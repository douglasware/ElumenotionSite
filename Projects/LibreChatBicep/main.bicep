param appSuffix string = uniqueString(resourceGroup().id)
param containerAppEnvrionmentName string = 'managedEnvironment-${appSuffix}'
param location string = resourceGroup().location
param openAiService_location string = 'swedencentral'
param storeAdminAuthTenantId string = subscription().tenantId
param mongoexpress_appRegistration_Guid string = newGuid()
param createMonogexpressAuthConfig bool = false

provider microsoftGraph

resource logAnalyticsWorkspace 'Microsoft.OperationalInsights/workspaces@2023-09-01' = {
  name: 'log-analytics-${appSuffix}'
  location: location
  properties: {
    sku: {
      name: 'PerGB2018'
    }
  }
}

resource storageAccount 'Microsoft.Storage/storageAccounts@2023-04-01' = {
  name: 'storage${appSuffix}'
  location: location
  sku: {
    name: 'Standard_RAGRS'
  }
  kind: 'StorageV2'
  properties: {
    dnsEndpointType: 'Standard'
    defaultToOAuthAuthentication: false
    publicNetworkAccess: 'Enabled'
    allowCrossTenantReplication: false
    minimumTlsVersion: 'TLS1_2'
    allowBlobPublicAccess: false
    allowSharedKeyAccess: true
    largeFileSharesState: 'Enabled'
    networkAcls: {
      bypass: 'AzureServices'
      virtualNetworkRules: []
      ipRules: []
      defaultAction: 'Allow'
    }
    supportsHttpsTrafficOnly: true
    encryption: {
      requireInfrastructureEncryption: false
      services: {
        file: {
          keyType: 'Account'
          enabled: true
        }
        blob: {
          keyType: 'Account'
          enabled: true
        }
      }
      keySource: 'Microsoft.Storage'
    }
    accessTier: 'Hot'
  }
}

// Create a file service for librechat-config and mongodb
resource storageAccount_fileService 'Microsoft.Storage/storageAccounts/fileServices@2023-04-01' = {
  parent: storageAccount
  name: 'default'
  properties: {
    protocolSettings: {
      smb: {}
    }
    cors: {
      corsRules: []
    }
    shareDeleteRetentionPolicy: {
      enabled: true
      days: 7
    }
  }
}

// librechat-config file share
resource librechatConfig_fileShare 'Microsoft.Storage/storageAccounts/fileServices/shares@2023-04-01' = {
  parent: storageAccount_fileService
  name: 'librechat-config'
  properties: {
    accessTier: 'Hot'
    shareQuota: 102400
    enabledProtocols: 'SMB'
  }
}

var rawLibrechatConfig = loadTextContent('../librechat.yaml')
var updatedLibrechatConfig = replace(replace(rawLibrechatConfig,
    'openai-key', openAiService.listKeys().key1),
    'openai-instance-name', openAiService.name)

// Upload librechat.yaml to librechat-config file share
resource uploadLibrechatConfig_deploymentScript 'Microsoft.Resources/deploymentScripts@2023-08-01' = {
  name: 'upload-librechat-config-${appSuffix}'
  location: location
  kind: 'AzureCLI'
  properties: {
    azCliVersion: '2.59.0'
    timeout: 'PT5M'
    retentionInterval: 'PT1H'
    environmentVariables: [
      {
        name: 'AZURE_STORAGE_ACCOUNT'
        value: storageAccount.name
      }
      {
        name: 'AZURE_STORAGE_KEY'
        secureValue: storageAccount.listKeys().keys[0].value
      }
      {
        name: 'CONTENT'
        value: updatedLibrechatConfig
      }
    ]
    scriptContent: 'echo "$CONTENT" > librechat.yaml && az storage file upload --source librechat.yaml -s ${librechatConfig_fileShare.name}'
  }
}

// mongodb file share
resource mongodb_fileShare 'Microsoft.Storage/storageAccounts/fileServices/shares@2023-04-01' = {
  parent: storageAccount_fileService
  name: 'mongodb'
  properties: {
    accessTier: 'Hot'
    shareQuota: 102400
    enabledProtocols: 'SMB'
  }
}

resource openAiService 'Microsoft.CognitiveServices/accounts@2023-10-01-preview' = {
  name: 'openai-${appSuffix}'
  location: openAiService_location
  sku: {
    name: 'S0'
  }
  kind: 'OpenAI'
  properties: {
    customSubDomainName: 'openai-${appSuffix}'
    networkAcls: {
      defaultAction: 'Allow'
      virtualNetworkRules: []
      ipRules: []
    }
    publicNetworkAccess: 'Enabled'
  }
}

var models = loadJsonContent('./models.json').models

// Loop over each model in the loaded JSON and create a resource for it
@batchSize(1) // Ensure that the deployment is executed sequentially
resource openAiModels 'Microsoft.CognitiveServices/accounts/deployments@2023-10-01-preview' = [for (model, i) in models: {
  parent: openAiService
  name: model.deploymentName
  sku: {
    name: 'Standard' // Assuming the SKU is "Standard" for all models; adjust as needed
    capacity: model.capacity
  }
  properties: {
    model: {
      format: 'OpenAI'
      name: model.modelName
      version: model.version
    }
    versionUpgradeOption: 'OnceNewDefaultVersionAvailable'
    currentCapacity: model.capacity
    raiPolicyName: 'Microsoft.Default'
  }
}]

resource containerAppEnvironment 'Microsoft.App/managedEnvironments@2023-11-02-preview' = {
  name: containerAppEnvrionmentName
  location: location
  properties: {
    appLogsConfiguration: {
      destination: 'log-analytics'
      logAnalyticsConfiguration: {
        customerId: logAnalyticsWorkspace.properties.customerId
        sharedKey: logAnalyticsWorkspace.listKeys().primarySharedKey
      }
    }
    zoneRedundant: false
    kedaConfiguration: {}
    daprConfiguration: {}
    customDomainConfiguration: {}
    workloadProfiles: [
      {
        workloadProfileType: 'Consumption'
        name: 'Consumption'
      }
    ]
    peerAuthentication: {
      mtls: {
        enabled: false
      }
    }
  }
}

resource librechatConfig_environmentStorage 'Microsoft.App/managedEnvironments/storages@2023-11-02-preview' = {
  parent: containerAppEnvironment
  name: 'librechat-config'
  properties: {
    azureFile: {
      accountName: storageAccount.name
      shareName: 'librechat-config'
      accessMode: 'ReadWrite'
      accountKey: storageAccount.listKeys().keys[0].value
    }
  }
}

resource mongodb_environmentStorage 'Microsoft.App/managedEnvironments/storages@2023-11-02-preview' = {
  parent: containerAppEnvironment
  name: 'mongodb'
  properties: {
    azureFile: {
      accountName: storageAccount.name
      shareName: 'mongodb'
      accessMode: 'ReadWrite'
      accountKey: storageAccount.listKeys().keys[0].value
    }
  }
}

resource mongodb_containerApp 'Microsoft.App/containerApps@2023-08-01-preview' = {
  name: 'mongodb-${appSuffix}'
  location: location
  properties: {
    managedEnvironmentId: containerAppEnvironment.id
    configuration: {
      ingress: {
        external: false
        transport: 'tcp'
        targetPort: 27017
        exposedPort: 27017
        traffic: [
          {
            latestRevision: true
            weight: 100
          }
        ]
      }
    }
    template: {
      containers: [
        {
          name: 'mongodb-${appSuffix}'
          image: 'bitnami/mongodb:7.0.7'
          resources: {
            cpu: json('1.0')
            memory: '2Gi'
          }
          env: [
            {
              name: 'MONGODB_ROOT_USER'
              value: 'root'
            }
            {
              name: 'MONGODB_ROOT_PASSWORD'
              value: 'password'
            }
          ]
          volumeMounts: [
            {
              volumeName: 'mongodb'
              mountPath: '/bitnami/mongodb'
            }
          ]
        }
      ]
      scale: {
        minReplicas: 1
        maxReplicas: 1
      }
      volumes: [
        {
          storageType: 'AzureFile'
          name: 'mongodb'
          storageName: mongodb_environmentStorage.name
          mountOptions: 'dir_mode=0777,file_mode=0777,uid=1001,gid=1001,mfsymlinks'
        }
      ]
    }
  }
}

resource mongoexpress_containerApp 'Microsoft.App/containerApps@2023-08-01-preview' = {
  name: 'mongoexpress-${appSuffix}'
  location: location
  properties: {
    managedEnvironmentId: containerAppEnvironment.id
    configuration: {
      ingress: {
        external: true
        transport: 'http'
        targetPort: 8081
        traffic: [
          {
            latestRevision: true
            weight: 100
          }
        ]
      }
    }
    template: {
      containers: [
        {
          name: 'mongoexpress-${appSuffix}'
          image: 'mongo-express'
          resources: {
            cpu: json('1.0')
            memory: '2Gi'
          }
          env: [
            {
              name: 'ME_CONFIG_MONGODB_URL'
              value: 'mongodb://root:password@mongodb-${appSuffix}:27017'
            }
            {
              name: 'ME_CONFIG_MONGODB_ADMINUSERNAME'
              value: 'root'
            }
            {
              name: 'ME_CONFIG_MONGODB_ADMINPASSWORD'
              value: 'password'
            }
          ]
        }
      ]
      scale: {
        minReplicas: 1
        maxReplicas: 1
      }
    }
  }
}

resource mongoexpress_appRegistration 'Microsoft.Graph/applications@v1.0' = if (createMonogexpressAuthConfig) {
  uniqueName: 'mongoexpress-${appSuffix}'
  displayName: 'mongoexpress-${appSuffix}'
  signInAudience: 'AzureADMyOrg'
  web: {
    redirectUris: [
      'https://${mongoexpress_containerApp.properties.configuration.ingress.fqdn}/.auth/login/aad/callback'
    ]
    implicitGrantSettings: {
      enableIdTokenIssuance: true
      enableAccessTokenIssuance: false
    }
  }
  api: {
    acceptMappedClaims: false
    oauth2PermissionScopes: [
      {
        adminConsentDescription: 'Allow the application to access mongoexpress on behalf of the signed-in user.'
        adminConsentDisplayName: 'Access mongoexpress'
        id: mongoexpress_appRegistration_Guid
        isEnabled: true
        type: 'User'
        userConsentDescription: 'Allow the application to access mongoexpress on your behalf.'
        userConsentDisplayName: 'Access mongoexpress'
        value: 'user_impersonation'
      }
    ]
  }
}

resource mongoexpress_authConfig 'Microsoft.App/containerApps/authConfigs@2024-03-01' = if (createMonogexpressAuthConfig) {
  name: 'current'
  parent: mongoexpress_containerApp
  properties: {
    platform:{
      enabled: true
    }
    identityProviders: {
      azureActiveDirectory: {
        enabled: true
        registration: {
          clientId: mongoexpress_appRegistration.appId
          openIdIssuer: 'https://sts.windows.net/${storeAdminAuthTenantId}/v2.0'
        }
        validation: {
          allowedAudiences: [
            'api://${mongoexpress_appRegistration.appId}'
          ]
        }
      }
    }
  }
}

resource librechat_containerApp 'Microsoft.App/containerApps@2023-08-01-preview' = {
  name: 'librechat-${appSuffix}'
  location: location
  properties: {
    managedEnvironmentId: containerAppEnvironment.id
    configuration: {
      ingress: {
        external: true
        transport: 'http'
        targetPort: 3080
        traffic: [
          {
            latestRevision: true
            weight: 100
          }
        ]
      }
    }
    template: {
      containers: [
        {
          name: 'librechat-${appSuffix}'
          image: 'librechat/librechat:v0.7.3-rc'
          resources: {
            cpu: json('1.0')
            memory: '2Gi'
          }
          env: [
            {
              name: 'ASSISTANTS_MODELS'
              value: ''
            }
            {
              name: 'HELP_AND_FAQ_URL'
              value: 'https://librechat.ai'
            }
            {
              name: 'ENDPOINTS'
              value: 'assistants,azureOpenAI'
            }
            {
              name: 'DOMAIN_CLIENT'
              value: 'http://localhost:3080'
            }
            {
              name: 'DOMAIN_SERVER'
              value: 'http://localhost:3080'
            }
            {
              name: 'DEBUG_LOGGING'
              value: 'true'
            }
            {
              name: 'DEBUG_CONSOLE'
              value: 'true'
            }
            {
              name: 'CONFIG_PATH'
              value: '/app/config-env/librechat.yaml'
            }
            {
              name: 'MONGO_URI'
              value: 'mongodb://mongodb-${appSuffix}:27017/LibreChat'
            }
            {
              name: 'CREDS_KEY'
              value: 'f34be427ebb29de8d88c107a71546019685ed8b241d8f2ed00c3df97ad2566f0'
            }
            {
              name: 'CREDS_IV'
              value: 'e2341419ec3dd3d19b13a1a87fafcbfb'
            }
            {
              name: 'JWT_SECRET'
              value: '16f8c0ef4a5d391b26034086c628469d3f9f497f08163ab9b40137092f2909ef'
            }
            {
              name: 'JWT_REFRESH_SECRET'
              value: 'eaa5191f2914e30b9387fd84e254e4ba6fc51b4654968a9b0803b456a54b8418'
            }
            {
              name: 'ALLOW_EMAIL_LOGIN'
              value: 'true'
            }
            {
              name: 'ALLOW_REGISTRATION'
              value: 'true'
            }
            {
              name: 'SESSION_EXPIRY'
              value: '1000 * 60 * 15'
            }
            {
              name: 'REFRESH_TOKEN_EXPIRY'
              value: '(1000 * 60 * 60 * 24) * 7'
            }
            {
              name: 'DEBUG_OPENAI'
              value: 'true'
            }
            {
              name: 'CUSTOM_FOOTER'
              value: 'ChatGPT can make mistakes. Check important info.'
            }
          ]
          volumeMounts: [
            {
              volumeName: 'librechat-config'
              mountPath: '/app/config-env/'
            }
          ]
        }
      ]
      scale: {
        minReplicas: 1
        maxReplicas: 1
      }
      volumes: [
        {
          storageType: 'AzureFile'
          name: 'librechat-config'
          storageName: librechatConfig_environmentStorage.name
          mountOptions: 'dir_mode=0777,file_mode=0777,uid=1001,gid=1001,mfsymlinks'
        }
      ]
    }
  }
}

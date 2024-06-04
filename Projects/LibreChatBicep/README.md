## Tools and Configuration Setup

Make sure you have [installed Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli) and [are signed in to your Azure account](https://learn.microsoft.com/en-us/cli/azure/authenticate-azure-cli). If you already have Azure CLI installed, run the `az bicep upgrade` command to ensure you're on the latest version of Bicep.

### librechat.yaml
The `librechat.yaml` file should be located in the parent directory of the `main.bicep` script. To properly configure the `librechat.yaml` as part of the Bicep deployment, create an OpenAI group named `"openai"`, and set the `apiKey` to `"openai-key"` and the `instanceName` to `"openai-instance-name"`.
```yaml
endpoints:
  azureOpenAI:
    (...)
    groups:
    - group: "openai"
      apiKey: "openai-key"
      instanceName: "openai-instance-name"
      forcePrompt: false
      assistants: true
      models:
        gpt-4-turbo:
          deploymentName: gpt-4-turbo
          version: "2024-02-15-preview"
        gpt-3.5-turbo-16k:
          deploymentName: gpt-35-turbo-16k
          version: "2024-02-15-preview"
```

### models.json
The `models.json` file should be located in the same directory of the `main.bicep` script. Configure the `modelName`, `version`, and `capacity` for each model based on the desired [models available in Azure OpenAI Service](https://learn.microsoft.com/en-us/azure/ai-services/openai/concepts/models). Ensure the `deploymentName` for each model matches the `deploymentName` parameter in your `librechat.yaml` file.

```json
{
  "models": [
    {
      "deploymentName": "gpt-4-turbo",
      "modelName": "gpt-4",
      "version": "turbo-2024-04-09",
      "capacity": 75
    },
    {
      "deploymentName": "gpt-35-turbo-16k",
      "modelName": "gpt-35-turbo-16k",
      "version": "0613",
      "capacity": 150
    }
  ]
}
```

## Deployment Instructions

To get a list of available location names for deployment, use the `az account list-locations` command and use the given `name` property when referencing that location.

To ensure compatibility and availability of OpenAI models in your selected region, consult the [Model Summary Table and Region Availability guide](https://learn.microsoft.com/en-us/azure/ai-services/openai/concepts/models#model-summary-table-and-region-availability). This provides detailed information on which AI models are available in specific OpenAI service regions.

### Provisioning a New Resource Group

To provision a new resource group and deploy resources to it, use the following command. Replace `your_region` with your preferred Azure location, `resource_group_name` with your desired resource group name, and `openai_service_region` with the OpenAI service region that supports the models you need.

```bash
az deployment sub create --name librechat --location your_region --template-file .\rg.bicep --parameters resourcegroup=resource_group_name location=your_region openAiService_location=openai_service_region
```
If you accidentally deploy to the wrong region or want to deploy this script across multiple regions, you might get the following error:
```
{"code": "InvalidDeploymentLocation", "message": "Invalid deployment location 'westeurope'. The deployment 'librechat' already exists in location 'eastus'."}
```
To fix this, change the `--name` parameter in the command from `librechat` to something else, eg. `librechat2`.

### Deploying to an Existing Resource Group

For deploying resources to an existing resource group, execute the command below. Replace `resource_group_name` with the name of your existing resource group and `openai_service_region` with the appropriate OpenAI service region.

```bash
az deployment group create --resource-group resource_group_name --template-file .\main.bicep --parameters openAiService_location=openai_service_region createMonogexpressAuthConfig=true
```

The `createMonogexpressAuthConfig` parameter will automatically setup a Microsoft identity provider for mongo-express. Remove this parameter or set it to false if you don't want this.
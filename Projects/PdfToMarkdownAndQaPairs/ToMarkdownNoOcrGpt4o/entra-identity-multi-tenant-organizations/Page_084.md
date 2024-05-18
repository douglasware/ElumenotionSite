## PATCH
`https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationPartnerConfiguration`

```json
{
    "inboundTrust": {
        "isMfaAccepted": true,
        "isCompliantDeviceAccepted": true,
        "isHybridAzureADJoinedDeviceAccepted": true
    },
    "automaticUserConsentSettings": {
        "inboundAllowed": true,
        "outboundAllowed": true
    },
    "templateApplicationLevel": ""
}
```

## Reset the template

To reset the template to its default state (decline all trust and automatic user consent), use the `multiTenantOrganizationPartnerConfigurationTemplate: resetToDefaultSettings` API.

### HTTP
`POST https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationPartnerConfiguration/resetToDefaultSettings`


## Cross-tenant synchronization template

The identity synchronization policy governs cross-tenant synchronization, which allows you to share users and groups across tenants in your organization. You can use these settings to allow inbound user synchronization. With the template in an unconfigured state, the identity synchronization policy for partner tenants in the multitenant organization won't be amended. However, if you configure the template, then the identity synchronization policy will be amended corresponding to the policy template.


### Configure inbound user synchronization

To allow inbound user synchronization in the policy template, use the `Update multiTenantOrganizationIdentitySyncPolicyTemplate` API. If you create or join a
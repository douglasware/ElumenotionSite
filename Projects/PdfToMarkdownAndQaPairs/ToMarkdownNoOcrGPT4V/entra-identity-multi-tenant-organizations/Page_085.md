## Request

```HTTP
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization
{
  "userSyncInbound": {
    "isSyncAllowed": true
  },
  "templateApplicationLevel": "newPartners,existingPartners"
}
```

## Disable the template for existing partners

To apply this template only to new multitenant organization members and exclude existing partners, set the `templateApplicationLevel` parameter to new partners only.

### Request

```HTTP
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization
{
  "userSyncInbound": {
    "isSyncAllowed": true
  },
  "templateApplicationLevel": "newPartners"
}
```

## Disable the template completely

To disable the template completely, set the `templateApplicationLevel` parameter to null.

### Request

```HTTP
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization
{
  "userSyncInbound": {
    "isSyncAllowed": true
  },
  "templateApplicationLevel": null
}
```
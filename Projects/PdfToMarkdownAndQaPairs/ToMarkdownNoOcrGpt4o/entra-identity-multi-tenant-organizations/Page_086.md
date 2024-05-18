## PATCH
`https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization`

```json
{
    "userSyncInbound": {
        "isSyncAllowed": true
    },
    "templateApplicationLevel": ""
}
```

## Reset the template

To reset the template to its default state (decline inbound synchronization), use the [multiTenantOrganizationIdentitySyncPolicyTemplate: resetToDefaultSettings](https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization/resetToDefaultSettings) API.

### Request

| HTTP  |
|-------|
| POST  |
| `https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization/resetToDefaultSettings` |

## Next steps

- [Configure cross-tenant synchronization](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/cross-tenant-synchronization)
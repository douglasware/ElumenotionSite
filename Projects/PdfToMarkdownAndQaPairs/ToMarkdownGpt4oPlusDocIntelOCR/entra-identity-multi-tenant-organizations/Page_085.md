multitenant organization using the Microsoft 365 admin center, this configuration is handled automatically.

Request

<figure>

Figure: HTTP PATCH request to enable identity synchronization for both new and existing partners

```
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/ multiTenantOrganizationIdentitySynchronization
{
    "userSyncInbound": {
        "isSyncAllowed": true
    },
    "templateApplicationLevel": "newPartners,existingPartners"
}
```
</figure>


# Disable the template for existing partners

To apply this template only to new multitenant organization members and exclude existing partners, set the templateApplicationLevel parameter to new partners only.

Request

<figure>

Figure: HTTP PATCH request to enable identity synchronization for new partners only

```
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/ multiTenantOrganizationIdentitySynchronization
{
    "userSyncInbound": {
        "isSyncAllowed": true
    },
    "templateApplicationLevel": "newPartners"
}
```
</figure>


# Disable the template completely

To disable the template completely, set the templateApplicationLevel parameter to null.

Request
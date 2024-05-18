PATCH

https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/ multiTenantOrganizationIdentitySynchronization

{ "userSyncInbound": { "isSyncAllowed": true }, "templateApplicationLevel": "" }


# Reset the template

To reset the template to its default state (decline inbound synchronization), use the multiTenantOrganizationIdentitySyncPolicyTemplate: resetToDefaultSettings API.


# Request

HTTP

POST

https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/templates/ multiTenantOrganizationIdentitySynchronization/resetToDefaultSettings


# Next steps

· Configure cross-tenant synchronization

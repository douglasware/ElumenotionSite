<figure>

![](figures/0)

</figure>


Owner tenant
===

You delete a multitenant organization by removing all tenants. The process for removing the final owner tenant is the same as the process for removing all other member tenants.

PowerShell

. In the final owner tenant, use the Remove- MgBetaTenantRelationshipMultiTenantOrganization Tenant command to remove the tenant. This operation takes a few minutes.

PowerShell

Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant - MultiTenantOrganizationMemberId $OwnerTenantId


## Next steps

· Set up a multitenant org in Microsoft 365

· Synchronize users in multitenant organizations in Microsoft 365

. The new Microsoft Teams desktop client

. Configure multitenant organization templates using the Microsoft Graph API

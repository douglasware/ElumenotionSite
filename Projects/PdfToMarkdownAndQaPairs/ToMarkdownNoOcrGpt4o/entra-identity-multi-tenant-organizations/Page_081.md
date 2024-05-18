## Owner tenant

You delete a multitenant organization by removing all tenants. The process for removing the final owner tenant is the same as the process for removing all other member tenants.

### PowerShell

- In the final owner tenant, use the [Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.tenantrelationships/remove-mgbetatenantrelationshipmultitenantorganizationtenant?view=graph-powershell-beta) command to remove the tenant. This operation takes a few minutes.

```powershell
Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId $OwnerTenantId
```

## Next steps

- [Set up a multitenant org in Microsoft 365](https://learn.microsoft.com/en-us/microsoft-365/enterprise/set-up-multitenant-org)
- [Synchronize users in multitenant organizations in Microsoft 365](https://learn.microsoft.com/en-us/microsoft-365/enterprise/synchronize-users)
- [The new Microsoft Teams desktop client](https://aka.ms/GetTeams)
- [Configure multitenant organization templates using the Microsoft Graph API](https://learn.microsoft.com/en-us/graph/api/resources/multitenantorganization?view=graph-rest-beta)
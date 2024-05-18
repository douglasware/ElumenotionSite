## Tenant Information

### Berlin Tenant

| Property              | Value                  |
|-----------------------|------------------------|
| AddedByTenantId       | `<OwnerTenantId>`      |
| AddedDateTime         | 1/8/2024 8:05:25 PM    |
| DeletedDateTime       |                        |
| DisplayName           | Berlin                 |
| Id                    | `<MtoIdB>`             |
| JoinedDateTime        |                        |
| Role                  | member                 |
| State                 | pending                |
| TenantId              | `<MemberTenantIdB>`    |
| TransitionDetails     |                        |
| AdditionalProperties  | `{[multiTenantOrgLabelType, none]}` |

### Athens Tenant

| Property              | Value                  |
|-----------------------|------------------------|
| AddedByTenantId       | `<OwnerTenantId>`      |
| AddedDateTime         | 1/8/2024 8:08:47 PM    |
| DeletedDateTime       |                        |
| DisplayName           | Athens                 |
| Id                    | `<MtoIdA>`             |
| JoinedDateTime        |                        |
| Role                  | member                 |
| State                 | pending                |
| TenantId              | `<MemberTenantIdA>`    |
| TransitionDetails     |                        |
| AdditionalProperties  | `{[multiTenantOrgLabelType, none]}` |

## Step 4: (Optional) Change the role of a tenant

### Owner Tenant

By default, tenants added to the multitenant organization are member tenants. Optionally, you can change them to owner tenants, which allow them to add other tenants to the multitenant organization. You can also change an owner tenant to a member tenant.

```PowerShell
# In the owner tenant, use the following command to change a member tenant to an owner tenant:
Update-MgBetaTenantRelationshipMultiTenantOrganizationTenant
```
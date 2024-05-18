## Update Command

```plaintext
Update-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId $MemberTenantIdB -Role "Owner" | Format-List
```

## Verification Command

```plaintext
Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId $MemberTenantIdB | Format-List
```

### Output

| Field                           | Value                           |
|---------------------------------|---------------------------------|
| AddedByTenantId                 | \<OwnerTenantId\>               |
| AddedDateTime                   | 1/8/2024 8:05:25 PM             |
| DeletedDateTime                 |                                 |
| DisplayName                     | Berlin                          |
| Id                              | \<MtoIdB\>                      |
| JoinedDateTime                  |                                 |
| Role                            | owner                           |
| State                           | pending                         |
| TenantId                        | \<MemberTenantIdB\>             |
| TransitionDetails               | See TransitionDetails below     |

### TransitionDetails

Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails
**AdditionalProperties:**  
- [odata.context](https://graph.microsoft.com/beta/$metadata#tenantRelationships/multiTenantOrganization/tenants/$entity)
  - multiTenantOrgLabelType, none

## Step 5: (Optional) Remove a member tenant

### Owner Tenant Instructions

You can remove any member tenant, including your own. You can't remove owner tenants. Also, you can't remove the original creator tenant, even if it has been changed from owner to member.

```plaintext
<Insert Remove Command Here>
```
## Step 3: Add tenants

### Owner tenant

1. In the owner tenant, use the [New-MgBetaTenantRelationshipMultiTenantOrganizationTenant](https://link) command to add tenants to your multitenant organization.

```powershell
New-MgBetaTenantRelationshipMultiTenantOrganizationTenant -TenantID $MemberTenantIdB -DisplayName "Berlin" | Format-List
```

```powershell
New-MgBetaTenantRelationshipMultiTenantOrganizationTenant -TenantID $MemberTenantIdA -DisplayName "Athens" | Format-List
```

2. Use the [Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant](https://link) command to verify that the operation has completed before proceeding.

```powershell
Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant | Format-List
```

**Output:**

| Field                 | Value                                                                                 |
|-----------------------|---------------------------------------------------------------------------------------|
| AddedByTenantId       | <OwnerTenantId>                                                                        |
| AddedDateTime         | 1/8/2024 7:47:45 PM                                                                    |
| DeletedDateTime       |                                                                                       |
| DisplayName           | Cairo                                                                                 |
| Id                    | <MtoIdC>                                                                              |
| JoinedDateTime        |                                                                                       |
| Role                  | owner                                                                                 |
| State                 | active                                                                                |
| TenantId              | <OwnerTenantId>                                                                        |
| TransitionDetails     | Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails |
| AdditionalProperties  | {{multiTenantOrgLabelType, none}}                                                     |

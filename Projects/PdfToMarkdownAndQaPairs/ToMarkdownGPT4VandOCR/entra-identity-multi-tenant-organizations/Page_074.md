## Step 3: Add tenants

### Owner tenant

#### PowerShell

1. In the owner tenant, use the `New-MgBetaTenantRelationshipMultiTenantOrganizationTenant` command to add tenants to your multitenant organization.

```plaintext
New-MgBetaTenantRelationshipMultiTenantOrganizationTenant -TenantID $MemberTenantIdB -DisplayName "Berlin" | Format-List

New-MgBetaTenantRelationshipMultiTenantOrganizationTenant -TenantID $MemberTenantIdA -DisplayName "Athens" | Format-List
```

2. Use the `Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant` command to verify that the operation has completed before proceeding.

```plaintext
Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant | Format-List
```

#### Output

| AddedByTenantId  | `<OwnerTenantId>`       |
|------------------|-------------------------|
| AddedDateTime    | 1/8/2024 7:47:45 PM     |
| DeletedDateTime  |                         |
| DisplayName      | Cairo                   |
| Id               | `<MtoIdC>`              |
| JoinedDateTime   |                         |
| Role             | owner                   |
| State            | active                  |
| TenantId         | `<OwnerTenantId>`       |
| TransitionDetails| Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails |
| AdditionalProperties | {[multiTenantOrgLabelType, none]} |
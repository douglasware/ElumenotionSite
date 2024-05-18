## PowerShell

### Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest | Format-List

#### Output

```
AddedByTenantId         : <OwnerTenantId>
Id                      : <MtoJoinRequestIdB>
MemberState             : active
Role                    : member
TransitionDetails       : Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationJoinRequestTransitionDetails
AdditionalProperties    : {[@odata.context, https://graph.microsoft.com/beta/$metadata#tenantRelationships/multiTenantOrganization/joinRequest/$entity]}
```

### Use the Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant command to check the multitenant organization itself. It should reflect the join operation.

### PowerShell

### Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant | Format-List

#### Output

```
AddedByTenantId         : <OwnerTenantId>
AddedDateTime           : 1/8/2024 8:05:25 PM
DeletedDateTime         : 
DisplayName             : Berlin
Id                      : <MtoJoinRequestIdB>
JoinedDateTime          : 1/8/2024 9:53:55 PM
Role                    : member
State                   : active
TenantId                : <MemberTenantIdB>
TransitionDetails       : Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails
AdditionalProperties    : {[multiTenantOrgLabelType, none]}
```

```
AddedByTenantId         : <OwnerTenantId>
AddedDateTime           : 1/8/2024 7:47:45 PM
DeletedDateTime         : 
DisplayName             : Cairo
Id                      : <Id>
JoinedDateTime          : 
```
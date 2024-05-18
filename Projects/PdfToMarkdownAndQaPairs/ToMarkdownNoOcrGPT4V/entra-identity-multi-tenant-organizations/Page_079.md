## PowerShell Commands and Outputs

### 1. Command to get multi-tenant organization join request
```
Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest | Format-List
```

#### Output
```
AddedByTenantId      : <OwnerTenantId>
Id                   : <MtoJoinRequestIdB>
MemberState          : active
Role                 : member
TransitionDetails    : Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrg
                        anizationJoinRequestTransitionDetails
AdditionalProperties : {[@odata.context,
                        https://graph.microsoft.com/beta/$metadata#tenantRelationships/mult
                        iTenantOrganization/joinRequest/$entity]}
```

### 2. Command to get multitenant organization tenant details
```
Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant | Format-List
```

#### Output 1
```
AddedByTenantId      : <OwnerTenantId>
AddedDateTime        : 1/8/2024 8:05:25 PM
DeletedDateTime      :
DisplayName          : Berlin
Id                   : <MtoJoinRequestIdB>
JoinedDateTime       : 1/8/2024 9:53:55 PM
Role                 : member
State                : active
TenantId             : <MemberTenantIdB>
TransitionDetails    : Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrg
                        anizationMemberTransitionDetails
AdditionalProperties : {[@multiTenantOrgLabelType, none]}
```

#### Output 2
```
AddedByTenantId      : <OwnerTenantId>
AddedDateTime        : 1/8/2024 7:47:45 PM
DeletedDateTime      :
DisplayName          : Cairo
Id                   : <Id>
JoinedDateTime       :
```
<!-- PageHeader="PowerShell" -->

Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest Format-List

|||
| - | - |
| Output | |
| AddedByTenantId | : < OwnerTenantId> |
| Id | : < MtoJoinRequestIdB> |
| MemberState | : active |
| Role | : member |
| TransitionDetails | : |
| Microsoft. Graph. Beta. PowerShell. Models. MicrosoftGraphMultiTenantOrg anizationJoinRequestTransitionDetails ||
| AdditionalProperties : {[@odata.context, ||
| https://graph.microsoft.com/beta/$metadata#tenantRelationships/mult iTenantOrganization/joinRequest/$entity]} ||

3\. Use the Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant

command to check the multitenant organization itself. It should reflect the

join operation.

PowerShell

Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant | Format-

List

Output

AddedByTenantId

: < OwnerTenantId>

AddedDateTime

: 1/8/2024 8:05:25 PM

DeletedDateTime

:

DisplayName

: Berlin

Id

: < MtoJoinRequestIdB>

JoinedDateTime

: 1/8/2024 9:53:55 PM

Role

: member

State

: active

TenantId

: < MemberTenantIdB>

:

TransitionDetails

Microsoft. Graph. Beta. PowerShell. Models. MicrosoftGraphMultiTenantOrg

anizationMemberTransitionDetails

AdditionalProperties : {[multiTenantOrgLabelType, none]}

AddedByTenantId

: < OwnerTenantId>

AddedDateTime

: 1/8/2024 7:47:45 PM

DeletedDateTime

:

DisplayName

: Cairo

Id

: < Id>

JoinedDateTime

:

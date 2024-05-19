<!-- PageHeader="PowerShell" -->

Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest | Format-List

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

```mermaid
graph TD;
    subgraph Output
        A[AddedByTenantId: <OwnerTenantId>]
        B[Id: <MtoJoinRequestIdB>]
        C[MemberState: active]
        D[Role: member]
        E[TransitionDetails]
        F[Microsoft Graph Beta PowerShell Models MicrosoftGraphMultiTenantOrganizationJoinRequestTransitionDetails]
        G[AdditionalProperties: {{@odata.context, https://graph.microsoft.com/beta/$metadata#tenantRelationships/multiTenantOrganization/joinRequest/$entity}}]
    end
```

3. Use the Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant

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

```mermaid
graph TD;
    subgraph Output1[Output for Berlin]
        A1[AddedByTenantId: <OwnerTenantId>]
        B1[AddedDateTime: 1/8/2024 8:05:25 PM]
        C1[DeletedDateTime]
        D1[DisplayName: Berlin]
        E1[Id: <MtoJoinRequestIdB>]
        F1[JoinedDateTime: 1/8/2024 9:53:55 PM]
        G1[Role: member]
        H1[State: active]
        I1[TenantId: <MemberTenantIdB>]
        J1[TransitionDetails: Microsoft Graph Beta PowerShell Models MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails]
        K1[AdditionalProperties: {multiTenantOrgLabelType, none}]
    end

    subgraph Output2[Output for Cairo]
        A2[AddedByTenantId: <OwnerTenantId>]
        B2[AddedDateTime: 1/8/2024 7:47:45 PM]
        C2[DeletedDateTime]
        D2[DisplayName: Cairo]
        E2[Id: <Id>]
        F2[JoinedDateTime]
    end
```
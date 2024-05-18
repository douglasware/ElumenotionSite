# Configure cross-tenant synchronization using PowerShell or Microsoft Graph API

Article · 04/23/2024

This article describes the key steps to configure cross-tenant synchronization using Microsoft Graph PowerShell or Microsoft Graph API. When configured, Microsoft Entra ID automatically provisions and de-provisions B2B users in your target tenant. For detailed steps using the Microsoft Entra admin center, see Configure cross-tenant synchronization.

<figure>

![](figures/0)

<!-- FigureContent="Source tenant Target tenant Internal Internal UserS1 UserS2 UserS3 UserT1 UserT2 UserT3 GroupT1 Outbound access settings :selected: > Automatically redeem invitations Cross-tenant synchronization External UserS1 UserS3 Configuration Inbound access settings :selected: Allow users sync into this tenant Scope :selected: Automatically redeem invitations UserS1 UserS3 Scoping filters department EQUALS Marketing Attribute mappings accountEnabled accountEnabled employeeld employeeld userPrincipalName userPrincipalName + extensionName companyName" -->

</figure>



# Prerequisites

<figure>

![](figures/1)

</figure>


Source tenant

· Microsoft Entra ID P1 or P2 license. For more information, see License requirements.

· Security Administrator role to configure cross-tenant access settings.

· Hybrid Identity Administrator role to configure cross-tenant synchronization.

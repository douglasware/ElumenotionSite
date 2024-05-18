$Params = @{ TenantId = $TargetTenantId } New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $Params Format-List

Output

AutomaticUserConsentSettings :

Microsoft. Graph. PowerShell.Models.MicrosoftGraphInboundOutboundPoli cyConfiguration

B2BCollaborationInbound

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyB2BSetting

B2BCollaborationOutbound :

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyB2BSetting B2BDirectConnectInbound . .

Microsoft. Graph. PowerShell. Models.MicrosoftGraphCrossTenantAccessPo licyB2BSetting

B2BDirectConnectOutbound :

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyB2BSetting

IdentitySynchronization :

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantIdentity SyncPolicyPartner

InboundTrust .

Microsoft. Graph. PowerShell.Models.MicrosoftGraphCrossTenantAccessPo licyInboundTrust

IsServiceProvider : TenantId : < TargetTenantId>

TenantRestrictions :

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyTenantRestrictions

AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAcce ssPolicy/partners/$entity],

[crossCloudMeetingConfiguration,

System. Collections. Generic. Dictionary 2[System.String, System. Object 1], [protectedContentSharing,

System. Collections. Generic.Dictionary\` 2[System.String, System. Object ]]}

2\. Use the Update-MgPolicyCross TenantAccessPolicyPartner command to automatically redeem invitations and suppress consent prompts for outbound access.

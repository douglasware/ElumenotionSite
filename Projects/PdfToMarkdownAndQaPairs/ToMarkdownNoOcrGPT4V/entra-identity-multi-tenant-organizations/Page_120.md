## Tenant Access Policy Script Execution

### Commands and Outputs

Run PowerShell command with parameters:

```
$Params = @{
    TenantId = $TargetTenantId
}
New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $Params | Format-List
```

Output display structure:

```
AutomaticUserConsentSettings :
    Microsoft.Graph.PowerShell.Models.MicrosoftGraphInboundOutboundPolicyConfiguration
    B2BCollaborationInbound :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting
    B2BCollaborationOutbound :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting
    B2BDirectConnectInbound :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting
    B2BDirectConnectOutbound :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting
    IdentitySynchronization :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantIdentity
    SyncPolicyPartner
    InboundTrust
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyInboundTrust
    IsServiceProvider : 
    TenantId : <TargetTenantId>
    TenantRestrictions :
        Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTenantRestrictions
    AdditionalProperties :
        [{@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAccessPolicy/partners/$entity},
         {crossCloudMeetingConfiguration, System.Collections.Generic.Dictionary`2[System.String,System.Object]},
         {protectedContentSharing, System.Collections.Generic.Dictionary`2[System.String,System.Object]}]
```

### Redeem Invitations Command

Use this command to automatically redeem invitations and suppress consent prompts for outbound access:

```
Update-MgPolicyCrossTenantAccessPolicyPartner
```
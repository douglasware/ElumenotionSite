## PowerShell Command Usage

```powershell
$Params = @{
    TenantId = $TargetTenantId
}
New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $Params | Format-List
```

## Output

### AutomaticUserConsentSettings

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphInboundOutboundPolicyConfiguration

### B2BCollaborationInbound

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting

### B2BCollaborationOutbound

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting

### B2BDirectConnectInbound

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting

### B2BDirectConnectOutbound

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyB2BSetting

### IdentitySynchronization

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantIdentitySyncPolicyPartner

### InboundTrust

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyInboundTrust

### IsServiceProvider

- **Value**: Not Specified

### TenantId

- **Value**: <TargetTenantId>

### TenantRestrictions

- **Type**: Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTenantRestrictions

### AdditionalProperties

- **[@odata.context]**: `https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAccessPolicy/partners/$entity`
- **[crossCloudMeetingConfiguration]**: Dictionary<string, object>
- **[protectedContentSharing]**: Dictionary<string, object>

## Instructions

### Updating CrossTenantAccessPolicyPartner

Use the **Update-MgPolicyCrossTenantAccessPolicyPartner** command to automatically redeem invitations and suppress consent prompts for outbound access.
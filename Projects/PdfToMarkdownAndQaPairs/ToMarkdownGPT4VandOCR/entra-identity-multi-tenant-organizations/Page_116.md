## Step 2: Enable user synchronization in the target tenant

### Target tenant

#### PowerShell

1. In the target tenant, use the `New-MgPolicyCrossTenantAccessPolicyPartner` command to create a new partner configuration in a cross-tenant access policy between the target tenant and the source tenant. Use the source tenant ID in the request.

If you get the error `New-MgPolicyCrossTenantAccessPolicyPartner_Create: Another object with the same value for property tenantId already exists`, you might already have an existing configuration. For more information, see Symptom - New-MgPolicyCrossTenantAccessPolicyPartner_Create error.

```powershell
$Params = @{
    TenantId = $SourceTenantId
}
New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $Params | Format-List
```

#### Output

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
```
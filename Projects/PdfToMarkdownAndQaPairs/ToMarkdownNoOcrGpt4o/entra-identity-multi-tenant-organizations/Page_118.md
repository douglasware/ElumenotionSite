## Step 3: Automatically redeem invitations in the target tenant

### Target tenant

1. In the target tenant, use the [Update-MgPolicyCrossTenantAccessPolicyPartner](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicycrosstenantaccesspolicypartner?view=graph-powershell-beta) command to automatically redeem invitations and suppress consent prompts for inbound access.

```PowerShell
$AutomaticUserConsentSettings = @{
    "InboundAllowed"="True"
}
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $sourceTenantId -AutomaticUserConsentSettings $AutomaticUserConsentSettings
```

## Step 4: Sign in to the source tenant

### Source tenant

1. Start an instance of PowerShell.

2. Get the tenant ID of the source and target tenants and initialize variables.
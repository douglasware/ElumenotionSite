| IsSyncAllowed   |
|-----------------|
| True            |

## Step 3: Automatically redeem invitations in the target tenant

### Target tenant

```PowerShell
# In the target tenant, use the following command to automatically redeem invitations and suppress consent prompts for inbound access:
$AutomaticUserConsentSettings = @{
    "InboundAllowed"="True"
}
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $sourceTenantId -AutomaticUserConsentSettings $AutomaticUserConsentSettings
```

## Step 4: Sign in to the source tenant

### Source tenant

```PowerShell
# Start an instance of PowerShell.
# Get the tenant ID of the source and target tenants and initialize variables.
```
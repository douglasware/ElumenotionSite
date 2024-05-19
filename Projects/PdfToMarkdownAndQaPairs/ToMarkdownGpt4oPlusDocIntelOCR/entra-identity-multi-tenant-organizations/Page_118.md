<!-- PageHeader="IsSyncAllowed" -->

IsSyncAllowed
-------------
True

Step 3: Automatically redeem invitations in the target tenant
===

![Diagram of the target tenant setup process](figures/0)

```mermaid
graph TD;
    TargetTenant["Target Tenant"] --> SetupProcess["Setup Process"]
```

Target tenant

PowerShell

1\. In the target tenant, use the Update-MgPolicyCrossTenantAccessPolicyPartner command to automatically redeem invitations and suppress consent prompts for inbound access.

PowerShell

$AutomaticUserConsentSettings = @{ "InboundAllowed"="True"

} Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId -AutomaticUserConsentSettings $AutomaticUserConsentSettings

## Step 4: Sign in to the source tenant

![Diagram of signing in to the source tenant](figures/1)

```mermaid
graph TD;
    SourceTenant["Source Tenant"] --> SignInProcess["Sign-in Process"]
```

Source tenant

PowerShell

1\. Start an instance of PowerShell.

2\. Get the tenant ID of the source and target tenants and initialize variables.
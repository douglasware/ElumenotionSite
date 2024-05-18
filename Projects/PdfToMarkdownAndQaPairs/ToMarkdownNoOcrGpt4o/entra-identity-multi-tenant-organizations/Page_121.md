## Step 6: Create a configuration application in the source tenant

### Source tenant

```powershell
$AutomaticUserConsentSettings = @{
    "OutboundAllowed"="True"
}
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $TargetTenantId -AutomaticUserConsentSettings $AutomaticUserConsentSettings
```

1. In the source tenant, use the [Invoke-MgInstantiateApplicationTemplate](https://docs.microsoft.com/powershell/module/microsoft.graph.application/invoke-mginstantiateapplicationtemplate) command to add an instance of a configuration application from the Microsoft Entra application gallery into your tenant.

```powershell
Invoke-MgInstantiateApplicationTemplate -ApplicationTemplateId "518e5f48-1fc8-4c48-9387-9fdf28b0dfe7" -DisplayName "Fabrikam"
```

2. Use the [Get-MgServicePrincipal](https://docs.microsoft.com/powershell/module/microsoft.graph.application/get-mgserviceprincipal) command to get the service principal ID and app role ID.

```powershell
Get-MgServicePrincipal -Filter "DisplayName eq 'Fabrikam'" | Format-List
```

#### Output

| Property            | Value         |
|---------------------|---------------|
| AccountEnabled      | True          |
| AddIns              | {}            |
| AlternativeNames    | {}            |
| AppDescription      |               |
| AppDisplayName      | Fabrikam      |
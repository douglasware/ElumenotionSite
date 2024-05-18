## Step 1: Save credentials in the source tenant

### PowerShell
```powershell
$Params = @{
    "value" = @(
        @{
            "key" = "AuthenticationType"
            "value" = "SyncPolicy"
        }
        @{
            "key" = "CompanyId"
            "value" = $TargetTenantId
        }
    )
}
Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/servicePrincipals/$ServicePrincipalId/synchronization/secrets" -Body $Params
```

## Step 10: Assign a user to the configuration

### Source tenant

For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

### PowerShell
```powershell
$Params = @{
    PrincipalId = "<PrincipalId>"
    ResourceId = $ServicePrincipalId
    AppRoleId = $AppRoleId
}
```
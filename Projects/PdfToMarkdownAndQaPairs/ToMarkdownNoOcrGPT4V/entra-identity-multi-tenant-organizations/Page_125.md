## Step 10: Assign a user to the configuration

### Source tenant

For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

```PowerShell
$Params = @{
    "PrincipalId" = "<PrincipalId>"
    "ResourceId" = "<ServicePrincipalId>"
    "AppRoleId" = "<AppRoleId>"
}
Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/servicePrincipals/<ServicePrincipalId>/appRoleAssignments" -Body $Params
```
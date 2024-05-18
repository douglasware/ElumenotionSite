## Step 10: Assign a user to the configuration

### Source tenant

For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

1. In the source tenant, use the [New-MgServicePrincipalAppRoleAssignedTo](#) command to assign an internal user to the configuration.

```powershell
$Params = @{
    PrincipalId = "<PrincipalId>"
    ResourceId = $ServicePrincipalId
    AppRoleId = $AppRoleId
}
```
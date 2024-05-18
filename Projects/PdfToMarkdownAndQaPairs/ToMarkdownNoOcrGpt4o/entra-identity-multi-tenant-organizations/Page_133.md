## PowerShell

```powershell
$Params = @{
    userSyncInbound = @{
        isSyncAllowed = $true
    }
}
Set-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $sourceTenantId -BodyParameter $Params
```

## Next steps

- Microsoft Entra synchronization API overview
- Tutorial: Develop and plan provisioning for a SCIM endpoint in Microsoft Entra ID
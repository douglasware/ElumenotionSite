## SyncPolicyPartner
```
InboundTrust
  Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyInboundTrust
    IsServiceProvider :
    TenantId : <SourceTenantId>
TenantRestrictions
  Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTenantRestrictions
    AdditionalProperties :
      - [@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAccessPolicy/partners/$entity]
      - [crossCloudMeetingConfiguration, System.Collections.Generic.Dictionary`2[System.String,System.Object]]
      - [protectedContentSharing, System.Collections.Generic.Dictionary`2[System.String,System.Object]]
```

## Use the Invoke-MgGraphRequest command to enable user synchronization in the target tenant.

If you get an `Request_MultipleObjectsWithSameKeyValue` error, you might already have an existing policy. For more information, see Symptom - `Request_MultipleObjectsWithSameKeyValue` error.

### PowerShell
```
$Params = @{
    userSyncInbound = @{
        isSyncAllowed = $true
    }
}
Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/policies/crossTenantAccessPolicy/partners/$SourceTenantId/identitySynchronization" -Body $Params
```

## Use the Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization command to verify `IsSyncAllowed` is set to True.

### PowerShell
```
(Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId).UserSyncInbound
```

### Output
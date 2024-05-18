## SyncPolicyPartner
**InboundTrust:** Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyInboundTrust  
**IsServiceProvider:** :  
**TenantId:** `<SourceTenantId>`  
**TenantRestrictions:** Microsoft.Graph.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTenantRestrictions  
**AdditionalProperties:** `{[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAccessPolicy/partners/$entity], [crossCloudMeetingConfiguration, System.Collections.Generic.Dictionary\`2[System.String,System.Object]], [protectedContentSharing, System.Collections.Generic.Dictionary\`2[System.String,System.Object]]}`

### 2. Enable User Synchronization
Use the `Invoke-MgGraphRequest` command to enable user synchronization in the target tenant.

If you encounter an `Request_MultipleObjectsWithSameKeyValue` error, you might already have an existing policy. For more details, refer to Symptom - `Request_MultipleObjectsWithSameKeyValue` error.

```plaintext
$Params = @{
    userSyncInbound = @{
        isSyncAllowed = $true
    }
}
Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/policies/crossTenantAccessPolicy/partners/$SourceTenantId/identitySynchronization" -Body $Params
```

### 3. Verify User Synchronization Setting
Use the `Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization` command to confirm `IsSyncAllowed` is set to True.

```plaintext
(Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId).UserSyncInbound
```
SyncPolicyPartner InboundTrust :

Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyInboundTrust IsServiceProvider :

TenantId : < SourceTenantId> TenantRestrictions : Microsoft. Graph. PowerShell. Models. MicrosoftGraphCrossTenantAccessPo licyTenantRestrictions AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/crossTenantAcce ssPolicy/partners/$entity],

[crossCloudMeetingConfiguration,

System. Collections. Generic.Dictionary 2[System.String, System. Object 1], [protectedContentSharing,

System. Collections. Generic.Dictionary 2[System.String, System. Object ] ]}

2\. Use the Invoke-MgGraphRequest command to enable user synchronization in the target tenant.

If you get an Request\_MultipleObjectsWithSameKeyValue error, you might already have an existing policy. For more information, see Symptom - Request\_MultipleObjectsWithSameKeyValue error.

PowerShell

$Params = @{ userSyncInbound = @{ isSyncAllowed = $true }

} Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/policies/crossTenantAccessPolicy/ partners/$SourceTenantId/identitySynchronization" -Body $Params

3\. Use the Get-MgPolicyCrossTenantAccessPolicyPartnerldentitySynchronization command to verify IsSyncAllowed is set to True.

PowerShell

(Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId) . UserSyncInbound

Output

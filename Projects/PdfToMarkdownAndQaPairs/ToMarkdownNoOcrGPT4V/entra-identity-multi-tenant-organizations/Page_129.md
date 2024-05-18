## PowerShell

### Get-MgServicePrincipalSynchronizationJob

```powershell
Get-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId | Format-List
```

#### Output

```
Id                          : <JobId>
Schedule                    : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchedule
Schema                      : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchema
Status                      : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationStatus
SynchronizationJobSettings  : {AzureIngestionAttributeOptimization, LookaheadQueryEnabled}
TemplateId                  : Azure2Azure
AdditionalProperties        : {{@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('<ServicePrincipalId>')/synchronization/jobs/<entityId>}}
```

### Monitoring Status of Provisioning

#### Get-MgAuditLogProvisioning

```powershell
Get-MgAuditLogDirectoryAudit | Select -First 10 | Format-List
```

#### Output

```
ActivityDateTime       : 7/31/2023 12:08:17 AM
ActivityDisplayName    : Export
AdditionalDetails      : {Details, ErrorCode, EventName, ipaddr...}
Category               : ProvisioningManagement
CorrelationId          : cc519f3b-fb72-4ea2-9b7b-8f9dc271c5ec
Id                     : Sync_cc519f3b-fb72-4ea2-9b7b-8f9dc271c5ec_LSBFV_161778479
InitiatedBy            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAuditActivityInitiator1
LoggedByService        : Account Provisioning
OperationType          : Account Provisioning
Result                 : success
```
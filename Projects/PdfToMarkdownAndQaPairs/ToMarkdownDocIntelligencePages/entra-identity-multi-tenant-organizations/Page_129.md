<!-- PageHeader="PowerShell" -->

Get-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId | Format-List


# Output

Id : < JobId> Schedule : Microsoft. Graph. PowerShell. Models.MicrosoftGraphSynchronizationSche dule Schema .. Microsoft. Graph. PowerShell.Models.MicrosoftGraphSynchronizationSche ma Status :

Microsoft. Graph. PowerShell.Models.MicrosoftGraphSynchronizationStat us SynchronizationJobSettings : {AzureIngestionAttributeOptimization, LookaheadQueryEnabled} TemplateId : Azure2Azure AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('<Serv icePrincipalId>')/synchro nization/jobs/$entity]}

2\. In addition to monitoring the status of the provisioning job, use the Get- MgAuditLogProvisioning command to retrieve the provisioning logs and get all the provisioning events that occur. For example, query for a particular user and determine if they were successfully provisioned.

PowerShell

Get-MgAuditLogDirectoryAudit | Select -First 10| Format-List

|||
| - | - |
| Output | |
| ActivityDateTime | : 7/31/2023 12:08:17 AM |
| ActivityDisplayName | : Export |
| AdditionalDetails | : {Details, ErrorCode, EventName, ipaddr. . . } |
| Category | : ProvisioningManagement |
| CorrelationId | : cc519f3b-fb72-4ea2-9b7b-8f9dc271c5ec |
| Id | : Sync\_cc519f3b-fb72-4ea2-9b7b- |
| 8f9dc271c5ec\_L5BFV\_161778479 | |
| InitiatedBy | : |
|| Microsoft. Graph. PowerShell.Models.MicrosoftGraphAuditActivityInitia  |
| tor1 | |
| LoggedByService | : Account Provisioning |
| OperationType | : |
| Result | : success |

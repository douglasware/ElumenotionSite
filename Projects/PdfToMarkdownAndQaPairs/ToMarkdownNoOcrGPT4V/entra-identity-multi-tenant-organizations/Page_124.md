## Step 9: Save your credentials

### Source tenant

```PowerShell
# The PowerShell command to initiate provisioning job with pre-configured synchronization settings
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -TemplateId "Azure2Azure" | Format-List
```

### Output Information

```
Id                           : <JobId>
Schedule                     :
Schema                       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchema
Status                       :
SynchronizationJobSettings   : {AzureIngestionAttributeOptimization, LookaheadQueryEnabled}
TemplateId                   : Azure2Azure
AdditionalProperties         : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('ServicePrincipalId')/synchronization/jobs/$entity]}
```

### Initialize job ID

```PowerShell
$JobId = "<JobId>"
```
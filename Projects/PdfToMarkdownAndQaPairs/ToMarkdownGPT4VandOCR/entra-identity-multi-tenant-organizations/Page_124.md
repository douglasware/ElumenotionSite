## A template has pre-configured synchronization settings.

### 2. In the source tenant, use the `New-MgServicePrincipalSynchronizationJob` command to create a provisioning job based on a template.

```PowerShell
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -TemplateId "Azure2Azure" | Format-List
```

#### Output

```
Id                        : <JobId>
Schedule                  :
Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchedule
Schema                    :
Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchema
Status                    :
Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationStatus
SynchronizationJobSettings : {AzureIngestionAttributeOptimization, LookaheadQueryEnabled}
TemplateId                : Azure2Azure
AdditionalProperties      : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('<ServicePrincipalId>')/synchronization/jobs/$entity]}
```

### 3. Initialize a variable for the job ID.

```PowerShell
$JobId = "<JobId>"
```

## Step 9: Save your credentials

### Source tenant

```PowerShell
```
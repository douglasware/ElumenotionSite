A template has pre-configured synchronization settings.

2. In the source tenant, use the [New-MgServicePrincipalSynchronizationJob](https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/synchronizationjob_post) command to create a provisioning job based on a template.

```powershell
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -TemplateId "Azure2Azure" | Format-List
```

| Output                       |                                  |
| ---------------------------- | -------------------------------- |
| Id                           | : <JobId>                        |
| Schedule                     |                                  |
| Schema                       | : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationSchema |
| Status                       | : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSynchronizationStatus |
| SynchronizationJobSettings   | : {AzureIngestionAttributeOptimization, LookaheadQueryEnabled} |
| TemplateId                   | : Azure2Azure                    |
| AdditionalProperties         | : [[@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('<ServicePrincipalId>')/synchronization/jobs/$entity]]  |

3. Initialize a variable for the job ID.

```powershell
$JobId = "<JobId>"
```

## Step 9: Save your credentials

### Source tenant

```powershell
```
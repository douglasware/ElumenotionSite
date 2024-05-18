## Step 12: Start the provisioning job

### Source tenant

#### PowerShell

1. Now that the provisioning job is configured, in the source tenant, use the `Start-MgServicePrincipalSynchronizationJob` command to start the provisioning job.

```
Start-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId
```

## Step 13: Monitor provisioning 

### Source tenant

#### PowerShell

1. Now that the provisioning job is running, in the source tenant, use the `Get-MgServicePrincipalSynchronizationJob` command to monitor the progress of the current provisioning cycle as well as statistics to date such as the number of users and groups that have been created in the target system.
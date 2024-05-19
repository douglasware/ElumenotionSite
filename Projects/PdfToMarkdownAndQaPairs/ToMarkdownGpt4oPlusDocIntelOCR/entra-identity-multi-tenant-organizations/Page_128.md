'user1@fabrikam.com' from Azure Active Directory", "timestamp" : "2023-07-31T22 : 31:15.9116590Z", "details" : {"objectId": = <UserObjectId>", "accountEnabled": "True", "displayName" : "User1", "mail Nickname" : "user1", "userPrincipalName" : "use AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#microsoft.graph.stringKe yStringValuePair]}

# Step 12: Start the provisioning job

This figure shows a command prompt executing a PowerShell command to start the synchronization job.

```mermaid
graph TD;
    PowerShell_Command["Start-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId"]
```

## Source tenant

PowerShell

1. Now that the provisioning job is configured, in the source tenant, use the Start-MgServicePrincipalSynchronizationJob command to start the provisioning job.

PowerShell

Start-MgServicePrincipalSynchronizationJob -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId

# Step 13: Monitor provisioning

This figure shows a command prompt executing a PowerShell command to monitor the progress of the synchronization job.

```mermaid
graph TD;
    PowerShell_Command_2["Get-MgServicePrincipalSynchronizationJob"]
```

## Source tenant

PowerShell

1. Now that the provisioning job is running, in the source tenant, use the Get-MgServicePrincipalSynchronizationJob command to monitor the progress of the current provisioning cycle as well as statistics to date such as the number of users and groups that have been created in the target system.
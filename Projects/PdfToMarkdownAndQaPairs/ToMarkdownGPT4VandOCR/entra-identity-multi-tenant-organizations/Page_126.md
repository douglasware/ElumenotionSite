## New-MgServicePrincipalAppRoleAssignedTo Command

```plaintext
New-MgServicePrincipalAppRoleAssignedTo -ServicePrincipalId $ServicePrincipalId -BodyParameter $Params | Format-List
```

### Output

| AppRoleId         | <AppRoleId>                 |
| CreatedDateTime   | 7/31/2023 10:27:12 PM       |
| DeletedDateTime   |                             |
| Id                | <Id>                        |
| PrincipalDisplayName | User1                  |
| PrincipalId       | <PrincipalId>               |
| PrincipalType     | User                        |
| ResourceDisplayName | Fabrikam                 |
| ResourceId        | <ServicePrincipalId>        |
| AdditionalProperties | {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#appRoleAssignments/$entity]} |

## Step 11: Test provision on demand

### Source tenant

Now that you have a configuration, you can test on-demand provisioning with one of your users.

### PowerShell Command

```plaintext
1. In the source tenant, use the Get-MgServicePrincipalSynchronizationJobSchema command to get the schema rule ID.
```

```plaintext
$SynchronizationSchema = Get-MgServicePrincipalSynchronizationJobSchema -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId
$SynchronizationSchema.SynchronizationRules | Format-List
```

### Output

| ContainerFilter | Microsoft.Graph.PowerShell.Models.MicrosoftGraphContainerFilter |
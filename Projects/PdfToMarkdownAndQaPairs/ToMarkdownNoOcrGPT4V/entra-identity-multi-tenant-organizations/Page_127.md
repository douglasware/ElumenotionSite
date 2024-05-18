## Editable Configuration Details

| Property               | Value                                   |
|------------------------|-----------------------------------------|
| Editable               | True                                    |
| GroupFilter            |                                         |
| Id                     | `<RuleId>`                              |
| Metadata               | {defaultSourceObjectMappings, supportsProvisionOnDemand} |
| Name                   | USER_INBOUND_USER                       |
| ObjectMappings         | {Provision Azure Active Directory Users, , , ...} |
| Priority               | 1                                       |
| SourceDirectoryName    | Azure Active Directory                  |
| TargetDirectoryName    | Azure Active Directory (target tenant)  |
| AdditionalProperties   | {}                                      |

## PowerShell Commands

### Initialize a variable for the rule ID

```powershell
$RuleId = "RuleId"
```

### Provision a User on Demand

```powershell
$Params = @{
    Parameters = @(
        @{
            Subjects = @(
                @{
                    ObjectId = "UserObjectId"
                    ObjectTypeName = "User"
                }
            )
            RuleId = $RuleId
        }
    )
}
New-MgServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId -BodyParameter $Params | Format-List
```

### Command Output

| Key  | Value                                                                                                                                                         |
|------|---------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Key  | Microsoft.Identity.Health.CPP.Common.DataContracts.SyncFabric.StatusInfo                                                                                      |
| Value| [{"name":"EntryImport","type":"Import","status":"Success","description":"Retrieved User"}]                                                                   |
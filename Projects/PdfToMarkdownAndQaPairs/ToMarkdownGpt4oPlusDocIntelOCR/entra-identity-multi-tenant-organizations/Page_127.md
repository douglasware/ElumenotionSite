Editable

: True

GroupFilter

:

Microsoft.Graph.PowerShell.Models.MicrosoftGraphGroupFilter

Id

: < RuleId>

Metadata

: {defaultSourceObjectMappings,

supportsProvisionOnDemand }

Name

: USER\_INBOUND\_USER

ObjectMappings

: {Provision Azure Active Directory Users, , ,

.. }

Priority

: 1

SourceDirectoryName

: Azure Active Directory

TargetDirectoryName

: Azure Active Directory (target tenant)

AdditionalProperties : {}

2\. Initialize a variable for the rule ID.

PowerShell

$RuleId = "<RuleId>"

3\. Use the New-MgServicePrincipalSynchronizationJobOnDemand command to provision a test user on demand.

PowerShell

$Params = @{ Parameters = @( @{ Subjects = @( @{ ObjectId = "<UserObjectId>" ObjectTypeName = "User" }

)

RuleId = $RuleId

}

\-

} New-MgServicePrincipalSynchronizationJobOnDemand - ServicePrincipalId $ServicePrincipalId -SynchronizationJobId $JobId -BodyParameter $Params | Format-List

Output

Key : Microsoft. Identity. Health . CPP. Common. DataContracts. SyncFabric. Statu sInfo

Value : [{"provisioningSteps": [{ "name" : "EntryImport", "type" : "Import", "status" : "Success", "descript ion": "Retrieved User
eadWrite. CrossTenantAccess", "Application. ReadWrite. All", "Directory. ReadWrite.All"

Step 2: Create a multitenant organization
===

[Blue box with icon]

In the owner tenant, use the Update-MgBetaTenantRelationshipMultiTenantOrganization command to create your multitenant organization. This operation can take a few minutes.

PowerShell

```
Update-MgBetaTenantRelationshipMultiTenantOrganization -DisplayName "Cairo"
```

Use the Get-MgBetaTenantRelationshipMultiTenantOrganization command to check that the operation has completed before proceeding.

PowerShell

```
Get-MgBetaTenantRelationshipMultiTenantOrganization | Format-List
```

Output

CreatedDateTime : 1/8/2024 7:47:45 PM  
Description :   
DisplayName : Cairo  
Id : < MtoIdC>  
JoinRequest :  
Microsoft. Graph. Beta. PowerShell.Models.MicrosoftGraphMultiTenantOrganizationJoinRequestRecord  
State : active  
Tenants :   
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/beta/$metadata#tenantRelationships/multiTenantOrganization/$entity]} 
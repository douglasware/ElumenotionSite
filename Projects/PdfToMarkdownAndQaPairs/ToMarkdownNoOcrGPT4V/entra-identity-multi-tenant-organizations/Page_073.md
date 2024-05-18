## Step 2: Create a multitenant organization

### Owner tenant

```PowerShell
# In the owner tenant, use the following command to create your multitenant organization. This operation can take a few minutes.
Update-MgBetaTenantRelationshipMultiTenantOrganization -DisplayName "Cairo"

# Use the following command to check that the operation has completed before proceeding.
Get-MgBetaTenantRelationshipMultiTenantOrganization | Format-List

# Output example
CreatedDateTime    : 1/8/2024 7:47:45 PM
Description        :
DisplayName        : Cairo
Id                 : <MtoIdC>
JoinRequest        :
Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrg
anizationJoinRequestRecord
State              : active
Tenants            :
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/beta/$metadata#tenantRelationships/mult
iTenantOrganization/$entity]}
```
## AppId              : <AppId>
## AppManagementPolicies : 
## AppOwnerOrganizationId : <AppOwnerOrganizationId>
## AppRoleAssignedTo : 
## AppRoleAssignmentRequired : True
## AppRoleAssignments : 
## AppRoles : {<AppRoleId>}
## ApplicationTemplateId : 518e5f48-1fc8-4c48-9387-9fdf28b0fef7
## ClaimsMappingPolicies : 
## CreatedObjects : 
## CustomSecurityAttributes :
## Microsoft.Graph.PowerShell.Models.MicrosoftGraphCustomSecurityAttributeValue 
## DelegatedPermissionClassifications :
## DeletedDateTime : 
## Description : 
## DisabledByMicrosoftStatus :
## DisplayName : Fabrikam
## Endpoints : 
## ErrorUrl : 
## FederatedIdentityCredentials : 
## HomeRealmDiscoveryPolicies : 
## Homepage :
## https://account.activedirectory.windowsazure.com:444/applications/default.aspx?metadata=aad2aadsync|ISV9.1|primary|z
## Id : <ServicePrincipalId>
## Info :
## Microsoft.Graph.PowerShell.Models.MicrosoftGraphInformationalUrl 
## KeyCredentials : {}
## LicenseDetails :

---

### 3. Initialize a variable for the service principal ID.
Be sure to use the service principal ID instead of the application ID.

```PowerShell
$ServicePrincipalId = "<ServicePrincipalId>"
```

### 4. Initialize a variable for the app role ID.

```PowerShell
$AppRoleId= "<AppRoleId>"
```
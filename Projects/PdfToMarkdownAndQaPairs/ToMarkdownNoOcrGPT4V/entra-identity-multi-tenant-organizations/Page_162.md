## Append

### Function
Append(source, suffix)

### Description
Takes a source string value and appends the suffix to the end of it.

### Parameters

| Name   | Required/Repeating | Type   | Notes                                         |
|--------|--------------------|--------|-----------------------------------------------|
| source | Required           | String | Usually name of the attribute from the source object. |
| suffix | Required           | String | The string that you want to append to the end of the source value. |

### Append constant suffix to user name

**Example:** If you're using a Salesforce Sandbox, you might need to append another suffix to all your user names before synchronizing them.

**Expression:** `Append([userPrincipalName], ".test")`

**Sample input/output:**
- **INPUT:** (userPrincipalName): "John.Doe@contoso.com"
- **OUTPUT:** "John.Doe@contoso.com.test"

## AppRoleAssignmentsComplex

### Function
AppRoleAssignmentsComplex([appRoleAssignments])
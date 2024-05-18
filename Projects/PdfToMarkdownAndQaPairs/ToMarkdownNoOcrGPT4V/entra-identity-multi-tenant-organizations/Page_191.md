## Select Unique Value Function

```
SelectUniqueValue(
    Join("@", NormalizeDiacritics(StripSpaces(Join(".", 
    [PreferredFirstName], [PreferredLastName]))), "contoso.com"),
    Join("@", NormalizeDiacritics(StripSpaces(Join(".", 
    Mid([PreferredFirstName], 1, 1), [PreferredLastName]))), "contoso.com"),
    Join("@", NormalizeDiacritics(StripSpaces(Join(".", 
    Mid([PreferredFirstName], 1, 2), [PreferredLastName]))), "contoso.com")
)
```

### Sample input/output:

- INPUT (PreferredFirstName): "John"
- INPUT (PreferredLastName): "Smith"
- OUTPUT: "John.Smith@contoso.com" if UPN value of John.Smith@contoso.com doesn't already exist in the directory
- OUTPUT: "J.Smith@contoso.com" if UPN value of John.Smith@contoso.com already exists in the directory
- OUTPUT: "Jo.Smith@contoso.com" if the above two UPN values already exist in the directory

## SingleAppRoleAssignment

### Function
`SingleAppRoleAssignment({appRoleAssignments})`

### Description
Returns a single appRoleAssignment from the list of all appRoleAssignments assigned to a user for a given application. This function is required to convert the appRoleAssignments object into a single role name string. The best practice is to ensure only one appRoleAssignment is assigned to one user at a time. This function isn't supported in scenarios where users have multiple app role assignments.

### Parameters

| Name                   | Required/Repeating | Type   | Notes                         |
|------------------------|--------------------|--------|-------------------------------|
| [appRoleAssignments]   | Required           | String | appRoleAssignments object.    |

## Split

### Function
`Split(source, delimiter)`
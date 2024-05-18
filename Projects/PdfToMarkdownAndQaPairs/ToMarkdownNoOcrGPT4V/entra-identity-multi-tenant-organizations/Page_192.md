## Split a String into a Multi-Valued Array

### Description
Splits a string into a multi-valued array, using the specified delimiter character.

### Parameters

| Name      | Required/Repeating | Type   | Notes                                         |
|-----------|--------------------|--------|-----------------------------------------------|
| source    | Required           | String | source value to update                        |
| delimiter | Required           | String | Specifies the character that will be used to split the string (example: ",") |

### Example
You need to take a comma-delimited list of strings, and split them into an array that can be plugged into a multi-value attribute like Salesforce's PermissionSets attribute. In this example, a list of permission sets has been populated in extensionAttribute5 in Microsoft Entra ID.

**Expression:** `Split(extensionAttribute5, ",")`

**Sample input/output:**

- **INPUT** (extensionAttribute5): "PermissionSetOne, PermissionSetTwo"
- **OUTPUT**: ["PermissionSetOne", "PermissionSetTwo"]

## StripSpaces

### Function 
`StripSpaces(source)`

### Description
Removes all space (" ") characters from the source string.

### Parameters

| Name   | Required/Repeating | Type   | Notes                             |
|--------|--------------------|--------|-----------------------------------|
| source | Required           | String | source value to update            |
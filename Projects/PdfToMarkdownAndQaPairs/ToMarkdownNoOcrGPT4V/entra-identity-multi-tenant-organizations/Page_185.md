## Redact Function

| Name            | Required/Repeating | Type  | Notes                                                          |
|-----------------|---------------------|-------|----------------------------------------------------------------|
| attribute/value | Required            | String| Specify the attribute or constant / string to redact from the logs.|

### Examples:
- Redact an attribute: `Redact([userPrincipalName])` Removes the userPrincipalName from the provisioning logs.
- Redact a string: `Redact("StringToBeRedacted")` Removes a constant string from the provisioning logs.
- Redact a random string: `Redact(RandomString(6,3,0,0,3))` Removes the random string from the provisioning logs.

## RemoveDuplicates Function

**Description**: The RemoveDuplicates function takes a multi-valued string and make sure each value is unique.

| Name     | Required/Repeating | Type           | Notes                                            |
|----------|---------------------|----------------|--------------------------------------------------|
| attribute| Required            | Multi-valued Attribute | Multi-valued attribute that has duplicates removed |

### Example:
- `RemoveDuplicates([proxyAddresses])` Returns a sanitized proxyAddress attribute where all duplicate values are removed.

## Replace Function

**Description**: Replaces values within a string in a case-sensitive manner. The function behaves differently depending on the parameters provided.

| Name                  | Required/Repeating | Type  | Notes   |
|-----------------------|---------------------|-------|---------|
| source                | Required            | String| Source string where replacements are to be made |
| oldValue              | Required            | String| Value to find in the source string |
| regexPattern          | Optional            | String| Pattern to match in the source string |
| regexGroupName        | Optional            | String| Part of the matched pattern to replace |
| replacementValue      | Optional            | String| Value to replace in the source string |
| replacementAttributeName | Optional        | String| Attribute name for the replacement value |
| template              | Optional            | String| Template for forming the replacement string |
## Attribute Details

| Name                     | Required/Repeating | Type   | Notes                                                             |
|--------------------------|--------------------|--------|-------------------------------------------------------------------|
| replacementValue         | Optional           | String | New value to replace old one with.                                |
| replacementAttributeName | Optional           | String | Name of the attribute to be used for replacement value             |
| template                 | Optional           | String | When template value is provided, we'll look for oldValue inside the template and replace it with source value. |

## Replace characters using a regular expression

### Example 1: Basic Replacement
Using oldValue and replacementValue to replace the entire source string with another string.

- **source**: `[BusinessTitle]`
- **oldValue**: "Product Developer"
- **replacementValue**: "Software Engineer"
- **Expression output**: Software Engineer

### Example 2: Using Templates
Using oldValue and template to insert the source string into another templated string.

- **source**: `[UserID]` = "jsmith"
- **template**: `<username>@contoso.com`
- **Expression output**: Using the UserID value, the result is `jsmith@contoso.com`
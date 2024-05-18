## Regular Expressions and Attribute Replacement Examples

### Example 4: Street Number Replacement

- **source**: `streetNumber="123"`
- **regexPattern**: `"(?<=streetNumber^)\d+"`
- **regexGroupName**: `"streetNumber"`
- **replacementValue**: `"888"`
- **Expression output**: `888 Tremont Street`

### Example 5: Domain Suffix Removal
Removes the domain suffix from a UPN to generate login ID without domain suffix.

- **source**: `[userPrincipalName] = "jsmith@contoso.com"`
- **regexPattern**: `"(?<=\@.*)"`
- **regexGroupName**: `"Suffix"`
- **replacementValue**: `""` (empty string)
- **Expression output**: `jsmith`

### Example 6: Handling Empty Telephone Numbers
Uses regex to extract exact 10 digits of the mobile number attribute when the source attribute is empty.

- **source**: `[telephoneNumber] = ""` (empty string)
- **regexPattern**: `"\+(\d{2})(\d{10})"`
- **regexGroupName**: `"phoneNumber"`
- **replacementAttributeName**: `[mobile] = "+91 8887779999"`
- **Expression output**: `8887779999`

### Example 7: Removing Certain Characters
Targets and removes specific characters from a string value using regex.

- **source**: `[mailNickname] = "john_doe72"`
- **oldValue**: `"[\-a-zA-Z]+,"`
- **replaceValue**: `""`
- **Expression output**: `72`
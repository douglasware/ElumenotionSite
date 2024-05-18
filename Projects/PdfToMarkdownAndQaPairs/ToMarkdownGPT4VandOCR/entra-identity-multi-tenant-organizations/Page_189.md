## Regex Examples

### Example 4: Replace street number with a specific value.

```
regexPattern: "^(?<streetNumber>\d*)"
regexGroupName: "streetNumber"
replacementValue: "888"
Expression output: 888 Tremont Street
```

### Example 5: Remove domain suffix from UPN.

```
Replace([userPrincipalName], "(?<Suffix>@(.*)*)", "Suffix", "", )
source: [userPrincipalName] = "jsmith@contoso.com"
regexPattern: "(?<Suffix>@(.*)*)"
regexGroupName: "Suffix"
replacementValue: ""
Expression output: jsmith
```

### Example 6: Handle empty source attribute.

```
Replace([telephoneNumber], "\+(?<isdCode>\d*) (?<phoneNumber>\d{10})", "phoneNumber", , [mobile], )
source: [telephoneNumber] = ""
regexPattern: "\+(?<isdCode>\d*) (?<phoneNumber>\d{10})"
regexGroupName: "phoneNumber"
replacementAttributeName: [mobile] = "+91 8887779999"
Expression output: 8887779999
```

### Example 7: Remove regex-matched characters.

```
Replace([mailNickname], "[a-zA-Z_]*", , "", )
source [mailNickname]
oldValue: "john_doe72"
replaceValue: ""
Expression output: 72
```
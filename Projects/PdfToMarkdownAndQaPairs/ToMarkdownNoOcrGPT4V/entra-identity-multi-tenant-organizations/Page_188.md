## Example 3: Regex Pattern and Replacement Value

Using regexPattern and replacementValue to extract a portion of the source string and replace it with an empty string or a custom value built using regex patterns or regex group names.

### Scenario

You have a source attribute `telephoneNumber` that includes `country code` and `phone number` separated by a space character. For instance, +91 9998887777. 

To extract the 10 digit phone number, you can use the following expression in your attribute mapping:

```plaintext
Replace([[telephoneNumber]], "^\+(\d{2})\s(\d{10})", "${phoneNumber}")
```

- **source**: 
  - `telephoneNumber` = "+91 9998887777"
- **regexPattern**: 
  - `"^\+(\d{2})\s(\d{10})"`
- **replacementValue**: 
  - `"${phoneNumber}"`
- **Expression output**: 
  - `9998887777`

You can also use this pattern to remove characters and condense a string. For example, the next expression removes parentheses, dashes, and space characters from the mobile number string and returns only digits:

```plaintext
Replace([mobile], "[()\\s-]+", "")
```

- **source**: 
  - `mobile` = "+1 (999) 888-7777"
- **regexPattern**: 
  - `"[()\\s-]+"`
- **replacementValue**: 
  - `""` (empty string)
- **Expression output**: 
  - `19998887777`

## Example 4: Regex Pattern, Regex Group Name, and Replacement Value

You can use regexPattern, regexGroupName, and replacementValue to extract a specific portion of the source string and replace it with another literal value or empty string.

### Scenario

Your source system has an attribute `AddressLineData` with street number and name. For a recent move, only the street number of the address changed. To update only the street number part of the address:

```plaintext
Replace([AddressLineData], "(?<=^)(\d+)(?=\s.*)", "888")
```

- **source**: 
  - `AddressLineData` = "545 Tremont Street"
- **regexPattern**: 
  - `"(?<=^)(\d+)(?=\s.*)"`
- **replacementValue**: 
  - `"888"`
- **Expression output**: 
  - "888 Tremont Street"

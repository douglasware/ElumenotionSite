## Example 3: Using regexPattern and replacementValue to extract a portion of the source string and replace it with an empty string or a custom value built using regex patterns or regex group names.

Let's say you have a source attribute `telephoneNumber` that has components country code and phone number separated by a space character. For example, `+91 9998887777`. Then in this case, you can use the following expression in your attribute mapping to extract the 10 digit phone number.

- source: `[telephoneNumber] = "+91 9998887777"`
- regexPattern: `"\\+(?<isdCode>\\d*) (?<phoneNumber>\\d{10})"`
- replacementValue: `"${phoneNumber}"`
- Expression output: `9998887777`

You can also use this pattern to remove characters and collapse a string. For example, the expression below removes parenthesis, dashes and space characters in the mobile number string and returns only digits.

- source: `[mobile] = "+1 (999) 888-7777"`
- regexPattern: `"[()\\s-]+"`
- replacementValue: `""` (empty string)
- Expression output: `19998887777`

## Example 4: Using regexPattern, regexGroupName and replacementValue to extract a portion of the source string and replace it with another literal value or empty string.

Let's say your source system has an attribute AddressLineData with two components street number and street name. As part of a recent move, let's say the street number of the address changed, and you want to update only the street number portion of the address line. Then in this case, you can use the following expression in your attribute mapping to extract the street number.

- source: `[AddressLineData] = "545 Tremont Street"`
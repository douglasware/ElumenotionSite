· regexPattern: "( ?< streetNumber>^\\\\d\*) "

· regexGroupName: "streetNumber"

· replacementValue: "888"

· Expression output: 888 Tremont Street

Here is another example where the domain suffix from a UPN is replaced with an empty string to generate login ID without domain suffix.

Replace([userPrincipalName], , "( ?< Suffix>@(.)\*)", "Suffix", "", , )

· source: [userPrincipalName] ="jsmith@contoso.com"

· regexPattern: " (?‹Suffix>@(.)\*) "

· regexGroupName: "Suffix"

· replacementValue: "" (empty string)

· Expression output: jsmith

Example 5: Using regexPattern, regexGroupName and replacementAttributeName to handle scenarios when the source attribute is empty or doesn't have a value.

Let's say your source system has an attribute telephoneNumber. If telephoneNumber is empty, you want to extract the 10 digits of the mobile number attribute. Then in this case, you can use the following expression in your attribute mapping.

Replace([telephoneNumber], , "\\\\+( ?< isdCode>\\\\d\* )( ?< phoneNumber>\\\\d{10})", "phoneNumber" , , [mobile], )

· source: [telephoneNumber] = "" (empty string)

· regexPattern: "\\\\+( ?< isdCode>\\\\d\* )( ?< phoneNumber>\\\\d{10})"

· regexGroupName: "phoneNumber"

· replacementAttributeName: [mobile] = "+91 8887779999"

· Expression output: 8887779999

Example 6: You need to find characters that match a regular expression value and remove them.

Replace([mailNickname], , "[a-zA-Z\_]\*" و , , )

· source [mailNickname]

· oldValue: "john\_doe72"

· replaceValue: ""

· Expression output: 72

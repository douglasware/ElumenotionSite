Sample input / output:

- INPUT (mail): "john.doe@contoso.com"
- OUTPUT: "john.doe"

Generate user alias by concatenating parts of first and last name
===

Generate a user alias by taking first three letters of user's first name and first five letters of user's last name.

Expression: `Append(Mid([givenName], 1, 3), Mid([surname], 1, 5))`

Sample input/output:

- INPUT (givenName): "John"
- INPUT (surname): "Doe"
- OUTPUT: "JohDoe"

Add a comma between last name and first name
===

Add a comma between last name and first name.

Expression: `Join(", ", "", [surname], [givenName])`

Sample input/output:

- INPUT (givenName): "John"
- INPUT (surname): "Doe"
- OUTPUT: "Doe, John"

Generate an ID for a user based on their Microsoft Entra ID object ID. Remove any letters from the ID and add 1000 at the beginning
===

This expression allows you to generate an identifier for a user that starts with 1000 and is likely to be unique.

Expression: `Join("", 1000, Replace(ConvertToUTF8Hex([objectId]), "[a-zA-Z_]*", ""))`

Sample input/output:

- INPUT: "d05e47b1-3909-445a-ba5e-ca60cbc0e4b4"
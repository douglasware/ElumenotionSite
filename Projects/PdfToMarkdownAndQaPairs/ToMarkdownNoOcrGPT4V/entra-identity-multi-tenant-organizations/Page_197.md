## Sample Input / Output

- INPUT (mail): "john.doe@contoso.com"
- OUTPUT: "john.doe"

## Generate User Alias by Concatenating Parts of First and Last Name

Generate a user alias by taking first three letters of user's first name and first five letters of user's last name.

Expression: `Append(Mid([givenName], 1, 3), Mid([surname], 1, 5))`

### Sample input/output:

- INPUT (givenName): "John"
- INPUT (surname): "Doe"
- OUTPUT: "JohDoe"

## Add a Comma Between Last Name and First Name

Add a comma between last name and first name.

Expression: `Join(", ", [surname], [givenName])`

### Sample input/output:

- INPUT (givenName): "John"
- INPUT (surname): "Doe"
- OUTPUT: "Doe, John"

## Generate an ID for a User Based on Their Microsoft Entra ID Object ID

Remove any letters from the ID and add 1000 at the beginning.

This expression allows you to generate an identifier for a user that starts with 1000 and is likely to be unique.

Expression: `Join("", 1000, Replace(ConvertToUTF8Hex([objectId]), "[a-zA-Z]*", ""))`

### Sample input/output:

- INPUT: "d05e47b1-3909-445a-ba5e-ca60cbc0e4b4"

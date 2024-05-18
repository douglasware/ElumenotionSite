## Example: 

You wish to flow the mail attribute if it is present. If it isn't, you wish to flow the value of userPrincipalName instead.

### Expression: 
`Coalesce([mail], [userPrincipalName])`

### Sample input/output:

- INPUT (mail): NULL
- INPUT (userPrincipalName): "John.Doe@contoso.com"
- OUTPUT: "John.Doe@contoso.com"

## ConvertToBase64

### Function: 
`ConvertToBase64(source)`

### Description: 
The ConvertToBase64 function converts a string to a Unicode base64 string.

### Parameters:

| Name   | Required/ Repeating | Type   | Notes                       |
|--------|---------------------|--------|-----------------------------|
| source | Required            | String | String to be converted to base 64 |

### Example: 
`ConvertToBase64("Hello world!")`

Returns "SABIAGwAbABvACAAdwBvAHIAbABkACEA"

## ConvertToUTF8Hex

### Function: 
`ConvertToUTF8Hex(source)`

### Description: 
The ConvertToUTF8Hex function converts a string to a UTF8 Hex encoded value.

### Parameters:

| Name   | Required/ Repeating | Type   | Notes                            |
|--------|---------------------|--------|----------------------------------|
| source | Required            | String | String to be converted to UTF8 Hex |
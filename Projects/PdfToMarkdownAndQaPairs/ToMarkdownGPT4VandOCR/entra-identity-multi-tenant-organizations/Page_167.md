## Example: ConvertToUTF8Hex("Hello world!") 
Returns 48656C6C6F20776F726C6421

## Count 
### Function: Count(attribute) 
### Description 
The Count function returns the number of elements in a multi-valued attribute 
### Parameters 

| Name       | Required/Repeating | Type      | Notes                                         |
|------------|--------------------|-----------|-----------------------------------------------|
| attribute  | Required           | attribute | Multi-valued attribute that will have elements counted |

## CStr 
### Function: CStr(value) 
### Description
The CStr function converts a value to a string data type. 
### Parameters 

| Name  | Required/Repeating | Type                      | Notes                               |
|-------|--------------------|---------------------------|-------------------------------------|
| value | Required           | numeric, reference, or boolean | Can be a numeric value, reference attribute, or Boolean. |

### Example: CStr([dn]) 
Returns "cn=Joe,dc=contoso,dc=com"

## DateAdd
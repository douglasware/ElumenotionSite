## Function: InStr(value1, value2, start, compareType)

### Description:
The InStr function finds the first occurrence of a substring in a string

### Parameters:

| Name       | Required/ Repeating | Type   | Notes                                  |
|------------|---------------------|--------|----------------------------------------|
| value1     | Required            | String | String to be searched                   |
| value2     | Required            | String | String to be found                      |
| start      | Optional            | Integer| Starting position to find the substring|
| compareType| Optional            | Enum   | Can be vbTextCompare or vbBinaryCompare|

### Example:
`InStr("The quick brown fox", "quick")`  
Evaluates to 5

`InStr("repeated", "e", 3, vbBinaryCompare)`  
Evaluates to 7

## IsNull

### Function: IsNull(Expression)

### Description:
If the expression evaluates to Null, then the IsNull function returns true. For an attribute, a Null is expressed by the absence of the attribute.

### Parameters:

| Name        | Required/ Repeating| Type      | Notes                    |
|-------------|--------------------|-----------|--------------------------|
| Expression  | Required           | Expression| Expression to be evaluated|

### Example:
`IsNull([displayName])`  
Returns True if the attribute isn't present.

## IsNullOrEmpty
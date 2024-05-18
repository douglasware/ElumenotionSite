## CBool

**Description**: `CBool` returns a boolean based on the evaluated expression. If the expression evaluates to a non-zero value, then `CBool` returns `True`, else it returns `False`.

**Parameters**:

| Name       | Required/Repeating | Type       | Notes             |
|------------|--------------------|------------|-------------------|
| Expression | Required           | expression | Any valid expression |

**Example**: `CBool([attribute1] = [attribute2])`

Returns True if both attributes have the same value.

## CDate

**Function**: `CDate(expression)`

**Description**: The CDate function returns a UTC DateTime from a string. DateTime isn't a native attribute type but it can be used within date functions such as `FormatDateTime` and `DateAdd`.

**Parameters**:

| Name       | Required/Repeating | Type       | Notes                                          |
|------------|--------------------|------------|------------------------------------------------|
| Expression | Required           | Expression | Any valid string that represents a date/time. For supported formats, refer to .NET custom date and time format strings. |

**Remarks**: The returned string is always in UTC and follows the format `M/d/yyyy h:mm:ss tt`.

**Example 1**: `CDate([StatusHireDate])`

**Sample input/output**:

- INPUT (StatusHireDate): "2020-03-16-07:00"
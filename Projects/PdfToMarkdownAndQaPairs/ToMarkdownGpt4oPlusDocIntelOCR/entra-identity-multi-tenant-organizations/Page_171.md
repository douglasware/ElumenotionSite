Switch ([Active], , "1", IIF(DateDiff("d", Now(), CDate([StatusHireDate])) > 5, "False", "True"), "0", "False")

# DateFromNum

Function: DateFromNum(value)

Description: The DateFromNum function converts a value in AD's date format to a DateTime type.

Parameters:

![Table 1: Parameters](figure1)

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| value | Required | Date | AD Date to be converted to DateTime type |

```mermaid
graph TD;
    Name --> value;
    Required_Repeating --> "Required";
    Type --> Date;
    Notes --> "AD Date to be converted to DateTime type";
```

Example: DateFromNum([lastLogonTimestamp])

DateFromNum(129699324000000000)

Returns a DateTime representing January 1, 2012 at 11:00PM.

# FormatDateTime

Function: FormatDateTime(source, dateTimeStyles, inputFormat, outputFormat)

Description: Takes a date string from one format and converts it into a different format.

Parameters:

![Table 2: Parameters](figure2)

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| source | Required | String | Usually name of the attribute from the source object. |
| dateTimeStyles | Optional | String | Use this parameter to specify the formatting options that customize string parsing for some date and time parsing methods. For supported values, see DateTimeStyles doc. If left empty, the default value used is |

```mermaid
graph TD;
    Name --> source;
    Required_Repeating --> "Required";
    Type --> String;
    Notes_1 --> "Usually name of the attribute from the source object";
    dateTimeStyles --> dateTimeStyles;
    Optional --> "Optional";
    Type_2 --> "String";
    Notes_2 --> "Use this parameter to specify the formatting options that customize string parsing for some date and time parsing methods. For supported values, see DateTimeStyles doc. If left empty, the default value used is";
```
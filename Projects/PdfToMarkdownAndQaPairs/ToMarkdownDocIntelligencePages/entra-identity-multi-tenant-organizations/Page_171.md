Switch ([Active], , "1", IIF(DateDiff("d", Now(), CDate([StatusHireDate])) > 5, "False", "True"), "0", "False")


# DateFromNum

Function: DateFromNum(value) Description: The DateFromNum function converts a value in AD's date format to a DateTime type.

Parameters:

Expand table

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| value | Required | Date | AD Date to be converted to DateTime type |

Example: DateFromNum([lastLogonTimestamp])

DateFromNum(129699324000000000)

Returns a DateTime representing January 1, 2012 at 11:00PM.


# FormatDateTime

Function: FormatDateTime(source, dateTimeStyles, inputFormat, outputFormat)

Description: Takes a date string from one format and converts it into a different format. Parameters:

Expand table

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| source | Required | String | Usually name of the attribute from the source object. |
| dateTimeStyles | Optional | String | Use this parameter to specify the formatting options that customize string parsing for some date and time parsing methods. For supported values, see DateTimeStyles doc. If left empty, the default value used is |

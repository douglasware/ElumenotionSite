## Replace a value based on predefined set of options

Example: Define the time zone of the user based on the state code stored in Microsoft Entra ID. If the state code doesn't match any of the predefined options, use default value of "Australia/Sydney".

Expression: `Switch([state], "Australia/Sydney", "NSW", "Australia/Sydney", "QLD", "Australia/Brisbane", "SA", "Australia/Adelaide")`

Sample input/output:
- INPUT (state): "QLD"
- OUTPUT: "Australia/Brisbane"

## ToLower

Function: `ToLower(source, culture)`

Description: Takes a source string value and converts it to lower case using the culture rules that are specified. If there is no culture info specified, then it will use Invariant culture.

If you would like to set existing values in the target system to lower case, update the schema for your target application and set the property caseExact to 'true' for the attribute that you're interested in.

Parameters:

| Name   | Required/ Repeating | Type   | Notes |
|--------|---------------------|--------|-------|
| source | Required            | String | Usually name of the attribute from the source object |
| culture| Optional            | String | The format for the culture name based on RFC 4646 is languagecode2-country/regioncode2, where languagecode2 is the two-letter language code and country/regioncode2 is the two-letter subculture code. Examples include ja-JP for Japanese (Japan) and en-US for English (United States). In cases where a two-letter language code isn't available, a three-letter code derived from ISO 639-2 is used. |

Convert generated userPrincipalName (UPN) value to lower case
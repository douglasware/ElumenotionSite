Example: You would like to generate the UPN value by concatenating the PreferredFirstName and PreferredLastName source fields and converting all characters to lower case.

ToLower (Join("@", NormalizeDiacritics(StripSpaces(Join(".", [PreferredFirstName], [PreferredLastName]) ) ), "contoso.com"))

Sample input/output:

. INPUT (PreferredFirstName): "John"

. INPUT (PreferredLastName): "Smith"

· OUTPUT: "john.smith@contoso.com"


# ToUpper

Function: ToUpper(source, culture)

Description: Takes a source string value and converts it to upper case using the culture rules that are specified. If there is no culture info specified, then it will use Invariant culture.

If you would like to set existing values in the target system to upper case, update the schema for your target application and set the property caseExact to 'true' for the attribute that you're interested in.

Parameters:

Expand table

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| source | Required || String Usually name of the attribute from the source object.  |
|| culture Optional  | String | The format for the culture name based on RFC 4646 is languagecode2-country/regioncode2, where languagecode2 is the two-letter language code and country/regioncode2 is the two- letter subculture code. Examples include ja-JP for Japanese (Japan) and en-US for English (United States). In cases where a two-letter language code isn't available, a three-letter code derived from ISO 639-2 is used. |

<!-- PageFooter="Word" -->

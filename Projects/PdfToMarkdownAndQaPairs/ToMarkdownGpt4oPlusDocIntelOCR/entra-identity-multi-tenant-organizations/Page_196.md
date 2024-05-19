Function: Word(String,WordNumber,Delimiters)

Description: The Word function returns a word contained within a string, based on parameters describing the delimiters to use and the word number to return. Each string of characters in string separated by the one of the characters in delimiters are identified as words:

If number < 1, returns empty string. If string is null, returns empty string. If string contains less than number words, or string doesn't contain any words identified by delimiters, an empty string is returned.

Parameters:

| Name       | Required/ Repeating | Type                    | Notes                                                    |
|------------|---------------------|-------------------------|----------------------------------------------------------|
| String     | Required            | Multi-valued Attribute  | String to return a word from.                            |
| WordNumber | Required            | Integer                 | Number identifying which word number should return       |
| delimiters | Required            | String                  | A string representing the delimiter(s) that should be used to identify words |


Example: Word("The quick brown fox", 3," ")

Returns "brown".

Word("This, string!has&many separators", 3, ", ! &#")

Returns "has".


# Examples

This section provides more expression function usage examples.


# Strip known domain name

Strip a known domain name from a user's email to obtain a user name. For example, if the domain is "contoso.com", then you could use the following expression:

Expression: Replace([mail], "@contoso.com", , ,"", ,)
## Punctuation and Symbols

- OpenPunctuation and ClosePunctuation characters that occur in pairs like parenthesis, curly bracket, angle bracket, etc.
- InitialQuotePunctuation and FinalQuotePunctuation characters like single quotes, double quotes and angular quotes.
- OtherPunctuation characters like exclamation mark, number sign, percent sign, ampersand, asterisk, comma, full stop, colon, semi-colon, etc.
- MathSymbol characters like plus sign, less-than and greater-than sign, vertical line, tilde, equals sign, etc.
- CurrencySymbol characters like dollar sign, cent sign, pound sign, euro sign, etc.
- ModifierSymbol characters like macron, accents, arrow heads, etc.
- OtherSymbol characters like copyright sign, degree sign, registered sign, etc.
- If the wordSeparators parameter is specified, then PCase only uses the characters specified as word separators.

## Example:

Let's say you're sourcing the attributes firstName and lastName from SAP SuccessFactors and in HR both these attributes are in upper-case. Using the PCase function, you can convert the name to proper case as shown below.

| Expression | Input | Output | Notes |
|---|---|---|---|
| `PCase([firstName])` | firstName = "PABLO GONSALVES (SECOND)" | "Pablo Gonsalves (Second)" | As the wordSeparators parameter isn't specified, the PCase function uses the default word separators character set. |
| `PCase([lastName]," ' -")` | lastName = "PINTO-DE'SILVA" | "Pinto-De'Silva" | The PCase function uses characters in the wordSeparators parameter to identify words and transform them to proper case. |
| `PCase(Join(" ", [firstName], [lastName]))` | firstName = "GREGORY, lastName = "JAMES" | "Gregory James" | You can nest the Join function within PCase. As the wordSeparators parameter isn't specified, the PCase function uses the default word separators character set. |

## RandomString

Function: RandomString(Length, MinimumNumbers, MinimumSpecialCharacters, MinimumCapital, MinimumLowerCase, CharactersToAvoid)
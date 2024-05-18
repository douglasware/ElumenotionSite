o OpenPunctuation and ClosePunctuation characters that occur in pairs like parenthesis, curly bracket, angle bracket, etc.

o InitialQuotePunctuation and FinalQuotePunctuation characters like single :unselected: quotes, double quotes and angular quotes.

o OtherPunctuation characters like exclamation mark, number sign, percent sign, ampersand, asterisk, comma, full stop, colon, semi-colon, etc.

o MathSymbol characters like plus sign, less-than and greater-than sign, vertical :unselected: line, tilde, equals sign, etc.

o CurrencySymbol characters like dollar sign, cent sign, pound sign, euro sign, etc.
 :unselected:
o ModifierSymbol characters like macron, accents, arrow heads, etc.
 :unselected:
o OtherSymbol characters like copyright sign, degree sign, registered sign, etc.
 :unselected:
. If the wordSeparators parameter is specified, then PCase only uses the characters specified as word separators.


# Example:

Let's say you're sourcing the attributes firstName and lastName from SAP SuccessFactors and in HR both these attributes are in upper-case. Using the PCase function, you can convert the name to proper case as shown below.

C) Expand table

| Expression | Input | Output | Notes |
| - | - | - | - |
| PCase([firstName]) | firstName = | "Pablo | As the wordSeparators parameter |
| | "PABLO | Gonsalves | isn't specified, the PCase function |
|| GONSALVES | (Second)" | uses the default word separators |
|| (SECOND)" | | character set. |
| PCase([lastName]," '- | lastName = | "Pinto- | The PCase function uses characters |
| ") | "PINTO- | De'Silva" | in the wordSeparators parameter to |
| | DE'SILVA" | | identify words and transform them |
|||| to proper case. |
| PCase (Join(" ", | firstName = | "Gregory | You can nest the Join function within |
| [firstName], | GREGORY, | James" | PCase. As the wordSeparators |
| [lastName])) | lastName = | | parameter isn't specified, the PCase |
| | "JAMES" | | function uses the default word separators character set. |


# RandomString

Function: RandomString(Length, MinimumNumbers, MinimumSpecialCharacters, MinimumCapital, MinimumLowerCase, CharactersToAvoid)
:unselected: :unselected:
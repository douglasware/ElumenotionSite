## Character with Diacritic and Normalized Character

| Character with Diacritic | Normalized character | Character with Diacritic | Normalized character |
|--------------------------|----------------------|--------------------------|----------------------|
| ğ, ğ, ğ                  | g                    | Ğ, Ğ, Ğ                  | G                    |
| ï, î, ì, í, í            | i                    | İ, İ, İ, İ, İ, İ        | I                    |
| ł, Ł, Ł                  | L                    | Ł, Ł, Ł, Ł               | L                    |
| ñ, ń, ň, n̄              | n                    | Ñ, Ń, Ň, Ǹ, N            | N                    |
| ö, ö, ö, ő, õ, ô, ó, ō   | o                    | Ö, Ò, Ő, Õ, Ô, Ó, Ō, Ó   | O                    |
| ø, œ                     | oe                   | Ø, Œ                     | OE                   |
| ř, ř, ř                  | r                    | Ř, Ř, Ř                  | R                    |
| ß                        | ss                   |                          |                      |
| ś, š, ś, ş               | s                    | Ś, Š, Ś, Ş               | S                    |
| ť, ť, ť                  | t                    | Ť, Ť, Ť                  | T                    |
| ü, ù, û, ú, ů, ű, ū      | u                    | Ü, Ù, Û, Ú, Ů, Ű, Ū      | U                    |
| ÿ, ý, ý, ỳ               | y                    | Y, Ý, Ý, Ỳ               | Y                    |
| ź, ž, ż                  | z                    | Ź, Ž, Ż                  | Z                    |

## Remove diacritics from a string

Example: Replace characters containing accent marks with equivalent characters that don't contain accent marks.

### Expression:

`NormalizeDiacritics([givenName])`

### Sample input/output:

- INPUT (givenName): "Zoë"
- OUTPUT: "Zoe"

## Not 

### Function:

`Not(source)`
## Remove diacritics from a string

| Character with Diacritic                                               | Normalized character | Character with Diacritic                                              | Normalized character |
|------------------------------------------------------------------------|----------------------|------------------------------------------------------------------------|----------------------|
| ğ, ǧ, g                                                                | g                    | Ǧ, Ğ, G                                                                | G                    |
| ï, î, ì, í, ì, ĩ, ĩ, i, ï, Î, Ï, i                                     | i                    | Ĩ, Ī, Ĭ, Î, Ï, Ĩ, Ĭ, Ï, Ī                                                | I                    |
| ŀ, ł, Ľ, Ĺ, l                                                          | l                    | Ł, Ľ, Ļ, Ĺ, L                                                          | L                    |
| ñ, ń, ň, ņ, n                                                          | n                    | Ń, Ń, Ň, Ň, N                                                          | N                    |
| ò, ó, ő, o, ò, ớ, ô, õ, ô, o, ố, ǫ, ǫ, ǒ                                | o                    | Ó, Ò, Ó, Ó, Ô, Ò, Ô, Ǒ, Ǭ, Ǭ, Ớ, Ố, ơ                                  | O                    |
| ø, ǿ, œ                                                                | oe                   | Ø, Ø, Œ                                                                | OE                   |
| ř, ŕ, ř, ŗ                                                             | r                    | Ř, Ř, Ŕ, ŗ                                                            | R                    |
| ß                                                                      | ss                   |                                                                        |                      |
| š, š, ṣ, ş, ş, ṣ                                                        | s                    | Š, Š, Ş, Ş, Š                                                          | S                    |
| ť, ţ, ŧ, t                                                             | t                    | Ť, Ŧ, Ť, Ţ                                                            | T                    |
| ù, û, ü, ù, ú, ù, ú, ù, û, û, ü, û                                     | u                    | Ų, Ũ, Ů, Ŭ, Ü, Ŷ, Ŵ, Ü, Ú, ů                                           | U                    |
| ÿ, ŷ, ẏ, ÿ, ŷ, ý, ÿ                                                    | y                    | Ŷ, Ŷ, Ÿ, Ŷ, Ÿ, Ŷ, Ý                                                    | Y                    |
| ž, ž, ž, ž, z                                                          | z                    | Ž, Ž, Ź, Ž, Ż, Ž                                                       | Z                    |

Example: Replace characters containing accent marks with equivalent characters that don't contain accent marks.

**Expression:** `NormalizeDiacritics([givenName])`

**Sample input/output:**

- **INPUT** (givenName): "Zoë"  
- **OUTPUT:** "Zoe"  

## Not

**Function:** Not(source)
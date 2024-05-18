## Character Diacritic Normalization Table

| Character with Diacritic | Normalized character | Character with Diacritic | Normalized character |
|--------------------------|----------------------|--------------------------|----------------------|
| ğ, ğ, ğ                  | g                    | Ğ, Ğ, Ğ                  | G                    |
| ì, í, î, ï, ĩ, ĭ, į, i̇, i̇ | i                    | Ì, Í, Î, Ï, Ĩ, Ĭ, Į, İ, İ | I                    |
| ĺ, ļ, ľ, ł              | l                    | Ĺ, Ļ, Ľ, Ł              | L                    |
| ń, ņ, ň, ǹ              | n                    | Ń, Ņ, Ň, Ǹ              | N                    |
| ò, ó, ô, ö, õ, ő, ơ, o̊, ő, ó̌, ò̌, ǒ, ǫ | o                    | Ò, Ó, Ô, Ö, Õ, Ő, Ơ, O̊, Ő, Ó̌, Ò̌, Ǒ, Ǫ | O                    |
| œ, ö, œ                 | oe                   | Œ, Ö, Œ                 | OE                   |
| ŕ, ŗ, ř                 | r                    | Ŕ, Ŗ, Ř                 | R                    |
| ß                       | ss                   |-                       |-                     |
| ś, ŝ, š, ş, s̩           | s                    | Ś, Ŝ, Š, Ş, S̩           | S                    |
| ţ, ť, ŧ                 | t                    | Ţ, Ť, Ŧ                 | T                    |
| ù, ú, û, ü, ũ, ű, ů, ų, ut̄, út̄, ùt̄, ǔ, ų | u                      | Ù, Ú, Û, Ü, Ũ, Ű, Ů, Ų, Ut̄, Út̄, Ùt̄, Ǔ, Ų | U                    |
| ý, ÿ, ŷ, ỳ, ỹ, y̌       | y                    | Ý, Ÿ, Ŷ, Ỳ, Ỹ, Y̌       | Y                    |
| ź, ż, ž, z̧             | z                    | Ź, Ż, Ž, Z̧             | Z                    |

### Remove Diacritics from a String

**Example:**

- Replace characters containing accent marks with equivalent characters that don't contain accent marks.

**Expression:**
```
NormalizeDiacritics([givenName])
```

**Sample input/output:**

- **INPUT (givenName):** "Zoë"
- **OUTPUT:** "Zoe"

### Not Function

**Function:** Not(source)
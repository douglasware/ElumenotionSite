## Parameters

| Name  | Required/ Repeating | Type     | Notes                                     |
|-------|---------------------|----------|-------------------------------------------|
| source | Required           | String   | Usually name of the attribute.            |
| start  | Required           | Integer  | Index in the source string where substring should start. |
| length | Required           | Integer  | Length of the substring. |

## NormalizeDiacritics

### Function: NormalizeDiacritics(source)

**Description:**
Requires one string argument. Returns the string, but with any diacritical characters replaced with equivalent nondiacritical characters. Typically used to convert first names and last names containing diacritical characters into legal values for various user identifiers.

### Parameters:

| Name  | Required/ Repeating | Type   | Notes                                |
|-------|---------------------|--------|--------------------------------------|
| source | Required           | String | Usually a first name or last name attribute. |

### Diacritic Conversion Table

| Character with Diacritic     | Normalized Character | Character with Diacritic | Normalized Character |
|------------------------------|----------------------|--------------------------|----------------------|
| á, à, â, ã, å, ā, ă, ą, ä, ã | a                    | Á, À, Â, Ã, Å, Ā, Ă, Ą, Ä, Ã | A                    |
| æ, ä                         | ae                   | Æ, Ä                     | AE                   |
| ç, ć, č, ĉ, ç                | c                    | Ç, Ć, Č, Ĉ, Ç            | C                    |
| đ, ď, đ                      | d                    | Đ, Ď, Đ                  | D                    |
| é, è, ê, ē, ĕ, ė, ë, ē, ė, ë  | e                    | É, È, Ê, Ē, Ĕ, Ė, Ë, Ē, Ė, Ë  | E                    |
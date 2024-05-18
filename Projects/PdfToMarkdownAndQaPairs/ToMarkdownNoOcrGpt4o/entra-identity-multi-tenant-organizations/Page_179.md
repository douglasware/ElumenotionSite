## Source and Substring

| Name   | Required/ Repeating | Type    | Notes                                                                                                          |
|--------|----------------------|---------|---------------------------------------------------------------------------------------------------------------|
| source | Required             | String  | Usually name of the attribute.                                                                                 |
| start  | Required             | Integer | Index in the source string where substring should start. First character in the string has an index of 1, second character has an index 2, and so on. |
| length | Required             | Integer | Length of the substring. If length ends outside the source string, function returns substring from start index until end of source string. |

## NormalizeDiacritics

### Function

NormalizeDiacritics(source)

### Description

Requires one string argument. Returns the string, but with any diacritical characters replaced with equivalent nondiacritical characters. Typically used to convert first names and last names containing diacritical characters (accent marks) into legal values that can be used in various user identifiers such as user principal names, SAM account names, and email addresses.

### Parameters:

| Name   | Required/ Repeating | Type   | Notes                                     |
|--------|----------------------|--------|-------------------------------------------|
| source | Required             | String | Usually a first name or last name attribute. |

### Character Mapping Table

| Character with Diacritic                                                                                   | Normalized character | Character with Diacritic                                                                                      | Normalized character |
|-------------------------------------------------------------------------------------------------------------|----------------------|---------------------------------------------------------------------------------------------------------------|----------------------|
| ä, à, á, â, ã, ā, ă, ą, å, ǟ, à, ȁ, Ả, Ạ, Ậ, Ắ, Ằ, Ẳ, Ẵ, Ặ | a                   | Ä, À, Á, Â, Ã, Ǎ, Ā, Ă, Å, Ǟ, Á, À, À, À, Ả, Ạ, Ậ, Ắ, Ằ, Ẳ, Ẵ, Ặ | A                   |
| æ, ǣ                                                                                                      | ae                  | Æ, Ǣ                                                                                                          | AE                  |
| ç, č, ć, ċ, c                                                                                             | c                   | Ç, Č, Ć, Ċ, Ĉ                                                                                               | C                   |
| ď, ḑ, ḏ                                                                                                  | d                   | Ď, Ḍ, Ḑ                                                                                                      | D                   |
| ē, ė, è, é, ë, ě, ȅ, ê, ệ, ȇ, ȩ                                                                          | e                   | Ē, Ê, É, È, Ë, Ě, Ȅ, Ë, Ĕ, Ế, Ề, Ẽ, Ệ, Ȇ                                                                     | E                   |
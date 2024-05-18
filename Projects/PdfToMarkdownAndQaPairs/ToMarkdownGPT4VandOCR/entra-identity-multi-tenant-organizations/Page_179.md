## Parameters

| Name  | Required/ Repeating | Type    | Notes                                           |
|-------|---------------------|---------|-------------------------------------------------|
| source | Required            | String  | Usually name of the attribute.                  |
| start | Required            | Integer | Index in the source string where substring should start. First character in the string has an index of 1, second character has an index 2, and so on. |
| length | Required            | Integer | Length of the substring. If length ends outside the source string, function returns substring from start index until end of source string. |

## NormalizeDiacritics

### Function: NormalizeDiacritics(source)

### Description:
Requires one string argument. Returns the string, but with any diacritical characters replaced with equivalent nondiacritical characters. Typically used to convert first names and last names containing diacritical characters (accent marks) into legal values that can be used in various user identifiers such as user principal names, SAM account names, and email addresses.

### Parameters:

| Name  | Required/ Repeating | Type    | Notes                                           |
|-------|---------------------|---------|-------------------------------------------------|
| source | Required            | String  | Usually a first name or last name attribute.    |

### Character with Diacritic and Normalized Characters

| Character with Diacritic | Normalized character | Character with Diacritic | Normalized character |
|--------------------------|----------------------|--------------------------|----------------------|
| ä, à, â, ã, å, á, ą, ā, ă, ắ, ằ, ẳ, ẵ, ặ          | a                    | Ä, À, Â, Ã, Å, Á, Ą, Ā, Ă, Ắ, Ằ, Ẳ, Ẵ, Ặ        | A                    |
| æ, ǽ                    | ae                   | Æ, Ǽ                   | AE                   |
| ç, ĉ, ċ, č, ć           | c                    | Ç, Ĉ, Ċ, Č, Ć          | C                    |
| đ, ď, d                 | d                    | Đ, Ď, D                | D                    |
| ë, è, é, ê, ę, ě, ē, ẻ, ẽ, ẹ, ệ, e            | e                    | Ë, È, É, Ê, Ę, Ě, Ē, Ẻ, Ẽ, Ẹ, Ệ, E            | E                    |
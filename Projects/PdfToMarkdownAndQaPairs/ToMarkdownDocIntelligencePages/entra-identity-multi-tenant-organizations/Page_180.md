
| Character with Diacritic | Normalized character | Character with Diacritic | Normalized character |
| - | - | - | - |
| ğ, ğ, g | g | Ğ, Ğ, Ģ | G |
| ï, î, ì, í, ı, ī, Í, ì, î, ĩ, į | | <1- 21 | - :unselected: |
| [', ł, I, [, ] | | Ł, Ľ, L, GL | L :unselected: |
| ñ, ń, ň, n̄, ṋ | n | Ñ, Ń, Ň, N̄, Ņ | N :selected: |
| ö, ò, ő, õ, ô, ó, ō, ố, ồ, ô, õ, ô, ö, ọ, õ, ỏ, o | O :unselected: | Ö, Ò, Ő, Õ, Ô, Ó, ô, Ô, Ò, ô, :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected: :unselected:  Õ, Ô, Ö, Q, õ, ỏ, 0| O :unselected: |
| Ø,ø, œ :selected: | oe | Ø,Ø, Œ :selected: | OE :unselected: |
| ř, r, r, r | r | Ř, Ř, R, Ř | R |
| ß | SS | | |
| š, Ś, ș, ș, š, S | S | Š, Ś, Ș, Ș, Š, S | S |
| ť, ț, t, t | t | Ť, Ț, Ī, Ţ | T |
| ü, ù, û, ú, ů, ű, ū, ú, ù, û, ũ, ū, ū, ũ, u̱, u̱ | u || Ü, Ù, Û, Ú, Ů, Ű, Ū, Ú, Ù, Û, Õ, U | Ú, Ü, Ü, Ų, U 
| ÿ, ý, ÿ, ý, ỳ, ỹ, y | y | Ÿ, Ý, Y, Ý, Ỳ, Ý, Y | Y |
| ź, ž, ż, ž, z | Z | Ź, Ž, Ż,Ż,Z | Z |


# Remove diacritics from a string

Example: Replace characters containing accent marks with equivalent characters that don't contain accent marks.

Expression: NormalizeDiacritics([givenName])

Sample input/output:

· INPUT (givenName): "Zoë"

· OUTPUT: "Zoe"

Not

Function: Not(source)

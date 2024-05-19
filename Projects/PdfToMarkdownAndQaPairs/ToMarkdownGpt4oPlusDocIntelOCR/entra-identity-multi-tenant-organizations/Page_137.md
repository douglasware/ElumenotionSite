c. ENDS_WITH. Clause returns "true" if the evaluated attribute ends with the input string value.

d. EQUALS. Clause returns "true" if the evaluated attribute matches the input string value exactly (case sensitive).

e. Greater_Than. Clause returns "true" if the evaluated attribute is greater than the value. The value specified on the scoping filter must be an integer and the attribute on the user must be an integer [0,1,2, ... ].

f. Greater_Than_OR_EQUALS. Clause returns "true" if the evaluated attribute is greater than or equal to the value. The value specified on the scoping filter must be an integer and the attribute on the user must be an integer [0,1,2, ... ].

g. Includes. Clause returns "true" if the evaluated attribute contains the string value (case sensitive) as described here.

h. IS FALSE. Clause returns "true" if the evaluated attribute contains a Boolean value of false.

i. IS NOT NULL. Clause returns "true" if the evaluated attribute isn't empty.

j. IS NULL. Clause returns "true" if the evaluated attribute is empty.

k. IS TRUE. Clause returns "true" if the evaluated attribute contains a Boolean value of true.

l. NOT EQUALS. Clause returns "true" if the evaluated attribute doesn't match the input string value (case sensitive).

m. NOT REGEX MATCH. Clause returns "true" if the evaluated attribute doesn't match a regular expression pattern. It returns "false" if the attribute is null / empty.

n. REGEX MATCH. Clause returns "true" if the evaluated attribute matches a regular expression pattern. For example: ([1-9][0-9]) matches any number between 10 and 99 (case sensitive).

**Figure Description:** An information box highlights several important notes: 
- The IsMemberOf filter is not supported currently.
- The members attribute on a group is not supported currently.
- Filtering is not supported for multi-valued attributes.
- Scoping filters will return "false" if the value is null / empty.

```mermaid
rect InfoBox
    NoteA["The IsMemberOf filter is not supported currently."]
    NoteB["The members attribute on a group is not supported currently."]
    NoteC["Filtering is not supported for multi-valued attributes."]
    NoteD["Scoping filters will return 'false' if the value is null / empty."]
end
```
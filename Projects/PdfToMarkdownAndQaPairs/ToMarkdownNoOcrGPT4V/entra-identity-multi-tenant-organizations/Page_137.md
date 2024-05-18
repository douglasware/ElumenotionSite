### C. ENDS_WITH
Clause returns "true" if the evaluated attribute ends with the input string value.

### D. EQUALS
Clause returns "true" if the evaluated attribute matches the input string value exactly (case sensitive).

### E. Greater_Than
Clause returns "true" if the evaluated attribute is greater than the value. The value specified on the scoping filter must be an integer and the attribute on the user must be an integer [0,1,2,...].

### F. Greater_Than_OR_EQUALS
Clause returns "true" if the evaluated attribute is greater than or equal to the value. The value specified on the scoping filter must be an integer and the attribute on the user must be an integer [0,1,2,...].

### G. Includes
Clause returns "true" if the evaluated attribute contains the string value (case sensitive) as described here.

### H. IS_FALSE
Clause returns "true" if the evaluated attribute contains a Boolean value of false.

### I. IS_NOT_NULL
Clause returns "true" if the evaluated attribute isn't empty.

### J. IS_NULL
Clause returns "true" if the evaluated attribute is empty.

### K. IS_TRUE
Clause returns "true" if the evaluated attribute contains a Boolean value of true.

### L. NOT_EQUALS
Clause returns "true" if the evaluated attribute doesn't match the input string value (case sensitive).

### M. NOT_REGEX_MATCH
Clause returns "true" if the evaluated attribute doesn't match a regular expression pattern. It returns "false" if the attribute is null / empty.

### N. REGEX_MATCH
Clause returns "true" if the evaluated attribute matches a regular expression pattern. For example: `([1-9][0-9])` matches any number between 10 and 99 (case sensitive).

### Important
- The IsMemberOf filter is not supported currently.
- The members attribute on a group is not supported currently.
- Filtering is not supported for multi-valued attributes.
- Scoping filters will return "false" if the value is null / empty.
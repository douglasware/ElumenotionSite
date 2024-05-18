| Name       | Required/ Repeating | Type       | Notes                        |
|------------|---------------------|------------|------------------------------|
| Expression | Required            | Expression | Expression to be evaluated   |

# Item

Function: Item(attribute, index)

Description: The Item function returns one item from a multi-valued string/attribute. 

Parameters:

| Name      | Required/ Repeating | Type      | Notes                                      |
|-----------|---------------------|-----------|--------------------------------------------|
| attribute | Required            | Attribute | Multi-valued attribute to be searched      |
| index     | Required            | Integer   | Index to an item in the multi-valued string|

Example: `Item([proxyAddresses], 1)` returns the first item in the multi-valued attribute. Index 0 shouldn't be used.

# Join

Function: Join(separator, source1, source2, ...)

Description: Join() is similar to Append(), except that it can combine multiple source string values into a single string, and each value will be separated by a separator string.

If one of the source values is a multi-value attribute, then every value in that attribute will be joined together, separated by the separator value.

Parameters:

| Name      | Required/ Repeating | Type   | Notes                                                                                    |
|-----------|---------------------|--------|------------------------------------------------------------------------------------------|
| separator | Required            | String | String used to separate source values when they are concatenated into one string. Can be "" if no separator is required. |
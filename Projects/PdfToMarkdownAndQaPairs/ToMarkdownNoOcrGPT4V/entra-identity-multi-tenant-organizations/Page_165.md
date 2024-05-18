## Example 1

- **OUTPUT:** "3/16/2020 7:00:00 AM" <-- Note the UTC equivalent of the above DateTime is returned

## Example 2

CDate("2021-06-30+08:00")

### Sample input/output:

- **INPUT:** "2021-06-30+08:00"
- **OUTPUT:** "6/29/2021 4:00:00 PM" <-- Note the UTC equivalent of the above DateTime is returned

## Example 3

CDate("2009-06-15T01:45:30-07:00")

### Sample input/output:

- **INPUT:** "2009-06-15T01:45:30-07:00"
- **OUTPUT:** "6/15/2009 8:45:30 AM" <-- Note the UTC equivalent of the above DateTime is returned

## Coalesce

### Function: Coalesce(source1, source2, ..., defaultValue)

### Description:

Returns the first source value that isn't NULL. If all arguments are NULL and defaultValue is present, the defaultValue is returned. If all arguments are NULL and defaultValue isn't present, Coalesce returns NULL.

### Parameters:

| Name          | Required/ Repeating | Type   | Notes                                                    |
|---------------|---------------------|--------|----------------------------------------------------------|
| source1 ... sourceN | Required            | String | Required, variable-number of times. Usually name of the attribute from the source object. |
| defaultValue  | Optional            | String | Default value to be used when all source values are NULL. Can be empty string ("").     |

### Flow

Flow mail value if not NULL, otherwise flow userPrincipalName
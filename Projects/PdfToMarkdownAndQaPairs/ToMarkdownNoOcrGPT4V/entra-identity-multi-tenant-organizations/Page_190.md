## SelectUniqueValue

### Function:
`SelectUniqueValue(uniqueValueRule1, uniqueValueRule2, uniqueValueRule3, ...)`

### Description:
Requires a minimum of two arguments, which are unique value generation rules defined using expressions. The function evaluates each rule and then checks the value generated for uniqueness in the target app/directory. The first unique value found will be the one returned. If all of the values already exist in the target, the entry will get escrowed, and the reason gets logged in the audit logs. There is no upper bound to the number of arguments that can be provided.

- This function must be at the top-level and cannot be nested.
- This function cannot be applied to attributes that have a matching precedence.
- This function is only meant to be used for entry creations. When using it with an attribute, set the Apply Mapping property to Only during object creation.
- This function is currently only supported for "Workday to Active Directory User Provisioning" and "SuccessFactors to Active Directory User Provisioning". It cannot be used with other provisioning applications.
- The LDAP search that `SelectUniqueValue` function performs in on-premises Active Directory doesn't escape special characters like diacritics. If you pass a string like "Jessica Smith" that contains a special character, you will encounter processing errors. Nest the `NormalizeDiacritics` function as shown in the example below to normalize special characters.

### Parameters:

| Name               | Required/ Repeating | Type  | Notes                                          |
|--------------------|---------------------|-------|------------------------------------------------|
| uniqueValueRule1… | At least 2 are required, no upper bound | String | List of unique value generation rules to evaluate. |

### Generate unique value for userPrincipalName (UPN) attribute
Example: Based on the user's first name, middle name and last name, you need to generate a value for the UPN attribute and check for its uniqueness in the target AD directory before assigning the value to the UPN attribute.

#### Expression:
`ad-attr-mapping-expr`
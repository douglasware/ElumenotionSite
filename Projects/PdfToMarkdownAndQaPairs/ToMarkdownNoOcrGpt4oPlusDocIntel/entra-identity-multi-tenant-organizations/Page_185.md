<!-- PageHeader="[] Expand table" -->

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| attribute/value | Required | String | Specify the attribute or constant / string to redact from the logs. |

Example 1: Redact an attribute: Redact([userPrincipalName]) Removes the userPrincipalName from the provisioning logs.

Example 2: Redact a string: Redact("StringToBeRedacted") Removes a constant string from the provisioning logs.

Example 3: Redact a random string: Redact(RandomString(6,3,0,0,3)) Removes the random string from the provisioning logs.

# RemoveDuplicates

Function: RemoveDuplicates(attribute)

Description: The RemoveDuplicates function takes a multi-valued string and make sure each value is unique.

Parameters:

<!-- PageHeader="[] Expand table" -->

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| attribute | Required | Multi-valued Attribute | Multi-valued attribute that has duplicates removed |

Example: RemoveDuplicates([proxyAddresses]) Returns a sanitized proxyAddress attribute where all duplicate values are removed.

## Replace

Function: Replace(source, oldValue, regexPattern, regexGroupName, replacementValue, replacementAttributeName, template)

Description: Replaces values within a string in a case-sensitive manner. The function behaves differently depending on the parameters provided:
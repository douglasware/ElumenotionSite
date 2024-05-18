Description: Used to configure multiple roles for a user. For detailed usage, see Tutorial - Customize user provisioning attribute-mappings for SaaS applications in Microsoft Entra ID.

Parameters:

![A table that lists parameters for configuring multiple roles for a user. The columns include Name, Required/Repeating, Type, and Notes.]

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| [appRoleAssignments] | Required | String | [appRoleAssignments] object. |


# BitAnd

Function: BitAnd(value1, value2)

Description: This function converts both parameters to the binary representation and sets a bit to:

· 0 - if one or both of the corresponding bits in value1 and value2 are 0

· 1 - if both of the corresponding bits are 1.

In other words, it returns 0 in all cases except when the corresponding bits of both parameters are 1.

Parameters:

![A table listing parameters for the BitAnd function. The columns include Name, Required/Repeating, Type, and Notes.]

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| value1 | Required | Num | Numeric value that should be AND'ed with value2 |
| value2 | Required | Num | Numeric value that should be AND'ed with value1 |

Example: BitAnd(&HF, &HF7)

11110111 AND 00000111 = 00000111 so BitAnd returns 7, the binary value of 00000111.

CBool

Function: CBool(Expression)
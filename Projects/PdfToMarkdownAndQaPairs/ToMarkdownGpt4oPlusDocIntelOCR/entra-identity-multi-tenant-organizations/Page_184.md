Description: The RandomString function generates a random string based on the conditions specified. Characters allowed can be identified here.

Parameters:

![Description of Figures: Illustrated icon represents an expandable table element.](figure1.png)

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| Length | Required | Number | Total length of the random string. This should be greater than or equal to the sum of MinimumNumbers, MinimumSpecialCharacters, and MinimumCapital. 256 characters max. |
| MinimumNumbers | Required | Number | Minimum numbers in the random string. |
| MinimumSpecialCharacters | Required | Number | Minimum number of special characters. |
| MinimumCapital | Required | Number | Minimum number of capital letters in the random string. |
| MinimumLowerCase | Required | Number | Minimum number of lower case letters in the random string. |
| CharactersToAvoid | Optional | String | Characters to be excluded when generating the random string. |

Example 1: - Generate a random string without special character restrictions: RandomString(6,3,0,0,3) Generates a random string with 6 characters. The string contains 3 numbers and 3 lower case characters (1a73qt).

Example 2: - Generate a random string with special character restrictions: RandomString(10,2,2,2,1,"?,") Generates a random string with 10 characters. The string contains at least 2 numbers, 2 special characters, 2 capital letters, 1 lower case letter and excludes the characters "?" and "," (1@!2BaRg53).

Redact

Function: Redact()

Description: The Redact function replaces the attribute value with the string literal " [Redact]" in the provisioning logs.

Parameters:

```mermaid
graph TD;
    ExpandTable["Expandable table element representation"]
```
## 7. Set the Mapping type to Expression.

## 8. In the Expression box, enter the transformation expression.

For example, with the display name, you can do the following:
- Flip the first name and last name and add a comma in between.
- Add the domain name in parentheses at the end of the display name.

For examples, see [Reference for writing expressions for attribute mappings](https://example.com/reference) in Microsoft Entra ID.

### Edit Attribute

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g., Users) should flow to and from this application.

| Mapping type | Expression |
| --- | --- |
| Expression | `[displayName]` |
| The expression was correctly parsed. |  |
| Default value if null (optional) |  |
| Use the expression builder |  |
| Target attribute * | `displayName` |

[Ok]

> **Tip**
> 
> You can map directory extensions by updating the schema of the cross-tenant synchronization. For more information, see [Map directory extensions in cross-tenant synchronization](https://example.com/map-directory-extensions).

## Step 10: Specify additional provisioning settings

Source tenant
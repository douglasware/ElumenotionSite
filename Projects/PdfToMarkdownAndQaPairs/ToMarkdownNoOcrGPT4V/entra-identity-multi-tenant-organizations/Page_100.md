## Note

If the B2B user already exists in the target tenant then Member (userType) will not changed to Member, unless the Apply this mapping setting is set to Always.

### User Type Limitations

The user type you choose has the following limitations for apps or services:

| App or service    | Limitations |
| ----------------- | ----------------------------------------------------------------------------------------- |
| Power BI          | Support for UserType Member in Power BI is currently in preview. For more information, see [Distribute Power BI content to external guest users with Microsoft Entra B2B.](https://linktopowerbi.com) |
| Azure Virtual Desktop | External member and external guest aren't supported in Azure Virtual Desktop. |

### Edit Attribute

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g., Users) should flow to and from this application.

- Mapping type: Constant
- Constant Value: Member
- Target attribute: userType
- Match objects using this attribute: No
- Matching precedence: 0
- Apply this mapping: Only during object creation

### Attribute Transformations

If you want to define any transformations, on the **Attribute Mapping** page, select the attribute you want to transform, such as displayName.
1. Note

If the B2B user already exists in the target tenant then Member (userType) will not changed to Member, unless the Apply this mapping setting is set to Always.

The user type you choose has the following limitations for apps or services (but aren't limited to):

**(Table Description: The table outlines various applications or services and their limitations when working with different user types.)**

| App or service        | Limitations                                                                                                                                         |
|-----------------------|------------------------------------------------------------------------------------------------------------------------------------------------------|
| Power BI              | - Support for UserType Member in Power BI is currently in preview. For more information, see Distribute Power BI content to external guest users with Microsoft Entra B2B. |
| Azure Virtual Desktop | - External member and external guest aren't supported in Azure Virtual Desktop.                                                                      |

... > Cross-tenant synchronization | Configurations > Fabrikam to Contoso | Provisioning >

# Edit Attribute

*(Figure illustrating the interface for editing attribute mappings.)*

```
**MermaidJS Description: Diagram to represent the attribute mapping process.**

graph TD;
    A["Mapping Attributes"] --> B["Source Tenant Attributes"];
    B --> C["Target Tenant Attributes"];
    C --> D["Transform Attributes"];
    D --> E["Apply Mapping"];
```

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g. Users) should flow to and from this application.

Mapping type

**(Dropdown to select mapping type)**

| Constant | V |

**(Input fields and selection checkboxes for configuring the mapping)**

| Constant Value * | ❌ |
| Member | V |

**(More options for selecting attribute settings)**

Target attribute * ❌ userType

V

Match objects using this attribute No

V

Matching precedence
❌ 0

Apply this mapping 
Only during object creation

V

+

6. If you want to define any transformations, on the Attribute Mapping page, select the attribute you want to transform, such as displayName.

Ok
❌
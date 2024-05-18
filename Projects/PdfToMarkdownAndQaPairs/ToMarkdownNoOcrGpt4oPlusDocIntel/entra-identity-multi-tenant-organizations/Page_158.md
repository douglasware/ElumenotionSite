<figure>

Description: Screenshot showing the "Edit Attribute List" page in the Fabrikam to Contoso | Provisioning | Attribute Mapping interface. Various attributes like "alternativeSecurityIds", "showInAddressList", "mail", "userState", "userType", and "extension_c44d2adc1ddd4..." are listed with corresponding data types (String, Boolean) and options to select or unselect these attributes. Tips for editing the attribute list are provided at the bottom.

<figcaption>Fabrikam to Contoso | Provisioning | Attribute Mapping | Edit Attribute List</figcaption>

</figure>

```mermaid
graph TD;
    A["alternativeSecurityIds (String)"] --> | "Unselected" | B;
    C["showInAddressList (Boolean)"] --> | "Unselected" | D;
    E["mail (String)"] --> | "Unselected" | F;
    G["userState (String)"] --> | "Unselected" | H;
    I["userType (String)"] --> | "Unselected" | J;
    K["extension_c44d2adc1ddd4... (String)"] --> | "Selected" | L;
    M["Another (String)"] --> | "Unselected" | N;
```

| alternativeSecuritylds | String || ❌ | ❌ | ✅ |
| - | - | - | - | - | - |
| showInAddressList | Boolean || ❌ | ❌ | ❌ |
| mail | String | | ❌ | ❌ | ❌ |
| userState | String | | ❌ | ❌ | ❌ |
| userType | String | | ❌ | ❌ | ❌ |
| extension\_c44d2adc1ddd4 ... | String | V | ❌ | ✅ | ❌ |
| | String | 1 | ❌ | ❌ | ❌ |

10. Select Save.

11. Refresh the browser.

12. Browse to the Attribute mappings page and try to map the directory extension as described earlier in this article.

# Manually add directory extensions by editing the schema

## Source tenant

Follow these steps to manually add directory extensions to the schema by using the schema editor.

1. Sign in to the Microsoft Entra admin center of the source tenant.

2. Browse to Identity > External Identities > Cross-tenant synchronization.

3. Select Configurations and then select your configuration.

4. Select Provisioning and expand the Mappings section.

5. Select Provision Microsoft Entra ID Users to open the Attribute Mapping page.
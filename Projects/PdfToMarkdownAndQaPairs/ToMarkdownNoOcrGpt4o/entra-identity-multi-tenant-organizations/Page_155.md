## Fabrikam to Contoso | Provisioning

### Admin Credentials

### Mappings

Mappings allow you to define how data should flow between Microsoft Entra ID and Azure Active Directory (target tenant).

| Name                               | Enabled |
|------------------------------------|---------|
| Provision Microsoft Entra ID Users | Yes     |

Restore default mappings

### Settings

Provisioning Status: On

5. Select **Provision Microsoft Entra ID Users** to open the **Attribute Mapping** page.

6. Scroll to the bottom of the page and select **Add new mapping**.

### Attribute Mapping

| Source Attribute     | Target Attribute      | Action |
|----------------------|-----------------------|--------|
| preferredLanguage    | preferredLanguage     | Delete |
| surname              | surname               | Delete |
| telephoneNumber      | telephoneNumber       | Delete |
| userPrincipalName    | userPrincipalName     | Delete |
| true                 | showInAddressList     | Delete |
| mail                 | mail                  | Delete |
| Member               | userType              | Delete |

Add New Mapping

7. In the **Source attribute** drop-down list, select a source attribute.

    If you created a directory extension in the source tenant, select the directory extension.

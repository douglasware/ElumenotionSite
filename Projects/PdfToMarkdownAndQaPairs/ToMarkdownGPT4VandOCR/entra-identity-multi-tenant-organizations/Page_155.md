## Home > Cross-tenant synchronization | Configurations > Fabrikam to Contoso

### Fabrikam to Contoso | Provisioning

**Fabrikam - Microsoft Entra ID**

- [ ] Save
- [ ] Discard

#### Overview
#### Admin Credentials
- [ ] Provision on demand

##### Manage
- Mappings
- Users and groups
- Provisioning
- Expression builder

##### Activity
- Audit logs
- Provisioning logs
- Insights

##### Troubleshooting + Support
- Settings
- New support request

##### Mappings

Mappings allow you to define how data should flow between Microsoft Entra ID and Azure Active Directory (target tenant).

| Name                               | Enabled |
| ---------------------------------- | ------- |
| Provision Microsoft Entra ID Users | Yes     |

- [ ] Restore default mappings

##### Provisioning Status
- [ ] On
- [ ] Off

5. Select **Provision Microsoft Entra ID Users** to open the **Attribute Mapping** page.
6. Scroll to the bottom of the page and select **Add new mapping**.

### Attribute Mapping

| Source Attribute  | Target Attribute  |      |
| ----------------- | ----------------- | ---- |
| preferredLanguage | preferredLanguage | Delete |
| surname           | surname           | Delete |
| telephoneNumber   | telephoneNumber   | Delete |
| userPrincipalName | userPrincipalName | Delete |
| true              | showInAddressList | Delete |
| mail              | mail              | Delete |
| Member            | userType          | Delete |

- [ ] Add New Mapping
- [ ] Show advanced options

7. In the **Source attribute** drop-down list, select a source attribute.

If you created a directory extension in the source tenant, select the directory extension.
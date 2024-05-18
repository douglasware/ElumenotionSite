## Fabrikam to Contoso | Provisioning
### Overview

**Manage**
- Users and groups
  - Provision on demand
- Mappings
  - Allow data flow between Microsoft Entra ID and Azure Active Directory (target tenant).
  ```markdown
  Name: Provision Microsoft Entra ID Users
  Enabled: Yes
  ```

**Activity**
- Audit logs
- Provisioning logs
- Insights

**Troubleshooting + Support**
- New support request

**Settings**
- Provisioning Status: On / Off

### Instructions

5. **Select `Provision Microsoft Entra ID Users` to open the Attribute Mapping page.**

6. **Scroll to the bottom of the page and select `Add new mapping`.**

### Attribute Mapping

| Source Attribute   | Mapping             |
|--------------------|---------------------|
| preferredlanguage | preferredlanguage   |
| surname           | surname             |
| telephoneNumber   | telephoneNumber     |
| userPrincipalName | userPrincipalName   |
| true              | showinAddressList   |
| mail              | mail                |
| Member            | userType            |

7. **In the Source attribute drop-down list, select a source attribute.**
   - If a directory extension exists in the source tenant, select the directory extension.
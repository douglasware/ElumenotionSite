## Home > Cross-tenant synchronization | Configurations > Fabrikam to Contoso
### Fabrikam to Contoso | Provisioning

---

### Overview

- Save
- Discard

#### Admin Credentials
- Provision on demand

#### Manage
- Mappings
- Users and groups

#### Activity
- Audit logs
- Provisioning logs
- Insights

#### Troubleshooting + Support
- Settings
- New support request

### Provisioning
Mappings allow you to define how data should flow between Microsoft Entra ID and Azure Active Directory (target tenant).

#### Mappings

| Name                               | Enabled |
| ---------------------------------- | ------- |
| Provision Microsoft Entra ID Users | Yes     |

---

- Restore default mappings
- Provisioning Status
  - On
  - Off

### Steps

1. Select Provision Microsoft Entra ID Users to open the Attribute Mapping page.
2. Under Source Object Scope, select All records.

## Attribute Mapping

- Save
- Discard

| Name                               | Enabled |
| ---------------------------------- | ------- |
| Provision Microsoft Entra ID Users | Yes     |

| Source Object | Source Object Scope |
| ------------- | ------------------- |
| User          | All records         |

| Target Object Actions |
| -------------------- |
| Create               |
| Update               |
| Delete               |

3. On the Source Object Scope page, select Add scoping filter.
4. Add any scoping filters to define which users are in scope for provisioning.
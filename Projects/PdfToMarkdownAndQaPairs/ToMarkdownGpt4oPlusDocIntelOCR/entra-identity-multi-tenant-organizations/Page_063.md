provisioned into their tenant and perform the necessary approvals in their tenant, topology 2 will best meet their needs.

Deployment considerations
===

Monitoring

Actions performed by a SOC analyst in Microsoft Entra are audited in the Microsoft Entra tenant that they're working in. Organizations can maintain an audit trail of actions performed, generate alerts when specific actions are performed, and analyze actions performed by pushing audit logs into Azure Monitor.

Learn more

Actions performed by a SOC analyst in Microsoft Defender are also audited.

Learn more

Scaling deployment with PowerShell / APIs

Every step that is configured through the user interface in Microsoft Entra has accompanying Microsoft Graph APIs and PowerShell commandlets, enabling you to deploy your desired policies/configuration across the tenants in your organization.

Expand table

| Capability | Microsoft Graph API | PowerShell |
| - | - | - |
| Cross-tenant synchronization | Link | Link |
| Entitlement management | Link | Link |
| Cross-tenant access policies | Link | Link |

Role-based access control

Configuring the capabilities described in topology 1 and topology 2 require the following roles:

- Configuring cross-tenant access settings - Security Administrator
- Configuring cross-tenant synchronization - Hybrid Identity Administrator
- Configuring entitlement management - Identity Governance Administrator
- Microsoft Defender supports both built-in roles such as Security Reader, Security Administrator, and Security Operator and custom roles.
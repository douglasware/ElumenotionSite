## External Identities | Cross-tenant access settings

### Cross-tenant settings
- Contoso - Microsoft Entra ID for workforce

### Add an external Microsoft Entra tenant by
- Search

### Overview
- Tenant ID or domain name

### Cross-tenant access settings
- Organizational settings
- Default settings
- Microsoft cloud settings

### External collaboration settings
- All identity providers
- Self-service sign up
- Custom user attributes
- All API connectors
- Custom authentication extensions (Preview)
- User flows

### Subscriptions
- Linked subscriptions

| Name | Inbound access |
| ---- | -------------- |
|      |  Add  |
|      | Discard |

5. Under Inbound access of the added organization, select Inherited from default.
6. Select the Cross-tenant sync tab.
7. Check the Allow users sync into this tenant check box.

### Inbound access settings - Fabrikam

- B2B collaboration
- B2B direct connect
- Trust settings
- Cross-tenant sync

> Enabling this will allow the admin of the specified (source) tenant to sync objects into this (target) tenant.
> 
> Disabling this will block admins of the source tenant from syncing objects into the target tenant but will not remove currently synced objects. We recommend that this setting should only be used between tenants that are part of the same organization.

- [ ] Allow users sync into this tenant

| | |
|-|-|
| Save | Discard |

8. Select Save.

9. If you see an Enable cross-tenant sync and auto-redemption dialog box asking if you want to enable auto-redemption, select Yes.

> Selecting Yes will automatically redeem invitations in the target tenant.
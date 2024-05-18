## External Identities | Cross-tenant access settings

### Overview
- **Cross-tenant access settings**
- Organizational settings
- Default settings
- Microsoft cloud settings
  - Add organization
  - Refresh
  - Columns

#### Inbound access settings
- **External collaboration settings**
- Diagnose and solve problems
- Self-service sign up
- Custom user attributes
- AI API connectors
- User flows
- Linked subscriptions

**Search by domain name or tenant ID**

| Name  | Inbound Access |
| ------ | --------------- |
| <No organizations found> | |

### Steps to Manage Access

5. **Inbound Access**
   - Under Inbound access of the added organization, select `Inherited from default`.

6. **Cross-tenant Sync Tab**
   - Select the Cross-tenant sync tab.

7. **User Sync Settings**
   - Check the `Allow users sync into this tenant` checkbox.

   ![Inbound access settings - Fabrikam](image-link-here)  
   - *Note: Enabling will allow the admin of the specified (source) tenant to sync objects into this (target) tenant. Disabling will block admins of the source tenant from syncing objects into the target tenant but will not remove currently synced objects. This setting should only be used between tenants that are part of the same organization.*

8. **Save Settings**
   - Select Save.

9. **Enable Cross-tenant Sync and Auto-redemption**
   - If you see an Enable cross-tenant sync and auto-redemption dialog box asking if you want to enable auto-redemption, select `Yes`.
     - Selecting Yes will automatically redeem invitations in the target tenant.
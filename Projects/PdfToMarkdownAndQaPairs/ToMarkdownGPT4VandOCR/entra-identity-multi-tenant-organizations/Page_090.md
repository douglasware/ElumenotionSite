## Inbound Access Settings - Fabrikam

### B2B Collaboration
### B2B Direct Connect
### Trust Settings
### Cross-tenant Sync

Enabling this will allow the admin of the other tenant to sync and access objects in your tenant.  
Disabling this will block admins of the other tenant from syncing and accessing, but will not remove currently synced objects. We recommend that this setting only be enabled for admin of the same organization.

- [ ] Allow users sync into this tenant

[Save](#) [Discard](#)

### Step 3: Automatically Redeem Invitations in the Target Tenant

#### Target Tenant

In this step, you automatically redeem invitations so users from the source tenant don't have to accept the consent prompt. This setting must be checked in both the source tenant (outbound) and target tenant (inbound). For more information, see [Automatic redemption setting](#).

1. In the target tenant, on the same Inbound access settings page, select the Trust settings tab.
2. Check the **Automatically redeem invitations with the tenant <tenant>** checkbox.

   This box might already be checked if you previously selected Yes in the Enable cross-tenant sync and auto-redemption dialog box.

   #### Automatic Redemption

   - [ ] Check this setting if you want to automatically redeem invitations. If so, users from the specified tenant won't have to accept the consent prompt the first time they access this tenant using cross-tenant synchronization, B2B collaboration, or B2B direct connect. This setting will only suppress the consent prompt if the specified tenant checks this setting for outbound access as well.

   - [ ] Automatically redeem invitations with the tenant Fabrikam.

[Save](#) [Discard](#)

3. Select Save.
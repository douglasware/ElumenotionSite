## Outbound access settings - Contoso

### B2B collaboration
### B2B direct connect
### Trust settings

- **Automatic redemption**
  - Check this setting if you want to automatically redeem invitations. If so, users from this tenant don't have to accept the consent prompt the first time they access the specified tenant using cross-tenant synchronization, B2B collaboration, or B2B direct connect. This setting will only suppress the consent prompt if the specified tenant checks this setting for inbound access as well.
  - Automatically redeem invitations with the tenant Contoso.

8. Select **Save**.

## Step 5: Create a configuration in the source tenant

### Source tenant

1. In the source tenant, browse to Identity > External Identities > Cross-tenant synchronization.
2. Select **Configurations**.
3. At the top of the page, select **New configuration**.
4. Provide a name for the configuration and select **Create**.

   It can take up to 15 seconds for the configuration that you just created to appear in the list.

## Step 6: Test the connection to the target tenant

### Source tenant

1. In the source tenant, you should see your new configuration. If not, in the configuration list, select your configuration.
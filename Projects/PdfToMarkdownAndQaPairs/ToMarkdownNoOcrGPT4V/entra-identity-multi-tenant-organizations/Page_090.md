## Inbound Access Settings - Fabrikam

### Enable Cross-Tenant Sync and Auto-Redemption

To enable this setting:

- **Target Tenant**: Automatically redeem invitations so users from the source tenant don't have to accept the consent prompt.

#### Step-by-Step Instructions:

1. On the **Inbound access settings** page, navigate to the **Trust settings** tab.
2. Enable the **Automatically redeem invitations with the tenant <tenant>** checkbox. (Note that if you previously enabled cross-tenant sync and auto-redemption, this might already be selected.)

   ```
   |  | Setting |
   |---|---------|
   | ![checkbox](checked) | Automatically redeem invitations with the tenant Fabrikam |
   ```

3. Confirm by clicking **Save**.

### Important Notes

- This setting must be enabled in both the source (outbound) and target (inbound) tenants.
- For more details on how to configure these settings effectively, refer to the [Automatic redemption setting](#) documentation.
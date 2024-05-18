## Step 6: Test Connection

1. In the **Tenant Id** box, enter the tenant ID of the target tenant.
2. Select **Test Connection** to test the connection.

You should see a message that the supplied credentials are authorized to enable provisioning. If the test connection fails, see [Troubleshooting tips](#) later in this article.

### Notifications

```
Testing connection to Fabrikam to Contoso
The supplied credentials are authorized to enable provisioning
```

3. Select **Save**.

Mappings and Settings sections appear.

4. Close the Provisioning page.

## Step 7: Define who is in scope for provisioning

### Source tenant

The Microsoft Entra provisioning service allows you to define who will be provisioned in one or both of the following ways:

- Based on assignment to the configuration
- Based on attributes of the user

Start small. Test with a small set of users before rolling out to everyone. When the scope for provisioning is set to assigned users and groups, you can control it by assigning one or two users to the configuration. You can further refine who is in scope for provisioning by creating attribute-based scoping filters, described in the next step.

1. In the source tenant, select **Provisioning** and expand the **Settings** section.
## Audit logs

You can also view audit logs in the target tenant.

4. In the target tenant, select **Users** > **Audit logs** to view logged events for user management.

### Step 14: Configure leave settings

#### Target tenant

Even though users are being provisioned in the target tenant, they still might be able to remove themselves. If users remove themselves and they are in scope, they'll be provisioned again during the next provisioning cycle. If you want to disallow the ability for users to remove themselves from your organization, you must configure the External user leave settings.

1. In the target tenant, browse to **Identity** > **External Identities** > **External collaboration settings**.
2. Under **External user leave settings**, choose whether to allow external users to leave your organization themselves.
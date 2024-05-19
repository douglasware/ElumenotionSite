Here's the primary constraint with using B2B direct connect across multiple tenants:

- Currently, B2B direct connect works only with Teams Connect shared channels.

B2B direct connect users -> Tenant -> Primary tenant -> Teams Connect shared channels -> Tenant -> B2B direct connect users

For more information, see B2B direct connect overview.

# B2B collaboration

To enable users across tenants to collaborate, you can use Microsoft Entra B2B collaboration. B2B collaboration is a feature within External Identities that lets you invite guest users to collaborate with your organization. Once the external user has redeemed their invitation or completed sign-up, they're represented in your tenant as a user object. With B2B collaboration, you can securely share your company's applications and services with external users, while maintaining control over your own corporate data.

Here are the primary constraints with using B2B collaboration across multiple tenants:

- Administrators must invite users using the B2B invitation process or build an onboarding experience using the B2B collaboration invitation manager.
- Administrators might have to synchronize users using custom scripts.
- Depending on automatic redemption settings, users might need to accept a consent prompt and follow a redemption process in each tenant.
- By default, users are of type external guest, which has different permissions than external member and might not be the desired user experience.

B2B collab users -> Tenant -> (Microsoft apps, Non-Microsoft apps) -> Primary tenant -> B2B collab users

```mermaid
graph TD;
    B2B_direct_connect_users1["B2B direct connect users"] --> Tenant1["Tenant"]
    Tenant1 --> Primary_tenant1["Primary tenant"]
    Primary_tenant1 --> Teams_Connect_shared_channels["Teams Connect shared channels"]
    Teams_Connect_shared_channels --> Tenant2["Tenant"]
    Tenant2 --> B2B_direct_connect_users2["B2B direct connect users"]
```

```mermaid
graph TD;
    B2B_collab_users1["B2B collab users"] --> Tenant3["Tenant"]
    Tenant3 --> Microsoft_apps["Microsoft apps"]
    Tenant3 --> Non_Microsoft_apps["Non-Microsoft apps"]
    Microsoft_apps --> Primary_tenant2["Primary tenant"]
    Non_Microsoft_apps --> Primary_tenant2["Primary tenant"]
    Primary_tenant2 --> B2B_collab_users2["B2B collab users"]
```

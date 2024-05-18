## Properties

When you configure cross-tenant synchronization, you define a trust relationship between a source tenant and a target tenant. Cross-tenant synchronization has the following properties:

- Based on the Microsoft Entra provisioning engine.
- Is a push process from the source tenant, not a pull process from the target tenant.
- Supports pushing only internal members from the source tenant. It doesn't support syncing external users from the source tenant.
- Users in scope for synchronization are configured in the source tenant.
- Attribute mapping is configured in the source tenant.
- Extension attributes are supported.
- Target tenant administrators can stop a synchronization at any time.

The following table shows the parts of cross-tenant synchronization and which tenant they're configured.

| Tenant         | Cross-tenant access settings | Automatic redemption | Sync settings configuration | Users in scope |
|----------------|------------------------------|----------------------|----------------------------|----------------|
| Source tenant  | ✔                            | ✔                    | ✔                          | ✔              |
| Target tenant  | ✔                            | ✔                    |                            |                |

### Cross-tenant synchronization setting

The cross-tenant synchronization setting is an inbound only organizational setting to allow the administrator of a source tenant to synchronize users into a target tenant. This setting is a check box with the name **Allow users sync into this tenant** that is specified in the target tenant. This setting doesn't impact B2B invitations created through other processes such as manual invitation or Microsoft Entra entitlement management.
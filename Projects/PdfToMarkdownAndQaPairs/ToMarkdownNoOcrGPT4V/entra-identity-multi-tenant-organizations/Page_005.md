## B2B Direct Connect Constraint

Currently, B2B direct connect works only with Teams Connect shared channels.

```mermaid
graph LR
    B2B_Direct_Connect_Users("B2B direct connect users") -->|connects to| Primary_Tenant("Primary tenant")
    Primary_Tenant -->|connects back to| Tenant("Tenant")
    Tenant -->|connection| B2B_Direct_Connect_Users
```

For more information, see [B2B direct connect overview](https://example.com).

## B2B Collaboration

To enable users across tenants to collaborate, you can use [Microsoft Entra B2B collaboration](https://example.com). B2B collaboration is a feature within External Identities that lets you invite guest users to collaborate with your organization. Once the external user has redeemed their invitation or completed sign-up, they're represented in your tenant as a user object. With B2B collaboration, you can securely share your company's applications and services with external users, while maintaining control over your own corporate data.

### Primary Constraints with B2B Collaboration

- Administrators must invite users using the B2B invitation process or build an onboarding experience using the [B2B collaboration invitation manager](https://example.com).
- Administrators might have to synchronize users using custom scripts.
- Depending on automatic redemption settings, users might need to accept a consent prompt and follow a redemption process in each tenant.
- By default, users are of type external guest, which has different permissions than external member and might not be the desired user experience.

```mermaid
graph LR
    Tenant("Tenant") -->|invites| Primary_Tenant("Primary tenant")
    Primary_Tenant -->|controls| B2B_Collab_Users("B2B collab users")
    B2B_Collab_Users -->|access| Microsoft_Apps("Microsoft apps")
    Microsoft_Apps -->|provides service to| Non_Microsoft_Apps("Non-Microsoft apps")
    Non_Microsoft_Apps -->|receives services from| Tenant
```
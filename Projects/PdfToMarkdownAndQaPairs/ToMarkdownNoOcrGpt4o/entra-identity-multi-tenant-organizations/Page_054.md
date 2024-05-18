## Manage employee lifecycles across tenants

[Cross-tenant synchronization in Microsoft Entra ID](https://learn.microsoft.com/link-to-cross-tenant-synchronization) automates creating, updating, and deleting B2B collaboration users.

When organizations create, or provision, a B2B collaboration user in a tenant, user access depends partly on how the organization provisioned them: Guest or Member user type. When you select user type, consider the various [properties of a Microsoft Entra B2B collaboration user](https://learn.microsoft.com/link-to-properties-b2b-collaboration-user). The Member user type is suitable if users are part of the larger multitenant organization and need member-level access to resources in the organizational tenants. Microsoft Teams requires the Member user type in [multitenant organizations](https://learn.microsoft.com/link-to-multitenant-organizations).

By default, cross-tenant synchronization includes commonly used attributes on the user object in Microsoft Entra ID. The following diagram illustrates this scenario.
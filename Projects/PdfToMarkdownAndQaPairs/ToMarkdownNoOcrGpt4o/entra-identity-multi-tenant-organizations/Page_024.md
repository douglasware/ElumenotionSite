## Home/source tenant | Resource/target tenant | Consent prompt behavior for source tenant users
|---|---|---|
| Outbound | Inbound | Suppressed |
| ✔️ | ❌ | Not suppressed |
| ❌ | ✔️ | Not suppressed |
| ❌ | ❌ | Not suppressed |
| Inbound | Outbound | Not suppressed |
| ✔️ | ✔️ | Not suppressed |
| ✔️ | ❌ | Not suppressed |
| ❌ | ✔️ | Not suppressed |
| ❌ | ❌ | Not suppressed |

To configure this setting using Microsoft Graph, see the [Update crossTenantAccessPolicyConfigurationPartner](https://learn.microsoft.com/graph/api/resources/cross-tenant-access-policy-configuration-partner?view=graph-rest-1.0) API. For more information, see [Configure cross-tenant synchronization](https://learn.microsoft.com/entra/identity/secure-enterprise-cross-tenant-access).

### How do users know what tenants they belong to?

For cross-tenant synchronization, users don't receive an email or have to accept a consent prompt. If users want to see what tenants they belong to, they can open their [My Account](https://myaccount.microsoft.com/organizations) page and select *Organizations*. In the Microsoft Entra admin center, users can open their [Portal settings](https://entra.microsoft.com), view their *Directories + subscriptions*, and switch directories.

For more information, including privacy information, see [Leave an organization as an external user](https://learn.microsoft.com/azure/active-directory/b2b/leave-the-organization).

## Get started

Here are the basic steps to get started using cross-tenant synchronization.

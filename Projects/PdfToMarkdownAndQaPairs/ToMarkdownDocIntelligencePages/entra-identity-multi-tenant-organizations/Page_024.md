<!-- PageHeader="[] Expand table" -->

Home/source tenant

Resource/target tenant

Consent prompt behavior for source tenant users

| Outbound | Inbound | |
| - | - | - |
| :selected: V | :selected: > | Suppressed |
| :selected: V | :unselected: | Not suppressed |
| :unselected: | :selected: | Not suppressed |
| :unselected: | :unselected: | Not suppressed |
| Inbound | Outbound | |
| :selected: V | :selected: > | Not suppressed |
| :selected: V | :unselected: | Not suppressed |
| :unselected: | :selected: | Not suppressed |
| :unselected: | :unselected: | Not suppressed |

To configure this setting using Microsoft Graph, see the Update crossTenantAccessPolicyConfigurationPartner API. For more information, see Configure cross-tenant synchronization.


# How do users know what tenants they belong to?

For cross-tenant synchronization, users don't receive an email or have to accept a consent prompt. If users want to see what tenants they belong to, they can open their My Account & page and select Organizations. In the Microsoft Entra admin center, users can open their Portal settings, view their Directories + subscriptions, and switch directories.

For more information, including privacy information, see Leave an organization as an external user.


# Get started

Here are the basic steps to get started using cross-tenant synchronization.

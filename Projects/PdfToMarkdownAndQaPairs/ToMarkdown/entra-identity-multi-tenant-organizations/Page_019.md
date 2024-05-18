## What is cross-tenant synchronization?

Article · 01/03/2024

Cross-tenant synchronization automates creating, updating, and deleting [Microsoft Entra B2B collaboration](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/) users across tenants in an organization. It enables users to access applications and collaborate across tenants, while still allowing the organization to evolve.

Here are the primary goals of cross-tenant synchronization:

- Seamless collaboration for a multitenant organization
- Automate lifecycle management of B2B collaboration users in a multitenant organization
- Automatically remove B2B accounts when a user leaves the organization

[![Video Link](https://img.youtube.com/vi/7B-PQwNfGBc/0.jpg)](https://www.youtube.com/watch?v=7B-PQwNfGBc)

## Why use cross-tenant synchronization?

Cross-tenant synchronization automates creating, updating, and deleting B2B collaboration users. Users created with cross-tenant synchronization are able to access both Microsoft applications (such as Teams and SharePoint) and non-Microsoft applications (such as ServiceNow, Adobe, and many more), regardless of which tenant the apps are integrated with. These users continue to benefit from the security capabilities in Microsoft Entra ID, such as [Microsoft Entra Conditional Access](https://docs.microsoft.com/en-us/azure/active-directory/conditional-access/) and [cross-tenant access settings](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/cross-tenant-access), and can be governed through features such as [Microsoft Entitlement Management](https://docs.microsoft.com/en-us/azure/active-directory/governance/entitlement-management-overview).

The following diagram shows how you can use cross-tenant synchronization to enable users to access applications across tenants in your organization.
What is a multitenant organization in Microsoft Entra ID?
===

Article · 04/24/2024

Multitenant organization is a feature in Microsoft Entra ID and Microsoft 365 that enables you to form a tenant group within your organization. Each pair of tenants in the group is governed by cross-tenant access settings that you can use to configure B2B or cross-tenant synchronization.


# Why use multitenant organization?

Here are the primary goals of multitenant organization:

· Define a group of tenants belonging to your organization

· Collaborate across your tenants in new Microsoft Teams

· Enable search and discovery of user profiles across your tenants through Microsoft 365 people search


# Who should use it?

Organizations that own multiple Microsoft Entra tenants and want to streamline intra- organization cross-tenant collaboration in Microsoft 365.

The multitenant organization capability is built on the assumption of reciprocal provisioning of B2B member users across multitenant organization tenants.

As such, the multitenant organization capability assumes the simultaneous use of Microsoft Entra cross-tenant synchronization or an alternative bulk provisioning engine for external identities.


# Benefits

Here are the primary benefits of a multitenant organization:

· Differentiate in-organization and out-of-organization external users

In Microsoft Entra ID, external users originating from within a multitenant organization can be differentiated from external users originating from outside the multitenant organization. This differentiation facilitates the application of different policies for in-organization and out-of-organization external users.

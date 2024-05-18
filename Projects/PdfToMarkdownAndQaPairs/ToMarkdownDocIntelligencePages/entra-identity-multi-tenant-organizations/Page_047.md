Topologies for cross-tenant collaboration
===

Article · 11/03/2023

Organizations often find themselves managing multiple tenants due to mergers and acquisitions, regulatory requirements, or administrative boundaries. Regardless of your scenario, Microsoft Entra offers a flexible and ready-to-use solution for provisioning accounts across tenants and facilitating seamless collaboration. Microsoft Entra accommodates the following three models and can adapt to your evolving organizational needs.

V Hub and spoke

V Mesh

V Just-in-time


# Hub and spoke

The hub and spoke topology presents two common patterns:

. Option 1 (application hub): In this option, you can integrate commonly used applications into a central hub tenant that users from across the organization can access.

· Option 2 (user hub): Alternatively, option 2 centralizes all your users in a single tenant and provisions them into spoke tenants where resources are managed.

Let's examine a few real-world scenarios and see how they align with each of these models.


# Mergers and acquisitions (application hub)

During mergers and acquisitions, the ability to quickly enable collaboration is crucial, allowing businesses to function cohesively while complex IT decisions are being made. For instance, when a newly acquired company's employees need immediate access to applications such as the internal help desk ticketing system or benefits application, cross-tenant synchronization proves invaluable. This synchronization process allows users from the acquired company to be provisioned into the application hub from day one, granting them access to SaaS apps, on-premises applications, and other cloud resources. Within the target tenant, admins can set up access packages to grant time limited access to additional applications such as Salesforce and Amazon Web Services
:selected: :selected: :selected: :unselected: :unselected: :unselected:
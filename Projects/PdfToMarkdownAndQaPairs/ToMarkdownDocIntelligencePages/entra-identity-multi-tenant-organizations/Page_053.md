Governance and cross-tenant synchronization
===

Article · 03/21/2024

Cross-tenant synchronization is a flexible and ready-to-use solution to provision accounts and facilitate seamless collaboration across tenants in an organization. Cross- tenant synchronization automatically manages user identity lifecycle across tenants. It provisions, synchronizes, and deprovisions users in the scope of synchronization from source tenants.

This article describes how Microsoft Entra ID Governance customers can use cross- tenant synchronization to manage identity and access lifecycles across multitenant organizations.


# Deployment example

In this example, Contoso is a multitenant organization with three production Microsoft Entra tenants. Contoso is deploying cross-tenant synchronization and Microsoft Entra ID Governance features to address the following scenarios:

· Manage employee identity lifecycles across multiple tenants

· Use workflows to automate lifecycle processes for employees that originate in other tenants

· Assign resource access automatically to employees that originate in other tenants

. Allow employees to request access to resources in multiple tenants

· Review the access of synchronized users

From a cross-tenant synchronization perspective, Contoso Europe, Middle East, and Africa (Contoso EMEA) and Contoso United States (Contoso US) are source tenants and Contoso is a target tenant. The following diagram illustrates the topology.

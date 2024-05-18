<figure>

![Cross-tenant Synchronization](figures/0)

The illustration shows a flowchart with the following steps:
1. Cross-tenant Synchronization (syncs user attribute data) 
2. Application provisioning 
3. Automatic assignment policies for access packages

</figure>

Organizations use the attributes to help create dynamic membership of groups and access packages in the source and target tenant. Some Microsoft Entra ID features have user attributes to target, such as lifecycle workflow user scoping.

To remove, or deprovision, a B2B collaboration user from a tenant automatically stops access to resources in that tenant. This configuration is relevant when employees leave an organization.


# Automate lifecycle processes with workflows

Microsoft Entra ID lifecycle workflows are an identity governance feature to manage Microsoft Entra users. Organizations can automate joiner, mover, and leaver processes.

With cross-tenant synchronization, multitenant organizations can configure lifecycle workflows to run automatically for B2B collaboration users it manages. For example, configure a user onboarding workflow, triggered by the createdDateTime event user attribute, to request access package assignment for new B2B collaboration users. Use attributes such as userType and userPrincipalName to scope lifecycle workflows for users homed in other tenants the organization owns.


# Govern synchronized user access with access packages

Multitenant organizations can ensure B2B collaboration users have access to shared resources in a target tenant. Users can request access, where needed. In the following scenarios, see how the identity governance feature, entitlement management access packages govern resource access.

Automatically assign access in target tenants to employees from source tenants
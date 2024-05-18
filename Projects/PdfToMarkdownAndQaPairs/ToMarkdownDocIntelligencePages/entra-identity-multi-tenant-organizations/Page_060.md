<!-- PageHeader="Learn more" -->


# Cross-tenant access policies

External identities cross-tenant access settings manage how you collaborate with other Microsoft Entra organizations through B2B collaboration. These settings determine both the level of inbound access users in external Microsoft Entra organizations have to your resources, and the level of outbound access your users have to external organizations.

Learn more


# Deployment topologies

This section describes how you can use tools such as cross-tenant synchronization, entitlement management, cross-tenant access policies, and conditional access together. In both topologies, the target tenant admin has full control over access to resources in the target tenant. They differ in who initiates provisioning and deprovisioning.


# Topology 1

In topology 1, the source tenant configures entitlement management and cross-tenant synchronization to provision users into the target tenant. Then, the administrator of the target tenant configures access packages to provide access to the necessary directory roles, group, and app roles in the target tenant.

<figure>

![](figures/0)

<!-- FigureContent="Source tenant Target tenant 2 SoC users' governance Guest accounts provisioning 3 Access packages assignment PERMISSIONS 2. Users are provisioned 3. SoC users will be auto-assigned Security Reader access. ORGANIZATION TRUST automatically through cross- tenant sync. SoC users will have eligible access for Security Operator and Security Admin roles. CROSS-TENANT SYNC APPROVALS ADD Inject attributes to map to SoC access Packages SoC 1 Access Package 1 Security Reader CHANGE SoC 2 Access Package 2 Security Operator REMOVE SoC 3 Access Package 3 Security Admin ACCES VIEWS 1. Users are added to the SoC security SoC Team Security Groups groups through access packages. ++" -->

<figcaption>

Steps to configure topology 1

</figcaption>

</figure>


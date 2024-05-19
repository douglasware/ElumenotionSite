# Cross-tenant access policies

External identities cross-tenant access settings manage how you collaborate with other Microsoft Entra organizations through B2B collaboration. These settings determine both the level of inbound access users in external Microsoft Entra organizations have to your resources, and the level of outbound access your users have to external organizations.

Learn more

# Deployment topologies

This section describes how you can use tools such as cross-tenant synchronization, entitlement management, cross-tenant access policies, and conditional access together. In both topologies, the target tenant admin has full control over access to resources in the target tenant. They differ in who initiates provisioning and deprovisioning.

# Topology 1

In topology 1, the source tenant configures entitlement management and cross-tenant synchronization to provision users into the target tenant. Then, the administrator of the target tenant configures access packages to provide access to the necessary directory roles, group, and app roles in the target tenant. 

Steps to configure topology 1:

1. Source tenant (SoC users' governance): Users are added to the SoC security groups through access packages.
2. Target tenant (Guest accounts provisioning): Users are provisioned automatically through cross-tenant sync.
3. Target tenant (Access packages assignment): SoC users will be auto-assigned Security Reader access. 
   - SoC users will have eligible access for Security Operator and Security Admin roles.

```mermaid
graph TD;
    SourceTenant["Source tenant"]
    TargetTenant["Target tenant"]
    Start["SoC users' governance"] --> Provision["Guest accounts provisioning"]
    Provision --> AccessPackages["Access packages assignment"]
    SourceTenant -.-> TargetTenant
    Approvals["APPROVALS ADD Inject attributes to map to SoC access Packages"]
    AccessPackage1["Access Package 1"]
    AccessPackage2["Access Package 2"]
    AccessPackage3["Access Package 3"]
    SecReader["Security Reader"]
    SecOperator["Security Operator"]
    SecAdmin["Security Admin"]

    subgraph SourceTenant
        Start
        Approvals
        AccessPackage1
        AccessPackage2
        AccessPackage3
    end

    subgraph TargetTenant
        Provision
        AccessPackages
        SecReader
        SecOperator
        SecAdmin
    end

    Start --> Approvals
    Approvals --> Provision
    Provision --> AccessPackages
    AccessPackages --> AccessPackage1 --> SecReader
    AccessPackages --> AccessPackage2 --> SecOperator
    AccessPackages --> AccessPackage3 --> SecAdmin
```
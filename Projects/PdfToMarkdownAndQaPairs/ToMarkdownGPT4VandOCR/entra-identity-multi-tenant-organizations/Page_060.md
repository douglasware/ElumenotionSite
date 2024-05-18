## Cross-tenant access policies

External identities cross-tenant access settings manage how you collaborate with other Microsoft Entra organizations through B2B collaboration. These settings determine both the level of inbound access users in external Microsoft Entra organizations have to your resources, and the level of outbound access your users have to external organizations.

## Deployment topologies

This section describes how you can use tools such as cross-tenant synchronization, entitlement management, cross-tenant access policies, and conditional access together. In both topologies, the target tenant admin has full control over access to resources in the target tenant. They differ in who initiates provisioning and deprovisioning.

## Topology 1

In topology 1, the source tenant configures entitlement management and cross-tenant synchronization to provision users into the target tenant. Then, the administrator of the target tenant configures access packages to provide access to the necessary directory roles, group, and app roles in the target tenant.

### Source tenant
1. SoC users' governance

### Target tenant
2. Guest accounts provisioning
3. Access packages assignment

```mermaid
graph LR
  A[SoC users' governance] -->|1. Users are added to the SoC security groups through access packages| B[CROSS-TENANT SYNC]
  B -->|2. Users are provisioned automatically through cross-tenant sync.| C[Guest accounts provisioning]
  C -->|3. SoC users will be auto-assigned Security Reader access.| D[Access packages assignment]
  D --> E[Access Package 1 Security Reader]
  D --> F[Access Package 2 Security Operator]
  D --> G[Access Package 3 Security Admin]
  
  style A fill:#f9f,stroke:#333,stroke-width:4px
  style B fill:#bbf,stroke:#f66,stroke-width:2px,color:#f66
  style C fill:#4f4,stroke:#44f,stroke-width:2px,color:#44f
  style D fill:#999,stroke:#f44,stroke-width:2px,color:#f44
  style E fill:#f96,stroke:#333,stroke-width:1px
  style F fill:#f66,stroke:#333,stroke-width:1px
  style G fill:#faa,stroke:#333,stroke-width:1px
```

### Steps to configure topology 1

(Descriptive steps regarding the configuration of Topology 1 are not present within the visible text or the OCR data provided and therefore cannot be included in the markdown output.)
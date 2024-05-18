## A multitenant organization is established as a collaboration of equals

Each tenant administrator stays in control of their tenant and their membership in the multitenant organization.

## Cross-tenant access settings

Administrators staying in control of their resources is a guiding principle for multitenant organization collaboration. Cross-tenant access settings are required for each tenant-to-tenant relationship. Tenant administrators explicitly configure, as needed, the following policies:

- Cross-tenant access partner configurations
  For more information, see Configure cross-tenant access settings for B2B collaboration and crossTenantAccessPolicyConfigurationPartner resource type.
- Cross-tenant access identity synchronization
  For more information, see Configure cross-tenant synchronization and crossTenantIdentitySyncPolicyPartner resource type.

## Multitenant organization example

The following diagram shows three tenants A, B, and C that form a multitenant organization.

```mermaid
graph TD;
  C[Owner tenant (C)] -->|Cross-tenant access settings| A[Member tenant (A)];
  C -->|Cross-tenant access settings| B[Member tenant (B)];
  A -->|Cross-tenant access settings| B;
```

[//]: # (Diagram description: The diagram depicts an organization structure consisting of three entities. There's an 'Owner tenant (C)' represented by a blue diamond shape at the top, which has bidirectional arrows labeled 'Cross-tenant access settings' connecting to two entities at the bottom. These entities at the bottom are 'Member tenant (A)' represented by a purple diamond shape on the left and 'Member tenant (B)' represented by a green diamond shape on the right. There's also a bidirectional arrow labeled 'Cross-tenant access settings' connecting Member tenant (A) and Member tenant (B), indicating a network of shared settings and collaboration.)

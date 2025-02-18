## A multitenant organization is established as a collaboration of equals. Each tenant administrator stays in control of their tenant and their membership in the multitenant organization.

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
  A[Member tenant (A)] -->|Cross-tenant access settings| C[Owner tenant (C)]
  B[Member tenant (B)] -->|Cross-tenant access settings| C[Owner tenant (C)]
  C -->|Cross-tenant access settings| A
  C -->|Cross-tenant access settings| B
  B -->|Cross-tenant access settings| A 
  A -->|Cross-tenant access settings| B
```

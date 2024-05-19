A multitenant organization is established as a collaboration of equals. Each tenant administrator stays in control of their tenant and their membership in the multitenant organization.

# Cross-tenant access settings

Administrators staying in control of their resources is a guiding principle for multitenant organization collaboration. Cross-tenant access settings are required for each tenant-to-tenant relationship. Tenant administrators explicitly configure, as needed, the following policies:

- Cross-tenant access partner configurations

For more information, see Configure cross-tenant access settings for B2B collaboration and crossTenantAccessPolicyConfigurationPartner resource type.

- Cross-tenant access identity synchronization

For more information, see Configure cross-tenant synchronization and crossTenantIdentitySyncPolicyPartner resource type.

# Multitenant organization example

The following diagram shows three tenants A, B, and C that form a multitenant organization.

The diagram describes three nodes:
1. Owner tenant (C)
2. Member tenant (A)
3. Member tenant (B)

Each node represents a tenant and has lines indicating cross-tenant access settings among them.

```mermaid
graph TD;
    OwnerTenantC["Owner tenant (C)"] --> MemberTenantA["Member tenant (A)"]
    OwnerTenantC["Owner tenant (C)"] --> MemberTenantB["Member tenant (B)"]
    MemberTenantA["Member tenant (A)"] --> MemberTenantB["Member tenant (B)"]
```
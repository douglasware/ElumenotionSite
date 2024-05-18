## Multitenant organization optional policy templates
Article • 04/23/2024

Administrators staying in control of their resources is a guiding principle for multitenant organization collaboration. Cross-tenant access settings are required for each tenant-to-tenant relationship. Tenant administrators explicitly configure cross-tenant access partner configurations and identity synchronization settings for partner tenants inside the multitenant organization.

To help apply homogenous cross-tenant access settings to partner tenants in the multitenant organization, the administrator of each tenant can configure optional cross-tenant access settings templates dedicated to the multitenant organization. This article describes how to use templates to preconfigure cross-tenant access settings that are applied to any partner tenant newly joining the multitenant organization.

### Autogeneration of cross-tenant access settings

Within a multitenant organization, each pair of tenants must have bi-directional [cross-tenant access settings](#), for both, partner configuration and identity synchronization. These settings provide the underlying policy framework for enabling trust and for sharing users and applications.

When your tenant joins a new multitenant organization, or when a partner tenant joins your existing multitenant organization, cross-tenant access settings to other partner tenants in the enlarged multitenant organization, if they don't already exist, are automatically generated in an unconfigured state. In an unconfigured state, these cross-tenant access settings pass through the [default settings](#).

Default cross-tenant access settings apply to all external tenants for which you haven't created organization-specific customized settings. Typically, these settings are configured to be nontrusting. For example, cross-tenant trusts for multifactor authentication and compliant device claims might be disabled and user and group sharing in B2B direct connect or B2B collaboration might be disallowed.

In multitenant organizations, on the other hand, cross-tenant access settings are typically expected to be trusting. For example, cross-tenant trusts for multifactor authentication and compliant device claims might be enabled and user and group sharing in B2B direct connect or B2B collaboration might be allowed.
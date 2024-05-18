## Policy templates at multitenant organization formation

While the autogeneration of cross-tenant access settings for multitenant organization partner tenants in and of itself doesn't change any authentication or authorization policy behavior, it allows your organization to easily customize the cross-tenant access settings for partner tenants in the multitenant organization on a per-tenant basis.

As previously described, in multitenant organizations, cross-tenant access settings are typically expected to be trusting. For example, cross-tenant trusts for multifactor authentication and compliant device claims might be enabled and user and group sharing in B2B direct connect or B2B collaboration might be allowed.

While autogeneration of cross-tenant access settings, per previous section, guarantees the existence of cross-tenant access settings for every multitenant organization partner tenant, further maintenance of the cross-tenant access settings for multitenant organization partner tenants is conducted individually, on a per-tenant basis.

To reduce the workload for administrators at the time of multitenant organization formation, you can optionally use policy templates for preemptive configuration of cross-tenant access settings. These template settings are applied at the time of your tenant joins a multitenant organization to all external multitenant organization partner tenants as well as at the time of any partner tenant joins your existing multitenant organization to such new partner tenant.

Enablement or configuration of the optional policy templates, at the time of a partner tenant joins a multitenant organization, preemptively amend the corresponding cross-tenant access settings, for both partner configuration and identity synchronization.

As an example, consider the actions of the administrators for an anticipated multitenant organization with three tenants, A, B, and C.

- The administrators of all three tenants enable and configure their respective optional policy templates to enable cross-tenant trusts for multifactor authentication and compliant device claims and to allow user and group sharing in B2B direct connect and B2B collaboration.
- Administrator A creates the multitenant organization and adds tenants B and C as pending tenants to the multitenant organization.
- Administrator B joins the multitenant organization. Cross-tenant access settings in tenant A for partner tenant B are amended, according to tenant A policy template settings. Vice versa, cross-tenant access settings in tenant B for partner tenant A are amended, according to tenant B policy template settings.
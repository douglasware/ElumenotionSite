## Birthright Assignment
The term birthright assignment refers to automatically granting resource access based on one or more user properties. To configure birthright assignment, create [automatic assignment policies for access packages](https://example.com) in entitlement management and configure resource roles to grant shared resource access.

## Cross-Tenant Synchronization
Organizations manage cross-tenant synchronization configuration in the source tenant. Therefore, organizations can delegate resource access management to other source tenant administrators for synchronized B2B collaboration users:
- In the source tenant, administrators configure cross-tenant synchronization attribute mappings for the users that require cross-tenant resource access.
- In the target tenant, administrators use attributes in automatic assignment policies to determine access package membership for synchronized B2B collaboration users.

To drive automatic assignment policies in the target tenant, synchronize default attribute mappings, such as department or map directory extensions, in the source tenant.

## Enable Source-Tenant Employees to Request Access to Target-Tenant Shared Resources
With identity governance access package policies, multitenant organizations can allow B2B collaboration users, created by cross-tenant synchronization, to request access to shared resources in a target tenant. This process is useful if employees need just-in-time (JIT) access to a resource that another tenant owns.

## Review Synchronized-User Access
Access reviews in Microsoft Entra ID enable organizations to manage group memberships, access to enterprise applications, and role assignments. Regularly review user access to ensure the right people have access.

When resource access configuration doesn’t automatically assign access, such as with dynamic groups or access packages, configure access reviews to apply the results to resources upon completion. The following sections describe how multitenant organizations can configure access reviews for users across tenants in source and target tenants.

### Review Source-Tenant User Access

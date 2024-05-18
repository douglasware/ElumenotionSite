## Cross-tenant synchronization

Cross-tenant synchronization allows the source tenant to automate creating, updating, and deleting B2B users across tenants in an organization.

## Comparing entitlement management and cross-tenant synchronization

| Capability                                                               | Entitlement management   | Cross-tenant synchronization |
|-------------------------------------------------------------------------|--------------------------|-----------------------------|
| Create users in the target tenant                                       | ●                        | ●                           |
| Update users in the target tenant when their attributes change in the source tenant |                          | ●                           |
| Delete users                                                            | ●                        | ●                           |
| Assign users to groups, directory roles, app roles                      | ●                        |                             |
| Attributes of the user in the target tenant                             | Minimal, supplied by user themself at request time | Synchronized from the source tenant |

## Access control

You can use entitlement management and cross-tenant access policies to control access to resources across tenants. Entitlement management will assign the right users to the right resources, while cross-tenant access policies and conditional access together perform the necessary run-time checks to ensure the right users are accessing the right resources.

### Entitlement management

Assigning Microsoft Entra roles through entitlement management access packages helps to efficiently manage role assignments at scale and improves the role assignment lifecycle. It provides a flexible request and approval process for gaining access to directory roles, app roles, and groups while also enabling automatic assignment to resources based on user attributes.
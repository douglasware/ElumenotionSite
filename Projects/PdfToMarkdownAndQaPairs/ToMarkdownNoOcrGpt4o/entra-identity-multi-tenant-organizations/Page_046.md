### Always
By moving a user from one configuration's scope to the other, you can easily control who will be a B2B guest or a B2B member in the target tenant.

- As part of a multitenant organization, reset redemption for an already redeemed B2B user is currently disabled.
- The at-scale provisioning of B2B users might collide with contact objects. The handling or conversion of contact objects is currently not supported.
- Using Microsoft Entra cross-tenant synchronization to target hybrid identities that have been converted to B2B users has not been tested in source of authority conflicts and is not supported.

### Cross-tenant synchronization deprovisioning

- By default, when provisioning scope is reduced while a synchronization job is running, users fall out of scope and are soft deleted, unless Target Object Actions for Delete is disabled. For more information, see Deprovisioning and Define who is in scope for provisioning.
- Currently, SkipOutOfScopeDeletions works for application provisioning jobs, but not for Microsoft Entra cross-tenant synchronization. To avoid soft deletion of users taken out of scope of cross-tenant synchronization, set Target Object Actions for Delete to disabled.

### Next steps

- Known issues for provisioning in Microsoft Entra ID

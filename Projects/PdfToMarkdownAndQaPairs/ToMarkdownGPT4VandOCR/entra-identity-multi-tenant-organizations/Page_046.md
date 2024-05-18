## Cross-tenant synchronization deprovisioning

- By default, when provisioning scope is reduced while a synchronization job is running, users fall out of scope and are soft deleted, unless [Target Object Actions for Delete](#) is disabled. For more information, see [Deprovisioning and Define who is in scope for provisioning](#).
- Currently, `SkipOutOfScopeDeletions` works for application provisioning jobs, but not for Microsoft Entra cross-tenant synchronization. To avoid soft deletion of users taken out of scope of cross-tenant synchronization, set [Target Object Actions for Delete](#) to disabled.

## Next steps

- [Known issues for provisioning in Microsoft Entra ID](#)
## Integration

### Federation Options
- For each internal user in the source tenant, cross-tenant synchronization creates a federated external user in the target tenant, commonly used in B2B environments. It supports syncing:
  - Internal users federated to other identity systems (including Active Directory Federation Services). It does not support syncing external users.

### SCIM Support
- Microsoft Entra ID supports a SCIM client but not a SCIM server. For more information, visit [SCIM synchronization with Microsoft Entra ID](https://docs.microsoft.com/en-us/microsoft-identity-manager/scim).

## Deprovisioning

### Support for Deprovisioning Users
- Cross-tenant synchronization supports deprovisioning users when:
  - A user is deleted in the source tenant; they are soft deleted in the target tenant.
  - A user is unassigned from the cross-tenant synchronization configuration.
  - A user is removed from a group associated with the cross-tenant synchronization configuration.
  - An attribute on the user changes making them non-compliant with the scoping filter of the cross-tenant synchronization configuration.

- If a user in the source tenant has their `accountEnabled` set to false, they will be blocked from signing in but not deleted in the target tenant. Their `accountEnabled` property in the target tenant gets updated.

- Actions that do not result in soft deletion from the target tenant:
  1. Add the user to a group linked to the cross-tenant configuration in the source tenant.
  2. Provision the user on-demand or through the incremental cycle.
  3. Set `accountEnabled` to false in the source tenant.
  4. Reprovision the user so the same change applies in the target tenant.
  5. Remove the user from the group in the source tenant.
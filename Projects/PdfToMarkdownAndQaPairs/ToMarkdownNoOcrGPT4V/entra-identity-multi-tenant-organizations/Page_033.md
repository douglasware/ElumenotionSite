## Does cross-tenant synchronization support restoring users?

- If the user in the source tenant is restored, reassigned to the app, and meets the scoping condition again within 30 days of soft deletion, they will be restored in the target tenant.
- IT admins can also manually restore the user directly in the target tenant.

## How can I deprovision all the users that are currently in scope of cross-tenant synchronization?

- Unassign all users and/or groups from the cross-tenant synchronization configuration. This will trigger the deprovisioning of all users that were unassigned, either directly or through group membership, in subsequent sync cycles. Please note that the target tenant will need to keep the inbound policy for sync enabled until deprovisioning is complete. If the scope is set to **Sync all users and groups**, you will also need to change it to **Sync only assigned users and groups**. The scheduled users to be deleted will be automatically soft deleted by cross-tenant synchronization and can be selected for hard deletion by the target tenant. You can choose to hard delete the users directly from the target tenant or wait 30 days for them to be automatically hard deleted.

## If the sync relationship is severed, are external users previously managed by cross-tenant synchronization deleted in the target tenant?

- No. No changes are made to the external users previously managed by cross-tenant synchronization if the relationship is severed (for example, if the cross-tenant synchronization policy is deleted).

## Next steps

- Topologies for cross-tenant synchronization
- Configure cross-tenant synchronization
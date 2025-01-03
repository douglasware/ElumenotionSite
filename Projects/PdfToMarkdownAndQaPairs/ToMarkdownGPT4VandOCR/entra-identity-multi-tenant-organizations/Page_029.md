## Cross-Tenant Synchronization

- Attributes including (but not limited to) photos, custom security attributes, and user attributes outside of the directory can't be synchronized by cross-tenant synchronization.

### Can I control where user attributes are sourced/managed?

- Cross-tenant synchronization doesn't offer direct control over source of authority. The user and its attributes are deemed authoritative at the source tenant. There are parallel sources of authority workstreams that will evolve source of authority controls for users down to the attribute level and a user object at the source may ultimately reflect multiple underlying sources. For the tenant-to-tenant process, this is still treated as the source tenant's values being authoritative for the sync process (even if pieces actually originate elsewhere) into the target tenant.
- Currently, there's no support for reversing the sync process's source of authority.
- Cross-tenant synchronization only supports source of authority at the object level. That means all attributes of a user must come from the same source, including credentials. It isn't possible to reverse the source of authority or federation direction of a synchronized object.

### What happens if attributes for a synced user are changed in the target tenant?

- Cross-tenant synchronization doesn't query for changes in the target. If no changes are made to the synced user in the source tenant, then user attribute changes made in the target tenant will persist. However, if changes are made to the user in the source tenant, then during the next synchronization cycle, the user in the target tenant will be updated to match the user in the source tenant.

### Can the target tenant manually block sign-in for a specific home/source tenant user that is synced?

- If no changes are made to the synced user in the source tenant, then the block sign-in setting in the target tenant will persist. If a change is detected for the user in the source tenant, cross-tenant synchronization will re-enable that user blocked from sign-in in the target tenant.

## Structure

### Can I sync a mesh between multiple tenants?

- Cross-tenant synchronization is configured as a single-direction peer-to-peer sync, meaning sync is configured between one source and one target tenant. Multiple instances of cross-tenant synchronization can be configured to sync from a single source to multiple target tenants, or vice-versa.
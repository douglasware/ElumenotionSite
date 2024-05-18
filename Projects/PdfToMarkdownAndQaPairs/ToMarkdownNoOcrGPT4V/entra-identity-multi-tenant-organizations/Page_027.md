### Synchronization Features

- Cross-tenant synchronization can update existing B2B users, ensuring each has only one account.
- It does not match an internal user in the source tenant with an internal user in the target tenant.

### Synchronization Frequency

**How often does cross-tenant synchronization run?**
- The sync interval is set at 40-minute intervals.
- Duration varies by the number of in-scope users.
- The initial sync cycle takes longer than subsequent cycles.

### Scope

**How do I control what is synchronized into the target tenant?**
- Control which users are provisioned using configuration or attribute-based filters.
- Control which attributes on the user object are synchronized.
- For more info, see [Scoping users or groups to be provisioned with scoping filters](#).

**What happens if a user is removed from the scope of sync in a source tenant?**
- If removed, cross-tenant synchronization will soft delete them in the target tenant.

### Object and User Types

**What object types can be synchronized?**
- Microsoft Entra users can be synchronized between tenants.

**What user types can be synchronized?**
- Internal members from source tenants.
- Users from source tenants can be synchronized to target tenants as external members or external guests.
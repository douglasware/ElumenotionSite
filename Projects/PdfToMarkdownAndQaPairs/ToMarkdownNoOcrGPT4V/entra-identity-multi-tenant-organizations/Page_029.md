## User Attributes in Cross-Tenant Synchronization

### Overview

- Attributes including photos, custom security attributes, and user attributes outside of the directory can't be synchronized by cross-tenant synchronization.

### Source and Management of User Attributes

- Cross-tenant synchronization does not offer direct control over the source of authority. Attributes are authoritative at the source tenant and may reflect multiple underlying sources. For the tenant-to-tenant process, this is handled as the source tenant's values being authoritative for the sync process. No support for reversing the sync process's source of authority is currently available.

### Attribute Changes Impact 

- If changes to a synced user's attributes occur in the target tenant, those changes will persist unless the user in the source tenant is updated. Subsequent syncs will then update the target tenant to match the source tenant's updates.

### Blocking User Sign-in

- If no changes occur to the synced user in the source tenant, any manual blocks on sign-in settings in the target tenant will continue to be effective. If the user is updated in the source tenant, cross-tenant synchronization will address the blocking status based on the source tenant's settings.

## Structure of Cross-Tenant Synchronization

### Mesh Synchronization Across Multiple Tenants

- Cross-tenant synchronization is typically configured as a single-direction peer-to-peer sync between one source and one target tenant. However, it's possible to configure multiple instances to sync from a single source to various target tenants.
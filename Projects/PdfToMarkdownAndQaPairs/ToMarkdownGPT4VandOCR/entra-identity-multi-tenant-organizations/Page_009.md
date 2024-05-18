## B2B direct connect (Org-to-org external or internal)

### Trust level
Mid trust. B2B direct connect users are less easy to track, mandating a certain level of trust with the external organization.

### Effect on users
Users access the resource tenant using the credentials for their home tenant. User objects aren't created in the resource tenant.

### User type
B2B direct connect user - N/A

## B2B collaboration (Org-to-org external or internal)

### Trust level
Low to mid trust. User objects can be tracked easily and managed with granular controls.

### Effect on users
External users are added to a tenant as B2B collaboration users.

### User type
B2B collaboration user
- External member
- External guest (default)

## Cross-tenant synchronization (Org internal)

### Trust level
High trust. All tenants are part of the same organization, and users are typically granted member access to all apps/resources.

### Effect on users
Within the same organization, users are synchronized from their home tenant to the resource tenant as B2B collaboration users.

### User type
B2B collaboration user
- External member (default)
- External guest

## Multitenant organization (Org internal)

### Trust level
High trust. All tenants are part of the same organization, and users are typically granted member access to all apps/resources.

### Effect on users
Within the same multitenant organization, B2B collaboration users, particularly member users, benefit from enhanced, seamless collaboration across Microsoft 365.

### User type
B2B collaboration user
- External member (default)
- External guest

The following diagram shows how B2B direct connect, B2B collaboration, and cross-tenant synchronization capabilities could be used together.
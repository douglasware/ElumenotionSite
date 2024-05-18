## B2B direct connect (Org-to-org external or internal)

### Purpose
- Users can access Teams Connect shared channels hosted in external tenants.

### Value
- Enables external collaboration within Teams Connect shared channels only.
- More convenient for administrators because they don't have to manage B2B users.

### Primary administrator workflow
- Configure cross-tenant access to provide external users inbound access to tenant the credentials for their home tenant.

## B2B collaboration (Org-to-org external or internal)

### Purpose
- Users can access apps/resources hosted in external tenants, usually with limited guest privileges.
- Depending on automatic redemption settings, users might need to accept a consent prompt in each tenant.

### Value
- Enables external collaboration.
- More control and monitoring for administrators by managing the B2B collaboration users.
- Administrators can limit the access that these external users have to their apps/resources.

### Primary administrator workflow
- Add external users to resource tenant by using the B2B invitation process or build your own onboarding experience using the B2B collaboration

## Cross-tenant synchronization (Org internal)

### Purpose
- Users can seamlessly access apps/resources across the same organization, even if they're hosted in different tenants.

### Value
- Enables collaboration across organizational tenants.
- Administrators don't have to manually invite and synchronize users between tenants to ensure continuous access to apps/resources within the organization.

### Primary administrator workflow
- Configure the cross-tenant synchronization engine to synchronize users between multiple tenants as B2B collaboration users.

## Multitenant organization (Org internal)

### Purpose
- Users can more seamlessly collaborate across a multitenant organization in new Teams and people search.

### Value
- Enables collaboration across organizational tenants.
- Administrators continue to have full configuration ability via cross-tenant access settings. Optional cross-tenant access templates allow pre-configuration of cross-tenant access settings.

### Primary administrator workflow
- Create a multitenant organization, add (invite) tenants, join a multitenant organization.
- Leverage existing B2B collaboration users or use cross-tenant synchronization to.
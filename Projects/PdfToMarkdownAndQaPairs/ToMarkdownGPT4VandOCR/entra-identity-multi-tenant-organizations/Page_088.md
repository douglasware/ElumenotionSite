## Microsoft Entra ID P1 or P2 license. 
For more information, see License requirements.

- Security Administrator role to configure cross-tenant access settings.
- Hybrid Identity Administrator role to configure cross-tenant synchronization.
- Cloud Application Administrator or Application Administrator role to assign users to a configuration and to delete a configuration.

### Target tenant

- Microsoft Entra ID P1 or P2 license. For more information, see License requirements.
- Security Administrator role to configure cross-tenant access settings.

## Step 1: Plan your provisioning deployment

1. Define how you would like to structure the tenants in your organization.
2. Learn about how the provisioning service works.
3. Determine who will be in scope for provisioning.
4. Determine what data to map between tenants.

## Step 2: Enable user synchronization in the target tenant

> Tip
> 
> Steps in this article might vary slightly based on the portal you start from.

### Target tenant

1. Sign in to the Microsoft Entra admin center of the target tenant.
2. Browse to Identity > External Identities > Cross-tenant access settings.
3. On the Organization settings tab, select Add organization.
4. Add the source tenant by typing the tenant ID or domain name and selecting Add.
## Security Permissions Review

From a security perspective, you should review the default permissions granted to B2B member users. For more information, see Compare member and guest default permissions.

## Changing UserType

To change the userType from **Guest to Member** (or vice versa), a source tenant administrator can amend the attribute mappings, or a target tenant administrator can change the userType if the property is not recurrently synchronized.

## Unsharing Your Users

To unshare users, you deprovision users by using the user deprovisioning capabilities available in Microsoft Entra cross-tenant synchronization. By default, when provisioning scope is reduced while a synchronization job is running, users fall out of scope and are soft deleted, unless Target Object Actions for Delete is disabled. For more information, see Deprovisioning and Define who is in scope for provisioning.

## Next Steps

- Plan for multitenant organizations in Microsoft 365
- Set up a multitenant org in Microsoft 365
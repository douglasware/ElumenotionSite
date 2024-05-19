. For more information about the UserType definitions, see Properties of a Microsoft Entra B2B collaboration user.

I have existing B2B collaboration users. What will happen to them?

· Cross-tenant synchronization will match the user and make any necessary updates to the user, such as update the display name. By default, the UserType won't be updated from guest to member, but you can configure this in the attribute mappings.

# Attributes

What user attributes can be synchronized?

· Cross-tenant synchronization will sync commonly used attributes on the user object in Microsoft Entra ID, including (but not limited to) displayName, userPrincipalName, and directory extension attributes.

· Cross-tenant synchronization supports provisioning the manager attribute. Both the user and their manager must be in scope for provisioning.

o For cross-tenant synchronization configurations created before January 2024, with the default schema / attribute mappings:

o The manager attribute will automatically be added to the mappings.
 
o This does not trigger an initial sync cycle.
 
o Manager updates will apply on the incremental cycle for users that are undergoing changes (e.g. manager change). The sync engine doesn't automatically update all existing users that were provisioned previously.
 
o To update the manager for existing users that are in scope for provisioning, you can use on-demand provisioning for specific users or do a restart to provision the manager for all users.

o For cross-tenant synchronization configurations created before January 2024, with a custom schema / attribute mappings (e.g. you added an attribute to the mappings or changed the default mappings):

o You need to manually add the manager attribute to your attribute mappings. This will trigger a restart and update all users that are in scope for provisioning. This should be a direct mapping of the manager attribute in the source tenant to the manager in the target tenant.

o If the manager of a user is removed in the source tenant and no new manager is assigned in the source tenant, the manager attribute will not be updated in the target tenant.

What attributes can't be synchronized?
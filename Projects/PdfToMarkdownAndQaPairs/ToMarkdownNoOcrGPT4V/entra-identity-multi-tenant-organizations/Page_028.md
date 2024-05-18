## Existing B2B Collaboration Users

Cross-tenant synchronization will match the user and make any necessary updates to the user, such as update the display name. By default, the UserType won't be updated from guest to member, but you can configure this in the attribute mappings.

## Attributes

### What user attributes can be synchronized?

- **Common Attributes**: Cross-tenant synchronization will sync commonly used attributes on the user object in Microsoft Entra ID, including displayName, userPrincipalName, and directory extension attributes.

- **Manager Provisioning**: 
  - Supports provisioning the manager attribute. Both the user and their manager must be in scope for provisioning.
  - Configurations created before January 2024:
    - The manager attribute will automatically be added to the mappings.
    - Manager updates apply on the incremental cycle for users undergoing changes (e.g., manager change). The synchronization engine doesn't automatically update previously provisioned users but can update the manager for existing users in scope.
    - For specific or restart provisioning, you can manually initiate provisioning for the manager attribute.
  - Configurations with a custom schema:
    - You must manually add the manager attribute to your attribute mappings when they are changed from the default, which will trigger updates of all users in scope.
  - If a user’s manager is removed in the source tenant and no new manager is assigned, the manager attribute will not be updated in the target tenant.

### What attributes can't be synchronized?

(The PDF does not provide specifics on attributes that cannot be synchronized; only those that can are listed.)
<!-- PageHeader="manually add the attributes. To learn more, see Customize attribute mappings." -->

# Null attribute can't be provisioned

Microsoft Entra ID currently can't provision null attributes. If an attribute is null on the user object, it will be skipped.

# Maximum characters for attribute-mapping expressions

Attribute-mapping expressions can have a maximum of 10,000 characters.

## Unsupported scoping filters

The appRoleAssignments, userType, and accountExpires attributes aren't supported as scoping filters.

# Multivalue directory extensions

Multivalue directory extensions can't be used in attribute mappings or scoping filters.

# Service issues

Unsupported scenarios

· Provisioning passwords isn't supported.

· Provisioning nested groups isn't supported.

· Provisioning to B2C tenants isn't supported because of the size of the tenants.

· Not all provisioning apps are available in all clouds. For example, Atlassian isn't yet available in the Government cloud. We're working with app developers to onboard their apps to all clouds.

# Automatic provisioning isn't available on my OIDC-based application

If you create an app registration, the corresponding service principal in enterprise apps won't be enabled for automatic user provisioning. You'll need to either request the app be added to the gallery, if intended for use by multiple organizations, or create a second non-gallery app for provisioning.
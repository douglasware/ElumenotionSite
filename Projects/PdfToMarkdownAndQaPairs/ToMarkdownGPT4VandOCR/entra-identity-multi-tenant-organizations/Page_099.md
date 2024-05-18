## Attribute Mapping

The first attribute, `alternativeSecurityIdentifier`, is an internal attribute used to uniquely identify the user across tenants, match users in the source tenant with existing users in the target tenant, and ensure that each user only has one account. The matching attribute cannot be changed. Attempting to change the matching attribute or adding additional matching attributes will result in a `schemaInvalid` error.

### Attribute Mappings

Attribute mappings define how attributes are synchronized between Azure Active Directory and Azure Active Directory (target tenant)

| Azure Active Directory Attribute      | Azure Active Directory (target tenant) Attribute | Matching precedence |
| ------------------------------------- | ----------------------------------------------- | ------------------- |
| AltSecidFromNetid([netid])            | alternativeSecurityIds                          | 1                   |
| IsSoftDeleted                         | IsSoftDeleted                                   |                     |
| accountEnabled                        | accountEnabled                                  |                     |
| streetAddress                         | streetAddress                                   |                     |
| city                                  | city                                            |                     |
| state                                 | state                                           |                     |
| postalCode                            | postalCode                                      |                     |
| country                               | country                                         |                     |
| department                            | department                                      |                     |
| employeeId                            | employeeId                                      |                     |
| displayName                           | displayName                                     |                     |
| givenName                             | givenName                                       |                     |

4. Select the Member (userType) attribute to open the **Edit Attribute** page.

5. Review the `Constant Value` setting for the userType attribute.

This setting defines the type of user that will be created in the target tenant and can be one of the values in the following table. By default, users will be created as external member (B2B collaboration users). For more information, see Properties of a Microsoft Entra B2B collaboration user.

### Constant Value Settings

| Constant Value | Description                                                                                                                                                  |
| -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Member         | Default. Users will be created as external member (B2B collaboration users) in the target tenant. Users will be able to function as any internal member of the target tenant. |
| Guest          | Users will be created as external guests (B2B collaboration users) in the target tenant.                                                                      |
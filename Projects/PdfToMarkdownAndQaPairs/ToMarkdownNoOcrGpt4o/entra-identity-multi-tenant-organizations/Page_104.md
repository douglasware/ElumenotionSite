## Perform action

| Modified attributes (successful) | Data Flow                                                                                                                                   |
|----------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| `User 'User1@fabrikam.com' was created in Azure Active Directory (target tenant)`                                                                                             |
| Target attribute name            | Source attribute value                           | Expression            | Original target attribute value | Modified target attribute value |
| `isSoftDeleted`                  | `False`                                          | `[isSoftDeleted]`     |                                | `False`                         |
| `accountEnabled`                 | `True`                                           | `[accountEnabled]`    |                                | `True`                          |
| `displayName`                    | `User1`                                          | `[displayName]`       |                                | `User1`                         |
| `mailNickname`                   | `USER1`                                          | `[mailNickname]`      |                                | `user1`                         |
| `alternativeSecurityIds`         | `AltSecIdFromNextId:1033...`                     |                       |                                | `(1 values)`                    |
| `showInAddressList`              | `"True"`                                         |                       |                                | `true`                          |
| `userType`                       | `"Member"`                                       | `"Member"`            |                                | `Member`                        |
| `preferredLanguage`              | `undefined`                                      | `[preferredLanguage]` |                                | `en-US`                         |

If the user isn't in scope, you'll see a page with information about why test user was skipped.

## Determine if user is in scope

The User `alice@fabrikam.com` will be skipped due to the following reasons: 1) This object is not assigned to the application. If you did not expect the object to be skipped, assign the object to the application or change your scoping filter to allow all users and groups to be in scope for provisioning. 2) This object does not have required entitlement for provisioning. If you did not expect the object to be skipped, update provisioning scope to 'Sync all users and groups' or assign the object to the application with entitlement of provisioning category

| Attribute name                    | Attribute value                  |
|-----------------------------------|----------------------------------|
| `SkipReason`                      | `NotEffectivelyEntitled`         |
| `isActive`                        | `True`                           |
| `Assigned to the application`     | `False`                          |
| `isInProvisioningScope`           | `True`                           |

On the **Provision on demand** page, you can view details about the provision and have the option to retry.
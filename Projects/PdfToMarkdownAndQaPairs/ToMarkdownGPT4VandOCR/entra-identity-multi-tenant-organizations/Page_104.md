## Perform action

### Modified attributes (successful)

| Target attribute name        | Source attribute value             | Expression                     | Original target attribute value | Modified target attribute value |
|------------------------------|------------------------------------|--------------------------------|---------------------------------|---------------------------------|
| IsSoftDeleted                | False                              | [IsSoftDeleted]                | False                           | False                           |
| accountEnabled               | True                               | [accountEnabled]               | True                            | True                            |
| displayName                  | User1                              | [displayName]                  | User1                           | User1                           |
| mailNickname                 | user1                              | [mailNickname]                 | user1                           | user1                           |
| alternativeSecurityIds       | AltSecidFromNetid("1003...         | AltSecidFromNetid([netId])     | (1 values)                      | (1 values)                      |
| showInAddressList            | "true"                             | "true"                         | true                            | true                            |
| userType                     | "Member"                           | "Member"                       | Member                          | Member                          |
| preferredLanguage            | undefined                          | [preferredLanguage]            | en-US                           | en-US                           |

### If the user isn't in scope, you'll see a page with information about why the user was skipped.

### Determine if user is in scope

| Attribute name         | Attribute value        |
|------------------------|------------------------|
| SkipReason             | NotEffectivelyEntitled |
| IsActive               | True                   |
| Assigned to the application | False              |
| IsInProvisioningScope  | True                   |

### On the Provision on demand page, you can view details about the provision and have the option to retry.
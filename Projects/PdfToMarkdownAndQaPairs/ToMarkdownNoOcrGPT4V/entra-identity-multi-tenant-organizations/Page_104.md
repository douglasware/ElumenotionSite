## Perform Action

**Modified Attributes (successful)** - User `User1@fictiban.com` was created in Azure Active Directory (target tenant).

### Data Flow

| Source Attribute Name  | Source Attribute Value | Expression   | Original Target Attribute Value | Modified Target Attribute Value |
|------------------------|------------------------|--------------|---------------------------------|---------------------------------|
| isSoftDeleted          | False                  | [isSoftDeleted] | False                             | False                           |
| accountEnabled         | True                   |               |                                  | True                            |
| displayName            | User1                  | [displayName] |                                  | User1                           |
| mailNickname           | user1                  | [mailNickname] |                                 | user1                           |
| alternativeSecurityIds | AIdSceFromId(nt:103... |               | (1 values)                       |                                 |
| showInAddressList      | "True"                 |               | True                             | True                            |
| userType               | "Member"               |               | "Member"                         | Member                          |
| preferredLanguage      | undefined              | [preferredLanguage]|                            | en-US                           |

## User Scope Check

### Determine if user is in scope

_The user `alice@fictiban.com` will be skipped due to the following reasons: This object is not assigned to the application._

#### Reason Details:

1. **Attribute:** SkipReason  
   **Attribute Value:** NotEffectivelyEntitled
2. **Attribute:** IsActive  
   **Attribute Value:** True
3. **Attribute:** Assigned to the application  
   **Attribute Value:** False
4. **Attribute:** isInProvisioningScope  
   **Attribute Value:** True

## Provision on Demand

On the Provision on demand page, you can view details about the provision and have the option to retry.
## Fabrikam to Contoso | Provision on demand

### Overview

- Provision on demand

### Manage

- Users and groups
- Provisioning
- Expression builder

### Activity

- Audit logs
- Provisioning logs
- Insights

### Troubleshooting + Support

- New support request

### User

- User1
  - user1@fabrikam.com

#### 1. Import user
This step shows the user retrieved from the source system and the properties of the user in the source system.
- Success | View details

#### 2. Determine if user is in scope
This step shows the scoping conditions that were evaluated and which ones the user passed or failed.
- Success | View details

#### 3. Match user between source and target system
This step shows whether the user was found in the target system as well as the properties of the user in the target system.
- Success | View details

#### 4. Perform action
This step shows the action that was performed in the target application, such as creating a user or updating a user.
- Success | View details

- Retry
- Provision another object

## 6. In the target tenant, verify that the test user was provisioned.

- User1
  - user1_fabrikam.com#EXT#@\[...\]
- Member
- ExternalAzureAD
- Invitation

## 7. If all is working as expected, assign additional users to the configuration.

For more information, see On-demand provisioning in Microsoft Entra ID.

## Step 12: Start the provisioning job
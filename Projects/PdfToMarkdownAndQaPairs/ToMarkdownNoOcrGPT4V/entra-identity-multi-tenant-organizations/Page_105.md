## Fabrikam to Contoso | Provision on Demand

### Overview
- **Provision on demand**
- **Manage**
  - Users and groups
  - Provisioning
  - Expression builder
- **Activity**
  - Audit logs
  - Provisioning logs
  - Insights
- **Troubleshooting + Support**
  - New support request

### Provision Steps
1. **Import user**
   - This step shows the user retrieved from the source system and the properties of the user in the source system.
   - Status: Success
2. **Determine if user is in scope**
   - This step shows the scoping conditions that were evaluated and which ones the user passed or failed.
   - Status: Success
3. **Match user between source and target system**
   - This step shows whether the user was found in the target system as well as the properties of the user in the target system.
   - Status: Success
4. **Perform action**
   - This step shows the action that was performed in the target application, such as creating a user or updating a user.
   - Status: Success

### Actions
- **Retry**
- **Provision another object**

### Verification in the target tenant

- **Contoso Users**
  - Azure Active Directory as ID provider
  - Details of provisioned user:
    - Display name: User1
    - User principal name: user1@fabrikam.com-EXT@Contoso.ID
    - User type: Member
    - On-premises: No
    - Identities: ExternalAzureAD
    - Company name: -
    - Creation type: Invitation

### Additional Configuration

- If all is working as expected, additional users can be assigned to the configuration.

### Documentation Reference

- For more details, refer to the documentation on On-demand provisioning in Microsoft Entra ID.

## Step 12: Start the Provisioning Job
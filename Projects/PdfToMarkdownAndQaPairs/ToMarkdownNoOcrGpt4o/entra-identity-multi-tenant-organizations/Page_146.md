## Step 2: Import user

Next, the provisioning service retrieves the user from the source system. The user attributes that the service retrieves are used later to:

- Evaluate whether the user is in scope for provisioning.
- Check the target system for an existing user.
- Determine what user attributes to export to the target system.

### View details

The **View details** section shows the properties of the user that were imported from the source system (for example, Microsoft Entra ID).

### Troubleshooting tips

- Importing the user can fail when the matching attribute is missing on the user object in the source system. To resolve this failure, try one of these approaches:
  - Update the user object with a value for the matching attribute.
  - Change the matching attribute in your provisioning configuration.
- If an attribute that you expected is missing from the imported list, ensure that the attribute has a value on the user object in the source system. The provisioning service currently doesn't support provisioning null attributes.
- Make sure that the **Attribute mapping** page of your provisioning configuration contains the attribute that you expect.

## Step 3: Determine if user is in scope

Next, the provisioning service determines whether the user is in scope for provisioning. The service considers aspects such as:

- Whether the user is assigned to the application.
- Whether scope is set to Sync assigned or Sync all.
- The scoping filters defined in your provisioning configuration.

### View details
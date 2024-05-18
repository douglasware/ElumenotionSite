## Fabricam to Contoso | Provisioning

### Overview

This screen provides a series of options and settings for provisioning users and groups from Fabricam to Contoso. Here is a description of the key parts visible in the screenshot:

- **Admin Credentials**
- **Mappings**
- **Settings** includes options such as:
  - Send an email notification when a failure occurs
  - Prevent accidental deletion (`Accidental deletion threshold` set to `500`)
  - Scope with options to `Sync only assigned users and groups`
- **Provisioning Status** with toggles for `On` and `Off`

### Configuration Steps

1. **Scope Selection:** 
   - Decide whether to synchronize all users in the source tenant or only those assigned to the configuration. 
   - It is advisable to select **Sync only assigned users and groups** for efficiency and better performance.

2. **Saving Changes:**
   - Click `Save` after making any modifications to ensure they are applied.

3. **Specifying Users and Groups:**
   - Navigate to `Users and groups` on the configuration page.
   - To enable cross-tenant synchronization, at least one internal user must be included in the configuration.

4. **Adding Users/Groups:**
   - Choose `Add user/group`.
   - Use the `Users and groups` selection dialog to include specific users or groups in the configuration. Ensure to select from internal users or groups as required.
   - Note: Only direct members of a selected group are in scope for provisioning. The scope does not extend to nested groups.

5. **Finalizing Selection:**
   - Complete the process by selecting `Select`.
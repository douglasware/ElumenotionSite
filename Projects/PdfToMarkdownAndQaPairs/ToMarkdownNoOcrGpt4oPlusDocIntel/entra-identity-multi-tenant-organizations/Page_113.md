##### End the script

# Symptom - Users fail to provision with error "AzureActiveDirectoryForbidden"

Users in scope fail to provision. The provisioning logs details include the following error message:

[Text box with error message]
```
Guest invitations not allowed for your company. Contact your company administrator for more details.
```

# Cause

This error indicates the Guest invite settings in the target tenant are configured with the most restrictive setting: "No one in the organization can invite guest users including admins (most restrictive)".

# Solution

Change the Guest invite settings in the target tenant to a less restrictive setting. For more information, see Configure external collaboration settings.

# Next steps

- Tutorial: Reporting on automatic user account provisioning
- Managing user account provisioning for enterprise apps in the Azure portal
- What is single sign-on in Microsoft Entra ID?
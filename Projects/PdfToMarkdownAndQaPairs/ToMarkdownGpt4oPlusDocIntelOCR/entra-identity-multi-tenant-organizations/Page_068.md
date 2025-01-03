# Microsoft Azure Government Cloud

Credentials, including the secret token, notification email, and SSO certificate notification emails together have a 1KB limit in the Microsoft Azure Government Cloud.

# On-premises application provisioning

The following information is a current list of known limitations with the Microsoft Entra ECMA Connector Host and on-premises application provisioning.

# Application and directories

The following applications and directories aren't yet supported.

## Active Directory Domain Services (user or group writeback from Microsoft Entra ID by using the on-premises provisioning preview)

- When a user is managed by Microsoft Entra Connect, the source of authority is on-premises Active Directory Domain Services. So, user attributes can't be changed in Microsoft Entra ID. This preview doesn't change the source of authority for users managed by Microsoft Entra Connect.
- Attempting to use Microsoft Entra Connect and the on-premises provisioning to provision groups or users into Active Directory Domain Services can lead to creation of a loop, where Microsoft Entra Connect can overwrite a change that was made by the provisioning service in the cloud. Microsoft is working on a dedicated capability for group or user writeback. Upvote the UserVoice feedback on this website to track the status of the preview. Alternatively, you can use Microsoft Identity Manager for user or group writeback from Microsoft Entra ID to Active Directory.

## Microsoft Entra ID

By using on-premises provisioning, you can take a user already in Microsoft Entra ID and provision them into a third-party application. You can't bring a user into the directory from a third-party application. Customers will need to rely on our native HR integrations, Microsoft Entra Connect, Microsoft Identity Manager, or Microsoft Graph, to bring users into the directory.
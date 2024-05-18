## Log / Report

### Roles

| Roles                                         | Licenses             |
|-----------------------------------------------|----------------------|
| A custom role with `ProvisioningLogsRead` permission | -                    |
| Security Reader                               | Microsoft Entra ID   |
| Reports Reader                                | P1/P2                |
| Security Administrator                        | -                    |
| Security Administrator                        | Microsoft Entra ID   |
| Security Operator                             | Free                 |
| Security Reader                               | Microsoft 365 Apps   |
| Global Reader                                 | Microsoft Entra ID   |
| A custom role with `IdentityRiskEventReadWrite` permission | P1/P2                |
| Security Administrator                        | -                    |
| Security Administrator                        | Microsoft Entra ID   |
| Security Operator                             | P1/P2                |
| Security Reader                               | -                    |
| Microsoft Graph                               | Microsoft Entra ID   |
| activity logs                                 | P1/P2                |
| A custom role with `ListKeys` permission       | -                    |

*The level of access and capabilities for Identity Protection varies with the role and license. For more information, see the license requirements for Identity Protection.

## What can you do with the provisioning logs?

You can use the provisioning logs to find answers to questions like:

- What groups were successfully created in ServiceNow?
- What users were successfully removed from Adobe?
- What users from Workday were successfully created in Active Directory?

> **Note**
> 
> Entries in the provisioning logs are system generated and can't be changed or deleted.

## What do the logs show?

When you select an item in the provisioning list view, you get more details about this item, such as the steps taken to provision the user and tips for troubleshooting issues. The details are grouped into four tabs.

- **Steps**: This tab outlines the steps taken to provision an object. Provisioning an object can include the following steps, but not all steps are applicable to all provisioning events.
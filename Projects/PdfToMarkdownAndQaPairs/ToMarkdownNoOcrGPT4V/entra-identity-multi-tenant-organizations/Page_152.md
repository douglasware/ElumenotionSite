## Log / Report Access

### Roles and Licenses

| Log / Report             | Roles                                              | Licenses                 |
|--------------------------|---------------------------------------------------|--------------------------|
| **Log / Report**         | **Roles**                                          | **Licenses**             |
| A custom role with `ProvisioningLogsRead` permission | Security Reader<br>Reports Reader<br>Security Administrator | Microsoft Entra ID P1/P2 |
| Identity Protection*     | Security Administrator<br>Security Operator<br>Security Reader<br>Global Reader<br>A custom role with `IdentityRiskEventReadWrite` permission | Microsoft Entra ID Free<br>Microsoft 365 Apps<br>Microsoft Entra ID P1/P2 |
| Microsoft Graph activity logs | Security Administrator<br>A custom role with `ListKeys` permission | Microsoft Entra ID P1/P2 |

> *The level of access and capabilities for Identity Protection varies with the role and license. For more information, see the [license requirements for Identity Protection](#).

## What can you do with the provisioning logs?

You can use the provisioning logs to find answers to questions like:

- What groups were successfully created in ServiceNow?
- What users were successfully removed from Adobe?
- What users from Workday were successfully created in Active Directory?

> **Note:** Entries in the provisioning logs are system generated and can't be changed or deleted.

## What do the logs show?

When you select an item in the provisioning list view, you get more details about this item, such as the steps taken to provision the user and tips for troubleshooting issues. The details are grouped into four tabs.

- **Steps:** This tab outlines the steps taken to provision an object. Provisioning an object can include the following steps, but not all steps are applicable to all provisioning events.
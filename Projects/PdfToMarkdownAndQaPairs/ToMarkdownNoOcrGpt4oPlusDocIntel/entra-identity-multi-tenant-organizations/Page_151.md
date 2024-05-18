What are the Microsoft Entra user provisioning logs?
===

Article · 01/25/2024

Microsoft Entra ID integrates with several third party services to provision users into your tenant. If you need to troubleshoot an issue with a provisioned user, you can use the information captured in the Microsoft Entra provisioning logs to help find a solution.

Two other activity logs are also available to help monitor the health of your tenant:

- Sign-ins - Information about sign-ins and how your resources are used by your users.

- Audit - Information about changes applied to your tenant such as users and group management or updates applied to your tenant's resources.

This article gives you an overview of the user provisioning logs.

# License and role requirements

The required roles and licenses might vary based on the report. Global Administrator can access all reports, but we recommend using a role with least privilege access to align with the Zero Trust guidance.

| Log / Report | Roles | Licenses |
| - | - | - |
| Audit | Report Reader | All editions of |
| | Security Reader | Microsoft Entra ID |
| | Security Administrator | |
| | Global Reader | |
| | A custom role with `AuditLogsRead` or `CustomSecAuditLogsRead` permission | |
| Sign-ins | Report Reader | All editions of |
| | Security Reader | Microsoft Entra ID |
| | Security Administrator | |
| | Global Reader | |
| | A custom role with `SignInLogsRead` permission | |
| Provisioning | Same as audit and sign-ins, plus | Microsoft Entra ID P1/P2 |
| | Security Operator | |
| | Application Administrator | |
| | Cloud App Administrator | |


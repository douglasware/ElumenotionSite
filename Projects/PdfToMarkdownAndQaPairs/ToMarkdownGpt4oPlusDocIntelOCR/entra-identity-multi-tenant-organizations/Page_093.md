\> Outbound access settings - Contoso > Cross-tenant synchronization | Configurations >

Description: A screenshot displaying the outbound access settings in a Microsoft Entra admin center, showing the navigation path and a dropdown menu with various settings categories.

```mermaid
graph TD;
    Outbound_Access_Settings["Outbound access settings - Contoso"] --> Cross_Tenant_Sync["Cross-tenant synchronization"]
    Cross_Tenant_Sync --> Configurations
    Configurations --> Fabrikam_to_Contoso["Fabrikam to Contoso"]
    Fabrikam_to_Contoso --> Overview
```

Fabrikam to Contoso Fabrikam - Microsoft Entra ID

Overview
 ✅
X

«

Got feedback?

Overview

Provision on demand

Manage

Users and groups

Provisioning

Expression builder

Activity

Audit logs

Provisioning logs

Insights

Troubleshooting + Support

New support request

Description: A pane from the Microsoft Entra admin center showing options for managing identity lifecycle, including user provisioning and audit logs. An illustration promotes automating identity lifecycle management.

```mermaid
graph TD;
    Manage["Manage"] --> Users_and_Groups["Users and groups"]
    Manage --> Provisioning
    Manage --> Expression_Builder["Expression builder"]
    Activity["Activity"] --> Audit_Logs["Audit logs"]
    Activity --> Provisioning_Logs["Provisioning logs"]
    Activity --> Insights
    Troubleshooting_Support["Troubleshooting + Support"] --> New_Support_Request["New support request"]
```

Automate identity lifecycle management with Microsoft Entra

Automatically create, update, and delete accounts when users join, leave, and move within your organization. Learn more.

Get started

What is provisioning? Plan an application deployment. +

Configure automatic provisioning.

Description: A screenshot showing provisioning instructions with a focus on setting the provisioning mode to automatic and configuring admin credentials for cross-tenant synchronization policy.

```mermaid
graph TD;
    Provisioning_Mode["Provisioning Mode"] --> Automatic
    Admin_Credentials["Admin Credentials"] --> Cross_Tenant_Sync_Policy["Cross Tenant Synchronization Policy"]
    Cross_Tenant_Sync_Policy --> Tenant_ID["Tenant Id"]
```

2. Select Get started.

3. Set the Provisioning Mode to Automatic.

4. Under the Admin Credentials section, change the Authentication Method to Cross Tenant Synchronization Policy.

Description: A screenshot of the provisioning configuration page in the Microsoft Entra admin center. The Provisioning Mode is set to Automatic, and the Authentication Method is set to Cross Tenant Synchronization Policy. There is a Tenant Id field and an option to Test Connection.

```mermaid
graph TD;
    Provisioning_Config["Provisioning Configuration"] --> Provisioning_Mode["Provisioning Mode: Automatic"]
    Provisioning_Config --> Admin_Credentials["Admin Credentials"]
    Admin_Credentials --> Auth_Method["Authentication Method: Cross Tenant Synchronization Policy"]
    Auth_Method --> Tenant_ID["Tenant Id"]
```
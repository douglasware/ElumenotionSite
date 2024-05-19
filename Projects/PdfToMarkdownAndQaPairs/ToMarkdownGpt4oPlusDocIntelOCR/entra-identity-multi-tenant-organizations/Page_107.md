If provisioning seems to be in an unhealthy state, the configuration will go into quarantine. For more information, see Application provisioning in quarantine status.

![Screenshot of provisioning page showing the Fabrikam to Contoso Overview with an option to start provisioning. The current cycle status is shown as 100% complete for users and groups.](figures/0)

```mermaid
graph TD;
    Overview --> Manage;
    Manage --> Users_and_groups;
    Manage --> Provisioning;
    Manage --> "Expression builder";
    Activity --> "Audit logs";
    Activity --> "Provisioning logs";
    Activity --> Insights;
    "Troubleshooting + Support" --> "View provisioning details";
    "Troubleshooting + Support" --> "View technical information";
    Statistics --> "Provisioning details";
    Statistics --> "Technical information";
```

2. Select Provisioning logs to determine which users have been provisioned successfully or unsuccessfully. By default, the logs are filtered by the service principal ID of the configuration. For more information, see Provisioning logs in Microsoft Entra ID.

![Screenshot of the provisioning logs page filtered by a specific application's service principal ID, showing the date, identity, action, source system, target system, and status of provisioning entries.](figures/1)

```mermaid
graph TD;
    Configuration --> "Service principal ID";
    Logs --> Download;
    Logs --> Learn_more;
    Logs --> Refresh;
    Logs --> Columns;
    Logs --> Filters["Add filters"];
    Identity --> "Display Name User3";
    Action --> Update;
    "Source System" --> "Azure Active Directory";
    "Target System" --> "Azure Active Directory (target tenant)";
    Status --> Success;
```

| Users and groups Provisioning | Date | Identity | Action | Source System | Target System | Status |
| - | - | - | - | - | - | - |
| Expression builder Activity | 1/22/2024, 6:18:47 PM | Display Name User3 Source ID Target ID | Update | Azure Active Directory | Azure Active Directory (target tenant) | Success |
|| 1/22/2024, 6:18:47 PM | Display Name User3 Source ID Target ID | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |
| Audit logs |||||||
| Provisioning logs 0 Insights Troubleshooting + Support | 1/22/2024, 6:18:39 PM | Display Name User1 Source ID Target ID | Other | Azure Active Directory | Azure Active Directory (target tenant) | Skipped |
|| 1/22/2024, 6:07:48 PM | Display Name User1 Source ID Target ID ❌ | Update | Azure Active Directory | Azure Active Directory (target tenant) | Success + |
| New support request | 1/22/2024, 6:07:48 PM | Display Name User1 Source ID Target ID ❌ ❌ | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |

3. Select Audit logs to view all logged events in Microsoft Entra ID. For more information, see Audit logs in Microsoft Entra ID.

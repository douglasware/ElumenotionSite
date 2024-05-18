If provisioning seems to be in an unhealthy state, the configuration will go into quarantine. For more information, see [Application provisioning in quarantine status](#).

![Provisioning Overview Screenshot](https://example.com/provisioning-overview)

1. Select **Provisioning logs** to determine which users have been provisioned successfully or unsuccessfully. By default, the logs are filtered by the service principal ID of the configuration. For more information, see [Provisioning logs in Microsoft Entra ID](#).

![Provisioning Logs Screenshot](https://example.com/provisioning-logs)

| Date/Time             | Identity                                     | Action | Source System       | Target System                         | Status  |
|-----------------------|----------------------------------------------|--------|---------------------|---------------------------------------|---------|
| 1/2/2024 6:18:47 PM   | Display Name User1<br>Source ID Target ID    | Update | Azure Active Directory | Azure Active Directory (target tenant) | Success |
| 1/2/2024 6:18:19 PM   | Display Name User2<br>Source ID Target ID    | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |
| 1/2/2024 6:18:19 PM   | Display Name User3<br>Source ID Target ID    | Update | Azure Active Directory | Azure Active Directory (target tenant) | Skipped |
| 1/2/2024 6:07:48 PM   | Display Name User4<br>Source ID Target ID    | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |
| 1/2/2024 6:07:48 PM   | Display Name User5<br>Source ID Target ID    | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |

2. Select **Audit logs** to view all logged events in Microsoft Entra ID. For more information, see [Audit logs in Microsoft Entra ID](#).
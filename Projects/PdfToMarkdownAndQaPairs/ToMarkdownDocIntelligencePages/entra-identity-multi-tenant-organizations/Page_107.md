If provisioning seems to be in an unhealthy state, the configuration will go into quarantine. For more information, see Application provisioning in quarantine status.

<figure>

![](figures/0)

<!-- FigureContent="... > Fabrikam to Contoso | Provisioning > Cross-tenant synchronization | Configurations > Fabrikam to Contoso Overview X Fabrikam - Microsoft Entra ID :selected: Start provisioning :unselected: Stop provisioning 5 Restart provisioning Edit provisioning .. Overview 4 Provision on demand Current cycle status Manage Initial cycle completed. Users and groups 100% complete Provisioning Expression builder Users 2 Activity View provisioning logs Audit logs Statistics to date Provisioning logs Insights v View provisioning details + Troubleshooting + Support v View technical information 1" -->

</figure>


2\. Select Provisioning logs to determine which users have been provisioned successfully or unsuccessfully. By default, the logs are filtered by the service principal ID of the configuration. For more information, see Provisioning logs in Microsoft Entra ID.

<figure>

![](figures/1)

<!-- FigureContent="... > Edit Attribute > Cross-tenant synchronization | Configurations > Fabrikam to Contoso | Provisioning > Cross-tenant synchronization | Configurations > Fabrikam to Contoso Fabrikam to Contoso | Provisioning logs X Fabrikam - Microsoft Entra ID « Download V Learn more Refresh EE Columns Got feedback? Overview % Provision on demand P Identity Name or ID Manage Date : Last 24 hours Show dates as: : Local Status : All Action : All Application contains 73574fa8-2ff5-4ada-bb13-32960b0434db × Add filters" -->

</figure>


| Users and groups Provisioning | Date | Identity | Action | Source System | Target System | Status |
| - | - | - | - | - | - | - |
| Expression builder Activity | 1/22/2024, 6:18:47 PM | Display Name User3 Source ID Target ID | Update | Azure Active Directory | Azure Active Directory (target tenant) | Success |
|| 1/22/2024, 6:18:47 PM | Display Name User3 Source ID Target ID | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |
| Audit logs |||||||
| Provisioning logs 0 Insights Troubleshooting + Support | 1/22/2024, 6:18:39 PM | Display Name User1 Source ID Target ID | Other | Azure Active Directory | Azure Active Directory (target tenant) | Skipped |
|| 1/22/2024, 6:07:48 PM | Display Name User1 Source ID Target ID :unselected: | Update | Azure Active Directory | Azure Active Directory (target tenant) | Success + |
| New support request | 1/22/2024, 6:07:48 PM | Display Name User1 Source ID Target ID :unselected: :unselected: | Create | Azure Active Directory | Azure Active Directory (target tenant) | Success |

3\. Select Audit logs to view all logged events in Microsoft Entra ID. For more information, see Audit logs in Microsoft Entra ID.
:selected: :selected: :selected: :selected: :selected: :unselected:
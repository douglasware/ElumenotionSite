<figure>
    The first figure shows a detailed UI of audit logs within a provisioning management system. The header indicates this view is set for attributes mapping, cross-tenant synchronization from Fabrikam to Contoso. A table lists activities by date, service, category, and specific operations with their status. There are various columns like Users, Date, Service, Category, Activity, Status, and Target for fine-grained tracking of provisioning actions.

    ```mermaid
    graph TD;
        AuditLogs["Audit Logs"] -->|View Items| AttributesMapping["Attribute Mapping"]
        AuditLogs -->|Edit Attribute| CrossTenantSync["Cross-tenant synchronization"]
        CrossTenantSync --> Configurations["Configurations > Fabrikam to Contoso"]
        Configurations --> Provisioning["Provisioning"]
        Provisioning --> FabricamContoso["Configuration > Fabrikam to Contoso"]
        Provisioning --> AuditLogs
    ```
</figure>

| Manage | Date : Last 1 month || Show dates as : Local  Service : All ❌ ❌ | Category : All ❌ | Activity : All || ty Add filters | | Initiated by (acto ... |
| Users and groups | Date | Service | Category | Activity | | Stat ... | Status reason | Target(s) ||
| - | - | - | - | - | - | - | - | - | - |
| Provisioning || 1/22/2024, 6:18:47 PM | Account Provisioning | ProvisioningManagement | Export | | Success | User 'user3@fabrika ... | Fabrikam to Contoso, user3 ... | Azure AD Cloud Sync |
| Expression builder | 1/22/2024, 6:18:47 PM | Account Provisioning | ProvisioningManagement | Export | | Success | User 'user3@fabrika ... | Fabrikam to Contoso, user3 ... | Azure AD Cloud Sync |
| Activity || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Synchronization rule action | Success | User 'user3@fabrika ... | Fabrikam to Contoso, user3 ... | Azure AD Cloud Sync |
| Audit logs || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Synchronization rule action | Success | The state of the entr ... | Fabrikam to Contoso, user1 ... | Azure AD Cloud Sync |
| Provisioning logs || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Synchronization rule action | Success | The state of the entr ... | Fabrikam to Contoso, user1 ... | Azure AD Cloud Sync |
| 0 Insights || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Import | | Success | ❌| No User with 'alterna ... | Fabrikam to Contoso, [Type: ... | Azure AD Cloud Sync |
| Troubleshooting + Support || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Import | | Success || Retrieved 'user1@fab ... | Fabrikam to Contoso, user1 ... | Azure AD Cloud Sync |
| New support request || 1/22/2024, 6:18:39 PM | Account Provisioning | ProvisioningManagement | Other | | Success || A target entry in Azu ... | Fabrikam to Contoso, user1 ... | Azure AD Cloud Sync |
|| + || 1/22/2024, 6:18:38 PM | Account Provisioning | ProvisioningManagement | Import | | Success || Received User 'user1 ... | Fabrikam to Contoso, user1 ... | Azure AD Cloud Sync |
| || 1/22/2024, 6:18:38 PM | Account Provisioning | ProvisioningManagement | Import | | Success | Received User 'user3 ... | Fabrikam to Contoso, user3 ... | Azure AD Cloud Sync |
| || 1/22/2024, 6:18:38 PM | Account Provisioning | ProvisioningManagement | Other | | Success | This app role assign ... | Fabrikam to Contoso | Azure AD Cloud Sync |

You can also view audit logs in the target tenant.

4\. In the target tenant, select Users > Audit logs to view logged events for user management.

<figure>
    The second figure details the audit logs page in the target tenant. The page shows user-related logs with several columns for dates, services, categories, activities, statuses, status reasons, targets, and who initiated the activities.

    ```mermaid
    graph TD;
        Home["Home > Contoso > Users"] --> UsersAuditLogs["Users > Audit Logs"]
        UsersAuditLogs --> AllUsers["All Users"]
        UsersAuditLogs --> SignInLogs["Sign-in Logs"]
        UsersAuditLogs --> DiagnoseAndSolve["Diagnose and solve problems"]
    ```
</figure>

| P Search « | ✅ Download Refresh | EE Columns | Or Got feedback?  | | | | | |
| - | - | - | - | - | - | - | - | - |
| All users | This view will be soon replaced with a view that includes infinite scrolling and column reordering. Try out our new audits preview. - > ||||||| |
| Audit logs | | | | | | || |
| Sign-in logs | Date : Last 1 month | Show dates as : Local | Service : All | Category : UserManagement | Activity : All ty Add filters ||| |
| Diagnose and solve problems | Date | Service | Category | Activity | Status | Status reason | Target(s) | Initiated by (actor) |
| Manage | 1/22/2024, 6:24:19 PM | Core Directory | UserManagement | Update user | Success | | user3_fabrikam.com ... | Microsoft Substrate Management |
| Deleted users | 1/22/2024, 6:18:47 PM | Core Directory | UserManagement | Update user | Success | | user3_fabrikam.com ... | Microsoft.Azure.SyncFabric |
| Password reset | 1/22/2024, 6:18:47 PM | Invited Users | UserManagement | Redeem external user invite | Success | | UPN: user3_fabrika ... | unknown |
| User settings | 1/22/2024, 6:18:47 PM | Invited Users | UserManagement | Redeem external user invite | Success | | | + |
| Bulk operation results | 1/22/2024, 6:18:47 PM | Core Directory | UserManagement | Update user | Success | | user3_fabrikam.com ... | Microsoft B2B Admin Worker |
| Troubleshooting + Support || 1/22/2024, 6:18:44 PM | Invited Users | UserManagement | Invite external user | Success | | user3 | Microsoft.Azure.SyncFabric |
| |1/22/2024, 6:18:44 PM | Core Directory | UserManagement | Add user | Success | | user3_fabrikam.com ... | Microsoft B2B Admin Worker |

# Step 14: Configure leave settings

<figure>
    The third figure describes the configuration process for leave settings in a target tenant's identity management system. The provided steps outline the navigation to the external collaboration settings in the tenant's identity section to adjust the leave permissions for external users.

    ```mermaid
    graph TD;
        TargetTenant["Target tenant"] --> IdentitySection["Identity > External Identities"]
        IdentitySection --> ExternalCollabSettings["External collaboration settings"]
    ```
</figure>

## Target tenant

Even though users are being provisioned in the target tenant, they still might be able to remove themselves. If users remove themselves and they are in scope, they'll be provisioned again during the next provisioning cycle. If you want to disallow the ability for users to remove themselves from your organization, you must configure the External user leave settings.

1. In the target tenant, browse to Identity > External Identities > External collaboration settings.
2. Under External user leave settings, choose whether to allow external users to leave your organization themselves.
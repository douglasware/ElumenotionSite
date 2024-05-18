## 
You can also view audit logs in the target tenant.

1. In the target tenant, select Users > Audit logs to view logged events for user management.

## 
| Date | Service | Category | Activity | Status | Status reason | Target(s) | Initiated by |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 1/2/2022, 6:41:24 PM  | Core Directory | UserManagement | Update user | Success | Success | user1@fabrikam.com | Microsoft System |
| 1/2/2022, 6:37:44 PM  | Invited Users | UserManagement | Redeem external user invite | Success | Success | user2@skarbo inc. | Azure AD B2B Collaboration |
| 1/2/2022, 6:37:44 PM  | Invited Users | UserManagement | Redeem external user invite | Success | Success | user2@skarbo inc. | Microsoft System |
| 1/2/2022, 6:36:07 PM  | Invited Users | UserManagement | Redeem external user invite | Error | Success | user3@contoso.com | Microsoft System |
| 1/2/2022, 6:34:12 PM  | Core Directory | UserManagement | Update user | Success | Success | user1@fabrikam.com | Microsoft 365 Admin Center |

## Step 14: Configure leave settings

### Target tenant

Even though users are being provisioned in the target tenant, they still might be able to remove themselves. If users remove themselves and they are in scope, they’ll be provisioned again during the next provisioning cycle. If you want to disallow the ability for users to remove themselves from your organization, you must configure the External user leave settings.

1. In the target tenant, browse to Identity > External Identities > External collaboration settings.

2. Under External user leave settings, choose whether to allow external users to leave your organization themselves.
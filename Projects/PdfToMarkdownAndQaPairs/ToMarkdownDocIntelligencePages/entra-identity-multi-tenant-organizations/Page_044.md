· Synchronization jobs created with Microsoft Entra ID will not appear in the Microsoft 365 admin center.

· If you created your synchronization job in the Microsoft 365 admin center, do

not modify the synchronization job name using Microsoft Entra ID, otherwise it will no longer appear in the admin center.

o You might adjust the attribute mappings to match your organizations' needs.
 :unselected:
· By default, new B2B users are provisioned as B2B members, while existing B2B :unselected: guests remain B2B guests.

o You can opt to convert B2B guests into B2B members by setting Apply this :unselected: mapping to Always.

. If you're using Microsoft Entra cross-tenant synchronization to provision your users, rather than the Microsoft 365 admin center share users functionality, Microsoft 365 admin center indicates an Outbound sync status of Not configured. This is expected behavior. Currently, Microsoft 365 admin center only shows the status of Microsoft Entra cross-tenant synchronization jobs created and managed by Microsoft 365 admin center and doesn't display Microsoft Entra cross-tenant synchronizations created and managed in Microsoft Entra ID.

. If you view Microsoft Entra cross-tenant synchronization in Microsoft Entra admin center, after adding tenants to or after joining a multitenant organization in Microsoft 365 admin center, you'll see a cross-tenant synchronization configuration with the name MTO\_Sync \_< TenantID> . Refrain from editing or changing the name if you want Microsoft 365 admin center to recognize the configuration as created and managed by Microsoft 365 admin center.

· Microsoft Entra cross-tenant synchronization doesn't support establishing a cross- tenant synchronization configuration before the tenant in question allows inbound synchronization in their cross-tenant access settings for identity synchronization. Hence the usage of the cross-tenant access settings template for identity synchronization is encouraged, with userSyncInbound set to true, as facilitated by Microsoft 365 admin center.

. There's no established or supported pattern for Microsoft 365 admin center to take control of pre-existing Microsoft Entra cross-tenant synchronization configurations and jobs.


# Join requests

. There are multiple reasons why a join request might fail. If the Microsoft 365 admin center doesn't indicate why a join request isn't succeeding, try examining the join request response by using the Microsoft Graph APIs or Microsoft Graph Explorer.
:unselected: :unselected: :unselected:
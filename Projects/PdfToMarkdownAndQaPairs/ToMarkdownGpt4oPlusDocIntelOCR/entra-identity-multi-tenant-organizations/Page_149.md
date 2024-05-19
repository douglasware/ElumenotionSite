minutes between when an object is assigned to an application and when that assignment is honored in on-demand provisioning. You may need to wait a few minutes and try again.

# Frequently asked questions

. Do you need to turn provisioning off to use on-demand provisioning? For applications that use a long-lived bearer token or a user name and password for authorization, no more steps are required. Applications that use OAuth for authorization currently require the provisioning job to be stopped before using on-demand provisioning. Applications such as G Suite, Box, Workplace by Facebook, and Slack fall into this category. Work is in progress to support on-demand provisioning for all applications without having to stop provisioning jobs.

. How long does on-demand provisioning take? On-demand provisioning typically takes less than 30 seconds.

# Known limitations

There are currently a few known limitations to on-demand provisioning. Post your suggestions and feedback 2 so we can better determine what improvements to make next.

# Note

The following limitations are specific to the on-demand provisioning capability. For information about whether an application supports provisioning groups, deletions, or other capabilities, check the tutorial for that application.

· On-demand provisioning of groups supports updating up to five members at a time. Connectors for cross-tenant synchronization, Workday, etc. do not support group provisioning and as a result do not support on-demand provisioning of groups.

· On-demand provisioning supports provisioning one user at a time through the Microsoft Entra admin center.

· Restoring a previously soft-deleted user in the target tenant with on-demand provisioning isn't supported. If you try to soft-delete a user with on-demand provisioning and then restore the user, it can result in duplicate users.

· On-demand provisioning of roles isn't supported.
❌ ❌ ❌ ❌ ❌ ❌ ❌ ✅ ❌ ❌ ✅
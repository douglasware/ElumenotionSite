## On-demand provisioning in Microsoft Entra ID
Article · 10/23/2023

Use on-demand provisioning to provision a user or group in seconds. Among other things, you can use this capability to:
- Troubleshoot configuration issues quickly.
- Validate expressions that you've defined.
- Test scoping filters.

### How to use on-demand provisioning

> **Tip**
> Steps in this article may vary slightly based on the portal you start from.

1. Sign in to the Microsoft Entra admin center as at least a Application Administrator.
2. Browse to Identity > Applications > Enterprise applications > select your application.
3. Select Provisioning.
4. Configure provisioning by providing your admin credentials.
5. Select Provision on demand.
6. Search for a user by first name, last name, display name, user principal name, or email address. Alternatively, you can search for a group and pick up to five users.

> **Note**
> For Cloud HR provisioning app (Workday / SuccessFactors to Active Directory / Microsoft Entra ID), the input value is different. For Workday scenario, please provide "WorkerID" or "WID" of the user in Workday. For SuccessFactors scenario, please provide "personldExternal" of the user in SuccessFactors.

7. Select Provision at the bottom of the page.
## Scoping users or groups to be provisioned with scoping filters

*Article • 01/18/2024*

Learn how to use scoping filters in the Microsoft Entra provisioning service to define attribute based rules. The rules are used to determine which users or groups are provisioned.

## Scoping filter use cases

You use scoping filters to prevent objects in applications that support automated user provisioning from being provisioned if an object doesn't satisfy your business requirements. A scoping filter allows you to include or exclude any users who have an attribute that matches a specific value. For example, when provisioning users from Microsoft Entra ID to a SaaS application used by a sales team, you can specify that only users with a "Department" attribute of "Sales" should be in scope for provisioning.

Scoping filters can be used differently depending on the type of provisioning connector:

- **Outbound provisioning from Microsoft Entra ID to SaaS applications.** When Microsoft Entra ID is the source system, user and group assignments are the most common method for determining which users are in scope for provisioning. These assignments also are used for enabling single sign-on and provide a single method to manage access and provisioning. Scoping filters can be used optionally, in addition to assignments or instead of them, to filter users based on attribute values.

> ### Tip
> The more users and groups in scope for provisioning, the longer the synchronization process can take. Setting the scope to sync assigned users and groups, limiting the number of groups assigned to the app, and limiting the size of the groups will reduce the time it takes to synchronize everyone that is in scope.

- **Inbound provisioning from HCM applications to Microsoft Entra ID and Active Directory.** When an HCM application such as Workday is the source system, scoping filters are the primary method for determining which users should be provisioned from the HCM application to Active Directory or Microsoft Entra ID.
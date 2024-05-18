## Can I use cross-tenant synchronization across organizations (outside my multitenant organization)?

- For privacy reasons, cross-tenant synchronization is intended for use within an organization. We recommend using entitlement management for inviting B2B collaboration users across organizations.

## Can cross-tenant synchronization be used to migrate users from one tenant to another tenant?

- No. Cross-tenant synchronization isn't a migration tool because the source tenant is required for synchronized users to authenticate. In addition, tenant migrations would require migrating user data such as SharePoint and OneDrive.

## B2B collaboration

Does cross-tenant synchronization resolve any present B2B collaboration limitations?

- Since cross-tenant synchronization is built on existing B2B collaboration technology, existing limitations apply. Examples include (but aren't limited to):

| App or service        | Limitations                                                                                                                   |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------------|
| Power BI              | - Support for UserType Member in Power BI is currently in preview. For more information, see [Distribute Power BI content to external guest users with Microsoft Entra B2B](https://learn.microsoft.com/power-bi/shared-with-me-publish-to-web). |
| Azure Virtual Desktop | - External member and external guest aren't supported in Azure Virtual Desktop.                                                |

## B2B direct connect

How does cross-tenant synchronization relate to [B2B direct connect](https://learn.microsoft.com/b2b-direct-connect)?
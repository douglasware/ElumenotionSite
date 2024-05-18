> 💡 Note
>
> If the B2B user already exists in the target tenant then Member (userType) will not change to Member, unless the Apply this mapping setting is set to Always.

The user type you choose has the following limitations for apps or services (but aren't limited to):

| App or service         | Limitations                                                                                                                                                                                                                                                       |
|------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Power BI               | - Support for UserType Member in Power BI is currently in preview. For more information, see [Distribute Power BI content to external guest users with Microsoft Entra B2B.](https://learn.microsoft.com/en-us/power-bi/admin/service-admin-azure-ad-b2b)           |
| Azure Virtual Desktop  | - External member and external guest aren't supported in Azure Virtual Desktop.                                                                                                                                                                                    |


...

![Edit Attribute settings window showing "Member" as the Constant Value.](image_placeholder)

...

6. If you want to define any transformations, on the **Attribute Mapping** page, select the attribute you want to transform, such as **displayName**.

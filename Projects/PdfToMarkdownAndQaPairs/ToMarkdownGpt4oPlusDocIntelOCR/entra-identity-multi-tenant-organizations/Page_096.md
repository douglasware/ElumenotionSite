<!-- PageHeader="9\. Select Assign." -->

<figure>
Description: The figure depicts the "Fabrikam to Contoso | Users and groups" screen in Microsoft Entra ID, displaying a list of users and groups with various provisioning options.

```mermaid
graph TD;
    Overview --> Users_and_groups;
    Overview --> Provisioning;
    Overview --> Expression_builder;
    Activity --> Audit_logs;
    Activity --> Provisioning_logs;
    Activity --> Insights;
    Troubleshooting_and_Support --> "New_support_request";
```
</figure>

| Display Name | Object Type | Role assigned |
| - | - | - |
| ❌ ✅  US User3| User | Default Access |
| ❌ ✅  US User1| User | Default Access |
| ❌ GR Group1 | Group | Default Access |

For more information, see Assign users and groups to an application.


# Step 8: (Optional) Define who is in scope for provisioning with scoping filters

## Source tenant

Regardless of the value you selected for Scope in the previous step, you can further limit which users are synchronized by creating attribute-based scoping filters.

1. In the source tenant, select Provisioning and expand the Mappings section.
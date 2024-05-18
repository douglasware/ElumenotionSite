## Configure Scoping Filters
To configure scoping filters, refer to the instructions provided in Scoping users or groups to be provisioned with scoping filters.

### Add Scoping Filter

| Target Attribute | Operator | Value       | Action            |
|------------------|----------|-------------|-------------------|
| department       | EQUALS   | Marketing   | Add New Scoping Clause |

**Note:** If multiple scoping clauses are present, they are evaluated using "AND" logic.

- Select **Ok** and **Save** to save any changes.

If you added a filter, you'll see a message that saving your changes will result in all assigned users and groups being resynchronized. This may take a long time depending on the size of your directory.

- Select **Yes** and close the Attribute Mapping page.

## Review Attribute Mappings

### Source Tenant

Attribute mappings allow you to define how data should flow between the source tenant and target tenant. For information on how to customize the default attribute mappings, see [Tutorial - Customize user provisioning attribute-mappings for SaaS applications in Microsoft Entra ID](#).

1. In the source tenant, select **Provisioning** and expand the **Mappings** section.
2. Select **Provision Microsoft Entra ID Users**.
3. On the **Attribute Mapping** page, scroll down to review the user attributes that are synchronized between tenants in the **Attribute Mappings** section.
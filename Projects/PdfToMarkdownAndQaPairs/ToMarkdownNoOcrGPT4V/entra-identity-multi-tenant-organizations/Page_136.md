## Create scoping filters

Scoping filters are configured as part of the attribute mappings for each Microsoft Entra user provisioning connector. The following procedure assumes that you already set up automatic provisioning for one of the supported applications and are adding a scoping filter to it.

### Create a scoping filter

#### Tip
Steps in this article might vary slightly based on the portal you start from.

1. Sign in to the Microsoft Entra admin center as at least a Application Administrator.
2. Browse to Identity > Applications > Enterprise applications > All applications.
3. Select the application for which you have configured automatic provisioning: for example, "ServiceNow".
4. Select the Provisioning tab.
5. In the Mappings section, select the mapping that you want to configure a scoping filter for: for example, "Synchronize Microsoft Entra users to ServiceNow".
6. Select the Source object scope menu.
7. Select Add scoping filter.
8. Define a clause by selecting a source Attribute Name, an Operator, and an Attribute Value to match against. The following operators are supported:
   - `&` Clause returns "true" if the evaluated attribute exists in the input string value.
   - `!&` Clause returns "true" if the evaluated attribute does not exist in the input string value.

### Criteria for Scope Filter Application
- They must work in the Engineering department.
- Their company employee ID must be between 1,000,000 and 2,000,000.
- Their job title must not be null or empty.
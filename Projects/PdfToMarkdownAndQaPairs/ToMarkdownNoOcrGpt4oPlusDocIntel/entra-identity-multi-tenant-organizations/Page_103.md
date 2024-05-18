Now that you have a configuration, you can test on-demand provisioning with one of your users.

1. In the source tenant, browse to Identity > External Identities > Cross-tenant synchronization.

2. Select Configurations and then select your configuration.

3. Select Provision on demand.

4. In the Select a user or group box, search for and select one of your test users.
    ![Screenshot of Provision on demand page with instruction to select a user or group](figures/0) 

    ```mermaid
    graph TD;
        Browse["Browse to Identity > External Identities > Cross-tenant synchronization"] --> Configurations["Select Configurations"]
        Configurations --> Provision_on_demand["Select Provision on demand"]
        Provision_on_demand --> SearchUser["Search for and select one of your test users"]
        SearchUser --> ProvisionButton["Select Provision"]
        ProvisionButton --> PerformAction["Perform action page appears with information about the provisioning of the test user in the target tenant"]
    ```

5. Select Provision.

After a few moments, the Perform action page appears with information about the provisioning of the test user in the target tenant.
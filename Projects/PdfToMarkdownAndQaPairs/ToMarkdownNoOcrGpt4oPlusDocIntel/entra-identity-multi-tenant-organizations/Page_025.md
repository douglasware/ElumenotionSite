# Step 1: Define how to structure the tenants in your organization

Cross-tenant synchronization provides a flexible solution to enable collaboration, but every organization is different. For example, you might have a central tenant, satellite tenants, or sort of a mesh of tenants. Cross-tenant synchronization supports any of these topologies. For more information, see Topologies for cross-tenant synchronization.

A diagram illustrating possible tenant structures.

```mermaid
graph TD;
    A1["Central Tenant"] --> A2["Satellite Tenant 1"];
    A1 --> A3["Satellite Tenant 2"];
    A4["Mesh Tenant 1"] --> A5["Mesh Tenant 2"];
    A4 --> A6["Mesh Tenant 3"];
    A5 --> A6;
```

# Step 2: Enable cross-tenant synchronization in the target tenants

In the target tenant where users are created, navigate to the Cross-tenant access settings page. Here you enable cross-tenant synchronization and the B2B automatic redemption settings by selecting the respective check boxes. For more information, see Configure cross-tenant synchronization.

Diagram showing the "Target tenant" with settings for "Inbound access" that have "Allow users sync into this tenant" and "Automatically redeem invitations" checked.

```mermaid
graph TD;
    TargetTenant["Target Tenant"] --> InboundAccessSettings["Inbound Access Settings"];
    InboundAccessSettings --> AllowUsersSync["Allow users sync into this tenant"];
    InboundAccessSettings --> AutomaticallyRedeem["Automatically redeem invitations"];
```

# Step 3: Enable cross-tenant synchronization in the source tenants

In any source tenant, navigate to the Cross-tenant access settings page and enable the B2B automatic redemption feature. Next, you use the Cross-tenant synchronization page to set up a cross-tenant synchronization job and specify:

* Which users you want to synchronize
* What attributes you want to include
* Any transformations

For anyone that has used Microsoft Entra ID to provision identities into a SaaS application, this experience will be familiar. Once you have synchronization configured,
<figure>

Diagram depicting the relationship and user synchronization across three tenants in a multitenant organization. The tenants are Tenant A, Tenant B, and Tenant C, with users classified as Internal or External.

```mermaid
graph TD;
    TenantB["Tenant B"]
    TenantA["Tenant A"]
    TenantC["Tenant C"]
    
    InternalBob["Internal Bob"] --> TenantB
    InternalBarbara["Internal Barbara"] --> TenantB
    ExternalAnnie_B["External Annie"] --> TenantB
    ExternalCharles_B["External Charles"] --> TenantB
    
    InternalAnnie_A["Internal Annie"] --> TenantA
    ExternalBob_A["External Bob"] --> TenantA
    ExternalBarbara_A["External Barbara"] --> TenantA
    ExternalCharles_A["External Charles"] --> TenantA
    
    InternalCharles_C["Internal Charles"] --> TenantC
    ExternalAnnie_C["External Annie"] --> TenantC
    ExternalBob_C["External Bob"] --> TenantC
    ExternalBarbara_C["External Barbara"] --> TenantC
    
    TenantB --> TenantA
    TenantA --> TenantB
    
    TenantB --> TenantC
    TenantC --> TenantB
    
    TenantA --> TenantC
    TenantC --> TenantA
    
    style InternalBob fill:#00f
    style InternalBarbara fill:#00f
    style ExternalAnnie_B fill:#f0f
    style ExternalCharles_B fill:#f0f
    style InternalAnnie_A fill:#00f
    style ExternalBob_A fill:#f0f
    style ExternalBarbara_A fill:#f0f
    style ExternalCharles_A fill:#f0f
    style InternalCharles_C fill:#00f
    style ExternalAnnie_C fill:#f0f
    style ExternalBob_C fill:#f0f
    style ExternalBarbara_C fill:#f0f
```

</figure>

Microsoft 365 admin center facilitates orchestration of such a collaborating user set across multitenant organization tenants. For more information, see Synchronize users in multitenant organizations in Microsoft 365.

Alternatively, pair-wise configuration of inbound and outbound cross-tenant synchronization can be used to orchestrate such collating user set across multitenant organization tenants. For more information, see What is a cross-tenant synchronization.

# B2B member users

To ensure a seamless collaboration experience across the multitenant organization in new Microsoft Teams, B2B identities are provisioned as B2B users of Member userType.

Expand table

| User synchronization method | Default userType property |
| - | - |
| Synchronize users in multitenant organizations in Microsoft 365 | Member Remains Guest, if the B2B identity already existed as Guest |
| Cross-tenant synchronization in Microsoft Entra ID | Member Remains Guest, if the B2B identity already existed as Guest |
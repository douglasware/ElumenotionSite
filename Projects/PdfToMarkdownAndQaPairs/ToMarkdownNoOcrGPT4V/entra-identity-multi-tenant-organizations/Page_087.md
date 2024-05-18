## Configure cross-tenant synchronization

Article • 03/11/2024

This article describes the steps to configure cross-tenant synchronization using the Microsoft Entra admin center. When configured, Microsoft Entra ID automatically provisions and de-provisions B2B users in your target tenant. For important details on what this service does, how it works, and frequently asked questions, see Automate user provisioning and deprovisioning to SaaS applications with Microsoft Entra ID.

```mermaid
flowchart LR
    Source([Source tenant]) -->|Cross-tenant synchronization| Target([Target tenant])
    Source -->|Outbound access settings| Conf([Configuration])
    Conf -->|Scoping filters<br/>Attribute mappings| Scope([Scope])
    
    subgraph Source
      US1([UserS1])
      US2([UserS2])
      US3([UserS3])
    end
    
    subgraph Target
      UT1([UserT1])
      UT2([UserT2])
      UT3([UserT3])
      GT1([GroupT1])
    end
    
    subgraph Conf
      SF([Scoping filters<br/>UserS1, UserS3<br/>department EQUALS Marketing])
      AM([Attribute mappings<br/>accountEnabled<br/>employeed<br/>userPrincipalName<br/>extensionName])
    end
    
    subgraph Scope 
      OS([UserS1, UserS3])
    end
```

### Learning objectives

By the end of this article, you'll be able to:

- Create B2B users in your target tenant
- Remove B2B users in your target tenant
- Keep user attributes synchronized between your source and target tenants

### Prerequisites

Source tenant
## Configure cross-tenant synchronization using PowerShell or Microsoft Graph API

Article · 04/23/2024

This article describes the key steps to configure cross-tenant synchronization using Microsoft Graph PowerShell or Microsoft Graph API. When configured, Microsoft Entra ID automatically provisions and de-provisions B2B users in your target tenant. For detailed steps using the Microsoft Entra admin center, see [Configure cross-tenant synchronization](#).

```mermaid
graph LR
  A[Source tenant] -->|Cross-tenant synchronization| B[Target tenant]
  subgraph A
    C[UserS1] --> D[Outbound access settings]
    E[UserS2]
    F[UserS3] --> D
    D -->|Automatically redeem invitations| G[Configuration]
    G --> H[Scope]
    H -->|UserS1 UserS3| I[Scoping filters]
    I -->|department EQUALS Marketing| J[Attribute mappings]
    J -.-> K[accountEnabled]
    J -.-> L[employeeld]
    J -.-> M[userPrincipalName]
    J -.-> N[extensionName]
  end
  subgraph B
    O[Internal UserT1 UserT2 UserT3 GroupT1]
    P[External UserS1 UserS3] --> Q[Inbound access settings]
    Q -.->|Allow users sync into this tenant| R
    Q -.->|Automatically redeem invitations| R
  end
```

### Prerequisites

#### Source tenant

- Microsoft Entra ID P1 or P2 license. For more information, see [License requirements](#).
- Security Administrator role to configure cross-tenant access settings.
- Hybrid Identity Administrator role to configure cross-tenant synchronization.
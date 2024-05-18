## Configure cross-tenant synchronization using PowerShell or Microsoft Graph API

Article • 04/23/2024

This article describes the key steps to configure cross-tenant synchronization using Microsoft Graph PowerShell or Microsoft Graph API. When configured, Microsoft Entra ID automatically provisions and de-provisions B2B users in your target tenant. For detailed steps using the Microsoft Entra admin center, see [Configure cross-tenant synchronization](#).

### Diagram Overview

```mermaid
graph LR
    A[Source Tenant] -->|Cross-tenant synchronization| B[Target Tenant]
    A -->|Outbound access settings| A1[UserS1, UserS2, UserS3]
    A1 -.->|Automatically redeem invitations| A
    A --> C[Configuration]
    C -.->|Scoping filters: department EQUALS Marketing| C
    C -->|Attribute mappings| C1{accountEnabled, employed, userPrincipalName, companyName}
    B -.->|Inbound access settings| B1[Allow users sync into this tenant]
    B1 -.->|Automatically redeem invitations| B
    B --> D[Internal User1, User2, User3, GroupT1]
    D --> E[External UserS1, UserS3]
```

### Prerequisites

Source tenant

- Microsoft Entra ID P1 or P2 license. For more information, see [License](#)
- Security Administrator role to configure cross-tenant access settings.
- Hybrid Identity Administrator role to configure cross-tenant synchronization.
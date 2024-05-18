## Configure a multitenant organization using PowerShell or Microsoft Graph API

Article • 04/24/2024

This article describes the key steps to configure a multitenant organization using Microsoft Graph PowerShell or Microsoft Graph API. This article uses an example owner tenant named **Cairo** and two member tenants named **Berlin** and **Athens**.

If you instead want to use the Microsoft 365 admin center to configure a multitenant organization, see [Set up a multitenant org in Microsoft 365](https://example.com/set-up-multi-tenant-org) and [Join or leave a multitenant organization in Microsoft 365](https://example.com/join-leave-multi-tenant-org). To learn how to configure Microsoft Teams for your multitenant organization, see [The new Microsoft Teams desktop client](https://example.com/new-teams-client).

### Organizational Structure

```mermaid
graph TD;
    Cairo -->|Cross-tenant access settings| Athens;
    Cairo -->|Cross-tenant access settings| Berlin;
```

## Prerequisites

**Owner tenant**

- For license information, see [License requirements](https://example.com/license-requirements).
- **Security Administrator** role to configure cross-tenant access settings and templates for the multitenant organization.
- **Global Administrator** role to consent to required permissions.
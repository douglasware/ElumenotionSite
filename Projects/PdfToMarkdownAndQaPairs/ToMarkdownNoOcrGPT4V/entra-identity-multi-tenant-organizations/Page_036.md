## Microsoft 365 Admin Center

![Tenant Collaboration Diagram](image url)

Microsoft 365 admin center facilitates orchestration of such a collaborating user set across multitenant organization tenants.

Alternatively, pair-wise configuration of inbound and outbound cross-tenant synchronization can be used to orchestrate such collating user set across multitenant organization tenants.

## B2B Member Users

To ensure a seamless collaboration experience across the multitenant organization in new Microsoft Teams, B2B identities are provisioned as B2B users of Member userType.

### User Synchronization Methods

| User synchronization method                                      | Default userType property |
|------------------------------------------------------------------|---------------------------|
| Synchronize users in multitenant organizations in Microsoft 365  | Member                    |
|                                                                  | Remains Guest, if the B2B identity already existed as Guest |
| Cross-tenant synchronization in Microsoft Entra ID               | Member                    |
|                                                                  | Remains Guest, if the B2B identity already existed as Guest |
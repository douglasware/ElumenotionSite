## B2B member users

To ensure a seamless collaboration experience across the multitenant organization in new Microsoft Teams, B2B identities are provisioned as B2B users of Member userType.

| User synchronization method                                                                 | Default userType property                       |
|--------------------------------------------------------------------------------------------|------------------------------------------------|
| [Synchronize users in multitenant organizations in Microsoft 365](#)                  | Member Remains Guest, if the B2B identity already existed as Guest    |
| [Cross-tenant synchronization in Microsoft Entra ID](#)                                | Member Remains Guest, if the B2B identity already existed as Guest    |
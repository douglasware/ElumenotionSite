## Tenant Description

| Tenant | Description |
| ------ | ----------- |
| A      | Administrators see a multitenant organization consisting of A, B, C. They also see cross-tenant access settings for B and C. |
| B      | Administrators see a multitenant organization consisting of A, B, C. They also see cross-tenant access settings for A and C. |
| C      | Administrators see a multitenant organization consisting of A, B, C. They also see cross-tenant access settings for A and B. |

## Templates for cross-tenant access settings

To ease the setup of homogenous cross-tenant access settings applied to partner tenants in the multitenant organization, the administrator of each multitenant organization tenant can configure optional cross-tenant access settings templates dedicated to the multitenant organization. These templates can be used to preconfigure cross-tenant access settings that are applied to any partner tenant newly joining the multitenant organization.

## Tenant role and state

To facilitate the management of a multitenant organization, any given multitenant organization tenant has an associated role and state.

| Tenant role | Description |
| ----------- | ----------- |
| Owner       | One tenant creates the multitenant organization. The multitenant organization creating tenant receives the role of owner. The privilege of the owner tenant is to add tenants into a pending state as well as to remove tenants from the multitenant organization. Also, an owner tenant can change the role of other multitenant organization tenants. |
| Member      | Following the addition of pending tenants to the multitenant organization, pending tenants need to join the multitenant organization to turn their state from pending to active. Joined tenants typically start in the member role. Any member tenant has the privilege to leave the multitenant organization. |
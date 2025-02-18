## Multitenant organization identity provisioning for Microsoft 365

### Article · 04/24/2024

The multitenant organization capability is designed for organizations that own multiple Microsoft Entra tenants and want to streamline intra-organization cross-tenant collaboration in Microsoft 365. It's built on the premise of reciprocal provisioning of B2B member users across multitenant organization tenants.

### Microsoft 365 people search

Teams external access and Teams shared channels excluded, Microsoft 365 people search is typically scoped to within local tenant boundaries. In multitenant organizations with increased need for cross-tenant coworker collaboration, it's recommended to reciprocally provision users from their home tenants into the resource tenants of collaborating coworkers.

### New Microsoft Teams

The new Microsoft Teams experience improves upon Microsoft 365 people search and Teams external access for a unified seamless collaboration experience. For this improved experience to light up, the multitenant organization representation in Microsoft Entra ID is required and collaborating users shall be provisioned as B2B members. For more information, see Announcing more seamless collaboration in Microsoft Teams for multitenant organizations.

### Collaborating user set

Collaboration in Microsoft 365 is built on the premise of reciprocal provisioning of B2B identities across multitenant organization tenants.

For example, say Annie in tenant A, Bob and Barbara in tenant B, and Charlie in tenant C want to collaborate. Conceptually, these four users represent a collaborating user set of four internal identities across three tenants.
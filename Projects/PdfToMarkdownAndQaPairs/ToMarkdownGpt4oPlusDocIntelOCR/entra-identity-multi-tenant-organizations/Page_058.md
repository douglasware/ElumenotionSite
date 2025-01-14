# Govern access for security operations center (SOC) teams in a multitenant environment

Article · 05/02/2024

Managing multitenant environments can add another layer of complexity when it comes to keeping up with the ever-evolving security threats facing your enterprise. Navigating across multiple tenants can be time consuming and reduce the overall efficiency of security operation center (SOC) teams. Multitenant management in Microsoft Defender XDR provides security operation teams with a single, unified view of all the tenants they manage. This view enables teams to quickly investigate incidents and perform advanced hunting across data from multiple tenants, improving their security operations.

Microsoft Entra ID Governance enables you to govern the access and lifecycle of the users who are members of the SOC teams and threat hunter teams. This document explores:

- The controls you can put in place for SOC teams to securely access resources across tenants.
- Example topologies for how you can implement your lifecycle and access controls.
- Deployment considerations (roles, monitoring, APIs).

# Manage the lifecycle and access of a SOC user

Microsoft Entra provides the controls needed to govern the lifecycle of a SOC user and to securely provide access to the resources they need. In this document, the term source tenant refers to where the SOC users originate and authenticate against. Target tenant refers to the tenant that they're investigating when there's an incident. Organizations have multiple target tenants due to mergers and acquisitions, aligning tenants with business units, and aligning tenants with geos.

# Lifecycle control

Entitlement management, through access packages and connected organizations allows the target tenant administrator to define collections of resources (ex: app roles, directory roles, and groups) that users from the source tenant can request access to. If the user is approved for the resources they need, but don't yet have a B2B account, entitlement management will automatically create a B2B account for the user in the
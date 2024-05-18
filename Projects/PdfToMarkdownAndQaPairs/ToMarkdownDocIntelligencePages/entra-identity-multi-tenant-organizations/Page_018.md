# Step 2: Create your multitenant organization

Create your multitenant organization using Microsoft 365 admin center, Microsoft Graph PowerShell, or Microsoft Graph API:

· First tenant, soon-to-be owner tenant, creates a multitenant organization.

· Owner tenant adds one or more joiner tenants.


## Step 3: Join a multitenant organization

Join a multitenant organization using Microsoft 365 admin center or Microsoft Graph PowerShell, or Microsoft Graph API:

· Joiner tenants submit a join request to join the multitenant organization of owner tenant.

. To allow for asynchronous processing, wait up to 2 hours.

Your multitenant organization is formed.


# Step 4: Synchronize users

Depending on your use case, you may want to synchronize users using one of the following methods:

· Synchronize users in multitenant organizations in Microsoft 365

· Configure cross-tenant synchronization

. Configure cross-tenant synchronization using PowerShell or Microsoft Graph API

· Your alternative bulk provisioning engine


# License requirements

The multitenant organization capability requires Microsoft Entra ID P1 licenses. Only one Microsoft Entra ID P1 license is required per employee per multitenant organization. Also, you must have at least one Microsoft Entra ID P1 license per tenant. To find the right license for your requirements, see Compare generally available features of Microsoft Entra ID Z.


# Next steps

· Plan for multitenant organizations in Microsoft 365

· What is cross-tenant synchronization?
:selected:
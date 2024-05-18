Map directory extensions in cross- tenant synchronization
===

Article · 01/30/2024

Directory extensions enable you to extend the schema in Microsoft Entra ID with your own attributes. You can map these directory extensions when provisioning users in cross-tenant synchronization. Custom security attributes are different and aren't supported in cross-tenant synchronization.

This article describes how to map directory extensions in cross-tenant synchronization.


# Prerequisites

· Hybrid Identity Administrator role to configure cross-tenant synchronization.

· Cloud Application Administrator or Application Administrator role to assign users to a configuration and to delete a configuration.


# Create directory extensions

If you don't already have directory extensions, you must create one or more directory extensions in the source or target tenant. You can create extensions using Microsoft Entra Connect or Microsoft Graph API. For information on how to create directory extensions, see Syncing extension attributes for Microsoft Entra Application Provisioning.


# Map directory extensions

<figure>

![](figures/0)

</figure>



## Source tenant

Once you have one or more directory extensions, you can use them when mapping attributes in cross-tenant synchronization.

1\. Sign in to the Microsoft Entra admin center 4 of the source tenant.

2\. Browse to Identity > External Identities > Cross-tenant synchronization.

3\. Select Configurations and then select your configuration.

4\. Select Provisioning and expand the Mappings section.

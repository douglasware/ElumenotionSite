## Inbound access settings - Contoso

Enabling this will allow the admin of the specified (source) tenant to sync objects into this (target) tenant.

Disabling this will block admins of the source tenant from syncing objects into the target tenant but will not remove currently synced objects. We recommend that this setting should only be used between tenants that are part of the same organization.

**Allow users sync into this tenant**

_Save_ _Discard_

To configure this setting using Microsoft Graph, see the [Update crossTenantIdentitySyncPolicyPartner](https://docs.microsoft.com/en-us/graph/api/crosstenantidentitysyncpolicypartner-update) API. For more information, see [Configure cross-tenant synchronization](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/cross-tenant-synchronization).

### Automatic redemption setting

The automatic redemption setting is an inbound and outbound organizational trust setting to automatically redeem invitations so users don't have to accept the consent prompt the first time they access the resource/target tenant. This setting is a check box with the following name:

- Automatically redeem invitations with the tenant \<tenant\>

**Automatically redeem invitations with the tenant fc19f62b-c752-43d3-a13a-c75e9a85a7dc.**

_Save_ _Discard_

### Compare setting for different scenarios

The automatic redemption setting applies to cross-tenant synchronization, B2B collaboration, and B2B direct connect in the following situations:
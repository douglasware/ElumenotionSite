## Outbound access settings - Contoso

### Automatic redemption

- [ ] Check this setting if you want to automatically redeem invitations. If so, users from this tenant don't have to accept the consent prompt the first time they access the specified tenant using cross-tenant synchronization, B2B collaboration, or B2B direct connect. This setting will only suppress the consent prompt if the specified tenant checks this setting for inbound access as well. [Learn more](#)

  - [x] Automatically redeem invitations with the tenant aa5eaf5a-ecc3-49f6-aac8-e50a26e228de.

---

### Cause

Your tenant doesn't have a Microsoft Entra ID P1 or P2 license.

### Solution

You must have Microsoft Entra ID P1 or P2 to configure trust settings.

### Symptom - Recently deleted user in the target tenant is not restored

After soft deleting a synchronized user in the target tenant, the user isn't restored during the next synchronization cycle. If you try to soft delete a user with on-demand provisioning and then restore the user, it can result in duplicate users.

### Cause

Restoring a previously soft-deleted user in the target tenant isn't supported.

### Solution

Manually restore the soft-deleted user in the target tenant. For more information, see [Restore or remove a recently deleted user using Microsoft Entra ID](#).

### Symptom - Users are skipped because SMS sign-in is enabled on the user
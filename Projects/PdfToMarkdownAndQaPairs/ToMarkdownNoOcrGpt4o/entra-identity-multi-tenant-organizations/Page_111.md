## Cause

Your tenant doesn't have a Microsoft Entra ID P1 or P2 license.

## Solution

You must have Microsoft Entra ID P1 or P2 to configure trust settings.

### Symptom - Recently deleted user in the target tenant is not restored

After soft deleting a synchronized user in the target tenant, the user isn't restored during the next synchronization cycle. If you try to soft delete a user with on-demand provisioning and then restore the user, it can result in duplicate users.

#### Cause

Restoring a previously soft-deleted user in the target tenant isn't supported.

#### Solution

Manually restore the soft-deleted user in the target tenant. For more information, see [Restore or remove a recently deleted user using Microsoft Entra ID](https://example-link).

### Symptom - Users are skipped because SMS sign-in is enabled on the user
## Role        : owner
## State       : active
## TenantId    : <OwnerTenantId>
## TransitionDetails : Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphMultiTenantOrganizationMemberTransitionDetails
## AdditionalProperties : {[multiTenantOrgLabelType, none]}

4. To allow for asynchronous processing, wait **up to 2 hours** before joining a multitenant organization is completed.

## Step 8: (Optional) Leave the multitenant organization

#### Member tenant

You can leave a multitenant organization that you have joined. The process for removing your own tenant from the multitenant organization is the same as the process for removing another tenant from the multitenant organization.

If your tenant is the only multitenant organization owner, you must designate a new tenant to be the multitenant organization owner. For steps, see [Step 4: (Optional) Change the role of a tenant](#).

#### PowerShell

- In the tenant, use the [Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant](#) command to remove the tenant. This operation takes a few minutes.

```powershell
Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId <MemberTenantId>
```

## Step 9: (Optional) Delete the multitenant organization
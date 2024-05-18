1. In the owner tenant, use the [Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.identity.multitenantorganization/remove-mgbetatenantrelationshipmultitenantorganizationtenant?view=graph-powershell-beta) command to remove any member tenant. This operation takes a few minutes.

    ```PowerShell
    Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId <MemberTenantIdID>
    ```

2. Use the [Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.identity.multitenantorganization/get-mgbetatenantrelationshipmultitenantorganizationtenant?view=graph-powershell-beta) command to verify the change.

    ```PowerShell
    Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId <MemberTenantIdID>
    ```

After the remove command completes, the output is similar to the following. This is an expected error message. It indicates that the tenant has been removed from the multitenant organization.

    ```Output
    Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant_Get:
    Unable to read the company information from the directory.

    Status: 404 (NotFound)
    ErrorCode: Directory_ObjectNotFound
    Date: 2024-01-08T20:35:11

    ...

    ```

## Step 6: Sign in to a member tenant

### Member tenant

The Cairo tenant created a multitenant organization and added the Berlin and Athens tenants. In these steps, you sign in to the Berlin tenant and join the multitenant organization created by Cairo.
## Member tenant

- For license information, see [License requirements](https://example.com/license).
- Security Administrator role to configure cross-tenant access settings and templates for the multitenant organization.
- Global Administrator role to consent to required permissions.

## Step 1: Sign in to the owner tenant

### Owner tenant

```PowerShell
# Start PowerShell.
Start PowerShell.

# If necessary, install the Microsoft Graph PowerShell SDK.
Install the Microsoft Graph PowerShell SDK.

# Get the tenant ID of the owner and member tenants and initialize variables.
$ownerTenantId = "OwnerTenantId"
$memberTenantIdB = "MemberTenantIdB"
$memberTenantIdA = "MemberTenantIdA"

# Use the Connect-MgGraph command to sign in to the owner tenant and consent to the following required permissions.
Connect-MgGraph -TenantId $ownerTenantId -Scopes "MultiTenantOrganization.ReadWrite.All", "Policy.Read.All", "Policy.ReadWrite.CrossTenantAccess", "Application.ReadWrite.All", "Directory.ReadWrite.All"
```

- MultiTenantOrganization.ReadWrite.All
- Policy.Read.All
- Policy.ReadWrite.CrossTenantAccess
- Application.ReadWrite.All
- Directory.ReadWrite.All
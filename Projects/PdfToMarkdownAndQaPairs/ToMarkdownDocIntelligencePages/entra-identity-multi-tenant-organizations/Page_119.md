<!-- PageHeader="PowerShell" -->

$SourceTenantId = "<SourceTenantId>" $TargetTenantId = "<TargetTenantId>"

3\. Use the Connect-MgGraph command to sign in to the source tenant and consent to the following required permissions.

· Policy. Read.All

· Policy. ReadWrite. CrossTenantAccess

· Application. ReadWrite.All

· Directory. ReadWrite.All

· AuditLog. Read.All

PowerShell

Connect-MgGraph -TenantId $SourceTenantId -Scopes "Policy . Read. All", "Policy . ReadWrite. CrossTenantAccess", "Application . ReadWrite. All", "Directory . ReadWrite. All", "AuditLog. Read. All"


# Step 5: Automatically redeem invitations in the source tenant

<figure>

![](figures/0)

</figure>


Source tenant

PowerShell

1\. In the source tenant, use the New-MgPolicyCross TenantAccessPolicyPartner command to create a new partner configuration in a cross-tenant access policy between the source tenant and the target tenant. Use the target tenant ID in the request.

If you get the error New-MgPolicyCrossTenantAccessPolicyPartner\_Create: Another object with the same value for property tenantId already exists you might already have an existing configuration. For more information, see Symptom - New-MgPolicyCrossTenantAccessPolicyPartner\_Create error.

PowerShell

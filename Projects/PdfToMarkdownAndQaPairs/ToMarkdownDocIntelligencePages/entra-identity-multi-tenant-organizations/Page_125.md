1\. In the source tenant, use the Invoke-MgGraphRequest command to save your credentials.

<figure>

![](figures/0)

<!-- FigureContent="PowerShell $Params = @{ "value" = @( "key" = "AuthenticationType" "value" = "SyncPolicy" } @{ "key" = "CompanyId" "value" = $TargetTenantId } ) } Invoke-MgGraphRequest -Method PUT -Uri "https://graph.microsoft.com/v1.0/servicePrincipals/$ServicePrincip alId/synchronization/secrets" -Body $Params" -->

</figure>


Step 10: Assign a user to the configuration
===

<figure>

![](figures/1)

</figure>


Source tenant

For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

PowerShell

1\. In the source tenant, use the New-MgServicePrincipalAppRoleAssignedTo command to assign an internal user to the configuration.

PowerShell

$Params = @{ PrincipalId = "<PrincipalId>" ResourceId = $ServicePrincipalId AppRoleId = $AppRoleId }

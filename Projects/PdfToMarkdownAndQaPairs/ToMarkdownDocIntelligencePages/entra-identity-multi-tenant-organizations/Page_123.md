Step 7: Test the connection to the target tenant
===

<figure>

![](figures/0)

</figure>


Source tenant

PowerShell

1\. In the source tenant, use the Invoke-MgGraphRequest command to test the connection to the target tenant and validate the credentials.

<figure>

![](figures/1)

<!-- FigureContent="PowerShell $Params = @{ "useSavedCredentials" = $false "templateId" = "Azure2Azure" "credentials" = @( "key" = "CompanyId" "value" = $TargetTenantId } "key" = "AuthenticationType" "value" = "SyncPolicy" } } Invoke-MgGraphRequest -Method POST -Uri "https://graph.microsoft.com/v1.0/servicePrincipals/$ServicePrincip alId/synchronization/jobs/validateCredentials" -Body $Params" -->

</figure>


Step 8: Create a provisioning job in the source tenant

<figure>

![](figures/2)

</figure>


Source tenant

In the source tenant, to enable provisioning, create a provisioning job.

PowerShell

1\. Determine the synchronization template to use, such as Azure2Azure.

2. Use the Get-MgPolicyCrossTenantAccessPolicyPartner command to list the existing object.

3. If you have an existing object, you might need to make an update using Update-MgPolicyCrossTenantAccessPolicyPartner

Symptom - Request_MultipleObjectsWithSameKeyValue Error
===

When you try to enable user synchronization, you receive an error message similar to the following:

```
[Figure: Error message received when enabling user synchronization]

Invoke-MgGraphRequest: PUT
https://graph.microsoft.com/v1.0/policies/crossTenantAccessPolicy/partners/<SourceTenantId>/identitySynchronization HTTP/1.1 409 Conflict
...
{"error": { "code": "Request_MultipleObjectsWithSameKeyValue", "message": "A conflicting object with one or more of the specified property values is present in the directory.", "details":
[{"code": "ConflictingObjects", "message":"A conflicting object with one or more of the specified property values is present in the directory.",
...

```

Cause

You are likely trying to create a policy that already exists, possibly from a previous configuration.

Solution

1. Verify your syntax and that you are using the correct tenant ID.

2. Use the Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization command to list the IsSyncAllowed setting.

    ```
    [Figure: PowerShell command to list IsSyncAllowed setting]

    PowerShell

    (Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId).UserSyncInbound
    ```

    ```mermaid
    graph TD;
        PowerShell["PowerShell Command: Get-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $SourceTenantId"] --> IsSyncAllowed["IsSyncAllowed Setting"]
    ```

3. If you have an existing policy, you might need to make an update using Set-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization command to enable user synchronization.
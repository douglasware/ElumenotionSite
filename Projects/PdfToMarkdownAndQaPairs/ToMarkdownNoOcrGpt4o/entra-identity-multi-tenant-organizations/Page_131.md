## Symptom - Insufficient privileges error

When you try to perform an action, you receive an error message similar to the following:

```
code: Authorization_RequestDenied
message: Insufficient privileges to complete the operation.
```

### Cause

Either the signed-in user doesn't have sufficient privileges, or you need to consent to one of the required permissions.

### Solution

1. Make sure you're assigned the required roles. See Prerequisites earlier in this article.

2. When you sign in with Connect-MgGraph, make sure you specify the required scopes. See Step 1: Sign in to the target tenant and Step 4: Sign in to the source tenant earlier in this article.

## Symptom - New-MgPolicyCrossTenantAccessPolicyPartner_Create error

When you try to create a new partner configuration, you receive an error message similar to the following:

```
New-MgPolicyCrossTenantAccessPolicyPartner_Create: Another object with the same value for property tenantId already exists.
```

### Cause

You are likely trying to create a configuration or object that already exists, possibly from a previous configuration.

### Solution

1. Verify your syntax and that you are using the correct tenant ID.
## Error Details

```
Error code: AzureDirectoryB2BManagementPolicyCheckFailure
Details: Policy permitting auto-redemption of invitations not configured.
```

## Notifications

### Testing Connection to Fabrikam
- **Error**: You appear to have entered invalid credentials. Please confirm you are using the correct information for an administrative account.
- **Error Code**: AzureDirectoryB2BManagementPolicyCheckFailure
- **Details**: Policy permitting auto-redemption of invitations not configured.
- **Request ID**: 

## Cause

This error indicates the policy to automatically redeem invitations in both the source and target tenants wasn't set up.

## Solution

Follow the steps in:
- **Step 3**: Automatically redeem invitations in the target tenant
- **Step 4**: Automatically redeem invitations in the source tenant.

## Symptom - Automatic Redemption Check Box is Disabled

When configuring cross-tenant synchronization, the Automatic redemption check box is disabled.
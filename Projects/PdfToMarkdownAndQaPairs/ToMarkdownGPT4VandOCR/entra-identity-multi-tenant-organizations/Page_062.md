## Source tenant and Target tenant

| Source tenant                  | Target tenant                 |
|--------------------------------|-------------------------------|
| SoC users' governance          | Guest accounts provisioning   |
| 12                              | Access packages assignment    |
| 3                               |                               |

### PERMISSIONS
Connected organization

1. Establish a connected organization.
2. Define access packages for the necessary roles.
3. Upon requesting the access package, SoC users will be auto-assigned Security Reader access.

- Ensure they are accessible by the connected org.
- SoC users will have eligible access for Security Operator and Security Admin roles.

| Access Package | Security Reader | Access Package 2 | Security Operator | Access Package 3 | Security Admin |

## Steps to configure topology 2

1. In the target tenant, add the source tenant as a connected organization.
   - This setting allows the target tenant administrator to make access packages available to the source tenant.
2. In the target tenant, create an access package that provides the Security Reader, Security Administrator, and Security Operator roles.
3. Users from the source tenant can now request access packages in the target tenant.

Once you have completed the setup, SOC users can navigate to myaccess.microsoft.com to request time-limited access to the necessary roles in each tenant.

## Topologies compared

In both topologies, the target tenant can control what resources users have access to. This can be accomplished using a mix of cross-tenant access policies, conditional access, and assignment of apps and roles to users. They differ in who configures and initiates provisioning. In topology 1, the source tenant configures provisioning and pushes users into the target tenants. In topology 2, the target tenant defines which users are eligible to access their tenant.

If a user needs access to several tenants at one time, topology 1 makes it easy for them to request access to an access package in one tenant and automatically get provisioned into several tenants. If the target tenant wants to ensure full control over who is
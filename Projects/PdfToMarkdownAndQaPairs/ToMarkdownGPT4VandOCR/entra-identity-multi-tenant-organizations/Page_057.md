Multitenant organizations can include internal users in access reviews. This action
enables access recertification in source tenants that synchronizes users. Use this
approach for regular review of security groups assigned to cross-tenant synchronization.
Therefore, ongoing B2B collaboration access to other tenants has approval in the user
home tenant.

Use access reviews of users in source tenants to avoid potential conflicts between cross-
tenant synchronization and access reviews that remove denied users upon completion.

## Review target-tenant user access

Organizations can include B2B collaboration users in access reviews, including users
provisioned by cross-tenant synchronization in target tenants. This option enables
access recertification of resources in target tenants. Although organizations can target
all users in access reviews, guest users can be explicitly targeted if necessary.

For organizations that synchronize B2B collaboration users, typically Microsoft doesn’t
recommend removing denied guest users automatically from access reviews. Cross-
tenant synchronization reprovisions the users if they're in the synchronization scope.

## Next steps

- Multitenant organizations and Microsoft 365
- Multitenant organization templates
- Topologies for cross-tenant synchronization
## Common scoping filters

| Target Attribute   | Operator        | Value                             | Description                                                                 |
|--------------------|-----------------|-----------------------------------|-----------------------------------------------------------------------------|
| userPrincipalName  | REGEX MATCH     | .\*@domain.com                    | All users with `userPrincipal` that have the domain `@domain.com` are in scope for provisioning.                 |
| userPrincipalName  | NOT REGEX MATCH | .\*@domain.com                    | All users with `userPrincipal` that has the domain `@domain.com` are out of scope for provisioning.              |
| department         | EQUALS          | sales                             | All users from the sales department are in scope for provisioning                                                |
| workerID           | REGEX MATCH     | (1[0-9][0-9][0-9][0-9] [0-9][0-9])| All employees with `workerID` between 1000000 and 2000000 are in scope for provisioning.                         |

## Related articles

- [Automate user provisioning and deprovisioning to SaaS applications](#)
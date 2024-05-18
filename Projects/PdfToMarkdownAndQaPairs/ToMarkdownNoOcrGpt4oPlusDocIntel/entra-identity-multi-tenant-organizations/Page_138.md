9. Optionally, repeat steps 7-8 to add more scoping clauses.

10. In Scoping Filter Title, add a name for your scoping filter.

11. Select OK.

12. Select OK again on the Scoping Filters screen. Optionally, repeat steps 6-11 to add another scoping filter.

13. Select Save on the Attribute Mapping screen.

# Important

Saving a new scoping filter triggers a new full sync for the application, where all users in the source system are evaluated again against the new scoping filter. If a user in the application was previously in scope for provisioning, but falls out of scope, their account is disabled or deprovisioned in the application. To override this default behavior, refer to Skip deletion for user accounts that go out of scope.

# Common scoping filters

( Expand table

| Target Attribute   | Operator        | Value                           | Description                                                                                      |
| ------------------ | --------------- | ------------------------------- | ------------------------------------------------------------------------------------------------ |
| userPrincipalName  | REGEX MATCH     | .*\@domain.com                  | All users with userPrincipal that have the domain @domain.com are in scope for provisioning.     |
| userPrincipalName  | NOT REGEX MATCH | .*\@domain.com                  | All users with userPrincipal that has the domain @domain.com are out of scope for provisioning.   |
| department         | EQUALS          | sales                           | All users from the sales department are in scope for provisioning                                |
| workerID           | REGEX MATCH     | (1[0-9][0-9][0-9][0-9][0-9][0-9])| All employees with workerID between 1000000 and 2000000 are in scope for provisioning.            |

# Related articles

- Automate user provisioning and deprovisioning to SaaS applications
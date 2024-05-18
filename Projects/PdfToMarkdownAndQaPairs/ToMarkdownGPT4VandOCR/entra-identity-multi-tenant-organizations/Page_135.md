## Scoping filter construction

A scoping filter consists of one or more **clauses**. Clauses determine which users are allowed to pass through the scoping filter by evaluating each user's attributes. For example, you might have one clause that requires that a user's "State" attribute equals "New York", so only New York users are provisioned into the application.

A single clause defines a single condition for a single attribute value. If multiple clauses are created in a single scoping filter, they're evaluated together using "AND" logic. The "AND" logic means all clauses must evaluate to "true" in order for a user to be provisioned.

Finally, multiple scoping filters can be created for a single application. If multiple scoping filters are present, they're evaluated together by using "OR" logic. The "OR" logic means that if all the clauses in any of the configured scoping filters evaluate to "true", the user is provisioned.

Each user or group processed by the Microsoft Entra provisioning service is always evaluated individually against each scoping filter.

As an example, consider the following scoping filter:

```mermaid
graph LR
  A[Scoping Filter Group: New York Engineering] -->|AND| B[(city EQUALS New York)]
  A -->|AND| C[(department EQUALS Engineering)]
  A -->|AND| D[(employeeID (extension...) REGEX MATCH (1[0-9]{5})...)]
  A -->|AND| E[(jobTitle IS NOT NULL)]
```

According to this scoping filter, users must satisfy the following criteria to be provisioned:
- They must be in New York.
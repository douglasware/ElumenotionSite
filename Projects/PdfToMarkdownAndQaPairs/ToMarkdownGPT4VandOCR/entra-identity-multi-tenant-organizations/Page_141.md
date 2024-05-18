## Allowing deletions

The **Allow deletes** action deletes the objects that triggered the accidental delete threshold. Use the procedure to accept the deletions.

1. Select **Allow deletes**.
2. Click **Yes** on the confirmation to allow the deletions.
3. View the confirmation that the deletions were accepted. The status returns to healthy with the next cycle.

## Rejecting deletions

Investigate and reject deletions as necessary:

- Investigate the source of the deletions. You can use the provisioning logs for details.
- Prevent the deletion by assigning the user / group to the application (or configuration) again, restoring the user / group, or updating your provisioning configuration.
- Once you've made the necessary changes to prevent the user / group from being deleted, restart provisioning. Don't restart provisioning until you've made the necessary changes to prevent the users / groups from being deleted.

## Test deletion prevention

You can test the feature by triggering disable / deletion events by setting the threshold to a low number, for example 3, and then changing scoping filters, unassigning users, and deleting users from the directory (see common scenarios in next section).

Let the provisioning job run (20 – 40 mins) and navigate back to the provisioning page. Check the provisioning job in quarantine and choose to allow the deletions or review the provisioning logs to understand why the deletions occurred.

## Common deprovisioning scenarios to test

- Delete a user / put them into the recycle bin.
- Block sign in for a user.
- Unassign a user or group from the application (or configuration).
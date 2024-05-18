## Step 5: Perform action

Finally, the provisioning service takes an action, such as creating, updating, deleting, or skipping the user.

Here's an example of what you might see after the successful on-demand provisioning of a user:

- Screenshot description: Provision on demand window in a browser showing a group's details after an action has been taken. Includes elements like operation status, user list and their respective statuses among other details.

## View details

The View details section displays the attributes that were modified in the target system. This display represents the final output of the provisioning service activity and the attributes that were exported. If this step fails, the attributes displayed represent the attributes that the provisioning service attempted to modify.

## Troubleshooting tips

- Failures for exporting changes can vary greatly. Check the documentation for provisioning logs for common failures.
- On-demand provisioning says the group or user can't be provisioned because they're not assigned to the application. There's a replication delay of up to a few minutes.
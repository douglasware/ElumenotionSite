· Remove a user from a group that's provides them access to the application (or configuration).

To learn more about deprovisioning scenarios, see How Application Provisioning Works.


# Frequently Asked Questions


## What scenarios count toward the deletion threshold?

When a user is set for removal from the target application (or target tenant), it's counted against the deletion threshold. Scenarios that could lead to a user being removed from the target application (or target tenant) could include: unassigning the user from the application (or configuration) and soft / hard deleting a user in the directory. Groups evaluated for deletion count towards the deletion threshold. In addition to deletions, the same functionality also works for disables.


## What is the interval that the deletion threshold is evaluated on?

It's evaluated each cycle. If the number of deletions doesn't exceed the threshold during a single cycle, the "circuit breaker" isn't triggered. If multiple cycles are needed to reach a steady state, the deletion threshold is evaluated per cycle.


# How are these deletion events logged?

You can find users that should be disabled / deleted but haven’t due to the deletion threshold. Navigation to Provisioning logs and then filter Action with StagedAction or StagedDelete.


# Next steps

· How application provisioning works

· Plan an application provisioning deployment


# Feedback

Was this page helpful?

3 Yes

No
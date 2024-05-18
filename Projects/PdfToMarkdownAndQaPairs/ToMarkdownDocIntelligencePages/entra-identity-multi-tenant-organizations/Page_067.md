# Manager isn't provisioned

If a user and their manager are both in scope for provisioning, the service provisions the user and then updates the manager. If on day one the user is in scope and the manager is out of scope, we'll provision the user without the manager reference. When the manager comes into scope, the manager reference won't be updated until you restart provisioning and cause the service to reevaluate all the users again.


# The provisioning interval is fixed

The time between provisioning cycles is currently not configurable.


# Changes not moving from target app to Microsoft Entra ID

The app provisioning service isn't aware of changes made in external apps. So, no action is taken to roll back. The app provisioning service relies on changes made in Microsoft Entra ID.


# Switching from Sync All to Sync Assigned not working

After you change scope from Sync All to Sync Assigned, make sure to also perform a restart to ensure that the change takes effect. You can do the restart from the Ul.


## Provisioning cycle continues until completion

When you set provisioning to enabled = off or select Stop, the current provisioning cycle continues running until completion. The service stops executing any future cycles until you turn provisioning on again.


# Member of group not provisioned

When a group is in scope and a member is out of scope, the group will be provisioned. The out-of-scope user won't be provisioned. If the member comes back into scope, the service won't immediately detect the change. Restarting provisioning addresses the issue. Periodically restart the service to ensure that all users are properly provisioned.


# Global Reader

The Global Reader role is unable to read the provisioning configuration. Create a custom role with the microsoft.directory/applications/synchronization/standard/read

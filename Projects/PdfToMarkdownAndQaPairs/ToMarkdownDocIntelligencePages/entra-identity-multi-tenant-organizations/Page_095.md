<figure>

![](figures/0)

<!-- FigureContent="... > Outbound access settings - Contoso > Cross-tenant synchronization | Configurations > Fabrikam to Contoso Fabrikam to Contoso | Provisioning Fabrikam - Microsoft Entra ID .. :selected: « :unselected: Save :selected: Discard Overview v Admin Credentials Provision on demand Manage V Mappings Users and groups Provisioning 1 Settings Expression builder Activity :unselected: Send an email notification when a failure occurs Audit logs :selected: Prevent accidental deletion 0 :unselected: Accidental deletion threshold \* Provisioning logs 500 Insights Scope Sync only assigned users and groups V Troubleshooting + Support New support request Provisioning Status 0 On Off +" -->

</figure>


2\. In the Scope list, select whether to synchronize all users in the source tenant or only users assigned to the configuration.

It's recommended that you select Sync only assigned users and groups instead of Sync all users and groups. Reducing the number of users in scope improves performance.

3\. If you made any changes, select Save.

4\. On the configuration page, select Users and groups.

For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

5\. Select Add user/group.

6\. On the Add Assignment page, under Users and groups, select None Selected.

7\. On the Users and groups pane, search for and select one or more internal users or groups you want to assign to the configuration.

If you select a group to assign to the configuration, only users that are direct members in the group will be in scope for provisioning. You can select a static group or a dynamic group. The assignment doesn't cascade to nested groups.

8\. Select Select.

## Fabrikam to Contoso | Provisioning

2. In the **Scope** list, select whether to synchronize all users in the source tenant or only users assigned to the configuration.

    It's recommended that you select **Sync only assigned users and groups** instead of **Sync all users and groups**. Reducing the number of users in scope improves performance.

3. If you made any changes, select **Save**.

4. On the configuration page, select **Users and groups**.

    For cross-tenant synchronization to work, at least one internal user must be assigned to the configuration.

5. Select **Add user/group**.

6. On the **Add Assignment** page, under **Users and groups**, select **None Selected**.

7. On the **Users and groups** pane, search for and select one or more internal users or groups you want to assign to the configuration.

    If you select a group to assign to the configuration, only users that are direct members in the group will be in scope for provisioning. You can select a static group or a dynamic group. The assignment doesn't cascade to nested groups.

8. Select **Select**.
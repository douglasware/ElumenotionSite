## Step 4: Automatically redeem invitations in the source tenant

### Source tenant

In this step, you automatically redeem invitations in the source tenant.

1. Sign in to the Microsoft Entra admin center of the source tenant.
2. Browse to Identity > External Identities > Cross-tenant access settings.
3. On the Organization settings tab, select Add organization.
4. Add the target tenant by typing the tenant ID or domain name and selecting Add.

### Screenshot Description

The image illustrates the user interface of the Microsoft Entra admin center where you can manage External Identities and Cross-tenant access settings. Specifically, it shows the Add organization window where a user can type the tenant ID or domain name to add an external Microsoft Entra tenant.

5. Under Outbound access for the target organization, select Inherited from default.
6. Select the Trust settings tab.
7. Check the Automatically redeem invitations with the tenant <tenant> checkbox.
:selected:
X

<!-- PageHeader="... > External Identities | Cross-tenant access settings >" -->

Inbound access settings - Fabrikam ..
===

<figure>

![](figures/0)

<!-- FigureContent="B2B collaboration B2B direct connect Trust settings Cross-tenant sync Enabling this will allow the admin of th Enable cross-tenant sync and auto-redemption? tenant. Disabling this will block admins of the objects. We recommend that this settir Setting up cross-tenant synchronization also requires auto-redemption to be enabled. Selecting yes will enable auto-redemption in addition to cross-tenant synchronization. but will not remove currently synced e same organization. :selected: Allow users sync into this tenant Yes No Save Discard" -->

</figure>



## Step 3: Automatically redeem invitations in the target tenant

<figure>

![](figures/1)

</figure>



### Target tenant

In this step, you automatically redeem invitations so users from the source tenant don't have to accept the consent prompt. This setting must be checked in both the source tenant (outbound) and target tenant (inbound). For more information, see Automatic redemption setting.

1\. In the target tenant, on the same Inbound access settings page, select the Trust settings tab.

2\. Check the Automatically redeem invitations with the tenant <tenant> check box.

This box might already be checked if you previously selected Yes in the Enable cross-tenant sync and auto-redemption dialog box.

<figure>

![](figures/2)

<!-- FigureContent="Automatic redemption :selected: Check this setting if you want to automatically redeem invitations. If so, users from the specified tenant won't have to accept the consent prompt the first time they access this tenant using cross-tenant synchronization, B2B collaboration, or B2B direct connect. This setting will only suppress the consent prompt if the specified tenant checks this setting for outbound access as well. Learn more :selected: :selected: Automatically redeem invitations with the tenant Fabrikam. + Save Discard" -->

</figure>


<!-- PageFooter="3\. Select Save." -->
:unselected: :unselected: :unselected:
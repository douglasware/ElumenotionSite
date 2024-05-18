✅
X


Inbound access settings - Fabrikam ..
===

<figure>
Screenshot of the Inbound access settings page in Fabrikam tenant's External Identities. The "Cross-tenant sync" tab is selected, showing an "Enable cross-tenant sync and auto-redemption?" dialog box. The dialog box mentions that setting up cross-tenant synchronization also requires auto-redemption to be enabled. The options "Yes" and "No" are available at the bottom.

[![](figures/0)](#)
</figure>


## Step 3: Automatically redeem invitations in the target tenant

<figure>
Icon representing a target tenant with an inbound arrow.

[![](figures/1)](#)
</figure>


### Target tenant

In this step, you automatically redeem invitations so users from the source tenant don't have to accept the consent prompt. This setting must be checked in both the source tenant (outbound) and target tenant (inbound). For more information, see Automatic redemption setting.

1. In the target tenant, on the same Inbound access settings page, select the Trust settings tab.

2. Check the Automatically redeem invitations with the tenant <tenant> check box.

This box might already be checked if you previously selected Yes in the Enable cross-tenant sync and auto-redemption dialog box.

<figure>
Screenshot of the "Automatic redemption" section in the Inbound access settings. There's a checkbox for "Automatically redeem invitations with the tenant Fabrikam." The option to save or discard is shown at the bottom.

[![](figures/2)](#)
</figure>

3. Select Save.
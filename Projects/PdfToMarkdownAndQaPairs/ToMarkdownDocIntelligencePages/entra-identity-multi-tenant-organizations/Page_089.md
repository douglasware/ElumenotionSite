X

Home > Inbound access settings - Contoso > External Identities

<figure>

![](figures/0)

<!-- FigureContent="External Identities | Cross-tenant access settings Contoso - Microsoft Entra ID for workforce
Add organization Cross tenant settings ... Add an external Microsoft Entra tenant by typing one of its domain names or tenant ID if from another Microsoft cloud. P Search « Got feedback? Overview Q Tenant ID or domain name Cross-tenant access settings Organizational settings Default settings Microsoft cloud settir All identity providers External collaboration settings + Add organization :unselected: Refresh Columns × Diagnose and solve problems Use cross-tenant access settings to manage collaboration with external Mici tenants, use collaboration settings. Edit or view collaboration restrictions Self-service sign up Organizational settings are cross-tenant access settings you've configured f Custom user attributes Entra tenants not listed here will use the default settings. Learn more :selected: All API connectors :selected: Custom authentication extensions (Preview) Search by domain name or tenant ID User flows 0 organizations found + Subscriptions Linked subscriptions Name Inbound access Add Discard" -->

</figure>



# 5\. Under Inbound access of the added organization, select Inherited from default.

6\. Select the Cross-tenant sync tab.

7\. Check the Allow users sync into this tenant check box.

<figure>

![](figures/1)

<!-- FigureContent="... > External Identities | Cross-tenant access settings > Inbound access settings - Fabrikam :selected: X B2B collaboration B2B direct connect Trust settings Cross-tenant sync Enabling this will allow the admin of the specified (source) tenant to sync objects into this (target) tenant. Disabling this will block admins of the source tenant from syncing objects into the target tenant but will not remove currently synced objects. We recommend that this setting should only be used between tenants that are part of the same organization. :selected: Allow users sync into this tenant + Save Discard" -->

</figure>


8\. Select Save.

9\. If you see an Enable cross-tenant sync and auto-redemption dialog box asking if you want to enable auto-redemption, select Yes.

Selecting Yes will automatically redeem invitations in the target tenant.
:selected: :selected: :selected:
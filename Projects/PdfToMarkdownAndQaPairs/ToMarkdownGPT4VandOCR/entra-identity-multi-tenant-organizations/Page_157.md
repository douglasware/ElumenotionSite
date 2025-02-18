## Microsoft Entra admin center configuration

1. Enter the following URL to enable the schema editor:  
`https://entra.microsoft.com/?Microsoft_AAD_Connect_Provisioning_forceSchemaEditorEnabled=true`

2. Browse to **Identity** > **External Identities** > **Cross-tenant synchronization**.

3. Select **Configurations** and then select your configuration.

4. Select **Provisioning** and expand the **Mappings** section.

5. Select **Provision Microsoft Entra ID Users** to open the **Attribute Mapping** page.

6. Scroll to the bottom and select the **Show advanced settings** check box.

### Attribute Mapping

| Attribute               | Mapping           | Actions |
|-------------------------|-------------------|---------|
| userPrincipalName       | userPrincipalName | Delete  |
| true                    | showInAddressList | Delete  |
| mail                    | mail              | Delete  |
| Member                  | userType          | Delete  |

- [Show advanced options]

### Supported Attributes

- View and edit the list of attributes that appear in the source and target attribute lists for this application.
- Edit attribute list for **Microsoft Entra ID**
- Edit attribute list for **Azure Active Directory (target tenant)**
- Use the expression builder

### Review your schema

- In addition to configuring your attribute mappings through the user interface, you can review, download, and edit the JSON representation of your schema. [Review your schema here](#).

### Tip

If you don't see the **Edit attribute list** links, be sure that you are signed in to the Microsoft Entra admin center using the link in Step 1.

7. If you created a directory extension in the source tenant, select the **Edit attribute list for Microsoft Entra ID** link.

8. If you created an extension in the target tenant, select the **Edit attribute list for Azure Active Directory (target tenant)** link.

9. Add the directory extension and select the appropriate options.
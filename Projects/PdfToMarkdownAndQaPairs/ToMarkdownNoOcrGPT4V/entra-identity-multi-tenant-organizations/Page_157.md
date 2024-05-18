## Configuring Microsoft Entra Identity Synchronization

1. Visit the Microsoft Entra admin page:
   ```
   https://entra.microsoft.com/?Microsoft_AAD_Connect_Provisioning_forceSchemaEditorEnabled=true
   ```

2. Navigate through the following path:
   - **Identity > External Identities > Cross-tenant synchronization**

3. Choose **Configurations** and then select your configuration.

4. Go to **Provisioning** and click on the **Mappings** section to expand it.

5. Click on **Provision Microsoft Entra ID Users** to open the **Attribute Mapping** page.

6. At the bottom of the page, select the **Show advanced settings** checkbox.

### Attribute Mapping

```
| Source Attribute  | Target Attribute  | Action   |
|-------------------|-------------------|----------|
| userPrincipalName | userPrincipalName | Delete   |
| true              | showinAddresslist | Delete   |
| mail              | mail              | Delete   |
| Member            | userType          | Delete   |
```

### Additional Information

- **Supported Attributes**: Edit and view the list of attributes for Microsoft Entra ID and for Azure Active Directory (target tenant) using the expression builder.
- You can review, download, and edit the JSON representation of your schema here.

#### Tip
> Ensure you're signed into Microsoft Entra admin center to access the **Edit attribute list** links.

7. If a directory extension was created in the source tenant, select the **Edit attribute list for Microsoft Entra ID** link.

8. If an extension was established in the target tenant, access the **Edit attribute list for Azure Active Directory (target tenant)** link.

9. Proceed to add the directory extension and select the required options.
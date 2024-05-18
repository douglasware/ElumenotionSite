## Edit Attribute List

### Steps:
1. **Save**: Click the save button to keep your changes.
2. **Discard**: Click the discard button to ignore any changes made.

### Tips:
- Editing the attribute list informs the provisioning service what attributes exist in your system(s).
- Leave "Metadata" blank for new attributes unless instructed by documentation. Requires a JSON-encoded object.
- Leave "Reference Object Attribute" blank unless the "Type" is set to "Reference". Enter referenced attribute in the form of `objectName.attributeName` or just `objectName`.
- See the online documentation on attribute editing.

### Procedure:
10. Select **Save**.
11. Refresh the browser.
12. Navigate to the **Attribute mappings** page and attempt to map the directory extension as described earlier in this article.

## Manually add directory extensions by editing the schema

### Source tenant

Follow these steps to manually add directory extensions to the schema via the schema editor.

1. Sign in to the [Microsoft Entra admin center](#) of the source tenant.
2. Navigate to **Identity > External Identities > Cross-tenant synchronization**.
3. Select **Configurations** and then choose your configuration.
4. Click on **Provisioning** and expand the **Mappings** section.
5. Select **Provision Microsoft Entra ID Users** to open the **Attribute Mapping** page.
## Step-by-Step Configuration Guide

### 6. Enable Advanced Settings
Scroll to the bottom of the screen and select the **Show advanced settings** checkbox under the Attribute Mapping section. This will enable you to access and configure more complex settings.

#### Attribute Mapping Table:
| Attribute | Mapped Attribute | Options |
|-----------|------------------|---------|
| userPrincipalName | userPrincipalName | Delete |
| showInAddressList | true | Delete |
| mail | mail | Delete |
| userType | Member | Delete |

### 7. Schema Review and Editing
Select the **Review your schema here** link to open the Schema editor page for advanced configuration. This page allows you to adjust and define the synchronization rules and object mappings through a JSON formatted schema.

#### JSON Schema Example:
```json
{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#servicePrincipals",
  "id": "Azure2...",
  "version": "v1.2",
  "synchronizationRules": [
    {
      "containerFilter": null,
      "editable": true,
      "id": "f0f8ff81-9e60-4ed3-b8df-09bbb40d2b7e",
      "name": "USER_INBOUND_USER",
      "priority": 1,
      "sourceDirectoryName": "Microsoft Entra ID",
    }
  ]
}
```

### 8. Schema Backup
Download an original copy of the schema as a backup to ensure you have a recoverable point in case changes need to be rolled back.

### 9. Modify the Schema
Modify the schema following the specific configurations required for your setup. This step involves changing values or adding new attributes and rules within the JSON structure provided.

### 10. Save Your Changes
After finalizing changes in the schema editor, select **Save** to apply all changes made to the attribute mappings and synchronization rules.

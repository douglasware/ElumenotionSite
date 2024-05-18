## 6. Scroll to the bottom and select the Show advanced settings check box.

### Attribute Mapping

| | Source Attribute | Target Attribute | |
| --- | --- | --- | --- |
| | `userPrincipalName` | `userPrincipalName` | Delete |
| | `true` | `showInAddressList` | Delete |
| | `mail` | `mail` | Delete |
| | `Member` | `userType` | Delete |

- [Add New Mapping](#)
- [Show advanced options](#)

#### Supported Attributes

- View and edit the list of attributes that appear in the source and target attribute lists for this application.
  - [Edit attribute list for Microsoft Entra ID](#)
  - [Edit attribute list for Azure Active Directory (target tenant)](#)
- [Use the expression builder](#)

> In addition to configuring your attribute mappings through the user interface, you can review, download, and edit the JSON representation of your schema. [Review your schema here](#).

## 7. Select the Review your schema here link to open the Schema editor page.

### Schema editor

- [Save](#)  [Discard](#)  [Download](#)  [Got feedback?](#)

> The schema below is a JSON representation of your provisioning configuration. You can use it to define what objects you want to provision, map objects between your source and target system, and specify who should be provisioned. We recommend making these changes directly through our configuration experience. The schema below is only used for saving your configuration and making changes in it.

> We recommend downloading and saving the current configuration prior to making changes. A backup copy can be used to roll back to a known good state.

```json
{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#servicePrincipals",
  "id": "Azure2Azure.1f58d1c91f90427abd849f967e96fb42.6a0b230b-3a8d-455d-98db-6e9e679fb64f",
  "version": "v1.2",
  "synchronizationRules": [
    {
      "containerFilter": null,
      "editable": true,
      "groupFilter": null,
      "id": "df8df8d1-9e6e-40d3-b8df-09bbb402db7e",
      "name": "USER_INBOUND_USER",
      "priority": 1,
      "sourceDirectoryName": "Microsoft Entra ID",
      ...
    },
    ...
  ]
}
```

## 8. Download an original copy of the schema as a backup.

## 9. Modify the schema following your required configuration.

## 10. Select Save.
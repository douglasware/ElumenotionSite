## Known issues for provisioning in Microsoft Entra ID

This article discusses known issues to be aware of when you work with app provisioning or cross-tenant synchronization. To provide feedback about the application provisioning service on UserVoice, see [Microsoft Entra application provision UserVoice](https://feedback.microsoft.com/forums/12345678-microsoft-entra-application-provision). We watch UserVoice closely so that we can improve the service.

> **Note**
> 
> This article isn't a comprehensive list of known issues. If you know of an issue that isn't listed, provide feedback at the bottom of the page.

### Authorization

#### Unable to change provisioning mode back to manual

After you've configured provisioning for the first time, you'll notice that the provisioning mode has switched from manual to automatic. You can't change it back to manual. But you can turn off provisioning through the UI. Turning off provisioning in the UI effectively does the same as setting the dropdown to manual.

### Attribute mappings

#### Attribute SamAccountName or userType not available as a source attribute

The attributes SamAccountName and userType aren't available as a source attribute by default. Extend your schema to add the attributes. You can add the attributes to the list of available source attributes by extending your schema. To learn more, see [Missing source attribute](https://help.microsoft.com/schema/missing-source-attribute).

#### Source attribute dropdown missing for schema extension

Extensions to your schema can sometimes be missing from the source attribute dropdown in the UI. Go into the advanced settings of your attribute mappings and check if the dropdown is configured properly.
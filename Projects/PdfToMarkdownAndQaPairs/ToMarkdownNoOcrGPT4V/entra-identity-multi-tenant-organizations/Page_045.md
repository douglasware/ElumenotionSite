## Microsoft apps

### SharePoint OneDrive
- Promotion of B2B guests to B2B members might not happen automatically. If there's a user type mismatch between Microsoft Entra ID and SharePoint OneDrive, try `Set-SPUser -SyncFromAD`.

- In user interfaces, sharing a file with **People in Fabrikam**, the current interfaces might be counterintuitive, because B2B members in Fabrikam from Contoso count towards **People in Fabrikam**.

### Microsoft Forms
- B2B member users might not be able to access forms.

### Microsoft Power BI
- B2B member users are not yet supported. B2B guest users can continue to access Power BI dashboards.

### Microsoft Power Apps, Microsoft Dynamics 365, and related workloads
- B2B member users may have restricted functionality. For more information, see Invite users with Microsoft Entra B2B collaboration.

## B2B users or B2B members

- The promotion of B2B guests to B2B members represents a strategic decision by multitenant organizations to consider B2B members as trusted users of the organization. Review the [default permissions](#) for B2B members.

- To promote B2B guests to B2B members, a source tenant administrator can amend the [attribute mappings](#), or a target tenant administrator can [change the userType](#) if the property is not recurringly synchronized.

- As organizations roll out the multitenant organization functionality including provisioning of B2B users across multitenant organization tenants, you might want to provision some users as B2B guests, while provision others as B2B members. To achieve this, you might want to establish two Microsoft Entra cross-tenant synchronization configurations in the source tenant, one with userType attribute mappings configured to B2B guest, and another with userType attribute mappings configured to B2B member, each with [Apply this mapping set to](#).
## Limitations in multitenant organizations

*Article • 04/24/2024*

This article describes limitations to be aware of when you work with multitenant organization functionality across Microsoft Entra ID and Microsoft 365. To provide feedback about the multitenant organization functionality on UserVoice, see [Microsoft Entra UserVoice](https://link.com). We watch UserVoice closely so that we can improve the service.

## Scope

The limitations described in this article have the following scope.

| Scope                  | Description                                                                                                                                                                    |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| In scope               | - Microsoft Entra administrator limitations related to multitenant organizations to support seamless collaboration experiences in new Teams, with reciprocally provisioned B2B members|
| Related scope          | - Microsoft 365 admin center limitations related to multitenant organizations  - Microsoft 365 multitenant organization people search experiences - Cross-tenant synchronization limitations related to Microsoft 365|
| Out of scope           | - Cross-tenant synchronization unrelated to Microsoft 365 - End user experiences in new Teams - End user experiences in Power BI - Tenant migration or consolidation|
| Unsupported scenarios  | - Seamless collaboration experience across multitenant organizations in classic Teams - Self-service for multitenant organizations larger than 100 tenants - Multitenant organizations in Azure Government or Microsoft Azure operated by 21Vianet - Cross-cloud multitenant organizations|

## Microsoft 365 admin center versus cross-tenant synchronization

- Whether you use the Microsoft 365 admin center share users functionality or Microsoft Entra cross-tenant synchronization, the following items apply:
  - In the identity platform, both methods are represented as Microsoft Entra cross-tenant synchronization jobs.
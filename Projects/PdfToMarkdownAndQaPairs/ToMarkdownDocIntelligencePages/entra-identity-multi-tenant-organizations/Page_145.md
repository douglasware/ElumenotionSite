<figure>

![](figures/0)

<!-- FigureContent="A Provision on demand - Microsof × + X C https://portal.azure.com/?Microsoft\_AAD\_Connect\_Provisioning=tip&feature.provisionondemandsupportmember=true#view/Microsoft\_AAD\_Connect\_Provisioning/UserPr ... A ... Microsoft Azure P Search resources, services, and docs (G+/) Home > scimreftest > AHCustom > Provision on demand ... × Learn More A Got feedback? Provision on-demand for a subset of users or groups before rolling it out broadly to your organization. When provisioning a group you can select 5 members at a time. :selected: No user or group will be provisioned on-demand that would not have been provisioned through the regular provisioning cycles. Selected group P On-demand provisioning Selected members 2 selected v p :selected: Alex Wilber AlexW@scimreftest.onmicrosoft.com MEMBER :selected: Nestor Wilke NestorW@scimreltest.onmicrosoft.com MEMBER + Provision" -->

</figure>


Understand the provisioning steps
===

The on-demand provisioning process attempts to show the steps that the provisioning service takes when provisioning a user. There are typically five steps to provision a user. One or more of those steps, explained in the following sections, are shown during the on-demand provisioning experience.


## Step 1: Test connection

The provisioning service attempts to authorize access to the target system by making a request for a "test user". The provisioning service expects a response that indicates that the service authorized to continue with the provisioning steps. This step is shown only when it fails. It's not shown during the on-demand provisioning experience when the step is successful.


## Troubleshooting tips

· Ensure that you've provided valid credentials, such as the secret token and tenant URL, to the target system. The required credentials vary by application. For detailed configuration tutorials, see the tutorial list.

. Make sure that the target system supports filtering on the matching attributes defined in the Attribute mappings pane. You might need to check the API documentation provided by the application developer to understand the supported filters.

. For System for Cross-domain Identity Management (SCIM) applications, you can use a tool like Postman. Such tools help you ensure that the application responds
:selected: :selected: :unselected: :unselected: :selected: :unselected: :unselected: :selected: :unselected: :unselected: :unselected: :selected: :unselected:
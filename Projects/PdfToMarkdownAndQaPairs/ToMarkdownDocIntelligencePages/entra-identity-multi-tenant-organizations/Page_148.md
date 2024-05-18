· The provisioning service might not be able to match a user in the source system uniquely with a user in the target. Resolve this problem by ensuring that the matching attribute is unique.

· Make sure that the target system supports filtering on the attribute that's defined as the matching attribute.


# Step 5: Perform action

Finally, the provisioning service takes an action, such as creating, updating, deleting, or skipping the user.

Here's an example of what you might see after the successful on-demand provisioning of a user:
 :unselected:
<figure>

![](figures/0)

<!-- FigureContent="A Perform action - Microsoft Azure X + - × C https://portal.azure.com/?Microsoft\_AAD\_Connect\_Provisioning=tip&feature.provisionondemandsupportmember=true#view/Microsoft\_AAD\_Connect\_Provisioning/ ... A\* To U U ... Microsoft Azure P Search resources, services, and docs (G+/) Home > scimreftest > AHCustom > Perform action X Provision on demand Group details Group membership operations User operations Data flow 1 Learn More 1 Technical details & Got feedback? 2 members are evaluated for addition. View details for more information. Group Members User principal name Group membership operations Membership update status On-demand provisioning OP d35358d6-ad58-400e-b13a-b73bb4455677 Alex Wilber AlexW@scimreftest.onmicrosoft.com Add member :selected: Success | View details Nestor Wilke NestorW@scimreftest.onmicrosoft.com Add member :selected: Success | View details 1. Import group This step shows the group retrieved from the source system and the properties of the group in the source system. :selected: Success | View details 2. Determine if group is in scope This step shows the scoping conditions that were evaluated and which ones the group passed or failed. :selected: Success | View details 3. Match group between source and target system This stop shows whether the group was found in the target system as well as the properties of the group in the target system. :selected: Success | View details 4. Perform action This step shows the action that was performed in the target application, such as creating a group or updating a group. :selected: Success | View details + Retry Provision another object" -->

</figure>



# View details

The View details section displays the attributes that were modified in the target system. This display represents the final output of the provisioning service activity and the attributes that were exported. If this step fails, the attributes displayed represent the attributes that the provisioning service attempted to modify.


# Troubleshooting tips

. Failures for exporting changes can vary greatly. Check the documentation for provisioning logs for common failures.

· On-demand provisioning says the group or user can't be provisioned because they're not assigned to the application. There's a replication delay of up to a few
:selected: :selected: :unselected: :unselected: :unselected: :selected: :selected: :selected:
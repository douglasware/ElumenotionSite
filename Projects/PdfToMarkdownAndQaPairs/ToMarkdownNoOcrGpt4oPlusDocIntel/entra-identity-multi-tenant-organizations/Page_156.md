<!-- PageHeader="Home > Cross-tenant synchronization | Configurations > Fabrikam to Contoso | Provisioning >" -->

# Edit Attribute ..

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g. Users) should flow to and from this application.

Mapping type 0

Direct

V

X

Source attribute \*

V

employeeHireDate

employeeld

employeeLeaveDateTime

employeeOrgData.costCenter

V

employeeOrgData.division

employeeType

V

testExtension (extension\_c44d2adc1ddd43f29f29248e8de53937\_testExtension)

extensionAttribute1

extensionAttribute10

\+

If the directory extension isn't listed, make sure that the directory extension was created successfully. You can also try to manually add the directory extension to the attribute list as described in the next section.

8\. In the Target attribute drop-down list, select a target attribute.

If you created a directory extension in the target tenant, select the directory extension.

9\. Select Ok to save the mapping.

# Manually add directory extensions to the attribute list

![A screenshot of the "Edit Attribute" interface in Microsoft Entra admin center. The screenshot shows a user selecting a source attribute from a dropdown list. Various attributes such as employeeHireDate, employeeld, employeeLeaveDateTime, and others are visible in the list. At the bottom of the dropdown list, there is an Ok button to save the mapping.](figures/0)

## Source tenant

If your directory extension wasn't automatically discovered, you can try the following steps to manually add the directory extension to the attribute list.

1\. Sign in to the Microsoft Entra admin center of the source tenant using the following link:
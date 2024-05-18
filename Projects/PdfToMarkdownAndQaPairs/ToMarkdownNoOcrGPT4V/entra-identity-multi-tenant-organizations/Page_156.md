## Edit Attribute

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g. Users) should flow to and from this application.

**Mapping Type:** *Direct*

**Source Attribute:**

- employeeHireDate
- employeeId
- employeeLeaveDateTime
- employeeOrgData.costCenter
- employeeOrgData.division
- employeeType
- testExtension (extension_c44d2dc1add4fd32f924e8de5c3937_testExtension)
- extensionAttribute1
- extensionAttribute10

If the directory extension isn't listed, make sure that the directory extension was created successfully. You can also try to manually add the directory extension to the attribute list as described in the next section.

8. In the **Target attribute** drop-down list, select a target attribute.
9. If you created a directory extension in the target tenant, select the directory extension.
10. Select **Ok** to save the mapping.

### Manually add directory extensions to the attribute list

**Source tenant**

If your directory extension wasn't automatically discovered, you can try the following steps to manually add the directory extension to the attribute list.

1. Sign in to the Microsoft Entra admin center of the source tenant using the following link:
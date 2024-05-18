## Edit Attribute

A mapping lets you define how the attributes in one class of Microsoft Entra object (e.g. Users) should flow to and from this application.

| Mapping type | Direct |
|--------------|--------|
| **Source attribute** | * | 

- employeeHireDate
- employeeid
- employeeLeaveDateTime
- employeeOrgData.costCenter
- employeeOrgData.division
- employeeType
- testExtension (extension_c4d42adc1dd4f3f29f29428de653397_testExtension)
- extensionAttribute1
- extensionAttribute10

**If the directory extension isn’t listed, make sure that the directory extension was created successfully. You can also try to manually add the directory extension to the attribute list as described in the next section.**

8. In the **Target attribute** drop-down list, select a target attribute.

    If you created a directory extension in the target tenant, select the directory extension.

9. Select **Ok** to save the mapping.

### Manually add directory extensions to the attribute list

#### Source tenant

If your directory extension wasn’t automatically discovered, you can try the following steps to manually add the directory extension to the attribute list.

1. Sign in to the Microsoft Entra admin center of the source tenant using the following link:
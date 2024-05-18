<figure>

![](figures/0)

<!-- FigureContent="\> Fabrikam to Contoso | Provisioning > Attribute Mapping > Edit Attribute List X :selected: H Save :selected: Discard 4 Tips . Editing the attribute list informs the provisioning service what attributes exist in your system(s). Editing this list does not modify the schema of these systems. . Leave "Metadata" blank for new attributes unless instructed by documentation. Requires a JSON-encoded object. . Leave "Reference Object Attribute" blank unless the "Type "is set to "Reference". Enter referenced attribute in the form of objectName.attributeName or just objectName. · See the online documentation on attribute editing. +" -->

</figure>


| alternativeSecuritylds | String || :unselected: | :unselected: | :selected: |
| - | - | - | - | - | - |
| showInAddressList | Boolean || :unselected: | :unselected: | :unselected: |
| mail | String | | :unselected: | :unselected: | :unselected: |
| userState | String | | :unselected: | :unselected: | :unselected: |
| userType | String | | :unselected: | :unselected: | :unselected: |
| extension\_c44d2adc1ddd4 ... | String | V | :unselected: | :selected: | :unselected: |
| | String | 1 | :unselected: | :unselected: | :unselected: |

10\. Select Save.

11\. Refresh the browser.

12\. Browse to the Attribute mappings page and try to map the directory extension as described earlier in this article.


# Manually add directory extensions by editing the schema


## Source tenant

Follow these steps to manually add directory extensions to the schema by using the schema editor.

1\. Sign in to the Microsoft Entra admin center 4 of the source tenant.

2\. Browse to Identity > External Identities > Cross-tenant synchronization.

3\. Select Configurations and then select your configuration.

4\. Select Provisioning and expand the Mappings section.

5\. Select Provision Microsoft Entra ID Users to open the Attribute Mapping page.
:unselected:
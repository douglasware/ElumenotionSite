<!-- PageNumber="X" -->


# Perform action

Modified attributes (successful) Data flow

User 'user1@fabrikam.com' was created in Azure Active Directory (target tenant)

Ma

Act

\-

Tro

| Target attribute name | Source attribute value | Expression | Original target attribute v ... | Modified target attribute value |
| - | - | - | - | - |
| IsSoftDeleted | False | [IsSoftDeleted] | | False |
| accountEnabled | True | [accountEnabled] | | True |
| displayName | User1 | [displayName] | | User1 |
| mailNickname | user1 | [mailNickname] | | user1 |
| alternativeSecuritylds | AltSecldFromNetid("1003 ... | AltSecldFromNetid([netid]) | | (1 values) |
| showInAddressList | "true" | "true" | | true |
| userType | "Member" | "Member" | | Member |
| preferredLanguage | undefined | [preferredLanguage] | | en-US |

\+


# If the user isn't in scope, you'll see a page with information about why test user was skipped.

<figure>

![](figures/0)

<!-- FigureContent="Hom Determine if user is in scope X a The User 'alice@fabrikam.com' will be skipped due to the following reasons: 1) This object is not assigned to the application. If you did not expect the object to be skipped, assign the object to the application or change your scoping filter to allow all users and groups to be in scope for provisioning. 2) This object does not have required entitlement for provisioning. If you did not expect the object to be skipped, update provisioning scope to 'Sync all users and groups' or assign the object to the application with entitlement of provisioning category Us A 1. Im This prop" -->

</figure>

 :selected:
| Attribute name | Attribute value |
| - | - |
| SkipReason | NotEffectivelyEntitled |
| IsActive | True |
| Assigned to the application | False |
| IsInProvisioningScope | True |
| | + |

On the Provision on demand page, you can view details about the provision and have the option to retry.
:selected: :selected: :unselected: :selected:
## B2B Direct Connect

- B2B direct connect is the underlying identity technology required for Teams Connect shared channels.
- We recommend B2B collaboration for all other cross-tenant application access scenarios, including both Microsoft and non-Microsoft applications.
- B2B direct connect and cross-tenant synchronization are designed to co-exist, and you can enable them both for broad coverage of cross-tenant scenarios.

We're trying to determine the extent to which we'll need to utilize cross-tenant synchronization in our multitenant organization. Do you plan to extend support for B2B direct connect beyond Teams Connect?

- There's no plan to extend support for B2B direct connect beyond Teams Connect shared channels.

## Microsoft 365

### Does cross-tenant synchronization enhance any cross-tenant Microsoft 365 app access user experiences?

- Cross-tenant synchronization utilizes a feature that improves the user experience by suppressing the first-time B2B consent prompt and redemption process in each tenant.
- Synchronized users will have the same cross-tenant Microsoft 365 experiences available to any other B2B collaboration user.

### Can cross-tenant synchronization enable people search scenarios where synchronized users appear in the global address list of the target tenant?

- Yes, but you must set the value for the showInAddressList attribute of synchronized users to True, which is not set by default. If you want to create a unified address list, you'll need to set up a mesh peer-to-peer topology. For more information, see Step 9: Review attribute mappings.
- Cross-tenant synchronization creates B2B collaboration users and doesn't create contacts.

## Teams

### Does cross-tenant synchronization enhance any current Teams experiences?

- Synchronized users will have the same cross-tenant Microsoft 365 experiences available to any other B2B collaboration user.
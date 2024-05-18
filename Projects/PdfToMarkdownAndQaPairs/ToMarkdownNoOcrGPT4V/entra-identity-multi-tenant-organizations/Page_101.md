## Step 7: Set the Mapping Type

Set the Mapping type to **Expression**.

## Step 8: Define the Transformation Expression

In the Expression box, enter the transformation expression. For example, with the display name, you can:

- Flip the first name and last name and add a comma in between.
- Add the domain name in parentheses at the end of the display name.

For examples, refer to Reference for writing expressions for attribute mappings in Microsoft Entra ID.

### Edit Attribute Interface

- **Mapping type:** Expression
- **Expression:** [displayName]
- *The expression was correctly parsed.*
- **Target attribute:** displayName

![Expression Interface](#)  <!-- Image described as interface window for Edit Attribute -->

> **Tip**
>
> You can map directory extensions by updating the schema of the cross-tenant synchronization. For more information, see [Map directory extensions in cross-tenant synchronization](#).

## Step 10: Specify Additional Provisioning Settings

**Source tenant**
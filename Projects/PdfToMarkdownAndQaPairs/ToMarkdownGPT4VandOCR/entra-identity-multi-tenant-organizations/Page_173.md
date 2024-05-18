## Parameters:

| Name        | Required/ Repeating | Type       | Notes                            |
|-------------|---------------------|------------|----------------------------------|
| Expression  | Required            | Expression | Expression to be evaluated       |

Example 1: Don't flow an attribute if it is null
```
IgnoreFlowIfNullOrEmpty([department])
```
The above expression will drop the department attribute from the provisioning flow if it is null or empty.

Example 2: Don't flow an attribute if the expression mapping evaluates to empty string or null
Let's say the SuccessFactors attribute `prefix` is mapped to the on-premises Active Directory attribute `personalTitle` using the following expression mapping:
```
IgnoreFlowIfNullOrEmpty(Switch([prefix], "", "3443", "Dr. ", "3444", "Prof.", "3445", "Prof. Dr."))
```
The above expression first evaluates the `Switch` function. If the `prefix` attribute doesn't have any of the values listed within the `Switch` function, then `Switch` will return an empty string and the attribute `personalTitle` will not be included in the provisioning flow to on-premises Active Directory.

## IIF

**Function:** IIF(condition,valueIfTrue,valueIfFalse)

**Description:** The IIF function returns one of a set of possible values based on a specified condition.

### Parameters:

| Name          | Required/ Repeating | Type               | Notes                                               |
|---------------|---------------------|--------------------|-----------------------------------------------------|
| condition     | Required            | Variable or Expression | Any value or expression that can be evaluated to true or false. |
| valueIfTrue   | Required            | Variable or String | If the condition evaluates to true, the returned value. |
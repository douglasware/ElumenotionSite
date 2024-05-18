## Function Definitions and Comparison Operators

### valueIfFalse
| Name       | Required/Repeating | Type            | Notes                                         |
|------------|--------------------|-----------------|-----------------------------------------------|
| valueIfFalse | Required         | Variable or String | If the condition evaluates to false, the returned value. |

Comparison operators for condition:
- Equal to (=) and not equal to (<>)
- Greater than (>) and greater than equal to (>=)
- Less than (<) and less than equal to (<=)

Example:
```
Set the target attribute value to source country attribute if country="USA", else set target attribute value to source department attribute. IIF([country]="USA", [country], [department])
```

## Known Limitations

### Issues and Workarounds
This section includes limitations and workarounds for the IIF function. For more on troubleshooting user creation issues, see related documentation on handling null or empty values.

- The IIF function does not support AND and OR logical operators directly. For AND logic, use nested IIF statements:
  ```
  IIF([country]="USA" AND [state]="CA", "True", "False")
  IIF([country]="USA", IIF([state]="CA", "True", "False"), "False")
  ```

- To achieve OR logic, similar nesting can be applied:
  ```
  IIF([country]="USA" OR [state]="CA", "True", "False")
  IIF([country]="USA", "True", IIF([state]="CA", "True", "False"))
  ```

- If the source attribute in the IIF function is empty or null, the function fails:
  - Unsupported IIF expressions: 
    - `IIF([country]="", "Other", [country])`
    - `IIF([IsNullorEmpty([country])], "Other", [country])`
    - `IIF([IsPresent([country])], [country], "Other")`

- Recommended solution:
  - Use the Switch function to check for null or empty values and set defaults:
    ```
    Switch([country], [country], "", "Other")
    ```
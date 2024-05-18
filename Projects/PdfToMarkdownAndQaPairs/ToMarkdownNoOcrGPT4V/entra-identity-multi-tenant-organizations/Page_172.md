## Parameters

| Name          | Required/Repeating | Type  | Notes |
|---------------|--------------------|-------|-------|
| inputFormat   | Required           | String| Expected format of the source value. For supported formats, see [.NET custom date and time format strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings).|
| outputFormat  | Required           | String| Format of the output date. |


### Output date as a string in a certain format

**Example:** You want to send dates to a SaaS application like ServiceNow in a certain format. You can consider using the following expression.

**Expression:**
```
FormatDateTime([extensionAttribute1], "yyyyMMddHHmmss.fZ", "yyyy-MM-dd")
```

**Sample input/output:**
- **INPUT** (extensionAttribute1): "20150123105347.1Z"
- **OUTPUT**: "2015-01-23"

### Guid

**Function:** Guid()

**Description:** The function Guid generates a new random GUID

**Example:**
```
Guid()
```
**Sample output:** "1088051a-cd4b-4288-84f8-e02042ca72bc"

### IgnoreFlowIfNullOrEmpty

**Function:** IgnoreFlowIfNullOrEmpty(expression)

**Description:** The IgnoreFlowIfNullOrEmpty function instructs the provisioning service to ignore the attribute and drop it from the flow if the enclosed function or attribute is NULL or empty.
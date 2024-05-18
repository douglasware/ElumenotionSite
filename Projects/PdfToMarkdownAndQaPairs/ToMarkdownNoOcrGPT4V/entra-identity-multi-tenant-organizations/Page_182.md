## Workday Example

Assuming you want to map the attribute **ContractEndDate** from Workday, which is in the format `2020-12-31-08:00` to **accountExpires** field in AD, here's how you can use this function and change the timezone offset to match your locale:

```plaintext
NumFromDate(Join("", FormatDateTime([ContractEndDate], "yyyy-MM-ddzzz", "yyyy-MM-dd"), ":23:59:59-08:00"))
```

## SuccessFactors Example

Assuming you want to map the attribute **endDate** from SuccessFactors, which is in the format `M/d/yyyy hh:mm:ss tt` to **accountExpires** field in AD, here's how you can use this function and change the time zone offset to match your locale:

```plaintext
NumFromDate(Join("", FormatDateTime([endDate], "M/d/yyyy hh:mm:ss tt", "yyyy-MM-dd"), ":23:59:59-08:00"))
```

## PCase Function

### Description

The `PCase` function converts the first character of each word in a string to upper case, and all other characters are converted to lower case.

### Parameters

| Name           | Required/Optional | Type  | Notes                                  |
|----------------|-------------------|-------|----------------------------------------|
| source         | Required          | String| source value to convert to proper case.|
| wordSeparators | Optional          | String| Specify a set of characters used as word separators (example: "-")|

### Remarks

- If the `wordSeparators` parameter isn't specified, then `PCase` internally invokes the .NET function `ToTitleCase` to convert the `source` string to proper case. 
- The .NET `ToTitleCase` supports a comprehensive set of the Unicode character categories as word separators.
  - Space character
  - New line character
  - Control characters like CRLF
  - Format control characters
  - Connector/Punctuation characters like underscore
  - Dash/Punctuation characters like dash and hyphen (including characters such as En Dash, Em Dash, double hyphen, etc.)
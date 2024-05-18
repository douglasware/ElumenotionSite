**Description:** Flips the boolean value of the source. If source value is True, returns False. Otherwise, returns True.

**Parameters:**

| Name   | Required/ Repeating | Type           | Notes                               |
|--------|----------------------|----------------|-------------------------------------|
| source | Required             | Boolean String | Expected source values are "True" or "False". |

## Now

**Function:** Now()

**Description:**
The Now function returns a string representing the current UTC DateTime in the format M/d/yyyy h:mm:ss tt.

**Example:** `Now()`
Example value returned 7/2/2021 3:33:38 PM

## NumFromDate

**Function:** NumFromDate(value)

**Description:** The NumFromDate function converts a DateTime value to Active Directory format that is required to set attributes like accountExpires. Use this function to convert DateTime values received from cloud HR apps like Workday and SuccessFactors to their equivalent AD representation.

**Parameters:**

| Name  | Required/ Repeating | Type   | Notes                                                                                                                 |
|-------|----------------------|--------|-----------------------------------------------------------------------------------------------------------------------|
| value | Required             | String | Date time string in ISO 8601 format. If the date variable is in a different format, use FormatDateTime function to convert the date to ISO 8601 format. |

**Example:**
## Example Modifications using Date Functions

| Example                      | interval | value | dateTime (value of variable StatusHireDate) | output               |
|------------------------------|----------|-------|---------------------------------------------|----------------------|
| Add 7 days to hire date      | "d"      | 7     | 2012-03-16-07:00                            | 3/23/2012 7:00 AM    |
| Get a date ten days prior to hire date | "d"  | -10   | 2012-03-16-07:00                            | 3/6/2012 7:00 AM     |
| Add two weeks to hire date   | "ww"     | 2     | 2012-03-16-07:00                            | 3/30/2012 7:00 AM    |
| Add ten months to hire date  | "m"      | 10    | 2012-03-16-07:00                            | 1/16/2013 7:00 AM    |
| Add two years to hire date   | "yyyy"   | 2     | 2012-03-16-07:00                            | 3/16/2014 7:00 AM    |

## DateDiff Function Documentation

### Function:
```
DateDiff(interval, date1, date2)
```

### Description:
This function uses the `interval` parameter to return a number that indicates the difference between the two input dates. It returns

- a positive number if date2 > date1,
- a negative number if date2 < date1,
- 0 if date2 == date1

### Parameters:

| Name      | Required/Optional | Type     | Notes                                          |
|-----------|-------------------|----------|------------------------------------------------|
| interval  | Required          | String   | Interval of time to use for calculating the difference. |
| date1     | Required          | DateTime | DateTime representing a valid date.           |
| date2     | Required          | DateTime | DateTime representing a valid date.           |

Note: When passing a date string as input, use `CDate` function to wrap the datetime string. To get system time in UTC, use the `Now` function.

The interval string must have one of the following values:
- **Expandable detailed values in documentation**
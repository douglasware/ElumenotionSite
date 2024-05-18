· yyyy Year

· m Month

· d Day

· ww Week

· h Hour

· n Minute

· s Second

Example 1: Compare current date with hire date from Workday with different intervals
DateDiff("d", Now(), CDate([StatusHireDate]))

Expand table

| Example | interval | date1  | date2 | output |
| - | - | - | - | - |
| Positive difference in days between two dates | d | 2021-08-18+08:00 | 2021-08-31+08:00 | 13 |
| Negative difference in days between two dates | d | 8/25/2021 5:41:18 PM | 2012-03-16- 07:00 | -3449 |
| Difference in weeks between two dates | ww | 8/25/2021 5:41:18 PM | 2012-03-16- 07:00 | -493 |
| Difference in months between two dates | m | 8/25/2021 5:41:18 PM | 2012-03-16- 07:00 | -113 |
| Difference in years between two dates | yyyy | 8/25/2021 5:41:18 PM | 2012-03-16- 07:00 | -9 |
| Difference when both dates are same | d  | 2021-08-31+08:00 | 2021-08-31+08:00 | 0 |
| Difference in hours between two dates | h | 2021-08-24 | 2021-08-25 | 24 |
| Difference in minutes between two dates | n | 2021-08-24 | 2021-08-25 | 1440 |
| Difference in seconds between two dates | s | 2021-08-24 | 2021-08-25 | 86400 |

Example 2: Combine DateDiff with IIF function to set attribute value
If an account is Active in Workday, set the accountEnabled attribute of the user to True only if hire date is within the next five days.
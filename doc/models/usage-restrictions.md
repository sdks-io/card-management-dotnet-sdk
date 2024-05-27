
# Usage Restrictions

## Structure

`UsageRestrictions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DailySpend` | `double?` | Optional | Maximum spend value (amount) allowed per day.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `WeeklySpend` | `double?` | Optional | Maximum spend value (amount) allowed per week.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `MonthlySpend` | `double?` | Optional | Maximum spend value (amount) allowed per month.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `PerTransactionSpend` | `double?` | Optional | Maximum spend value (amount) allowed per transaction.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `DailyVolume` | `int?` | Optional | Maximum volume (quantity) allowed per day.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `WeeklyVolume` | `int?` | Optional | Maximum volume (quantity) allowed per week.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `MonthlyVolume` | `int?` | Optional | Maximum volume (quantity) allowed per month.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `PerTransactionVolume` | `int?` | Optional | Maximum volume (quantity) allowed per transaction.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `DailyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per day.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `WeeklyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per week.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `MonthlyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per month.<br>Optional.<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `AnnualSpend` | `double?` | Optional | Maximum spend value (amount) allowed per annum.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `LifeTimeSpend` | `double?` | Optional | Maximum spend value (amount) allowed in card’s life time.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `AnnualVolume` | `double?` | Optional | Maximum volume (quantity) allowed per annum.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `LifeTimeVolume` | `double?` | Optional | Maximum volume (quantity) allowed in card’s life time.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `AnnualTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per annum.<br>Optional.<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |
| `LifeTimeTransactionCount` | `double?` | Optional | Maximum number of transactions allowed in card’s lifetime.<br>Optional<br>The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.<br>Valid range: 0 to 9999999999 |

## Example (as JSON)

```json
{
  "DailySpend": 7.72,
  "WeeklySpend": 10.22,
  "MonthlySpend": 48.66,
  "PerTransactionSpend": 17.28,
  "DailyVolume": 122
}
```


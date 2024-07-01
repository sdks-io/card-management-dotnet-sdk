
# Usage Restrictions Card

## Structure

`UsageRestrictionsCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DailySpend` | `double?` | Optional | Maximum spend value (amount) allowed per day.<br>Optional<br>It allows null in the input field. If Values is passed as null, apply the card type limit. However, if the card type limit is NULL for the same field then No limit will be applied in Gateway. |
| `WeeklySpend` | `double?` | Optional | Maximum spend value (amount) allowed per week.<br>Optional |
| `MonthlySpend` | `double?` | Optional | Maximum spend value (amount) allowed per month.<br>Optional |
| `PerTransactionSpend` | `double?` | Optional | Maximum spend value (amount) allowed per transaction.<br>Optional |
| `AnnualSpend` | `double?` | Optional | Maximum spend value (amount) allowed per annum.<br>Optional |
| `LifeTimeSpend` | `double?` | Optional | Maximum spend value (amount) allowed in card’s life time.<br>Optional |
| `DailyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per day.<br>Optional |
| `WeeklyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per week.<br>Optional |
| `MonthlyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per month.<br>Optional |
| `PerTransactionVolume` | `double?` | Optional | Maximum volume (quantity) allowed per transaction.<br>Optional |
| `AnnualVolume` | `double?` | Optional | Maximum volume (quantity) allowed per annum.<br>Optional |
| `LifeTimeVolume` | `double?` | Optional | Maximum volume (quantity) allowed in card’s life time.<br>Optional |
| `DailyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per day.<br>Optional |
| `WeeklyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per week.<br>Optional |
| `MonthlyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per month.<br>Optional. |
| `AnnualTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per annum. |
| `LifeTimeTransactionCount` | `double?` | Optional | Maximum number of transactions allowed in card’s lifetime.<br>Optional |

## Example (as JSON)

```json
{
  "DailySpend": 76.58,
  "WeeklySpend": 181.92,
  "MonthlySpend": 132.96,
  "PerTransactionSpend": 101.58,
  "AnnualSpend": 51.38
}
```


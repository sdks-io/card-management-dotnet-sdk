
# Card Usage Restrictions

## Structure

`CardUsageRestrictions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level` | `string` | Optional | Describes at which level the restriction is set at.<br>Possible values:<br>OU = Restriction set at ColCo card type<br>Customer = Restriction set at customer card type |
| `DailySpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in a day. |
| `WeeklySpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in a week. |
| `MonthlySpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in a month. |
| `AnnualSpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in a year. |
| `LifeTimeSpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in the card’s life time. |
| `DailyVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in a day. |
| `WeeklyVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in a week. |
| `MonthlyVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in a month. |
| `AnnualVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in a year.<br>**Default**: `0` |
| `LifeTimeVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in the card’s life time. |
| `TransactionSpendLimit` | `double?` | Optional | Maximum amount that can be spend on the card in a transaction. |
| `TransactionVolumeLimit` | `double?` | Optional | Maximum volume of fuel that can be bought on the card in a transaction. |
| `DailyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed on a card in a day. |
| `WeeklyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed on a card in a week. |
| `MonthlyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed on a card in a month. |
| `AnnualTransactionCount` | `double?` | Optional | Maximum number of transactions allowed on the card in a year. |
| `LifeTimeTransactionCount` | `double?` | Optional | Maximum number of transactions allowed on the card in the card’s life time. |
| `IsVelocityCeiling` | `bool?` | Optional | IsVelocityCeiling flag<br>Note: When "True", the velocity defaults configured in MS DB will be considered as the Max Limits for velocity changes. When ‘false’ max allowed limits will be 999999999999 for Type “Count” and 9999999999.99 for Type ‘Value’. |

## Example (as JSON)

```json
{
  "Level": "OU",
  "DailySpendLimit": 120.0,
  "WeeklySpendLimit": 56.07,
  "MonthlySpendLimit": 0.0,
  "AnnualSpendLimit": 0.0,
  "LifeTimeSpendLimit": 0,
  "DailyVolumeLimit": 0,
  "WeeklyVolumeLimit": 0,
  "MonthlyVolumeLimit": 0,
  "AnnualVolumeLimit": 0,
  "LifeTimeVolumeLimit": 0,
  "TransactionSpendLimit": 0,
  "TransactionVolumeLimit": 0,
  "DailyTransactionCount": 100,
  "WeeklyTransactionCount": 100,
  "MonthlyTransactionCount": 100,
  "AnnualTransactionCount": 100,
  "LifeTimeTransactionCount": 100
}
```


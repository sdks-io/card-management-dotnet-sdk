
# Usage Restriction

Details of the usage restrictions such as day/week/month value and volume restrictions applied on the card.

## Structure

`UsageRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level` | `string` | Optional | Usage limit is applied on the card from this level.<br>Valid values –<br>•    Inherited<br>•    Card<br>When Card level usage restrictions are not present, the API will return the inherited restrictions.<br>Note: -This field is deprecated. Instead, use ‘Override’. |
| `DailySpend` | `double?` | Optional | Maximum spend value (amount) allowed per day.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `DailySpendAccumulated` | `double?` | Optional | Balance spend value (amount) available for rest of the day. |
| `DailySpendBalance` | `double?` | Optional | Balance spend value (amount) available for rest of the day. |
| `DailySpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `DailySpendThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55 |
| `WeeklySpend` | `double?` | Optional | Maximum spend value (amount) allowed per week.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `WeeklySpendAccumulated` | `double?` | Optional | Value (amount) spent during the week. |
| `WeeklySpendBalance` | `double?` | Optional | Balance spend value (amount) available for rest of the week. |
| `WeeklySpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `WeeklySpendThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `MonthlySpend` | `double?` | Optional | Maximum spend value (amount) allowed per month.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `MonthlySpendAccumulated` | `double?` | Optional | Value (amount) spent during the month. |
| `MonthlySpendBalance` | `double?` | Optional | Balance spend value (amount) available for rest of the month. |
| `MonthlySpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `PerTransactionSpend` | `double?` | Optional | Maximum spend value (amount) allowed per transaction.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `PerTransactionSpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `AnnualSpend` | `double?` | Optional | Maximum spend value (amount) allowed per annum.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `AnnualSpendAccumulated` | `double?` | Optional | Value (amount) spent during the year. |
| `AnnualSpendBalance` | `double?` | Optional | Balance spend value (amount) available for rest of the year. |
| `AnnualSpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `AnnualSpendThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `LifeTimeSpend` | `double?` | Optional | Maximum spend value (amount) allowed in card’s life time.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited |
| `LifeTimeSpendAccumulated` | `double?` | Optional | Value (amount) spent during the card’s life time |
| `LifeTimeSpendBalance` | `double?` | Optional | Balance spend value (amount) available for rest of the card’s life time. |
| `LifeTimeSpendOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `LifeTimeSpendThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `DailyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per day.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `DailyVolumeAccumulated` | `double?` | Optional | Volume (quantity) bought during the day. |
| `DailyVolumeBalance` | `double?` | Optional | Balance volume (quantity) available for rest of the day. |
| `DailyVolumeOverride` | `double?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `DailyVolumeThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `WeeklyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per week.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `WeeklyVolumeAccumulated` | `double?` | Optional | Volume (quantity) bought during the week. |
| `WeeklyVolumeBalance` | `double?` | Optional | Balance volume (quantity) available for rest of the week. |
| `WeeklyVolumeOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `WeeklyVolumeThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `MonthlyVolume` | `double?` | Optional | Maximum volume (quantity) allowed per month.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `MonthlyVolumeAccumulated` | `double?` | Optional | Volume (quantity) bought during the month. |
| `MonthlyVolumeBalance` | `double?` | Optional | Balance volume (quantity) available for rest of the month. |
| `MonthlyVolumeOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default). |
| `MonthlyVolumeThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `PerTransactionVolume` | `double?` | Optional | Maximum volume (quantity) allowed per transaction.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `PerTransactionVolumeOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `AnnualVolume` | `double?` | Optional | Maximum volume (quantity) allowed per annum.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `AnnualVolumeAccumulated` | `double?` | Optional | Volume (quantity) bought during the year. |
| `AnnualVolumeBalance` | `double?` | Optional | Balance volume (quantity) available for rest of the year. |
| `AnnualVolumeOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `AnnualVolumeThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `LifeTimeVolume` | `double?` | Optional | Maximum volume (quantity) allowed in the card’s life time.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `LifeTimeVolumeAccumulated` | `double?` | Optional | Volume (quantity) bought during the card’s life time. |
| `LifeTimeVolumeBalance` | `double?` | Optional | Balance volume (quantity) available for rest of the card’s life time. |
| `LifeTimeVolumeOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `LifeTimeVolumeThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `DailyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per day.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited |
| `DailyTransactionAccumulated` | `double?` | Optional | Number of times the card is used during the day. |
| `DailyTransactionBalance` | `double?` | Optional | Number of times the card could be used in rest of the day. |
| `DailyTransactionOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `DailyTransactionThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `WeeklyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per week.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `WeeklyTransactionAccumulated` | `double?` | Optional | Number of times the card is used during the week |
| `WeeklyTransactionBalance` | `double?` | Optional | Number of times the card could be used in rest of the week. |
| `WeeklyTransactionOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `WeeklyTransactionThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `MonthlyTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per month.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `MonthlyTransactionAccumulated` | `double?` | Optional | Number of times the card is used during the month |
| `MonthlyTransactionBalance` | `double?` | Optional | Number of times the card could be used in rest of the month. |
| `MonthlyTransactionOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `MonthlyTransactionThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `AnnualTransactionCount` | `double?` | Optional | Maximum number of transactions allowed per annum.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance. |
| `AnnualTransactionAccumulated` | `double?` | Optional | Number of times the card is used during the year. |
| `AnnualTransactionBalance` | `double?` | Optional | Number of times the card could be used in rest of the year. |
| `AnnualTransactionOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `AnnualTransactionThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |
| `LifeTimeTransactionCount` | `double?` | Optional | Maximum number of transactions allowed in the card’s life time.<br>Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.<br>However, Inherited limit ‘0’ represents unlimited. |
| `LifeTimeTransactionAccumulated` | `double?` | Optional | Number of times the card is used during the card’s life time. |
| `LifeTimeTransactionBalance` | `double?` | Optional | Number of times the card could be used in rest of the card’s life time. |
| `LifeTimeTransactionOverride` | `bool?` | Optional | Indicate if the limit is overridden or default. (False for default).<br>Example: false |
| `LifeTimeTransactionThreshold` | `double?` | Optional | The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.<br>Example: 50.55<br>This is an optional output field. |

## Example (as JSON)

```json
{
  "Level": "Level8",
  "DailySpend": 43.36,
  "DailySpendAccumulated": 178.28,
  "DailySpendBalance": 56.44,
  "DailySpendOverride": false
}
```



# Bundle Restriction

## Structure

`BundleRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DayTimeRestrictionAction` | `string` | Optional | The value indicates what actions to be performed with respect to day time restriction.<br>Mandatory<br>Allowed values –<br>•	Add: Apply the given restriction on the bundle.<br>•	Default: No Day/Time restriction will be applied on the bundle in Gateway. |
| `LocationRestrictionAction` | `string` | Optional | The value indicates what actions to be performed with respect to location restriction.<br>Mandatory<br>Allowed values –<br>•	Add: Apply the given restriction on the bundle.<br>•	Default: No location restriction will be applied on the bundle in Gateway. |
| `UsageRestrictions` | [`UsageRestrictionsCard`](../../doc/models/usage-restrictions-card.md) | Optional | - |
| `DayTimeRestrictions` | [`DayTimeRestriction`](../../doc/models/day-time-restriction.md) | Optional | Details of the day/time restrictions such as weekdays and time range in which transactions should be allowed on the card. |
| `ProductRestrictions` | [`ProductRestrictionCard`](../../doc/models/product-restriction-card.md) | Optional | - |
| `LocationRestrictions` | [`LocationRestriction`](../../doc/models/location-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "DayTimeRestrictionAction": "DayTimeRestrictionAction8",
  "LocationRestrictionAction": "LocationRestrictionAction6",
  "UsageRestrictions": {
    "DailySpend": 7.72,
    "WeeklySpend": 10.22,
    "MonthlySpend": 48.66,
    "PerTransactionSpend": 17.28,
    "AnnualSpend": 223.08
  },
  "DayTimeRestrictions": {
    "Monday": false,
    "Tuesday": false,
    "Wednesday": false,
    "Thursday": false,
    "Friday": false
  },
  "ProductRestrictions": {
    "Products": [
      "Products4"
    ],
    "ProductGroups": [
      "ProductGroups3",
      "ProductGroups4"
    ]
  }
}
```


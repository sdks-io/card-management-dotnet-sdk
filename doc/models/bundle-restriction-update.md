
# Bundle Restriction Update

## Structure

`BundleRestrictionUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResetDayTimeRestriction` | `bool?` | Optional | True/False<br>A value indicates if the day/time restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `ResetLocationRestriction` | `bool?` | Optional | True/False<br>A value indicates if the location restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `ResetProductRestriction` | `bool?` | Optional | True/False<br>A value indicates if the product restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `UsageRestrictions` | [`UsageRestrictionsCard`](../../doc/models/usage-restrictions-card.md) | Optional | - |
| `DayTimeRestrictionProfileId` | `string` | Optional | Identifier of the day/time restriction profile to be updated for the bundle in Gateway.<br>Optional |
| `DayTimeRestrictions` | [`CardDayTimeRestrictions`](../../doc/models/card-day-time-restrictions.md) | Optional | - |
| `ProductRestrictions` | [`ProductRestrictionCard`](../../doc/models/product-restriction-card.md) | Optional | - |
| `LocationRestrictionProfileId` | `string` | Optional | Identifier of the location restriction profile to be updated for the bundle in Gateway.<br>Optional |
| `LocationRestrictions` | [`LocationRestriction`](../../doc/models/location-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "ResetDayTimeRestriction": false,
  "ResetLocationRestriction": false,
  "ResetProductRestriction": false,
  "UsageRestrictions": {
    "DailySpend": 7.72,
    "WeeklySpend": 10.22,
    "MonthlySpend": 48.66,
    "PerTransactionSpend": 17.28,
    "AnnualSpend": 223.08
  },
  "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId2"
}
```



# Bundle Restriction Update

## Structure

`BundleRestrictionUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResetDayTimeRestriction` | `bool?` | Optional | True/False<br>A value indicates if the day/time restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `ResetLocationRestriction` | `bool?` | Optional | True/False<br>A value indicates if the location restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `ResetProductRestriction` | `bool?` | Optional | True/False<br>A value indicates if the product restriction is to be reset for card bundle.<br>Optional<br>Default value is False. |
| `UsageRestrictions` | `object` | Optional | - |
| `DayTimeRestrictionProfileId` | `string` | Optional | Identifier of the day/time restriction profile to be updated for the bundle in Gateway.<br>Optional |
| `DayTimeRestrictions` | [`CardDayTimeRestrictions`](../../doc/models/card-day-time-restrictions.md) | Optional | - |
| `ProductRestrictions` | `object` | Optional | - |
| `LocationRestrictionProfileId` | `string` | Optional | Identifier of the location restriction profile to be updated for the bundle in Gateway.<br>Optional |
| `LocationRestrictions` | [`LocationRestriction`](../../doc/models/location-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "ResetDayTimeRestriction": false,
  "ResetLocationRestriction": false,
  "ResetProductRestriction": false,
  "UsageRestrictions": {
    "key1": "val1",
    "key2": "val2"
  },
  "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId2"
}
```


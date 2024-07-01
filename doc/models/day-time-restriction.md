
# Day Time Restriction

Details of the day/time restrictions such as weekdays and time range in which transactions should be allowed on the card.

## Structure

`DayTimeRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Monday` | `bool?` | Optional | True if card could be used on a Monday, else false |
| `Tuesday` | `bool?` | Optional | True if card could be used on a Tuesday, else false. |
| `Wednesday` | `bool?` | Optional | True if card could be used on a Wednesday, else false. |
| `Thursday` | `bool?` | Optional | True if card could be used on a Thursday, else false |
| `Friday` | `bool?` | Optional | True if card could be used on a Friday, else false |
| `Saturday` | `bool?` | Optional | True if card could be used on a Saturday, else false |
| `Sunday` | `bool?` | Optional | True if card could be used on a Sunday, else false. |
| `TimeFrom` | `string` | Optional | Card could be used from this time in a day.<br>Format: HH:mm (24-hour format)<br>Note:<br><br>1. Clients to convert this to appropriate DateTime or TimeSpan type.<br>   “00:00” is the lowest time value and “23:59” is the highest time value. |
| `TimeTo` | `string` | Optional | Card could be used up to this time in a day.<br>Format: HH:mm (24-hour format)<br>Note:<br><br>1. Clients to convert this to appropriate DateTime or TimeSpan type.<br>   “00:00” is the lowest time value and “23:59” is the highest time value. |

## Example (as JSON)

```json
{
  "Monday": false,
  "Tuesday": false,
  "Wednesday": false,
  "Thursday": false,
  "Friday": false
}
```


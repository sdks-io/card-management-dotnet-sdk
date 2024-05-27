
# Schedule Card Block Response Data Items

## Structure

`ScheduleCardBlockResponseDataItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardId` | `int?` | Optional | Unique Id of the card. |
| `FromDate` | `string` | Optional | Effective start date & time of Block / Unblock as updated in the intermediate queue table.<br><br>Format: yyyyMMdd HH:mm<br>Eg: 20230512 12:30 |
| `ToDate` | `string` | Optional | Effective end date & time of Block / Unblock as updated in the intermediate queue table.<br><br>Format: yyyyMMdd HH:mm<br>Eg: 20230512 14:30 |
| `ReferenceId` | `int?` | Optional | Effective end date & time of Block / Unblock as updated in the intermediate queue table.<br><br>Format: yyyyMMdd HH:mm<br>Eg: 20230512 14:30 |

## Example (as JSON)

```json
{
  "CardId": 86,
  "FromDate": "FromDate8",
  "ToDate": "ToDate8",
  "ReferenceId": 10
}
```


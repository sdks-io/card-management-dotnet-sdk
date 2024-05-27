
# PIN Reminder Reference

This class holds the PIN Reminder References

## Structure

`PINReminderReference`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardId` | `int?` | Optional | Card Id |
| `PANID` | `int?` | Optional | PAN ID |
| `PAN` | `int?` | Optional | PAN |
| `CardExpiryDate` | `string` | Optional | Expiry date of the card.<br>Mandatory if Either PAN or PANID is passed, else optional.<br>Format: yyyyMMdd |
| `ReferenceId` | `int?` | Optional | Individual card pin reminder reference number for the Pin Reminder request. |

## Example (as JSON)

```json
{
  "CardId": 122,
  "PANID": 154,
  "PAN": 52,
  "CardExpiryDate": "CardExpiryDate4",
  "ReferenceId": 46
}
```


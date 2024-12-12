
# Card Management V1 Pinreminder Request

## Structure

`CardManagementV1PinreminderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br /><br>Optional if AccountNumber is passed, else Mandatory.<br /><br>This input is a search criterion, if given. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br /><br>Optional if AccountId is passed, else Mandatory.<br /><br>This input is a search criterion, if given. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer. <br /><br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. <br /><br>It is optional for other countries if ColCoID is provided. |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer<br /><br>Optional if ColCoCode is passed else Mandatory. |
| `PayerId` | `int?` | Optional | Payer Id (i.e. Customer Id of the Payment Customer of the selected payer.<br /><br>Optional if PayerNumber is passed else Mandatory |
| `PayerNumber` | `string` | Optional | Payer Number (Ex: GB000000123) of the selected payer.<br /><br>Optional if PayerId is passed else Mandatory |
| `PINReminderCardDetails` | [`List<PINReminderCardDetails>`](../../doc/models/pin-reminder-card-details.md) | Optional | List of PINReminderCardDetails entity. The fields of this entity are described below. |

## Example (as JSON)

```json
{
  "AccountId": 18,
  "AccountNumber": "AccountNumber6",
  "ColCoCode": 180,
  "ColCoId": 166,
  "PayerId": 214
}
```


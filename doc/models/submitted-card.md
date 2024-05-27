
# Submitted Card

Response entity object for SubmittedCard list <br/>Note: This list will be empty for status 9006 and 9012 i.e., request for all the cards failed.

## Structure

`SubmittedCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReplacementCardReference` | `int?` | Optional | Reference number for tracking of replacement card order request of the specific card,<br /><br>This is applicable for requests with target status as Block and OrderReplacement passed as True. |
| `UpdateCardReference` | `int?` | Optional | Reference number for tracking of update status request of the specific card, |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br /><br>Optional if AccountNumber is passed, else Mandatory. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br /><br>Optional if AccountId is passed, else Mandatory. |
| `CardExpiryDate` | `string` | Optional | Expiry date of the card.<br /><br>Mandatory if PAN is passed, else optional.<br /><br>Format: yyyyMMdd |
| `CardId` | `int?` | Optional | Card Id of the card.<br /><br>Optional if PAN is passed, else Mandatory. |
| `ColCoCode` | `int?` | Optional | Collecting company code of the customer. <br /><br>Optional if ColCoId is passed, else Mandatory.<br /> |
| `ColCoId` | `int?` | Optional | Collecting company id of the customer. <br /><br>Optional if ColCoCode is passed, else Mandatory.<br /> |
| `PAN` | `string` | Optional | PAN of the card.<br /><br>Optional if CardId is passed, else Mandatory.<br /> |
| `PayerId` | `int?` | Optional | Payer id of the customer.<br /><br>Optional if PayerNumber is passed, else Mandatory. |
| `PayerNumber` | `string` | Optional | PayerNumber of the customer.<br /><br>Optional if PayerId is passed, else Mandatory. |

## Example (as JSON)

```json
{
  "ReplacementCardReference": 234,
  "UpdateCardReference": 140,
  "AccountId": 124,
  "AccountNumber": "AccountNumber8",
  "CardExpiryDate": "CardExpiryDate6"
}
```


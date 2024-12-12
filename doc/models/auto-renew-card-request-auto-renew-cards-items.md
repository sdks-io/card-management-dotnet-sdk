
# Auto Renew Card Request Auto Renew Cards Items

## Structure

`AutoRenewCardRequestAutoRenewCardsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional if AccountId is passed, else Mandatory. |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Optional if AccountNumber is passed, else Mandatory. |
| `PAN` | `string` | Optional | PAN of the card.<br>Optional if CardId is passed, else Mandatory. |
| `PANID` | `double?` | Optional | Card PAN ID.<br>Optional if CardId is given, else mandatory.<br>Note: PANID is ignored if CardId is given. |
| `CardId` | `int?` | Optional | Card Id of the card.<br>Optional if PAN is passed, else Mandatory. |
| `ReissueSetting` | `bool` | Required | Reissue setting of the card.<br>Values:<br>True – Card will be Reissued when nearing its expiry date<br>False – Card will not be Reissued<br>Mandatory |

## Example (as JSON)

```json
{
  "AccountNumber": "AccountNumber4",
  "AccountId": 178,
  "PAN": "PAN6",
  "PANID": 75.4,
  "CardId": 84,
  "ReissueSetting": false
}
```


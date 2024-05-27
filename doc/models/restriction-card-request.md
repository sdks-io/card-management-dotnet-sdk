
# Restriction Card Request

## Structure

`RestrictionCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory<br>Example: GB000000123<br>List of restrictions to be applied on the card. The details of CardRestriction entity is given below. |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `Cards` | [`List<RestrictionCardRequestCardsItems>`](../../doc/models/restriction-card-request-cards-items.md) | Optional | List of restrictions to be applied on the card. The details of CardRestriction entity is given below. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |

## Example (as JSON)

```json
{
  "ColCoId": 110,
  "PayerNumber": "PayerNumber6",
  "PayerId": 158,
  "Cards": [
    {
      "AccountNumber": "AccountNumber8",
      "AccountId": 184,
      "PAN": "PAN0",
      "CardId": 90,
      "ResetUsageRestrictions": false
    }
  ],
  "ColCoCode": 124
}
```


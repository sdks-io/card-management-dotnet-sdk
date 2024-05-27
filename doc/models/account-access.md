
# Account Access

## Structure

`AccountAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColcoId` | `int?` | Optional | Collecting company id. |
| `ColcoCode` | `int?` | Optional | Collecting company code. |
| `PayerId` | `int?` | Optional | Payer Id to which the user has access |
| `PayerNumber` | `string` | Optional | Payer Number to which the user has access |
| `PayerName` | `string` | Optional | Name of the Payer to which the user has access |
| `AccountId` | `int?` | Optional | Account Id to which the user has access |
| `AccountNumber` | `string` | Optional | Account Number to which the user has access |
| `AccountName` | `string` | Optional | Name of the Account to which the user has access |

## Example (as JSON)

```json
{
  "ColcoId": 14,
  "ColcoCode": 14,
  "PayerId": 854,
  "PayerNumber": "DE26688504",
  "PayerName": "TK MobilPlus",
  "AccountId": 435,
  "AccountNumber": "DE26688504",
  "AccountName": "TK Sub Account"
}
```


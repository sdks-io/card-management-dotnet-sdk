
# Delete Bundle Request

## Structure

`DeleteBundleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `ColCoId` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: GB000000123 |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: 123456 |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: GB000000123 |
| `BundleId` | `string` | Required | Identifier of the card bundle in Gateway.<br>Mandatory |

## Example (as JSON)

```json
{
  "ColCoCode": 218,
  "ColCoId": 204,
  "PayerNumber": "PayerNumber8",
  "PayerId": 252,
  "AccountId": 56,
  "BundleId": "BundleId8"
}
```



# Payers

## Structure

`Payers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the payer |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided. |
| `PayerId` | `int?` | Optional | Payer id of the customer. |
| `PayerNumber` | `string` | Optional | Payer Number of the customer. |
| `PayerName` | `string` | Optional | Payer Name of the customer. |
| `PayerGroupId` | `int?` | Optional | Payer Group identifier of the customer |

## Example (as JSON)

```json
{
  "ColCoId": 14,
  "ColCoCode": 14,
  "PayerId": 12345,
  "PayerName": "ABC company",
  "PayerGroupId": 456,
  "PayerNumber": "PayerNumber0"
}
```



# Payer Access

## Structure

`PayerAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsDefault` | `bool?` | Optional | Whether this payer is the default payer of the user.<br>**Default**: `false` |
| `ColcoId` | `int?` | Optional | Collecting company id. |
| `ColcoCode` | `int?` | Optional | Collecting company code.<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoCountryCode` | `string` | Optional | The 2-character ISO Code for the customer and card owning country |
| `PayerGroupId` | `int?` | Optional | Payer Group Id of the payer. |
| `PayerGroup` | `string` | Optional | Payer group of the payer.<br>The value of this parameter will always be null when the input parameter “IncludePayerGroup” is false. |
| `PayerId` | `int?` | Optional | Payer Id to which the user has access<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number to which the user has access<br>Example: GB000000123 |
| `PayerName` | `string` | Optional | Name of the Payer to which the user has access |

## Example (as JSON)

```json
{
  "IsDefault": false,
  "ColcoId": 14,
  "ColcoCode": 14,
  "ColCoCountryCode": "DE",
  "PayerGroupId": 123,
  "PayerGroup": "null",
  "PayerId": 854,
  "PayerNumber": "DE26688504",
  "PayerName": "TK MobilPlus"
}
```


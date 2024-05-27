
# Card Move Request

## Structure

`CardMoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | - |
| `ColCoId` | `int?` | Optional | - |
| `ColCoCountryCode` | `string` | Optional | - |
| `PayerNumber` | `string` | Optional | - |
| `PayerId` | `int?` | Optional | - |
| `Cards` | [`List<CardMoveRequestCardsItems>`](../../doc/models/card-move-request-cards-items.md) | Optional | - |
| `TargetAccountId` | `int?` | Optional | - |
| `TargetAccountNumber` | `string` | Optional | - |
| `TargetCardGroupId` | `int?` | Optional | - |
| `TargetNewCardGroupName` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "ColCoCode": 166,
  "ColCoId": 152,
  "ColCoCountryCode": "ColCoCountryCode0",
  "PayerNumber": "PayerNumber2",
  "PayerId": 200
}
```


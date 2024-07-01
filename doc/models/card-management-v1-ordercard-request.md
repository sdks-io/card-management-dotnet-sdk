
# Card Management V1 Ordercard Request

## Structure

`CardManagementV1OrdercardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardDetails` | [`List<CardDetail>`](../../doc/models/card-detail.md) | Optional | List of CardOrder entity. The fields in this entity are described below. |

## Example (as JSON)

```json
{
  "CardDetails": [
    {
      "PayerId": 232,
      "PayerNumber": "PayerNumber2",
      "AccountId": 36,
      "AccountNumber": "AccountNumber4",
      "ColCoCode": 198,
      "CardDeliveryType": 222,
      "PINAdviceType": 70
    }
  ]
}
```


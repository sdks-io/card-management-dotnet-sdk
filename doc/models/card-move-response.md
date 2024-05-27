
# Card Move Response

## Structure

`CardMoveResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MoveCardRequestReference` | `int?` | Optional | - |
| `SuccessfulRequests` | [`List<CardMoveResponseSuccessfulRequestsItems>`](../../doc/models/card-move-response-successful-requests-items.md) | Optional | - |
| `ErrorCards` | [`List<CardMoveResponseErrorCardsItems>`](../../doc/models/card-move-response-error-cards-items.md) | Optional | - |
| `RequestId` | `string` | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "MoveCardRequestReference": 70,
  "SuccessfulRequests": [
    {
      "AccountNumber": "AccountNumber8",
      "AccountId": 112,
      "PAN": "PAN0",
      "CardId": 18,
      "MoveCardReference": 248
    }
  ],
  "ErrorCards": [
    {
      "AccountNumber": "AccountNumber4",
      "AccountId": 230,
      "PAN": "PAN6",
      "CardId": 136,
      "ValidationErrorCode": "ValidationErrorCode6"
    },
    {
      "AccountNumber": "AccountNumber4",
      "AccountId": 230,
      "PAN": "PAN6",
      "CardId": 136,
      "ValidationErrorCode": "ValidationErrorCode6"
    }
  ],
  "RequestId": "RequestId2",
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


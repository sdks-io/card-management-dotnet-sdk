
# Create Card Group Response

## Structure

`CreateCardGroupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MainReference` | `int?` | Optional | Reference number for tracking the execution of the requests – new Card Group creation and to move the cards to the new card group.<br>Reference number will be null when the validations of new card group parameters fail. |
| `NewCardGroupReference` | `int?` | Optional | Reference number for tracking the execution of card group creation.<br>Reference number will be null when the validations of new card group parameters fail. |
| `SuccessfulRequests` | [`List<CreateCardGroupResponseSuccessfulRequestsItems>`](../../doc/models/create-card-group-response-successful-requests-items.md) | Optional | List of cards validated and submitted successfully for processing. |
| `ErrorCards` | [`List<CreateCardGroupResponseErrorCardsItems>`](../../doc/models/create-card-group-response-error-cards-items.md) | Optional | List of cards that failed validation and not submitted for processing.<br>Entity: FailedCardReference<br>This list will be empty when the validations of new card group parameters fail. |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

## Example (as JSON)

```json
{
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed",
  "MainReference": 104,
  "NewCardGroupReference": 174,
  "SuccessfulRequests": [
    {
      "CardId": 18,
      "PAN": "PAN0",
      "Reference": 228
    }
  ],
  "ErrorCards": [
    {
      "CardId": 136,
      "PAN": "PAN6",
      "ErrorCode": "ErrorCode0",
      "ErrorDescription": "ErrorDescription6"
    },
    {
      "CardId": 136,
      "PAN": "PAN6",
      "ErrorCode": "ErrorCode0",
      "ErrorDescription": "ErrorDescription6"
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


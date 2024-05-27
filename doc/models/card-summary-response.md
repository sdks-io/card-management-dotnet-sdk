
# Card Summary Response

## Structure

`CardSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Unique request identifier passed from end user. This identifier helps in tracing a transaction |
| `Status` | `string` | Optional | Unique request identifier passed from end user. This identifier helps in tracing a transaction |
| `Data` | [`List<SummaryResponse>`](../../doc/models/summary-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId6",
  "Status": "Status0",
  "Data": [
    {
      "ActiveCards": 252,
      "BlockedCards": 156,
      "CancelledCards": 102,
      "ExpiredCards": 156,
      "ExpiringCards": 122
    },
    {
      "ActiveCards": 252,
      "BlockedCards": 156,
      "CancelledCards": 102,
      "ExpiredCards": 156,
      "ExpiringCards": 122
    },
    {
      "ActiveCards": 252,
      "BlockedCards": 156,
      "CancelledCards": 102,
      "ExpiredCards": 156,
      "ExpiringCards": 122
    }
  ]
}
```


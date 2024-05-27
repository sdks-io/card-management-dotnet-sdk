
# Search Account Limit Response

## Structure

`SearchAccountLimitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `Data` | [`SearchAccountLimitResponseData`](../../doc/models/search-account-limit-response-data.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId0",
  "Status": "Status6",
  "Data": {
    "AccountId": 62,
    "AccountNumber": "AccountNumber8",
    "ReferenceProduct": "ReferenceProduct8",
    "RestrictionCondition": "RestrictionCondition4",
    "VelocityLimits": [
      {
        "Type": "Type0",
        "Period": "Period2",
        "Limit": 24.94,
        "Accumulation": 132.24,
        "Balance": 189.6
      },
      {
        "Type": "Type0",
        "Period": "Period2",
        "Limit": 24.94,
        "Accumulation": 132.24,
        "Balance": 189.6
      },
      {
        "Type": "Type0",
        "Period": "Period2",
        "Limit": 24.94,
        "Accumulation": 132.24,
        "Balance": 189.6
      }
    ]
  }
}
```


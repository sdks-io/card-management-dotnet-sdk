
# Update Bundle Response

## Structure

`UpdateBundleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `RequestActionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `DayTimeRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `LocationRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `ProductRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `UsageRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "RequestActionStatus": {
    "Code": "Code6",
    "Description": "Description0"
  },
  "DayTimeRestrictionStatus": {
    "Code": "Code4",
    "Description": "Description2"
  },
  "LocationRestrictionStatus": {
    "Code": "Code6",
    "Description": "Description0"
  },
  "ProductRestrictionStatus": {
    "Code": "Code8",
    "Description": "Description8"
  }
}
```


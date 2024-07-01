
# Create Bundle Response

## Structure

`CreateBundleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `BundleCreationStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `BundleId` | `string` | Optional | Identifier of the newly created bundle |
| `DayTimeRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `DayTimeRestrictionProfileId` | `string` | Optional | Identifier of the day/time restriction profile created |
| `LocationRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `LocationRestrictionProfileId` | `string` | Optional | Identifier of the location restriction profile created |
| `UsageRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `ProductRestrictionStatus` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `Cards` | [`BundleCardRestrictionStatus`](../../doc/models/bundle-card-restriction-status.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "BundleCreationStatus": {
    "Code": "Code8",
    "Description": "Description8"
  },
  "BundleId": "BundleId2",
  "DayTimeRestrictionStatus": {
    "Code": "Code4",
    "Description": "Description2"
  },
  "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId0"
}
```


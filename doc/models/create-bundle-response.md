
# Create Bundle Response

## Structure

`CreateBundleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id |
| `Status` | `string` | Optional | Response status |
| `Data` | [`List<CreateBundleResponseDataItems>`](../../doc/models/create-bundle-response-data-items.md) | Optional | - |
| `Errors` | [`List<ErrorDetails>`](../../doc/models/error-details.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId2",
  "Status": "Status8",
  "Data": [
    {
      "BundleId": "BundleId6",
      "Cards": [
        {
          "PAN": "PAN0"
        }
      ],
      "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId4",
      "LocationRestrictionProfileId": "LocationRestrictionProfileId6",
      "ProductRestrictionProfileId": "ProductRestrictionProfileId0"
    },
    {
      "BundleId": "BundleId6",
      "Cards": [
        {
          "PAN": "PAN0"
        }
      ],
      "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId4",
      "LocationRestrictionProfileId": "LocationRestrictionProfileId6",
      "ProductRestrictionProfileId": "ProductRestrictionProfileId0"
    },
    {
      "BundleId": "BundleId6",
      "Cards": [
        {
          "PAN": "PAN0"
        }
      ],
      "DayTimeRestrictionProfileId": "DayTimeRestrictionProfileId4",
      "LocationRestrictionProfileId": "LocationRestrictionProfileId6",
      "ProductRestrictionProfileId": "ProductRestrictionProfileId0"
    }
  ],
  "Errors": [
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```


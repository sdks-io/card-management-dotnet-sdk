
# Update Bundle Response

## Structure

`UpdateBundleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | API Request Id |
| `Status` | `string` | Optional | API Response Status |
| `Errors` | [`ErrorDetails`](../../doc/models/error-details.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId4",
  "Status": "Status0",
  "Errors": {
    "Code": "Code4",
    "Title": "Title6",
    "Detail": "Detail6",
    "AdditionalInfo": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```


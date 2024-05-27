
# Card Search Response

## Structure

`CardSearchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Unique request identifier passed from end user. This identifier helps in tracing a transaction |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCES, FAILED, PARTIAL_SUCCES |
| `Data` | [`List<Card>`](../../doc/models/card.md) | Optional | - |
| `Page` | `int?` | Optional | Specifies the returned page of the results |
| `PageSize` | `int?` | Optional | Specifies the number of records to be returned which could be less than the PageSize in the request |
| `TotalPages` | `int?` | Optional | Specifies the total pages available in the result |
| `TotalRecords` | `int?` | Optional | Specifies the total pages available in the result |

## Example (as JSON)

```json
{
  "RequestId": "RequestId6",
  "Status": "Status2",
  "Data": [
    {
      "AccountId": 62,
      "AccountName": "AccountName4",
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "BundleId": "BundleId6"
    },
    {
      "AccountId": 62,
      "AccountName": "AccountName4",
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "BundleId": "BundleId6"
    }
  ],
  "Page": 130,
  "PageSize": 110
}
```


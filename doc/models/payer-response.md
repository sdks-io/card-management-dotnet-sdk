
# Payer Response

## Structure

`PayerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `Payers` | [`List<PayerDetails>`](../../doc/models/payer-details.md) | Optional | - |
| `CurrentPage` | `int?` | Optional | Current Page |
| `RowCount` | `int?` | Optional | Total row count matched for the given input criteria |
| `TotalPages` | `int?` | Optional | Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria. Return 1 if the page size is -1 as all records are returned |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "CurrentPage": 1,
  "RowCount": 1,
  "TotalPages": 1,
  "Payers": [
    {
      "ColCoId": 78,
      "ColCoCode": 92,
      "CountryCode": "CountryCode8",
      "Country": "Country2",
      "PayerId": 126
    },
    {
      "ColCoId": 78,
      "ColCoCode": 92,
      "CountryCode": "CountryCode8",
      "Country": "Country2",
      "PayerId": 126
    },
    {
      "ColCoId": 78,
      "ColCoCode": 92,
      "CountryCode": "CountryCode8",
      "Country": "Country2",
      "PayerId": 126
    }
  ]
}
```


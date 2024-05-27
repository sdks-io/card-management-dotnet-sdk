
# Account Response

## Structure

`AccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accounts` | [`List<AccountResponseAccountsItems>`](../../doc/models/account-response-accounts-items.md) | Optional | - |
| `CurrentPage` | `int?` | Optional | current page |
| `RowCount` | `int?` | Optional | Total row count matched for the given input criteria |
| `TotalPages` | `int?` | Optional | Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria. |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request ID |

## Example (as JSON)

```json
{
  "CurrentPage": 1,
  "RowCount": 1,
  "TotalPages": 1,
  "RequestId": "e5165f29-7e6f-45b4-96fe-f303df9ca180",
  "Accounts": [
    {
      "AccountFullName": "AccountFullName8",
      "AccountId": 28,
      "AccountNumber": "AccountNumber0",
      "AccountShortName": "AccountShortName2",
      "BestOfIndicator": false
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


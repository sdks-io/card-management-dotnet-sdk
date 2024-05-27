
# Card Group Response

## Structure

`CardGroupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardGroups` | [`List<CardGroupResponseCardGroupsItems>`](../../doc/models/card-group-response-card-groups-items.md) | Optional | - |
| `CurrentPage` | `int?` | Optional | current page |
| `RowCount` | `int?` | Optional | number of records in current response |
| `TotalPages` | `int?` | Optional | Total pages available |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request id |

## Example (as JSON)

```json
{
  "CurrentPage": 1,
  "RowCount": 1,
  "TotalPages": 1,
  "RequestId": "3cc14d61-8f2a-4d88-cc3c-c53110646a85",
  "CardGroups": [
    {
      "AccountId": 114,
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "ActiveCards": 200,
      "BlockedCards": 104
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


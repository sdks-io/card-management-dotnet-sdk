
# Restriction Search Card Request

## Structure

`RestrictionSearchCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`RestrictionSearchCardRequestFilters`](../../doc/models/restriction-search-card-request-filters.md) | Optional | - |

## Example (as JSON)

```json
{
  "Filters": {
    "ColCoCode": 14,
    "ColCoId": 0,
    "PayerNumber": "PayerNumber0",
    "PayerId": 48,
    "Accounts": {
      "AccountId": 28,
      "AccountNumber": "AccountNumber0"
    }
  }
}
```



# Summary Response

Encapsulates the details of a Summary response.

## Structure

`SummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActiveCards` | `int?` | Optional | Total number of active cards for the given search criteria |
| `BlockedCards` | `int?` | Optional | Total number of cards for the given search criteria that are permanently blocked (Blocked) |
| `CancelledCards` | `int?` | Optional | Total number of cards for the given search criteria that are cancelled (at cancelled status) blocked by customer |
| `ExpiredCards` | `int?` | Optional | Total number of expired cards for the given search criteria |
| `ExpiringCards` | `int?` | Optional | Cards that are active and expiring in X days, X should be configurable |
| `FraudCards` | `int?` | Optional | Totalnumber of Cards in Fraud status for the given search criteria. |
| `NewCards` | `int?` | Optional | Total number of cards in New status for the given search criteria. |
| `RenewalPendingCards` | `int?` | Optional | Total number of Renewal Pending cards for the given search criteria |
| `ReplacedCards` | `int?` | Optional | Cards with status Replaced |
| `TemporaryBlockByCustomer` | `int?` | Optional | Total number of cards for the given search criteria that are temporarily blocked by customer |
| `TemporaryBlockByShell` | `int?` | Optional | Total number of cards for the given search criteria that are temporarily blocked by Shell |
| `TotalCards` | `int?` | Optional | Total number of cards for the given search criteria |

## Example (as JSON)

```json
{
  "ActiveCards": 142,
  "BlockedCards": 238,
  "CancelledCards": 240,
  "ExpiredCards": 238,
  "ExpiringCards": 4
}
```


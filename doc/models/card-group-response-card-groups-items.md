
# Card Group Response Card Groups Items

## Structure

`CardGroupResponseCardGroupsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id for the associated card group |
| `AccountNumber` | `string` | Optional | Account number for the associated card group |
| `AccountShortName` | `string` | Optional | Account short name for the associated card group |
| `ActiveCards` | `int?` | Optional | Total number of active cards for the given search criteria |
| `BlockedCards` | `int?` | Optional | Total number of cards for the given search criteria that are permanently blocked |
| `CancelledCards` | `int?` | Optional | Total number of cards for the given search criteria that are cancelled |
| `CardDeliveryPoint` | `bool?` | Optional | card delivery point enabled or not |
| `CardGroupId` | `int?` | Optional | Id of the card group matching the search criteria. |
| `CardGroupName` | `string` | Optional | Name of the card group matching the search criteria. |
| `CardTypeCode` | `string` | Optional | Card Type Code |
| `CardTypeId` | `int?` | Optional | Card Type Id |
| `CardTypeName` | `string` | Optional | Card Type Name |
| `ExpiredCards` | `int?` | Optional | Total number of expired cards for the given search criteria |
| `ExpiryDate` | `string` | Optional | Expiry date of the card.<br>Format: yyyyMMdd<br>Note: Clients to convert this to appropriate DateTime type. |
| `PrintOnCard` | `bool?` | Optional | PrintOnCard true/false |
| `RenewalPendingCards` | `int?` | Optional | Total number of Renewal Pending Cards for the given search criteria |
| `ReplacedCards` | `int?` | Optional | - |
| `Status` | `string` | Optional | Status of the card group. |
| `TemporaryBlockByCustomer` | `int?` | Optional | Total number of cards for the given search criteria that are temporarily blocked by customer |
| `TemporaryBlockByShell` | `int?` | Optional | Total number of cards for the given search criteria that are temporarily blocked by Shell |
| `TerminatedDate` | `string` | Optional | Terminated Date.<br>Format: yyyyMMdd<br>Note: Clients to convert this to appropriate Date Time type. |
| `TotalCards` | `int?` | Optional | Total number of cards for the given search criteria |

## Example (as JSON)

```json
{
  "AccountId": 1229,
  "AccountNumber": "CZ00000929",
  "AccountShortName": "Dominica South1",
  "ActiveCards": 0,
  "BlockedCards": 1,
  "CancelledCards": 0,
  "CardGroupId": 1234,
  "CardGroupName": "1234T",
  "CardTypeCode": "0123",
  "CardTypeId": 123,
  "CardTypeName": "test",
  "ExpiredCards": 0,
  "ExpiryDate": "20231231",
  "RenewalPendingCards": 5,
  "ReplacedCards": 0,
  "Status": "TERMINATED",
  "TemporaryBlockByCustomer": 0,
  "TemporaryBlockByShell": 0,
  "TerminatedDate": "20210712",
  "TotalCards": 10
}
```


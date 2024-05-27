
# Summary of Bundle Response Data Items

## Structure

`SummaryOfBundleResponseDataItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerId` | `int?` | Optional | Payer Id of the bundles and cards.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the bundles and cards.<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | Account ID of the bundle.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the bundle.<br>Example: GB000000123 |
| `CountOfCardsNotInBundle` | `int?` | Optional | Count of cards that are not part of the bundle in a given account. |
| `CardBundles` | [`List<SummaryOfBundleResponseDataItemsCardBundlesItems>`](../../doc/models/summary-of-bundle-response-data-items-card-bundles-items.md) | Optional | List of Card Bundles |

## Example (as JSON)

```json
{
  "PayerId": 102,
  "PayerNumber": "PayerNumber6",
  "AccountId": 162,
  "AccountNumber": "AccountNumber8",
  "CountOfCardsNotInBundle": 222
}
```


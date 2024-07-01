
# Summaryofbundle Response

## Structure

`SummaryofbundleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `PayerId` | `int?` | Optional | Payer Id of the bundles and cards.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the bundles and cards.<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | - |
| `AccountNumber` | `string` | Optional | Account Number of the bundle.<br>Example: GB000000123 |
| `CountOfCardsNotInBundle` | `int?` | Optional | Count of cards that are not part of the bundle in a given account. |
| `CardBundles` | [`CardBundle`](../../doc/models/card-bundle.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "PayerId": 70,
  "PayerNumber": "PayerNumber2",
  "AccountId": 130,
  "AccountNumber": "AccountNumber4"
}
```


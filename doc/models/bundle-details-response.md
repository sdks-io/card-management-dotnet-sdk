
# Bundle Details Response

## Structure

`BundleDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerId` | `int?` | Optional | Payer Id of the bundles and cards.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the bundles and cards.<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | Account ID of the bundle.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the bundle.<br>Example: GB000000123 |
| `BundleId` | `string` | Optional | unique identifier for the Card Bundle |
| `ExternalBundleId` | `string` | Optional | External system allocated Card Bundle identifier for Card Bundle. |
| `Description` | `string` | Optional | Card Bundle Description. |
| `Pans` | `List<string>` | Optional | List of Card Pans added to the card bundle. |
| `RestrictionCurrencyCode` | `string` | Optional | ISO currency code of the country.<br>Example: GBP |
| `RestrictionCurrencySymbol` | `string` | Optional | Currency symbol of the country.<br>Example: £, $ |
| `Restrictions` | [`BundledRestrictionsList`](../../doc/models/bundled-restrictions-list.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

## Example (as JSON)

```json
{
  "PayerId": 172,
  "PayerNumber": "PayerNumber4",
  "AccountId": 232,
  "AccountNumber": "AccountNumber6",
  "BundleId": "BundleId4"
}
```


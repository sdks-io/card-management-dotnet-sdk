
# Create Bundle Request

## Structure

`CreateBundleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: GB000000123 |
| `ExternalBundleId` | `string` | Optional | Identifier of the bundle in external system.<br>Optional. |
| `Description` | `string` | Optional | A bundle description.<br>Optional. |
| `Cards` | `List<string>` | Optional | List of Card PANs to be added in the bundle.<br>Mandatory.<br>Example: 7002051006629890645<br>When PAN matches with multiple cards, the restriction will be applied on the latest issued card. |
| `Restrictions` | [`BundleRestriction`](../../doc/models/bundle-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "ColCoId": 246,
  "ColCoCode": 4,
  "PayerId": 38,
  "PayerNumber": "PayerNumber2",
  "AccountId": 98
}
```


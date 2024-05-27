
# Update Bundle Request

## Structure

`UpdateBundleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: 123456 |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: 123456 |
| `BundleId` | `string` | Required | Identifier of the bundle in Gateway.<br>Mandatory |
| `RequestAction` | `string` | Required | The value indicates the action to be performed with the request.<br>Mandatory<br>Allowed values:<br>•	Add<br>•	Update<br>•	Remove |
| `Cards` | `List<string>` | Optional | List of Card PANs to be added in the bundle.<br>Mandatory for Add / Remove request action. Ignored for Update action.<br>Example: 7002051006629890645<br>When PAN matches with multiple cards, the restriction will be applied on the latest issued card |
| `UsageRestrictionAction` | `string` | Optional | The value indicates what actions to be performed with respect to usage restrictions on the list of cards being added or removed.<br>Mandatory for Add / Remove request action. Ignored for Update action.<br>Allowed values:<br>•	Update<br>•	None |
| `Restrictions` | [`BundleRestriction`](../../doc/models/bundle-restriction.md) | Optional | - |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Either PayerId or PayerNumber or both must be passed.<br>Example: GB000000123 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: GB000000123 |

## Example (as JSON)

```json
{
  "ColCoId": 26,
  "PayerId": 74,
  "AccountId": 134,
  "BundleId": "BundleId4",
  "RequestAction": "RequestAction4",
  "Cards": [
    "Cards5",
    "Cards6"
  ],
  "UsageRestrictionAction": "UsageRestrictionAction6"
}
```

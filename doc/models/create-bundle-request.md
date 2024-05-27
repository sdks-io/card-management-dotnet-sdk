
# Create Bundle Request

## Structure

`CreateBundleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id  of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1-Philippines<br>5-UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: 123456 |
| `ExternalBundleId` | `string` | Optional | Identifier of the bundle in external system.<br>Optional. |
| `Description` | `string` | Required | A bundle description.<br>Optional. |
| `Cards` | `List<string>` | Required | List of Card PANs to be added in the bundle.<br>Mandatory.<br>Example: 7002051006629890645<br>When PAN matches with multiple cards, the restriction will be applied on the latest issued card. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86-Philippines<br>5-UK |
| `PayerNumber` | `string` | Optional | Payer Number (Ex: GB000000123) of the selected payer.<br>Optional if PayerId is passed else Mandatory |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Either AccountId or AccountNumber or both must be passed.<br>Example: GB000000123 |
| `Restrictions` | [`CreateBundleRequestRestrictions`](../../doc/models/create-bundle-request-restrictions.md) | Optional | Restrictions to be applied on the bundle.<br>Mandatory |

## Example (as JSON)

```json
{
  "ColCoId": 246,
  "PayerId": 38,
  "AccountId": 98,
  "ExternalBundleId": "ExternalBundleId8",
  "Description": "Description4",
  "Cards": [
    "Cards3",
    "Cards2",
    "Cards1"
  ],
  "ColCoCode": 4
}
```


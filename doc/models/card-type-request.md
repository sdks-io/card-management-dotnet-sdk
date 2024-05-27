
# Card Type Request

## Structure

`CardTypeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided. |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer. |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer. |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Optional if AccountNumber is passed else Mandatory. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional if AccountId is passed else Mandatory<br>Example: GB000000124 |
| `IncludeUsageRestrictions` | `bool?` | Optional | Include usage restrictions in the response.<br>Optional field– default value is False.<br>Possible values: True/False |
| `IncludePurchaseCategories` | `bool?` | Optional | Include purchase categories in the response.<br>Optional field– default value is False.<br>Possible values: True/False |

## Example (as JSON)

```json
{
  "ColCoId": 14,
  "ColCoCode": 14,
  "PayerId": 2343,
  "PayerNumber": "GB000000124",
  "AccountId": 343,
  "AccountNumber": "GB000000124"
}
```


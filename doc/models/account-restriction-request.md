
# Account Restriction Request

## Structure

`AccountRestrictionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | Account ID of the customer on which the restrictions will be applied.<br>Optional if AccountNumber is passed, else Mandatory.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the customer on which the restrictions will be applied.<br>Optional if AccountId is passed, else Mandatory.<br>Example: GB000000123 |
| `ResetUsageRestrictions` | `bool?` | Optional | True/False.<br>If true, the usage restrictions applied on the account will be removed.<br>Optional<br>Default: False |
| `UsageRestrictions` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "ColCoId": 138,
  "ColCoCode": 152,
  "PayerId": 186,
  "PayerNumber": "PayerNumber8",
  "AccountId": 246
}
```


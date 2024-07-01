
# Summaryofbundler Request

## Structure

`SummaryofbundlerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id  of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory<br>Example: GB000000123 |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Optional if Account Number is passed else Mandatory<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional if Account Id is passed else Mandatory<br>Example: GB000000123 |
| `BundleId` | `List<string>` | Optional | List of Bundle Id associated with account<br>Optional.<br>When not present all the bundles in the given account will be returned in the response. |

## Example (as JSON)

```json
{
  "ColCoId": 148,
  "ColCoCode": 162,
  "PayerId": 196,
  "PayerNumber": "PayerNumber6",
  "AccountId": 0
}
```


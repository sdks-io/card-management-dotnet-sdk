
# Card Details Request

## Structure

`CardDetailsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | Collecting Company Id  of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1-Philippines<br>5-UK |
| `ColCoId` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoCountryCode` | `string` | Optional | ISO Country code of collecting company |
| `ClientReferenceId` | `string` | Optional | Customer reference number of the card.<br>Optional |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer. |
| `PayerId` | `int?` | Optional | Payer Id (i.e. Customer Id of the Payment of the selected payer. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional if AccountId is passed, else mandatory. |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br>Optional if AccountNumber is passed, else mandatory. |
| `PAN` | `string` | Optional | PAN of the card.<br>Optional if CardId is passed, else Mandatory. |
| `CardId` | `int?` | Optional | Card Id of the card.<br>Optional if PAN is passed, else Mandatory. |
| `TokenTypeID` | `int?` | Optional | Token Type ID for the Card<br>Optional |
| `TokenTypeName` | `string` | Optional | Token Type name for the Card<br>Optional |
| `CreationDate` | `string` | Optional | Card Creation Date time<br>Optional<br>Format: yyyyMMdd |
| `EffectiveDate` | `string` | Optional | Effective date for the Card<br>Optional<br>Format: yyyyMMdd |
| `IncludeBundleDetails` | `bool?` | Optional | When the value is True, API will return bundle Id associated with card in the response, if available.<br>Note: Use ‘Null’ or ‘False’ for optimum performance. A delay in response is expected when set to ‘True’. |
| `IncludeIntermediateStatus` | `bool?` | Optional | A flag which indicates if the response can contain intermediate statuses |
| `IncludeScheduledCardBlocks` | `bool?` | Optional | A flag which indicates if the response can contain scheduled card blocks details |

## Example (as JSON)

```json
{
  "ColCoCode": 154,
  "ColCoId": 140,
  "ColCoCountryCode": "ColCoCountryCode6",
  "ClientReferenceId": "ClientReferenceId2",
  "PayerNumber": "PayerNumber8"
}
```


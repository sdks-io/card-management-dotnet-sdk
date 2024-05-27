
# Bank Account

## Structure

`BankAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | Account Number |
| `BankName` | `string` | Optional | Bank Name |
| `AccountName` | `string` | Optional | Account Name |
| `DateEffective` | `string` | Optional | Bank Account effective date for the payer |
| `DateTerminated` | `string` | Optional | Bank Account terminated date. Default is null |
| `IBAN` | `string` | Optional | Bank Account IBAN for Payer |
| `CurrencyCode` | `string` | Optional | Bank Account currency ISO code. |
| `CurrencySymbol` | `string` | Optional | Bank Account currency Symbol. |
| `CountryISOCode` | `string` | Optional | Bank Account Country ISO Code |
| `Country` | `string` | Optional | Bank Account Country Name<br>1-Austria<br>2-Belgium<br>3-Bulgaria<br>4-Croatia<br>5-Czech Republic |
| `SortCode` | `string` | Optional | Payer bank Sort Code |
| `SwiftCode` | `string` | Optional | Payer Bank Swift Code |
| `BankType` | `string` | Optional | Bank Type Id and Description |

## Example (as JSON)

```json
{
  "AccountNumber": "45346346443",
  "BankName": "swiss",
  "AccountName": "ARIM SERVIS",
  "DateEffective": "20200808",
  "IBAN": "CZ6508000000192000145399",
  "CurrencyCode": "EUR",
  "CurrencySymbol": "€",
  "CountryISOCode": "DE",
  "Country": "Germany",
  "SortCode": "0100",
  "SwiftCode": "KOMBCZPPXXX",
  "BankType": "1-Test",
  "DateTerminated": "DateTerminated0"
}
```



# Account Response Accounts Items

## Structure

`AccountResponseAccountsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountFullName` | `string` | Optional | Account Full Name |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `BestOfIndicator` | `bool?` | Optional | Best of Indicator of the Pricing customer/account configured. |
| `BillingFrequencyType` | `string` | Optional | Billing/Invoice frequency. The frequency in which the transactions will be considered for invoicing in a bulling run<br>E.g.:<br>1	Daily (all days)<br>2	Daily (only working days)<br>3	Weekly - Monday<br>4	Weekly – Tuesday<br>Etc. |
| `BillingFrequencyTypeId` | `int?` | Optional | Billing/Invoice frequency Identifier. Indicates the frequency in which the transactions will be considered for invoicing in a bulling run |
| `BillingRunFrequency` | `string` | Optional | Frequency at which the billing process is triggered. E.g.:<br>1	Daily (all days)<br>2	Daily (only working days)<br>3	Weekly - Monday<br>4	Weekly – Tuesday<br>Etc. |
| `BillingRunFrequencyTypeId` | `int?` | Optional | Frequency at which the billing process is triggered.<br>E.g.: 1, 2, 3, etc. |
| `ColCoCountryCode` | `string` | Optional | The 2-character ISO Code for the customer and card owning country. |
| `CurrencyCode` | `string` | Optional | ISO code of customer currency. |
| `CurrencySymbol` | `string` | Optional | € |
| `Day1Run` | `int?` | Optional | The first day in a month when the billing should run in case of multiple billing runs configured with in a single month |
| `Day2Run` | `int?` | Optional | The second day in a month when the billing should run in case of multiple billing runs configured with in a single month |
| `Day3Run` | `int?` | Optional | The third day in a month when the billing should run in case of multiple billing runs configured with in a single month |
| `Day4Run` | `int?` | Optional | The fourth day in a month when the billing should run in case of multiple billing runs configured with in a single month |
| `FrequencyType` | `string` | Optional | Frequency type unit id & description<br>E.g.:<br>1 - Daily<br>2 - Weekly<br>3 - Monthly<br>4 - Invoicing<br>6 - Calendar quarter |
| `GrossAmount` | `double?` | Optional | Gross amount in customer currency. |
| `InternationalPOSLanguageCode` | `string` | Optional | POS international language code |
| `InternationalPOSLanguageID` | `int?` | Optional | POS international language ID |
| `InvoiceAccountID` | `int?` | Optional | The Account ID of the account on which the invoice is generated. |
| `InvoiceAccountNumber` | `string` | Optional | The Account Number of the account on which the invoice is generated. |
| `InvoiceAccountShortName` | `string` | Optional | The Account Short Name of the account on which the invoice is generated. |
| `InvoiceDistributionMethods` | [`List<InvoiceDistributionMethod>`](../../doc/models/invoice-distribution-method.md) | Optional | - |
| `IsInternational` | `bool?` | Optional | Whether the account is international. |
| `IsInvoicePoint` | `bool?` | Optional | Whether the account is an invoice point. |
| `LastModifiedDate` | `string` | Optional | Account last modified date and time |
| `LocalCurrencyCode` | `string` | Optional | ISO code of customer currency. |
| `LocalCurrencySymbol` | `string` | Optional | Customer currency symbol. |
| `LocalPOSLanguageCode` | `string` | Optional | POS local language code |
| `LocalPOSLanguageID` | `int?` | Optional | POS local language ID |
| `NetAmount` | `double?` | Optional | Net amount in customer currency. |
| `OutstandingBalance` | `double?` | Optional | Outstanding balance in customer currency. |
| `PaidAmount` | `double?` | Optional | Amount paid in customer currency. |
| `Status` | `string` | Optional | Account Status |
| `StatusReason` | `string` | Optional | Account status change reason id-description for the Status Reason, if any |
| `TotalActiveCardGroups` | `int?` | Optional | Total number of active card groups under the account |
| `TotalActiveCards` | `int?` | Optional | Total number of active cards under the account. |
| `TotalBlockedCards` | `int?` | Optional | Total number of cards under the account that are permanently blocked |
| `TotalCancelledCards` | `int?` | Optional | Total number of cards under the account that are cancelled |
| `TotalCards` | `int?` | Optional | Total number of cards under the account. |
| `TotalExpiredCards` | `int?` | Optional | Total number of expired cards under the account. |
| `TotalFraudCards` | `int?` | Optional | Total number of cards in Fraud status. |
| `TotalNewCards` | `int?` | Optional | Total number of cards in “New” status. |
| `TotalRenewalPendingCards` | `int?` | Optional | Total number of Renewal Pending account under the payer |
| `TotalReplacedCards` | `int?` | Optional | Total number of cards under the account with status as “Replaced” |
| `TotalTemporaryBlockCardsByCustomer` | `int?` | Optional | Total number of cards under the account that are temporarily blocked by customer. |
| `TotalTemporaryBlockCardsByShell` | `int?` | Optional | Total number of cards under the account that are temporarily blocked by Shell. |
| `VATAmount` | `double?` | Optional | VAT amount in customer currency. |
| `IsPartnerCard` | `int?` | Optional | The account / sub-account is partner card account or not.<br>Possible values (1= Non-PC account, 2= PC account, 3= PC Payer with Card Types, 4= PC Payer)<br>Note: A partner card account is assumed to have only partner card card-types associated |
| `TollsCustomerId` | `string` | Optional | Customer id in e-TM system |
| `TollsColcoCountryTypeId` | `string` | Optional | Colco country type id in e-TM system |
| `Contracts` | [`List<CustomerContract>`](../../doc/models/customer-contract.md) | Optional | - |
| `IsConsortiumMember` | `string` | Optional | true |

## Example (as JSON)

```json
{
  "AccountFullName": "CI TEST_Update20 New updated",
  "AccountId": 123,
  "AccountNumber": "DE00000008",
  "AccountShortName": "CI TEST_Update20",
  "BillingFrequencyType": "Monthly - 3rd",
  "BillingFrequencyTypeId": 1,
  "BillingRunFrequency": "Weekly - Monday",
  "BillingRunFrequencyTypeId": 1,
  "ColCoCountryCode": "14",
  "CurrencyCode": "14",
  "CurrencySymbol": "EUR",
  "Day1Run": 1,
  "Day2Run": 31,
  "Day3Run": 2,
  "Day4Run": 3,
  "FrequencyType": "Daily",
  "GrossAmount": 1232,
  "InternationalPOSLanguageCode": "deu",
  "InternationalPOSLanguageID": 1,
  "InvoiceAccountID": 9,
  "InvoiceAccountNumber": "DE00000008",
  "InvoiceAccountShortName": "BCI TEST_Update20",
  "LastModifiedDate": "20240131 11:12:34",
  "LocalCurrencyCode": "EUR",
  "LocalCurrencySymbol": "€",
  "LocalPOSLanguageCode": "deu",
  "LocalPOSLanguageID": 1,
  "NetAmount": 3434,
  "OutstandingBalance": 4354,
  "PaidAmount": 4343,
  "Status": "Blocked",
  "StatusReason": "3 - Customer Request",
  "TotalActiveCardGroups": 198,
  "TotalActiveCards": 544,
  "TotalBlockedCards": 121,
  "TotalCancelledCards": 168,
  "TotalCards": 10966,
  "TotalExpiredCards": 1000,
  "TotalFraudCards": 8,
  "TotalNewCards": 2,
  "TotalRenewalPendingCards": 0,
  "TotalReplacedCards": 20,
  "TotalTemporaryBlockCardsByCustomer": 9,
  "TotalTemporaryBlockCardsByShell": 2,
  "VATAmount": 2322,
  "IsPartnerCard": 1,
  "TollsCustomerId": "332",
  "TollsColcoCountryTypeId": "14",
  "BestOfIndicator": false
}
```


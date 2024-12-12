
# Payer Details

## Structure

`PayerDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting company id of the customer. |
| `ColCoCode` | `int?` | Optional | Collecting company code of the customer. |
| `CountryCode` | `string` | Optional | ISO code of the customer country. |
| `Country` | `string` | Optional | Country of the customer |
| `PayerId` | `int?` | Optional | Payer id of the customer |
| `PayerNumber` | `string` | Optional | Payer Number of the customer |
| `PayerFullName` | `string` | Optional | Full Name of the Payer |
| `PayerShortName` | `string` | Optional | Short name of the payer |
| `PayerGroupId` | `int?` | Optional | Payer Group Id |
| `AmountDue` | `double?` | Optional | Invoiced amount and due for payment from the last SOA. |
| `AmountOverdue` | `double?` | Optional | Invoiced amount and overdue for payment from the last SOA. |
| `AmountNotOverdue` | `double?` | Optional | Invoiced amount and not overdue for payment from the last SOA. |
| `OutstandingBalance` | `double?` | Optional | Current outstanding balance amount from the last SOA. |
| `UnallocatedPayment` | `double?` | Optional | Unallocated payment.<br>When negative, indicates overdue amount from the last SOA. |
| `SOACurrencyCode` | `string` | Optional | Currency ISO code |
| `SOACurrencySymbol` | `string` | Optional | Currency symbol |
| `SOACreditLimitCurrencyCode` | `string` | Optional | Currency ISO code |
| `SOACreditLimitCurrencySymbol` | `string` | Optional | Currency symbol |
| `LastPaymentCurrencyCode` | `string` | Optional | Currency ISO code |
| `LastPaymentCurrencySymbol` | `string` | Optional | currency symbol |
| `LastPaymentAmount` | `double?` | Optional | Latest payment amount for the requested payer. |
| `LastPaymentDate` | `string` | Optional | Latest payment date for the requested payer. |
| `SOALastPaymentAmount` | `double?` | Optional | Last payment amount in statement of account for the requested payer. |
| `SOALastPaymentDate` | `string` | Optional | Last payment date in statement of account for the requested payer. |
| `CurrencyCode` | `string` | Optional | Currency ISO code |
| `CurrencySymbol` | `string` | Optional | Currency Symbol |
| `ColCoCountryCode` | `string` | Optional | The 2-character ISO Code for the customer and card owning country. |
| `LocalCurrencyCode` | `string` | Optional | Currency ISO code of the local country. |
| `LocalCurrencySymbol` | `string` | Optional | Currency Symbol of the local country |
| `LocalCurrencyExchangeRate` | `double?` | Optional | Exchange rate from OU base currency to local currency. |
| `LocalCurrencyExchangeRateSoA` | `double?` | Optional | Exchange rate from SoA credit limit currency to local currency |
| `BillingFrequencyTypeId` | `int?` | Optional | Billing/Invoice frequency Identifier. Indicates the frequency in which the transactions will be considered for invoicing in a bulling run<br>E.g.: 1, 2, 3, etc. |
| `BillingFrequencyType` | `string` | Optional | Billing/Invoice frequency. The frequency in which the transactions will be considered for invoicing in a bulling run<br>E.g.:<br>1    Daily (all days)<br>2    Daily (only working days)<br>3    Weekly - Monday<br>4    Weekly – Tuesday<br>Etc. |
| `BillingRunFrequencyTypeId` | `int?` | Optional | Frequency at which the billing process is triggered.<br>E.g.: 1, 2, 3, etc. |
| `BillingRunFrequnecy` | `string` | Optional | Frequency at which the billing process is triggered.E.g.:<br>1    Daily (all days)<br>2    Daily (only working days)<br>3    Weekly - Monday<br>4    Weekly – Tuesday<br>Etc. |
| `Day1Run` | `int?` | Optional | The first day in a month when the billing should run in case of multiple billing runs configured with in a single month. |
| `Day2Run` | `int?` | Optional | The second day in a month when the billing should run in case of multiple billing runs configured with in a single month. |
| `Day3Run` | `int?` | Optional | The third day in a month when the billing should run in case of multiple billing runs configured with in a single month. |
| `Day4Run` | `int?` | Optional | The fourth day in a month when the billing should run in case of multiple billing runs configured with in a single month. |
| `InvoiceDistributionMethods` | [`List<InvoiceDistributionMethod>`](../../doc/models/invoice-distribution-method.md) | Optional | - |
| `OutputType` | `string` | Optional | Invoice output type (Id-Description)<br>E.g.:<br>1-PDF<br>6-Print |
| `InvoiceAccountID` | `int?` | Optional | The Account ID of the account on which the invoice is generated. |
| `InvoiceAccountNumber` | `string` | Optional | The Account Number of the account on which the invoice is generated. |
| `InvoiceAccountShortName` | `string` | Optional | The Account Short Name of the account on which the invoice is generated. |
| `BestOfIndicator` | `bool?` | Optional | Best of Indicator of the Pricing customer/account configured.<br>**Default**: `false` |
| `IsInternational` | `bool?` | Optional | Whether the account is international.<br>**Default**: `false` |
| `TotalAccounts` | `int?` | Optional | Total number of accounts under the payer. |
| `TotalActiveAccounts` | `int?` | Optional | Total number of active accounts under the payer. |
| `TotalCards` | `int?` | Optional | Total number of cards under the payer. |
| `TotalActiveCards` | `int?` | Optional | Total number of active cards under the payer. |
| `TotalBlockedCards` | `int?` | Optional | Total number of cards under the payer that are permanently blocked |
| `TotalCancelledCards` | `int?` | Optional | Total number of cards under the payer that are cancelled |
| `TotalExpiredCards` | `int?` | Optional | Total number of expired cards under the payer. |
| `TotalRenewalPendingCards` | `int?` | Optional | Total number of Renewal Pending cards under the payer. |
| `TotalReplacedCards` | `int?` | Optional | Total number of cards under the payer with status as “Replaced |
| `TotalTemporaryBlockCardsByCustomer` | `int?` | Optional | Total number of cards under the payer that are temporarily blocked by customer. |
| `TotalTemporaryBlockCardsByShell` | `int?` | Optional | Total number of cards under the payer that are temporarily blocked by Shell. |
| `TotalNewCards` | `int?` | Optional | Total number of cards in “New” status |
| `TotalFraudCards` | `int?` | Optional | Total number of cards in Fraud status |
| `TotalBlockedAccounts` | `int?` | Optional | Total number of accounts in Blocked status |
| `TotalCancelledAccounts` | `int?` | Optional | Total number of accounts in Cancel status |
| `PayerTradingName` | `string` | Optional | Trading name for the Payer |
| `Status` | `string` | Optional | Payer current status id and description<br>e.g. (Id – Description):<br>1-Active<br>2-Requested from UTA<br>3-Awaiting embossing<br>4-Manufactured<br>5-Awaiting despatch |
| `BillingLanguage` | `string` | Optional | Payer Billing Language id and description |
| `LegalEntity` | `string` | Optional | Legal entity id and description of the Payer |
| `DateEstablished` | `string` | Optional | Payer/Company Established Date. |
| `CustomerClassification` | `string` | Optional | Payer/Company Classification id and description |
| `IndustryClass` | `string` | Optional | Payer/Company Industry class id and description |
| `MarketingSegmentation` | `string` | Optional | Marketing Segmentation id and description |
| `LineOfBusiness` | `string` | Optional | Payer/Company Line of Business Id and Description |
| `PrintCreditLimit` | `bool?` | Optional | Is Credit Limit printed on the statement of account: True/False<br>If True Credit Limit is printed on invoice/SOA<br>**Default**: `false` |
| `CardGroupType` | `string` | Optional | Card Group Type configured for Payer<br>e.g. (Id – Description):<br>1-Horizontal only<br>2-Vertical only<br>3-Both |
| `RenewCards` | `bool?` | Optional | If set to True cards will be automatically renewed on expiry<br>**Default**: `false` |
| `AllowSelectPIN` | `bool?` | Optional | If set to True then Self Select PIN is allowed for Payer<br>**Default**: `false` |
| `UseFleetPIN` | `bool?` | Optional | If set to True then Fleet PIN is applied for the cards directly under payer |
| `VATRegNumber` | `string` | Optional | Payer/Company VAT registration number. |
| `VATRegNumber2` | `string` | Optional | Payer/Company VAT registration number 2. |
| `RegistrationNumber` | `string` | Optional | Payer/Company Registration number |
| `RegistrationNumber2` | `string` | Optional | Payer/Company Registration number2 |
| `SalesLedgerBalance` | `double?` | Optional | Sales Ledger Balance (Billed) |
| `Exposure` | `double?` | Optional | Exposure after guarantee |
| `OutstandingDebt` | `double?` | Optional | Total outstanding debt (including billed and unbilled sales and fee items) |
| `AvailableCredit` | `double?` | Optional | The available credit for the payer.<br>This is the credit limit minus the outstanding debt. |
| `Band` | `string` | Optional | Band Id and Description of the Payer in Card Platform.<br>e.g. (Id – Description):<br>1-Platinum<br>2-Gold<br>3-Silver<br>4-Bronze |
| `GlobalCustomerReferenceId` | `string` | Optional | Global Customer reference id configured in card platform for Payer (Same as Payer Group) |
| `CreditLimit` | `double?` | Optional | Payment Credit limit of Payer. |
| `CreditLimitInCustomerCurrency` | `double?` | Optional | Credit limit in Customer currency.<br>Note: For currency details refer the parameters CurrencyCode & CurrencySymbol in the PayerDetail response. |
| `BillingCurrencyCode` | `string` | Optional | Customer Billing currency ISO code. |
| `BillingCurrencySymbol` | `string` | Optional | Customer Billing currency Symbol. |
| `PaymentMethod` | `string` | Optional | Payment method Id and Description as configured for Payer in Card Platform |
| `PaymentTerms` | `string` | Optional | Payment terms Id and Description as configured for Payer in Card Platform |
| `TemporaryCreditLimitIncrease` | `double?` | Optional | Temporary Credit limit increase value |
| `TemporaryCreditLimitIncreaseInCustomerCurrency` | `double?` | Optional | Temporary Credit limit increase value |
| `TemporaryCreditLimitExpiryDate` | `string` | Optional | Temporary Credit limit expiry date |
| `PayerBankAccount` | [`List<BankAccount>`](../../doc/models/bank-account.md) | Optional | - |
| `CardDeliveryAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `CorrespondanceAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `HasActiveVolBasedPricing` | `bool?` | Optional | True, if the payer is setup for volume-based pricing and is active on the current date, else false.<br><br>This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null. |
| `HasActiveVolBasedBonus` | `bool?` | Optional | True, if the payer is setup for volume-based bonus and is active on the current date, else false.<br>This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null. |
| `HasActiveVolBasedAssociationBonus` | `bool?` | Optional | True, if the payer is setup for volume-based association bonus and is active on the current date, else false.<br>This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null. |
| `FinanceCurrency` | [`FinanceCurrency2`](../../doc/models/finance-currency-2.md) | Optional | - |
| `TollsCustomerId` | `string` | Optional | Customer id in e-TM system<br>This field will have value only when ReturnTollsCustomerId is set to true in the request else set to null or empty. |
| `TollsColcoCountryTypeId` | `string` | Optional | String    Colco country type id in e-TM system<br>This field will have value only when ReturnTollsCustomerId is set to true in the request else set to null or empty. |
| `Contracts` | [`List<CustomerContract>`](../../doc/models/customer-contract.md) | Optional | - |

## Example (as JSON)

```json
{
  "ColCoId": 14,
  "ColCoCode": 14,
  "CountryCode": "DE",
  "Country": "Germany",
  "PayerId": 12345,
  "PayerNumber": "DE000000123",
  "PayerFullName": "ABC Company",
  "PayerShortName": "ABC",
  "PayerGroupId": 456,
  "AmountDue": 1500,
  "AmountOverdue": 450,
  "AmountNotOverdue": 4546.76,
  "OutstandingBalance": 456,
  "UnallocatedPayment": 123,
  "SOACurrencyCode": "EUR",
  "SOACurrencySymbol": "€",
  "SOACreditLimitCurrencyCode": "EUR",
  "SOACreditLimitCurrencySymbol": "€",
  "LastPaymentCurrencyCode": "EUR",
  "LastPaymentCurrencySymbol": "€",
  "LastPaymentAmount": 5465,
  "LastPaymentDate": "20230405",
  "SOALastPaymentAmount": 45443,
  "SOALastPaymentDate": "20230805",
  "CurrencyCode": "EUR",
  "CurrencySymbol": "€",
  "ColCoCountryCode": "DE",
  "LocalCurrencyCode": "EUR",
  "LocalCurrencySymbol": "€",
  "LocalCurrencyExchangeRate": 1.45,
  "LocalCurrencyExchangeRate_SoA": 1.2,
  "BillingFrequencyTypeId": 1,
  "BillingFrequencyType": "weekly",
  "BillingRunFrequencyTypeId": 1,
  "BillingRunFrequnecy": "weekly",
  "Day1Run": 0,
  "Day2Run": 0,
  "Day3Run": 0,
  "Day4Run": 0,
  "OutputType": "PDF",
  "InvoiceAccountID": 12345,
  "InvoiceAccountNumber": "1234567",
  "InvoiceAccountShortName": "Test Account",
  "BestOfIndicator": false,
  "IsInternational": false,
  "TotalAccounts": 5,
  "TotalActiveAccounts": 4,
  "TotalCards": 567,
  "TotalActiveCards": 560,
  "TotalBlockedCards": 6,
  "TotalCancelledCards": 0,
  "TotalExpiredCards": 1,
  "TotalRenewalPendingCards": 0,
  "TotalReplacedCards": 0,
  "TotalTemporaryBlockCardsByCustomer": 0,
  "TotalTemporaryBlockCardsByShell": 0,
  "TotalNewCards": 0,
  "TotalBlockedAccounts": 0,
  "TotalCancelledAccounts": 0,
  "PayerTradingName": "ABC Company",
  "Status": "Active",
  "BillingLanguage": "1-German",
  "LegalEntity": "20-Unlimited Corporation",
  "DateEstablished": "19880504",
  "CustomerClassification": "3-10049 Domestic",
  "IndustryClass": "4-Growing of sugar cane",
  "MarketingSegmentation": "1-National CRT",
  "LineOfBusiness": "1-CRT",
  "PrintCreditLimit": false,
  "CardGroupType": "1-Horizontal only",
  "RenewCards": false,
  "AllowSelectPIN": false,
  "VATRegNumber": "4534545",
  "VATRegNumber2": "45345545",
  "RegistrationNumber": "453543",
  "RegistrationNumber2": "35435",
  "SalesLedgerBalance": 0,
  "Exposure": 0,
  "OutstandingDebt": 0,
  "AvailableCredit": 0,
  "Band": "Gold",
  "GlobalCustomerReferenceId": "1234",
  "CreditLimit": 3434,
  "BillingCurrencyCode": "EUR",
  "BillingCurrencySymbol": "€",
  "PaymentMethod": "Incoming - Bank Transfer",
  "PaymentTerms": "0 days after invoice",
  "TemporaryCreditLimitIncrease": 0,
  "TemporaryCreditLimitIncreaseInCustomerCurrency": 0,
  "TemporaryCreditLimitExpiryDate": "20230504",
  "TollsCustomerId": "2332",
  "TollsColcoCountryTypeId": "33"
}
```


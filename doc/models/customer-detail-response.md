
# Customer Detail Response

## Structure

`CustomerDetailResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the selected account. |
| `AccountName` | `string` | Optional | Account Name of the selected account. |
| `AccountNumber` | `string` | Optional | Account Number of the selected account. |
| `AccountShortName` | `string` | Optional | Short name of the customer. |
| `AccountTradingName` | `string` | Optional | Trading name of the customer |
| `AllowFleetIdInput` | `bool?` | Optional | True/False.<br>When false, users should not be allowed to enable Fleet Id prompt option while ordering cards under this account. |
| `Band` | `string` | Optional | Band Id and Description of the Payer in Card Platform<br>e.g. (Id – Description):<br>1-Platinum<br>2-Gold<br>3-Silver<br>4-Bronze |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `CardGroupPosition` | `string` | Optional | Card group position at –<br>•    Payer – Payer level<br>•    Account – Account level |
| `CorrespondenceAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `DeliveryAddresses` | [`List<DeliveryAddresses>`](../../doc/models/delivery-addresses.md) | Optional | - |
| `FleetPin` | `bool?` | Optional | Is Fleet Pin optional enabled for the selected account |
| `FullName` | `string` | Optional | Full Name of the customer |
| `InvoiceCustomerId` | `int?` | Optional | Customer Id of the Invoice Point of the account |
| `InvoiceCustomerShortName` | `string` | Optional | Short Name of the Invoice Point of the account |
| `IsInvoicePoint` | `bool?` | Optional | Whether the account is an invoice point. |
| `MarketingSegmentation` | `string` | Optional | Marketing Segmentation id and description<br>e.g. (Id – Description):<br>1-National CRT<br>2-International CRT & IKAs<br>3-Small Customers<br>4-National/International Fleet/IKA |
| `VATNumber` | `string` | Optional | VAT Registration Number of Customer |
| `PayerId` | `int?` | Optional | Payer Id of the selected account. |
| `PayerName` | `string` | Optional | Payer Name of the selected account. |
| `PayerNumber` | `string` | Optional | Payer Number of the selected account. |
| `SelfSelectedPin` | `bool?` | Optional | Is Self-selected Pin enabled for the account |
| `Status` | `string` | Optional | Payer current status id and description<br>e.g. (Id – Description):<br>1-Active<br>2-Requested from UTA<br>3-Awaiting embossing<br>4-Manufactured<br>5-Awaiting despatch |
| `DefaultPINAdviceType` | `int?` | Optional | Default PIN AdviceType of the customer.<br>Possible Values:<br><br>1. Paper<br>2. Email<br>3. SMS<br>4. None |
| `PINAdviceTypes` | [`List<PINAdviceTypes>`](../../doc/models/pin-advice-types.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request id |
| `PINChangeAllowedByCardholder` | `bool?` | Optional | PIN change allowed for card holder or not. |
| `PINChangeAllowedFromFleetPIN` | `bool?` | Optional | PIN change allowed from fleetpin or not. |

## Example (as JSON)

```json
{
  "AccountId": 1227,
  "AccountName": "5.11.3 DE",
  "AccountNumber": "DE00001067",
  "AccountShortName": "5.11.3 DE",
  "AccountTradingName": "5.11.3 DE",
  "Band": "2 - Gold",
  "FullName": "5.11.3 DE",
  "InvoiceCustomerId": 1227,
  "InvoiceCustomerShortName": "5.11.3 DE",
  "MarketingSegmentation": "4 - National/International Fleet/IKA",
  "VATNumber": "PH6578900900",
  "PayerId": 1227,
  "PayerName": "5.11.3 DE",
  "PayerNumber": "DE00001067",
  "Status": "1 - Active",
  "DefaultPINAdviceType": 1,
  "RequestId": "908358e3-03ca-4aef-93b2-37586b859171"
}
```


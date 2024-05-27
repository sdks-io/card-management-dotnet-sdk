
# Card Type Response Customer Card Types Items

## Structure

`CardTypeResponseCustomerCardTypesItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CanHavePIN` | `bool?` | Optional | True/False – Whether the cards of this card type can have PIN. |
| `CardTypeId` | `int?` | Optional | Card Type Id |
| `CardTypeName` | `string` | Optional | Card Type Name. |
| `ColCoCurrencyCode` | `string` | Optional | ISO currency code of the country. |
| `CustomerCardTypeId` | `int?` | Optional | Customer Card Type Id |
| `DayTimeRestrictions` | [`CardDayTimeRestrictions`](../../doc/models/card-day-time-restrictions.md) | Optional | - |
| `DefaultPurchaseCategoryId` | `int?` | Optional | Default Purchase category of the card type. |
| `EmbossAccountName` | `string` | Optional | Default Name to be embossed on the card |
| `ExpiryPeriod` | `int?` | Optional | Default Expiry period. |
| `IsCRT` | `bool?` | Optional | True/False – Wether it is a CRT Card type or not. |
| `IsFleet` | `bool?` | Optional | True/False – Whether it is it a Fleet Card typeor not. |
| `IsInternational` | `bool?` | Optional | True/False – Whether it is an International Card type or not. |
| `IsNational` | `bool?` | Optional | True/False – Whether it is a National Card type or not. |
| `IsPartnerSitesIncluded` | `bool?` | Optional | True/False – Whether this card type is allowed in partner Stations. |
| `IsShellSitesOnly` | `bool?` | Optional | True/False – Whether it is only allowed in Shell Stations or not. |
| `IsVirtual` | `bool?` | Optional | True/False - Whether it is a Virtual Card type or not. |
| `IsVisibleToCustomers` | `bool?` | Optional | True/False – Whether this card type is visible in SFH for card ordering. |
| `IsActive` | `bool?` | Optional | Whether card type is active or not. |
| `IsCardAvailableForDownload` | `bool?` | Optional | - |
| `IsCardVisibleToCustomers` | `bool?` | Optional | - |
| `PANLength` | `int?` | Optional | PAN Length |
| `PurchaseCategories` | [`List<PurchaseCategories>`](../../doc/models/purchase-categories.md) | Optional | - |
| `TokenTypeId` | `int?` | Optional | Token type identifier. |
| `TokenTypeName` | `string` | Optional | Token Type Name. |
| `UsageRestrictions` | [`CardUsageRestrictions`](../../doc/models/card-usage-restrictions.md) | Optional | - |
| `EMVContactless` | `bool?` | Optional | Is Europay, MasterCard, and Visa Contactless enabled or not. |
| `RFID` | `bool?` | Optional | Whether the card type is enabled for RFID (Radio Frequency Identification) |
| `PINChangeSupported` | `bool?` | Optional | PIN change supported or not. |
| `RequirePIN` | `bool?` | Optional | Whether a PIN is mandatory for the cards of this card type. |
| `OfflinePIN` | `bool?` | Optional | Whether offline PIN is enabled or not. |
| `IsDefault` | `bool?` | Optional | Whether card type is default or not. |
| `ApplicationsToShowNPIITokens` | `bool?` | Optional | True/False<br>Note: ApplicationsToShowNPIITokens will be set as ‘True’ when the accessing application API key exists in the “ApplicationsToShowNPIITokens” card type configuration else “False”. |
| `MediumTypeID` | `int?` | Optional | Id of the medium type identifier.<br>Example: 1,2,4<br><br>Full list below:<br>1 - Fuel Card<br>2 - Fuel Card with EV<br>3 - EV only<br>4 - Fuel Card and Key Fob<br>5 - Key Fob<br>6 - Virtual Card<br>7 - NPII Token<br>8 – Smartpay Token |
| `MediumType` | `string` | Optional | Name of the medium type identifier.<br>Example: Fuel Card, Fuel Card with EV, Key Fob<br><br>Full list below:<br>1 - Fuel Card<br>2 - Fuel Card with EV<br>3 - EV only<br>4 - Fuel Card and Key Fob<br>5 - Key Fob<br>6 - Virtual Card<br>7 - NPII Token<br>8 - Smartpay Token |
| `ColCoCurrencySymbol` | `string` | Optional | Currency symbol of the country. |

## Example (as JSON)

```json
{
  "CardTypeId": 228,
  "CardTypeName": "DE-Kleinfhzg. International Multi",
  "ColCoCurrencyCode": "EUR",
  "CustomerCardTypeId": 1576,
  "DefaultPurchaseCategoryId": 127,
  "EmbossAccountName": "5.11.3 DE",
  "ExpiryPeriod": 48,
  "PANLength": 19,
  "TokenTypeId": 160,
  "TokenTypeName": "DE FLT INT MUL - CHIP",
  "MediumTypeID": 1,
  "MediumType": "Fuel Card",
  "ColCoCurrencySymbol": "£",
  "CanHavePIN": false
}
```


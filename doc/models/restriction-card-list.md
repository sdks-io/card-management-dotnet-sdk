
# Restriction Card List

## Structure

`RestrictionCardList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardId` | `int?` | Optional | Unique Card Id |
| `PAN` | `string` | Optional | Card PAN |
| `ExpiryDate` | `string` | Optional | Expiry date of the card<br>Format: yyyyMMdd<br>Note: Clients to convert this to appropriate DateTime type. |
| `StatusId` | `int?` | Optional | Card Status id |
| `StatusDescription` | `string` | Optional | Status Description (Active, Temporarily Blocked, etc.,) |
| `DriverName` | `string` | Optional | Driver name<br>Example:  ANDREW GILBERRY |
| `VRN` | `string` | Optional | Vehicle registration number<br>Example: MV65YLH |
| `IssueDate` | `string` | Optional | Issue date<br>Format: yyyyMMdd<br>Note: Clients to convert this to appropriate DateTime type. |
| `IssueNumber` | `int?` | Optional | Issue Number |
| `AccountId` | `int?` | Optional | Account ID<br>Example: 29484 |
| `AccountNumber` | `string` | Optional | Account Number<br>Example: GB99215176 |
| `AccountName` | `string` | Optional | Account Name<br>Example: MATTHEW ALGIE & COMPANY LIMITED |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `CurrencyCode` | `string` | Optional | ISO currency code of the Customer Currency<br>Example: GBP |
| `ColCoCurrencyCode` | `string` | Optional | ISO currency code of the country.<br>Example: GBP |
| `ColCoCurrencySymbol` | `string` | Optional | Currency symbol of the country.<br>Example: £, $ |
| `RestrictionCurrencyCode` | `string` | Optional | ISO currency code of the country.<br>Example: GBP |
| `RestrictionCurrencySymbol` | `string` | Optional | Currency symbol of the country.<br>Example: £, $ |
| `PurchaseCategoryId` | `string` | Optional | Purchase category Id<br>Example: 123, 124, etc., |
| `PurchaseCategoryCode` | `string` | Optional | Purchase category code<br>Example:<br>0 - All Fuels (without VP) and Lubricants<br>1 - FuelSave only<br>2 - FuelSave and Lubricants<br>3 - No Restrictions<br>4 - VP and FuelSave<br>5 - Diesel ONLY<br>6 - Diesel and Lubricants<br>7 - VP and Lubricants<br>8 - VP and FuelSave and Lubricants |
| `PurchaseCategoryName` | `string` | Optional | Purchase category name<br>Example:<br>0 - All Fuels (without VP) and Lubricants<br>1 - FuelSave only<br>2 - FuelSave and Lubricants<br>3 - No Restrictions<br>4 - VP and FuelSave<br>5 - Diesel ONLY<br>6 - Diesel and Lubricants<br>7 - VP and Lubricants<br>8 - VP and FuelSave and Lubricants |
| `IsSuperseded` | `bool?` | Optional | True/False<br>True if a new card is issued with the same PAN, else false |
| `IsVirtualCard` | `bool?` | Optional | True/False<br>True if it is a virtual card, else false |
| `IsNational` | `bool?` | Optional | True/False<br>True if it is a national card, else false |
| `IsInternational` | `bool?` | Optional | True/False<br>True if it is an international card, else false |
| `IsCRT` | `bool?` | Optional | True/False<br>True if it is a CRT type card, else false |
| `IsFleet` | `bool?` | Optional | True/False<br>True if it is a Fleet type card, else false |
| `IsShellSitesOnly` | `bool?` | Optional | True/False<br>True if it is only allowed at Shell sites, else false |
| `IsPartnerSitesIncluded` | `bool?` | Optional | True/False<br>True if it is allowed at all partner sites, else false |
| `CardTypeId` | `int?` | Optional | Card Type ID<br>Example Id & Description:<br>1 - Philippines CRT 7077861<br>2- Philippines Fleet 7002861<br>5-SHELL FLEET- HONG KONG 7002821<br>6-SHELL NHF- HONG KONG 7002821<br>7-SHELL CRT- HONG KONG 7077821 |
| `CardTypeCode` | `string` | Optional | ISO code of the card i.e. first 7 digits of the PAN |
| `CardTypeName` | `string` | Optional | Card Type Name<br>Example Id & Description:<br>1 - Philippines CRT 7077861<br>2- Philippines Fleet 7002861<br>5-SHELL FLEET- HONG KONG 7002821<br>6-SHELL NHF- HONG KONG 7002821<br>7-SHELL CRT- HONG KONG 7077821 |
| `BundleId` | `string` | Optional | Bundle Id associated with card in the Gateway.<br>This field will have a null value if the card is not associated with any bundle of IncludeBundleDetails in request is false.<br>If the search is based on a bundle Id, the same will be returned. |
| `MediumTypeID` | `int?` | Optional | Id of the medium type identifier.<br>Example: 1,2,4<br>Full list below:<br>1 - Fuel Card<br>2 - Fuel Card with EV<br>4 - Fuel Card and Key fob Card<br>5 - Key fob<br>6 - Virtual Card<br>7 - NPII Token<br>8 – Smartpay |
| `MediumType` | `string` | Optional | Name of the medium type identifier.<br><br>Example: Fuel Card, Fuel Card with EV, Key fob  <br>Full list below:<br>1 - Fuel Card<br>2 - Fuel Card with EV<br>4 - Fuel Card and Key fob Card<br>5 - Key fob<br>6 - Virtual Card<br>7 - NPII Token<br>8 - Smartpay |

## Example (as JSON)

```json
{
  "CardId": 110,
  "PAN": "PAN8",
  "ExpiryDate": "ExpiryDate8",
  "StatusId": 178,
  "StatusDescription": "StatusDescription4"
}
```


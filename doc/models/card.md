
# Card

## Structure

`Card`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account ID |
| `AccountName` | `string` | Optional | Account Name |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `BundleId` | `string` | Optional | Bundle Id associated with card in the Gateway.<br /><br><br>This field will have null value if the card is not associated with any bundle in Gateway or the value of IncludeBundleDetails in request is false. |
| `CardBlockSchedules` | [`List<CardBlockSchedule>`](../../doc/models/card-block-schedule.md) | Optional | List of Scheduled Card Blocks details<br /><br>Entity: CardBlockSchedule |
| `CardGroupId` | `int?` | Optional | Card group ID |
| `CardGroupName` | `string` | Optional | Card group name |
| `CardId` | `int?` | Optional | Unique Card Id |
| `CardTypeCode` | `string` | Optional | ISO code of the card i.e. first 7 digits of the PAN |
| `CardTypeId` | `int?` | Optional | Card Type ID Example Id and Description: 1 -Philippines CRT 7077861 2-Philippines<br /><br>Fleet 7002861 5-SHELL FLEET-HONG KONG 7002821 6-SHELL NHF- HONG KONG 7002821 7-SHELL CRT- HONG KONG 7077821 |
| `CardTypeName` | `string` | Optional | Card Type Name Example Id and Description: 1-Philippines CRT 7077861 2-Philippines <br /><br>Fleet 7002861 5-SHELL FLEET- HONG KONG 7002821 6-SHELL NHF- HONG KONG 7002821 7-SHELL  CRT- HONG KONG 7077821 |
| `ColCoCountryCode` | `string` | Optional | The 2 character ISO Code for the customer and card owning country. <br /><br>If default card type is not set then the first two alphabets of the account ID is returned. |
| `CreationDate` | `string` | Optional | Card Creation datetime.<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `DriverName` | `string` | Optional | Driver name |
| `EffectiveDate` | `string` | Optional | Effective date for the Card<br /><br>Format: yyyyMMdd<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `ExpiryDate` | `string` | Optional | Expiry date of the card.<br /><br>Format: yyyyMMdd<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `FleetIdInput` | `bool?` | Optional | True/False True if fleet id input is enabled, else false |
| `IsCRT` | `bool?` | Optional | True/False True if it is a CRT type card, else false |
| `IsFleet` | `bool?` | Optional | True/False True if it is a Fleet type card, else false |
| `IsInternational` | `bool?` | Optional | True/False True if it is an international card, else false |
| `IsNational` | `bool?` | Optional | True/False True if it is a national card, else false |
| `IsPartnerSitesIncluded` | `bool?` | Optional | True/False True if it is allowed at all partner sites, else false |
| `IsShellSitesOnly` | `bool?` | Optional | True/False True if it is only allowed at Shell sites, else false |
| `IssueDate` | `string` | Optional | Issue date<br /><br>Format: yyyyMMdd<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `IsSuperseded` | `bool?` | Optional | True/False True if a new card is issued with the same PAN, else false. |
| `IsVirtualCard` | `bool?` | Optional | True/False True if it is a virtual card, else false |
| `LastModifiedDate` | `string` | Optional | Card last modified date and time<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `LastUsedDate` | `string` | Optional | Card last used date .<br /><br>Note: last used date of a card will be calculated based on billed/unbilled sales items<br><br>      of a given card.The query that extracts the last used dates will be applied on the<br>    <br>      subset of the cards being returned to the client.Unbilled sales items is checked<br>    <br>      first and for those not found in the unbilled table, sales items will be checked<br>    <br>      (only when the last used date is not found in unbilled table for at least a single<br>    <br>      card from the result). The transactions in last 48 hours are not expected to be<br><br>Therefore this field gives the correct information up to 48 hours early.<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: Clients to convert this to appropriate DateTime type |
| `LocalCurrencyCode` | `string` | Optional | ISO code of the local currency. <br /> |
| `LocalCurrencySymbol` | `string` | Optional | Local currency symbol. <br /> |
| `OdometerInput` | `bool?` | Optional | True/False True if odometer input is enabled on the card, else false |
| `PAN` | `string` | Optional | Card PAN |
| `MaskedPAN` | `string` | Optional | Card PAN Mask PAN (Mask all digits except the Last 6 digits of the PAN) |
| `PANID` | `double?` | Optional | Card PAN ID. |
| `PurchaseCategoryCode` | `string` | Optional | Purchase category code |
| `PurchaseCategoryId` | `int?` | Optional | Purchase category Id <br /><br>Note: Not Purchase code. |
| `PurchaseCategoryName` | `string` | Optional | Purchase category name |
| `Reason` | `string` | Optional | Card Status reason Example: Lost Stolen Card no longer required |
| `ReissueSetting` | `string` | Optional | Reissue setting of the card. If the card is superseded (i.e. a replacement/new card is issued) then reissue setting of the latest card issued. <br /><br>Values<br /><br>•True –Card will be Reissued when nearing its expiry date <br /><br>•False –Card will not be Reissued |
| `StatusDescription` | `string` | Optional | Status Description (Active, Temporarily Blocked, etc.,)<br /><br>Possible Ids and description: 1 Active 7 Blocked Card 8 Expired 9 Cancelled 10 New 23 Pending Renewal 31 Replaced 41<br /><br>Temporary Block(Customer) 42 Temporary Block(Shell) 43 Fraud 101 Active(Block in progress)<br /><br><br>* 102 Blocked Card(Unblock in progress) <br /><br>* 103 Active(Cancel in progress) <br /><br>* 104 Active(Marked as damaged)<br /><br>* 105 New(Cancel in progress) <br /><br>* 106 { Status}(Scheduled for block)<br /><br>* 107 { Status}(Scheduled for unblock) <br /><br>  *# Note: Items marked with* are intermediate statuses  to indicate that there are pending requests in progress.<br /><br>  The response can contain these intermediate statuses only if the<br /><br>  IncludeIntermediateStatus flag is true. The placeholder { Status} in the items<br /><br>  marked with # will be replaced with the  status description. E.g., Active (Scheduled for block) |
| `StatusId` | `int?` | Optional | Card Status id Possible Ids and description: 1 Active 7 Blocked Card 8 Expired 9 Cancelled 10 New 23 Pending Renewal 31 Replaced 41 Temporary Block(Customer) 42 <br /><br>Temporary Block(Shell) 43 Fraud 101 Active(Block in progress) <br /><br><br>* 102 Blocked Card(Unblock in progress)<br /><br>* 103 Active(Cancel in progress) <br /><br>* 104 Active(Marked as damaged) <br /><br>* 105 New(Cancel in progress)<br /><br>* 106 { Status}(Scheduled for block) <br /><br><br># 107 {Status}(Scheduled for unblock)<br /><br><br>*# Note: Items marked with* are intermediate statuses to indicate that there are pending requests in progress.<br /><br>The response can contain these intermediate statuses only if the IncludeIntermediateStatus flag is true.<br /><br>The placeholder { Status} in the items marked with # will be replaced with<br /><br>the status description. E.g., Active (Scheduled for block) |
| `TokenTypeID` | `int?` | Optional | Token Type ID configured for the Card E.g. 107 |
| `TokenTypeName` | `string` | Optional | Token Type Name configured for the Card |
| `VRN` | `string` | Optional | Vehicle registration number |
| `ClientReferenceId` | `string` | Optional | Customer reference number of the card. |
| `IsEMVContact` | `bool?` | Optional | Is Europay, MasterCard, and Visa Contact enabled or not. |
| `IsEMVContactless` | `bool?` | Optional | Is Europay, MasterCard, and Visa Contactless enabled or not. |
| `IsRFID` | `bool?` | Optional | Whether the card type is enabled for RFID (Radio Frequency Identification) |
| `RFIDUID` | `string` | Optional | RFIDUID |
| `EMAID` | `string` | Optional | EMAID |
| `EVPrintedNumber` | `string` | Optional | EV Printed Number |
| `CardMediaCode` | `string` | Optional | Card Media Code. |

## Example (as JSON)

```json
{
  "AccountId": 140,
  "AccountName": "AccountName0",
  "AccountNumber": "AccountNumber4",
  "AccountShortName": "AccountShortName6",
  "BundleId": "BundleId2"
}
```


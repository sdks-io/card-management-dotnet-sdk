
# Card Details Response

## Structure

`CardDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerId` | `int?` | Optional | Payer Id (i.e. Customer Id of the Payment Customer in the Shell Card Platform) of the selected payer. |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer. |
| `AccountId` | `int?` | Optional | Account Id (i.e. Customer Id of the Customer in the Shell Card Platform) of the customer. |
| `AccountNumber` | `string` | Optional | Account Number of the customer. |
| `AccountShortName` | `string` | Optional | Account short name. |
| `ColCoCountryCode` | `string` | Optional | ISO 3166 Alpha-2 Country Code for the customer and card owning country. |
| `LocalCurrencyCode` | `string` | Optional | ISO 4217 Curreny Code of the local currency. |
| `LocalCurrencySymbol` | `string` | Optional | Currency symbol of local currency. |
| `CardId` | `int?` | Optional | Unique Card Id in Cards platform. |
| `PAN` | `string` | Optional | Card PAN. In the response body the PAN will be masked if the option is enabled in the Shell Card Platform. |
| `StatusId` | [`CardDetailsResponseStatusIdEnum?`](../../doc/models/card-details-response-status-id-enum.md) | Optional | Possible Id’s and description:<br><br>* 1  Active<br>* 7  Blocked Card<br>* 8  Expired<br>* 9  Cancelled<br>* 10  New<br>* 23  Pending Renewal<br>* 31  Replaced<br>* 41  Temporary Block (Customer)<br>* 42  Temporary Block (Shell)<br>* 43  Fraud<br>* 101 Active (Block in progress) *<br>* 102 Blocked Card (Unblock in progress) *<br>* 103 Active (Cancel in progress) *<br>* 104 Active (Marked as damaged) *<br>* 105 New (Cancel as damaged) *<br>* 106 Active(Scheduled for block) ”#<br>* 107 Blocked Card(Scheduled for unblock)*#<br>* 108 Blocked Card (Cancel in progress) *<br><br>> Note:<br>> •  Items marked with * are intermediate statuses  to indicate that there are pending requests in progress. , The response can contain these intermediate statuses only if the IncludeIntermediateStatus flag is true.<br>> •  The placeholder “<Shell Card Platform Status>” in the items marked with # will be replaced with the Shell Card Platform status description. E.g., “Active (Scheduled for block)” |
| `Status` | `string` | Optional | Possible Id’s and description:<br><br>* 1  Active<br>* 7  Blocked Card<br>* 8  Expired<br>* 9  Cancelled<br>* 10  New<br>* 23  Pending Renewal<br>* 31  Replaced<br>* 41  Temporary Block (Customer)<br>* 42  Temporary Block (Shell)<br>* 43  Fraud<br>* 101 Active (Block in progress) *<br>* 102 Blocked Card (Unblock in progress) *<br>* 103 Active (Cancel in progress) *<br>* 104 Active (Marked as damaged) *<br>* 105 New (Cancel as damaged) *<br>* 106 Active(Scheduled for block) ”#<br>* 107 Blocked Card(Scheduled for unblock) *#<br>* 108 Blocked Card (Cancel in progress) *<br><br>> Note:<br>> •  Items marked with * are intermediate statuses  to indicate that there are pending requests in progress. , The response can contain these intermediate statuses only if the IncludeIntermediateStatus flag is true.<br>> •  The placeholder “<Shell Card Platform Status>” in the items marked with # will be replaced with the Shell Card Platform status description. E.g., “Active (Scheduled for block)” |
| `OdometerPrompt` | `bool?` | Optional | True if odometer input is enabled on the card, else false |
| `FleetIdPrompt` | `bool?` | Optional | True if fleet id input is enabled, else false |
| `PINType` | [`CardDetailsResponsePINTypeEnum?`](../../doc/models/card-details-response-pin-type-enum.md) | Optional | PIN type:<br><br>* `Card` - Card PIN<br>* `Fleet` - Fleet PIN |
| `HasPIN` | `bool?` | Optional | True if card has PIN, else false |
| `IsSelfSelectedPIN` | `bool?` | Optional | True if card has Self Selected PIN, else false |
| `TemporaryBlockAllowed` | `bool?` | Optional | True if card can be blocked temporarily, else false |
| `UnblockAllowed` | `bool?` | Optional | True/False True if card can be Unblocked, else false |
| `PermanentBlockAllowed` | `bool?` | Optional | True if card can be blocked permanently, else false |
| `IssueNumber` | `int?` | Optional | Issue number of the card |
| `ReissueSetting` | [`CardDetailsResponseReissueSettingEnum?`](../../doc/models/card-details-response-reissue-setting-enum.md) | Optional | Reissue setting of the card. If the card is superseded (i.e. a replacement/new card is issued) then reissue setting of the latest card issued. Reissue setting:<br><br>* `True` - Card will be Reissued when nearing its expiry date<br>* `False` - Card will not be Reissued |
| `InternationalPOSLanguageID` | [`CardDetailsResponseInternationalPOSLanguageIDEnum?`](../../doc/models/card-details-response-international-pos-language-id-enum.md) | Optional | POS language identifier. Language Id:<br><br>* `1` - German<br>* `2` - French<br>* `3` - Bulgarian<br>* `4` - Croatian<br>* `5` - Czech<br>* `6` - Danish<br>* `7` - Finnish<br>* `8` - English<br>* `9` - Greek<br>* `10` - Chinese<br>* `11` - Hungarian<br>* `12` - Italian<br>* `13` - Luxembourgish<br>* `14` - Malay<br>* `15` - Dutch<br>* `16` - Norwegian, Bokmal<br>* `17` - Urdu<br>* `18` - Polish<br>* `19` - Portuguese<br>* `20` - Romanian<br>* `21` - Russian<br>* `22` - Slovak<br>* `23` - Slovenian<br>* `24` - Spanish<br>* `25` - Swedish<br>* `26` - Turkish<br>* `27` - Thai<br>* `28` - Filipino<br>* `29` - Estonian<br>* `30` - Latvian<br>* `31` - Lithuanian |
| `InternationalPOSLanguageCode` | [`CardDetailsResponseInternationalPOSLanguageCodeEnum?`](../../doc/models/card-details-response-international-pos-language-code-enum.md) | Optional | POS language code. Language code:<br><br>* `deu` - German<br>* `fra` - French<br>* `bul` - Bulgarian<br>* `hrv` - Croatian<br>* `ces` - Czech<br>* `dan` - Danish<br>* `fin` - Finnish<br>* `eng` - English<br>* `ell` - Greek<br>* `zho` - Chinese<br>* `hun` - Hungarian<br>* `ita` - Italian<br>* `ltz` - Luxembourgish<br>* `msa` - Malay<br>* `nld` - Dutch<br>* `nob` - Norwegian, Bokmal<br>* `urd` - Urdu<br>* `pol` - Polish<br>* `por` - Portuguese<br>* `ron` - Romanian<br>* `rus` - Russian<br>* `slk` - Slovak<br>* `slv` - Slovenian<br>* `spa` - Spanish<br>* `swe` - Swedish<br>* `tur` - Turkish<br>* `tha` - Thai<br>* `fil` - Filipino<br>* `est` - Estonian<br>* `lav` - Latvian<br>* `lit` - Lithuanian |
| `LocalPOSLanguageID` | [`CardDetailsResponseLocalPOSLanguageIDEnum?`](../../doc/models/card-details-response-local-pos-language-id-enum.md) | Optional | POS language identifier. Language Id:<br><br>* `1` - German<br>* `2` - French<br>* `3` - Bulgarian<br>* `4` - Croatian<br>* `5` - Czech<br>* `6` - Danish<br>* `7` - Finnish<br>* `8` - English<br>* `9` - Greek<br>* `10` - Chinese<br>* `11` - Hungarian<br>* `12` - Italian<br>* `13` - Luxembourgish<br>* `14` - Malay<br>* `15` - Dutch<br>* `16` - Norwegian, Bokmal<br>* `17` - Urdu<br>* `18` - Polish<br>* `19` - Portuguese<br>* `20` - Romanian<br>* `21` - Russian<br>* `22` - Slovak<br>* `23` - Slovenian<br>* `24` - Spanish<br>* `25` - Swedish<br>* `26` - Turkish<br>* `27` - Thai<br>* `28` - Filipino<br>* `29` - Estonian<br>* `30` - Latvian<br>* `31` - Lithuanian |
| `LocalPOSLanguageCode` | [`CardDetailsResponseLocalPOSLanguageCodeEnum?`](../../doc/models/card-details-response-local-pos-language-code-enum.md) | Optional | POS language code. Language code:<br><br>* `deu` - German<br>* `fra` - French<br>* `bul` - Bulgarian<br>* `hrv` - Croatian<br>* `ces` - Czech<br>* `dan` - Danish<br>* `fin` - Finnish<br>* `eng` - English<br>* `ell` - Greek<br>* `zho` - Chinese<br>* `hun` - Hungarian<br>* `ita` - Italian<br>* `ltz` - Luxembourgish<br>* `msa` - Malay<br>* `nld` - Dutch<br>* `nob` - Norwegian, Bokmal<br>* `urd` - Urdu<br>* `pol` - Polish<br>* `por` - Portuguese<br>* `ron` - Romanian<br>* `rus` - Russian<br>* `slk` - Slovak<br>* `slv` - Slovenian<br>* `spa` - Spanish<br>* `swe` - Swedish<br>* `tur` - Turkish<br>* `tha` - Thai<br>* `fil` - Filipino<br>* `est` - Estonian<br>* `lav` - Latvian<br>* `lit` - Lithuanian |
| `CardTypeCode` | `string` | Optional | ISO code of the card i.e. first 7 digits of the PAN. |
| `CardTypeId` | `int?` | Optional | Card Type ID |
| `CardTypeName` | `string` | Optional | Card Type Name |
| `TokenTypeId` | `int?` | Optional | Token Type ID configured for the Card |
| `TokenTypeName` | `string` | Optional | Token Type Name configured for the Card |
| `IsChipCard` | `bool?` | Optional | True if a chip card, else false |
| `IsMagStripCard` | `bool?` | Optional | True if it is a magnetic stripe card, else false |
| `IsVirtualCard` | `bool?` | Optional | True if it is a virtual card, else false |
| `PurchaseCategoryCode` | `string` | Optional | Purchase category code of the card.<br>**Constraints**: *Maximum Length*: `1` |
| `PurchaseCategoryId` | `int?` | Optional | Purchase category identifier in the Shell Card Platform. |
| `PurchaseCategoryName` | `string` | Optional | Purchase category name |
| `IsCRT` | `bool?` | Optional | True if it is a Commercial Road Transport (CRT) card, else false |
| `IsFleet` | `bool?` | Optional | True if it is a Fleet card, else false |
| `IsInternational` | `bool?` | Optional | True if it is an international card, else false |
| `IsNational` | `bool?` | Optional | True if it is a national card, else false |
| `IsPartnerSitesIncluded` | `bool?` | Optional | True if it is allowed at all partner sites, else false |
| `IsShellSitesOnly` | `bool?` | Optional | True if it is only allowed at Shell sites, else false |
| `FuelSets` | [`List<CardDetailsResponseFuelSetsItems>`](../../doc/models/card-details-response-fuel-sets-items.md) | Optional | List of active fuel type product restrictions applied on the card.<br>**Constraints**: *Unique Items Required* |
| `NonFuelSets` | [`List<CardDetailsResponseNonFuelSetsItems>`](../../doc/models/card-details-response-non-fuel-sets-items.md) | Optional | List of active non-fuel type product restrictions applied on the card.<br>**Constraints**: *Unique Items Required* |
| `IssuedDate` | `string` | Optional | Card issue date. |
| `ExpiryDate` | `string` | Optional | Expiry date of the card. |
| `LastUsedDate` | `string` | Optional | Card last used date. |
| `MisuseDate` | `string` | Optional | Last misused date of the card. |
| `Temperature` | `string` | Optional | Hot-list status |
| `DriverName` | `string` | Optional | Driver name of the card. Note- While ordering card, optional when VRN is passed else mandatory.<br>**Constraints**: *Maximum Length*: `27` |
| `VRN` | `string` | Optional | Vehicle registration number of the card. Note- While ordering card, optional when DriverName is passed else mandatory.<br>**Constraints**: *Maximum Length*: `16` |
| `EmbossText` | `string` | Optional | Text printed on the card as account name.<br>**Constraints**: *Maximum Length*: `25` |
| `CardGroupId` | `int?` | Optional | Existing Card Group ID, under which the replacement card is to be created.<br>Pass “-1” if the replacement card should not be assigned to any card group.<br>Optional.<br>If not provided, the replacement card will be created under the same card group as the current card.<br>Example- 156 |
| `CardGroupName` | `string` | Optional | Card group name. Note- 1. While ordering card this field is mandatory when IsNewCardGroup is true.<br>**Constraints**: *Maximum Length*: `30` |
| `RenewalDate` | `string` | Optional | Renewal date of the card. Applicable if ReissueSetting is set to True. |
| `RenewedCardId` | `int?` | Optional | Renewed card id. |
| `RenewedCardStatusId` | `int?` | Optional | Renewed card status id. |
| `RenewedCardStatus` | `string` | Optional | Renewed card status description. |
| `RenewedCardExpiryDate` | `string` | Optional | Renewed card expiry date. |
| `RenewedCardIssueNumber` | `int?` | Optional | Renewed card issue number. |
| `RenewedCardReissueSetting` | [`CardDetailsResponseRenewedCardReissueSettingEnum?`](../../doc/models/card-details-response-renewed-card-reissue-setting-enum.md) | Optional | Reissue setting of the renewed new card. Reissue Setting:<br><br>* `True` - Card will be sent to production<br>* `False` - Parent Card is Dormant or the Card is not to be produced |
| `CreationDate` | `string` | Optional | Card Creation Date time |
| `EffectiveDate` | `string` | Optional | Effective date for the Card |
| `LastModifiedDate` | `string` | Optional | Card last modified date |
| `BundleId` | `string` | Optional | Bundle Id associated with card in the Gateway. This field will have a null value if the card is not associated with any bundle in Gateway or the value of IncludeBundleDetails in request is false. |
| `CardDeliveryAddress` | [`CardDetailsResponseCardDeliveryAddress`](../../doc/models/card-details-response-card-delivery-address.md) | Optional | Delivery address. |
| `PINDeliveryAddress` | [`CardDetailsResponsePINDeliveryAddress`](../../doc/models/card-details-response-pin-delivery-address.md) | Optional | Delivery address. |
| `CardBlockSchedules` | [`List<CardDetailsResponseCardBlockSchedulesItemsAllOf0>`](../../doc/models/card-details-response-card-block-schedules-items-all-of-0.md) | Optional | **Constraints**: *Unique Items Required* |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request |

## Example (as JSON)

```json
{
  "PayerId": 853,
  "PayerNumber": "PH50000843",
  "AccountId": 854,
  "AccountNumber": "PH50000844",
  "AccountShortName": "PARKLEY",
  "ColCoCountryCode": "PH",
  "LocalCurrencyCode": "EUR",
  "LocalCurrencySymbol": "€",
  "CardId": 125,
  "PAN": "7002861007636000020",
  "OdometerPrompt": true,
  "FleetIdPrompt": true,
  "PINType": "Card",
  "HasPIN": true,
  "IsSelfSelectedPIN": true,
  "TemporaryBlockAllowed": true,
  "UnblockAllowed": true,
  "PermanentBlockAllowed": true,
  "IssueNumber": 1,
  "InternationalPOSLanguageID": 8,
  "InternationalPOSLanguageCode": "eng",
  "LocalPOSLanguageID": 8,
  "LocalPOSLanguageCode": "eng",
  "CardTypeCode": "7077861",
  "CardTypeId": 1,
  "CardTypeName": "Philippines CRT 7077861",
  "TokenTypeId": 107,
  "TokenTypeName": "PH FLE NAT SIN R1",
  "IsChipCard": false,
  "IsMagStripCard": true,
  "IsVirtualCard": true,
  "PurchaseCategoryCode": "6",
  "PurchaseCategoryId": 54,
  "PurchaseCategoryName": "2 - FuelSave and Lubricants",
  "IsCRT": true,
  "IsFleet": true,
  "IsInternational": true,
  "IsNational": true,
  "IsPartnerSitesIncluded": true,
  "IsShellSitesOnly": true,
  "IssuedDate": "20181001",
  "ExpiryDate": "20181031",
  "LastUsedDate": "20181001 13:23:55",
  "MisuseDate": "20181001 13:23:55",
  "Temperature": "10-Warm",
  "DriverName": "ROBERT",
  "VRN": "MV65YLH",
  "EmbossText": "PARKLEY",
  "CardGroupId": 5,
  "CardGroupName": "GROUP1",
  "RenewalDate": "20181001",
  "RenewedCardId": 1325,
  "RenewedCardStatusId": 10,
  "RenewedCardStatus": "New",
  "RenewedCardExpiryDate": "20181031",
  "RenewedCardIssueNumber": 2,
  "CreationDate": "20181001",
  "EffectiveDate": "20181001",
  "LastModifiedDate": "20181001 13:23:55",
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed"
}
```


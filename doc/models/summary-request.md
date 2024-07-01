
# Summary Request

Encapsulates the details of a Summary Request.
Summary Request fields are same as the Search Request base class and no new fields are required.

## Structure

`SummaryRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account ID of the customer.<br/> Optional.<br/> This input is a search criterion, if given. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br/> Optional.<br/> This input is a search criterion, if given. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer. <br /><br>Optional If ColCo Id or ColCoCountryCode is passed else Mandatory.<br /> |
| `ColCoCountryCode` | `string` | Optional | The 2 character ISO Code for the customer and card owning country.<br /><br>Optional If ColCoId or ColCoCode is passed else Mandatory.<br /> |
| `ColCoId` | `int?` | Optional | Collecting Company Id (in ) of the selected payer.<br /><br>Optional If ColCo Codeor ColCoCountryCode is passed else Mandatory <br /> |
| `PayerId` | `int?` | Optional | Payer Id (i.e. Customer Id of the Payment Customer ) of the selected payer.<br /><br>Optional if PayerNumber is passed else Mandatory |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br /><br>Optional if PayerId is passed else Mandatory |
| `CardGroupId` | `int?` | Optional | Card group id.<br /><br>Optional. <br /><br>This input is a search criterion, if given.<br /><br>When -1 is passed, those cards that does not belong to any card group will be returned. |
| `CardGroupName` | `string` | Optional | Card group name.<br /><br>Optional.<br /><br>This input is a search criterion, if given.<br /><br>If CardGroupId is provided then this search criterion will be ignored, else, those cards that have the card group name completely matching with the entered value will be returned |
| `CardStatus` | `List<string>` | Required | Status of the card.<br /><br>Mandatory.<br /><br>Multiple statuses are allowed to be included in the search criteria.<br /><br>CardStatus filter accepts either of the two values for each status as described below. However, the output field “StatusDescription” is aligned with second value highlighted in italics.<br /><br>Below are the possible allowed statuses: <br /><br>• ACTIVE or Active – Cards at status Active (The result will include all the cards having the following intermediate statuses as defined s, if the IncludeIntermediateStatus flag is true: Active (Block in progress), Active (Cancel in progress), Active (Marked as damaged)), New (Cancel in progress).<br /><br>• ON_ORDER or New – Cards at status New <br /><br>• EXPIRED or Expired – Cards at status Expired<br /><br>• BLOCKED or Blocked Card – Cards at status Block (The result will include all cards having the following intermediate status as defined, if the IncludeIntermediateStatus flag is true: Blocked card (Unblock in progress))<br /><br>• TEMP_BLOCKED_CUSTOMER or Temporary Block(Customer) – Cards at status Temporary Blocked By Customer<br /><br>• TEMP_BLOCKED_SHELL or Temporary Block (Shell) – Cards at Status Temporary Blocked by Shell<br /><br>• CANCELLED or Cancelled – Cards at status Cancelled<br /><br>• PENDING_RENEWAL or Pending Renewal - Cards that are in renewal process<br /><br>• REPLACED or Replaced – Cards at Status Replaced<br /><br>• FRAUD or Fraud – Cards at Status FRAUD<br /><br>• ALL |
| `ExpiringInDays` | `int?` | Optional | Cards active and expiring in given number of days.<br /><br>Optional<br /><br>Note: When a value is passed in this parameter, only active cards will be considered while searching. |
| `IssuedAfter` | `string` | Optional | If provided, only list cards issued after the given date<br /><br>Optional<br /><br>Format: yyyyMMdd<br /><br>Note: Clients to convert this to appropriate DateTime type. |
| `PANEndsWith` | `string` | Optional | Last digits of the PAN number<br /><br>Minimum 4 last digits of the card should be sent for this field to be considered as part of the search criteria.<br /><br>Optional<br /><br>Max Length: 50 |
| `DriverName` | `List<string>` | Optional | Driver Name embossed on the card<br /><br>Optional<br /><br>Up to 10 driver names could be passed in the parameter.<br /><br>Minimum of 4 characters should be provided for each driver name else not considered.<br /><br>Those cards will be returned when part of the driver name matches with any of the string passed in the list.<br /><br>Max Length for each Driver name: 50 |
| `VehicleRegistrationNumber` | `List<string>` | Optional | Vehicle Registration embossed on the card<br /><br>Optional<br /><br>Up to 10 vehicle registration numbers could be passed in the parameter.<br /><br>Minimum of 4 characters should be provided for each VRN else not considered<br /><br>Those cards will be returned when part of the VRN matches with any of the string passed in the list.<br /><br>Max Length for each VRN: 50 |
| `IncludeCards` | [`List<SearchCard>`](../../doc/models/search-card.md) | Optional | List of SearchCard entity i.e., Card Id or PAN, which needs to be included in the response.<br /><br>Details of the SerachCard entity are given below. |
| `ExcludeCards` | [`List<SearchCard>`](../../doc/models/search-card.md) | Optional | List of SearchCard entity i.e., Card Id or PAN, which needs to be excluded in the response. <br /><br>Details of the SerachCard entity are given below. |
| `ExcludeBundleId` | `string` | Optional | Bundle Id for the Card, which needs to be excluded in the response.<br /><br>Optional |
| `CardSegment` | `string` | Optional | Market segment to which card belongs to.<br /><br>Optional.<br /><br>Allowed values<br /><br>• CRT<br /><br>• Fleet |
| `PurchaseCategoryCode` | `string` | Optional | Purchase category code of the card.<br /><br>Optional. |
| `CardTypeCode` | `string` | Optional | ISO code of the card i.e. first 7 digits of the PAN<br /><br>Optional. |
| `ExcludePendingRenewalCards` | `bool?` | Optional | Default value is True.<br /><br>When true, the API will not return cards that are at Pending Renewal Status in Cards Platform |
| `ExcludeCancelledCards` | `bool?` | Optional | Default value is True.<br /><br>When true, the API will not return cards that are at Cancelled Status in Cards Platform |
| `ExcludeReplacedCards` | `bool?` | Optional | Default value is False.<br /><br>When true, the API will not return cards that are at Replaced Status in Cards Platform |
| `ExcludeFraudCards` | `bool?` | Optional | Default value is False.<br /><br>When true, the API will not return cards that are at Fraud Status in Cards Platform |
| `ExcludeCardGroupId` | `int?` | Optional | Optional<br /><br>When passed, the API will not return cards that are currently in the Card Group specified |
| `ExcludeCardGroupName` | `string` | Optional | Optional<br /><br>When passed, the API will not return cards that are currently in the Card Group specified |
| `CreationDate` | `string` | Optional | Card Creation Date<br /><br>Optional<br /><br>Format: yyyyMMdd |
| `EffectiveDate` | `string` | Optional | Effective date for the Card<br /><br>Optional<br /><br>Format: yyyyMMdd |
| `Network` | `string` | Optional | Cards allowed to be used in site.<br /><br>Optional.<br /><br>Allowed values<br /><br>• ShellSitesOnly<br /><br>• PartnersSitesIncluded<br /> |
| `Coverage` | `string` | Optional | Cards allowed to used nationally/internationally.<br /><br>Optional.<br /><br>Allowed values<br /><br><br>-National<br /><br><br>-International |
| `ExpiryMonth` | `string` | Optional | Month in which the card is expiring.<br /><br>Optional.<br /><br>Format: MMYYYY |
| `ExcludeOldCards` | `bool?` | Optional | Default Value: False<br /><br>When this field is set to True, cards with below status 2 years (configurable) ago and earlier are excluded from the result<br /><br><br>-Blocked Card<br /><br><br>-Expired<br /><br><br>-Cancelled<br /><br><br>-Suspended<br /><br><br>-Blocked<br /><br><br>-Expired and Cancelled<br /><br><br>-Replaced<br /><br><br>-Replaced By<br /><br><br>-Closed<br /><br><br>-Fraud<br /> |
| `ReissueSetting` | `string` | Optional | Default Value: All<br /><br>Optional<br /><br>This option is used to filter the list of cards with ‘ReissueSetting’.<br /><br>If ‘True’, the API will return cards with ReIssueSetting value is true.<br /><br>If ‘False’, the API will return cards with ReIsssueSetting value is false.<br /><br>If ‘ALL’, API will return cards with ReIssueSetting value True &amp; False both.<br /><br>Allowed Values:<br /><br><br>1. All<br /><br>2. True<br /><br>3. False |
| `RequestId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "AccountId": 4,
  "AccountNumber": "AccountNumber8",
  "ColCoCode": 166,
  "ColCoCountryCode": "ColCoCountryCode4",
  "ColCoId": 152,
  "CardStatus": [
    "CardStatus9",
    "CardStatus0"
  ],
  "RequestId": "RequestId6"
}
```



# Schedule Card Block Cards Items

## Structure

`ScheduleCardBlockCardsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1-Philippines<br>5-UK |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Optional if AccountNumber is passed, else Mandatory. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional if AccountId is passed, else Mandatory. |
| `PayerId` | `int?` | Optional | Payer id of the customer.<br>Optional if PayerNumber is passed, else Mandatory.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | PayerNumber of the customer.<br>Optional if PayerId is passed, else Mandatory. |
| `CardId` | `int?` | Optional | Unique Id of the card.<br>Optional if PAN is passed, else Mandatory. |
| `PAN` | `string` | Optional | PAN of the card.<br>Optional if CardId is passed, else Mandatory. |
| `CardExpiryDate` | `string` | Optional | Expiry date of the card.<br>Optional if CardId is passed, else Mandatory.<br>Format: yyyyMMdd<br>Example: 20170930 |
| `Action` | `string` | Required | Action<br>Mandatory<br>Possible values are:<br>•	AddOrUpdate – adds a new request or updates any existing requests, with overlapping dates, for the card<br>•	AddAndOverwriteAll - all the existing requests of the given card will be removed and a new request with the specified FromDate and ToDate will be added.<br>•	Delete – deletes any existing request with the same start date and end date for the card<br>•	DeleteAll – deletes all saved future dated requests (all block and unblock requests) of the card. |
| `FromDate` | `string` | Optional | Effective start date of Block / Unblock<br>Allowed Formats: –<br>•	yyyyMMdd<br>•	yyyyMMdd HH:mm<br>Eg: 20230512 14:30, 20230512<br>Optional<br>Default value:<br>•	 If the card status is “Active” then Current date & Time<br>•	If the card status is “TemporaryBlock (Customer)” then null.<br>Note:<br>•	Time is considered only when “IsTimeSupported” is true else it will be treated as a date.<br>•	Time will be passed in UTC time-zone.<br>•	If the Card Status is “Temporary Block (Customer)” and FromDate is provided – The fromdate & time is considered as starting period of unblock request. |
| `ToDate` | `string` | Optional | Effective end date of Block / Unblock<br>Allowed Formats: –<br>•	yyyyMMdd<br>•	yyyyMMdd HH:mm<br>Eg: 20230512 14:30, 20230512<br>Optional – When the Card status is Active else mandatory.<br>When not provided, the card will remain blocked until manually unblocked.<br>Note:<br>•	Time is considered only when the “IsTimeSupported” flag is set as true, else it will be considered as only date.<br>•	Date & Time passed in the request will be considered in UTC time-zone.<br>•	If the card is currently in ‘Temporary Block (Customer)’ status, then this date is treated as the unblock date and is mandatory.<br>•	If the Card Status is “Temporary Block (Customer)” and FromDate & ToDate is provided - The request will be considered as a scheduled specific period unblock request. |
| `Caller` | `string` | Optional | The caller to be notified with the status of the scheduled card block / unblock request.<br>Mandatory, if NotifyCaller is true.<br>Maximum field length: 20 |
| `NotifyCaller` | `bool?` | Optional | True/False.<br>Optional.<br>Default: False<br>If true, the caller would be notified back with the status as success or failure after the scheduled card block / unblock request is processed. |

## Example (as JSON)

```json
{
  "ColCoCode": 164,
  "ColCoId": 150,
  "AccountId": 2,
  "AccountNumber": "AccountNumber6",
  "PayerId": 198,
  "Action": "Action2"
}
```


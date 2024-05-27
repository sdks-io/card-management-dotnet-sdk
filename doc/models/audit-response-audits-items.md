
# Audit Response Audits Items

## Structure

`AuditResponseAuditsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account id of the customer.<br>It will be the source account id in case of “Fund Transfer |
| `AccountNumber` | `string` | Optional | Account number of the customer.<br>It will be the source account number in case of “Fund Transfer” |
| `AdditionalInformation1` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation2` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation3` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation4` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation5` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation6` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation7` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation8` | `string` | Optional | Additional information in the request. |
| `AdditionalInformation9` | `string` | Optional | Additional information in the request. |
| `CardGroupId` | `int?` | Optional | Additional information in the request. |
| `CardGroupName` | `string` | Optional | Card group name in the request. |
| `CardId` | `int?` | Optional | Card Id in the request |
| `ColCoCode` | `int?` | Optional | Collecting company code of the customer |
| `ColCoId` | `int?` | Optional | Collecting company id of the customer. |
| `ErrorCode` | `string` | Optional | Error code of the request |
| `ErrorString` | `string` | Optional | Error description of the request |
| `GlobalRequestID` | `string` | Optional | Global unique request reference provided by client application. |
| `PAN` | `string` | Optional | PAN in the request.<br>If Mask PAN is enabled at Microservices configuration then all digits of the PAN, except the last 6 digits, will be masked. |
| `PayerId` | `int?` | Optional | Payer id of the customer. |
| `PayerNumber` | `string` | Optional | Payer number of the customer. |
| `ProcessedOn` | `string` | Optional | Request processed date.<br>Format: yyyyMMdd HH:mm: ss |
| `RequestedBy` | `string` | Optional | vUUID of the user who submitted this request.<br>It will be the UUID of the Driver in the case of “MobilePaymentRegistration” |
| `RequestedOperation` | `string` | Optional | User requested operation.<br>Possible values:<br>•	OrderCard<br>•	CreateCardGroup<br>•	PINReminder<br>•	MoveCard<br>•	UpdateCardStatus<br>•	UpdateCardGroup<br>•	AutoRenew<br>•	BulkCardOrder<br>•	BulkCardBlock<br>•	BulkCardOrderMultiAccount<br>•	MobilePaymentRegistration<br>•	UpdateCompanyInfo<br>•	BCOSummary<br>•	BCOMultiAccountSummary<br>•	BCBSummary<br>•	FundTransfer<br>•	DeliveryAddressUpdate |
| `RequestReference` | `int?` | Optional | Reference number for the requested operation. |
| `RequestType` | `string` | Optional | Request type initiated under the requested operation.<br>Possible values:<br>•	OrderCard<br>•	CreateCardGroup<br>•	PINReminder<br>•	MoveCard<br>•	UpdateCardStatus<br>•	UpdateCardGroup<br>•	AutoRenew<br>•	BulkCardOrder<br>•	BulkCardBlock<br>•	BulkCardOrderMultiAccount<br>•	MobilePaymentRegistration<br>•	UpdateCompanyInfo<br>•	BCOSummary<br>•	BCOMultiAccountSummary<br>•	BCBSummary<br>•	FundTransfer<br>•	DeliveryAddressUpdate |
| `Status` | `string` | Optional | Status of the request.<br>Possible values:<br>•	Success<br>•	Failed<br>•	InProgress<br>•	Submitted<br>•	Rejected<br>•	PendingApproval<br>•	MailedToCSC |
| `SubmittedOn` | `string` | Optional | Request submitted date.<br>Format: yyyyMMdd HH:mm: ss |
| `SubRequestReference` | `int?` | Optional | Reference number for the individual request type. |
| `UserDisplayName` | `string` | Optional | Display name of the user who submitted this request.<br>It will be the Display Name of the Driver in the case of “MobilePaymentRegistration” in the below format: |

## Example (as JSON)

```json
{
  "AccountId": 123,
  "AccountNumber": "BE00000113",
  "AdditionalInformation1": "922",
  "AdditionalInformation2": "2016",
  "AdditionalInformation3": "MERCEDES GLE KLASSE SEGM. L",
  "AdditionalInformation4": "408135/3",
  "AdditionalInformation5": "API TEST CUSTOMER 113",
  "AdditionalInformation6": "408135/3",
  "AdditionalInformation7": "null",
  "AdditionalInformation8": "null",
  "AdditionalInformation9": "null",
  "CardGroupId": 123,
  "CardGroupName": "test",
  "CardId": 10594,
  "ColCoCode": 9,
  "ColCoId": 9,
  "ErrorCode": "0000",
  "ErrorString": "null",
  "GlobalRequestID": "6f1473ea-7f68-4ccb-acee-4b5b997aad5a",
  "PAN": "7002097550439850717",
  "PayerId": 123,
  "PayerNumber": "BE00000113",
  "ProcessedOn": "20240201 14:30:26",
  "RequestedBy": "EWyIv8LpjgW3LlKDDUo0VZMN6JKpqRc",
  "RequestedOperation": "OrderCard",
  "RequestReference": 519876,
  "RequestType": "OrderCard",
  "Status": "Success",
  "SubmittedOn": "20240201 14:29:16",
  "SubRequestReference": 720061,
  "UserDisplayName": "Supriya-ThridPartyAgent"
}
```



# Order Card Enquiry

This entity models the data that is sent in the https

## Structure

`OrderCardEnquiry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account ID on the card request |
| `AccountNumber` | `string` | Optional | AccountNumber |
| `BCOReference` | `int?` | Optional | Bulk card order request refrence numer.<br /><br>This field will be null if the order is not through BCO. |
| `BCORowNumber` | `int?` | Optional | Row number of the request in the BCO file.<br /><br>This field will be null if the order is not through BCO. |
| `CardGroupId` | `int?` | Optional | Card group ID |
| `CardGroupName` | `string` | Optional | Card group name |
| `CardId` | `int?` | Optional | Unique Card Id.<br /><br>The field will be null if the card order request is not successly processed. |
| `CardPAN` | `string` | Optional | Card PAN.<br /><br>Mask PAN (Mask all digits except the Last 6 digits of the PAN).<br /><br>The field will be null if the card order request is not successly processed. |
| `CardTypeCode` | `string` | Optional | CardTypeCode<br /><br>ISO code of the card i.e. first 7 digits of the PAN |
| `CardTypeId` | `int?` | Optional | CardTypeId |
| `CardTypeName` | `string` | Optional | CardTypeName |
| `DriverName` | `string` | Optional | Driver name |
| `ErrorCode` | `string` | Optional | Error code for the order card request.<br /><br>The value will be 0000 if it is processed without errors. |
| `ErrorDescription` | `string` | Optional | Error description for the order card request.<br /><br>The value will be empty string if it is processed without errors. |
| `GatewaySyncErrorCode` | `string` | Optional | Error code for the Gateway sync error.<br /><br>The value will be 0000 if it is processed without errors. |
| `GatewaySyncErrorDescription` | `string` | Optional | Error description for the Gateway sync error.<br /><br>The value will be empty string if it is processed without errors. |
| `GatewaySyncStatus` | `string` | Optional | GatewaySyncStatus<br /><br>Status of the card sync with CFGW.<br /><br>Possible values:<br /><br>-Success<br /><br>-Failed<br /><br>-In Progress<br /><br>-Not Submitted |
| `MainReference` | `int?` | Optional | Main reference number for the order card request.<br /><br>This field will be null if the order is through BCO. |
| `OrderCardReference` | `int?` | Optional | Indivitual card reference number for the order card request.<br /><br>This field will be null if the order is through BCO. |
| `OrderStatus` | `string` | Optional | Order status.<br /><br>Possible values:<br /><br>P   Pending<br /><br>I   Picked up for processing<br /><br>PX	Failed at Queue but retry attempts pending<br /><br>X	Failed  at Queue<br /><br>R	Card is processed, awaiting for PAN update.<br /><br>S	Processed<br /><br>F	Failed |
| `PayerId` | `int?` | Optional | Payer ID on the card request. |
| `PayerNumber` | `string` | Optional | Payer Number on the card request |
| `ProcessedDate` | `string` | Optional | Date and time (in cutomers local time) when the card order request is processed<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: The client application to convert the string to appropriate date/time type. |
| `PurchaseCategoryCode` | `string` | Optional | PurchaseCategoryCode |
| `PurchaseCategoryId` | `int?` | Optional | PurchaseCategoryId <br /><br>Note: Not Purchase code. This is a unique purchase category id assigned |
| `PurchaseCategoryName` | `string` | Optional | PurchaseCategoryName |
| `SubmittedDate` | `string` | Optional | Date and time (in cutomers local time) when the card order request is submitted.<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: The client application to convert the string to appropriate date/time type. |
| `SyncProcessedDate` | `string` | Optional | SyncProcessedDate<br /><br>Date and time (in cutomers local time) when the sync card request is processed.<br /><br>Format: yyyyMMdd HH:mm:ss<br /><br>Note: The client application to convert the string to appropriate date/time type. |
| `SyncRequestedDate` | `string` | Optional | SyncRequestedDate<br /><br>Date and time (in cutomers local time) when the sync card request is submitted.<br /><br>Format: yyyyMMdd HH:mm:ss <br /><br>Note: The client application to convert the string to appropriate date/time type. |
| `VRN` | `string` | Optional | Vehicle registration number |
| `OrderRequestId` | `string` | Optional | Unique Id of the Original Order card request, the status of which is enquired by this API. <br /><br>This is returned for end to end traceability of a request based on the original Order Card request. |
| `ExpiryDate` | `string` | Optional | Expiry date of the card.<br /><br>Format: MMyy<br /><br>(Clients to convert this to appropriate DateTime type.)<br /><br>Note: This is the Expiry Date saved.<br /><br>If the Order Card request is still not processed, i.e.PAN is not yet issued, this field will be null or empty. <br /><br>For a Card Order with a custom Expiry Date passed in the request, this value will be returned after it is updated successfully. |
| `ClientReferenceId` | `string` | Optional | This is the Client Reference Id of card in the order which needs to be passed by the client. |
| `StatusDescription` | `string` | Optional | Order status.<br /><br>Possible values<br /><br>Success<br /><br>Failed<br /><br>InProgress<br /> |
| `ColCoId` | `int?` | Optional | Colcoid |

## Example (as JSON)

```json
{
  "AccountId": 206,
  "AccountNumber": "AccountNumber0",
  "BCOReference": 154,
  "BCORowNumber": 80,
  "CardGroupId": 252
}
```


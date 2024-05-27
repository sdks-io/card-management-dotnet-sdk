
# Update M Pay Reg Status Request M Pay Requests Items

## Structure

`UpdateMPayRegStatusRequestMPayRequestsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GlobalRequestID` | `string` | Optional | List of MPay Request to be updated for Fleet Manager approval status.<br>Mandatory<br>Maximum number of requests that can be submitted are 50 |
| `Status` | `string` | Optional | Status of mobile payment registration request<br>Mandatory.<br>Allowed values –<br>•	Approved<br>•   Rejected |
| `ApproverUserID` | `string` | Optional | Approver’s User ID<br>ApproverUserID is mandatory when Status is Approved else optional |
| `ApproverUserDisplayName` | `string` | Optional | Approver’s display name<br>Mandatory when Status is Approved else optional. |
| `Reason` | `string` | Optional | Reason for Fleet Manager approval/rejection.<br>Optional |

## Example (as JSON)

```json
{
  "GlobalRequestID": "GlobalRequestID4",
  "Status": "Status4",
  "ApproverUserID": "ApproverUserID0",
  "ApproverUserDisplayName": "ApproverUserDisplayName0",
  "Reason": "Reason8"
}
```



# Order Card Enquiry Response

## Structure

`OrderCardEnquiryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `Data` | [`List<OrderCardEnquiry>`](../../doc/models/order-card-enquiry.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId8",
  "Status": "Status4",
  "Data": [
    {
      "AccountId": 62,
      "AccountNumber": "AccountNumber8",
      "BCOReference": 10,
      "BCORowNumber": 192,
      "CardGroupId": 108
    }
  ]
}
```


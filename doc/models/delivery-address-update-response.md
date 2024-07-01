
# Delivery Address Update Response

## Structure

`DeliveryAddressUpdateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request ID to which was passed on the API request. |
| `ServiceReference` | `int?` | Optional | Service reference number for tracking. |
| `DeliveryAddressUpdateReferences` | [`DeliveryAddressUpdateReferences2`](../../doc/models/delivery-address-update-references-2.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "eb621f45-a543-4d9a-a934-2f223b263c42",
  "ServiceReference": 123456,
  "DeliveryAddressUpdateReferences": {
    "CardId": 66,
    "CardPAN": "CardPAN8",
    "AccountId": 160,
    "AccountNumber": "AccountNumber8",
    "ReferenceId": 10
  },
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


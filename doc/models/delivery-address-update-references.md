
# Delivery Address Update References

List of Delivery address update entity. The fields of this entity are described below.

## Structure

`DeliveryAddressUpdateReferences`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardId` | `int?` | Optional | CardId |
| `CardPAN` | `string` | Optional | PAN of the card. |
| `AccountId` | `int?` | Optional | AccountId |
| `AccountNumber` | `string` | Optional | Account number |
| `ReferenceId` | `int?` | Optional | Individual delivery address update reference number for the delivery address update request. |
| `ErrorInfo` | `string` | Optional | Individual error information for the delivery address update request. |

## Example (as JSON)

```json
{
  "CardId": 12345,
  "CardPAN": "7002051006629889654",
  "AccountId": 12356,
  "AccountNumber": "GB000000124",
  "ReferenceId": 573567,
  "ErrorInfo": "null"
}
```



# Restriction Card Response Data Items

## Structure

`RestrictionCardResponseDataItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the customer. |
| `AccountNumber` | `string` | Optional | Account Number of the customer. |
| `CardId` | `int?` | Optional | Unique Card Id |
| `DayTimeRestrictionDescription` | `string` | Optional | This field will have a value only when “DayTimeRestrictionStatus” is “Failed”. |
| `DayTimeRestrictionStatus` | `string` | Optional | Status of the card day/time restriction submitted to API. Based on the response from API value will be set as either “Success” or “Failed”. |
| `LocationRestrictionDescription` | `string` | Optional | This field will have a value only when “LocationRestrictionStatus” is “Failed”. |
| `LocationRestrictionStatus` | `string` | Optional | Card Location restriction submitted to gateway based on gateway response value set as “Success” or “Failed”. |
| `PAN` | `string` | Optional | Card PAN |
| `ProductRestrictionDescription` | `string` | Optional | This field will have a value only when “ProductRestrictionStatus” is “Failed”. |
| `ProductRestrictionStatus` | `string` | Optional | Status of the card product restriction submitted |
| `UsageRestrictionDescription` | `string` | Optional | This field will have a value only when “UsageRestrictionStatus” is “Failed”. |
| `UsageRestrictionStatus` | `string` | Optional | Status of the card usage restriction submitted |
| `ValidationErrorCode` | `string` | Optional | Error code for validation failure.<br>Example error codes:<br>0007, 9007, 7000, 7001. |
| `ValidationErrorDescription` | `string` | Optional | Description of validation failure. |

## Example (as JSON)

```json
{
  "AccountId": 182,
  "AccountNumber": "AccountNumber8",
  "CardId": 88,
  "DayTimeRestrictionDescription": "DayTimeRestrictionDescription8",
  "DayTimeRestrictionStatus": "DayTimeRestrictionStatus8"
}
```


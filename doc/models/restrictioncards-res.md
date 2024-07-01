
# Restrictioncards Res

## Structure

`RestrictioncardsRes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Example: GB000000123 |
| `CardId` | `string` | Optional | Unique Card Id<br>Example: 275549 |
| `PAN` | `string` | Optional | Card PAN.<br>Example: 7002051006629890645 |
| `UsageRestrictionStatus` | `string` | Optional | Status of the card usage restriction submitted. Based on the response the value will be set as either “Success” or “Failed”. |
| `UsageRestrictionDescription` | `string` | Optional | Response for the usage restriction in case of an error. This field will have a value only when “UsageRestrictionStatus” is “Failed”. |
| `DayTimeRestrictionStatus` | `string` | Optional | Status of the card day/time restriction submitted. Based on the response from Gateway value will be set as either “Success” or “Failed”. |
| `DayTimeRestrictionDescription` | `string` | Optional | Response for the day/time restriction in case of an error. This field will have a value only when “DayTimeRestrictionStatus” is “Failed”. |
| `ProductRestrictionStatus` | `string` | Optional | Status of the card product restriction submitted. Based on the response  the value will be set  either as “Success” or “Failed”. |
| `ProductRestrictionDescription` | `string` | Optional | Response for the product restriction in case of an error. This field will have a value only when “ProductRestrictionStatus” is “Failed”. |
| `LocationRestrictionStatus` | `string` | Optional | Card Location restriction submitted, based on response value set as “Success” or “Failed”. |
| `LocationRestrictionStatusDescription` | `string` | Optional | Response for the location restriction in case of an error. This field will have a value only when “LocationRestrictionStatus” is “Failed”. |
| `ValidationErrorCode` | `string` | Optional | Error code for validation failure. |
| `ValidationErrorDescription` | `string` | Optional | Description of validation failure. |

## Example (as JSON)

```json
{
  "AccountId": 148,
  "AccountNumber": "AccountNumber0",
  "CardId": "CardId0",
  "PAN": "PAN2",
  "UsageRestrictionStatus": "UsageRestrictionStatus0"
}
```


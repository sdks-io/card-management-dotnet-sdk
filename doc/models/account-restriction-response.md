
# Account Restriction Response

## Structure

`AccountRestrictionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `AccountId` | `int?` | Optional | Account Id on which restriction is applied.<br>Example: 123456 |
| `AccountNumber` | `string` | Optional | Account Number on which restriction is applied.<br>Example: GB000000123 |
| `UsageRestrictionStatus` | `string` | Optional | Status of the card usage restriction submitted to Gateway. Based on the response from Gateway value will be set as either “Success” or “Failed”. |
| `UsageRestrictionDescription` | `string` | Optional | Response for the usage restriction in case of an error. This field will have a value only when “UsageRestrictionStatus” is “Failed”. |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "AccountId": 130,
  "AccountNumber": "AccountNumber8",
  "UsageRestrictionStatus": "UsageRestrictionStatus8",
  "UsageRestrictionDescription": "UsageRestrictionDescription2"
}
```


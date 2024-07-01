
# Search Account Limit Response

## Structure

`SearchAccountLimitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Request Id of the API call |
| `AccountId` | `int?` | Optional | Account ID of the customer. |
| `AccountNumber` | `string` | Optional | Account Number<br>Example: GB99215176 |
| `ReferenceProduct` | `string` | Optional | 3 digit Shell global fuel product code, if already set up.<br>Example: 021 |
| `RestrictionCondition` | `string` | Optional | The restriction condition code.<br>Example: DECLINE_ALERT |
| `VelocityLimits` | [`List<AccountVelocityLimit>`](../../doc/models/account-velocity-limit.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "2ace3991-5d03-4a68-ac68-ca9119b25101",
  "AccountId": 114,
  "AccountNumber": "AccountNumber2",
  "ReferenceProduct": "ReferenceProduct2",
  "RestrictionCondition": "RestrictionCondition0"
}
```



# Accounts

## Structure

`Accounts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the customer.<br>Optional, if AccountNumber is passed, else mandatory. |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Optional, if AccountId is passed, else mandatory. |

## Example (as JSON)

```json
{
  "AccountId": 3453,
  "AccountNumber": "GB000000124"
}
```


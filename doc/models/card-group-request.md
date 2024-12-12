
# Card Group Request

## Structure

`CardGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer id of the customer.<br>Optional if PayerNumber is passed, else Mandatory.<br>This input is a search criterion.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | PayerNumber of the customer.<br>Optional if PayerId is passed, else Mandatory.<br>This input is a search criterion.<br>Example: GB00123456 |
| `Account` | [`List<Accounts>`](../../doc/models/accounts.md) | Optional | - |
| `CardGroupName` | `string` | Optional | Card Group Name<br>Optional.<br>Minimum of 2 characters should be provided else not considered.<br>CardGroups those have the entered value at any part |
| `Status` | `string` | Optional | Card Group Status<br>Mandatory<br>Allowed values:<br>•    ALL<br>•    TERMINATED<br>•    ACTIVE |
| `CurrentPage` | `int?` | Optional | Page Number (as shown to the users)<br>Optional<br>Default value 1 |
| `PageSize` | `int?` | Optional | Page Size – Number of records to show on a page.<br>Optional<br>Default value 50.<br>Return all rows if -1 is supplied as page size. |

## Example (as JSON)

```json
{
  "ColCoId": 14,
  "ColCoCode": 14,
  "PayerId": 123,
  "PayerNumber": "GB00123456",
  "CardGroupName": "test",
  "Status": "ALL",
  "PageSize": 1,
  "Account": [
    {
      "AccountId": 66,
      "AccountNumber": "AccountNumber2"
    },
    {
      "AccountId": 66,
      "AccountNumber": "AccountNumber2"
    }
  ]
}
```


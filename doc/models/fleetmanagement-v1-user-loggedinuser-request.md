
# Fleetmanagement V1 User Loggedinuser Request

## Structure

`FleetmanagementV1UserLoggedinuserRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IncludePayerGroup` | `bool?` | Optional | True/False. The output will include the payer group information only when true is passed.<br>**Default**: `false` |
| `IncludeEIDDetails` | `bool?` | Optional | True/False. The output will include the EID (Electronic Invoice data) information only when true is passed..<br>**Default**: `false` |
| `RequestedAPIName` | `string` | Optional | Name of the API on which user access needs to be validated<br>Optional. |
| `PayerId` | `int?` | Optional | Payer id of the customer.</br><br>Optional.</br><br>This input is a search criterion.</br><br>Note: If PayerId or PayerNumber is provided in the input, the given payer will be available in the output if the user has access to the given payer. |
| `PayerNumber` | `string` | Optional | PayerNumber of the customer.</br><br>Optional</br><br>This input is a search criterion.</br><br>Note: If Payerid or PayerNumber is provided in the input, the given payer will be available in the output if the user has access to the given payer. |

## Example (as JSON)

```json
{
  "IncludePayerGroup": false,
  "IncludeEIDDetails": false,
  "RequestedAPIName": "Name of the API",
  "PayerId": 123456,
  "PayerNumber": "GB00123456"
}
```



# Order Card Response

## Structure

`OrderCardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Unique request identifier passed from end user. This identifier helps in tracing a transaction |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCESS, FAILED |
| `Data` | [`List<CreateCardResponse>`](../../doc/models/create-card-response.md) | Optional | - |
| `MainReference` | `int?` | Optional | Main order reference number for tracking. |

## Example (as JSON)

```json
{
  "RequestId": "RequestId2",
  "Status": "Status8",
  "Data": [
    {
      "DriverAndVRN": "DriverAndVRN6",
      "OrderCardReference": 86
    }
  ],
  "MainReference": 110
}
```


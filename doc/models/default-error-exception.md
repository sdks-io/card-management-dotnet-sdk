
# Default Error Exception

Error response

## Structure

`DefaultErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Fault` | [`DefaultErrorFault`](../../doc/models/default-error-fault.md) | Optional | Error object |

## Example (as JSON)

```json
{
  "fault": {
    "faultstring": "faultstring2",
    "detail": {
      "errorcode": "errorcode6"
    }
  }
}
```


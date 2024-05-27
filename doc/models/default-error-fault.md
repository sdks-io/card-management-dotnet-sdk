
# Default Error Fault

Error object

## Structure

`DefaultErrorFault`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Faultstring` | `string` | Optional | Error Description |
| `Detail` | [`DefaultErrorFaultDetail`](../../doc/models/default-error-fault-detail.md) | Optional | Details about the error |

## Example (as JSON)

```json
{
  "faultstring": "faultstring8",
  "detail": {
    "errorcode": "errorcode6"
  }
}
```


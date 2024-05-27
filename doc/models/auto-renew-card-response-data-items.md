
# Auto Renew Card Response Data Items

## Structure

`AutoRenewCardResponseDataItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoRenewReferenceId` | `int?` | Optional | CardId and PAN of the card. ;( Semicolon is used as delimiter. |
| `CardIdAndPAN` | `string` | Optional | Reference number for each individual auto renew card in the order. |

## Example (as JSON)

```json
{
  "AutoRenewReferenceId": 84,
  "CardIdAndPAN": "CardIdAndPAN6"
}
```


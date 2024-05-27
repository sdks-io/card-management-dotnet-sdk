
# Product Group

## Structure

`ProductGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReferenceId` | `int?` | Optional | Referenced Purchase Category Id<br>Example: 123, 124 |
| `ProductGroupId` | `string` | Optional | Product group ID |
| `Name` | `string` | Optional | Product group name |
| `IsDefault` | `bool?` | Optional | Indicates whether this is a default Product Group at ColCo level or not.<br>Note: The Customer level default settings are not considered here. |
| `IsFuelType` | `bool?` | Optional | Identifies the type of Product group.<br>true - if it is a Fuel type Product group<br>false - if it is Non-Fuel type |
| `Products` | [`List<ProductAllOf0>`](../../doc/models/product-all-of-0.md) | Optional | - |

## Example (as JSON)

```json
{
  "ReferenceId": 123,
  "ProductGroupId": "7",
  "Name": "Automotive Gas Oil",
  "IsDefault": false,
  "IsFuelType": false
}
```


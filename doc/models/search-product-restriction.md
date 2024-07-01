
# Search Product Restriction

## Structure

`SearchProductRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Products` | [`List<RestrictionProduct>`](../../doc/models/restriction-product.md) | Optional | - |
| `ProductGroups` | [`List<ProductGroup>`](../../doc/models/product-group.md) | Optional | - |

## Example (as JSON)

```json
{
  "Products": [
    {
      "GlobalProductCode": "GlobalProductCode6",
      "Description": "Description8"
    },
    {
      "GlobalProductCode": "GlobalProductCode6",
      "Description": "Description8"
    }
  ],
  "ProductGroups": [
    {
      "ReferenceId": 82,
      "ProductGroupId": "ProductGroupId6",
      "Name": "Name0",
      "IsDefault": false,
      "IsFuelType": false
    }
  ]
}
```



# Purchase Category Response

## Structure

`PurchaseCategoryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PurchaseCategories` | [`List<PurchaseCategory1AllOf0>`](../../doc/models/purchase-category-1-all-of-0.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "PurchaseCategories": [
    {
      "Id": 166,
      "Code": "Code6",
      "Name": "Name4",
      "IsVisible": false,
      "ProductGroups": [
        {
          "ReferenceId": 82,
          "ProductGroupId": "ProductGroupId6",
          "Name": "Name0",
          "IsDefault": false,
          "IsFuelType": false
        }
      ],
      "Title": "Title4",
      "Description": "Description0"
    },
    {
      "Id": 166,
      "Code": "Code6",
      "Name": "Name4",
      "IsVisible": false,
      "ProductGroups": [
        {
          "ReferenceId": 82,
          "ProductGroupId": "ProductGroupId6",
          "Name": "Name0",
          "IsDefault": false,
          "IsFuelType": false
        }
      ],
      "Title": "Title4",
      "Description": "Description0"
    },
    {
      "Id": 166,
      "Code": "Code6",
      "Name": "Name4",
      "IsVisible": false,
      "ProductGroups": [
        {
          "ReferenceId": 82,
          "ProductGroupId": "ProductGroupId6",
          "Name": "Name0",
          "IsDefault": false,
          "IsFuelType": false
        }
      ],
      "Title": "Title4",
      "Description": "Description0"
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```


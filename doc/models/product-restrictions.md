
# Product Restrictions

## Structure

`ProductRestrictions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Products` | `List<string>` | Optional | An array of 3-digit global product codes.<br>Optional. However, this field is mandatory when the Product restrictions are migrated to Gateway and Product Groups are not provided.<br>Example: [ "033", "021", "023" ] |
| `ProductGroups` | `List<string>` | Optional | An array of product group ids.<br>Optional. However, this field is mandatory when the Product restrictions are migrated to Gateway and Products are not provided.<br>Example: [ "670246404", "40557126" ] |

## Example (as JSON)

```json
{
  "Products": [
    "Products4"
  ],
  "ProductGroups": [
    "ProductGroups3",
    "ProductGroups4"
  ]
}
```


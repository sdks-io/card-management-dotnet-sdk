
# Restriction

## Structure

`Restriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UsageRestrictions` | `object` | Optional | - |
| `DayTimeRestrictions` | [`DayTimeRestrictions`](../../doc/models/day-time-restrictions.md) | Optional | - |
| `ProductRestrictions` | [`SearchProductRestriction`](../../doc/models/search-product-restriction.md) | Optional | - |
| `LocationRestrictions` | [`LocationRestriction`](../../doc/models/location-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "UsageRestrictions": {
    "key1": "val1",
    "key2": "val2"
  },
  "DayTimeRestrictions": {
    "Monday": false,
    "Tuesday": false,
    "Wednesday": false,
    "Thursday": false,
    "Friday": false
  },
  "ProductRestrictions": {
    "Products": [
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
      },
      {
        "ReferenceId": 82,
        "ProductGroupId": "ProductGroupId6",
        "Name": "Name0",
        "IsDefault": false,
        "IsFuelType": false
      }
    ]
  },
  "LocationRestrictions": {
    "CountryRestrictions": {
      "Countries": [
        "Countries7"
      ],
      "Exclusive": false
    },
    "NetworkRestrictions": [
      {
        "Country": "Country6",
        "Networks": [
          "Networks3",
          "Networks4",
          "Networks5"
        ],
        "Exclusive": false
      },
      {
        "Country": "Country6",
        "Networks": [
          "Networks3",
          "Networks4",
          "Networks5"
        ],
        "Exclusive": false
      }
    ],
    "ShellSiteRestrictions": [
      {
        "Country": "Country4",
        "Sites": [
          "Sites3",
          "Sites4"
        ],
        "SiteGroups": [
          "SiteGroups9",
          "SiteGroups8",
          "SiteGroups7"
        ],
        "Exclusive": false
      },
      {
        "Country": "Country4",
        "Sites": [
          "Sites3",
          "Sites4"
        ],
        "SiteGroups": [
          "SiteGroups9",
          "SiteGroups8",
          "SiteGroups7"
        ],
        "Exclusive": false
      }
    ],
    "PartnerSiteRestrictions": [
      {
        "NetworkCode": "NetworkCode2",
        "Sites": [
          "Sites3"
        ],
        "SiteGroups": [
          "SiteGroups1",
          "SiteGroups2"
        ],
        "Exclusive": false
      }
    ]
  }
}
```


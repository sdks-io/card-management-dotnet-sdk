
# Country Restriction

## Structure

`CountryRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Countries` | `List<string>` | Optional | A list of ISO 3166-1 Numeric-3 country codes.<br>Example: 826 for United Kingdom. |
| `Exclusive` | `bool?` | Optional | Flag indicates whether the profile is inclusive or exclusive.<br>Example: False - (inclusive), i.e. the “Countries” property lists the countries where the transactions will be allowed.<br>True - (exclusive), i.e. the “Countries” property lists the countries where the transactions will be declined. |

## Example (as JSON)

```json
{
  "Countries": [
    "Countries9",
    "Countries0",
    "Countries1"
  ],
  "Exclusive": false
}
```


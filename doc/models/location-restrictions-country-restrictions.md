
# Location Restrictions Country Restrictions

An entity that encapsulate the country restrictions.
Optional.

## Structure

`LocationRestrictionsCountryRestrictions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Exclusive` | `bool` | Required | Boolean	Flag indicates whether the profile is inclusive or exclusive.<br>Mandatory<br>Example: False - (inclusive), i.e. the “Countries” property lists the countries where the transactions will be allowed.<br>True - (exclusive), i.e. the “Countries” property lists the countries where the transactions will be declined. |
| `Countries` | `List<string>` | Required | ISO 3166-1 Numeric-3 code of the country where the network restriction is applied.<br>Example: 826 for United Kingdom.<br>Mandatory |

## Example (as JSON)

```json
{
  "Exclusive": false,
  "Countries": [
    "Countries3",
    "Countries4"
  ]
}
```


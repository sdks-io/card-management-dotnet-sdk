
# Address

## Structure

`Address`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressId` | `int?` | Optional | Address Id in cards platform. |
| `AddressLine1` | `string` | Optional | Address line1 |
| `AddressLine2` | `string` | Optional | Address line2 |
| `AddressLine3` | `string` | Optional | AddressLine3 |
| `ZipCode` | `string` | Optional | ZipCode |
| `City` | `string` | Optional | City |
| `RegionId` | `int?` | Optional | Region Id of the address. |
| `CountryISOCode` | `string` | Optional | Country ISO code of the address |
| `Country` | `string` | Optional | Country for the address |
| `Telephone` | `string` | Optional | Telephone number of the address contact |
| `EmailAddress` | `string` | Optional | Email address of the address contact |
| `Fax` | `string` | Optional | Fax number of the address contact |

## Example (as JSON)

```json
{
  "AddressId": 1,
  "AddressLine1": "test street",
  "AddressLine2": "Address line2",
  "AddressLine3": "AddressLine3",
  "ZipCode": "667 78",
  "City": "LUMPUR",
  "RegionId": 1234,
  "CountryISOCode": "CZ",
  "Country": "Germany",
  "Telephone": "3245872364823",
  "EmailAddress": "testmail@gmail.com",
  "Fax": "3245872364823"
}
```



# Delivery Addresses

## Structure

`DeliveryAddresses`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressId` | `int?` | Optional | Address Id |
| `AddressLine1` | `string` | Optional | AddressLine1 |
| `AddressLine2` | `string` | Optional | AddressLine2 |
| `AddressLine3` | `string` | Optional | AddressLine3 |
| `City` | `string` | Optional | City |
| `CompanyName` | `string` | Optional | Account Name |
| `ContactForeName` | `string` | Optional | Contact fore name of the delivery address. |
| `ContactLastName` | `string` | Optional | Contact last name of the delivery address. |
| `ContactMiddleName` | `string` | Optional | Contact middle name of the delivery address. |
| `ContactTitle` | `string` | Optional | ContactTitle |
| `Country` | `string` | Optional | Country |
| `CountryId` | `int?` | Optional | Country Id |
| `CountryISOCode` | `string` | Optional | Country ISO code |
| `Fax` | `string` | Optional | Fax number of the address contact. |
| `Region` | `string` | Optional | Region of the Card Delivery address |
| `RegionId` | `int?` | Optional | Region Id of the address. |
| `Telephone` | `string` | Optional | Telephone number of the address contact |
| `ZipCode` | `string` | Optional | Delivery Zip code |
| `AddressType` | `int?` | Optional | Delivery address type.<br>Possible Values:<br>1 – Card and PIN delivery address<br>2 – Card delivery address<br>3 – PIN delivery address |

## Example (as JSON)

```json
{
  "AddressId": 1,
  "AddressLine1": "AddressLine1",
  "AddressLine2": "AddressLine2",
  "AddressLine3": "AddressLine3",
  "City": "germany",
  "CompanyName": "5.11.3 DE",
  "ContactForeName": "5.11.13 DE",
  "ContactLastName": "SAM",
  "ContactMiddleName": "SAM",
  "ContactTitle": "Mr",
  "Country": "Germany",
  "CountryId": 9,
  "CountryISOCode": "DE",
  "Fax": "657875",
  "Region": "Germany",
  "RegionId": 133,
  "Telephone": "78787786868",
  "ZipCode": "E14 5HQ",
  "AddressType": 1
}
```


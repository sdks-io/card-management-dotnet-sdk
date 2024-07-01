
# PIN Delivery Address

## Structure

`PINDeliveryAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContactForeName` | `string` | Optional | Fore name of the contact person |
| `ContactMiddleName` | `string` | Optional | Middle name of the contact person |
| `ContactLastName` | `string` | Optional | Last name of the contact person |
| `ContactTitle` | `string` | Optional | Title of the contact person Optional Max field length- 10 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.<br>**Constraints**: *Maximum Length*: `10` |
| `CompanyName` | `string` | Required | Company name Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. True, Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request. |
| `AddressId` | `int` | Required | Address Id in cards platform. |
| `AddressLine1` | `string` | Required | Address line 1 Mandatory if IsNewDeliveryAddress and OrderReplacement are passed True. Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.<br>**Constraints**: *Minimum Length*: `1` |
| `AddressLine2` | `string` | Optional | Address line 2 Optional Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request. |
| `AddressLine3` | `string` | Optional | Address line Optional Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request. |
| `ZipCode` | `string` | Required | ZIP code Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. True, Max field length- 10 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.<br>**Constraints**: *Maximum Length*: `10` |
| `City` | `string` | Optional | City Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.<br>**Constraints**: *Maximum Length*: `40` |
| `RegionId` | `int?` | Optional | Region Id |
| `Region` | `string` | Optional | Region Optional When region is passed, Shell Card Platform will look up for the region id for the given region.  If the option to clear personal details is set in the Shell Card Platform, then this value will be cleared from the record after processing the request . |
| `CountryId` | `int` | Required | Country Id in cards platform. |
| `CountryISOCode` | `string` | Required | The ISO code of the country. Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. If the option to clear personal details is set in the Shell Card Platform, then this value will be cleared from the record after processing the request . |
| `Country` | `string` | Required | Country name. |

## Example (as JSON)

```json
{
  "ContactForeName": "ROBERT",
  "ContactMiddleName": "M",
  "ContactLastName": "Langdon",
  "ContactTitle": "Mr.",
  "CompanyName": "PARKLEY Philippines",
  "AddressId": 1768,
  "AddressLine1": "No 345, 1st cross,",
  "AddressLine2": "10th avenue",
  "AddressLine3": "makati city",
  "ZipCode": "1630",
  "City": "manila",
  "Region": "EU",
  "CountryId": 1,
  "CountryISOCode": "PH",
  "Country": "Philippines"
}
```


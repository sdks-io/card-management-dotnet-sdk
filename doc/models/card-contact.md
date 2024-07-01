
# Card Contact

## Structure

`CardContact`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeliveryContactTitle` | `string` | Optional | Title of the contact person <br /><br>Optional<br>Max field length: 10<br>**Constraints**: *Maximum Length*: `10` |
| `DeliveryContactName` | `string` | Required | Name of the contact person <br /><br>Mandatory  <br /><br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `DeliveryCompanyName` | `string` | Required | Company name <br /><br>Mandatory  <br /><br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `DeliveryAddressLine1` | `string` | Required | Address line 1 <br /><br>Mandatory<br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryAddressLine2` | `string` | Optional | Address line 2 <br /><br>Optional <br /><br>Max field length: 40  <br /><br>Optional<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryAddressLine3` | `string` | Optional | Address line 3 <br /><br>Optional <br /><br>Max field length: 40  <br /><br>Optional<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryZipCode` | `string` | Required | ZIP code <br /><br>Mandatory  <br /><br>Max field length: 10  <br /><br>Optional<br>**Constraints**: *Maximum Length*: `10` |
| `DeliveryCity` | `string` | Required | City  <br /><br>Mandatory  <br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryRegionId` | `int?` | Optional | Region Id  <br /><br>Optional |
| `DeliveryRegion` | `string` | Optional | Region  <br /><br>Optional<br /><br>When region is passed |
| `DeliveryCountry` | `string` | Required | The ISO code of the country.<br /> |
| `PhoneNumber` | `string` | Optional | Phone number for courier delivery.<br /><br>Optional.<br /><br>Max field length: 20<br>**Constraints**: *Maximum Length*: `20` |
| `EmailAddress` | `string` | Optional | Email address for courier delivery.<br /><br>Optional.<br /><br>Max field length: 90 <br/>Note:Based on the international standard that there can be Max Length 64 before the @ (the 'Local part’) =64(minimum of 1) Max Lenth after the (the domain) = 88 (Minimum of 2)<br>**Constraints**: *Maximum Length*: `90` |
| `SaveForCardReissue` | `bool?` | Optional | If this is specified, the contact address will be saved in cards platform for card reissue processing.<br /><br>Optional |

## Example (as JSON)

```json
{
  "DeliveryContactTitle": "DeliveryContactTitle4",
  "DeliveryContactName": "DeliveryContactName0",
  "DeliveryCompanyName": "DeliveryCompanyName2",
  "DeliveryAddressLine1": "DeliveryAddressLine18",
  "DeliveryAddressLine2": "DeliveryAddressLine20",
  "DeliveryAddressLine3": "DeliveryAddressLine32",
  "DeliveryZipCode": "DeliveryZipCode0",
  "DeliveryCity": "DeliveryCity2",
  "DeliveryRegionId": 152,
  "DeliveryRegion": "DeliveryRegion4",
  "DeliveryCountry": "DeliveryCountry0"
}
```


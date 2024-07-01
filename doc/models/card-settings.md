
# Card Settings

## Structure

`CardSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SelfSelectedEncryptedPIN` | `string` | Optional | The encrypted value of self-selected PIN.<br /><br>Optional – When not provided, the PIN will be auto generated(if the card token type supports PIN) and delivered based on the given PIN delivery option.<br /><br>Max Length: 256<br>**Constraints**: *Maximum Length*: `256` |
| `SelfSelectedPINKeyID` | `string` | Optional | KeyId of the PIN encrypted value.<br /><br>Mandatory, if opted for self-selected PIN else optional.<br /><br>Max Length: 30<br>**Constraints**: *Maximum Length*: `30` |
| `SelfSelectedPINSessionKey` | `string` | Optional | Encoded message of the TCS form which is used for encrypting the PIN of this card.<br /><br>The encode message forms are provided to clients by another API (“TCS”).<br /><br>Instructions to encrypt the PIN is covered in the related API specifications document.<br /><br>Mandatory –If opted for self-selected PIN else optional.<br>Max Length: 1024<br>**Constraints**: *Maximum Length*: `1024` |
| `ValidateFleetId` | `bool?` | Optional | True/False.<br /><br>Optional <br /><br>Default: False<br /><br>For cards ordered with Validate Fleet Id parameter set to true, CFGW will be notified to enable this validation for the card.<br /><br>Note: When “FleetIdInputRequired” is not set on the card, validate fleet id will be considered false regardless of the value passed on this parameter. |
| `CardGroupId` | `int?` | Optional | Existing Card Group ID, under which the replacement card is to be created.<br /><br>Pass “-1” if the replacement card should not be assigned to any card group.<br /><br>Optional <br /><br>If not provided, the replacement card will be created under the same card group as the current card. |
| `CardDeliveryType` | `int?` | Required | Card delivery type.<br /><br>Mandatory <br /><br>Allowed Value: <br /><br><br>1. Customer Address(Default) <br /><br>2. New Delivery Address <br /><br>3. Old Card Address |
| `DeliveryContactTitle` | `string` | Optional | Title of the contact person. <br /><br>Optional<br /><br>Max field length: 10<br>**Constraints**: *Maximum Length*: `10` |
| `DeliveryContactName` | `string` | Optional | Name of the contact person <br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br /><br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `DeliveryCompanyName` | `string` | Optional | Company name <br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `DeliveryAddressLine1` | `string` | Optional | Address line 1 <br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryAddressLine2` | `string` | Optional | Address line 2 <br /><br>Optional <br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryAddressLine3` | `string` | Optional | Address line 3 <br /><br>Optional<br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryZipCode` | `string` | Optional | ZIP code <br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br /><br>Max field length: 10<br>**Constraints**: *Maximum Length*: `10` |
| `DeliveryCity` | `string` | Optional | City  <br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `DeliveryRegionId` | `int?` | Optional | Region Id  <br /><br>Optional |
| `DeliveryRegion` | `string` | Optional | Region  <br /><br>Optional<br /><br>When region is passed |
| `DeliveryCountry` | `string` | Optional | The ISO code of the country.<br /><br>Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true |
| `DeliveryCountryId` | `int?` | Optional | The countryId of gicen country.<br /> |
| `PhoneNumber` | `string` | Optional | Phone number for to send SMS. <br /><br>Optional<br /><br>Max field length: 20<br>**Constraints**: *Maximum Length*: `16` |
| `EmailAddress` | `string` | Optional | Email address for to send email.<br /><br>Mandatory if PINAdviceType is email else optional.<br /><br>Max field length: 90<br>**Constraints**: *Maximum Length*: `90` |
| `PINDeliveryAddressType` | `int?` | Optional | PIN delivery address type selection.<br /><br>Optional<br /><br>Allowed Values:<br /><br><br>1. Customer Address(Default)<br /><br>2. Card Address<br /><br>3. New Delivery Address |
| `PINAdviceType` | `int?` | Optional | PIN delivery method.<br /><br>Mandatory when OrderReplacement Is true.<br /><br>Allowed Values:<br /><br><br>1. Paper<br /><br>2. Email<br /><br>3. SMS<br /><br>4. None |
| `PINDeliveryContactTitle` | `string` | Optional | Title of the contact person.<br /><br>Optional <br /><br>Max field length: 10<br>**Constraints**: *Maximum Length*: `10` |
| `PINDeliveryContactName` | `string` | Optional | Name of the contact person.<br /><br>Mandatory - If PINAdviceType is paper else optional.<br /><br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `PINDeliveryCompanyName` | `string` | Optional | Company name.<br /><br>Mandatory - If PINAdviceType is paper else optional.<br /><br>Max field length: 50<br>**Constraints**: *Maximum Length*: `50` |
| `PINDeliveryAddressLine1` | `string` | Optional | Address line 1.<br /><br>Mandatory - If PINAdviceType is paper else optional.<br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `PINDeliveryAddressLine2` | `string` | Optional | Address line 2.<br /><br>Optional <br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `PINDeliveryAddressLine3` | `string` | Optional | Address line 3.<br /><br>Optional <br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `PINDeliveryZipCode` | `string` | Optional | ZIP code.<br /><br>Mandatory - if PINAdviceType is paper else optional. <br /><br>Max field length: 10<br>**Constraints**: *Maximum Length*: `10` |
| `PINDeliveryCity` | `string` | Optional | City.<br /><br>Mandatory - If PINAdviceType is paper else optional. <br /><br>Max field length: 40<br>**Constraints**: *Maximum Length*: `40` |
| `PINDeliveryRegionId` | `int?` | Optional | Region Id.<br /><br>Optional |
| `PINDeliveryRegion` | `string` | Optional | Region.<br /><br>When region is passed |
| `PINDeliveryCountry` | `string` | Optional | The ISO code of the country.<br /><br>Mappings for ISO code <br /><br>Mandatory if PINAdviceType is paper else optional. |
| `PINDeliveryCountryId` | `int?` | Optional | The countryId of the country.<br /><br>Mappings for ISO code<br /><br>This is not an input parameter. |
| `PINPhoneNumber` | `string` | Optional | Phone number for to send SMS of the PIN in case PINAdviceType is SMS.<br /><br>Mandatory if PINAdviceType is SMS else optional.<br /><br>Max field length: 20<br>**Constraints**: *Maximum Length*: `16` |
| `PINEmailAddress` | `string` | Optional | Email address for to send email of the PIN in case PINAdviceType is Email.<br /><br>Mandatory if PINAdviceType is email else optional.<br /><br>Max field length: 90<br>**Constraints**: *Maximum Length*: `90` |
| `SaveForPINReminder` | `bool?` | Optional | The given address will be used for sending PIN reminders in future when requested.<br /><br>PIN Advice type should be Paper<br>Optional |
| `SaveForCardReissue` | `bool?` | Optional | If this is specified, the contact address will be saved in cards platform for card reissue processing.<br /><br>Optional |
| `ExpiryDate` | `string` | Optional | Expiry Date for newly created card to be update in cards plot form.<br /><br>Optional <br /><br>Format: MMyy <br /><br>Eg:1221 <br /><br>If not apply the default Expiry Date.<br /><br>Note:<br /><br>There is a limit to the ExpiryDate which the user can choose for the Card.<br>If the user chooses a later ExpiryDate than the allowed value for the CardType of the OU,<br>the background service logs the respective error code and description<br>**Constraints**: *Maximum Length*: `4` |

## Example (as JSON)

```json
{
  "SelfSelectedEncryptedPIN": "SelfSelectedEncryptedPIN8",
  "SelfSelectedPINKeyID": "SelfSelectedPINKeyID2",
  "SelfSelectedPINSessionKey": "SelfSelectedPINSessionKey4",
  "ValidateFleetId": false,
  "CardGroupId": 118,
  "CardDeliveryType": 2
}
```


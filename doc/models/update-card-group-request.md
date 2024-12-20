
# Update Card Group Request

## Structure

`UpdateCardGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoId` | `int?` | Optional | Collecting Company Id  of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1-Philippines<br>5-UK |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory |
| `PayerId` | `int?` | Optional | Payer Id (i.e., Customer Id of the Payment Customer) of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `AccountId` | `int?` | Optional | Account ID of the card-group to be updated/terminated. |
| `AccountNumber` | `string` | Optional | Account Number of the card-group to be updated/terminated. |
| `CardGroupId` | `int?` | Optional | Unique Id of the card group that needs to be updated or terminated. |
| `CardGroupName` | `string` | Optional | New name for the card group if it needs to be updated. Set this field to ‘null’ if no change required to the current card group name.<br><br>Optional<br><br>Minimum length: 1 (Configurable)<br>Maximum length: 40 (Configurable)<br>Allowed characters (Configurable) are: - A-Z 0-9, / ‘. & Ä Ö Ü Å Æ É Ø<br>Note: The card group name has to be unique for customer. Else an error with error code 9015 is returned. |
| `PrintOnCard` | `bool?` | Optional | Whether to emboss the card group name on the cards.<br>Populate this field only if the value needs to be updated. Otherwise set to ‘null’. |
| `CardTypeId` | `int?` | Optional | Card Type ID of the card group.<br>Populate this field if the value needs to be updated. Otherwise set to ‘null’.<br>Optional<br>Note:<br><br>1) If a card type is passed, the cardgorup will allow cards with same card type to be moved in to the card group.<br>2) Pass ‘-1’ to remove the card type from the card group. |
| `TerminateCardGroup` | `bool?` | Optional | Whether to terminate the card group.<br>When set to true, the card group will be terminated by setting current date as it’s termination date.<br>Optional, False by default . |
| `MoveCards` | `bool?` | Optional | Whether to move the cards from this CardGroup in to a different or a new CardGroup.<br>Optional<br>When the value is set to ‘False’ or ‘null’, the cards that are currently in the card-group will remain under the same card-group. |
| `TargetAccountId` | `int?` | Optional | Account ID of the new/target card-group.<br>Either TargetAccountId or TargetAccountNumber is mandatory when MoveCards is set to True. |
| `TargetAccountNumber` | `string` | Optional | Account Number of the new/target card-group.<br>Either TargetAccountId or TargetAccountNumber is mandatory when MoveCards is set to True. |
| `TargetNewCardGroupName` | `string` | Optional | Name of the new card group if the cards in the existing card-group have to be moved to a new card-group.<br><br>Mandatory when MoveCards parameter is True and TargetCardGroupId is null.<br><br>Minimum length: 1 (Configurable)<br>Maximum length: 30 (Configurable) |
| `TargetCardGroupId` | `int?` | Optional | ID of the card group if the cards in the existing card-group have to be moved to another existing card-group.<br>Mandatory when MoveCards parameter is True and TargetNewCardGroupName is null.<br>If the value is “-1” then the cards will be moved out of the current CardGroup. |

## Example (as JSON)

```json
{
  "ColCoCode": 210,
  "ColCoId": 196,
  "PayerNumber": "PayerNumber0",
  "PayerId": 244,
  "AccountId": 48
}
```


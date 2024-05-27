
# Role

## Structure

`Role`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RoleName` | `string` | Optional | Role Name of the user |
| `IsCustomerAdmin` | `bool?` | Optional | Whether the role is an administrator.<br>**Default**: `true` |
| `IsCustomerUser` | `bool?` | Optional | Whether the role is a customer user.<br>**Default**: `false` |
| `IsShellAdmin` | `bool?` | Optional | True if the role is Shell user, else false.<br>**Default**: `false` |
| `IsServiceAccount` | `bool?` | Optional | True/False.<br>True if the role is Service accounts, else false.<br>**Default**: `false` |
| `IsUserAdmin` | `bool?` | Optional | True/False.<br>True, if the role allows user administration, else false.<br>**Default**: `true` |

## Example (as JSON)

```json
{
  "RoleName": "FleetManager",
  "IsCustomerAdmin": true,
  "IsCustomerUser": false,
  "IsShellAdmin": false,
  "IsServiceAccount": false,
  "IsUserAdmin": true
}
```


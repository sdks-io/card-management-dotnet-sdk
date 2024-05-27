# Restriction

APIs for Retrieve and Update restriction on cards

```csharp
RestrictionController restrictionController = client.RestrictionController;
```

## Class Name

`RestrictionController`

## Methods

* [Restriction Bundle Create](../../doc/controllers/restriction.md#restriction-bundle-create)
* [Restriction Bundle Update](../../doc/controllers/restriction.md#restriction-bundle-update)
* [Restriction Bundle Delete](../../doc/controllers/restriction.md#restriction-bundle-delete)
* [Restriction Bundle Summary](../../doc/controllers/restriction.md#restriction-bundle-summary)
* [Card Restriction](../../doc/controllers/restriction.md#card-restriction)
* [Account Restriction](../../doc/controllers/restriction.md#account-restriction)
* [Search Account Limit](../../doc/controllers/restriction.md#search-account-limit)
* [Search Card Restriction](../../doc/controllers/restriction.md#search-card-restriction)


# Restriction Bundle Create

This API enables clients to create a new card bundle and apply restrictions.

#### Supported operations

* Create bundle and include mandatory -
  * Usage, day/time, product and location restrictions
  * List of cards to add to bundle
* Create bundle and include optional identifier of bundle in external system

#### Validation rules

The following are the key validation rules with the associated error codes for failed validation-

* `7012` - At least one card must be added to the bundle
* `7011` - The total number of cards passed in the input must be 500 or less.
* `7014` - All the cards passed in the input are part of the selected account.
* `7013` - At least one restriction must be applied to the bundle i.e. either of usage, day/time, location or product restriction.
* `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week.
* `7000` - Usage restriction of the bundle is not open ended i.e. all the limits within the usage restriction must not be set to 0/null.
* `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e. Daily value should be less than equal to Monthly value if Weekly value is 0/blank.
* `0007` - Error returned if request parameters fail validation e.g. mandatory check.

```csharp
RestrictionBundleCreateAsync(
    string requestId,
    Models.CreateBundleRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CreateBundleRequest`](../../doc/models/create-bundle-request.md) | Body, Optional | Create Bundle Request body |

## Response Type

[`Task<Models.CreateBundleResponse>`](../../doc/models/create-bundle-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CreateBundleRequest body = new CreateBundleRequest
{
    Description = "",
    Cards = new List<string>
    {
        "7077141000589242081",
        "7077141000589242099",
    },
    ColCoId = 14,
    PayerId = 22884,
    AccountId = 22884,
    ExternalBundleId = "SIT3Bundle04FEB-2",
    Restrictions = new CreateBundleRequestRestrictions
    {
        UsageRestrictionAction = "None",
        DayTimeRestrictionAction = "Add",
        LocationRestrictionAction = "Add",
        DayTimeRestrictions = new DayTimeRestrictions
        {
            Friday = true,
            Monday = false,
            Saturday = true,
            Sunday = true,
            Thursday = false,
            TimeFrom = "03:10:00",
            TimeTo = "12:00:00",
            Tuesday = false,
            Wednesday = false,
        },
        LocationRestrictions = new LocationRestrictions
        {
        },
        ProductRestrictions = new ProductRestrictions
        {
            Products = new List<string>
            {
                "010",
                "011",
            },
        },
        UsageRestrictions = new UsageRestrictions
        {
            DailySpend = 1000,
            MonthlySpend = 14000,
            PerTransactionSpend = 800,
            DailyVolume = 10,
            WeeklyVolume = 100,
            MonthlyVolume = 1000,
            PerTransactionVolume = 10,
            DailyTransactionCount = 3,
            WeeklyTransactionCount = 9,
            MonthlyTransactionCount = 20,
        },
    },
};

try
{
    CreateBundleResponse result = await restrictionController.RestrictionBundleCreateAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "254745ea-7573-4eed-e714-f2a42506dba0",
  "Status": "Success",
  "Data": [
    {
      "BundleId": "31183",
      "Cards": null,
      "DayTimeRestrictionProfileId": "33395",
      "LocationRestrictionProfileId": "32326",
      "ProductRestrictionProfileId": "38029"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Restriction Bundle Update

This API enables clients to update an existing card bundle and its associated restrictions.

#### Supported operations

* Add new cards to an existing bundle
* Remove cards from existing bundle
* Update restrictions applied to existing bundle

The following are the key validation rules with the associated error codes for failed validation-

#### Validation rules

* `9007` - The cards must exist in the cards platform for adding or removing cards.
* `7014` - All the cards passed in the input are part of the selected account.
* `7018` - All the cards passed in the input are part of the selected bundle.
* `7011` - The total number of cards passed in the input must be 500 or less.
* `7012` - The action to remove cards should not result in removing all the cards from the bundle.
* `7016` - At least one restriction must be modified for â€œUpdateâ€ request action.
* `7013` - All restrictions cannot be marked for â€œResetâ€ for â€œUpdateâ€ request action.
* `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week. This validation is applicable for Update request action.
* `7000` - Usage restriction of the bundle is not open ended i.e., all the limits within the usage restriction must not be set to 0/null. This validation is applicable for Update request action.
* `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank. This validation is applicable for Update request action.
* `0007` - Error returned if request parameters fail validation e.g. at least one card must be provided in the input.

```csharp
RestrictionBundleUpdateAsync(
    string requestId,
    Models.UpdateBundleRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`UpdateBundleRequest`](../../doc/models/update-bundle-request.md) | Body, Optional | Update Bundle Request body |

## Response Type

[`Task<Models.UpdateBundleResponse>`](../../doc/models/update-bundle-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
UpdateBundleRequest body = new UpdateBundleRequest
{
    BundleId = "2207",
    RequestAction = "Add",
    ColCoId = 32,
    PayerId = 1223,
    AccountId = 1223,
    Cards = new List<string>
    {
        "7077327290224797344",
    },
    UsageRestrictionAction = "Update",
    Restrictions = new BundleRestriction
    {
    },
};

try
{
    UpdateBundleResponse result = await restrictionController.RestrictionBundleUpdateAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "13cb37b6-991f-4f37-c8c2-f4b29c916735",
  "Status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Restriction Bundle Delete

This API enables clients to delete an existing card bundle in the Shell Card Platform. Once the card bundle is deleted the usage and product restrictions of the cards that were present in the bundle will be reset based on the request.

#### Supported operations

* Delete card bundle by bundle Id

#### Validation rules

The following are the key validation rules with the associated error codes for failed validation-

* `7019` - The given card bundle is not available in the Shell Card Platform.
* `0007` - Error returned if request parameters fail validation e.g. mandatory check.

```csharp
RestrictionBundleDeleteAsync(
    string requestId,
    Models.DeleteBundleRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`DeleteBundleRequest`](../../doc/models/delete-bundle-request.md) | Body, Optional | Delete Bundle Request body |

## Response Type

[`Task<Models.DeleteBundleResponse>`](../../doc/models/delete-bundle-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
DeleteBundleRequest body = new DeleteBundleRequest
{
    BundleId = "31189",
    ColCoId = 14,
    PayerId = 22884,
    AccountId = 22884,
};

try
{
    DeleteBundleResponse result = await restrictionController.RestrictionBundleDeleteAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "13cb37b6-991f-4f37-c8c2-f4b29c916735",
  "Status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Restriction Bundle Summary

This API allows clients to get a summary of card bundles associated with Payer/Account. This API will return the basic bundle details including card and restriction details. Optionally the API will also include a count of cards that are not associated with the bundle but returned by the search criteria.

Note - to include count of cards of an account that are not associated with any bundles, in the input parameter SearchCardBundles either pass all the bundles of the account in the list or pass only account with bundle id left blank/null.

#### Supported operations

* Get summary of bundles by list of bundle Ids

```csharp
RestrictionBundleSummaryAsync(
    string requestId,
    Models.SummaryOfBundleRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`SummaryOfBundleRequest`](../../doc/models/summary-of-bundle-request.md) | Body, Optional | Summary Bundle Request body |

## Response Type

[`Task<Models.SummaryOfBundleResponse>`](../../doc/models/summary-of-bundle-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
SummaryOfBundleRequest body = new SummaryOfBundleRequest
{
    Filters = new SummaryofBundle
    {
        BundleId = new List<string>
        {
            "2343",
        },
        ColCoId = 5,
        PayerNumber = "GB00000235",
        PayerId = 291,
        AccountId = 291,
        AccountNumber = "GB00000235",
    },
};

try
{
    SummaryOfBundleResponse result = await restrictionController.RestrictionBundleSummaryAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "cf142c58-bdfa-4414-81c5-f099c0c829d7",
  "Status": "Success",
  "Data": [
    {
      "PayerId": 291,
      "PayerNumber": "GB00000235",
      "AccountId": 291,
      "AccountNumber": "GB00000235",
      "CountOfCardsNotInBundle": 205,
      "CardBundles": [
        {
          "BundleId": "1234",
          "ExternalBundleId": "2343",
          "Description": "CardBundle1",
          "TotalCards": 1250
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Card Restriction

This API allows to set or update the restrictions for existing cards or newly ordered cards under the same payer.

#### Supported operations

* Set or reset usage restrictions for cards
* Set or reset day/time restrictions for cards
* Set or reset product restrictions for cards
* Set or reset location restrictions for cards

```csharp
CardRestrictionAsync(
    string requestId,
    Models.RestrictionCardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`RestrictionCardRequest`](../../doc/models/restriction-card-request.md) | Body, Optional | Summary Bundle Request body |

## Response Type

[`Task<Models.RestrictionCardResponse>`](../../doc/models/restriction-card-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
RestrictionCardRequest body = new RestrictionCardRequest
{
    ColCoId = 5,
    PayerNumber = "GB00000235",
    PayerId = 291,
    Cards = new List<Models.RestrictionCardRequestCardsItems>
    {
        new RestrictionCardRequestCardsItems
        {
            AccountNumber = "GB00000235",
            AccountId = 291,
            PAN = "7002057035956000019",
            CardId = 205113,
            ResetUsageRestrictions = false,
            ResetDayTimeRestrictions = false,
            ResetProductRestrictions = false,
            ResetLocationRestrictions = false,
            DayTimeRestrictions = new DayTimeRestrictions
            {
                Friday = true,
                Monday = true,
                Saturday = false,
                Sunday = false,
                Thursday = true,
                TimeFrom = "01:00:00",
                TimeTo = "10:00:00",
                Tuesday = true,
                Wednesday = true,
            },
            LocationRestrictions = new LocationRestrictions
            {
                ShellSiteRestrictions = new List<Models.LocationRestrictionsShellSiteRestrictionsItems>
                {
                    new LocationRestrictionsShellSiteRestrictionsItems
                    {
                    },
                },
                PartnerSiteRestrictions = new List<Models.LocationRestrictionsPartnerSiteRestrictionsItems>
                {
                    new LocationRestrictionsPartnerSiteRestrictionsItems
                    {
                        NetworkCode = "0452301643",
                    },
                },
            },
            ProductRestrictions = new ProductRestrictions
            {
            },
            UsageRestrictions = new UsageRestrictions
            {
                DailySpend = 1010,
                WeeklySpend = 1620,
                MonthlySpend = 15020,
                PerTransactionSpend = 920,
                DailyVolume = 10,
                WeeklyVolume = 100,
                MonthlyVolume = 1000,
                PerTransactionVolume = 10,
                DailyTransactionCount = 6,
                WeeklyTransactionCount = 18,
                MonthlyTransactionCount = 32,
            },
        },
    },
};

try
{
    RestrictionCardResponse result = await restrictionController.CardRestrictionAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "MainReference": 1234,
  "RequestId": "cf142c58-bdfa-4414-81c5-f099c0c829d7",
  "Status": "Success",
  "Data": [
    {
      "AccountId": 291,
      "AccountNumber": "GB00000235",
      "CardId": 205113,
      "CardProductReference": null,
      "DayTimeRestrictionDescription": "0000 - Success",
      "DayTimeRestrictionStatus": "Success",
      "LocationRestrictionDescription": "0000 - Success",
      "LocationRestrictionStatus": "Success",
      "PAN": "7002057035956000019",
      "ProductRestrictionDescription": "0000 - Success",
      "ProductRestrictionStatus": "Success",
      "UsageRestrictionDescription": "0000 - Success",
      "UsageRestrictionStatus": "Success",
      "ValidationErrorCode": null,
      "ValidationErrorDescription": null
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Account Restriction

This operation allows setting or updating the usage restrictions of an existing account.

#### Validation rules

* The account exists.
* Day time restriction cannot be set to restrict the use of a card, under the account, on all days of the week.
* Either of the usage, daytime or location is either marked for reset or new restriction values provided for the account.
* In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank.

```csharp
AccountRestrictionAsync(
    string requestId,
    Models.AccountRestrictionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`AccountRestrictionRequest`](../../doc/models/account-restriction-request.md) | Body, Optional | Summary Bundle Request body |

## Response Type

[`Task<Models.AccountRestrictionResponse>`](../../doc/models/account-restriction-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
AccountRestrictionRequest body = new AccountRestrictionRequest
{
    ColCoId = 32,
    ColCoCode = 3,
    PayerNumber = "CZ00000927",
    AccountNumber = "CZ00000928",
    ResetUsageRestrictions = false,
    UsageRestrictions = new UsageRestrictions
    {
        DailySpend = 10,
        WeeklySpend = 30,
        MonthlySpend = 100,
        PerTransactionSpend = 3,
        DailyVolume = 10,
        WeeklyVolume = 146,
        MonthlyVolume = 625,
        PerTransactionVolume = 5,
        DailyTransactionCount = 5,
        WeeklyTransactionCount = 15,
        MonthlyTransactionCount = 20,
        AnnualSpend = 500,
        LifeTimeSpend = 50000,
        AnnualVolume = 1000,
        LifeTimeVolume = 5000,
        AnnualTransactionCount = 50,
        LifeTimeTransactionCount = 100,
    },
};

try
{
    AccountRestrictionResponse result = await restrictionController.AccountRestrictionAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "18c955d1-b3ec-4dc0-95da-76e67afb891a",
  "Status": "SUCCESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Search Account Limit

This operation will allow user to get account level limits for the given account.
It returns the velocity limits if its overridden at the account else the values will be null/empty.

```csharp
SearchAccountLimitAsync(
    string requestId,
    Models.SearchAccountLimitRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`SearchAccountLimitRequest`](../../doc/models/search-account-limit-request.md) | Body, Optional | Summary Bundle Request body |

## Response Type

[`Task<Models.SearchAccountLimitResponse>`](../../doc/models/search-account-limit-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
SearchAccountLimitRequest body = new SearchAccountLimitRequest
{
    Filters = new SearchAccountLimitRequestFilters
    {
        ColCoId = 14,
        ColCoCode = 14,
        PayerId = 1234,
        PayerNumber = "GB99215176",
        AccountId = 29484,
        AccountNumber = "GB99215176",
    },
};

try
{
    SearchAccountLimitResponse result = await restrictionController.SearchAccountLimitAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "27ec111b-0310-425d-b2a0-0fc2b1bfabb7",
  "Status": "SUCCESS",
  "Data": {
    "AccountId": 29484,
    "AccountNumber": "GB99215176",
    "ReferenceProduct": "021",
    "RestrictionCondition": "DECLINE_ALERT",
    "VelocityLimits": [
      {
        "Type": "VALUE",
        "Period": "DAILY",
        "Limit": 1500.55,
        "Accumulation": 1100.55,
        "Balance": 400.55,
        "Override": true,
        "ProductGroup": "RoadSvc",
        "Threshold": 50.55
      }
    ]
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Search Card Restriction

This API will allows querying card details including the day/time and product restrictions.

#### Supported operations

* Search by list of cards or bundle
* Include card bundle details (optional)

```csharp
SearchCardRestrictionAsync(
    string requestId,
    Models.RestrictionSearchCardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`RestrictionSearchCardRequest`](../../doc/models/restriction-search-card-request.md) | Body, Optional | Summary Bundle Request body |

## Response Type

[`Task<Models.RestrictionSearchCardResponse>`](../../doc/models/restriction-search-card-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
RestrictionSearchCardRequest body = new RestrictionSearchCardRequest
{
    Filters = new RestrictionSearchCardRequestFilters
    {
        ColCoCode = 32,
        ColCoId = 32,
        PayerNumber = "CZ00000923",
        PayerId = 1223,
        BundleId = "BundleId8",
        Cards = new List<Models.RestrictionSearchCardRequestFiltersCardsItems>
        {
            new RestrictionSearchCardRequestFiltersCardsItems
            {
                PAN = "7077327290223419353",
                CardId = 459629,
            },
        },
        IncludeLocationRestrictions = true,
        IncludeInheritedLimits = true,
        IncludeBundleDetails = true,
    },
};

try
{
    RestrictionSearchCardResponse result = await restrictionController.SearchCardRestrictionAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "cf142c58-bdfa-4414-81c5-f099c0c829d7",
  "Status": "Success",
  "Data": [
    {
      "BundleId": 100,
      "Restrictions": {
        "DayTimeRestrictions": {
          "Friday": true,
          "Monday": true,
          "Saturday": false,
          "Sunday": false,
          "Thursday": true,
          "TimeFrom": "01:00:00",
          "TimeTo": "10:00:00",
          "Tuesday": true,
          "Wednesday": true
        },
        "LocationRestrictions": {
          "CountryRestrictions": {
            "Countries": [
              "203"
            ],
            "Exclusive": true
          },
          "NetworkRestrictions": [
            {
              "Country": "826",
              "Exclusive": false,
              "Networks": [
                "0002003826"
              ]
            }
          ],
          "PartnerSiteRestrictions": [
            {
              "Exclusive": false,
              "NetworkCode": "0452301643",
              "SiteGroups": [
                "P1"
              ],
              "Sites": []
            }
          ],
          "ShellSiteRestrictions": [
            {
              "Country": "276",
              "Exclusive": true,
              "SiteGroups": [
                "P2"
              ],
              "Sites": []
            }
          ]
        },
        "ProductRestrictions": {
          "FuelSetId": 0,
          "FuelSetName": null,
          "NonFuelSets": null,
          "ProductGroups": [
            {
              "IsDefault": true,
              "IsFuelType": true,
              "Name": "Premium Diesel",
              "ProductGroupId": "P103",
              "Products": [
                {
                  "Description": "High Performance Diesel",
                  "GlobalProductCode": "033"
                }
              ],
              "ReferenceId": 100
            }
          ],
          "Products": [],
          "PurchaseCategoryCode": "",
          "PurchaseCategoryId": 0
        },
        "UsageRestrictions": {
          "AnnualSpend": 9999999999.99,
          "AnnualSpendAccumulated": 0,
          "AnnualSpendBalance": 9999999999.99,
          "AnnualTransactionAccumulated": 0,
          "AnnualTransactionBalance": 999999999999,
          "AnnualTransactionCount": 999999999999,
          "AnnualVolume": 9999999999.99,
          "AnnualVolumeAccumulated": 0,
          "AnnualVolumeBalance": 9999999999.99,
          "DailySpend": 1010,
          "DailySpendAccumulated": 0,
          "DailySpendBalance": 1010,
          "DailyTransactionAccumulated": 0,
          "DailyTransactionBalance": 6,
          "DailyTransactionCount": 6,
          "DailyVolume": 10,
          "DailyVolumeAccumulated": 0,
          "DailyVolumeBalance": 10,
          "Level": "Card",
          "LifeTimeSpend": null,
          "LifeTimeSpendAccumulated": null,
          "LifeTimeSpendBalance": null,
          "LifeTimeTransactionAccumulated": null,
          "LifeTimeTransactionBalance": null,
          "LifeTimeTransactionCount": null,
          "LifeTimeVolume": null,
          "LifeTimeVolumeAccumulated": null,
          "LifeTimeVolumeBalance": null,
          "MonthlySpend": 15020,
          "MonthlySpendAccumulated": 0,
          "MonthlySpendBalance": 15020,
          "MonthlyTransactionAccumulated": 0,
          "MonthlyTransactionBalance": 32,
          "MonthlyTransactionCount": 32,
          "MonthlyVolume": 1000,
          "MonthlyVolumeAccumulated": 0,
          "MonthlyVolumeBalance": 1000,
          "PerTransactionSpend": 920,
          "PerTransactionVolume": 10,
          "WeeklySpend": 1620,
          "WeeklySpendAccumulated": 0,
          "WeeklySpendBalance": 1620,
          "WeeklyTransactionAccumulated": 0,
          "WeeklyTransactionBalance": 18,
          "WeeklyTransactionCount": 18,
          "WeeklyVolume": 100,
          "WeeklyVolumeAccumulated": 0,
          "WeeklyVolumeBalance": 100,
          "AnnualSpendOverride": false,
          "DailySpendOverride": true,
          "LifeTimeSpendOverride": false,
          "MonthlySpendOverride": true,
          "PerTransactionSpendOverride": true,
          "WeeklySpendOverride": true,
          "DailyVolumeOverride": true,
          "WeeklyVolumeOverride": true,
          "MonthlyVolumeOverride": true,
          "PerTransactionVolumeOverride": true,
          "AnnualVolumeOverride": false,
          "LifeTimeVolumeOverride": false,
          "DailyTransactionOverride": true,
          "WeeklyTransactionOverride": true,
          "MonthlyTransactionOverride": true,
          "AnnualTransactionOverride": false,
          "LifeTimeTransactionOverride": false
        }
      },
      "RestrictionCurrencyCode": "CZK",
      "RestrictionCurrencySymbol": "Kč",
      "AccountId": 1223,
      "AccountName": "NewtestPandB",
      "AccountNumber": "CZ00000923",
      "AccountShortName": "NewtestPandB",
      "CardId": 459629,
      "CardTypeCode": "7077327",
      "CardTypeId": 105,
      "CardTypeName": "CZ CRT INT MUL R7",
      "ColCoCurrencyCode": "CZK",
      "ColCoCurrencySymbol": "Kč",
      "CurrencyCode": "EUR",
      "CurrencySymbol": "€",
      "DriverName": "XYZ 1504",
      "ExpiryDate": "20240731",
      "IsCRT": true,
      "IsFleet": false,
      "IsInternational": true,
      "IsNational": false,
      "IsPartnerSitesIncluded": true,
      "IsShellSitesOnly": false,
      "IssueDate": "20200722",
      "IssueNumber": 1,
      "IsSuperseded": false,
      "IsVirtualCard": false,
      "PAN": "7077327290223419353",
      "PurchaseCategoryCode": "0",
      "PurchaseCategoryId": 100,
      "PurchaseCategoryName": "0 - Diesel Products and TMF",
      "StatusDescription": "Active",
      "StatusId": 1,
      "VRN": "ABC 1504",
      "MediumTypeID": 5,
      "MediumType": "Key fob"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


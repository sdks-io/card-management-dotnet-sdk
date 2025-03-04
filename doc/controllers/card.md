# Card

APIs for Retrieve and update shell card details

```csharp
CardController cardController = client.CardController;
```

## Class Name

`CardController`

## Methods

* [Search Card](../../doc/controllers/card.md#search-card)
* [Card Summary](../../doc/controllers/card.md#card-summary)
* [Order Card](../../doc/controllers/card.md#order-card)
* [Order Card Enquiry](../../doc/controllers/card.md#order-card-enquiry)
* [Card Cancel](../../doc/controllers/card.md#card-cancel)
* [Card Update Status](../../doc/controllers/card.md#card-update-status)
* [Purchase Category](../../doc/controllers/card.md#purchase-category)
* [Card Details](../../doc/controllers/card.md#card-details)
* [Card Move](../../doc/controllers/card.md#card-move)
* [Card Pin Reminder](../../doc/controllers/card.md#card-pin-reminder)
* [Schedule Card Block](../../doc/controllers/card.md#schedule-card-block)
* [Auto Renew](../../doc/controllers/card.md#auto-renew)
* [Update Mobile Payment Registration Status](../../doc/controllers/card.md#update-mobile-payment-registration-status)
* [Get Key](../../doc/controllers/card.md#get-key)
* [Delivery Address Update](../../doc/controllers/card.md#delivery-address-update)


# Search Card

This API allows to search for Shell Cards in the Shell Card Platform. It provides flexible search criteria and supports paging.

#### New version updates

* Oauth authentication to access the API

* New parameters have been added in the response. Below are the list of parameters added
  
  * IsEMVContact
  
  * IsEMVContactless
  
  * IsRFID
  
  * RFIDUID
  
  * EMAID
  
  * EVPrintedNumber
  
  * CardMediaCode

#### Supported operations

* Search cards by card id or PAN

* Search cards by card status

* Search cards by excluding card status

* Search cards by date fields

* Search cards by embossed fields

* Search cards by card configuration fields

* Search cards by included/excluded list of cards

* Search cards by excluding card bundle Id

```csharp
SearchCardAsync(
    string requestId,
    Models.SearchCardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`SearchCardRequest`](../../doc/models/search-card-request.md) | Body, Optional | requestbody |

## Response Type

[`Task<Models.CardSearchResponse>`](../../doc/models/card-search-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
SearchCardRequest body = new SearchCardRequest
{
    Filters = new Filters
    {
        CardStatus = new List<string>
        {
            "ACTIVE",
            "BLOCKED",
        },
        AccountId = 1223,
        AccountNumber = "CZ00000923",
        CardGroupId = 424,
        CardGroupName = "CARDGRP1",
        CardSegment = "Fleet",
        CardTypeCode = "7077327",
        ColCoCode = 32,
        ColCoId = 32,
        Coverage = "National",
        CreationDate = "20211222",
        DriverName = new List<string>
        {
            "JAN KOLLER",
            "DRIVER23",
            "DRIVER25",
        },
        EffectiveDate = "20211222",
        ExcludeCancelledCards = true,
        ExcludeCardGroupId = 425,
        ExcludeCardGroupName = "CARDGRP2",
        ExcludeCards = new List<SearchCard>
        {
            new SearchCard
            {
                CardId = 466907,
                PAN = "7077327290224795811",
                PANID = 17350065,
            },
        },
        ExcludeFraudCards = false,
        ExcludePendingRenewalCards = true,
        ExcludeReplacedCards = false,
        ExpiryMonth = "052022",
        IncludeCards = new List<SearchCard>
        {
            new SearchCard
            {
                CardId = 466906,
                PAN = "7077327290224795801",
                PANID = 17350065,
            },
        },
        IncludeIntermediateStatus = false,
        IssuedAfter = "20211123",
        Network = "ShellSitesOnly",
        PANEndsWith = "1284",
        PayerId = 1223,
        PayerNumber = "CZ00000923",
        PurchaseCategoryCode = "3",
        SortOrder = "1,3,7",
        IncludeScheduledCardBlocks = false,
        TokenTypeID = 107,
        TokenTypeName = "CZ CRT Int MultiNetwork - CHIP",
        VehicleRegistrationNumber = new List<string>
        {
            "5A2 7512",
            "5A2 7514",
        },
        ExcludeOldCards = false,
        ExcludeExpiringCards = false,
        ReissueSetting = "true",
        RequestId = "233e4567-e89b-12d3-a456-426614174000",
    },
    PageSize = "50",
    Page = "1",
};

try
{
    CardSearchResponse result = await cardController.SearchCardAsync(
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
  "Page": 1,
  "TotalRecords": 3420,
  "TotalPages": 3420,
  "PageSize": 50,
  "Data": [
    {
      "AccountId": 1223,
      "AccountName": "NewtestPandB",
      "AccountNumber": "CZ00000923",
      "AccountShortName": "NewtestPandB",
      "BundleId": "null",
      "CardBlockSchedules": [
        {
          "null": null
        }
      ],
      "CardGroupId": 5,
      "CardGroupName": "null",
      "CardId": 385316,
      "CardTypeCode": "7077327",
      "CardTypeId": 105,
      "CardTypeName": "CZ CRT INT MUL R7",
      "ColCoCountryCode": "CZ",
      "CreationDate": "20190911 13:58:30",
      "DriverName": "Jhon",
      "EffectiveDate": "20190911",
      "ExpiryDate": "20230930",
      "FleetIdInput": true,
      "IsCRT": true,
      "IsFleet": false,
      "IsInternational": true,
      "IsNational": false,
      "IsPartnerSitesIncluded": true,
      "IsShellSitesOnly": false,
      "IssueDate": "20190911",
      "IsSuperseded": true,
      "IsVirtualCard": false,
      "LastModifiedDate": "20230720 09:33:28",
      "LastUsedDate": "20230720 09:33:28",
      "LocalCurrencyCode": "CZK",
      "LocalCurrencySymbol": "Kč",
      "OdometerInput": true,
      "PAN": "7077327290223410782",
      "MaskedPAN": "7077327******410782",
      "PANID": 17350064,
      "PurchaseCategoryCode": "3",
      "PurchaseCategoryId": 103,
      "PurchaseCategoryName": "3 - No Restriction",
      "Reason": "Lost",
      "ReissueSetting": "False",
      "StatusDescription": "Active",
      "StatusId": 1,
      "TokenTypeID": 107,
      "TokenTypeName": "CZ CRT Int MultiNetwork - CHIP",
      "VRN": "GHJHJDKSDS",
      "ClientReferenceId": "233e4567-e89b-12d3-a456-426614174000",
      "IsEMVContact": false,
      "IsEMVContactless": false,
      "IsRFID": false,
      "RFIDUID": "AFR56T",
      "EMAID": "JUYHF767",
      "EVPrintedNumber": "87394FDE",
      "CardMediaCode": "100999",
      "MediumTypeID": 0,
      "MediumType": null
    }
  ],
  "RequestId": "4cb1d11e-c387-48a5-b667-a1d862be4343",
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


# Card Summary

This API allows to search for fuel cards in the Shell Card Platform and returns a high-level summary count. It provides flexible search criteria.

#### New version updates

* Oauth authentication to access the API
* Minor change in response structure with addition of Status parameter

#### Supported operations

* Search cards by card id or PAN
* Search cards by card status
* Search cards by excluding card status
* Search cards by date fields
* Search cards by embossed fields
* Search cards by card configuration fields
* Search cards by included/excluded list of cards

```csharp
CardSummaryAsync(
    string requestId,
    Models.CardSummaryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardSummaryRequest`](../../doc/models/card-summary-request.md) | Body, Optional | summary request body |

## Response Type

[`Task<Models.CardSummaryResponse>`](../../doc/models/card-summary-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CardSummaryRequest body = new CardSummaryRequest
{
    Filters = new Filters1
    {
        CardStatus = new List<string>
        {
            "ACTIVE",
            "BLOCKED",
        },
        RequestId = "233e4567-e89b-12d3-a456-426614174000",
        AccountId = 1223,
        AccountNumber = "CZ00000923",
        ColCoCode = 32,
        ColCoId = 32,
        PayerId = 1223,
        PayerNumber = "CZ00000923",
        CardGroupId = 424,
        CardGroupName = "CARDGRP1",
        IssuedAfter = "20211123",
        PANEndsWith = "1284",
        DriverName = new List<string>
        {
            "JAN KOLLER",
            "DRIVER23",
            "DRIVER25",
        },
        VehicleRegistrationNumber = new List<string>
        {
            "5A2 7512",
            "5A2 7514",
        },
        IncludeCards = new List<SearchCard>
        {
            new SearchCard
            {
                CardId = 466906,
                PAN = "7077327290224795801",
            },
        },
        ExcludeCards = new List<SearchCard>
        {
            new SearchCard
            {
                CardId = 466907,
                PAN = "7077327290224795811",
            },
        },
        CardSegment = "Fleet",
        PurchaseCategoryCode = "3",
        CardTypeCode = "7077327",
        ExcludePendingRenewalCards = true,
        ExcludeCancelledCards = true,
        ExcludeReplacedCards = false,
        ExcludeFraudCards = false,
        ExcludeCardGroupId = 425,
        ExcludeCardGroupName = "CARDGRP2",
        CreationDate = "20211222",
        EffectiveDate = "20211222",
        Network = "ShellSitesOnly",
        Coverage = "National",
        ExpiryMonth = "052022",
        ExcludeOldCards = false,
        ReissueSetting = "true",
    },
};

try
{
    CardSummaryResponse result = await cardController.CardSummaryAsync(
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
  "RequestId": "233e4567-e89b-12d3-a456-426614174000",
  "Status": "SUCCESS",
  "Data": [
    {
      "ActiveCards": 10,
      "BlockedCards": 5,
      "CancelledCards": 2,
      "ExpiredCards": 5,
      "ExpiringCards": 2,
      "FraudCards": 0,
      "NewCards": 0,
      "RenewalPendingCards": 0,
      "ReplacedCards": 0,
      "TemporaryBlockByCustomer": 0,
      "TemporaryBlockByShell": 0,
      "TotalCards": 24
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Order Card

This API allows ordering one or more fuel cards (up to 50). If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.

#### New version updates

* Oauth authentication to access the API
* New parameters have been added in the response for the new PIN management changes. Below parameters needs to be derived from the new PIN encryption method explained in our Mobility Card PIN Management product.
  * SelfSelectedEncryptedPIN
  * SelfSelectedPINKeyID
  * SelfSelectedPINSessionKey
* New parameters have been added in the response for card and pin delivery mechanism which gives the opportunity to deliver card & pin by email, SMS or post.
  Also the possibility to deliver card and pin to different address if the use case demands.
  * CardDeliveryType
  * PINDeliveryAddressType
  * PINAdviceType
  * PINContact
  * CardContact

#### Supported operations

* Order one or more cards (up to 50)
* Order card with self selected PIN
* Order card with vehicle registration number
* Order card and add to new or exisitng card group
* Order card and enable fleetId or odemeter input
* Order card and specify product groups

#### Validation rules

* Number of cards per request does not exceed 50

#### API response

* A main reference number for the API request (**OrderReference**)
* Individual reference numbers (**OrderCardReference**) for each new card

```csharp
OrderCardAsync(
    string requestId,
    Models.CardManagementV1OrdercardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardManagementV1OrdercardRequest`](../../doc/models/card-management-v1-ordercard-request.md) | Body, Optional | Order card request body |

## Response Type

[`Task<Models.OrderCardResponse>`](../../doc/models/order-card-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CardManagementV1OrdercardRequest body = new CardManagementV1OrdercardRequest
{
    CardDetails = new List<CardDetail>
    {
        new CardDetail
        {
            CardDeliveryType = 1,
            PINAdviceType = 1,
            PayerId = 853,
            PayerNumber = "PH50000843",
            AccountId = 854,
            AccountNumber = "PH50000844",
            ColCoCode = 86,
            ColCoId = 1,
            CardTypeId = 1,
            TokenTypeId = 107,
            EmbossText = "PARKLEY",
            VRN = "MV65YLH",
            DriverName = "Robert",
            OdometerInputRequired = false,
            FleetIdInputRequired = false,
            PurchaseCategoryId = 54,
            SelfSelectedEncryptedPIN = "0hCx7wfFp3z8QkW8dElhHiMwCwC1",
            SelfSelectedPINKeyID = "123aaa33198dc8f3s4k77dsc78",
            SelfSelectedPINSessionKey = "WoWB+8UEd71+8QXwuE75flkAQ /4Q6gDFSn027oJ/0ne6LmzVIxJ87yoeqKS /C+OIBJ7bTvasLH+xvDSZtzoOZHr 7wfFmpfSyet8KnKjnagSicrUgpGk 7qFyOw3iA9/Qd6Oy9djYR3C3cDWEpj /YREZ1lBGReb9fqdSpoKx8mnGuPAw7",
            CardGroupId = 5,
            CardGroupName = "Group1",
            IsNewCardGroup = false,
            EmbossCardGroup = false,
            CardContact = new CardContact
            {
                DeliveryContactName = "Robert",
                DeliveryCompanyName = "WILTON AUFDERHAR",
                DeliveryAddressLine1 = "Herrn Dieter Whausen Lansstrab",
                DeliveryZipCode = "12130",
                DeliveryCity = "manila",
                DeliveryCountry = "WILTON AUFDERHAR",
                DeliveryContactTitle = "Mr.",
                DeliveryAddressLine2 = "10th avenue",
                DeliveryAddressLine3 = "makati city",
                DeliveryRegionId = 43,
                DeliveryRegion = "Philippines",
                PhoneNumber = "99999999999",
                EmailAddress = "xxxxx@example.com",
                SaveForCardReissue = false,
            },
            PINDeliveryAddressType = 1,
            PINContact = new PINContact
            {
                DeliveryContactTitle = "Mr.",
                DeliveryContactName = "Robert",
                DeliveryCompanyName = "WILTON AUFDERHAR",
                DeliveryAddressLine1 = "Herrn Dieter Whausen Lansstrab",
                DeliveryAddressLine2 = "10th avenue",
                DeliveryAddressLine3 = "makati city",
                DeliveryZipCode = "12130",
                DeliveryCity = "manila",
                DeliveryRegionId = 43,
                DeliveryRegion = "Philippines",
                DeliveryCountry = "WILTON AUFDERHAR",
                PhoneNumber = "99999999999",
                EmailAddress = "xxxxx@example.com",
                SaveForPINReminder = false,
            },
            NotifyCaller = false,
            Caller = "NextGenUI",
            NotifyCallerOnSync = false,
            ValidateFleetId = false,
            FleetOption = "ALERT",
            BundleId = "1046",
            UsageRestrictionAction = "None",
            ProductRestrictionAction = "None",
            Products = new List<string>
            {
                "011",
                "033",
            },
            ProductGroups = new List<string>
            {
                "670246404",
                "40557126",
            },
            ExpiryDate = "1221",
            ClientReferenceId = "cli123",
        },
    },
};

try
{
    OrderCardResponse result = await cardController.OrderCardAsync(
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
  "RequestId": "b88525fd-6340-404e-9313-12e702c33cb7",
  "Status": "SUCCESS",
  "Data": [
    {
      "DriverAndVRN": "ROBERT:MV65YLH",
      "OrderCardReference": 488351
    }
  ],
  "MainReference": 488453
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Order Card Enquiry

This API retrieves the card order status from the Shell Card Platform based on the given reference numbers.

#### New version updates

    * Oauth authentication to access the API
    
    * Minor change in response structure with addition of Status parameter

#### Supported operations

    * Get order status by Bulk Card Order Reference
    
    * Get order status by Order Reference (main reference for the order)
    
    * Get order status by Card Reference (individual card reference belonging to an order reference)

```csharp
OrderCardEnquiryAsync(
    string requestId,
    Models.OrderCardEnquiryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`OrderCardEnquiryRequest`](../../doc/models/order-card-enquiry-request.md) | Body, Optional | Order Card Enquiry request body |

## Response Type

[`Task<Models.OrderCardEnquiryResponse>`](../../doc/models/order-card-enquiry-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
OrderCardEnquiryRequest body = new OrderCardEnquiryRequest
{
    Filters = new Filters2
    {
        AccountId = 70,
        AccountNumber = "NL00000063",
        ColCoCode = 18,
        ColCoId = 18,
        ColCoCountryCode = "NL",
        PayerId = 70,
        PayerNumber = "NL00000063",
        ReferenceNumber = 25,
        ReferenceType = OrderCardEnquiryReqReferenceTypeEnum.Enum1,
        FromDate = "20210502",
        ToDate = "20210505",
        OrderRequestId = "34edbfbf-f05e-4d8d-bcd4-9eb7aea5ea41",
    },
};

try
{
    OrderCardEnquiryResponse result = await cardController.OrderCardEnquiryAsync(
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
  "RequestId": "6fb81ffe-bf1b-44b0-94f8-d6711afde392",
  "Status": "SUCCESS",
  "Data": [
    {
      "AccountId": 70,
      "AccountNumber": "NL00000063",
      "BCOReference": 0,
      "BCORowNumber": 0,
      "CardGroupId": 0,
      "CardGroupName": "null",
      "CardId": 41008,
      "CardPAN": "7077187910757000712",
      "MaskedPAN": "707718******000712",
      "PANID": 17285721,
      "CardTypeCode": "7077187",
      "CardTypeId": 704,
      "CardTypeName": "NL CRT Nat. Shell + partnernetwerk",
      "DriverName": "DAVE ROUSE TEST",
      "ErrorCode": "0000",
      "ErrorDescription": "null",
      "GatewaySyncErrorCode": "0000",
      "GatewaySyncErrorDescription": "Success",
      "GatewaySyncStatus": "S",
      "MainReference": 512164,
      "OrderCardReference": 714069,
      "OrderStatus": "S",
      "PayerId": 70,
      "PayerNumber": "NL00000063",
      "ProcessedDate": "20231219 10:12:21",
      "PurchaseCategoryCode": "3",
      "PurchaseCategoryId": 139,
      "PurchaseCategoryName": "3 - No Restriction",
      "SubmittedDate": "20231219 10:11:16",
      "SyncProcessedDate": "20231219 10:15:44",
      "SyncRequestedDate": "null",
      "VRN": "null",
      "OrderRequestId": "ee625150-8d84-496c-b824-a4c47b482ae3",
      "ExpiryDate": "20271231 00:00:00",
      "ClientReferenceId": "9073ab4e-c1f5-4f2d-947f-753ead176c3d",
      "StatusDescription": "Success"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Card Cancel

This API allows cancelling one or multiple cards (up to 500) within a single API call. This API allows updating of
the card to the following status-

* Block (Cancelled)

#### New version updates

* Oauth authentication to access the API
* Change in the request body
  * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery.

Requests that passed the below validations are queued-

* All Mandatory fields are passed.
* Card is present in the Shell Card Platform.
* Only one matching card is available in the cards platform for the given PAN and expiry date for Block requests.
* Card is allowed to be moved to proposed state as per the card status transition configuration in cards platform.
* A valid Reason Id or Reason Text is provided. The reason for card cancellation can be “Damaged” or “NoLongerRequired”.
* For the given card, there is no Cancel request already submitted via this API and is being processed.
* ‘IsReplacementChargeable’ is set to ‘False’ only to the configured customer, other customers need to set it as ‘True’ only. If other customers pass this value as ‘False’.

Note- Shell Card Platform will maintain the list of   customers, to whom ‘IsReplacementChargeable’ can be set as ‘False’.

If all validations are passed, the request will be accepted and the API will return reference numbers for tracking purpose. If any of the validations fail, the API will return the appropriate error details on response.  The API response will include-

* A main reference number for the API request.
* A list of successfully validated and accepted cards along with the individual reference numbers for each of the successful requests.
* A list of cards for which at least validation has failed along with the appropriate error code and details.

A permanent block (cancelled) request for the card will be queued in Shell Card Platform after the configured damaged card active period (configured as number of days).

When a card is requested to be Blocked permanently (cancelled) for which a request has already been submitted to report as Damaged and the damaged card active period is not yet completed, the damaged card request will be marked as superseded and the new Block (cancelled) request will be processed.

```csharp
CardCancelAsync(
    string requestId,
    Models.CardManagementV1CancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardManagementV1CancelRequest`](../../doc/models/card-management-v1-cancel-request.md) | Body, Optional | Update status request body |

## Response Type

[`Task<Models.CancelCardResponse>`](../../doc/models/cancel-card-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CardManagementV1CancelRequest body = new CardManagementV1CancelRequest
{
    Cards = new List<UpdateCard>
    {
        new UpdateCard
        {
            Caller = "NextGenUI",
            IsReplacementChargeable = true,
            NotifyCaller = false,
            NotifyCallerOnSync = false,
            OrderCardReplacement = true,
            CardSettings = new CardSettings
            {
                CardDeliveryType = 1,
                SelfSelectedEncryptedPIN = "0hCx7wfFp3z8QkW8dElhHiMwCwC1",
                SelfSelectedPINKeyID = "123aaa33198dc8f3s4k77dsc78",
                SelfSelectedPINSessionKey = "WoWB+8UEd71+8QXwuE75flkAQ /4Q6gDFSn027oJ/0ne6LmzVIxJ87yoeqKS /C+OIBJ7bTvasLH+xvDSZtzoOZHr 7wfFmpfSyet8KnKjnagSicrUgpGk 7qFyOw3iA9/Qd6Oy9djYR3C3cDWEpj /YREZ1lBGReb9fqdSpoKx8mnGuPAw7",
                ValidateFleetId = false,
                CardGroupId = 156,
                DeliveryContactTitle = "Mr",
                DeliveryContactName = "SAPE",
                DeliveryCompanyName = "welcome",
                DeliveryAddressLine1 = "123/89",
                DeliveryAddressLine2 = "Mac Street",
                DeliveryAddressLine3 = "NLStrret",
                DeliveryZipCode = "1213242",
                DeliveryCity = "Chennai",
                DeliveryRegionId = 54,
                DeliveryRegion = "Mountain Province",
                DeliveryCountry = "CZ",
                PhoneNumber = "99999999999",
                EmailAddress = "xxxxx@examp\"le.com",
                PINDeliveryAddressType = 1,
                PINAdviceType = 1,
                PINDeliveryContactTitle = "5058F1AF",
                PINDeliveryContactName = "WILTON",
                PINDeliveryCompanyName = "WILTON AUFDERHAR",
                PINDeliveryAddressLine1 = "Herrn Dieter Whausen Lansstrab",
                PINDeliveryAddressLine2 = "Wall street",
                PINDeliveryAddressLine3 = "Wall Street",
                PINDeliveryZipCode = "12103",
                PINDeliveryCity = "Berlin",
                PINDeliveryRegionId = 1,
                PINDeliveryRegion = "Berlin-Brandenburg",
                PINDeliveryCountry = "DEU",
                PINPhoneNumber = "99999999999",
                PINEmailAddress = "xxxxx@example.com",
                SaveForPINReminder = false,
                SaveForCardReissue = false,
                ExpiryDate = "1221",
            },
            AccountId = 854,
            AccountNumber = "PH50000844",
            CardExpiryDate = "20181031",
            CardId = 125,
            ColCoCode = 86,
            ColCoId = 1,
            PAN = "7002861007636000020",
            PayerId = 853,
            PayerNumber = "PH50000843",
        },
    },
    ReasonText = "Lost",
};

try
{
    CancelCardResponse result = await cardController.CardCancelAsync(
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
  "RequestId": "ba093ec6-a738-47d3-d25d-2f15a6d04fc6",
  "MainReference": 466536,
  "OrderReplacementReference": 466537,
  "Status": "SUCCESS",
  "Data": [
    {
      "ReplacementCardReference": 599643,
      "UpdateCardReference": 39269,
      "AccountId": 1227,
      "AccountNumber": "CZ00000927",
      "CardExpiryDate": "20240930",
      "CardId": 462079,
      "ColCoCode": 32,
      "ColCoId": 32,
      "PAN": "7002329040232130111",
      "PayerId": 1227,
      "PayerNumber": "CZ00000927"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Card Update Status

This API allows updating of the card status for one or more cards (up to 500) within a single API call.  If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.

#### New version updates

* Oauth authentication to access the API
* Change in the request body
  * Pin change related parameters - SelfSelectedEncryptedPIN, SelfSelectedPINKeyID, SelfSelectedPINSessionKey
  * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery.
  * SaveForPINReminder - The given address will be used for sending PIN reminders in future when requested.
  * SaveForCardReissue - If this is specified, the contact address will be saved in cards platform for card reissue processing.

#### Supported operations

* Updating a card status to Temporary block, Unblock, Block (Cancelled)
  or Damaged
* Requesting a replacement card when status is set to Block or Damaged

#### Validation rules

* Number of cards per request does not exceed 500
* A card can be changed to proposed status as per the card status transition configuration in the Shell Card Platform
* Locating a card -
  * If target status set to **TemporaryBlock**, then only one matching active card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**
  * If target status set to **Unblock** or **Block**, then only one matching card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**
* A valid Reason Id or Reason Text is provided
  * If target status set to **Block** or **Damaged** and a **ReasonText** is provided, the value must be from the fixed list - *'Lost'*, *'Stolen'* or *'Card no longer required'*
* For the given card, there is no Status Update request already submitted via this API and is being processed
* The **OrderReplacementCard** field is set to True only for cards with a target status set to Block or Damaged

#### API response

* A main reference number for the API request (**OrderReplacementReference**)
* A list of successfully validated and accepted cards along with the individual reference numbers (**UpdateCardReference**) for each of the successful  request
* A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message

#### Asynchronous processing of valid API request

* Replacement cards
  * Request for a replacement card will be placed only when the Block card or Block damaged card request is successfully placed.
  * The Replacement card request will be processed only when the permanent Block card request is successfully processed. In case of damaged card request, the replacement card request will be processed immediately.
* Damaged cards
  * Setting a card to Damaged will automatically trigger a request to permanently block the card. This will only take effect once the ‘Damaged Active’ period has passed.
  * The Damaged card active period is the number of days after which a "Damaged" card request will be processed. This value is configured at ColCo level.
  * If a card is reported as damaged at 10pm local time on 1st Nov and the damaged card period is set to 10 days, then the block request will be submitted to the Shell Card Platform on 11th Nov 00-01 local time.
  * If during the damage card active period another request is made to set the card to Temporarily Blocked or Blocked permanently (cancelled), then the damaged card request will be marked as superseded and the new Temporary Block or Block (cancelled) will be processed.

```csharp
CardUpdateStatusAsync(
    string requestId,
    Models.CardManagementV1UpdatestatusRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardManagementV1UpdatestatusRequest`](../../doc/models/card-management-v1-updatestatus-request.md) | Body, Optional | Update status request body |

## Response Type

[`Task<Models.UpdateCardStatusResponse>`](../../doc/models/update-card-status-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CardManagementV1UpdatestatusRequest body = new CardManagementV1UpdatestatusRequest
{
    Cards = new List<UpdateCard>
    {
        new UpdateCard
        {
            Caller = "Motix",
            IsReplacementChargeable = true,
            NotifyCaller = true,
            NotifyCallerOnSync = false,
            OrderCardReplacement = true,
            CardSettings = new CardSettings
            {
                CardDeliveryType = 1,
                SelfSelectedEncryptedPIN = "0hCx7wfFp3z8QkW8dElhHiMwCwC1",
                SelfSelectedPINKeyID = "123aaa33198dc8f3s4k77dsc78",
                SelfSelectedPINSessionKey = "WoWB+8UEd71+8QXwuE75flkAQ /4Q6gDFSn027oJ/0ne6LmzVIxJ87yoeqKS /C+OIBJ7bTvasLH+xvDSZtzoOZHr 7wfFmpfSyet8KnKjnagSicrUgpGk 7qFyOw3iA9/Qd6Oy9djYR3C3cDWEpj /YREZ1lBGReb9fqdSpoKx8mnGuPAw7",
                ValidateFleetId = false,
                CardGroupId = 156,
                DeliveryContactTitle = "Mr",
                DeliveryContactName = "SAPE",
                DeliveryCompanyName = "welcome",
                DeliveryAddressLine1 = "123/89",
                DeliveryAddressLine2 = "Mac Street",
                DeliveryAddressLine3 = "NLStrret",
                DeliveryZipCode = "1213242",
                DeliveryCity = "Chennai",
                DeliveryRegionId = 54,
                DeliveryRegion = "Mountain Province",
                DeliveryCountry = "CZ",
                PhoneNumber = "99999999999",
                EmailAddress = "xxxxx@example.com",
                PINDeliveryAddressType = 1,
                PINAdviceType = 1,
                PINDeliveryContactTitle = "50388633F",
                PINDeliveryContactName = "WILTON",
                PINDeliveryCompanyName = "WILTON AUFDERHAR",
                PINDeliveryAddressLine1 = "Herrn Dieter Whausen Lansstrab",
                PINDeliveryAddressLine2 = "Wall street",
                PINDeliveryAddressLine3 = "Wall Street",
                PINDeliveryZipCode = "12103",
                PINDeliveryCity = "Berlin",
                PINDeliveryRegionId = 1,
                PINDeliveryRegion = "Berlin-Brandenburg",
                PINDeliveryCountry = "DEU",
                PINPhoneNumber = "99999999999",
                PINEmailAddress = "xxxxx@example.com",
                SaveForPINReminder = false,
                SaveForCardReissue = false,
                ExpiryDate = "1221",
            },
            AccountId = 1223,
            AccountNumber = "CZ00000928",
            CardExpiryDate = "20221215",
            CardId = 385360,
            ColCoCode = 32,
            ColCoId = 32,
            PAN = "7077327290223410816",
            PANID = 17350064,
            PayerId = 1223,
            PayerNumber = "CZ00000928",
        },
    },
    TargetStatus = "Unblock",
    ReasonId = 1236,
    ReasonText = "Unblock",
};

try
{
    UpdateCardStatusResponse result = await cardController.CardUpdateStatusAsync(
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
  "RequestId": "233e4567-e89b-12d3-a456-426614174000",
  "MainReference": 466543,
  "OrderReplacementReference": 466544,
  "Status": "SUCCESS",
  "Data": [
    {
      "ReplacementCardReference": 599649,
      "UpdateCardReference": 39270,
      "AccountId": 1227,
      "AccountNumber": "CZ00000927",
      "CardExpiryDate": "20240930",
      "CardId": 462083,
      "ColCoCode": 32,
      "ColCoId": 32,
      "PAN": "7077327290223421201",
      "PANID": 17352931,
      "MaskedPAN": "7077327******421201",
      "PayerId": 1227,
      "PayerNumber": "CZ00000927"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Purchase Category

This API will allow querying the purchase categories of Card
for the given country and/or card type.
It will also include the below data associated with each of the purchase categories on it’s response.

* List of fuel and non-fuel product sets associated.
* List of products configured in each product set

```csharp
PurchaseCategoryAsync(
    string apikey,
    string requestId,
    Models.PurchaseCategoryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`PurchaseCategoryRequest`](../../doc/models/purchase-category-request.md) | Body, Optional | PurchaseCategory request body |

## Response Type

[`Task<Models.PurchaseCategoryResponse>`](../../doc/models/purchase-category-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "RequestId8";
PurchaseCategoryRequest body = new PurchaseCategoryRequest
{
    ColCoId = 32,
    LanguageCode = "EN-GB",
};

try
{
    PurchaseCategoryResponse result = await cardController.PurchaseCategoryAsync(
        apikey,
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
  "PurchaseCategories": [
    {
      "Code": "0",
      "Id": 100,
      "IsVisible": false,
      "Name": "0 - Diesel Products and TMF",
      "Title": "0 - Diesel Products and TMF",
      "Description": "0 - Diesel Products and TMF",
      "ProductGroups": [
        {
          "IsDefault": false,
          "IsFuelType": true,
          "Name": "Other Fuels",
          "ProductGroupId": "P102",
          "Products": [
            {
              "Description": "Hydrogen",
              "GlobalProductCode": "019"
            },
            {
              "Description": "CNG",
              "GlobalProductCode": "029"
            },
            {
              "Description": "LPG",
              "GlobalProductCode": "034"
            }
          ],
          "ReferenceId": 100
        }
      ]
    }
  ],
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "47aca5b8-8186-49e5-b8d0-30f73fffd0f1"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | The server understood the request but refuses to authorize it. | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | `ApiException` |


# Card Details

This API allows to fetch details of a single fuel card from the Shell Card Platform. If a **CardId** request parameter is provided, this will return a single card.  If a **PAN** request parameter is provided, this may result in multiple fuel cards matching the search criteria. The card details of the most recently issued card will be returned.

#### Supported operations

* Get card by card id or PAN

```csharp
CardDetailsAsync(
    string apikey,
    string requestId,
    Models.CardDetailsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardDetailsRequest`](../../doc/models/card-details-request.md) | Body, Optional | Card details request body |

## Response Type

[`Task<Models.CardDetailsResponse>`](../../doc/models/card-details-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "RequestId8";
CardDetailsRequest body = new CardDetailsRequest
{
    ColCoCode = 86,
    ColCoId = 1,
    ColCoCountryCode = "PH",
    ClientReferenceId = "adc-1671-ftwiQweh-67UJs",
    PayerNumber = "PH50000843",
    PayerId = 853,
    AccountNumber = "PH50000844",
    AccountId = 854,
    PAN = "7002861007636000020",
    CardId = 125,
    TokenTypeID = 107,
    TokenTypeName = "PH FLE NAT SIN R1",
    CreationDate = "20181001",
    EffectiveDate = "20181001",
    IncludeBundleDetails = false,
    IncludeIntermediateStatus = false,
    IncludeScheduledCardBlocks = false,
};

try
{
    CardDetailsResponse result = await cardController.CardDetailsAsync(
        apikey,
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
  "PayerId": 853,
  "PayerNumber": "PH50000843",
  "AccountId": 854,
  "AccountNumber": "PH50000844",
  "AccountShortName": "PARKLEY",
  "ColCoCountryCode": "PH",
  "LocalCurrencyCode": "EUR",
  "LocalCurrencySymbol": "€",
  "CardId": 125,
  "PAN": "7002861007636000020",
  "StatusId": 1,
  "Status": "string",
  "OdometerPrompt": true,
  "FleetIdPrompt": true,
  "PINType": "Card",
  "HasPIN": true,
  "IsSelfSelectedPIN": true,
  "TemporaryBlockAllowed": true,
  "UnblockAllowed": true,
  "PermanentBlockAllowed": true,
  "IssueNumber": 1,
  "ReissueSetting": "True",
  "InternationalPOSLanguageID": 8,
  "InternationalPOSLanguageCode": "eng",
  "LocalPOSLanguageID": 8,
  "LocalPOSLanguageCode": "eng",
  "CardTypeCode": "7077861",
  "CardTypeId": 1,
  "CardTypeName": "Philippines CRT 7077861",
  "TokenTypeId": 107,
  "TokenTypeName": "PH FLE NAT SIN R1",
  "IsChipCard": false,
  "IsMagStripCard": true,
  "IsVirtualCard": true,
  "PurchaseCategoryCode": "6",
  "PurchaseCategoryId": 54,
  "PurchaseCategoryName": "2 - FuelSave and Lubricants",
  "IsCRT": true,
  "IsFleet": true,
  "IsInternational": true,
  "IsNational": true,
  "IsPartnerSitesIncluded": true,
  "IsShellSitesOnly": true,
  "FuelSets": [
    {
      "ProductRestrictionId": 120,
      "Description": "FS02: Diesel"
    }
  ],
  "NonFuelSets": [
    {
      "ProductRestrictionId": 120,
      "Description": "FS02: Diesel"
    }
  ],
  "IssuedDate": "20181001",
  "ExpiryDate": "20181031",
  "LastUsedDate": "20181001 13:23:55",
  "MisuseDate": "20181001 13:23:55",
  "Temperature": "10-Warm",
  "DriverName": "ROBERT",
  "VRN": "MV65YLH",
  "EmbossText": "PARKLEY",
  "CardGroupId": 5,
  "CardGroupName": "GROUP1",
  "RenewalDate": "20181001",
  "RenewedCardId": 1325,
  "RenewedCardStatusId": 10,
  "RenewedCardStatus": "New",
  "RenewedCardExpiryDate": "20181031",
  "RenewedCardIssueNumber": 2,
  "RenewedCardReissueSetting": "True",
  "CreationDate": "20181001",
  "EffectiveDate": "20181001",
  "LastModifiedDate": "20181001 13:23:55",
  "BundleId": null,
  "CardDeliveryAddress": {
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
    "RegionId": null,
    "Region": "EU",
    "CountryId": 1,
    "CountryISOCode": "PH",
    "Country": "Philippines"
  },
  "PINDeliveryAddress": {
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
    "RegionId": null,
    "Region": "EU",
    "CountryId": 1,
    "CountryISOCode": "PH",
    "Country": "Philippines"
  },
  "CardBlockSchedules": [
    {
      "FromDate": "20210212",
      "ToDate": "20210212"
    }
  ],
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | The server understood the request but refuses to authorize it. | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | `ApiException` |


# Card Move

This API allows to move one or more fuel cards (up to 500) across card groups within a single account or across accounts under the same payer. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.

#### Supported operations

* Moving card to exisitng card group
* Moving card to new card group
* Removing a card from a card group

#### Validation rules

* Number of cards per request does not exceed 500
* Given **PAN** for a card matches with only one card
* A card is allowed to be moved to the **TargetCardGroupId** or **TargetAccountNumber**
* A pending move request does not exist in the queue for a card submitted on the same date (customers local)
* A card has not been moved as part of a previous request on the same date (customers local)

#### API response

* A main reference number for the API request (**MoveCardRequestReference**)
* Individual reference numbers (**MoveCardReference**) for each card move request that passes validation
* A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message

#### Asynchronous processing of valid API request

* Move card requests that have been submitted and processed will be reflected after midnight according to the customers local date

```csharp
CardMoveAsync(
    string apikey,
    string requestId,
    Models.CardMoveRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardMoveRequest`](../../doc/models/card-move-request.md) | Body, Optional | Move cards request body. |

## Response Type

[`Task<Models.CardMoveResponse>`](../../doc/models/card-move-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "RequestId8";
CardMoveRequest body = new CardMoveRequest
{
    ColCoCode = 86,
    ColCoId = 1,
    ColCoCountryCode = "PH",
    PayerNumber = "PH50000843",
    PayerId = 853,
    Cards = new List<CardMoveRequestCardsItems>
    {
        new CardMoveRequestCardsItems
        {
            AccountNumber = "PH50000844",
            AccountId = 854,
            PAN = "7002861007636000020",
            CardId = 125,
        },
    },
    TargetAccountId = 855,
    TargetAccountNumber = "GB000000123",
    TargetCardGroupId = 93,
    TargetNewCardGroupName = "GROUP1",
};

try
{
    CardMoveResponse result = await cardController.CardMoveAsync(
        apikey,
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
  "MoveCardRequestReference": 0,
  "SuccessfulRequests": [
    {
      "AccountNumber": "PH50000844",
      "AccountId": 854,
      "PAN": "7002861007636000020",
      "CardId": 125,
      "MoveCardReference": 9074
    }
  ],
  "ErrorCards": [
    {
      "AccountNumber": "PH50000844",
      "AccountId": 854,
      "PAN": "7002861007636000020",
      "CardId": 125,
      "ValidationErrorCode": "0000",
      "ValidationErrorDescription": "Invalid parameter value – [ParameterName]"
    }
  ],
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed",
  "Error": {
    "Description": "Success",
    "Code": "0000"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | The server understood the request but refuses to authorize it. | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | `ApiException` |


# Card Pin Reminder

This API allows requesting a PIN reminder for a fuel card. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.

#### New version updates

* Oauth authentication to access the API
* Change in request body where PIN delivery type can be requested via Email, SMS or Post. PIN delivery contact can be set to different values based on previous contact details of card or pin delivery or can set specific contact details for this request.
  * PINAdviceType
  * PINContactType
  * PINDeliverTo
* Please note that we have a **savePINReminder** parameter in order to save the contact details for future such requests.
* Change in response body where Card details are also provided along with expiry date and PAN details.

#### Supported operations

* Request a pin reminder by card Id or PAN

#### Validation rules

* Given **PAN** or **CardId** is active
* Given **PAN** matches only one active card
* Requested card has PIN
* There is no pending PIN Reminder request in the queue awaiting to be processed for the card
* A PIN reminder request has not been successfully processed in the last 48 hours for the card

```csharp
CardPinReminderAsync(
    string requestId,
    Models.CardManagementV1PinreminderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`CardManagementV1PinreminderRequest`](../../doc/models/card-management-v1-pinreminder-request.md) | Body, Optional | PIN reminder request body |

## Response Type

[`Task<Models.PINReminderResponse>`](../../doc/models/pin-reminder-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
CardManagementV1PinreminderRequest body = new CardManagementV1PinreminderRequest
{
    AccountNumber = "CZ00000927",
    ColCoCode = 32,
    PayerNumber = "CZ00000927",
    PINReminderCardDetails = new List<PINReminderCardDetails>
    {
        new PINReminderCardDetails
        {
            PINAdviceType = 1,
            CardId = 463402,
            PAN = "7027329200000115820",
            CardExpiryDate = "20241031",
            PINContactType = 4,
            PINDeliverTo = new PINDeliverTo
            {
                CompanyName = "CGI",
                AddressLine = "Address1",
                ZipCode = "938373",
                City = "City1",
                ContactName = "Alex",
                ContactTitle = "Mr",
                RegionID = 0,
                CountryID = 0,
                PhoneNumber = "9998883332",
                EmailAddress = "abc.gmail.com",
                SavePINReminder = false,
            },
        },
    },
};

try
{
    PINReminderResponse result = await cardController.CardPinReminderAsync(
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
  "RequestId": "ba093ec6-a738-47d3-d25d-2f15a6d04fc6",
  "MainReference": 466588,
  "Status": "SUCCESS",
  "Data": [
    {
      "CardId": 463402,
      "PANID": null,
      "PAN": null,
      "CardExpiryDate": null,
      "ReferenceId": 2360
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


# Schedule Card Block

This API allows scheduling Card Block / Unblock requests for one or multiple cards (up to 500 (configurable)) within a single API call. This API is used to perform the following Actions:



* AddOrUpdate (Schedule a new request or update an existing     scheduled request for the overlapping period.
* AddAndOverwriteAll (all the existing requests of the given card will be removed and a new request with the specified FromDate and ToDate will be added.)
* Delete (Deletes the scheduled request for the same From and To date)
* DeleteAll (Deletes all the scheduled requests for the given card)

> Requests that passed the below validations are queue:

* All Mandatory fields are passed in the request.
* Card is present in the Shell Card Platform. Only one matching card is available in the cards platform for the given PAN and expiry date for the requests
* The scheduled period start date or end date should be later than or equal to the current date.

> If all validations are passed, the request will be accepted and saved in the intermediate queue  and the API will return reference numbers for tracking purpose.

> A background service will execute the block/unblock requests on a daily basis, based on the scheduled block or unblock date.

* The newly added block/unblock request will have a status ‘A’ when it is yet to be moved to the actual queue.

* When the request is moved to the actual queue table, the status will be updated as ‘P’ if the request has a value for ‘ToDate’, else, the status will be updated as ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error is encountered during processing.

* When the unblock request is moved to the actual queue table, the status of the request will be changed from ‘P’ to ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error has occurred during processing.

> If any of the validations fail, the API will return the appropriate error details in the response.
> The API response will include:

* An error entity holding the details of any error encountered.
* A list of submitted cards along with the individual reference numbers for each of the request.

```csharp
ScheduleCardBlockAsync(
    string requestId,
    Models.ScheduleCardBlockRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`ScheduleCardBlockRequest`](../../doc/models/schedule-card-block-request.md) | Body, Optional | request body |

## Response Type

[`Task<Models.ScheduleCardBlockResponse>`](../../doc/models/schedule-card-block-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
ScheduleCardBlockRequest body = new ScheduleCardBlockRequest
{
    IsTimeSupported = true,
    ScheduleCardBlockCards = new List<ScheduleCardBlockCardsItems>
    {
        new ScheduleCardBlockCardsItems
        {
            Action = "AddOrUpdate",
            ColCoCode = 32,
            ColCoId = 32,
            AccountId = 928,
            AccountNumber = "CZ00000928",
            PayerId = 928,
            PayerNumber = "CZ00000928",
            CardId = 234,
            PAN = "7077327290223418348",
            PANID = "130128",
            CardExpiryDate = "20240731",
            FromDate = "20230701 14:30",
            ToDate = "20230731 16:30",
            Caller = "NextGenUI",
            NotifyCaller = true,
        },
    },
};

try
{
    ScheduleCardBlockResponse result = await cardController.ScheduleCardBlockAsync(
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
  "MainReference": 4124828,
  "RequestId": "b471023f-b1e1-45df-8fe8-126291bd0c30",
  "Status": "SUCCESS",
  "Data": [
    {
      "CardId": 458951,
      "FromDate": "20230613 00:00",
      "ToDate": "20230614 00:00",
      "ReferenceId": 342
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Auto Renew

This API allows to update the reissue indicator of a single card. If the API call succeeds, the API will return a reference number for tracking purposes and queue the request for asynchronous processing.

#### Supported operations

* Update the reissue indicator of a card to enable auto renewal
* Update the reissue indicator of a card to disable auto renewal

#### Validation rules

* Card status must be either Active, Temporary Block (Customer), Temporary Block (Shell) or Pending Renewal, otherwise an error code 9016 is returned

#### API response

* Returns a reference number for the API request (**AutoRenewReference**)

#### Asynchronous processing of valid API request

* If the provided card is superseded i.e. a replacement/new card is already issued, then the latest card's reissue indicator should be updated in the Shell Card Platform.
* Providing a **PAN** request paramter may result in multiple fuel cards being located in the Shell Card Platform. The card details of the most recently issued card will be considered.

```csharp
AutoRenewAsync(
    string requestId,
    Models.AutoRenewCardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`AutoRenewCardRequest`](../../doc/models/auto-renew-card-request.md) | Body, Optional | Auto renew request body |

## Response Type

[`Task<Models.AutoRenewCardResponse>`](../../doc/models/auto-renew-card-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
AutoRenewCardRequest body = new AutoRenewCardRequest
{
    ColCoId = 32,
    ColCoCode = 32,
    PayerNumber = "CZ00000928",
    PayerId = 1227,
    AutoRenewCards = new List<AutoRenewCardRequestAutoRenewCardsItems>
    {
        new AutoRenewCardRequestAutoRenewCardsItems
        {
            ReissueSetting = true,
            AccountNumber = "CZ00000929",
            AccountId = 1229,
            PAN = "7077327290223440243",
            PANID = 17240826,
            CardId = 446472,
        },
    },
};

try
{
    AutoRenewCardResponse result = await cardController.AutoRenewAsync(
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
  "MainReference": 326712,
  "RequestId": "0e6fb42a-51b0-43b2-f010-92f822657f6a",
  "Status": "SUCCESS",
  "Data": [
    {
      "AutoRenewReferenceId": 226,
      "CardIdAndPAN": "446472;7077327290223440243",
      "PANID": 17240826
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Update Mobile Payment Registration Status

This operation allows  update the approval status of Mobile Payment Registration requests requiring for Fleet Manager approval.
If the approval status is:

* “Approved” then the request status will be changed to Pending for processing.
* “Rejected” then status will be updated to “CI” (Failed) with appropriate error message.

```csharp
UpdateMobilePaymentRegistrationStatusAsync(
    string requestId,
    Models.UpdateMPayRegStatusRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`UpdateMPayRegStatusRequest`](../../doc/models/update-m-pay-reg-status-request.md) | Body, Optional | Request body |

## Response Type

[`Task<Models.UpdateMPayRegStatusResponse>`](../../doc/models/update-m-pay-reg-status-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
UpdateMPayRegStatusRequest body = new UpdateMPayRegStatusRequest
{
    ColCoId = 32,
    ColCoCode = 32,
    PayerId = 1223,
    PayerNumber = "CZ00000923",
    MPayRequests = new List<UpdateMPayRegStatusRequestMPayRequestsItems>
    {
        new UpdateMPayRegStatusRequestMPayRequestsItems
        {
            GlobalRequestID = "123",
            Status = "Rejected",
            ApproverUserID = "AdminUser100",
            ApproverUserDisplayName = "AdminUser100",
            Reason = "approved",
        },
    },
};

try
{
    UpdateMPayRegStatusResponse result = await cardController.UpdateMobilePaymentRegistrationStatusAsync(
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
  "RequestId": "b471023f-b1e1-45df-8fe8-126291bd0c30",
  "Status": "SUCCESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | `ApiException` |


# Get Key

Get a new public key that will be used to encrypt data for selected PIN process when ordering new Shell Card. This encrypted data is used for further processing.

```csharp
GetKeyAsync(
    string requestId,
    bool? fleet = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `fleet` | `bool?` | Query, Optional | If the public key will be used a long time for multiple files this parameter will be true. If the parameter is true then public Key will be valid for 90 days. If the parameter is false then the key will be valid for one time. default value will be false. |

## Response Type

[`Task<Models.GeneratePINKeyResponse>`](../../doc/models/generate-pin-key-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
try
{
    GeneratePINKeyResponse result = await cardController.GetKeyAsync(requestId);
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
  "uid": "123aaa33198dc8f3s4k77dsc78",
  "value": "LS0tLS1CRUdJTiBQVUJMSUMgS0VZLS0tLS0KTUlJQ0lqQU5CZ2txaGtpRzl3MEJBUUVGQUFPQ0FnOEFNSUlDQ2dLQ0FnRUFvZ0dSQ3k4N1FjQ3d6MFI0NE9LTwpucEhhZ0p1bW83Wll1V21JdXY2b1ZseUxqYkcwWlgyUFBSUy9LVUdhbXdiWGQwMGtYeHBXbFA5cXJ2N2hYMlNSCkJ2TFJVWFR0TCtvWS9QajN0c2Z6d0liT3VDei9qUnQ5Uk9WdzNBTkZTNjF6blVFTkVsSlNXN2dudnJuL29USWwKRWlid2VVTE5aTlJObFRwQTI1QVhKanhXMzM3ZUx0Y2F5cXJiQlNJNVFmRitCTGJJbE1Rd2tqSkNhUFEzV0pUKwpxcnlCREFCME5ocm02VlBmK2toN2FyR2JqL3ZLS0NRWVBkQWhRKzI3OGp0ZGJZdFBzYWtjN0RqVXpTenl2Wm9HCmhiSEt4V0ZTODFnL2ZlQUZNbFFDVlErZk15ZVN5dFZKOGlmZjFZR2RydEJCdG16U0NRN2V0K1IwaHpUbzJXblcKZzREZG1oWmlZT0MvUU55dk5uY1VSeDRZMU84VW1nSmorNE56c3VyQ2dQMmRSUjNpVXRIYlZaZjRzTEpZWk5CWApORGxjUDNzYWlwTXJ6Z0RpM0VCbWZzdEJOODdvWVdsRzRQNmlPVGt3dzdDVyt0TUdRNmJPcVBBNFF0cWMrYUZMCktZR3FWREhWRnBhZWdwYXl0U2g3T25nd0cwckJod0M4ODNpeVFaZDNKRW1lSWt2V05wYTVRSExqRmJKTEg4M2YKdk9TR2E0aGR6ZmZqYUhUM2VvR2VCRU5NaTZIbFo4RVZHWUh0VUpXZGMzZ2h5OHdPbmZkTlN2NzV3SUZYbHNragpIdHM3Z3NkM3hDN1B3ZnBqOEV5Lyt2aTVLNHM5M29IaE5TYlRhNlUzNUVsZkFXL20zK1YxWjZqVUpwRWpmZkZYCnI0YlFiR3pQNVhWYkNKL21ndmVNM3lNQ0F3RUFBUT09Ci0tLS0tRU5EIFBVQkxJQyBLRVktLS0tLQo="
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | The server understood the request but refuses to authorize it. | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | `ApiException` |


# Delivery Address Update

This API allows users to update the card’s delivery addresses (card delivery address used for card re-issue and PIN delivery address used when PIN reminder is requested)

#### Supported operations

* card delivery address update

```csharp
DeliveryAddressUpdateAsync(
    string apikey,
    Models.DeliveryAddressUpdateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `body` | [`DeliveryAddressUpdateRequest`](../../doc/models/delivery-address-update-request.md) | Body, Optional | Delivery Address Update Request Body |

## Response Type

[`Task<Models.DeliveryAddressUpdateResponse>`](../../doc/models/delivery-address-update-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
DeliveryAddressUpdateRequest body = new DeliveryAddressUpdateRequest
{
    ColCoId = 5,
    ColCoCode = 5,
    PayerId = 123456,
    PayerNumber = "GB000000123",
    AccountId = 12356,
    AccountNumber = "GB000000124",
    DeliveryAddressUpdates = new List<DeliveryAddressUpdate>
    {
        new DeliveryAddressUpdate
        {
            UseCustomerDefaultAddress = true,
            CardId = 123,
            PAN = "7002051006629889654",
            CardExpiryDate = "20170930",
            UpdateCardRenewalAddress = new UpdateCardRenewalAddress2
            {
                ContactName = "Jack",
                CompanyName = "Travel Transport",
                AddressLine = "Elm Street 11",
                ZipCode = "1023EA",
                CountryID = 8,
                ContactTitle = "Mr",
                City = "London",
                RegionID = 2,
                EmailAddress = "testmail@gmail.com",
                PhoneNumber = "+99999999999",
            },
        },
    },
};

try
{
    DeliveryAddressUpdateResponse result = await cardController.DeliveryAddressUpdateAsync(
        apikey,
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
  "RequestId": "eb621f45-a543-4d9a-a934-2f223b263c42",
  "ServiceReference": 123456,
  "DeliveryAddressUpdateReferences": {
    "CardId": 12345,
    "CardPAN": "7002051006629889654",
    "AccountId": 12356,
    "AccountNumber": "GB000000124",
    "ReferenceId": 573567,
    "ErrorInfo": "null"
  },
  "Error": {
    "Code": "0000",
    "Description": "Success"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | `ApiException` |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | `ApiException` |
| 403 | The server understood the request but refuses to authorize it. | `ApiException` |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | `ApiException` |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | `ApiException` |


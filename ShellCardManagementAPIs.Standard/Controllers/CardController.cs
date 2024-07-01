// <copyright file="CardController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using ShellCardManagementAPIs.Standard;
    using ShellCardManagementAPIs.Standard.Exceptions;
    using ShellCardManagementAPIs.Standard.Http.Client;
    using ShellCardManagementAPIs.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// CardController.
    /// </summary>
    public class CardController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardController"/> class.
        /// </summary>
        internal CardController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API allows to search for Shell Cards in the Shell Card Platform. It provides flexible search criteria and supports paging.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * New parameters have been added in the response. Below are the list of parameters added.
        ///       * IsEMVContact.
        ///       * IsEMVContactless.
        ///       * IsRFID.
        ///       * RFIDUID.
        ///       * EMAID.
        ///       * EVPrintedNumber.
        ///       * CardMediaCode.
        /// #### Supported operations.
        ///   * Search cards by card id or PAN.
        ///   * Search cards by card status.
        ///   * Search cards by excluding card status.
        ///   * Search cards by date fields.
        ///   * Search cards by embossed fields.
        ///   * Search cards by card configuration fields.
        ///   * Search cards by included/excluded list of cards.
        ///   * Search cards by excluding card bundle Id.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: requestbody.</param>
        /// <returns>Returns the Models.CardSearchResponse response from the API call.</returns>
        public Models.CardSearchResponse Searchcard(
                string requestId,
                Models.SearchCardRequest body = null)
            => CoreHelper.RunTask(SearchcardAsync(requestId, body));

        /// <summary>
        /// This API allows to search for Shell Cards in the Shell Card Platform. It provides flexible search criteria and supports paging.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * New parameters have been added in the response. Below are the list of parameters added.
        ///       * IsEMVContact.
        ///       * IsEMVContactless.
        ///       * IsRFID.
        ///       * RFIDUID.
        ///       * EMAID.
        ///       * EVPrintedNumber.
        ///       * CardMediaCode.
        /// #### Supported operations.
        ///   * Search cards by card id or PAN.
        ///   * Search cards by card status.
        ///   * Search cards by excluding card status.
        ///   * Search cards by date fields.
        ///   * Search cards by embossed fields.
        ///   * Search cards by card configuration fields.
        ///   * Search cards by included/excluded list of cards.
        ///   * Search cards by excluding card bundle Id.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: requestbody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardSearchResponse response from the API call.</returns>
        public async Task<Models.CardSearchResponse> SearchcardAsync(
                string requestId,
                Models.SearchCardRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardSearchResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/search")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows to search for fuel cards in the Shell Card Platform and returns a high-level summary count. It provides flexible search criteria.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Minor change in response structure with addition of Status parameter.
        ///   .
        /// #### Supported operations.
        ///   * Search cards by card id or PAN.
        ///   * Search cards by card status.
        ///   * Search cards by excluding card status.
        ///   * Search cards by date fields.
        ///   * Search cards by embossed fields.
        ///   * Search cards by card configuration fields.
        ///   * Search cards by included/excluded list of cards.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: summary request body.</param>
        /// <returns>Returns the Models.CardSummaryResponse response from the API call.</returns>
        public Models.CardSummaryResponse Cardsummary(
                string requestId,
                Models.CardSummaryRequest body = null)
            => CoreHelper.RunTask(CardsummaryAsync(requestId, body));

        /// <summary>
        /// This API allows to search for fuel cards in the Shell Card Platform and returns a high-level summary count. It provides flexible search criteria.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Minor change in response structure with addition of Status parameter.
        ///   .
        /// #### Supported operations.
        ///   * Search cards by card id or PAN.
        ///   * Search cards by card status.
        ///   * Search cards by excluding card status.
        ///   * Search cards by date fields.
        ///   * Search cards by embossed fields.
        ///   * Search cards by card configuration fields.
        ///   * Search cards by included/excluded list of cards.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: summary request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardSummaryResponse response from the API call.</returns>
        public async Task<Models.CardSummaryResponse> CardsummaryAsync(
                string requestId,
                Models.CardSummaryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/summary")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This API allows ordering one or more fuel cards (up to 50). If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * New parameters have been added in the response for the new PIN management changes. Below parameters needs to be derived from the new PIN encryption method explained in our Mobility Card PIN Management product.  .
        ///       * SelfSelectedEncryptedPIN.
        ///       * SelfSelectedPINKeyID.
        ///       * SelfSelectedPINSessionKey.
        ///   * New parameters have been added in the response for card and pin delivery mechanism which gives the opportunity to deliver card & pin by email, SMS or post. .
        ///     Also the possibility to deliver card and pin to different address if the use case demands. .
        ///       * CardDeliveryType.
        ///       * PINDeliveryAddressType.
        ///       * PINAdviceType.
        ///       * PINContact.
        ///       * CardContact.
        /// #### Supported operations.
        ///   * Order one or more cards (up to 50).
        ///   * Order card with self selected PIN.
        ///   * Order card with vehicle registration number.
        ///   * Order card and add to new or exisitng card group.
        ///   * Order card and enable fleetId or odemeter input.
        ///   * Order card and specify product groups.
        /// #### Validation rules.
        /// * Number of cards per request does not exceed 50.
        /// #### API response .
        /// * A main reference number for the API request (**OrderReference**).
        /// * Individual reference numbers (**OrderCardReference**) for each new card.
        /// ]]>
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Order card request body.</param>
        /// <returns>Returns the Models.OrderCardResponse response from the API call.</returns>
        public Models.OrderCardResponse Cardordercard(
                string requestId,
                Models.CardManagementV1OrdercardRequest body = null)
            => CoreHelper.RunTask(CardordercardAsync(requestId, body));

        /// <summary>
        /// <![CDATA[
        /// This API allows ordering one or more fuel cards (up to 50). If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * New parameters have been added in the response for the new PIN management changes. Below parameters needs to be derived from the new PIN encryption method explained in our Mobility Card PIN Management product.  .
        ///       * SelfSelectedEncryptedPIN.
        ///       * SelfSelectedPINKeyID.
        ///       * SelfSelectedPINSessionKey.
        ///   * New parameters have been added in the response for card and pin delivery mechanism which gives the opportunity to deliver card & pin by email, SMS or post. .
        ///     Also the possibility to deliver card and pin to different address if the use case demands. .
        ///       * CardDeliveryType.
        ///       * PINDeliveryAddressType.
        ///       * PINAdviceType.
        ///       * PINContact.
        ///       * CardContact.
        /// #### Supported operations.
        ///   * Order one or more cards (up to 50).
        ///   * Order card with self selected PIN.
        ///   * Order card with vehicle registration number.
        ///   * Order card and add to new or exisitng card group.
        ///   * Order card and enable fleetId or odemeter input.
        ///   * Order card and specify product groups.
        /// #### Validation rules.
        /// * Number of cards per request does not exceed 50.
        /// #### API response .
        /// * A main reference number for the API request (**OrderReference**).
        /// * Individual reference numbers (**OrderCardReference**) for each new card.
        /// ]]>
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Order card request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrderCardResponse response from the API call.</returns>
        public async Task<Models.OrderCardResponse> CardordercardAsync(
                string requestId,
                Models.CardManagementV1OrdercardRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/ordercard")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API retrieves the card order status from the Shell Card Platform based on the given reference numbers.
        ///   #### New version updates.
        ///     * Oauth authentication to access the API.
        ///     * Minor change in response structure with addition of Status parameter.
        ///   #### Supported operations.
        ///     * Get order status by Bulk Card Order Reference.
        ///     * Get order status by Order Reference (main reference for the order).
        ///     * Get order status by Card Reference (individual card reference belonging to an order reference).
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Order Card Enquiry request body.</param>
        /// <returns>Returns the Models.OrderCardEnquiryResponse response from the API call.</returns>
        public Models.OrderCardEnquiryResponse Cardordercardenquiry(
                string requestId,
                Models.OrderCardEnquiryRequest body = null)
            => CoreHelper.RunTask(CardordercardenquiryAsync(requestId, body));

        /// <summary>
        /// This API retrieves the card order status from the Shell Card Platform based on the given reference numbers.
        ///   #### New version updates.
        ///     * Oauth authentication to access the API.
        ///     * Minor change in response structure with addition of Status parameter.
        ///   #### Supported operations.
        ///     * Get order status by Bulk Card Order Reference.
        ///     * Get order status by Order Reference (main reference for the order).
        ///     * Get order status by Card Reference (individual card reference belonging to an order reference).
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Order Card Enquiry request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrderCardEnquiryResponse response from the API call.</returns>
        public async Task<Models.OrderCardEnquiryResponse> CardordercardenquiryAsync(
                string requestId,
                Models.OrderCardEnquiryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderCardEnquiryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/ordercardenquiry")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows cancelling one or multiple cards (up to 500) within a single API call. This API allows updating of.
        ///   the card to the following status-.
        /// *  Block (Cancelled).
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in the request body.
        ///     * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery.
        /// Requests that passed the below validations are queued-.
        ///   * All Mandatory fields are passed.
        ///   *  Card is present in the Shell Card Platform.
        ///   *  Only one matching card is available in the cards platform for the given PAN and expiry date for Block requests.
        ///   *  Card is allowed to be moved to proposed state as per the card status transition configuration in cards platform.
        ///   *  A valid Reason Id or Reason Text is provided. The reason for card cancellation can be “Damaged” or “NoLongerRequired”. .
        ///   *  For the given card, there is no Cancel request already submitted via this API and is being processed.
        ///   *  ‘IsReplacementChargeable’ is set to ‘False’ only to the configured customer, other customers need to set it as ‘True’ only. If other customers pass this value as ‘False’.
        ///   Note- Shell Card Platform will maintain the list of   customers, to whom ‘IsReplacementChargeable’ can be set as ‘False’.
        /// If all validations are passed, the request will be accepted and the API will return reference numbers for tracking purpose. If any of the validations fail, the API will return the appropriate error details on response.  The API response will include-.
        ///   *  A main reference number for the API request.
        ///   *  A list of successfully validated and accepted cards along with the individual reference numbers for each of the successful requests.
        ///   *  A list of cards for which at least validation has failed along with the appropriate error code and details.
        ///   A permanent block (cancelled) request for the card will be queued in Shell Card Platform after the configured damaged card active period (configured as number of days).
        ///   .
        ///   When a card is requested to be Blocked permanently (cancelled) for which a request has already been submitted to report as Damaged and the damaged card active period is not yet completed, the damaged card request will be marked as superseded and the new Block (cancelled) request will be processed.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update status request body.</param>
        /// <returns>Returns the Models.CancelCardResponse response from the API call.</returns>
        public Models.CancelCardResponse Cardcancel(
                string requestId,
                Models.CardManagementV1CancelRequest body = null)
            => CoreHelper.RunTask(CardcancelAsync(requestId, body));

        /// <summary>
        /// This API allows cancelling one or multiple cards (up to 500) within a single API call. This API allows updating of.
        ///   the card to the following status-.
        /// *  Block (Cancelled).
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in the request body.
        ///     * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery.
        /// Requests that passed the below validations are queued-.
        ///   * All Mandatory fields are passed.
        ///   *  Card is present in the Shell Card Platform.
        ///   *  Only one matching card is available in the cards platform for the given PAN and expiry date for Block requests.
        ///   *  Card is allowed to be moved to proposed state as per the card status transition configuration in cards platform.
        ///   *  A valid Reason Id or Reason Text is provided. The reason for card cancellation can be “Damaged” or “NoLongerRequired”. .
        ///   *  For the given card, there is no Cancel request already submitted via this API and is being processed.
        ///   *  ‘IsReplacementChargeable’ is set to ‘False’ only to the configured customer, other customers need to set it as ‘True’ only. If other customers pass this value as ‘False’.
        ///   Note- Shell Card Platform will maintain the list of   customers, to whom ‘IsReplacementChargeable’ can be set as ‘False’.
        /// If all validations are passed, the request will be accepted and the API will return reference numbers for tracking purpose. If any of the validations fail, the API will return the appropriate error details on response.  The API response will include-.
        ///   *  A main reference number for the API request.
        ///   *  A list of successfully validated and accepted cards along with the individual reference numbers for each of the successful requests.
        ///   *  A list of cards for which at least validation has failed along with the appropriate error code and details.
        ///   A permanent block (cancelled) request for the card will be queued in Shell Card Platform after the configured damaged card active period (configured as number of days).
        ///   .
        ///   When a card is requested to be Blocked permanently (cancelled) for which a request has already been submitted to report as Damaged and the damaged card active period is not yet completed, the damaged card request will be marked as superseded and the new Block (cancelled) request will be processed.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update status request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CancelCardResponse response from the API call.</returns>
        public async Task<Models.CancelCardResponse> CardcancelAsync(
                string requestId,
                Models.CardManagementV1CancelRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/cancel")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows updating of the card status for one or more cards (up to 500) within a single API call.  If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing. .
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in the request body.
        ///     * Pin change related parameters - SelfSelectedEncryptedPIN, SelfSelectedPINKeyID, SelfSelectedPINSessionKey.
        ///     * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery. .
        ///     * SaveForPINReminder - The given address will be used for sending PIN reminders in future when requested.
        ///     * SaveForCardReissue - If this is specified, the contact address will be saved in cards platform for card reissue processing.
        /// #### Supported operations.
        ///   * Updating a card status to Temporary block, Unblock, Block (Cancelled).
        ///     or Damaged.
        ///   * Requesting a replacement card when status is set to Block or Damaged.
        /// #### Validation rules .
        ///   * Number of cards per request does not exceed 500.
        ///   * A card can be changed to proposed status as per the card status transition configuration in the Shell Card Platform.
        ///   * Locating a card -.
        ///     * If target status set to **TemporaryBlock**, then only one matching active card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**.
        ///     * If target status set to **Unblock** or **Block**, then only one matching card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**.
        ///   * A valid Reason Id or Reason Text is provided.
        ///     * If target status set to **Block** or **Damaged** and a **ReasonText** is provided, the value must be from the fixed list - *'Lost'*, *'Stolen'* or *'Card no longer required'*.
        ///   * For the given card, there is no Status Update request already submitted via this API and is being processed.
        ///   * The **OrderReplacementCard** field is set to True only for cards with a target status set to Block or Damaged.
        /// #### API response .
        ///   * A main reference number for the API request (**OrderReplacementReference**).
        ///   * A list of successfully validated and accepted cards along with the individual reference numbers (**UpdateCardReference**) for each of the successful  request .
        ///   * A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message.
        /// #### Asynchronous processing of valid API request .
        ///   * Replacement cards.
        ///     * Request for a replacement card will be placed only when the Block card or Block damaged card request is successfully placed.
        ///     * The Replacement card request will be processed only when the permanent Block card request is successfully processed. In case of damaged card request, the replacement card request will be processed immediately.
        ///   * Damaged cards.
        ///     * Setting a card to Damaged will automatically trigger a request to permanently block the card. This will only take effect once the ‘Damaged Active’ period has passed.
        ///     * The Damaged card active period is the number of days after which a "Damaged" card request will be processed. This value is configured at ColCo level.
        ///     * If a card is reported as damaged at 10pm local time on 1st Nov and the damaged card period is set to 10 days, then the block request will be submitted to the Shell Card Platform on 11th Nov 00-01 local time.
        ///     * If during the damage card active period another request is made to set the card to Temporarily Blocked or Blocked permanently (cancelled), then the damaged card request will be marked as superseded and the new Temporary Block or Block (cancelled) will be processed.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update status request body.</param>
        /// <returns>Returns the Models.UpdateCardStatusResponse response from the API call.</returns>
        public Models.UpdateCardStatusResponse Cardupdatestatus(
                string requestId,
                Models.CardManagementV1UpdatestatusRequest body = null)
            => CoreHelper.RunTask(CardupdatestatusAsync(requestId, body));

        /// <summary>
        /// This API allows updating of the card status for one or more cards (up to 500) within a single API call.  If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing. .
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in the request body.
        ///     * Pin change related parameters - SelfSelectedEncryptedPIN, SelfSelectedPINKeyID, SelfSelectedPINSessionKey.
        ///     * PIN delivery address details have been added along with Email and Phone number for card and PIN delivery. .
        ///     * SaveForPINReminder - The given address will be used for sending PIN reminders in future when requested.
        ///     * SaveForCardReissue - If this is specified, the contact address will be saved in cards platform for card reissue processing.
        /// #### Supported operations.
        ///   * Updating a card status to Temporary block, Unblock, Block (Cancelled).
        ///     or Damaged.
        ///   * Requesting a replacement card when status is set to Block or Damaged.
        /// #### Validation rules .
        ///   * Number of cards per request does not exceed 500.
        ///   * A card can be changed to proposed status as per the card status transition configuration in the Shell Card Platform.
        ///   * Locating a card -.
        ///     * If target status set to **TemporaryBlock**, then only one matching active card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**.
        ///     * If target status set to **Unblock** or **Block**, then only one matching card should exist in the Shell Card Platform for the given **PAN** and **CardExpiryDate**.
        ///   * A valid Reason Id or Reason Text is provided.
        ///     * If target status set to **Block** or **Damaged** and a **ReasonText** is provided, the value must be from the fixed list - *'Lost'*, *'Stolen'* or *'Card no longer required'*.
        ///   * For the given card, there is no Status Update request already submitted via this API and is being processed.
        ///   * The **OrderReplacementCard** field is set to True only for cards with a target status set to Block or Damaged.
        /// #### API response .
        ///   * A main reference number for the API request (**OrderReplacementReference**).
        ///   * A list of successfully validated and accepted cards along with the individual reference numbers (**UpdateCardReference**) for each of the successful  request .
        ///   * A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message.
        /// #### Asynchronous processing of valid API request .
        ///   * Replacement cards.
        ///     * Request for a replacement card will be placed only when the Block card or Block damaged card request is successfully placed.
        ///     * The Replacement card request will be processed only when the permanent Block card request is successfully processed. In case of damaged card request, the replacement card request will be processed immediately.
        ///   * Damaged cards.
        ///     * Setting a card to Damaged will automatically trigger a request to permanently block the card. This will only take effect once the ‘Damaged Active’ period has passed.
        ///     * The Damaged card active period is the number of days after which a "Damaged" card request will be processed. This value is configured at ColCo level.
        ///     * If a card is reported as damaged at 10pm local time on 1st Nov and the damaged card period is set to 10 days, then the block request will be submitted to the Shell Card Platform on 11th Nov 00-01 local time.
        ///     * If during the damage card active period another request is made to set the card to Temporarily Blocked or Blocked permanently (cancelled), then the damaged card request will be marked as superseded and the new Temporary Block or Block (cancelled) will be processed.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update status request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateCardStatusResponse response from the API call.</returns>
        public async Task<Models.UpdateCardStatusResponse> CardupdatestatusAsync(
                string requestId,
                Models.CardManagementV1UpdatestatusRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateCardStatusResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/updatestatus")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API will allow querying the purchase categories of Card.
        ///  for the given country and/or card type.
        ///   It will also include the below data associated with each of the purchase categories on it’s response.
        ///   *  List of fuel and non-fuel product sets associated. .
        ///   *  List of products configured in each product set.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PurchaseCategory request body.</param>
        /// <returns>Returns the Models.PurchaseCategoryResponse response from the API call.</returns>
        public Models.PurchaseCategoryResponse PurchaseCategory(
                string apikey,
                string requestId,
                Models.PurchaseCategoryRequest body = null)
            => CoreHelper.RunTask(PurchaseCategoryAsync(apikey, requestId, body));

        /// <summary>
        /// This API will allow querying the purchase categories of Card.
        ///  for the given country and/or card type.
        ///   It will also include the below data associated with each of the purchase categories on it’s response.
        ///   *  List of fuel and non-fuel product sets associated. .
        ///   *  List of products configured in each product set.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PurchaseCategory request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PurchaseCategoryResponse response from the API call.</returns>
        public async Task<Models.PurchaseCategoryResponse> PurchaseCategoryAsync(
                string apikey,
                string requestId,
                Models.PurchaseCategoryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PurchaseCategoryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/master/purchasecategory")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows to fetch details of a single fuel card from the Shell Card Platform. If a **CardId** request parameter is provided, this will return a single card.  If a **PAN** request parameter is provided, this may result in multiple fuel cards matching the search criteria. The card details of the most recently issued card will be returned.
        ///   #### Supported operations.
        ///   * Get card by card id or PAN.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card details request body.</param>
        /// <returns>Returns the Models.CardDetailsResponse response from the API call.</returns>
        public Models.CardDetailsResponse Carddetails(
                string apikey,
                string requestId,
                Models.CardDetailsRequest body = null)
            => CoreHelper.RunTask(CarddetailsAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows to fetch details of a single fuel card from the Shell Card Platform. If a **CardId** request parameter is provided, this will return a single card.  If a **PAN** request parameter is provided, this may result in multiple fuel cards matching the search criteria. The card details of the most recently issued card will be returned.
        ///   #### Supported operations.
        ///   * Get card by card id or PAN.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card details request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardDetailsResponse response from the API call.</returns>
        public async Task<Models.CardDetailsResponse> CarddetailsAsync(
                string apikey,
                string requestId,
                Models.CardDetailsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/card/card")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows to move one or more fuel cards (up to 500) across card groups within a single account or across accounts under the same payer. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.
        /// #### Supported operations.
        ///   * Moving card to exisitng card group.
        ///   * Moving card to new card group.
        ///   * Removing a card from a card group .
        /// #### Validation rules.
        ///   * Number of cards per request does not exceed 500.
        ///   * Given **PAN** for a card matches with only one card.
        ///   * A card is allowed to be moved to the **TargetCardGroupId** or **TargetAccountNumber**.
        ///   * A pending move request does not exist in the queue for a card submitted on the same date (customers local).
        ///   * A card has not been moved as part of a previous request on the same date (customers local).
        /// #### API response .
        ///   * A main reference number for the API request (**MoveCardRequestReference**).
        ///   * Individual reference numbers (**MoveCardReference**) for each card move request that passes validation  .
        ///   * A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message.
        /// #### Asynchronous processing of valid API request .
        ///   * Move card requests that have been submitted and processed will be reflected after midnight according to the customers local date.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Move cards request body..</param>
        /// <returns>Returns the Models.CardMoveResponse response from the API call.</returns>
        public Models.CardMoveResponse CardMove(
                string apikey,
                string requestId,
                Models.CardMoveRequest body = null)
            => CoreHelper.RunTask(CardMoveAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows to move one or more fuel cards (up to 500) across card groups within a single account or across accounts under the same payer. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing.
        /// #### Supported operations.
        ///   * Moving card to exisitng card group.
        ///   * Moving card to new card group.
        ///   * Removing a card from a card group .
        /// #### Validation rules.
        ///   * Number of cards per request does not exceed 500.
        ///   * Given **PAN** for a card matches with only one card.
        ///   * A card is allowed to be moved to the **TargetCardGroupId** or **TargetAccountNumber**.
        ///   * A pending move request does not exist in the queue for a card submitted on the same date (customers local).
        ///   * A card has not been moved as part of a previous request on the same date (customers local).
        /// #### API response .
        ///   * A main reference number for the API request (**MoveCardRequestReference**).
        ///   * Individual reference numbers (**MoveCardReference**) for each card move request that passes validation  .
        ///   * A list of cards (**ErrorCards**) that failed validation along with the appropriate error code and message.
        /// #### Asynchronous processing of valid API request .
        ///   * Move card requests that have been submitted and processed will be reflected after midnight according to the customers local date.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Move cards request body..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardMoveResponse response from the API call.</returns>
        public async Task<Models.CardMoveResponse> CardMoveAsync(
                string apikey,
                string requestId,
                Models.CardMoveRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardMoveResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/card/move")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows requesting a PIN reminder for a fuel card. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing. .
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in request body where PIN delivery type can be requested via Email, SMS or Post. PIN delivery contact can be set to different values based on previous contact details of card or pin delivery or can set specific contact details for this request. .
        ///     * PINAdviceType.
        ///     * PINContactType.
        ///     * PINDeliverTo .
        ///   * Please note that we have a **savePINReminder** parameter in order to save the contact details for future such requests. .
        ///   * Change in response body where Card details are also provided along with expiry date and PAN details. .
        /// #### Supported operations.
        ///   * Request a pin reminder by card Id or PAN.
        /// #### Validation rules.
        ///   * Given **PAN** or **CardId** is active.
        ///   * Given **PAN** matches only one active card.
        ///   * Requested card has PIN.
        ///   * There is no pending PIN Reminder request in the queue awaiting to be processed for the card.
        ///   * A PIN reminder request has not been successfully processed in the last 48 hours for the card.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PIN reminder request body.</param>
        /// <returns>Returns the Models.PINReminderResponse response from the API call.</returns>
        public Models.PINReminderResponse Cardpinreminder(
                string requestId,
                Models.CardManagementV1PinreminderRequest body = null)
            => CoreHelper.RunTask(CardpinreminderAsync(requestId, body));

        /// <summary>
        /// This API allows requesting a PIN reminder for a fuel card. If the API call succeeds, the API will return a reference number and queue the request for asynchronous processing. .
        /// #### New version updates.
        ///   * Oauth authentication to access the API.
        ///   * Change in request body where PIN delivery type can be requested via Email, SMS or Post. PIN delivery contact can be set to different values based on previous contact details of card or pin delivery or can set specific contact details for this request. .
        ///     * PINAdviceType.
        ///     * PINContactType.
        ///     * PINDeliverTo .
        ///   * Please note that we have a **savePINReminder** parameter in order to save the contact details for future such requests. .
        ///   * Change in response body where Card details are also provided along with expiry date and PAN details. .
        /// #### Supported operations.
        ///   * Request a pin reminder by card Id or PAN.
        /// #### Validation rules.
        ///   * Given **PAN** or **CardId** is active.
        ///   * Given **PAN** matches only one active card.
        ///   * Requested card has PIN.
        ///   * There is no pending PIN Reminder request in the queue awaiting to be processed for the card.
        ///   * A PIN reminder request has not been successfully processed in the last 48 hours for the card.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PIN reminder request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PINReminderResponse response from the API call.</returns>
        public async Task<Models.PINReminderResponse> CardpinreminderAsync(
                string requestId,
                Models.CardManagementV1PinreminderRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PINReminderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/pinreminder")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows scheduling Card Block / Unblock requests for one or multiple cards (up to 500 (configurable)) within a single API call. This API is used to perform the following Actions:.
        /// >  .
        ///    *  AddOrUpdate (Schedule a new request or update an existing     scheduled request for the overlapping period.
        ///    *  AddAndOverwriteAll (all the existing requests of the given card will be removed and a new request with the specified FromDate and ToDate will be added.).
        ///    *  Delete (Deletes the scheduled request for the same From and To date).
        ///    *  DeleteAll (Deletes all the scheduled requests for the given card).
        /// > Requests that passed the below validations are queue:.
        /// *  All Mandatory fields are passed in the request.
        /// *  Card is present in the Shell Card Platform. Only one matching card is available in the cards platform for the given PAN and expiry date for the requests.
        /// *  The scheduled period start date or end date should be later than or equal to the current date.  .
        /// > If all validations are passed, the request will be accepted and saved in the intermediate queue  and the API will return reference numbers for tracking purpose. .
        /// > A background service will execute the block/unblock requests on a daily basis, based on the scheduled block or unblock date.
        ///   .
        ///   *  The newly added block/unblock request will have a status ‘A’ when it is yet to be moved to the actual queue. .
        ///   *  When the request is moved to the actual queue table, the status will be updated as ‘P’ if the request has a value for ‘ToDate’, else, the status will be updated as ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error is encountered during processing. .
        ///   .
        ///   *  When the unblock request is moved to the actual queue table, the status of the request will be changed from ‘P’ to ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error has occurred during processing.
        /// > If any of the validations fail, the API will return the appropriate error details in the response. .
        /// > The API response will include:.
        ///   *  An error entity holding the details of any error encountered.
        ///   * A list of submitted cards along with the individual reference numbers for each of the request.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: request body.</param>
        /// <returns>Returns the Models.ScheduleCardBlockResponse response from the API call.</returns>
        public Models.ScheduleCardBlockResponse ScheduleCardBlock(
                string requestId,
                Models.ScheduleCardBlockRequest body = null)
            => CoreHelper.RunTask(ScheduleCardBlockAsync(requestId, body));

        /// <summary>
        /// This API allows scheduling Card Block / Unblock requests for one or multiple cards (up to 500 (configurable)) within a single API call. This API is used to perform the following Actions:.
        /// >  .
        ///    *  AddOrUpdate (Schedule a new request or update an existing     scheduled request for the overlapping period.
        ///    *  AddAndOverwriteAll (all the existing requests of the given card will be removed and a new request with the specified FromDate and ToDate will be added.).
        ///    *  Delete (Deletes the scheduled request for the same From and To date).
        ///    *  DeleteAll (Deletes all the scheduled requests for the given card).
        /// > Requests that passed the below validations are queue:.
        /// *  All Mandatory fields are passed in the request.
        /// *  Card is present in the Shell Card Platform. Only one matching card is available in the cards platform for the given PAN and expiry date for the requests.
        /// *  The scheduled period start date or end date should be later than or equal to the current date.  .
        /// > If all validations are passed, the request will be accepted and saved in the intermediate queue  and the API will return reference numbers for tracking purpose. .
        /// > A background service will execute the block/unblock requests on a daily basis, based on the scheduled block or unblock date.
        ///   .
        ///   *  The newly added block/unblock request will have a status ‘A’ when it is yet to be moved to the actual queue. .
        ///   *  When the request is moved to the actual queue table, the status will be updated as ‘P’ if the request has a value for ‘ToDate’, else, the status will be updated as ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error is encountered during processing. .
        ///   .
        ///   *  When the unblock request is moved to the actual queue table, the status of the request will be changed from ‘P’ to ‘S’ or ‘F’ based on whether the request has been successfully moved to the actual queue table or if an error has occurred during processing.
        /// > If any of the validations fail, the API will return the appropriate error details in the response. .
        /// > The API response will include:.
        ///   *  An error entity holding the details of any error encountered.
        ///   * A list of submitted cards along with the individual reference numbers for each of the request.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduleCardBlockResponse response from the API call.</returns>
        public async Task<Models.ScheduleCardBlockResponse> ScheduleCardBlockAsync(
                string requestId,
                Models.ScheduleCardBlockRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduleCardBlockResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/schedulecardblock")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows to update the reissue indicator of a single card. If the API call succeeds, the API will return a reference number for tracking purposes and queue the request for asynchronous processing.
        /// #### Supported operations.
        ///   * Update the reissue indicator of a card to enable auto renewal.
        ///   * Update the reissue indicator of a card to disable auto renewal.
        /// #### Validation rules.
        ///   * Card status must be either Active, Temporary Block (Customer), Temporary Block (Shell) or Pending Renewal, otherwise an error code 9016 is returned.
        ///   .
        /// #### API response.
        ///   * Returns a reference number for the API request (**AutoRenewReference**).
        /// #### Asynchronous processing of valid API request.
        ///   * If the provided card is superseded i.e. a replacement/new card is already issued, then the latest card's reissue indicator should be updated in the Shell Card Platform.
        ///   * Providing a **PAN** request paramter may result in multiple fuel cards being located in the Shell Card Platform. The card details of the most recently issued card will be considered.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Auto renew request body.</param>
        /// <returns>Returns the Models.AutoRenewCardResponse response from the API call.</returns>
        public Models.AutoRenewCardResponse Autorenew(
                string requestId,
                Models.AutoRenewCardRequest body = null)
            => CoreHelper.RunTask(AutorenewAsync(requestId, body));

        /// <summary>
        /// This API allows to update the reissue indicator of a single card. If the API call succeeds, the API will return a reference number for tracking purposes and queue the request for asynchronous processing.
        /// #### Supported operations.
        ///   * Update the reissue indicator of a card to enable auto renewal.
        ///   * Update the reissue indicator of a card to disable auto renewal.
        /// #### Validation rules.
        ///   * Card status must be either Active, Temporary Block (Customer), Temporary Block (Shell) or Pending Renewal, otherwise an error code 9016 is returned.
        ///   .
        /// #### API response.
        ///   * Returns a reference number for the API request (**AutoRenewReference**).
        /// #### Asynchronous processing of valid API request.
        ///   * If the provided card is superseded i.e. a replacement/new card is already issued, then the latest card's reissue indicator should be updated in the Shell Card Platform.
        ///   * Providing a **PAN** request paramter may result in multiple fuel cards being located in the Shell Card Platform. The card details of the most recently issued card will be considered.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Auto renew request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AutoRenewCardResponse response from the API call.</returns>
        public async Task<Models.AutoRenewCardResponse> AutorenewAsync(
                string requestId,
                Models.AutoRenewCardRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AutoRenewCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/autorenew")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This operation allows  update the approval status of Mobile Payment Registration requests requiring for Fleet Manager approval.
        /// If the approval status is:.
        /// *	“Approved” then the request status will be changed to Pending for processing. .
        /// *	“Rejected” then status will be updated to “CI” (Failed) with appropriate error message. .
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Request body.</param>
        /// <returns>Returns the Models.UpdateMPayRegStatusResponse response from the API call.</returns>
        public Models.UpdateMPayRegStatusResponse Updatemobilepaymentregistrationstatus(
                string requestId,
                Models.UpdateMPayRegStatusRequest body = null)
            => CoreHelper.RunTask(UpdatemobilepaymentregistrationstatusAsync(requestId, body));

        /// <summary>
        /// This operation allows  update the approval status of Mobile Payment Registration requests requiring for Fleet Manager approval.
        /// If the approval status is:.
        /// *	“Approved” then the request status will be changed to Pending for processing. .
        /// *	“Rejected” then status will be updated to “CI” (Failed) with appropriate error message. .
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateMPayRegStatusResponse response from the API call.</returns>
        public async Task<Models.UpdateMPayRegStatusResponse> UpdatemobilepaymentregistrationstatusAsync(
                string requestId,
                Models.UpdateMPayRegStatusRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateMPayRegStatusResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-management/v1/updatemobilepaymentregistrationstatus")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a new public key that will be used to encrypt data for selected PIN process when ordering new Shell Card. This encrypted data is used for further processing.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="fleet">Optional parameter: If the public key will be used a long time for multiple files this parameter will be true. If the parameter is true then public Key will be valid for 90 days. If the parameter is false then the key will be valid for one time. default value will be false..</param>
        /// <returns>Returns the Models.GeneratePINKeyResponse response from the API call.</returns>
        public Models.GeneratePINKeyResponse Getkey(
                string requestId,
                bool? fleet = null)
            => CoreHelper.RunTask(GetkeyAsync(requestId, fleet));

        /// <summary>
        /// Get a new public key that will be used to encrypt data for selected PIN process when ordering new Shell Card. This encrypted data is used for further processing.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="fleet">Optional parameter: If the public key will be used a long time for multiple files this parameter will be true. If the parameter is true then public Key will be valid for 90 days. If the parameter is false then the key will be valid for one time. default value will be false..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GeneratePINKeyResponse response from the API call.</returns>
        public async Task<Models.GeneratePINKeyResponse> GetkeyAsync(
                string requestId,
                bool? fleet = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GeneratePINKeyResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/pin-management/v1/generatepinkeys")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("fleet", fleet))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows users to update the card’s delivery addresses (card delivery address used for card re-issue and PIN delivery address used when PIN reminder is requested).
        /// #### Supported operations.
        ///   * card delivery address update.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="body">Optional parameter: Delivery Address Update Request Body.</param>
        /// <returns>Returns the Models.DeliveryAddressUpdateResponse response from the API call.</returns>
        public Models.DeliveryAddressUpdateResponse Deliveryaddressupdate(
                string apikey,
                Models.DeliveryAddressUpdateRequest body = null)
            => CoreHelper.RunTask(DeliveryaddressupdateAsync(apikey, body));

        /// <summary>
        /// This API allows users to update the card’s delivery addresses (card delivery address used for card re-issue and PIN delivery address used when PIN reminder is requested).
        /// #### Supported operations.
        ///   * card delivery address update.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="body">Optional parameter: Delivery Address Update Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeliveryAddressUpdateResponse response from the API call.</returns>
        public async Task<Models.DeliveryAddressUpdateResponse> DeliveryaddressupdateAsync(
                string apikey,
                Models.DeliveryAddressUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeliveryAddressUpdateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/card/deliveryaddressupdate")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
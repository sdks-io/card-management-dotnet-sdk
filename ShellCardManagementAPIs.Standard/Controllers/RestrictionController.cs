// <copyright file="RestrictionController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellCardManagementAPIs.Standard.Controllers
{
    /// <summary>
    /// RestrictionController.
    /// </summary>
    public class RestrictionController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionController"/> class.
        /// </summary>
        internal RestrictionController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API will allows querying card details including the day/time and product restrictions.
        /// #### Supported operations.
        ///   * Search by list of cards or bundle.
        ///   * Include card bundle details (optional).
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Restriction search card request body.</param>
        /// <returns>Returns the Models.SearchCardRestrictionRes response from the API call.</returns>
        public Models.SearchCardRestrictionRes SearchCardRestriction(
                string apikey,
                string requestId,
                Models.SearchCardRestrictionReq body = null)
            => CoreHelper.RunTask(SearchCardRestrictionAsync(apikey, requestId, body));

        /// <summary>
        /// This API will allows querying card details including the day/time and product restrictions.
        /// #### Supported operations.
        ///   * Search by list of cards or bundle.
        ///   * Include card bundle details (optional).
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Restriction search card request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchCardRestrictionRes response from the API call.</returns>
        public async Task<Models.SearchCardRestrictionRes> SearchCardRestrictionAsync(
                string apikey,
                string requestId,
                Models.SearchCardRestrictionReq body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchCardRestrictionRes>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v2/restriction/searchcard")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.", (_reason, _context) => new FleetmanagementV2RestrictionSearchcard401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.", (_reason, _context) => new FleetmanagementV2RestrictionSearchcard500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The Card Limit and Restriction API is REST-based and employs Basic and ApiKey authentication. The API endpoints accept JSON-encoded request bodies, return JSON-encoded responses and use standard HTTP response codes. .
        /// All resources are located in the Shell Card Platform.  The Shell Card Platform is the overall platform that encompasses all the internal Shell systems used to manage resources. The internal workings of the platform are not important when interacting with the API. However, it is worth noting that the platform uses a microservice architecture to communicate with various backend systems and some API calls are processed asynchronously.
        /// All endpoints use the `POST` verb for retrieving, updating, creating and deleting resources in the Shell Card Platform. The endpoints that retrieve resources from the Shell Card Platform allow flexible search parameters in the API request body.
        /// **Important Note** - This operation allows setting or updating the restrictions on existing cards. (For up to 3 cards in a single call).
        /// All restrictions of the cards are submitted and executed after successful below condition.
        /// •    The card exists.
        /// •    Day time restriction cannot be set to restrict the use of a card on all days of the week i.e., the values for all the days in the restriction cannot be set to false.
        /// •    Either of the usage, daytime, location or product restriction ‘Reset’ is set to ‘True’ or applied on the card.
        /// •    All the limits in the usage restriction profile for a card is not set to ‘0’/null.
        /// •    If IsVelocityCeiling is ‘true’, API will validate below condition:.
        /// Usage restrictions for a card are lower than Customer Card Type level limits, if there are no customer level overrides available then lower than OU card type limits.
        /// •    In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly, Monthly should be less than or equal to Yearly (Annually). Exception being null/blank will be skipped. i.e., Daily value should be less than equal to Monthly value if Weekly value is null/blank. Lifetime limit is not considered for usage restrictions limits validation.
        /// •    Apply the card type limit to Gateway when a value is NULL in the input. However, if the card type limit is NULL for the same field, then no limit will be applied in Gateway.
        /// •    If ‘SetDefaultOnVelocityUpdate’ is ‘true’ then the operation will apply customer cardtype or OU level velocity limits on existing cards when restrictions are modified without providing custom values for all fields.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card Restriction request body.</param>
        /// <returns>Returns the Models.CardRestrictionResponse response from the API call.</returns>
        public Models.CardRestrictionResponse ApplyRestriction(
                string apikey,
                string requestId,
                Models.CardRestrictionReq body = null)
            => CoreHelper.RunTask(ApplyRestrictionAsync(apikey, requestId, body));

        /// <summary>
        /// The Card Limit and Restriction API is REST-based and employs Basic and ApiKey authentication. The API endpoints accept JSON-encoded request bodies, return JSON-encoded responses and use standard HTTP response codes. .
        /// All resources are located in the Shell Card Platform.  The Shell Card Platform is the overall platform that encompasses all the internal Shell systems used to manage resources. The internal workings of the platform are not important when interacting with the API. However, it is worth noting that the platform uses a microservice architecture to communicate with various backend systems and some API calls are processed asynchronously.
        /// All endpoints use the `POST` verb for retrieving, updating, creating and deleting resources in the Shell Card Platform. The endpoints that retrieve resources from the Shell Card Platform allow flexible search parameters in the API request body.
        /// **Important Note** - This operation allows setting or updating the restrictions on existing cards. (For up to 3 cards in a single call).
        /// All restrictions of the cards are submitted and executed after successful below condition.
        /// •    The card exists.
        /// •    Day time restriction cannot be set to restrict the use of a card on all days of the week i.e., the values for all the days in the restriction cannot be set to false.
        /// •    Either of the usage, daytime, location or product restriction ‘Reset’ is set to ‘True’ or applied on the card.
        /// •    All the limits in the usage restriction profile for a card is not set to ‘0’/null.
        /// •    If IsVelocityCeiling is ‘true’, API will validate below condition:.
        /// Usage restrictions for a card are lower than Customer Card Type level limits, if there are no customer level overrides available then lower than OU card type limits.
        /// •    In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly, Monthly should be less than or equal to Yearly (Annually). Exception being null/blank will be skipped. i.e., Daily value should be less than equal to Monthly value if Weekly value is null/blank. Lifetime limit is not considered for usage restrictions limits validation.
        /// •    Apply the card type limit to Gateway when a value is NULL in the input. However, if the card type limit is NULL for the same field, then no limit will be applied in Gateway.
        /// •    If ‘SetDefaultOnVelocityUpdate’ is ‘true’ then the operation will apply customer cardtype or OU level velocity limits on existing cards when restrictions are modified without providing custom values for all fields.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card Restriction request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardRestrictionResponse response from the API call.</returns>
        public async Task<Models.CardRestrictionResponse> ApplyRestrictionAsync(
                string apikey,
                string requestId,
                Models.CardRestrictionReq body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardRestrictionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v2/restriction/card")
                  .WithAuth("BasicAuth")
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
        /// This API enables clients to create a new card bundle and apply restrictions.
        /// #### Supported operations.
        ///   * Create bundle and include mandatory -.
        ///     * Usage, day/time, product and location restrictions.
        ///     * List of cards to add to bundle.
        ///   * Create bundle and include optional identifier of bundle in external system.
        /// #### Validation rules.
        ///   The following are the key validation rules with the associated error codes for failed validation-.
        ///   * `7012` - At least one card must be added to the bundle.
        ///   *  `7011` - The total number of cards passed in the input must be 500 or less.
        ///   *  `7014` - All the cards passed in the input are part of the selected account.
        ///   *  `7013` - At least one restriction must be applied to the bundle i.e. either of usage, day/time, location or product restriction.
        ///   *  `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week.
        ///   *  `7000` - Usage restriction of the bundle is not open ended i.e. all the limits within the usage restriction must not be set to 0/null.
        ///   *  `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e. Daily value should be less than equal to Monthly value if Weekly value is 0/blank. .
        ///   *  `0007` - Error returned if request parameters fail validation e.g. mandatory check.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: CreateBundle request body.</param>
        /// <returns>Returns the Models.CreateBundleResponse response from the API call.</returns>
        public Models.CreateBundleResponse CreateBundle(
                string apikey,
                string requestId,
                Models.CreateBundleRequest body = null)
            => CoreHelper.RunTask(CreateBundleAsync(apikey, requestId, body));

        /// <summary>
        /// This API enables clients to create a new card bundle and apply restrictions.
        /// #### Supported operations.
        ///   * Create bundle and include mandatory -.
        ///     * Usage, day/time, product and location restrictions.
        ///     * List of cards to add to bundle.
        ///   * Create bundle and include optional identifier of bundle in external system.
        /// #### Validation rules.
        ///   The following are the key validation rules with the associated error codes for failed validation-.
        ///   * `7012` - At least one card must be added to the bundle.
        ///   *  `7011` - The total number of cards passed in the input must be 500 or less.
        ///   *  `7014` - All the cards passed in the input are part of the selected account.
        ///   *  `7013` - At least one restriction must be applied to the bundle i.e. either of usage, day/time, location or product restriction.
        ///   *  `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week.
        ///   *  `7000` - Usage restriction of the bundle is not open ended i.e. all the limits within the usage restriction must not be set to 0/null.
        ///   *  `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e. Daily value should be less than equal to Monthly value if Weekly value is 0/blank. .
        ///   *  `0007` - Error returned if request parameters fail validation e.g. mandatory check.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: CreateBundle request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateBundleResponse response from the API call.</returns>
        public async Task<Models.CreateBundleResponse> CreateBundleAsync(
                string apikey,
                string requestId,
                Models.CreateBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/createbundle")
                  .WithAuth("BasicAuth")
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
        /// This API enables clients to update an existing card bundle and its associated restrictions.
        /// #### Supported operations.
        ///   * Add new cards to an existing bundle.
        ///   * Remove cards from existing bundle.
        ///   * Update restrictions applied to existing bundle.
        ///   The following are the key validation rules with the associated error codes for failed validation-      .
        /// #### Validation rules.
        ///   *  `9007` - The cards must exist in the cards platform for adding or removing cards.
        ///   *  `7014` - All the cards passed in the input are part of the selected account.
        ///   *  `7018` - All the cards passed in the input are part of the selected bundle.
        ///   *  `7011` - The total number of cards passed in the input must be 500 or less.
        ///   *  `7012` - The action to remove cards should not result in removing all the cards from the bundle.
        ///   *  `7016` - At least one restriction must be modified for â€œUpdateâ€ request action.
        ///   *  `7013` - All restrictions cannot be marked for â€œResetâ€ for â€œUpdateâ€ request action.
        ///   *  `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week. This validation is applicable for Update request action.
        ///   *  `7000` - Usage restriction of the bundle is not open ended i.e., all the limits within the usage restriction must not be set to 0/null. This validation is applicable for Update request action.
        ///   *  `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank. This validation is applicable for Update request action.
        ///   *  `0007` - Error returned if request parameters fail validation e.g. at least one card must be provided in the input.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle request body.</param>
        /// <returns>Returns the Models.UpdateBundleResponse response from the API call.</returns>
        public Models.UpdateBundleResponse UpdateBundle(
                string apikey,
                string requestId,
                Models.UpdateBundleRequest body = null)
            => CoreHelper.RunTask(UpdateBundleAsync(apikey, requestId, body));

        /// <summary>
        /// This API enables clients to update an existing card bundle and its associated restrictions.
        /// #### Supported operations.
        ///   * Add new cards to an existing bundle.
        ///   * Remove cards from existing bundle.
        ///   * Update restrictions applied to existing bundle.
        ///   The following are the key validation rules with the associated error codes for failed validation-      .
        /// #### Validation rules.
        ///   *  `9007` - The cards must exist in the cards platform for adding or removing cards.
        ///   *  `7014` - All the cards passed in the input are part of the selected account.
        ///   *  `7018` - All the cards passed in the input are part of the selected bundle.
        ///   *  `7011` - The total number of cards passed in the input must be 500 or less.
        ///   *  `7012` - The action to remove cards should not result in removing all the cards from the bundle.
        ///   *  `7016` - At least one restriction must be modified for â€œUpdateâ€ request action.
        ///   *  `7013` - All restrictions cannot be marked for â€œResetâ€ for â€œUpdateâ€ request action.
        ///   *  `7005` - Day time restriction cannot be set to restrict the use of a card on all days of the week. This validation is applicable for Update request action.
        ///   *  `7000` - Usage restriction of the bundle is not open ended i.e., all the limits within the usage restriction must not be set to 0/null. This validation is applicable for Update request action.
        ///   *  `7004` - In the usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank. This validation is applicable for Update request action.
        ///   *  `0007` - Error returned if request parameters fail validation e.g. at least one card must be provided in the input.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateBundleResponse response from the API call.</returns>
        public async Task<Models.UpdateBundleResponse> UpdateBundleAsync(
                string apikey,
                string requestId,
                Models.UpdateBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/updatebundle")
                  .WithAuth("BasicAuth")
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
        /// This API enables clients to delete an existing card bundle in the Shell Card Platform. Once the card bundle is deleted the usage and product restrictions of the cards that were present in the bundle will be reset based on the request.
        /// #### Supported operations.
        ///   * Delete card bundle by bundle Id.
        /// #### Validation rules.
        ///   The following are the key validation rules with the associated error codes for failed validation-.
        ///   *  `7019` - The given card bundle is not available in the Shell Card Platform. .
        ///   *  `0007` - Error returned if request parameters fail validation e.g. mandatory check.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle request body.</param>
        /// <returns>Returns the Models.DeleteBundleResponse response from the API call.</returns>
        public Models.DeleteBundleResponse DeleteBundle(
                string apikey,
                string requestId,
                Models.DeleteBundleRequest body = null)
            => CoreHelper.RunTask(DeleteBundleAsync(apikey, requestId, body));

        /// <summary>
        /// This API enables clients to delete an existing card bundle in the Shell Card Platform. Once the card bundle is deleted the usage and product restrictions of the cards that were present in the bundle will be reset based on the request.
        /// #### Supported operations.
        ///   * Delete card bundle by bundle Id.
        /// #### Validation rules.
        ///   The following are the key validation rules with the associated error codes for failed validation-.
        ///   *  `7019` - The given card bundle is not available in the Shell Card Platform. .
        ///   *  `0007` - Error returned if request parameters fail validation e.g. mandatory check.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteBundleResponse response from the API call.</returns>
        public async Task<Models.DeleteBundleResponse> DeleteBundleAsync(
                string apikey,
                string requestId,
                Models.DeleteBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/deletebundle")
                  .WithAuth("BasicAuth")
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
        /// This API allows clients to get a summary of card bundles associated with Payer/Account. This API will return the basic bundle details including card and restriction details. Optionally the API will also include a count of cards that are not associated with the bundle but returned by the search criteria.
        /// Note - to include count of cards of an account that are not associated with any bundles, in the input parameter SearchCardBundles either pass all the bundles of the account in the list or pass only account with bundle id left blank/null.
        /// #### Supported operations.
        ///   * Get summary of bundles by list of bundle Ids.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary of Bundle request body.</param>
        /// <returns>Returns the Models.SummaryofbundleResponse response from the API call.</returns>
        public Models.SummaryofbundleResponse Summaryofbundles(
                string apikey,
                string requestId,
                Models.SummaryofbundlerRequest body = null)
            => CoreHelper.RunTask(SummaryofbundlesAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows clients to get a summary of card bundles associated with Payer/Account. This API will return the basic bundle details including card and restriction details. Optionally the API will also include a count of cards that are not associated with the bundle but returned by the search criteria.
        /// Note - to include count of cards of an account that are not associated with any bundles, in the input parameter SearchCardBundles either pass all the bundles of the account in the list or pass only account with bundle id left blank/null.
        /// #### Supported operations.
        ///   * Get summary of bundles by list of bundle Ids.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary of Bundle request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SummaryofbundleResponse response from the API call.</returns>
        public async Task<Models.SummaryofbundleResponse> SummaryofbundlesAsync(
                string apikey,
                string requestId,
                Models.SummaryofbundlerRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SummaryofbundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/summaryofbundles")
                  .WithAuth("BasicAuth")
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
        /// This API allows setting or updating the usage restrictions of an existing account. .
        /// Then validation rules applied for this API.
        /// •    The account exists.
        /// •    Day time restriction cannot be set to restrict the use of a card, under the account, on all days of the week.
        /// •    Either of the usage, daytime or location is either marked for reset or new restriction values provided for the account.
        /// •    In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Account Restriction request body.</param>
        /// <returns>Returns the Models.AccountRestrictionResponse response from the API call.</returns>
        public Models.AccountRestrictionResponse RestrictionAccount(
                string apikey,
                string requestId,
                Models.AccountRestrictionRequest body = null)
            => CoreHelper.RunTask(RestrictionAccountAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows setting or updating the usage restrictions of an existing account. .
        /// Then validation rules applied for this API.
        /// •    The account exists.
        /// •    Day time restriction cannot be set to restrict the use of a card, under the account, on all days of the week.
        /// •    Either of the usage, daytime or location is either marked for reset or new restriction values provided for the account.
        /// •    In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Account Restriction request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountRestrictionResponse response from the API call.</returns>
        public async Task<Models.AccountRestrictionResponse> RestrictionAccountAsync(
                string apikey,
                string requestId,
                Models.AccountRestrictionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountRestrictionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/account")
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
        /// This API will allow user to get account level limits for the given account. It returns the velocity limits if its overridden at the account else the values will be null/empty.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Search Account Limit RequestBody.</param>
        /// <returns>Returns the Models.SearchAccountLimitResponse response from the API call.</returns>
        public Models.SearchAccountLimitResponse SearchAccountLimit(
                string apikey,
                string requestId,
                Models.SearchAccountLimitRequest body = null)
            => CoreHelper.RunTask(SearchAccountLimitAsync(apikey, requestId, body));

        /// <summary>
        /// This API will allow user to get account level limits for the given account. It returns the velocity limits if its overridden at the account else the values will be null/empty.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Search Account Limit RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchAccountLimitResponse response from the API call.</returns>
        public async Task<Models.SearchAccountLimitResponse> SearchAccountLimitAsync(
                string apikey,
                string requestId,
                Models.SearchAccountLimitRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchAccountLimitResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/searchaccountlimit")
                  .WithAuth("BasicAuth")
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
        /// This API allows to get the details of a specific card bundle. It returns the bundle basic details along with the cards in the bundle and restrictions applied on them.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Bundle Details Request body.</param>
        /// <returns>Returns the Models.BundleDetailsResponse response from the API call.</returns>
        public Models.BundleDetailsResponse Bundledetails(
                string apikey,
                string requestId,
                Models.BudleDetailsRequest body = null)
            => CoreHelper.RunTask(BundledetailsAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows to get the details of a specific card bundle. It returns the bundle basic details along with the cards in the bundle and restrictions applied on them.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Bundle Details Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BundleDetailsResponse response from the API call.</returns>
        public async Task<Models.BundleDetailsResponse> BundledetailsAsync(
                string apikey,
                string requestId,
                Models.BudleDetailsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BundleDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/restriction/bundledetails")
                  .WithAuth("BasicAuth")
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
    }
}
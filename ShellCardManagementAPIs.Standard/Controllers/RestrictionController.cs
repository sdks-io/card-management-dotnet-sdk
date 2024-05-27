// <copyright file="RestrictionController.cs" company="APIMatic">
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
    /// RestrictionController.
    /// </summary>
    public class RestrictionController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionController"/> class.
        /// </summary>
        internal RestrictionController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

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
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Create Bundle Request body.</param>
        /// <returns>Returns the Models.CreateBundleResponse response from the API call.</returns>
        public Models.CreateBundleResponse RestrictionBundleCreate(
                string requestId,
                Models.CreateBundleRequest body = null)
            => CoreHelper.RunTask(RestrictionBundleCreateAsync(requestId, body));

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
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Create Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateBundleResponse response from the API call.</returns>
        public async Task<Models.CreateBundleResponse> RestrictionBundleCreateAsync(
                string requestId,
                Models.CreateBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/bundles/create")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
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
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle Request body.</param>
        /// <returns>Returns the Models.UpdateBundleResponse response from the API call.</returns>
        public Models.UpdateBundleResponse RestrictionBundleUpdate(
                string requestId,
                Models.UpdateBundleRequest body = null)
            => CoreHelper.RunTask(RestrictionBundleUpdateAsync(requestId, body));

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
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Update Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateBundleResponse response from the API call.</returns>
        public async Task<Models.UpdateBundleResponse> RestrictionBundleUpdateAsync(
                string requestId,
                Models.UpdateBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/bundles/update")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
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
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Delete Bundle Request body.</param>
        /// <returns>Returns the Models.DeleteBundleResponse response from the API call.</returns>
        public Models.DeleteBundleResponse RestrictionBundleDelete(
                string requestId,
                Models.DeleteBundleRequest body = null)
            => CoreHelper.RunTask(RestrictionBundleDeleteAsync(requestId, body));

        /// <summary>
        /// This API enables clients to delete an existing card bundle in the Shell Card Platform. Once the card bundle is deleted the usage and product restrictions of the cards that were present in the bundle will be reset based on the request.
        /// #### Supported operations.
        ///   * Delete card bundle by bundle Id.
        /// #### Validation rules.
        ///   The following are the key validation rules with the associated error codes for failed validation-.
        ///   *  `7019` - The given card bundle is not available in the Shell Card Platform. .
        ///   *  `0007` - Error returned if request parameters fail validation e.g. mandatory check.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Delete Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteBundleResponse response from the API call.</returns>
        public async Task<Models.DeleteBundleResponse> RestrictionBundleDeleteAsync(
                string requestId,
                Models.DeleteBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/bundles/delete")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows clients to get a summary of card bundles associated with Payer/Account. This API will return the basic bundle details including card and restriction details. Optionally the API will also include a count of cards that are not associated with the bundle but returned by the search criteria.
        /// Note - to include count of cards of an account that are not associated with any bundles, in the input parameter SearchCardBundles either pass all the bundles of the account in the list or pass only account with bundle id left blank/null.
        /// #### Supported operations.
        ///   * Get summary of bundles by list of bundle Ids.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <returns>Returns the Models.SummaryOfBundleResponse response from the API call.</returns>
        public Models.SummaryOfBundleResponse RestrictionBundleSummary(
                string requestId,
                Models.SummaryOfBundleRequest body = null)
            => CoreHelper.RunTask(RestrictionBundleSummaryAsync(requestId, body));

        /// <summary>
        /// This API allows clients to get a summary of card bundles associated with Payer/Account. This API will return the basic bundle details including card and restriction details. Optionally the API will also include a count of cards that are not associated with the bundle but returned by the search criteria.
        /// Note - to include count of cards of an account that are not associated with any bundles, in the input parameter SearchCardBundles either pass all the bundles of the account in the list or pass only account with bundle id left blank/null.
        /// #### Supported operations.
        ///   * Get summary of bundles by list of bundle Ids.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SummaryOfBundleResponse response from the API call.</returns>
        public async Task<Models.SummaryOfBundleResponse> RestrictionBundleSummaryAsync(
                string requestId,
                Models.SummaryOfBundleRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SummaryOfBundleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/bundles/Summary")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows to set or update the restrictions for existing cards or newly ordered cards under the same payer.
        ///   #### Supported operations.
        ///   * Set or reset usage restrictions for cards.
        ///   * Set or reset day/time restrictions for cards.
        ///   * Set or reset product restrictions for cards.
        ///   * Set or reset location restrictions for cards.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <returns>Returns the Models.RestrictionCardResponse response from the API call.</returns>
        public Models.RestrictionCardResponse CardRestriction(
                string requestId,
                Models.RestrictionCardRequest body = null)
            => CoreHelper.RunTask(CardRestrictionAsync(requestId, body));

        /// <summary>
        /// This API allows to set or update the restrictions for existing cards or newly ordered cards under the same payer.
        ///   #### Supported operations.
        ///   * Set or reset usage restrictions for cards.
        ///   * Set or reset day/time restrictions for cards.
        ///   * Set or reset product restrictions for cards.
        ///   * Set or reset location restrictions for cards.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestrictionCardResponse response from the API call.</returns>
        public async Task<Models.RestrictionCardResponse> CardRestrictionAsync(
                string requestId,
                Models.RestrictionCardRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestrictionCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v2/card")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This operation allows setting or updating the usage restrictions of an existing account. .
        /// #### Validation rules.
        /// *	The account exists.
        /// *	Day time restriction cannot be set to restrict the use of a card, under the account, on all days of the week.
        /// *	Either of the usage, daytime or location is either marked for reset or new restriction values provided for the account.
        /// *	In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <returns>Returns the Models.AccountRestrictionResponse response from the API call.</returns>
        public Models.AccountRestrictionResponse AccountRestriction(
                string requestId,
                Models.AccountRestrictionRequest body = null)
            => CoreHelper.RunTask(AccountRestrictionAsync(requestId, body));

        /// <summary>
        /// This operation allows setting or updating the usage restrictions of an existing account. .
        /// #### Validation rules.
        /// *	The account exists.
        /// *	Day time restriction cannot be set to restrict the use of a card, under the account, on all days of the week.
        /// *	Either of the usage, daytime or location is either marked for reset or new restriction values provided for the account.
        /// *	In usage restrictions, the limits per transaction should be less than or equal to Daily, Daily should be less than or equal to Weekly, Weekly should be less than or equal to Monthly. Exception being 0/blank will be skipped, i.e., Daily value should be less than equal to Monthly value if Weekly value is 0/blank.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountRestrictionResponse response from the API call.</returns>
        public async Task<Models.AccountRestrictionResponse> AccountRestrictionAsync(
                string requestId,
                Models.AccountRestrictionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountRestrictionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/Account")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This operation will allow user to get account level limits for the given account. .
        /// It returns the velocity limits if its overridden at the account else the values will be null/empty.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <returns>Returns the Models.SearchAccountLimitResponse response from the API call.</returns>
        public Models.SearchAccountLimitResponse SearchAccountLimit(
                string requestId,
                Models.SearchAccountLimitRequest body = null)
            => CoreHelper.RunTask(SearchAccountLimitAsync(requestId, body));

        /// <summary>
        /// This operation will allow user to get account level limits for the given account. .
        /// It returns the velocity limits if its overridden at the account else the values will be null/empty.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchAccountLimitResponse response from the API call.</returns>
        public async Task<Models.SearchAccountLimitResponse> SearchAccountLimitAsync(
                string requestId,
                Models.SearchAccountLimitRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchAccountLimitResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v1/searchaccountlimit")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API will allows querying card details including the day/time and product restrictions.
        /// #### Supported operations.
        ///   * Search by list of cards or bundle.
        ///   * Include card bundle details (optional).
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <returns>Returns the Models.RestrictionSearchCardResponse response from the API call.</returns>
        public Models.RestrictionSearchCardResponse SearchCardRestriction(
                string requestId,
                Models.RestrictionSearchCardRequest body = null)
            => CoreHelper.RunTask(SearchCardRestrictionAsync(requestId, body));

        /// <summary>
        /// This API will allows querying card details including the day/time and product restrictions.
        /// #### Supported operations.
        ///   * Search by list of cards or bundle.
        ///   * Include card bundle details (optional).
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Summary Bundle Request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestrictionSearchCardResponse response from the API call.</returns>
        public async Task<Models.RestrictionSearchCardResponse> SearchCardRestrictionAsync(
                string requestId,
                Models.RestrictionSearchCardRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestrictionSearchCardResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/card-restrictions/v2/search")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
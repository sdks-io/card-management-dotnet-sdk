// <copyright file="SummaryofbundleResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ShellCardManagementAPIs.Standard;
    using ShellCardManagementAPIs.Standard.Utilities;

    /// <summary>
    /// SummaryofbundleResponse.
    /// </summary>
    public class SummaryofbundleResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryofbundleResponse"/> class.
        /// </summary>
        public SummaryofbundleResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryofbundleResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="countOfCardsNotInBundle">CountOfCardsNotInBundle.</param>
        /// <param name="cardBundles">CardBundles.</param>
        /// <param name="error">Error.</param>
        public SummaryofbundleResponse(
            string requestId = null,
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            int? countOfCardsNotInBundle = null,
            Models.CardBundle cardBundles = null,
            Models.ErrorStatus error = null)
        {
            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.CountOfCardsNotInBundle = countOfCardsNotInBundle;
            this.CardBundles = cardBundles;
            this.Error = error;
        }

        /// <summary>
        /// Request Id of the API call
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// Payer Id of the bundles and cards.
        /// Example: 123456
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number of the bundles and cards.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the bundle.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Count of cards that are not part of the bundle in a given account.
        /// </summary>
        [JsonProperty("CountOfCardsNotInBundle", NullValueHandling = NullValueHandling.Ignore)]
        public int? CountOfCardsNotInBundle { get; set; }

        /// <summary>
        /// Gets or sets CardBundles.
        /// </summary>
        [JsonProperty("CardBundles", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBundle CardBundles { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SummaryofbundleResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SummaryofbundleResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CountOfCardsNotInBundle == null && other.CountOfCardsNotInBundle == null) || (this.CountOfCardsNotInBundle?.Equals(other.CountOfCardsNotInBundle) == true)) &&
                ((this.CardBundles == null && other.CardBundles == null) || (this.CardBundles?.Equals(other.CardBundles) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.CountOfCardsNotInBundle = {(this.CountOfCardsNotInBundle == null ? "null" : this.CountOfCardsNotInBundle.ToString())}");
            toStringOutput.Add($"this.CardBundles = {(this.CardBundles == null ? "null" : this.CardBundles.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
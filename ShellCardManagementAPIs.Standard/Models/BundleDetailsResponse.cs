// <copyright file="BundleDetailsResponse.cs" company="APIMatic">
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
    /// BundleDetailsResponse.
    /// </summary>
    public class BundleDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleDetailsResponse"/> class.
        /// </summary>
        public BundleDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleDetailsResponse"/> class.
        /// </summary>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="externalBundleId">ExternalBundleId.</param>
        /// <param name="description">Description.</param>
        /// <param name="pans">Pans.</param>
        /// <param name="restrictionCurrencyCode">RestrictionCurrencyCode.</param>
        /// <param name="restrictionCurrencySymbol">RestrictionCurrencySymbol.</param>
        /// <param name="restrictions">Restrictions.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public BundleDetailsResponse(
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            string bundleId = null,
            string externalBundleId = null,
            string description = null,
            List<string> pans = null,
            string restrictionCurrencyCode = null,
            string restrictionCurrencySymbol = null,
            Models.BundledRestrictionsList restrictions = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.BundleId = bundleId;
            this.ExternalBundleId = externalBundleId;
            this.Description = description;
            this.Pans = pans;
            this.RestrictionCurrencyCode = restrictionCurrencyCode;
            this.RestrictionCurrencySymbol = restrictionCurrencySymbol;
            this.Restrictions = restrictions;
            this.Error = error;
            this.RequestId = requestId;
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
        /// Account ID of the bundle.
        /// Example: 123456
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
        /// unique identifier for the Card Bundle
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// External system allocated Card Bundle identifier for Card Bundle.
        /// </summary>
        [JsonProperty("ExternalBundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalBundleId { get; set; }

        /// <summary>
        /// Card Bundle Description.
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// List of Card Pans added to the card bundle.
        /// </summary>
        [JsonProperty("Pans", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Pans { get; set; }

        /// <summary>
        /// ISO currency code of the country.
        /// Example: GBP
        /// </summary>
        [JsonProperty("RestrictionCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrictionCurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol of the country.
        /// Example: £, $
        /// </summary>
        [JsonProperty("RestrictionCurrencySymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrictionCurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets Restrictions.
        /// </summary>
        [JsonProperty("Restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BundledRestrictionsList Restrictions { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request Id
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BundleDetailsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is BundleDetailsResponse other &&                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.ExternalBundleId == null && other.ExternalBundleId == null) || (this.ExternalBundleId?.Equals(other.ExternalBundleId) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Pans == null && other.Pans == null) || (this.Pans?.Equals(other.Pans) == true)) &&
                ((this.RestrictionCurrencyCode == null && other.RestrictionCurrencyCode == null) || (this.RestrictionCurrencyCode?.Equals(other.RestrictionCurrencyCode) == true)) &&
                ((this.RestrictionCurrencySymbol == null && other.RestrictionCurrencySymbol == null) || (this.RestrictionCurrencySymbol?.Equals(other.RestrictionCurrencySymbol) == true)) &&
                ((this.Restrictions == null && other.Restrictions == null) || (this.Restrictions?.Equals(other.Restrictions) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.ExternalBundleId = {(this.ExternalBundleId == null ? "null" : this.ExternalBundleId)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Pans = {(this.Pans == null ? "null" : $"[{string.Join(", ", this.Pans)} ]")}");
            toStringOutput.Add($"this.RestrictionCurrencyCode = {(this.RestrictionCurrencyCode == null ? "null" : this.RestrictionCurrencyCode)}");
            toStringOutput.Add($"this.RestrictionCurrencySymbol = {(this.RestrictionCurrencySymbol == null ? "null" : this.RestrictionCurrencySymbol)}");
            toStringOutput.Add($"this.Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}
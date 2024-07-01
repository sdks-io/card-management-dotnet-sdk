// <copyright file="DeleteBundleRequest.cs" company="APIMatic">
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
    /// DeleteBundleRequest.
    /// </summary>
    public class DeleteBundleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBundleRequest"/> class.
        /// </summary>
        public DeleteBundleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBundleRequest"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        public DeleteBundleRequest(
            string bundleId,
            int? colCoCode = null,
            int? colCoId = null,
            string payerNumber = null,
            int? payerId = null,
            int? accountId = null,
            string accountNumber = null)
        {
            this.ColCoCode = colCoCode;
            this.ColCoId = colCoId;
            this.PayerNumber = payerNumber;
            this.PayerId = payerId;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.BundleId = bundleId;
        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Either PayerId or PayerNumber or both must be passed.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Payer Id of the selected payer.
        /// Either PayerId or PayerNumber or both must be passed.
        /// Example: 123456
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Account ID of the customer.
        /// Either AccountId or AccountNumber or both must be passed.
        /// Example: 123456
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the customer.
        /// Either AccountId or AccountNumber or both must be passed.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Identifier of the card bundle in Gateway.
        /// Mandatory
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeleteBundleRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeleteBundleRequest other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
        }
    }
}
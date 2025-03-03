// <copyright file="SearchAccountLimitResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellCardManagementAPIs.Standard.Models
{
    /// <summary>
    /// SearchAccountLimitResponse.
    /// </summary>
    public class SearchAccountLimitResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAccountLimitResponse"/> class.
        /// </summary>
        public SearchAccountLimitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAccountLimitResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="referenceProduct">ReferenceProduct.</param>
        /// <param name="restrictionCondition">RestrictionCondition.</param>
        /// <param name="velocityLimits">VelocityLimits.</param>
        /// <param name="error">Error.</param>
        public SearchAccountLimitResponse(
            string requestId = null,
            int? accountId = null,
            string accountNumber = null,
            string referenceProduct = null,
            string restrictionCondition = null,
            List<Models.AccountVelocityLimit> velocityLimits = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.ReferenceProduct = referenceProduct;
            this.RestrictionCondition = restrictionCondition;
            this.VelocityLimits = velocityLimits;
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
        /// Account ID of the customer.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number
        /// Example: GB99215176
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 3 digit Shell global fuel product code, if already set up.
        /// Example: 021
        /// </summary>
        [JsonProperty("ReferenceProduct", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceProduct { get; set; }

        /// <summary>
        /// The restriction condition code.
        /// Example: DECLINE_ALERT
        /// </summary>
        [JsonProperty("RestrictionCondition", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrictionCondition { get; set; }

        /// <summary>
        /// Gets or sets VelocityLimits.
        /// </summary>
        [JsonProperty("VelocityLimits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountVelocityLimit> VelocityLimits { get; set; }

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
            return $"SearchAccountLimitResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchAccountLimitResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.ReferenceProduct == null && other.ReferenceProduct == null ||
                 this.ReferenceProduct?.Equals(other.ReferenceProduct) == true) &&
                (this.RestrictionCondition == null && other.RestrictionCondition == null ||
                 this.RestrictionCondition?.Equals(other.RestrictionCondition) == true) &&
                (this.VelocityLimits == null && other.VelocityLimits == null ||
                 this.VelocityLimits?.Equals(other.VelocityLimits) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"ReferenceProduct = {this.ReferenceProduct ?? "null"}");
            toStringOutput.Add($"RestrictionCondition = {this.RestrictionCondition ?? "null"}");
            toStringOutput.Add($"VelocityLimits = {(this.VelocityLimits == null ? "null" : $"[{string.Join(", ", this.VelocityLimits)} ]")}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
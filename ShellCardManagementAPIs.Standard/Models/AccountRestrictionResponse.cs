// <copyright file="AccountRestrictionResponse.cs" company="APIMatic">
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
    /// AccountRestrictionResponse.
    /// </summary>
    public class AccountRestrictionResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRestrictionResponse"/> class.
        /// </summary>
        public AccountRestrictionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRestrictionResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="usageRestrictionStatus">UsageRestrictionStatus.</param>
        /// <param name="usageRestrictionDescription">UsageRestrictionDescription.</param>
        /// <param name="error">Error.</param>
        public AccountRestrictionResponse(
            string requestId = null,
            int? accountId = null,
            string accountNumber = null,
            string usageRestrictionStatus = null,
            string usageRestrictionDescription = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.UsageRestrictionStatus = usageRestrictionStatus;
            this.UsageRestrictionDescription = usageRestrictionDescription;
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
        /// Account Id on which restriction is applied.
        /// Example: 123456
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number on which restriction is applied.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Status of the card usage restriction submitted to Gateway. Based on the response from Gateway value will be set as either “Success” or “Failed”.
        /// </summary>
        [JsonProperty("UsageRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRestrictionStatus { get; set; }

        /// <summary>
        /// Response for the usage restriction in case of an error. This field will have a value only when “UsageRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("UsageRestrictionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRestrictionDescription { get; set; }

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
            return $"AccountRestrictionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccountRestrictionResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.UsageRestrictionStatus == null && other.UsageRestrictionStatus == null ||
                 this.UsageRestrictionStatus?.Equals(other.UsageRestrictionStatus) == true) &&
                (this.UsageRestrictionDescription == null && other.UsageRestrictionDescription == null ||
                 this.UsageRestrictionDescription?.Equals(other.UsageRestrictionDescription) == true) &&
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
            toStringOutput.Add($"UsageRestrictionStatus = {this.UsageRestrictionStatus ?? "null"}");
            toStringOutput.Add($"UsageRestrictionDescription = {this.UsageRestrictionDescription ?? "null"}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
// <copyright file="FleetmanagementV1UserLoggedinuserRequest.cs" company="APIMatic">
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
    /// FleetmanagementV1UserLoggedinuserRequest.
    /// </summary>
    public class FleetmanagementV1UserLoggedinuserRequest
    {
        private string requestedAPIName;
        private int? payerId;
        private string payerNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestedAPIName", false },
            { "PayerId", false },
            { "PayerNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1UserLoggedinuserRequest"/> class.
        /// </summary>
        public FleetmanagementV1UserLoggedinuserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1UserLoggedinuserRequest"/> class.
        /// </summary>
        /// <param name="includePayerGroup">IncludePayerGroup.</param>
        /// <param name="includeEIDDetails">IncludeEIDDetails.</param>
        /// <param name="requestedAPIName">RequestedAPIName.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        public FleetmanagementV1UserLoggedinuserRequest(
            bool? includePayerGroup = false,
            bool? includeEIDDetails = false,
            string requestedAPIName = null,
            int? payerId = null,
            string payerNumber = null)
        {
            this.IncludePayerGroup = includePayerGroup;
            this.IncludeEIDDetails = includeEIDDetails;

            if (requestedAPIName != null)
            {
                this.RequestedAPIName = requestedAPIName;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }
        }

        /// <summary>
        /// True/False. The output will include the payer group information only when true is passed.
        /// </summary>
        [JsonProperty("IncludePayerGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludePayerGroup { get; set; }

        /// <summary>
        /// True/False. The output will include the EID (Electronic Invoice data) information only when true is passed..
        /// </summary>
        [JsonProperty("IncludeEIDDetails", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEIDDetails { get; set; }

        /// <summary>
        /// Name of the API on which user access needs to be validated
        /// Optional.
        /// </summary>
        [JsonProperty("RequestedAPIName")]
        public string RequestedAPIName
        {
            get
            {
                return this.requestedAPIName;
            }

            set
            {
                this.shouldSerialize["RequestedAPIName"] = true;
                this.requestedAPIName = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Payer id of the customer.</br>
        /// Optional.</br>
        /// This input is a search criterion.</br>
        /// Note: If PayerId or PayerNumber is provided in the input, the given payer will be available in the output if the user has access to the given payer.
        /// ]]>
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// PayerNumber of the customer.</br>
        /// Optional</br>
        /// This input is a search criterion.</br>
        /// Note: If Payerid or PayerNumber is provided in the input, the given payer will be available in the output if the user has access to the given payer.
        /// ]]>
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FleetmanagementV1UserLoggedinuserRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestedAPIName()
        {
            this.shouldSerialize["RequestedAPIName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestedAPIName()
        {
            return this.shouldSerialize["RequestedAPIName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FleetmanagementV1UserLoggedinuserRequest other &&
                (this.IncludePayerGroup == null && other.IncludePayerGroup == null ||
                 this.IncludePayerGroup?.Equals(other.IncludePayerGroup) == true) &&
                (this.IncludeEIDDetails == null && other.IncludeEIDDetails == null ||
                 this.IncludeEIDDetails?.Equals(other.IncludeEIDDetails) == true) &&
                (this.RequestedAPIName == null && other.RequestedAPIName == null ||
                 this.RequestedAPIName?.Equals(other.RequestedAPIName) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"IncludePayerGroup = {(this.IncludePayerGroup == null ? "null" : this.IncludePayerGroup.ToString())}");
            toStringOutput.Add($"IncludeEIDDetails = {(this.IncludeEIDDetails == null ? "null" : this.IncludeEIDDetails.ToString())}");
            toStringOutput.Add($"RequestedAPIName = {this.RequestedAPIName ?? "null"}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
        }
    }
}
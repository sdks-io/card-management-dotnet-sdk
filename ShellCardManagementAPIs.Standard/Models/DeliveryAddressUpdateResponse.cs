// <copyright file="DeliveryAddressUpdateResponse.cs" company="APIMatic">
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
    /// DeliveryAddressUpdateResponse.
    /// </summary>
    public class DeliveryAddressUpdateResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdateResponse"/> class.
        /// </summary>
        public DeliveryAddressUpdateResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdateResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="serviceReference">ServiceReference.</param>
        /// <param name="deliveryAddressUpdateReferences">DeliveryAddressUpdateReferences.</param>
        /// <param name="error">Error.</param>
        public DeliveryAddressUpdateResponse(
            string requestId = null,
            int? serviceReference = null,
            Models.DeliveryAddressUpdateReferences2 deliveryAddressUpdateReferences = null,
            Models.ErrorStatus error = null)
        {
            this.RequestId = requestId;
            this.ServiceReference = serviceReference;
            this.DeliveryAddressUpdateReferences = deliveryAddressUpdateReferences;
            this.Error = error;
        }

        /// <summary>
        /// Request ID to which was passed on the API request.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Service reference number for tracking.
        /// </summary>
        [JsonProperty("ServiceReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceReference { get; set; }

        /// <summary>
        /// Gets or sets DeliveryAddressUpdateReferences.
        /// </summary>
        [JsonProperty("DeliveryAddressUpdateReferences", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryAddressUpdateReferences2 DeliveryAddressUpdateReferences { get; set; }

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
            return $"DeliveryAddressUpdateResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeliveryAddressUpdateResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.ServiceReference == null && other.ServiceReference == null ||
                 this.ServiceReference?.Equals(other.ServiceReference) == true) &&
                (this.DeliveryAddressUpdateReferences == null && other.DeliveryAddressUpdateReferences == null ||
                 this.DeliveryAddressUpdateReferences?.Equals(other.DeliveryAddressUpdateReferences) == true) &&
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
            toStringOutput.Add($"ServiceReference = {(this.ServiceReference == null ? "null" : this.ServiceReference.ToString())}");
            toStringOutput.Add($"DeliveryAddressUpdateReferences = {(this.DeliveryAddressUpdateReferences == null ? "null" : this.DeliveryAddressUpdateReferences.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
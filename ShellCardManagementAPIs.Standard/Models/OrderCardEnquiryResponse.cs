// <copyright file="OrderCardEnquiryResponse.cs" company="APIMatic">
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
    /// OrderCardEnquiryResponse.
    /// </summary>
    public class OrderCardEnquiryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiryResponse"/> class.
        /// </summary>
        public OrderCardEnquiryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiryResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        public OrderCardEnquiryResponse(
            string requestId = null,
            string status = null,
            List<Models.OrderCardEnquiry> data = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderCardEnquiry> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderCardEnquiryResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderCardEnquiryResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"this.Status = {this.Status ?? "null"}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}
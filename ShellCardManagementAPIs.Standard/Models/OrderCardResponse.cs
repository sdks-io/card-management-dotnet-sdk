// <copyright file="OrderCardResponse.cs" company="APIMatic">
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
    /// OrderCardResponse.
    /// </summary>
    public class OrderCardResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardResponse"/> class.
        /// </summary>
        public OrderCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="mainReference">MainReference.</param>
        public OrderCardResponse(
            string requestId = null,
            string status = null,
            List<Models.CreateCardResponse> data = null,
            int? mainReference = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
            this.MainReference = mainReference;
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCESS, FAILED
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateCardResponse> Data { get; set; }

        /// <summary>
        /// Main order reference number for tracking.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderCardResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderCardResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true) &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true);
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
            toStringOutput.Add($"this.MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
        }
    }
}
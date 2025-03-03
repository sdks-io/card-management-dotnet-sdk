// <copyright file="CancelCardResponse.cs" company="APIMatic">
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
    /// CancelCardResponse.
    /// </summary>
    public class CancelCardResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCardResponse"/> class.
        /// </summary>
        public CancelCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCardResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="orderReplacementReference">OrderReplacementReference.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="errors">Errors.</param>
        public CancelCardResponse(
            string requestId = null,
            int? mainReference = null,
            int? orderReplacementReference = null,
            string status = null,
            List<Models.SubmittedCard> data = null,
            List<Models.ErrorDetails> errors = null)
        {
            this.RequestId = requestId;
            this.MainReference = mainReference;
            this.OrderReplacementReference = orderReplacementReference;
            this.Status = status;
            this.Data = data;
            this.Errors = errors;
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Cancel card reference number for tracking the execution of the request.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Order replacement reference number for tracking the execution of the order replacement cards request.
        /// </summary>
        [JsonProperty("OrderReplacementReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderReplacementReference { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCESS, FAILED, PARTIAL_SUCCESS
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubmittedCard> Data { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("Errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ErrorDetails> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CancelCardResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancelCardResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true) &&
                (this.OrderReplacementReference == null && other.OrderReplacementReference == null ||
                 this.OrderReplacementReference?.Equals(other.OrderReplacementReference) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true) &&
                (this.Errors == null && other.Errors == null ||
                 this.Errors?.Equals(other.Errors) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"OrderReplacementReference = {(this.OrderReplacementReference == null ? "null" : this.OrderReplacementReference.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}
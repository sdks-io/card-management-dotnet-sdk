// <copyright file="PINReminderResponse.cs" company="APIMatic">
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
    /// PINReminderResponse.
    /// </summary>
    public class PINReminderResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderResponse"/> class.
        /// </summary>
        public PINReminderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        public PINReminderResponse(
            string requestId = null,
            int? mainReference = null,
            string status = null,
            List<Models.PINReminderReference> data = null)
        {
            this.RequestId = requestId;
            this.MainReference = mainReference;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Service reference number for tracking.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCESS, FAILED
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PINReminderReference> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PINReminderResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PINReminderResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true) &&
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
            toStringOutput.Add($"this.MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"this.Status = {this.Status ?? "null"}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}
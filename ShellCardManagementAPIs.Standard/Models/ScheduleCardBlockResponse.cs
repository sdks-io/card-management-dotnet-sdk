// <copyright file="ScheduleCardBlockResponse.cs" company="APIMatic">
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
    /// ScheduleCardBlockResponse.
    /// </summary>
    public class ScheduleCardBlockResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockResponse"/> class.
        /// </summary>
        public ScheduleCardBlockResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockResponse"/> class.
        /// </summary>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        public ScheduleCardBlockResponse(
            int? mainReference = null,
            string requestId = null,
            string status = null,
            List<Models.ScheduleCardBlockResponseDataItems> data = null)
        {
            this.MainReference = mainReference;
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Reference number for tracking the execution of the request.
        /// Note: Reference will be empty for status 9006 and 9012 i.e., request for all the cards failed.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// API Request ID
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Overall Status of the API call
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// List of SubmittedScheduleCardBlockCard entity.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ScheduleCardBlockResponseDataItems> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduleCardBlockResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduleCardBlockResponse other &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true) &&
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
            toStringOutput.Add($"this.MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"this.RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"this.Status = {this.Status ?? "null"}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}
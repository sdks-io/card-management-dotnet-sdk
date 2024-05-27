// <copyright file="UpdateCardStatusResponse.cs" company="APIMatic">
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
    /// UpdateCardStatusResponse.
    /// </summary>
    public class UpdateCardStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardStatusResponse"/> class.
        /// </summary>
        public UpdateCardStatusResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardStatusResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="orderReplacementReference">OrderReplacementReference.</param>
        /// <param name="errors">Errors.</param>
        public UpdateCardStatusResponse(
            string requestId = null,
            string status = null,
            List<Models.SubmittedCard> data = null,
            int? mainReference = null,
            int? orderReplacementReference = null,
            List<Models.ErrorDetails> errors = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
            this.MainReference = mainReference;
            this.OrderReplacementReference = orderReplacementReference;
            this.Errors = errors;
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

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
        /// <![CDATA[
        /// Update status reference number for tracking the execution of the request. <br>Note: Reference will be empty for status 9006 and 9012 i.e., request for all the cards failed.
        /// ]]>
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Order replacement reference number for tracking the execution of the order replacement cards request. <br/>Note: Reference will be empty for status 9006 and 9012 i.e., request for all the cards failed or if there were no order replacement requested in the input.
        /// </summary>
        [JsonProperty("OrderReplacementReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderReplacementReference { get; set; }

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

            return $"UpdateCardStatusResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateCardStatusResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.MainReference == null && other.MainReference == null) || (this.MainReference?.Equals(other.MainReference) == true)) &&
                ((this.OrderReplacementReference == null && other.OrderReplacementReference == null) || (this.OrderReplacementReference?.Equals(other.OrderReplacementReference) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"this.OrderReplacementReference = {(this.OrderReplacementReference == null ? "null" : this.OrderReplacementReference.ToString())}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}
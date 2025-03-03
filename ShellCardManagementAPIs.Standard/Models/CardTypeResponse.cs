// <copyright file="CardTypeResponse.cs" company="APIMatic">
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
    /// CardTypeResponse.
    /// </summary>
    public class CardTypeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeResponse"/> class.
        /// </summary>
        public CardTypeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeResponse"/> class.
        /// </summary>
        /// <param name="customerCardTypes">CustomerCardTypes.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public CardTypeResponse(
            List<Models.CardTypeResponseCustomerCardTypesItems> customerCardTypes = null,
            Models.CardTypeResponseError error = null,
            string requestId = null)
        {
            this.CustomerCardTypes = customerCardTypes;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets CustomerCardTypes.
        /// </summary>
        [JsonProperty("CustomerCardTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardTypeResponseCustomerCardTypesItems> CustomerCardTypes { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardTypeResponseError Error { get; set; }

        /// <summary>
        /// API Request Id
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardTypeResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardTypeResponse other &&
                (this.CustomerCardTypes == null && other.CustomerCardTypes == null ||
                 this.CustomerCardTypes?.Equals(other.CustomerCardTypes) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true) &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerCardTypes = {(this.CustomerCardTypes == null ? "null" : $"[{string.Join(", ", this.CustomerCardTypes)} ]")}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
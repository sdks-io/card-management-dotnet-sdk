// <copyright file="CardRestrictionResponse.cs" company="APIMatic">
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
    /// CardRestrictionResponse.
    /// </summary>
    public class CardRestrictionResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardRestrictionResponse"/> class.
        /// </summary>
        public CardRestrictionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardRestrictionResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="restrictionRequestReference">RestrictionRequestReference.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="error">Error.</param>
        public CardRestrictionResponse(
            string requestId = null,
            double? restrictionRequestReference = null,
            List<Models.RestrictioncardsRes> cards = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.RestrictionRequestReference = restrictionRequestReference;
            this.Cards = cards;
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
        /// Reference number for tracking the execution of the card restriction requests.
        /// </summary>
        [JsonProperty("RestrictionRequestReference", NullValueHandling = NullValueHandling.Ignore)]
        public double? RestrictionRequestReference { get; set; }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RestrictioncardsRes> Cards { get; set; }

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
            return $"CardRestrictionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is CardRestrictionResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.RestrictionRequestReference == null && other.RestrictionRequestReference == null ||
                 this.RestrictionRequestReference?.Equals(other.RestrictionRequestReference) == true) &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
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
            toStringOutput.Add($"RestrictionRequestReference = {(this.RestrictionRequestReference == null ? "null" : this.RestrictionRequestReference.ToString())}");
            toStringOutput.Add($"Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
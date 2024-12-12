// <copyright file="CardMoveResponse.cs" company="APIMatic">
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
    /// CardMoveResponse.
    /// </summary>
    public class CardMoveResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveResponse"/> class.
        /// </summary>
        public CardMoveResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveResponse"/> class.
        /// </summary>
        /// <param name="moveCardRequestReference">MoveCardRequestReference.</param>
        /// <param name="successfulRequests">SuccessfulRequests.</param>
        /// <param name="errorCards">ErrorCards.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="error">Error.</param>
        public CardMoveResponse(
            int? moveCardRequestReference = null,
            List<Models.CardMoveResponseSuccessfulRequestsItems> successfulRequests = null,
            List<Models.CardMoveResponseErrorCardsItems> errorCards = null,
            string requestId = null,
            Models.ErrorStatus error = null)
        {
            this.MoveCardRequestReference = moveCardRequestReference;
            this.SuccessfulRequests = successfulRequests;
            this.ErrorCards = errorCards;
            this.RequestId = requestId;
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets MoveCardRequestReference.
        /// </summary>
        [JsonProperty("MoveCardRequestReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MoveCardRequestReference { get; set; }

        /// <summary>
        /// Gets or sets SuccessfulRequests.
        /// </summary>
        [JsonProperty("SuccessfulRequests", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardMoveResponseSuccessfulRequestsItems> SuccessfulRequests { get; set; }

        /// <summary>
        /// Gets or sets ErrorCards.
        /// </summary>
        [JsonProperty("ErrorCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardMoveResponseErrorCardsItems> ErrorCards { get; set; }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

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
            return $"CardMoveResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardMoveResponse other &&
                (this.MoveCardRequestReference == null && other.MoveCardRequestReference == null ||
                 this.MoveCardRequestReference?.Equals(other.MoveCardRequestReference) == true) &&
                (this.SuccessfulRequests == null && other.SuccessfulRequests == null ||
                 this.SuccessfulRequests?.Equals(other.SuccessfulRequests) == true) &&
                (this.ErrorCards == null && other.ErrorCards == null ||
                 this.ErrorCards?.Equals(other.ErrorCards) == true) &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MoveCardRequestReference = {(this.MoveCardRequestReference == null ? "null" : this.MoveCardRequestReference.ToString())}");
            toStringOutput.Add($"this.SuccessfulRequests = {(this.SuccessfulRequests == null ? "null" : $"[{string.Join(", ", this.SuccessfulRequests)} ]")}");
            toStringOutput.Add($"this.ErrorCards = {(this.ErrorCards == null ? "null" : $"[{string.Join(", ", this.ErrorCards)} ]")}");
            toStringOutput.Add($"this.RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
// <copyright file="CreateCardGroupResponseErrorCardsItems.cs" company="APIMatic">
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
    /// CreateCardGroupResponseErrorCardsItems.
    /// </summary>
    public class CreateCardGroupResponseErrorCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponseErrorCardsItems"/> class.
        /// </summary>
        public CreateCardGroupResponseErrorCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponseErrorCardsItems"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="errorCode">ErrorCode.</param>
        /// <param name="errorDescription">ErrorDescription.</param>
        public CreateCardGroupResponseErrorCardsItems(
            int? cardId = null,
            string pAN = null,
            string errorCode = null,
            string errorDescription = null)
        {
            this.CardId = cardId;
            this.PAN = pAN;
            this.ErrorCode = errorCode;
            this.ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Card Id of the card.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// PAN of the card.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Error code for validation failure.
        /// </summary>
        [JsonProperty("ErrorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Description of validation failure.
        /// </summary>
        [JsonProperty("ErrorDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCardGroupResponseErrorCardsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCardGroupResponseErrorCardsItems other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.ErrorCode == null && other.ErrorCode == null ||
                 this.ErrorCode?.Equals(other.ErrorCode) == true) &&
                (this.ErrorDescription == null && other.ErrorDescription == null ||
                 this.ErrorDescription?.Equals(other.ErrorDescription) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"this.ErrorCode = {this.ErrorCode ?? "null"}");
            toStringOutput.Add($"this.ErrorDescription = {this.ErrorDescription ?? "null"}");
        }
    }
}
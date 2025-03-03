// <copyright file="CreateCardGroupResponse.cs" company="APIMatic">
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
    /// CreateCardGroupResponse.
    /// </summary>
    public class CreateCardGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponse"/> class.
        /// </summary>
        public CreateCardGroupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponse"/> class.
        /// </summary>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="newCardGroupReference">NewCardGroupReference.</param>
        /// <param name="successfulRequests">SuccessfulRequests.</param>
        /// <param name="errorCards">ErrorCards.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public CreateCardGroupResponse(
            int? mainReference = null,
            int? newCardGroupReference = null,
            List<Models.CreateCardGroupResponseSuccessfulRequestsItems> successfulRequests = null,
            List<Models.CreateCardGroupResponseErrorCardsItems> errorCards = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.MainReference = mainReference;
            this.NewCardGroupReference = newCardGroupReference;
            this.SuccessfulRequests = successfulRequests;
            this.ErrorCards = errorCards;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Reference number for tracking the execution of the requests – new Card Group creation and to move the cards to the new card group.
        /// Reference number will be null when the validations of new card group parameters fail.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Reference number for tracking the execution of card group creation.
        /// Reference number will be null when the validations of new card group parameters fail.
        /// </summary>
        [JsonProperty("NewCardGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCardGroupReference { get; set; }

        /// <summary>
        /// List of cards validated and submitted successfully for processing.
        /// </summary>
        [JsonProperty("SuccessfulRequests", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateCardGroupResponseSuccessfulRequestsItems> SuccessfulRequests { get; set; }

        /// <summary>
        /// List of cards that failed validation and not submitted for processing.
        /// Entity: FailedCardReference
        /// This list will be empty when the validations of new card group parameters fail.
        /// </summary>
        [JsonProperty("ErrorCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateCardGroupResponseErrorCardsItems> ErrorCards { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

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
            return $"CreateCardGroupResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCardGroupResponse other &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true) &&
                (this.NewCardGroupReference == null && other.NewCardGroupReference == null ||
                 this.NewCardGroupReference?.Equals(other.NewCardGroupReference) == true) &&
                (this.SuccessfulRequests == null && other.SuccessfulRequests == null ||
                 this.SuccessfulRequests?.Equals(other.SuccessfulRequests) == true) &&
                (this.ErrorCards == null && other.ErrorCards == null ||
                 this.ErrorCards?.Equals(other.ErrorCards) == true) &&
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
            toStringOutput.Add($"MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"NewCardGroupReference = {(this.NewCardGroupReference == null ? "null" : this.NewCardGroupReference.ToString())}");
            toStringOutput.Add($"SuccessfulRequests = {(this.SuccessfulRequests == null ? "null" : $"[{string.Join(", ", this.SuccessfulRequests)} ]")}");
            toStringOutput.Add($"ErrorCards = {(this.ErrorCards == null ? "null" : $"[{string.Join(", ", this.ErrorCards)} ]")}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
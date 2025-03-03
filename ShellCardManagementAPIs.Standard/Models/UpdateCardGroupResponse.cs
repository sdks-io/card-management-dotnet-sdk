// <copyright file="UpdateCardGroupResponse.cs" company="APIMatic">
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
    /// UpdateCardGroupResponse.
    /// </summary>
    public class UpdateCardGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupResponse"/> class.
        /// </summary>
        public UpdateCardGroupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupResponse"/> class.
        /// </summary>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="updateCardGroupReference">UpdateCardGroupReference.</param>
        /// <param name="newCardGroupReference">NewCardGroupReference.</param>
        /// <param name="moveCardReferences">MoveCardReferences.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public UpdateCardGroupResponse(
            int? mainReference = null,
            int? updateCardGroupReference = null,
            int? newCardGroupReference = null,
            List<Models.UpdateCardGroupResponseMoveCardReferencesItems> moveCardReferences = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.MainReference = mainReference;
            this.UpdateCardGroupReference = updateCardGroupReference;
            this.NewCardGroupReference = newCardGroupReference;
            this.MoveCardReferences = moveCardReferences;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Reference number for tracking the overall request.
        /// The value will be null when the validation fails.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Reference number for tracking the execution of terminate card-group request.
        /// Reference number will be null when the validations fail or TerminateCardGroup in the request object is false.
        /// </summary>
        [JsonProperty("UpdateCardGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateCardGroupReference { get; set; }

        /// <summary>
        /// Reference number for tracking the execution of new card group creation in the case when the cards in the terminating card-group have to be moved to a new card-group.
        /// Reference number will be null when the validations fail or new card-group creation is not requested.
        /// </summary>
        [JsonProperty("NewCardGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCardGroupReference { get; set; }

        /// <summary>
        /// List of cards submitted successfully for processing the move to the target card-group or to change card-group to null.
        /// This list will be empty when the validations fail or there are no cards in the card-group that is getting terminated or MoveCards in the request object is false
        /// </summary>
        [JsonProperty("MoveCardReferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateCardGroupResponseMoveCardReferencesItems> MoveCardReferences { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request ID
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardGroupResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardGroupResponse other &&
                (this.MainReference == null && other.MainReference == null ||
                 this.MainReference?.Equals(other.MainReference) == true) &&
                (this.UpdateCardGroupReference == null && other.UpdateCardGroupReference == null ||
                 this.UpdateCardGroupReference?.Equals(other.UpdateCardGroupReference) == true) &&
                (this.NewCardGroupReference == null && other.NewCardGroupReference == null ||
                 this.NewCardGroupReference?.Equals(other.NewCardGroupReference) == true) &&
                (this.MoveCardReferences == null && other.MoveCardReferences == null ||
                 this.MoveCardReferences?.Equals(other.MoveCardReferences) == true) &&
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
            toStringOutput.Add($"UpdateCardGroupReference = {(this.UpdateCardGroupReference == null ? "null" : this.UpdateCardGroupReference.ToString())}");
            toStringOutput.Add($"NewCardGroupReference = {(this.NewCardGroupReference == null ? "null" : this.NewCardGroupReference.ToString())}");
            toStringOutput.Add($"MoveCardReferences = {(this.MoveCardReferences == null ? "null" : $"[{string.Join(", ", this.MoveCardReferences)} ]")}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
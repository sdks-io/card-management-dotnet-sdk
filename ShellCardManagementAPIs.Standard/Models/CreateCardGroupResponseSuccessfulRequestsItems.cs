// <copyright file="CreateCardGroupResponseSuccessfulRequestsItems.cs" company="APIMatic">
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
    /// CreateCardGroupResponseSuccessfulRequestsItems.
    /// </summary>
    public class CreateCardGroupResponseSuccessfulRequestsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponseSuccessfulRequestsItems"/> class.
        /// </summary>
        public CreateCardGroupResponseSuccessfulRequestsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardGroupResponseSuccessfulRequestsItems"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="reference">Reference.</param>
        public CreateCardGroupResponseSuccessfulRequestsItems(
            int? cardId = null,
            string pAN = null,
            int? reference = null)
        {
            this.CardId = cardId;
            this.PAN = pAN;
            this.Reference = reference;
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
        /// Reference number for tracking of update status request of the specific card,
        /// </summary>
        [JsonProperty("Reference", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCardGroupResponseSuccessfulRequestsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateCardGroupResponseSuccessfulRequestsItems other &&                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference.ToString())}");
        }
    }
}
// <copyright file="UpdateCardGroupResponseMoveCardReferencesItems.cs" company="APIMatic">
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
    /// UpdateCardGroupResponseMoveCardReferencesItems.
    /// </summary>
    public class UpdateCardGroupResponseMoveCardReferencesItems
    {
        private int? cardId;
        private string pAN;
        private int? reference;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardId", false },
            { "PAN", false },
            { "Reference", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupResponseMoveCardReferencesItems"/> class.
        /// </summary>
        public UpdateCardGroupResponseMoveCardReferencesItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupResponseMoveCardReferencesItems"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="reference">Reference.</param>
        public UpdateCardGroupResponseMoveCardReferencesItems(
            int? cardId = null,
            string pAN = null,
            int? reference = null)
        {

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (reference != null)
            {
                this.Reference = reference;
            }
        }

        /// <summary>
        /// Card Id of the card.
        /// Example: 123
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// PAN of the card.
        /// Example: 7002051123456789145
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
            }
        }

        /// <summary>
        /// Reference number for tracking of update status request of the specific card.
        /// </summary>
        [JsonProperty("Reference")]
        public int? Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
                this.shouldSerialize["Reference"] = true;
                this.reference = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardGroupResponseMoveCardReferencesItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReference()
        {
            this.shouldSerialize["Reference"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReference()
        {
            return this.shouldSerialize["Reference"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardGroupResponseMoveCardReferencesItems other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.Reference == null && other.Reference == null ||
                 this.Reference?.Equals(other.Reference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"Reference = {(this.Reference == null ? "null" : this.Reference.ToString())}");
        }
    }
}
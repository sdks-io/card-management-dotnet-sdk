// <copyright file="PINReminderReference.cs" company="APIMatic">
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
    /// PINReminderReference.
    /// </summary>
    public class PINReminderReference
    {
        private int? cardId;
        private int? pANID;
        private int? pAN;
        private string cardExpiryDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardId", false },
            { "PANID", false },
            { "PAN", false },
            { "CardExpiryDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderReference"/> class.
        /// </summary>
        public PINReminderReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderReference"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pANID">PANID.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="referenceId">ReferenceId.</param>
        public PINReminderReference(
            int? cardId = null,
            int? pANID = null,
            int? pAN = null,
            string cardExpiryDate = null,
            int? referenceId = null)
        {

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pANID != null)
            {
                this.PANID = pANID;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (cardExpiryDate != null)
            {
                this.CardExpiryDate = cardExpiryDate;
            }
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// Card Id
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
        /// PAN ID
        /// </summary>
        [JsonProperty("PANID")]
        public int? PANID
        {
            get
            {
                return this.pANID;
            }

            set
            {
                this.shouldSerialize["PANID"] = true;
                this.pANID = value;
            }
        }

        /// <summary>
        /// PAN
        /// </summary>
        [JsonProperty("PAN")]
        public int? PAN
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
        /// Expiry date of the card.
        /// Mandatory if Either PAN or PANID is passed, else optional.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CardExpiryDate")]
        public string CardExpiryDate
        {
            get
            {
                return this.cardExpiryDate;
            }

            set
            {
                this.shouldSerialize["CardExpiryDate"] = true;
                this.cardExpiryDate = value;
            }
        }

        /// <summary>
        /// Individual card pin reminder reference number for the Pin Reminder request.
        /// </summary>
        [JsonProperty("ReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PINReminderReference : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPANID()
        {
            this.shouldSerialize["PANID"] = false;
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
        public void UnsetCardExpiryDate()
        {
            this.shouldSerialize["CardExpiryDate"] = false;
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
        public bool ShouldSerializePANID()
        {
            return this.shouldSerialize["PANID"];
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
        public bool ShouldSerializeCardExpiryDate()
        {
            return this.shouldSerialize["CardExpiryDate"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PINReminderReference other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PANID == null && other.PANID == null ||
                 this.PANID?.Equals(other.PANID) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.CardExpiryDate == null && other.CardExpiryDate == null ||
                 this.CardExpiryDate?.Equals(other.CardExpiryDate) == true) &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
            toStringOutput.Add($"PAN = {(this.PAN == null ? "null" : this.PAN.ToString())}");
            toStringOutput.Add($"CardExpiryDate = {this.CardExpiryDate ?? "null"}");
            toStringOutput.Add($"ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId.ToString())}");
        }
    }
}
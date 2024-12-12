// <copyright file="SearchCard.cs" company="APIMatic">
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
    /// SearchCard.
    /// </summary>
    public class SearchCard
    {
        private int? cardId;
        private string pAN;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardId", false },
            { "PAN", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCard"/> class.
        /// </summary>
        public SearchCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCard"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="pANID">PANID.</param>
        public SearchCard(
            int? cardId = null,
            string pAN = null,
            double? pANID = null)
        {

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }
            this.PANID = pANID;
        }

        /// <summary>
        /// Unique Card Id
        /// Optional if PAN is given, else mandatory.
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
        /// Card PAN.
        /// Optional if CardId is given, else mandatory.
        /// Note: PAN is ignored if CardId is given.
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
        /// Card PANID
        ///  optional id cardid given, else mandatory
        /// Note: PANID is ignored if CardId is given.
        /// </summary>
        [JsonProperty("PANID", NullValueHandling = NullValueHandling.Ignore)]
        public double? PANID { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SearchCard : ({string.Join(", ", toStringOutput)})";
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchCard other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.PANID == null && other.PANID == null ||
                 this.PANID?.Equals(other.PANID) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"this.PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
        }
    }
}
// <copyright file="SearchCardRestriction.cs" company="APIMatic">
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
    /// SearchCardRestriction.
    /// </summary>
    public class SearchCardRestriction
    {
        private int? cardId;
        private string pAN;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardId", false },
            { "PAN", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestriction"/> class.
        /// </summary>
        public SearchCardRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestriction"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        public SearchCardRestriction(
            int? cardId = null,
            string pAN = null)
        {
            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

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
        /// Example: 7002051006629890645
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchCardRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SearchCardRestriction other &&                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
        }
    }
}
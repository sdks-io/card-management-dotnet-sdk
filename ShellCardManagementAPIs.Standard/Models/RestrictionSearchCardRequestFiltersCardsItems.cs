// <copyright file="RestrictionSearchCardRequestFiltersCardsItems.cs" company="APIMatic">
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
    /// RestrictionSearchCardRequestFiltersCardsItems.
    /// </summary>
    public class RestrictionSearchCardRequestFiltersCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardRequestFiltersCardsItems"/> class.
        /// </summary>
        public RestrictionSearchCardRequestFiltersCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardRequestFiltersCardsItems"/> class.
        /// </summary>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        public RestrictionSearchCardRequestFiltersCardsItems(
            string pAN = null,
            int? cardId = null)
        {
            this.PAN = pAN;
            this.CardId = cardId;
        }

        /// <summary>
        /// Card PAN.
        /// Optional if CardId is given, else mandatory.
        /// Note: PAN is ignored if CardId is given.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Unique Card Id in GFN.
        /// Optional if PAN is given, else mandatory.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictionSearchCardRequestFiltersCardsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is RestrictionSearchCardRequestFiltersCardsItems other &&                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
        }
    }
}
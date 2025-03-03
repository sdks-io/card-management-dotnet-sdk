// <copyright file="SearchCardRestrictionRes.cs" company="APIMatic">
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
    /// SearchCardRestrictionRes.
    /// </summary>
    public class SearchCardRestrictionRes
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestrictionRes"/> class.
        /// </summary>
        public SearchCardRestrictionRes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestrictionRes"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="cards">cards.</param>
        /// <param name="restrictions">Restrictions.</param>
        /// <param name="error">Error.</param>
        public SearchCardRestrictionRes(
            string requestId = null,
            List<Models.RestrictionCardList> cards = null,
            Models.Restriction restrictions = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.Cards = cards;
            this.Restrictions = restrictions;
            this.Error = error;
        }

        /// <summary>
        /// Request Id of the API call
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RestrictionCardList> Cards { get; set; }

        /// <summary>
        /// Gets or sets Restrictions.
        /// </summary>
        [JsonProperty("Restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Restriction Restrictions { get; set; }

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
            return $"SearchCardRestrictionRes : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchCardRestrictionRes other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
                (this.Restrictions == null && other.Restrictions == null ||
                 this.Restrictions?.Equals(other.Restrictions) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
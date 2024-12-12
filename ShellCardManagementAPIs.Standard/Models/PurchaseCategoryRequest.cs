// <copyright file="PurchaseCategoryRequest.cs" company="APIMatic">
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
    /// PurchaseCategoryRequest.
    /// </summary>
    public class PurchaseCategoryRequest
    {
        private int? colCoCode;
        private int? colCoId;
        private int? cardTypeId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoCode", false },
            { "ColCoId", false },
            { "CardTypeId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryRequest"/> class.
        /// </summary>
        public PurchaseCategoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryRequest"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="languageCode">LanguageCode.</param>
        public PurchaseCategoryRequest(
            string requestId = null,
            int? colCoCode = null,
            int? colCoId = null,
            int? cardTypeId = null,
            int? purchaseCategoryId = null,
            string languageCode = null)
        {
            this.RequestId = requestId;

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (cardTypeId != null)
            {
                this.CardTypeId = cardTypeId;
            }
            this.PurchaseCategoryId = purchaseCategoryId;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code).
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Collecting Company Id (in Shell Cards Platform).
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// Card type Id
        /// </summary>
        [JsonProperty("CardTypeId")]
        public int? CardTypeId
        {
            get
            {
                return this.cardTypeId;
            }

            set
            {
                this.shouldSerialize["CardTypeId"] = true;
                this.cardTypeId = value;
            }
        }

        /// <summary>
        /// Purchase category Id
        /// Optional.
        /// Example: 123, 124, etc.,
        /// </summary>
        [JsonProperty("PurchaseCategoryId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseCategoryId { get; set; }

        /// <summary>
        /// Language code for the Title and Description.
        /// Language codes should be same as SFH supported language
        /// Optional.
        /// Default: en-GB
        /// Example:
        /// en-GB – English (UK)
        /// nl-NL – Dutch (Netherlands)
        /// </summary>
        [JsonProperty("LanguageCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PurchaseCategoryRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardTypeId()
        {
            this.shouldSerialize["CardTypeId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeId()
        {
            return this.shouldSerialize["CardTypeId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PurchaseCategoryRequest other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.PurchaseCategoryId == null && other.PurchaseCategoryId == null ||
                 this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true) &&
                (this.LanguageCode == null && other.LanguageCode == null ||
                 this.LanguageCode?.Equals(other.LanguageCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.LanguageCode = {this.LanguageCode ?? "null"}");
        }
    }
}
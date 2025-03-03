// <copyright file="CardMoveRequest.cs" company="APIMatic">
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
    /// CardMoveRequest.
    /// </summary>
    public class CardMoveRequest
    {
        private int? colCoCode;
        private int? colCoId;
        private string colCoCountryCode;
        private string payerNumber;
        private int? payerId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoCode", false },
            { "ColCoId", false },
            { "ColCoCountryCode", false },
            { "PayerNumber", false },
            { "PayerId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveRequest"/> class.
        /// </summary>
        public CardMoveRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveRequest"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="targetAccountId">TargetAccountId.</param>
        /// <param name="targetAccountNumber">TargetAccountNumber.</param>
        /// <param name="targetCardGroupId">TargetCardGroupId.</param>
        /// <param name="targetNewCardGroupName">TargetNewCardGroupName.</param>
        public CardMoveRequest(
            int? colCoCode = null,
            int? colCoId = null,
            string colCoCountryCode = null,
            string payerNumber = null,
            int? payerId = null,
            List<Models.CardMoveRequestCardsItems> cards = null,
            int? targetAccountId = null,
            string targetAccountNumber = null,
            int? targetCardGroupId = null,
            string targetNewCardGroupName = null)
        {

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }
            this.Cards = cards;
            this.TargetAccountId = targetAccountId;
            this.TargetAccountNumber = targetAccountNumber;
            this.TargetCardGroupId = targetCardGroupId;
            this.TargetNewCardGroupName = targetNewCardGroupName;
        }

        /// <summary>
        /// Gets or sets ColCoCode.
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
        /// Gets or sets ColCoId.
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
        /// Gets or sets ColCoCountryCode.
        /// </summary>
        [JsonProperty("ColCoCountryCode")]
        public string ColCoCountryCode
        {
            get
            {
                return this.colCoCountryCode;
            }

            set
            {
                this.shouldSerialize["ColCoCountryCode"] = true;
                this.colCoCountryCode = value;
            }
        }

        /// <summary>
        /// Gets or sets PayerNumber.
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets PayerId.
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardMoveRequestCardsItems> Cards { get; set; }

        /// <summary>
        /// Gets or sets TargetAccountId.
        /// </summary>
        [JsonProperty("TargetAccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetAccountId { get; set; }

        /// <summary>
        /// Gets or sets TargetAccountNumber.
        /// </summary>
        [JsonProperty("TargetAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets TargetCardGroupId.
        /// </summary>
        [JsonProperty("TargetCardGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetCardGroupId { get; set; }

        /// <summary>
        /// Gets or sets TargetNewCardGroupName.
        /// </summary>
        [JsonProperty("TargetNewCardGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetNewCardGroupName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardMoveRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
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
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardMoveRequest other &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.ColCoCountryCode == null && other.ColCoCountryCode == null ||
                 this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
                (this.TargetAccountId == null && other.TargetAccountId == null ||
                 this.TargetAccountId?.Equals(other.TargetAccountId) == true) &&
                (this.TargetAccountNumber == null && other.TargetAccountNumber == null ||
                 this.TargetAccountNumber?.Equals(other.TargetAccountNumber) == true) &&
                (this.TargetCardGroupId == null && other.TargetCardGroupId == null ||
                 this.TargetCardGroupId?.Equals(other.TargetCardGroupId) == true) &&
                (this.TargetNewCardGroupName == null && other.TargetNewCardGroupName == null ||
                 this.TargetNewCardGroupName?.Equals(other.TargetNewCardGroupName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"ColCoCountryCode = {this.ColCoCountryCode ?? "null"}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"TargetAccountId = {(this.TargetAccountId == null ? "null" : this.TargetAccountId.ToString())}");
            toStringOutput.Add($"TargetAccountNumber = {this.TargetAccountNumber ?? "null"}");
            toStringOutput.Add($"TargetCardGroupId = {(this.TargetCardGroupId == null ? "null" : this.TargetCardGroupId.ToString())}");
            toStringOutput.Add($"TargetNewCardGroupName = {this.TargetNewCardGroupName ?? "null"}");
        }
    }
}
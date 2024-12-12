// <copyright file="CardMoveRequestCardsItems.cs" company="APIMatic">
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
    /// CardMoveRequestCardsItems.
    /// </summary>
    public class CardMoveRequestCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveRequestCardsItems"/> class.
        /// </summary>
        public CardMoveRequestCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveRequestCardsItems"/> class.
        /// </summary>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        public CardMoveRequestCardsItems(
            string accountNumber = null,
            int? accountId = null,
            string pAN = null,
            int? cardId = null)
        {
            this.AccountNumber = accountNumber;
            this.AccountId = accountId;
            this.PAN = pAN;
            this.CardId = cardId;
        }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Gets or sets PAN.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Gets or sets CardId.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardMoveRequestCardsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardMoveRequestCardsItems other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
        }
    }
}
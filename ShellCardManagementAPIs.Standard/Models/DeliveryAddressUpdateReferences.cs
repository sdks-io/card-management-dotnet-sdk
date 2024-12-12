// <copyright file="DeliveryAddressUpdateReferences.cs" company="APIMatic">
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
    /// DeliveryAddressUpdateReferences.
    /// </summary>
    public class DeliveryAddressUpdateReferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdateReferences"/> class.
        /// </summary>
        public DeliveryAddressUpdateReferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdateReferences"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="referenceId">ReferenceId.</param>
        /// <param name="errorInfo">ErrorInfo.</param>
        public DeliveryAddressUpdateReferences(
            int? cardId = null,
            string cardPAN = null,
            int? accountId = null,
            string accountNumber = null,
            int? referenceId = null,
            string errorInfo = null)
        {
            this.CardId = cardId;
            this.CardPAN = cardPAN;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.ReferenceId = referenceId;
            this.ErrorInfo = errorInfo;
        }

        /// <summary>
        /// CardId
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// PAN of the card.
        /// </summary>
        [JsonProperty("CardPAN", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPAN { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Individual delivery address update reference number for the delivery address update request.
        /// </summary>
        [JsonProperty("ReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Individual error information for the delivery address update request.
        /// </summary>
        [JsonProperty("ErrorInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeliveryAddressUpdateReferences : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeliveryAddressUpdateReferences other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.CardPAN == null && other.CardPAN == null ||
                 this.CardPAN?.Equals(other.CardPAN) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true) &&
                (this.ErrorInfo == null && other.ErrorInfo == null ||
                 this.ErrorInfo?.Equals(other.ErrorInfo) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {this.CardPAN ?? "null"}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"this.ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId.ToString())}");
            toStringOutput.Add($"this.ErrorInfo = {this.ErrorInfo ?? "null"}");
        }
    }
}
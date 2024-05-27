// <copyright file="AutoRenewCardRequestAutoRenewCardsItems.cs" company="APIMatic">
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
    /// AutoRenewCardRequestAutoRenewCardsItems.
    /// </summary>
    public class AutoRenewCardRequestAutoRenewCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardRequestAutoRenewCardsItems"/> class.
        /// </summary>
        public AutoRenewCardRequestAutoRenewCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardRequestAutoRenewCardsItems"/> class.
        /// </summary>
        /// <param name="reissueSetting">ReissueSetting.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        public AutoRenewCardRequestAutoRenewCardsItems(
            bool reissueSetting,
            string accountNumber = null,
            int? accountId = null,
            string pAN = null,
            int? cardId = null)
        {
            this.AccountNumber = accountNumber;
            this.AccountId = accountId;
            this.PAN = pAN;
            this.CardId = cardId;
            this.ReissueSetting = reissueSetting;
        }

        /// <summary>
        /// Account Number of the customer.
        /// Optional if AccountId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account Id of the customer.
        /// Optional if AccountNumber is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// PAN of the card.
        /// Optional if CardId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Card Id of the card.
        /// Optional if PAN is passed, else Mandatory.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// Reissue setting of the card.
        /// Values:
        /// True – Card will be Reissued when nearing its expiry date
        /// False – Card will not be Reissued
        /// Mandatory
        /// </summary>
        [JsonProperty("ReissueSetting")]
        public bool ReissueSetting { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoRenewCardRequestAutoRenewCardsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoRenewCardRequestAutoRenewCardsItems other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                this.ReissueSetting.Equals(other.ReissueSetting);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.ReissueSetting = {this.ReissueSetting}");
        }
    }
}
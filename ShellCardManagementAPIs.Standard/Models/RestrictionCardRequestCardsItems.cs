// <copyright file="RestrictionCardRequestCardsItems.cs" company="APIMatic">
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
    /// RestrictionCardRequestCardsItems.
    /// </summary>
    public class RestrictionCardRequestCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardRequestCardsItems"/> class.
        /// </summary>
        public RestrictionCardRequestCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardRequestCardsItems"/> class.
        /// </summary>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="resetUsageRestrictions">ResetUsageRestrictions.</param>
        /// <param name="resetDayTimeRestrictions">ResetDayTimeRestrictions.</param>
        /// <param name="resetProductRestrictions">ResetProductRestrictions.</param>
        /// <param name="resetLocationRestrictions">ResetLocationRestrictions.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        public RestrictionCardRequestCardsItems(
            string accountNumber = null,
            int? accountId = null,
            string pAN = null,
            int? cardId = null,
            bool? resetUsageRestrictions = null,
            bool? resetDayTimeRestrictions = null,
            bool? resetProductRestrictions = null,
            bool? resetLocationRestrictions = null,
            Models.DayTimeRestrictions dayTimeRestrictions = null,
            Models.LocationRestrictions locationRestrictions = null,
            Models.ProductRestrictions productRestrictions = null,
            Models.UsageRestrictions usageRestrictions = null)
        {
            this.AccountNumber = accountNumber;
            this.AccountId = accountId;
            this.PAN = pAN;
            this.CardId = cardId;
            this.ResetUsageRestrictions = resetUsageRestrictions;
            this.ResetDayTimeRestrictions = resetDayTimeRestrictions;
            this.ResetProductRestrictions = resetProductRestrictions;
            this.ResetLocationRestrictions = resetLocationRestrictions;
            this.DayTimeRestrictions = dayTimeRestrictions;
            this.LocationRestrictions = locationRestrictions;
            this.ProductRestrictions = productRestrictions;
            this.UsageRestrictions = usageRestrictions;
        }

        /// <summary>
        /// Account Number of the customer.
        /// Optional if AccountId is passed, else Mandatory.
        /// This input is a search criterion, if given.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account ID of the customer.
        /// Optional if AccountNumber is passed, else Mandatory.
        /// This input is a search criterion, if given.
        /// Example: 123456
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Card PAN.
        /// Optional if CardId is given, else mandatory.
        /// Example: 7002051006629890645
        /// Note:
        /// •	PAN is ignored if CardId is given.
        /// When PAN matches with multiple cards, the restriction will be applied on the latest issued card.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Unique Card Id
        /// Optional if PAN is given, else mandatory.
        /// Example: 275549
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// True/False.
        /// If true, the usage restrictions applied on the card in Gateway will be reset to Customer Card Type level max limits, if there are no customer level overrides available then OU card type max limits. Else, the card restrictions will be updated with the usage restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetUsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetUsageRestrictions { get; set; }

        /// <summary>
        /// True/False.
        /// If true, the Day/Time restrictions applied on the card will be deleted. Else, the card restrictions will be updated with the day/time restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetDayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetDayTimeRestrictions { get; set; }

        /// <summary>
        /// True/False.
        /// If true, Default fuel/non-fuel sets configured at the purchase category level will be applied to the card. Else, the card will be applied with product restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetProductRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetProductRestrictions { get; set; }

        /// <summary>
        /// True/False.
        /// If true, the location restrictions applied on the card will be deleted. Else, the card restrictions will be updated with the location restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetLocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetLocationRestrictions { get; set; }

        /// <summary>
        /// Day/time restrictions such as weekdays and time range to be applied on the bundle.
        /// Mandatory if respective action is set as “Add”.
        /// The details of DayTimeRestriction entity is given below.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DayTimeRestrictions DayTimeRestrictions { get; set; }

        /// <summary>
        /// Location restrictions to be applied on the bundle which either allows or restricts using the cards, which are under the bundle, in the specified locations.
        /// Mandatory if respective action is set as “Add”.
        /// Details of location restrictions are given below.
        /// </summary>
        [JsonProperty("LocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationRestrictions LocationRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictions.
        /// </summary>
        [JsonProperty("ProductRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProductRestrictions ProductRestrictions { get; set; }

        /// <summary>
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsageRestrictions UsageRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictionCardRequestCardsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is RestrictionCardRequestCardsItems other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.ResetUsageRestrictions == null && other.ResetUsageRestrictions == null) || (this.ResetUsageRestrictions?.Equals(other.ResetUsageRestrictions) == true)) &&
                ((this.ResetDayTimeRestrictions == null && other.ResetDayTimeRestrictions == null) || (this.ResetDayTimeRestrictions?.Equals(other.ResetDayTimeRestrictions) == true)) &&
                ((this.ResetProductRestrictions == null && other.ResetProductRestrictions == null) || (this.ResetProductRestrictions?.Equals(other.ResetProductRestrictions) == true)) &&
                ((this.ResetLocationRestrictions == null && other.ResetLocationRestrictions == null) || (this.ResetLocationRestrictions?.Equals(other.ResetLocationRestrictions) == true)) &&
                ((this.DayTimeRestrictions == null && other.DayTimeRestrictions == null) || (this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true)) &&
                ((this.LocationRestrictions == null && other.LocationRestrictions == null) || (this.LocationRestrictions?.Equals(other.LocationRestrictions) == true)) &&
                ((this.ProductRestrictions == null && other.ProductRestrictions == null) || (this.ProductRestrictions?.Equals(other.ProductRestrictions) == true)) &&
                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true));
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
            toStringOutput.Add($"this.ResetUsageRestrictions = {(this.ResetUsageRestrictions == null ? "null" : this.ResetUsageRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetDayTimeRestrictions = {(this.ResetDayTimeRestrictions == null ? "null" : this.ResetDayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetProductRestrictions = {(this.ResetProductRestrictions == null ? "null" : this.ResetProductRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetLocationRestrictions = {(this.ResetLocationRestrictions == null ? "null" : this.ResetLocationRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
        }
    }
}
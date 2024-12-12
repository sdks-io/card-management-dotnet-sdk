// <copyright file="RestrictionCardsList.cs" company="APIMatic">
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
    /// RestrictionCardsList.
    /// </summary>
    public class RestrictionCardsList
    {
        private int? accountId;
        private int? cardId;
        private string pAN;
        private bool? resetDayTimeRestrictions;
        private bool? resetProductRestrictions;
        private bool? resetLocationRestrictions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "CardId", false },
            { "PAN", false },
            { "ResetDayTimeRestrictions", false },
            { "ResetProductRestrictions", false },
            { "ResetLocationRestrictions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardsList"/> class.
        /// </summary>
        public RestrictionCardsList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardsList"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="resetUsageRestrictions">ResetUsageRestrictions.</param>
        /// <param name="resetDayTimeRestrictions">ResetDayTimeRestrictions.</param>
        /// <param name="resetProductRestrictions">ResetProductRestrictions.</param>
        /// <param name="resetLocationRestrictions">ResetLocationRestrictions.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        public RestrictionCardsList(
            int? accountId = null,
            int? cardId = null,
            string pAN = null,
            bool? resetUsageRestrictions = null,
            bool? resetDayTimeRestrictions = null,
            bool? resetProductRestrictions = null,
            bool? resetLocationRestrictions = null,
            object usageRestrictions = null,
            Models.DayTimeRestrictions dayTimeRestrictions = null,
            object productRestrictions = null,
            Models.LocationRestriction locationRestrictions = null)
        {

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }
            this.ResetUsageRestrictions = resetUsageRestrictions;

            if (resetDayTimeRestrictions != null)
            {
                this.ResetDayTimeRestrictions = resetDayTimeRestrictions;
            }

            if (resetProductRestrictions != null)
            {
                this.ResetProductRestrictions = resetProductRestrictions;
            }

            if (resetLocationRestrictions != null)
            {
                this.ResetLocationRestrictions = resetLocationRestrictions;
            }
            this.UsageRestrictions = usageRestrictions;
            this.DayTimeRestrictions = dayTimeRestrictions;
            this.ProductRestrictions = productRestrictions;
            this.LocationRestrictions = locationRestrictions;
        }

        /// <summary>
        /// Account ID of the customer.
        /// Optional if AccountNumber is passed, else Mandatory.
        /// This input is a search criterion, if given.
        /// Example: 123456
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Unique Card Id
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
        /// Example: 7002051006629890645
        /// Note:
        /// •    PAN is ignored if CardId is given.
        /// When PAN matches with multiple cards, the restriction will be applied on the latest issued card.
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
        /// True/False.
        /// If true, the usage restrictions applied on the card in Gateway will be reset to Customer Card Type level max limits, if there are no customer level overrides available then OU card type max limits. Else, the card restrictions will be updated with the usage restrictions provided in the API.
        /// This property is not dependent on IsVelocityCeiling or SetDefaultOnVelocityUpdate flags.
        /// </summary>
        [JsonProperty("ResetUsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetUsageRestrictions { get; set; }

        /// <summary>
        /// True/False.
        /// If true, the Day/Time restrictions applied on the card will be deleted. Else, the card restrictions will be updated with the day/time restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetDayTimeRestrictions")]
        public bool? ResetDayTimeRestrictions
        {
            get
            {
                return this.resetDayTimeRestrictions;
            }

            set
            {
                this.shouldSerialize["ResetDayTimeRestrictions"] = true;
                this.resetDayTimeRestrictions = value;
            }
        }

        /// <summary>
        /// True/False.
        /// If true, Default fuel/non-fuel sets configured at the purchase category level will be applied to the card. Else, the card will be applied with product restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetProductRestrictions")]
        public bool? ResetProductRestrictions
        {
            get
            {
                return this.resetProductRestrictions;
            }

            set
            {
                this.shouldSerialize["ResetProductRestrictions"] = true;
                this.resetProductRestrictions = value;
            }
        }

        /// <summary>
        /// True/False.
        /// If true, the location restrictions applied on the card will be deleted. Else, the card restrictions will be updated with the location restrictions provided in the API.
        /// </summary>
        [JsonProperty("ResetLocationRestrictions")]
        public bool? ResetLocationRestrictions
        {
            get
            {
                return this.resetLocationRestrictions;
            }

            set
            {
                this.shouldSerialize["ResetLocationRestrictions"] = true;
                this.resetLocationRestrictions = value;
            }
        }

        /// <summary>
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public object UsageRestrictions { get; set; }

        /// <summary>
        /// Gets or sets DayTimeRestrictions.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DayTimeRestrictions DayTimeRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictions.
        /// </summary>
        [JsonProperty("ProductRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public object ProductRestrictions { get; set; }

        /// <summary>
        /// Gets or sets LocationRestrictions.
        /// </summary>
        [JsonProperty("LocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationRestriction LocationRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RestrictionCardsList : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetResetDayTimeRestrictions()
        {
            this.shouldSerialize["ResetDayTimeRestrictions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetResetProductRestrictions()
        {
            this.shouldSerialize["ResetProductRestrictions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetResetLocationRestrictions()
        {
            this.shouldSerialize["ResetLocationRestrictions"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResetDayTimeRestrictions()
        {
            return this.shouldSerialize["ResetDayTimeRestrictions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResetProductRestrictions()
        {
            return this.shouldSerialize["ResetProductRestrictions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResetLocationRestrictions()
        {
            return this.shouldSerialize["ResetLocationRestrictions"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RestrictionCardsList other &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.ResetUsageRestrictions == null && other.ResetUsageRestrictions == null ||
                 this.ResetUsageRestrictions?.Equals(other.ResetUsageRestrictions) == true) &&
                (this.ResetDayTimeRestrictions == null && other.ResetDayTimeRestrictions == null ||
                 this.ResetDayTimeRestrictions?.Equals(other.ResetDayTimeRestrictions) == true) &&
                (this.ResetProductRestrictions == null && other.ResetProductRestrictions == null ||
                 this.ResetProductRestrictions?.Equals(other.ResetProductRestrictions) == true) &&
                (this.ResetLocationRestrictions == null && other.ResetLocationRestrictions == null ||
                 this.ResetLocationRestrictions?.Equals(other.ResetLocationRestrictions) == true) &&
                (this.UsageRestrictions == null && other.UsageRestrictions == null ||
                 this.UsageRestrictions?.Equals(other.UsageRestrictions) == true) &&
                (this.DayTimeRestrictions == null && other.DayTimeRestrictions == null ||
                 this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true) &&
                (this.ProductRestrictions == null && other.ProductRestrictions == null ||
                 this.ProductRestrictions?.Equals(other.ProductRestrictions) == true) &&
                (this.LocationRestrictions == null && other.LocationRestrictions == null ||
                 this.LocationRestrictions?.Equals(other.LocationRestrictions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"this.ResetUsageRestrictions = {(this.ResetUsageRestrictions == null ? "null" : this.ResetUsageRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetDayTimeRestrictions = {(this.ResetDayTimeRestrictions == null ? "null" : this.ResetDayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetProductRestrictions = {(this.ResetProductRestrictions == null ? "null" : this.ResetProductRestrictions.ToString())}");
            toStringOutput.Add($"this.ResetLocationRestrictions = {(this.ResetLocationRestrictions == null ? "null" : this.ResetLocationRestrictions.ToString())}");
            toStringOutput.Add($"UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
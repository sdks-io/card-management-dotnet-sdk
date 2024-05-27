// <copyright file="RestrictionSearchCardRequestFilters.cs" company="APIMatic">
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
    /// RestrictionSearchCardRequestFilters.
    /// </summary>
    public class RestrictionSearchCardRequestFilters
    {
        private string bundleId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "BundleId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardRequestFilters"/> class.
        /// </summary>
        public RestrictionSearchCardRequestFilters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardRequestFilters"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="includeLocationRestrictions">IncludeLocationRestrictions.</param>
        /// <param name="includeInheritedLimits">IncludeInheritedLimits.</param>
        /// <param name="includeBundleDetails">IncludeBundleDetails.</param>
        public RestrictionSearchCardRequestFilters(
            int? colCoCode = null,
            int? colCoId = null,
            string payerNumber = null,
            int? payerId = null,
            Models.Accounts accounts = null,
            string bundleId = null,
            List<Models.RestrictionSearchCardRequestFiltersCardsItems> cards = null,
            bool? includeLocationRestrictions = false,
            bool? includeInheritedLimits = false,
            bool? includeBundleDetails = false)
        {
            this.ColCoCode = colCoCode;
            this.ColCoId = colCoId;
            this.PayerNumber = payerNumber;
            this.PayerId = payerId;
            this.Accounts = accounts;
            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }

            this.Cards = cards;
            this.IncludeLocationRestrictions = includeLocationRestrictions;
            this.IncludeInheritedLimits = includeInheritedLimits;
            this.IncludeBundleDetails = includeBundleDetails;
        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Collecting Company Id (in GFN) of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// Example: 123456
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Accounts Accounts { get; set; }

        /// <summary>
        /// Identifier of the Card bundle in Gateway.
        /// Optional if cards list is given, else mandatory.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId
        {
            get
            {
                return this.bundleId;
            }

            set
            {
                this.shouldSerialize["BundleId"] = true;
                this.bundleId = value;
            }
        }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RestrictionSearchCardRequestFiltersCardsItems> Cards { get; set; }

        /// <summary>
        /// Whether to include location restriction of the cards in the response
        /// </summary>
        [JsonProperty("IncludeLocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeLocationRestrictions { get; set; }

        /// <summary>
        /// When True: service will return the inherited values for the usage limits (from card-program or account as available) when it is not overridden on the card.
        /// </summary>
        [JsonProperty("IncludeInheritedLimits", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeInheritedLimits { get; set; }

        /// <summary>
        /// When the value is True, API will return bundle Id associated with cards in the response, if available.
        /// Note: Use ‘Null’ or ‘False’ for optimum performance. A delay in response is expected when set to ‘True’.
        /// </summary>
        [JsonProperty("IncludeBundleDetails", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeBundleDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictionSearchCardRequestFilters : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
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
            return obj is RestrictionSearchCardRequestFilters other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.IncludeLocationRestrictions == null && other.IncludeLocationRestrictions == null) || (this.IncludeLocationRestrictions?.Equals(other.IncludeLocationRestrictions) == true)) &&
                ((this.IncludeInheritedLimits == null && other.IncludeInheritedLimits == null) || (this.IncludeInheritedLimits?.Equals(other.IncludeInheritedLimits) == true)) &&
                ((this.IncludeBundleDetails == null && other.IncludeBundleDetails == null) || (this.IncludeBundleDetails?.Equals(other.IncludeBundleDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.IncludeLocationRestrictions = {(this.IncludeLocationRestrictions == null ? "null" : this.IncludeLocationRestrictions.ToString())}");
            toStringOutput.Add($"this.IncludeInheritedLimits = {(this.IncludeInheritedLimits == null ? "null" : this.IncludeInheritedLimits.ToString())}");
            toStringOutput.Add($"this.IncludeBundleDetails = {(this.IncludeBundleDetails == null ? "null" : this.IncludeBundleDetails.ToString())}");
        }
    }
}
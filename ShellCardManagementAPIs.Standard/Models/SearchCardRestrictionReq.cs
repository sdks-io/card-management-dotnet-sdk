// <copyright file="SearchCardRestrictionReq.cs" company="APIMatic">
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
    /// SearchCardRestrictionReq.
    /// </summary>
    public class SearchCardRestrictionReq
    {
        private int? colCoId;
        private int? colCoCode;
        private int? payerId;
        private string bundleId;
        private bool? includeLocationRestrictions;
        private bool? includeBundleDetails;
        private bool? includeInheritedLimits;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "PayerId", false },
            { "BundleId", false },
            { "IncludeLocationRestrictions", false },
            { "IncludeBundleDetails", false },
            { "IncludeInheritedLimits", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestrictionReq"/> class.
        /// </summary>
        public SearchCardRestrictionReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRestrictionReq"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="includeLocationRestrictions">IncludeLocationRestrictions.</param>
        /// <param name="includeBundleDetails">IncludeBundleDetails.</param>
        /// <param name="includeInheritedLimits">IncludeInheritedLimits.</param>
        public SearchCardRestrictionReq(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            Models.Accounts accounts = null,
            string bundleId = null,
            Models.SearchCardRestriction cards = null,
            bool? includeLocationRestrictions = null,
            bool? includeBundleDetails = null,
            bool? includeInheritedLimits = null)
        {

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }
            this.PayerNumber = payerNumber;
            this.Accounts = accounts;

            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }
            this.Cards = cards;

            if (includeLocationRestrictions != null)
            {
                this.IncludeLocationRestrictions = includeLocationRestrictions;
            }

            if (includeBundleDetails != null)
            {
                this.IncludeBundleDetails = includeBundleDetails;
            }

            if (includeInheritedLimits != null)
            {
                this.IncludeInheritedLimits = includeInheritedLimits;
            }
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
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
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
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
        /// Payer Id (i.e. Customer Id of the Payment Customer) of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// Example: 123456
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
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Accounts Accounts { get; set; }

        /// <summary>
        /// Identifier of the Card bundle
        /// Optional if cards list is given, else mandatory.
        /// This input is a search criterion, if given.
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
        public Models.SearchCardRestriction Cards { get; set; }

        /// <summary>
        /// True/False
        /// Whether to include location restriction of the cards in the response.
        /// Optional
        /// Default ‘false’
        /// </summary>
        [JsonProperty("IncludeLocationRestrictions")]
        public bool? IncludeLocationRestrictions
        {
            get
            {
                return this.includeLocationRestrictions;
            }

            set
            {
                this.shouldSerialize["IncludeLocationRestrictions"] = true;
                this.includeLocationRestrictions = value;
            }
        }

        /// <summary>
        /// Default value is False,
        /// When the value is True, API will return bundle Id associated with cards in the response, if available.
        /// Note: Use ‘Null’ or ‘False’ for optimum performance. A delay in response is expected when set to ‘True’.
        /// </summary>
        [JsonProperty("IncludeBundleDetails")]
        public bool? IncludeBundleDetails
        {
            get
            {
                return this.includeBundleDetails;
            }

            set
            {
                this.shouldSerialize["IncludeBundleDetails"] = true;
                this.includeBundleDetails = value;
            }
        }

        /// <summary>
        /// Default value is True,
        /// When True: service will return the inherited values for the usage limits (from card-program or account as available) when it is not overridden on the card.
        /// </summary>
        [JsonProperty("IncludeInheritedLimits")]
        public bool? IncludeInheritedLimits
        {
            get
            {
                return this.includeInheritedLimits;
            }

            set
            {
                this.shouldSerialize["IncludeInheritedLimits"] = true;
                this.includeInheritedLimits = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SearchCardRestrictionReq : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIncludeLocationRestrictions()
        {
            this.shouldSerialize["IncludeLocationRestrictions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIncludeBundleDetails()
        {
            this.shouldSerialize["IncludeBundleDetails"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIncludeInheritedLimits()
        {
            this.shouldSerialize["IncludeInheritedLimits"] = false;
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeLocationRestrictions()
        {
            return this.shouldSerialize["IncludeLocationRestrictions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeBundleDetails()
        {
            return this.shouldSerialize["IncludeBundleDetails"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeInheritedLimits()
        {
            return this.shouldSerialize["IncludeInheritedLimits"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchCardRestrictionReq other &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.Accounts == null && other.Accounts == null ||
                 this.Accounts?.Equals(other.Accounts) == true) &&
                (this.BundleId == null && other.BundleId == null ||
                 this.BundleId?.Equals(other.BundleId) == true) &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
                (this.IncludeLocationRestrictions == null && other.IncludeLocationRestrictions == null ||
                 this.IncludeLocationRestrictions?.Equals(other.IncludeLocationRestrictions) == true) &&
                (this.IncludeBundleDetails == null && other.IncludeBundleDetails == null ||
                 this.IncludeBundleDetails?.Equals(other.IncludeBundleDetails) == true) &&
                (this.IncludeInheritedLimits == null && other.IncludeInheritedLimits == null ||
                 this.IncludeInheritedLimits?.Equals(other.IncludeInheritedLimits) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"this.BundleId = {this.BundleId ?? "null"}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : this.Cards.ToString())}");
            toStringOutput.Add($"this.IncludeLocationRestrictions = {(this.IncludeLocationRestrictions == null ? "null" : this.IncludeLocationRestrictions.ToString())}");
            toStringOutput.Add($"this.IncludeBundleDetails = {(this.IncludeBundleDetails == null ? "null" : this.IncludeBundleDetails.ToString())}");
            toStringOutput.Add($"this.IncludeInheritedLimits = {(this.IncludeInheritedLimits == null ? "null" : this.IncludeInheritedLimits.ToString())}");
        }
    }
}
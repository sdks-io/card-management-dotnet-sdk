// <copyright file="UpdateBundleRequest.cs" company="APIMatic">
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
    /// UpdateBundleRequest.
    /// </summary>
    public class UpdateBundleRequest
    {
        private int? colCoId;
        private int? payerId;
        private int? accountId;
        private int? colCoCode;
        private string payerNumber;
        private string accountNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "PayerId", false },
            { "AccountId", false },
            { "ColCoCode", false },
            { "PayerNumber", false },
            { "AccountNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBundleRequest"/> class.
        /// </summary>
        public UpdateBundleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBundleRequest"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="requestAction">RequestAction.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="usageRestrictionAction">UsageRestrictionAction.</param>
        /// <param name="restrictions">Restrictions.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        public UpdateBundleRequest(
            string bundleId,
            int? colCoId = null,
            int? payerId = null,
            int? accountId = null,
            string requestAction = null,
            List<string> cards = null,
            string usageRestrictionAction = null,
            Models.BundleRestriction restrictions = null,
            int? colCoCode = null,
            string payerNumber = null,
            string accountNumber = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            this.BundleId = bundleId;
            this.RequestAction = requestAction;
            this.Cards = cards;
            this.UsageRestrictionAction = usageRestrictionAction;
            this.Restrictions = restrictions;
            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
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
        /// Payer Id of the selected payer.
        /// Either PayerId or PayerNumber or both must be passed.
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
        /// Account ID of the customer.
        /// Either AccountId or AccountNumber or both must be passed.
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
        /// Identifier of the bundle in Gateway.
        /// Mandatory
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId { get; set; }

        /// <summary>
        /// The value indicates the action to be performed with the request.
        /// Mandatory
        /// Allowed values:
        /// •	Add
        /// •	Update
        /// •	Remove
        /// </summary>
        [JsonProperty("RequestAction", NullValueHandling = NullValueHandling.Include)]
        public string RequestAction { get; set; }

        /// <summary>
        /// List of Card PANs to be added in the bundle.
        /// Mandatory for Add / Remove request action. Ignored for Update action.
        /// Example: 7002051006629890645
        /// When PAN matches with multiple cards, the restriction will be applied on the latest issued card
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cards { get; set; }

        /// <summary>
        /// The value indicates what actions to be performed with respect to usage restrictions on the list of cards being added or removed.
        /// Mandatory for Add / Remove request action. Ignored for Update action.
        /// Allowed values:
        /// •	Update
        /// •	None
        /// </summary>
        [JsonProperty("UsageRestrictionAction", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRestrictionAction { get; set; }

        /// <summary>
        /// Gets or sets Restrictions.
        /// </summary>
        [JsonProperty("Restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BundleRestriction Restrictions { get; set; }

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
        /// Payer Number of the selected payer.
        /// Either PayerId or PayerNumber or both must be passed.
        /// Example: GB000000123
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
        /// Account Number of the customer.
        /// Either AccountId or AccountNumber or both must be passed.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateBundleRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
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
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
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
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
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
            return obj is UpdateBundleRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.RequestAction == null && other.RequestAction == null) || (this.RequestAction?.Equals(other.RequestAction) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.UsageRestrictionAction == null && other.UsageRestrictionAction == null) || (this.UsageRestrictionAction?.Equals(other.UsageRestrictionAction) == true)) &&
                ((this.Restrictions == null && other.Restrictions == null) || (this.Restrictions?.Equals(other.Restrictions) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.RequestAction = {(this.RequestAction == null ? "null" : this.RequestAction)}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.UsageRestrictionAction = {(this.UsageRestrictionAction == null ? "null" : this.UsageRestrictionAction)}");
            toStringOutput.Add($"this.Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
        }
    }
}
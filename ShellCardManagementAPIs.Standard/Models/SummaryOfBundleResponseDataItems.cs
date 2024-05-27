// <copyright file="SummaryOfBundleResponseDataItems.cs" company="APIMatic">
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
    /// SummaryOfBundleResponseDataItems.
    /// </summary>
    public class SummaryOfBundleResponseDataItems
    {
        private int? payerId;
        private string payerNumber;
        private int? accountId;
        private string accountNumber;
        private int? countOfCardsNotInBundle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PayerId", false },
            { "PayerNumber", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "CountOfCardsNotInBundle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryOfBundleResponseDataItems"/> class.
        /// </summary>
        public SummaryOfBundleResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryOfBundleResponseDataItems"/> class.
        /// </summary>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="countOfCardsNotInBundle">CountOfCardsNotInBundle.</param>
        /// <param name="cardBundles">CardBundles.</param>
        public SummaryOfBundleResponseDataItems(
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            int? countOfCardsNotInBundle = null,
            List<Models.SummaryOfBundleResponseDataItemsCardBundlesItems> cardBundles = null)
        {
            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (countOfCardsNotInBundle != null)
            {
                this.CountOfCardsNotInBundle = countOfCardsNotInBundle;
            }

            this.CardBundles = cardBundles;
        }

        /// <summary>
        /// Payer Id of the bundles and cards.
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
        /// Payer Number of the bundles and cards.
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
        /// Account ID of the bundle.
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
        /// Account Number of the bundle.
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

        /// <summary>
        /// Count of cards that are not part of the bundle in a given account.
        /// </summary>
        [JsonProperty("CountOfCardsNotInBundle")]
        public int? CountOfCardsNotInBundle
        {
            get
            {
                return this.countOfCardsNotInBundle;
            }

            set
            {
                this.shouldSerialize["CountOfCardsNotInBundle"] = true;
                this.countOfCardsNotInBundle = value;
            }
        }

        /// <summary>
        /// List of Card Bundles
        /// </summary>
        [JsonProperty("CardBundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SummaryOfBundleResponseDataItemsCardBundlesItems> CardBundles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SummaryOfBundleResponseDataItems : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountOfCardsNotInBundle()
        {
            this.shouldSerialize["CountOfCardsNotInBundle"] = false;
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
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
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
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountOfCardsNotInBundle()
        {
            return this.shouldSerialize["CountOfCardsNotInBundle"];
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
            return obj is SummaryOfBundleResponseDataItems other &&                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CountOfCardsNotInBundle == null && other.CountOfCardsNotInBundle == null) || (this.CountOfCardsNotInBundle?.Equals(other.CountOfCardsNotInBundle) == true)) &&
                ((this.CardBundles == null && other.CardBundles == null) || (this.CardBundles?.Equals(other.CardBundles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.CountOfCardsNotInBundle = {(this.CountOfCardsNotInBundle == null ? "null" : this.CountOfCardsNotInBundle.ToString())}");
            toStringOutput.Add($"this.CardBundles = {(this.CardBundles == null ? "null" : $"[{string.Join(", ", this.CardBundles)} ]")}");
        }
    }
}
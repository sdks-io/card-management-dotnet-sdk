// <copyright file="SearchAccountLimitResponseData.cs" company="APIMatic">
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
    /// SearchAccountLimitResponseData.
    /// </summary>
    public class SearchAccountLimitResponseData
    {
        private int? accountId;
        private string accountNumber;
        private string referenceProduct;
        private string restrictionCondition;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "ReferenceProduct", false },
            { "RestrictionCondition", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAccountLimitResponseData"/> class.
        /// </summary>
        public SearchAccountLimitResponseData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAccountLimitResponseData"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="referenceProduct">ReferenceProduct.</param>
        /// <param name="restrictionCondition">RestrictionCondition.</param>
        /// <param name="velocityLimits">VelocityLimits.</param>
        public SearchAccountLimitResponseData(
            int? accountId = null,
            string accountNumber = null,
            string referenceProduct = null,
            string restrictionCondition = null,
            List<Models.AccountVelocityLimit> velocityLimits = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (referenceProduct != null)
            {
                this.ReferenceProduct = referenceProduct;
            }

            if (restrictionCondition != null)
            {
                this.RestrictionCondition = restrictionCondition;
            }

            this.VelocityLimits = velocityLimits;
        }

        /// <summary>
        /// Gets or sets AccountId.
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
        /// Account Number
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
        /// 3 digit Shell global fuel product code, if already set up.
        /// </summary>
        [JsonProperty("ReferenceProduct")]
        public string ReferenceProduct
        {
            get
            {
                return this.referenceProduct;
            }

            set
            {
                this.shouldSerialize["ReferenceProduct"] = true;
                this.referenceProduct = value;
            }
        }

        /// <summary>
        /// The restriction condition code.
        /// </summary>
        [JsonProperty("RestrictionCondition")]
        public string RestrictionCondition
        {
            get
            {
                return this.restrictionCondition;
            }

            set
            {
                this.shouldSerialize["RestrictionCondition"] = true;
                this.restrictionCondition = value;
            }
        }

        /// <summary>
        /// Gets or sets VelocityLimits.
        /// </summary>
        [JsonProperty("VelocityLimits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountVelocityLimit> VelocityLimits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchAccountLimitResponseData : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetReferenceProduct()
        {
            this.shouldSerialize["ReferenceProduct"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRestrictionCondition()
        {
            this.shouldSerialize["RestrictionCondition"] = false;
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
        public bool ShouldSerializeReferenceProduct()
        {
            return this.shouldSerialize["ReferenceProduct"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRestrictionCondition()
        {
            return this.shouldSerialize["RestrictionCondition"];
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
            return obj is SearchAccountLimitResponseData other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ReferenceProduct == null && other.ReferenceProduct == null) || (this.ReferenceProduct?.Equals(other.ReferenceProduct) == true)) &&
                ((this.RestrictionCondition == null && other.RestrictionCondition == null) || (this.RestrictionCondition?.Equals(other.RestrictionCondition) == true)) &&
                ((this.VelocityLimits == null && other.VelocityLimits == null) || (this.VelocityLimits?.Equals(other.VelocityLimits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ReferenceProduct = {(this.ReferenceProduct == null ? "null" : this.ReferenceProduct)}");
            toStringOutput.Add($"this.RestrictionCondition = {(this.RestrictionCondition == null ? "null" : this.RestrictionCondition)}");
            toStringOutput.Add($"this.VelocityLimits = {(this.VelocityLimits == null ? "null" : $"[{string.Join(", ", this.VelocityLimits)} ]")}");
        }
    }
}
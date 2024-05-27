// <copyright file="AccountVelocityLimit.cs" company="APIMatic">
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
    /// AccountVelocityLimit.
    /// </summary>
    public class AccountVelocityLimit
    {
        private string type;
        private string period;
        private double? limit;
        private double? accumulation;
        private double? balance;
        private bool? mOverride;
        private string productGroup;
        private double? threshold;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Type", false },
            { "Period", false },
            { "Limit", false },
            { "Accumulation", false },
            { "Balance", false },
            { "Override", false },
            { "ProductGroup", false },
            { "Threshold", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVelocityLimit"/> class.
        /// </summary>
        public AccountVelocityLimit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVelocityLimit"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="period">Period.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="accumulation">Accumulation.</param>
        /// <param name="balance">Balance.</param>
        /// <param name="mOverride">Override.</param>
        /// <param name="productGroup">ProductGroup.</param>
        /// <param name="threshold">Threshold.</param>
        public AccountVelocityLimit(
            string type = null,
            string period = null,
            double? limit = null,
            double? accumulation = null,
            double? balance = null,
            bool? mOverride = null,
            string productGroup = null,
            double? threshold = null)
        {
            if (type != null)
            {
                this.Type = type;
            }

            if (period != null)
            {
                this.Period = period;
            }

            if (limit != null)
            {
                this.Limit = limit;
            }

            if (accumulation != null)
            {
                this.Accumulation = accumulation;
            }

            if (balance != null)
            {
                this.Balance = balance;
            }

            if (mOverride != null)
            {
                this.MOverride = mOverride;
            }

            if (productGroup != null)
            {
                this.ProductGroup = productGroup;
            }

            if (threshold != null)
            {
                this.Threshold = threshold;
            }

        }

        /// <summary>
        /// Type of velocity (COUNT type is not present for limits of PERTRX period
        /// Possible Values: VALUE, VOLUME, COUNT
        /// </summary>
        [JsonProperty("Type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["Type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Duration of the velocity or threshold alert.
        /// Possible Values: DAILY, WEEKLY, MONTHLY, ANNUAL, LIFETIME, PERTRX
        /// </summary>
        [JsonProperty("Period")]
        public string Period
        {
            get
            {
                return this.period;
            }

            set
            {
                this.shouldSerialize["Period"] = true;
                this.period = value;
            }
        }

        /// <summary>
        /// The limit associated with this velocity with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer (except for COUNT type velocity).
        /// </summary>
        [JsonProperty("Limit")]
        public double? Limit
        {
            get
            {
                return this.limit;
            }

            set
            {
                this.shouldSerialize["Limit"] = true;
                this.limit = value;
            }
        }

        /// <summary>
        /// The transaction accumulation during the current period with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer (except for COUNT type velocity). Not present for PERTRX period.
        /// </summary>
        [JsonProperty("Accumulation")]
        public double? Accumulation
        {
            get
            {
                return this.accumulation;
            }

            set
            {
                this.shouldSerialize["Accumulation"] = true;
                this.accumulation = value;
            }
        }

        /// <summary>
        /// The remaining/available balance at this point in time with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer (except for COUNT type velocity). Not present for PERTRX period.
        /// </summary>
        [JsonProperty("Balance")]
        public double? Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.shouldSerialize["Balance"] = true;
                this.balance = value;
            }
        }

        /// <summary>
        /// Indicate if the limit is overridden or default. (false for default).
        /// </summary>
        [JsonProperty("Override")]
        public bool? MOverride
        {
            get
            {
                return this.mOverride;
            }

            set
            {
                this.shouldSerialize["Override"] = true;
                this.mOverride = value;
            }
        }

        /// <summary>
        /// The reference group name for product differentiated velocities. This field cannot be used with Volume type velocity.
        /// Example: RoadSvc
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("ProductGroup")]
        public string ProductGroup
        {
            get
            {
                return this.productGroup;
            }

            set
            {
                this.shouldSerialize["ProductGroup"] = true;
                this.productGroup = value;
            }
        }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// </summary>
        [JsonProperty("Threshold")]
        public double? Threshold
        {
            get
            {
                return this.threshold;
            }

            set
            {
                this.shouldSerialize["Threshold"] = true;
                this.threshold = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountVelocityLimit : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPeriod()
        {
            this.shouldSerialize["Period"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLimit()
        {
            this.shouldSerialize["Limit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccumulation()
        {
            this.shouldSerialize["Accumulation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBalance()
        {
            this.shouldSerialize["Balance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOverride()
        {
            this.shouldSerialize["Override"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroup()
        {
            this.shouldSerialize["ProductGroup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetThreshold()
        {
            this.shouldSerialize["Threshold"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePeriod()
        {
            return this.shouldSerialize["Period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLimit()
        {
            return this.shouldSerialize["Limit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccumulation()
        {
            return this.shouldSerialize["Accumulation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBalance()
        {
            return this.shouldSerialize["Balance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOverride()
        {
            return this.shouldSerialize["Override"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroup()
        {
            return this.shouldSerialize["ProductGroup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreshold()
        {
            return this.shouldSerialize["Threshold"];
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
            return obj is AccountVelocityLimit other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Accumulation == null && other.Accumulation == null) || (this.Accumulation?.Equals(other.Accumulation) == true)) &&
                ((this.Balance == null && other.Balance == null) || (this.Balance?.Equals(other.Balance) == true)) &&
                ((this.MOverride == null && other.MOverride == null) || (this.MOverride?.Equals(other.MOverride) == true)) &&
                ((this.ProductGroup == null && other.ProductGroup == null) || (this.ProductGroup?.Equals(other.ProductGroup) == true)) &&
                ((this.Threshold == null && other.Threshold == null) || (this.Threshold?.Equals(other.Threshold) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
            toStringOutput.Add($"this.Accumulation = {(this.Accumulation == null ? "null" : this.Accumulation.ToString())}");
            toStringOutput.Add($"this.Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"this.MOverride = {(this.MOverride == null ? "null" : this.MOverride.ToString())}");
            toStringOutput.Add($"this.ProductGroup = {(this.ProductGroup == null ? "null" : this.ProductGroup)}");
            toStringOutput.Add($"this.Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
        }
    }
}
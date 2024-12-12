// <copyright file="AccountVelocityLimit.cs" company="APIMatic">
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
    /// AccountVelocityLimit.
    /// </summary>
    public class AccountVelocityLimit
    {
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
            this.Type = type;
            this.Period = period;
            this.Limit = limit;
            this.Accumulation = accumulation;
            this.Balance = balance;
            this.MOverride = mOverride;
            this.ProductGroup = productGroup;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Type of velocity (COUNT type is not present for limits of PERTRX period
        /// Possible Values: VALUE, VOLUME, COUNT
        /// </summary>
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Duration of the velocity or threshold alert.
        /// Possible Values: DAILY, WEEKLY, MONTHLY, ANNUAL, LIFETIME, PERTRX
        /// </summary>
        [JsonProperty("Period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// The limit associated with this velocity with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer.
        /// Example: 1500.55
        /// </summary>
        [JsonProperty("Limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// The transaction accumulation during the current period with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer (except for COUNT type velocity). Not present for PERTRX period.
        /// Example: 1100.55
        /// </summary>
        [JsonProperty("Accumulation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Accumulation { get; set; }

        /// <summary>
        /// The remaining/available balance at this point in time with the correct number of digits after the decimal point according to the minor denomination of the currency of the card issuer (except for COUNT type velocity). Not present for PERTRX period.
        /// Example: 400.55
        /// </summary>
        [JsonProperty("Balance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Balance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (false for default).
        /// Example: false
        /// </summary>
        [JsonProperty("Override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MOverride { get; set; }

        /// <summary>
        /// The reference group name for product differentiated velocities. This field cannot be used with Volume type velocity.
        /// Example: RoadSvc
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("ProductGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductGroup { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("Threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountVelocityLimit : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountVelocityLimit other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Period == null && other.Period == null ||
                 this.Period?.Equals(other.Period) == true) &&
                (this.Limit == null && other.Limit == null ||
                 this.Limit?.Equals(other.Limit) == true) &&
                (this.Accumulation == null && other.Accumulation == null ||
                 this.Accumulation?.Equals(other.Accumulation) == true) &&
                (this.Balance == null && other.Balance == null ||
                 this.Balance?.Equals(other.Balance) == true) &&
                (this.MOverride == null && other.MOverride == null ||
                 this.MOverride?.Equals(other.MOverride) == true) &&
                (this.ProductGroup == null && other.ProductGroup == null ||
                 this.ProductGroup?.Equals(other.ProductGroup) == true) &&
                (this.Threshold == null && other.Threshold == null ||
                 this.Threshold?.Equals(other.Threshold) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type ?? "null"}");
            toStringOutput.Add($"this.Period = {this.Period ?? "null"}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
            toStringOutput.Add($"this.Accumulation = {(this.Accumulation == null ? "null" : this.Accumulation.ToString())}");
            toStringOutput.Add($"this.Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"this.MOverride = {(this.MOverride == null ? "null" : this.MOverride.ToString())}");
            toStringOutput.Add($"this.ProductGroup = {this.ProductGroup ?? "null"}");
            toStringOutput.Add($"this.Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
        }
    }
}
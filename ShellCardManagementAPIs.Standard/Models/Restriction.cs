// <copyright file="Restriction.cs" company="APIMatic">
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
    /// Restriction.
    /// </summary>
    public class Restriction
    {
        private Models.UsageRestriction usageRestrictions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "UsageRestrictions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction"/> class.
        /// </summary>
        public Restriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction"/> class.
        /// </summary>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        public Restriction(
            Models.UsageRestriction usageRestrictions = null,
            Models.DayTimeRestriction dayTimeRestrictions = null,
            Models.SearchProductRestriction productRestrictions = null,
            Models.LocationRestriction locationRestrictions = null)
        {
            if (usageRestrictions != null)
            {
                this.UsageRestrictions = usageRestrictions;
            }

            this.DayTimeRestrictions = dayTimeRestrictions;
            this.ProductRestrictions = productRestrictions;
            this.LocationRestrictions = locationRestrictions;
        }

        /// <summary>
        /// Details of the usage restrictions such as day/week/month value and volume restrictions applied on the card.
        /// </summary>
        [JsonProperty("UsageRestrictions")]
        public Models.UsageRestriction UsageRestrictions
        {
            get
            {
                return this.usageRestrictions;
            }

            set
            {
                this.shouldSerialize["UsageRestrictions"] = true;
                this.usageRestrictions = value;
            }
        }

        /// <summary>
        /// Details of the day/time restrictions such as weekdays and time range in which transactions should be allowed on the card.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DayTimeRestriction DayTimeRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictions.
        /// </summary>
        [JsonProperty("ProductRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchProductRestriction ProductRestrictions { get; set; }

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

            return $"Restriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUsageRestrictions()
        {
            this.shouldSerialize["UsageRestrictions"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageRestrictions()
        {
            return this.shouldSerialize["UsageRestrictions"];
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
            return obj is Restriction other &&                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true)) &&
                ((this.DayTimeRestrictions == null && other.DayTimeRestrictions == null) || (this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true)) &&
                ((this.ProductRestrictions == null && other.ProductRestrictions == null) || (this.ProductRestrictions?.Equals(other.ProductRestrictions) == true)) &&
                ((this.LocationRestrictions == null && other.LocationRestrictions == null) || (this.LocationRestrictions?.Equals(other.LocationRestrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
// <copyright file="Restriction.cs" company="APIMatic">
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
    /// Restriction.
    /// </summary>
    public class Restriction
    {
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
            object usageRestrictions = null,
            Models.DayTimeRestrictions dayTimeRestrictions = null,
            Models.SearchProductRestriction productRestrictions = null,
            Models.LocationRestriction locationRestrictions = null)
        {
            this.UsageRestrictions = usageRestrictions;
            this.DayTimeRestrictions = dayTimeRestrictions;
            this.ProductRestrictions = productRestrictions;
            this.LocationRestrictions = locationRestrictions;
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Restriction other &&
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
            toStringOutput.Add($"UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
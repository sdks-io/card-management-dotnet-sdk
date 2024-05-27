// <copyright file="SearchCardResponseRestrictions.cs" company="APIMatic">
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
    /// SearchCardResponseRestrictions.
    /// </summary>
    public class SearchCardResponseRestrictions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardResponseRestrictions"/> class.
        /// </summary>
        public SearchCardResponseRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardResponseRestrictions"/> class.
        /// </summary>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        public SearchCardResponseRestrictions(
            Models.DayTimeRestrictions dayTimeRestrictions = null,
            Models.LocationRestrictions locationRestrictions = null,
            Models.SearchProductRestriction productRestrictions = null,
            Models.UsageRestrictions usageRestrictions = null)
        {
            this.DayTimeRestrictions = dayTimeRestrictions;
            this.LocationRestrictions = locationRestrictions;
            this.ProductRestrictions = productRestrictions;
            this.UsageRestrictions = usageRestrictions;
        }

        /// <summary>
        /// Day/time restrictions such as weekdays and time range to be applied on the bundle.
        /// Mandatory if respective action is set as “Add”.
        /// The details of DayTimeRestriction entity is given below.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DayTimeRestrictions DayTimeRestrictions { get; set; }

        /// <summary>
        /// Location restrictions to be applied on the bundle which either allows or restricts using the cards, which are under the bundle, in the specified locations.
        /// Mandatory if respective action is set as “Add”.
        /// Details of location restrictions are given below.
        /// </summary>
        [JsonProperty("LocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationRestrictions LocationRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictions.
        /// </summary>
        [JsonProperty("ProductRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchProductRestriction ProductRestrictions { get; set; }

        /// <summary>
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsageRestrictions UsageRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchCardResponseRestrictions : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchCardResponseRestrictions other &&                ((this.DayTimeRestrictions == null && other.DayTimeRestrictions == null) || (this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true)) &&
                ((this.LocationRestrictions == null && other.LocationRestrictions == null) || (this.LocationRestrictions?.Equals(other.LocationRestrictions) == true)) &&
                ((this.ProductRestrictions == null && other.ProductRestrictions == null) || (this.ProductRestrictions?.Equals(other.ProductRestrictions) == true)) &&
                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
        }
    }
}
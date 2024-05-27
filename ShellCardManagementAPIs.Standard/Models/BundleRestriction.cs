// <copyright file="BundleRestriction.cs" company="APIMatic">
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
    /// BundleRestriction.
    /// </summary>
    public class BundleRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestriction"/> class.
        /// </summary>
        public BundleRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestriction"/> class.
        /// </summary>
        /// <param name="resetDayTimeRestriction">ResetDayTimeRestriction.</param>
        /// <param name="resetLocationRestriction">ResetLocationRestriction.</param>
        /// <param name="resetProductRestriction">ResetProductRestriction.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="productRestriction">ProductRestriction.</param>
        /// <param name="locationRestrictionProfileId">LocationRestrictionProfileId.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        public BundleRestriction(
            bool? resetDayTimeRestriction = false,
            bool? resetLocationRestriction = false,
            bool? resetProductRestriction = false,
            Models.UsageRestrictions usageRestrictions = null,
            Models.DayTimeRestrictions dayTimeRestrictions = null,
            Models.ProductRestrictions productRestriction = null,
            string locationRestrictionProfileId = null,
            Models.LocationRestrictions locationRestrictions = null)
        {
            this.ResetDayTimeRestriction = resetDayTimeRestriction;
            this.ResetLocationRestriction = resetLocationRestriction;
            this.ResetProductRestriction = resetProductRestriction;
            this.UsageRestrictions = usageRestrictions;
            this.DayTimeRestrictions = dayTimeRestrictions;
            this.ProductRestriction = productRestriction;
            this.LocationRestrictionProfileId = locationRestrictionProfileId;
            this.LocationRestrictions = locationRestrictions;
        }

        /// <summary>
        /// True/False
        /// A value indicates if the day/time restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetDayTimeRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetDayTimeRestriction { get; set; }

        /// <summary>
        /// True/False
        /// A value indicates if the location restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetLocationRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetLocationRestriction { get; set; }

        /// <summary>
        /// True/False
        /// A value indicates if the product restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetProductRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetProductRestriction { get; set; }

        /// <summary>
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsageRestrictions UsageRestrictions { get; set; }

        /// <summary>
        /// Day/time restrictions such as weekdays and time range to be applied on the bundle.
        /// Mandatory if respective action is set as “Add”.
        /// The details of DayTimeRestriction entity is given below.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DayTimeRestrictions DayTimeRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ProductRestriction.
        /// </summary>
        [JsonProperty("ProductRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProductRestrictions ProductRestriction { get; set; }

        /// <summary>
        /// Identifier of the location restriction profile to be updated for the bundle in Gateway.
        /// Optional
        /// </summary>
        [JsonProperty("LocationRestrictionProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationRestrictionProfileId { get; set; }

        /// <summary>
        /// Location restrictions to be applied on the bundle which either allows or restricts using the cards, which are under the bundle, in the specified locations.
        /// Mandatory if respective action is set as “Add”.
        /// Details of location restrictions are given below.
        /// </summary>
        [JsonProperty("LocationRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationRestrictions LocationRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BundleRestriction : ({string.Join(", ", toStringOutput)})";
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
            return obj is BundleRestriction other &&                ((this.ResetDayTimeRestriction == null && other.ResetDayTimeRestriction == null) || (this.ResetDayTimeRestriction?.Equals(other.ResetDayTimeRestriction) == true)) &&
                ((this.ResetLocationRestriction == null && other.ResetLocationRestriction == null) || (this.ResetLocationRestriction?.Equals(other.ResetLocationRestriction) == true)) &&
                ((this.ResetProductRestriction == null && other.ResetProductRestriction == null) || (this.ResetProductRestriction?.Equals(other.ResetProductRestriction) == true)) &&
                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true)) &&
                ((this.DayTimeRestrictions == null && other.DayTimeRestrictions == null) || (this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true)) &&
                ((this.ProductRestriction == null && other.ProductRestriction == null) || (this.ProductRestriction?.Equals(other.ProductRestriction) == true)) &&
                ((this.LocationRestrictionProfileId == null && other.LocationRestrictionProfileId == null) || (this.LocationRestrictionProfileId?.Equals(other.LocationRestrictionProfileId) == true)) &&
                ((this.LocationRestrictions == null && other.LocationRestrictions == null) || (this.LocationRestrictions?.Equals(other.LocationRestrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResetDayTimeRestriction = {(this.ResetDayTimeRestriction == null ? "null" : this.ResetDayTimeRestriction.ToString())}");
            toStringOutput.Add($"this.ResetLocationRestriction = {(this.ResetLocationRestriction == null ? "null" : this.ResetLocationRestriction.ToString())}");
            toStringOutput.Add($"this.ResetProductRestriction = {(this.ResetProductRestriction == null ? "null" : this.ResetProductRestriction.ToString())}");
            toStringOutput.Add($"this.UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestriction = {(this.ProductRestriction == null ? "null" : this.ProductRestriction.ToString())}");
            toStringOutput.Add($"this.LocationRestrictionProfileId = {(this.LocationRestrictionProfileId == null ? "null" : this.LocationRestrictionProfileId)}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
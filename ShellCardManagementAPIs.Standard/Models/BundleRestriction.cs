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
        private string dayTimeRestrictionAction;
        private string locationRestrictionAction;
        private Models.UsageRestrictionsCard usageRestrictions;
        private Models.ProductRestrictionCard productRestrictions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DayTimeRestrictionAction", false },
            { "LocationRestrictionAction", false },
            { "UsageRestrictions", false },
            { "ProductRestrictions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestriction"/> class.
        /// </summary>
        public BundleRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestriction"/> class.
        /// </summary>
        /// <param name="dayTimeRestrictionAction">DayTimeRestrictionAction.</param>
        /// <param name="locationRestrictionAction">LocationRestrictionAction.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        public BundleRestriction(
            string dayTimeRestrictionAction = null,
            string locationRestrictionAction = null,
            Models.UsageRestrictionsCard usageRestrictions = null,
            Models.DayTimeRestriction dayTimeRestrictions = null,
            Models.ProductRestrictionCard productRestrictions = null,
            Models.LocationRestriction locationRestrictions = null)
        {
            if (dayTimeRestrictionAction != null)
            {
                this.DayTimeRestrictionAction = dayTimeRestrictionAction;
            }

            if (locationRestrictionAction != null)
            {
                this.LocationRestrictionAction = locationRestrictionAction;
            }

            if (usageRestrictions != null)
            {
                this.UsageRestrictions = usageRestrictions;
            }

            this.DayTimeRestrictions = dayTimeRestrictions;
            if (productRestrictions != null)
            {
                this.ProductRestrictions = productRestrictions;
            }

            this.LocationRestrictions = locationRestrictions;
        }

        /// <summary>
        /// The value indicates what actions to be performed with respect to day time restriction.
        /// Mandatory
        /// Allowed values –
        /// •	Add: Apply the given restriction on the bundle.
        /// •	Default: No Day/Time restriction will be applied on the bundle in Gateway.
        /// </summary>
        [JsonProperty("DayTimeRestrictionAction")]
        public string DayTimeRestrictionAction
        {
            get
            {
                return this.dayTimeRestrictionAction;
            }

            set
            {
                this.shouldSerialize["DayTimeRestrictionAction"] = true;
                this.dayTimeRestrictionAction = value;
            }
        }

        /// <summary>
        /// The value indicates what actions to be performed with respect to location restriction.
        /// Mandatory
        /// Allowed values –
        /// •	Add: Apply the given restriction on the bundle.
        /// •	Default: No location restriction will be applied on the bundle in Gateway.
        /// </summary>
        [JsonProperty("LocationRestrictionAction")]
        public string LocationRestrictionAction
        {
            get
            {
                return this.locationRestrictionAction;
            }

            set
            {
                this.shouldSerialize["LocationRestrictionAction"] = true;
                this.locationRestrictionAction = value;
            }
        }

        /// <summary>
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions")]
        public Models.UsageRestrictionsCard UsageRestrictions
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
        [JsonProperty("ProductRestrictions")]
        public Models.ProductRestrictionCard ProductRestrictions
        {
            get
            {
                return this.productRestrictions;
            }

            set
            {
                this.shouldSerialize["ProductRestrictions"] = true;
                this.productRestrictions = value;
            }
        }

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

            return $"BundleRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDayTimeRestrictionAction()
        {
            this.shouldSerialize["DayTimeRestrictionAction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationRestrictionAction()
        {
            this.shouldSerialize["LocationRestrictionAction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUsageRestrictions()
        {
            this.shouldSerialize["UsageRestrictions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductRestrictions()
        {
            this.shouldSerialize["ProductRestrictions"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDayTimeRestrictionAction()
        {
            return this.shouldSerialize["DayTimeRestrictionAction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationRestrictionAction()
        {
            return this.shouldSerialize["LocationRestrictionAction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageRestrictions()
        {
            return this.shouldSerialize["UsageRestrictions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductRestrictions()
        {
            return this.shouldSerialize["ProductRestrictions"];
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
            return obj is BundleRestriction other &&                ((this.DayTimeRestrictionAction == null && other.DayTimeRestrictionAction == null) || (this.DayTimeRestrictionAction?.Equals(other.DayTimeRestrictionAction) == true)) &&
                ((this.LocationRestrictionAction == null && other.LocationRestrictionAction == null) || (this.LocationRestrictionAction?.Equals(other.LocationRestrictionAction) == true)) &&
                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true)) &&
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
            toStringOutput.Add($"this.DayTimeRestrictionAction = {(this.DayTimeRestrictionAction == null ? "null" : this.DayTimeRestrictionAction)}");
            toStringOutput.Add($"this.LocationRestrictionAction = {(this.LocationRestrictionAction == null ? "null" : this.LocationRestrictionAction)}");
            toStringOutput.Add($"this.UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
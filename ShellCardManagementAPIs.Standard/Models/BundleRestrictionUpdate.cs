// <copyright file="BundleRestrictionUpdate.cs" company="APIMatic">
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
    /// BundleRestrictionUpdate.
    /// </summary>
    public class BundleRestrictionUpdate
    {
        private bool? resetDayTimeRestriction;
        private bool? resetLocationRestriction;
        private bool? resetProductRestriction;
        private Models.UsageRestrictionsCard usageRestrictions;
        private string dayTimeRestrictionProfileId;
        private Models.ProductRestrictionCard productRestrictions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ResetDayTimeRestriction", false },
            { "ResetLocationRestriction", false },
            { "ResetProductRestriction", false },
            { "UsageRestrictions", false },
            { "DayTimeRestrictionProfileId", false },
            { "ProductRestrictions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestrictionUpdate"/> class.
        /// </summary>
        public BundleRestrictionUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleRestrictionUpdate"/> class.
        /// </summary>
        /// <param name="resetDayTimeRestriction">ResetDayTimeRestriction.</param>
        /// <param name="resetLocationRestriction">ResetLocationRestriction.</param>
        /// <param name="resetProductRestriction">ResetProductRestriction.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="dayTimeRestrictionProfileId">DayTimeRestrictionProfileId.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="productRestrictions">ProductRestrictions.</param>
        /// <param name="locationRestrictionProfileId">LocationRestrictionProfileId.</param>
        /// <param name="locationRestrictions">LocationRestrictions.</param>
        public BundleRestrictionUpdate(
            bool? resetDayTimeRestriction = null,
            bool? resetLocationRestriction = null,
            bool? resetProductRestriction = null,
            Models.UsageRestrictionsCard usageRestrictions = null,
            string dayTimeRestrictionProfileId = null,
            Models.CardDayTimeRestrictions dayTimeRestrictions = null,
            Models.ProductRestrictionCard productRestrictions = null,
            string locationRestrictionProfileId = null,
            Models.LocationRestriction locationRestrictions = null)
        {
            if (resetDayTimeRestriction != null)
            {
                this.ResetDayTimeRestriction = resetDayTimeRestriction;
            }

            if (resetLocationRestriction != null)
            {
                this.ResetLocationRestriction = resetLocationRestriction;
            }

            if (resetProductRestriction != null)
            {
                this.ResetProductRestriction = resetProductRestriction;
            }

            if (usageRestrictions != null)
            {
                this.UsageRestrictions = usageRestrictions;
            }

            if (dayTimeRestrictionProfileId != null)
            {
                this.DayTimeRestrictionProfileId = dayTimeRestrictionProfileId;
            }

            this.DayTimeRestrictions = dayTimeRestrictions;
            if (productRestrictions != null)
            {
                this.ProductRestrictions = productRestrictions;
            }

            this.LocationRestrictionProfileId = locationRestrictionProfileId;
            this.LocationRestrictions = locationRestrictions;
        }

        /// <summary>
        /// True/False
        /// A value indicates if the day/time restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetDayTimeRestriction")]
        public bool? ResetDayTimeRestriction
        {
            get
            {
                return this.resetDayTimeRestriction;
            }

            set
            {
                this.shouldSerialize["ResetDayTimeRestriction"] = true;
                this.resetDayTimeRestriction = value;
            }
        }

        /// <summary>
        /// True/False
        /// A value indicates if the location restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetLocationRestriction")]
        public bool? ResetLocationRestriction
        {
            get
            {
                return this.resetLocationRestriction;
            }

            set
            {
                this.shouldSerialize["ResetLocationRestriction"] = true;
                this.resetLocationRestriction = value;
            }
        }

        /// <summary>
        /// True/False
        /// A value indicates if the product restriction is to be reset for card bundle.
        /// Optional
        /// Default value is False.
        /// </summary>
        [JsonProperty("ResetProductRestriction")]
        public bool? ResetProductRestriction
        {
            get
            {
                return this.resetProductRestriction;
            }

            set
            {
                this.shouldSerialize["ResetProductRestriction"] = true;
                this.resetProductRestriction = value;
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
        /// Identifier of the day/time restriction profile to be updated for the bundle in Gateway.
        /// Optional
        /// </summary>
        [JsonProperty("DayTimeRestrictionProfileId")]
        public string DayTimeRestrictionProfileId
        {
            get
            {
                return this.dayTimeRestrictionProfileId;
            }

            set
            {
                this.shouldSerialize["DayTimeRestrictionProfileId"] = true;
                this.dayTimeRestrictionProfileId = value;
            }
        }

        /// <summary>
        /// Gets or sets DayTimeRestrictions.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDayTimeRestrictions DayTimeRestrictions { get; set; }

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
        /// Identifier of the location restriction profile to be updated for the bundle in Gateway.
        /// Optional
        /// </summary>
        [JsonProperty("LocationRestrictionProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationRestrictionProfileId { get; set; }

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

            return $"BundleRestrictionUpdate : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetResetDayTimeRestriction()
        {
            this.shouldSerialize["ResetDayTimeRestriction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetResetLocationRestriction()
        {
            this.shouldSerialize["ResetLocationRestriction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetResetProductRestriction()
        {
            this.shouldSerialize["ResetProductRestriction"] = false;
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
        public void UnsetDayTimeRestrictionProfileId()
        {
            this.shouldSerialize["DayTimeRestrictionProfileId"] = false;
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
        public bool ShouldSerializeResetDayTimeRestriction()
        {
            return this.shouldSerialize["ResetDayTimeRestriction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResetLocationRestriction()
        {
            return this.shouldSerialize["ResetLocationRestriction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResetProductRestriction()
        {
            return this.shouldSerialize["ResetProductRestriction"];
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
        public bool ShouldSerializeDayTimeRestrictionProfileId()
        {
            return this.shouldSerialize["DayTimeRestrictionProfileId"];
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
            return obj is BundleRestrictionUpdate other &&                ((this.ResetDayTimeRestriction == null && other.ResetDayTimeRestriction == null) || (this.ResetDayTimeRestriction?.Equals(other.ResetDayTimeRestriction) == true)) &&
                ((this.ResetLocationRestriction == null && other.ResetLocationRestriction == null) || (this.ResetLocationRestriction?.Equals(other.ResetLocationRestriction) == true)) &&
                ((this.ResetProductRestriction == null && other.ResetProductRestriction == null) || (this.ResetProductRestriction?.Equals(other.ResetProductRestriction) == true)) &&
                ((this.UsageRestrictions == null && other.UsageRestrictions == null) || (this.UsageRestrictions?.Equals(other.UsageRestrictions) == true)) &&
                ((this.DayTimeRestrictionProfileId == null && other.DayTimeRestrictionProfileId == null) || (this.DayTimeRestrictionProfileId?.Equals(other.DayTimeRestrictionProfileId) == true)) &&
                ((this.DayTimeRestrictions == null && other.DayTimeRestrictions == null) || (this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true)) &&
                ((this.ProductRestrictions == null && other.ProductRestrictions == null) || (this.ProductRestrictions?.Equals(other.ProductRestrictions) == true)) &&
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
            toStringOutput.Add($"this.DayTimeRestrictionProfileId = {(this.DayTimeRestrictionProfileId == null ? "null" : this.DayTimeRestrictionProfileId)}");
            toStringOutput.Add($"this.DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"this.ProductRestrictions = {(this.ProductRestrictions == null ? "null" : this.ProductRestrictions.ToString())}");
            toStringOutput.Add($"this.LocationRestrictionProfileId = {(this.LocationRestrictionProfileId == null ? "null" : this.LocationRestrictionProfileId)}");
            toStringOutput.Add($"this.LocationRestrictions = {(this.LocationRestrictions == null ? "null" : this.LocationRestrictions.ToString())}");
        }
    }
}
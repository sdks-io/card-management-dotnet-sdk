// <copyright file="CreateBundleResponseDataItems.cs" company="APIMatic">
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
    /// CreateBundleResponseDataItems.
    /// </summary>
    public class CreateBundleResponseDataItems
    {
        private List<Models.CreateBundleResponseDataItemsCardsItems> cards;
        private string dayTimeRestrictionProfileId;
        private string locationRestrictionProfileId;
        private string productRestrictionProfileId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Cards", false },
            { "DayTimeRestrictionProfileId", false },
            { "LocationRestrictionProfileId", false },
            { "ProductRestrictionProfileId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponseDataItems"/> class.
        /// </summary>
        public CreateBundleResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponseDataItems"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="dayTimeRestrictionProfileId">DayTimeRestrictionProfileId.</param>
        /// <param name="locationRestrictionProfileId">LocationRestrictionProfileId.</param>
        /// <param name="productRestrictionProfileId">ProductRestrictionProfileId.</param>
        public CreateBundleResponseDataItems(
            string bundleId = null,
            List<Models.CreateBundleResponseDataItemsCardsItems> cards = null,
            string dayTimeRestrictionProfileId = null,
            string locationRestrictionProfileId = null,
            string productRestrictionProfileId = null)
        {
            this.BundleId = bundleId;
            if (cards != null)
            {
                this.Cards = cards;
            }

            if (dayTimeRestrictionProfileId != null)
            {
                this.DayTimeRestrictionProfileId = dayTimeRestrictionProfileId;
            }

            if (locationRestrictionProfileId != null)
            {
                this.LocationRestrictionProfileId = locationRestrictionProfileId;
            }

            if (productRestrictionProfileId != null)
            {
                this.ProductRestrictionProfileId = productRestrictionProfileId;
            }

        }

        /// <summary>
        /// Identifier of the newly created bundle in Gateway.
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// List of product restriction requests validated and submitted successfully for each card.
        /// </summary>
        [JsonProperty("Cards")]
        public List<Models.CreateBundleResponseDataItemsCardsItems> Cards
        {
            get
            {
                return this.cards;
            }

            set
            {
                this.shouldSerialize["Cards"] = true;
                this.cards = value;
            }
        }

        /// <summary>
        /// Identifier of the day/time restriction profile created for the bundle in Gateway.
        /// This will be null if respective action is passed as “Default”.
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
        /// Identifier of the location restriction profile created for the bundle in Gateway.
        /// This will be null if respective action is passed as “Default”.
        /// </summary>
        [JsonProperty("LocationRestrictionProfileId")]
        public string LocationRestrictionProfileId
        {
            get
            {
                return this.locationRestrictionProfileId;
            }

            set
            {
                this.shouldSerialize["LocationRestrictionProfileId"] = true;
                this.locationRestrictionProfileId = value;
            }
        }

        /// <summary>
        /// Identifier of the location restriction profile created for the bundle in Gateway.
        /// This will be null if respective action is passed as “Default”.
        /// </summary>
        [JsonProperty("ProductRestrictionProfileId")]
        public string ProductRestrictionProfileId
        {
            get
            {
                return this.productRestrictionProfileId;
            }

            set
            {
                this.shouldSerialize["ProductRestrictionProfileId"] = true;
                this.productRestrictionProfileId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateBundleResponseDataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCards()
        {
            this.shouldSerialize["Cards"] = false;
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
        public void UnsetLocationRestrictionProfileId()
        {
            this.shouldSerialize["LocationRestrictionProfileId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductRestrictionProfileId()
        {
            this.shouldSerialize["ProductRestrictionProfileId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCards()
        {
            return this.shouldSerialize["Cards"];
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
        public bool ShouldSerializeLocationRestrictionProfileId()
        {
            return this.shouldSerialize["LocationRestrictionProfileId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductRestrictionProfileId()
        {
            return this.shouldSerialize["ProductRestrictionProfileId"];
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
            return obj is CreateBundleResponseDataItems other &&                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.DayTimeRestrictionProfileId == null && other.DayTimeRestrictionProfileId == null) || (this.DayTimeRestrictionProfileId?.Equals(other.DayTimeRestrictionProfileId) == true)) &&
                ((this.LocationRestrictionProfileId == null && other.LocationRestrictionProfileId == null) || (this.LocationRestrictionProfileId?.Equals(other.LocationRestrictionProfileId) == true)) &&
                ((this.ProductRestrictionProfileId == null && other.ProductRestrictionProfileId == null) || (this.ProductRestrictionProfileId?.Equals(other.ProductRestrictionProfileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.DayTimeRestrictionProfileId = {(this.DayTimeRestrictionProfileId == null ? "null" : this.DayTimeRestrictionProfileId)}");
            toStringOutput.Add($"this.LocationRestrictionProfileId = {(this.LocationRestrictionProfileId == null ? "null" : this.LocationRestrictionProfileId)}");
            toStringOutput.Add($"this.ProductRestrictionProfileId = {(this.ProductRestrictionProfileId == null ? "null" : this.ProductRestrictionProfileId)}");
        }
    }
}
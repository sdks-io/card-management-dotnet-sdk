// <copyright file="SummaryOfBundleResponseDataItemsCardBundlesItems.cs" company="APIMatic">
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
    /// SummaryOfBundleResponseDataItemsCardBundlesItems.
    /// </summary>
    public class SummaryOfBundleResponseDataItemsCardBundlesItems
    {
        private string bundleId;
        private string externalBundleId;
        private string description;
        private int? totalCards;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "BundleId", false },
            { "ExternalBundleId", false },
            { "Description", false },
            { "TotalCards", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryOfBundleResponseDataItemsCardBundlesItems"/> class.
        /// </summary>
        public SummaryOfBundleResponseDataItemsCardBundlesItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryOfBundleResponseDataItemsCardBundlesItems"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="externalBundleId">ExternalBundleId.</param>
        /// <param name="description">Description.</param>
        /// <param name="totalCards">TotalCards.</param>
        public SummaryOfBundleResponseDataItemsCardBundlesItems(
            string bundleId = null,
            string externalBundleId = null,
            string description = null,
            int? totalCards = null)
        {
            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }

            if (externalBundleId != null)
            {
                this.ExternalBundleId = externalBundleId;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (totalCards != null)
            {
                this.TotalCards = totalCards;
            }

        }

        /// <summary>
        /// Gateway assigned unique identifier for the Card Bundle.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId
        {
            get
            {
                return this.bundleId;
            }

            set
            {
                this.shouldSerialize["BundleId"] = true;
                this.bundleId = value;
            }
        }

        /// <summary>
        /// External system allocated Card Bundle identifier for Card Bundle.
        /// </summary>
        [JsonProperty("ExternalBundleId")]
        public string ExternalBundleId
        {
            get
            {
                return this.externalBundleId;
            }

            set
            {
                this.shouldSerialize["ExternalBundleId"] = true;
                this.externalBundleId = value;
            }
        }

        /// <summary>
        /// Card Bundle Description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["Description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// No of Card PAN added to the card bundle.
        /// </summary>
        [JsonProperty("TotalCards")]
        public int? TotalCards
        {
            get
            {
                return this.totalCards;
            }

            set
            {
                this.shouldSerialize["TotalCards"] = true;
                this.totalCards = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SummaryOfBundleResponseDataItemsCardBundlesItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExternalBundleId()
        {
            this.shouldSerialize["ExternalBundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["Description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalCards()
        {
            this.shouldSerialize["TotalCards"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExternalBundleId()
        {
            return this.shouldSerialize["ExternalBundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["Description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCards()
        {
            return this.shouldSerialize["TotalCards"];
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
            return obj is SummaryOfBundleResponseDataItemsCardBundlesItems other &&                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.ExternalBundleId == null && other.ExternalBundleId == null) || (this.ExternalBundleId?.Equals(other.ExternalBundleId) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.TotalCards == null && other.TotalCards == null) || (this.TotalCards?.Equals(other.TotalCards) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.ExternalBundleId = {(this.ExternalBundleId == null ? "null" : this.ExternalBundleId)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.TotalCards = {(this.TotalCards == null ? "null" : this.TotalCards.ToString())}");
        }
    }
}
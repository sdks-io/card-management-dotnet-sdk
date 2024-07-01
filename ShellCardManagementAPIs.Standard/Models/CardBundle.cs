// <copyright file="CardBundle.cs" company="APIMatic">
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
    /// CardBundle.
    /// </summary>
    public class CardBundle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardBundle"/> class.
        /// </summary>
        public CardBundle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardBundle"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="externalBundleId">ExternalBundleId.</param>
        /// <param name="description">Description.</param>
        /// <param name="totalCards">TotalCards.</param>
        public CardBundle(
            string bundleId = null,
            string externalBundleId = null,
            string description = null,
            int? totalCards = null)
        {
            this.BundleId = bundleId;
            this.ExternalBundleId = externalBundleId;
            this.Description = description;
            this.TotalCards = totalCards;
        }

        /// <summary>
        /// Unique identifier for the Card Bundle
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// External system allocated Card Bundle identifier for Card Bundle.
        /// </summary>
        [JsonProperty("ExternalBundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalBundleId { get; set; }

        /// <summary>
        /// DescriptionCard Bundle Description.
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// No of Card PAN added to the card bundle.
        /// </summary>
        [JsonProperty("TotalCards", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCards { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardBundle : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardBundle other &&                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
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
// <copyright file="LocationRestriction.cs" company="APIMatic">
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
    /// LocationRestriction.
    /// </summary>
    public class LocationRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestriction"/> class.
        /// </summary>
        public LocationRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestriction"/> class.
        /// </summary>
        /// <param name="countryRestrictions">CountryRestrictions.</param>
        /// <param name="networkRestrictions">NetworkRestrictions.</param>
        /// <param name="shellSiteRestrictions">ShellSiteRestrictions.</param>
        /// <param name="partnerSiteRestrictions">PartnerSiteRestrictions.</param>
        public LocationRestriction(
            Models.CountryRestriction countryRestrictions = null,
            List<Models.NetworkRestriction> networkRestrictions = null,
            List<Models.ShellSiteRestriction> shellSiteRestrictions = null,
            List<Models.PartnerSiteRestriction> partnerSiteRestrictions = null)
        {
            this.CountryRestrictions = countryRestrictions;
            this.NetworkRestrictions = networkRestrictions;
            this.ShellSiteRestrictions = shellSiteRestrictions;
            this.PartnerSiteRestrictions = partnerSiteRestrictions;
        }

        /// <summary>
        /// Gets or sets CountryRestrictions.
        /// </summary>
        [JsonProperty("CountryRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CountryRestriction CountryRestrictions { get; set; }

        /// <summary>
        /// Gets or sets NetworkRestrictions.
        /// </summary>
        [JsonProperty("NetworkRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NetworkRestriction> NetworkRestrictions { get; set; }

        /// <summary>
        /// Gets or sets ShellSiteRestrictions.
        /// </summary>
        [JsonProperty("ShellSiteRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ShellSiteRestriction> ShellSiteRestrictions { get; set; }

        /// <summary>
        /// Gets or sets PartnerSiteRestrictions.
        /// </summary>
        [JsonProperty("PartnerSiteRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PartnerSiteRestriction> PartnerSiteRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationRestriction : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationRestriction other &&                ((this.CountryRestrictions == null && other.CountryRestrictions == null) || (this.CountryRestrictions?.Equals(other.CountryRestrictions) == true)) &&
                ((this.NetworkRestrictions == null && other.NetworkRestrictions == null) || (this.NetworkRestrictions?.Equals(other.NetworkRestrictions) == true)) &&
                ((this.ShellSiteRestrictions == null && other.ShellSiteRestrictions == null) || (this.ShellSiteRestrictions?.Equals(other.ShellSiteRestrictions) == true)) &&
                ((this.PartnerSiteRestrictions == null && other.PartnerSiteRestrictions == null) || (this.PartnerSiteRestrictions?.Equals(other.PartnerSiteRestrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CountryRestrictions = {(this.CountryRestrictions == null ? "null" : this.CountryRestrictions.ToString())}");
            toStringOutput.Add($"this.NetworkRestrictions = {(this.NetworkRestrictions == null ? "null" : $"[{string.Join(", ", this.NetworkRestrictions)} ]")}");
            toStringOutput.Add($"this.ShellSiteRestrictions = {(this.ShellSiteRestrictions == null ? "null" : $"[{string.Join(", ", this.ShellSiteRestrictions)} ]")}");
            toStringOutput.Add($"this.PartnerSiteRestrictions = {(this.PartnerSiteRestrictions == null ? "null" : $"[{string.Join(", ", this.PartnerSiteRestrictions)} ]")}");
        }
    }
}
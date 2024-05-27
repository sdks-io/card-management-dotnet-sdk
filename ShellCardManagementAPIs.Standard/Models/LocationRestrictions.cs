// <copyright file="LocationRestrictions.cs" company="APIMatic">
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
    /// LocationRestrictions.
    /// </summary>
    public class LocationRestrictions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictions"/> class.
        /// </summary>
        public LocationRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictions"/> class.
        /// </summary>
        /// <param name="countryRestrictions">CountryRestrictions.</param>
        /// <param name="networkRestrictions">NetworkRestrictions.</param>
        /// <param name="shellSiteRestrictions">ShellSiteRestrictions.</param>
        /// <param name="partnerSiteRestrictions">PartnerSiteRestrictions.</param>
        public LocationRestrictions(
            Models.LocationRestrictionsCountryRestrictions countryRestrictions = null,
            List<Models.LocationRestrictionsNetworkRestrictionsItems> networkRestrictions = null,
            List<Models.LocationRestrictionsShellSiteRestrictionsItems> shellSiteRestrictions = null,
            List<Models.LocationRestrictionsPartnerSiteRestrictionsItems> partnerSiteRestrictions = null)
        {
            this.CountryRestrictions = countryRestrictions;
            this.NetworkRestrictions = networkRestrictions;
            this.ShellSiteRestrictions = shellSiteRestrictions;
            this.PartnerSiteRestrictions = partnerSiteRestrictions;
        }

        /// <summary>
        /// An entity that encapsulate the country restrictions.
        /// Optional.
        /// </summary>
        [JsonProperty("CountryRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationRestrictionsCountryRestrictions CountryRestrictions { get; set; }

        /// <summary>
        /// A list of NetworkRestriction entity. Each item in the list encapsulates a network restriction in a given country.
        /// Optional.
        /// The details of the entity are described below:
        /// </summary>
        [JsonProperty("NetworkRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LocationRestrictionsNetworkRestrictionsItems> NetworkRestrictions { get; set; }

        /// <summary>
        /// A list of ShellSiteRestriction entity. Each item in the list encapsulates a site restriction of Shell network in a given country.
        /// Optional.
        /// The details of the entity are described below.
        /// </summary>
        [JsonProperty("ShellSiteRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LocationRestrictionsShellSiteRestrictionsItems> ShellSiteRestrictions { get; set; }

        /// <summary>
        /// A list of PartnerSiteRestriction entity. Each item in the list encapsulates a site restriction of a given partner network.
        /// Optional.
        /// The details of the entity are described below.
        /// </summary>
        [JsonProperty("PartnerSiteRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LocationRestrictionsPartnerSiteRestrictionsItems> PartnerSiteRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationRestrictions : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationRestrictions other &&                ((this.CountryRestrictions == null && other.CountryRestrictions == null) || (this.CountryRestrictions?.Equals(other.CountryRestrictions) == true)) &&
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
// <copyright file="ShellSiteRestriction.cs" company="APIMatic">
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
    /// ShellSiteRestriction.
    /// </summary>
    public class ShellSiteRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShellSiteRestriction"/> class.
        /// </summary>
        public ShellSiteRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellSiteRestriction"/> class.
        /// </summary>
        /// <param name="country">Country.</param>
        /// <param name="sites">Sites.</param>
        /// <param name="siteGroups">SiteGroups.</param>
        /// <param name="exclusive">Exclusive.</param>
        public ShellSiteRestriction(
            string country = null,
            List<string> sites = null,
            List<string> siteGroups = null,
            bool? exclusive = null)
        {
            this.Country = country;
            this.Sites = sites;
            this.SiteGroups = siteGroups;
            this.Exclusive = exclusive;
        }

        /// <summary>
        /// ISO 3166-1 Numeric-3 code of the country where the site restriction is applied.
        /// Example: 826 for United Kingdom.
        /// </summary>
        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// A list of Site IDs in this country, in the format “AA1111” where “AA” is a 2-character country code and “1111” is a 4-digit site number in that country, which is either restricted or allowed.
        /// For example, “GB1234”.
        /// </summary>
        [JsonProperty("Sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sites { get; set; }

        /// <summary>
        /// A list of site group ids in this country which is either restricted or allowed.
        /// </summary>
        [JsonProperty("SiteGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SiteGroups { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Flag indicates whether the profile is inclusive or exclusive.
        /// Example: False - (inclusive), i.e. the “Sites” & “SiteGroups” properties lists the sites & site groups where the transaction will be allowed.
        /// True - (exclusive), i.e. the “Sites” & “SiteGroups” properties lists the sites and site groups where the transactions will be declined.
        /// ]]>
        /// </summary>
        [JsonProperty("Exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclusive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShellSiteRestriction : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShellSiteRestriction other &&                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Sites == null && other.Sites == null) || (this.Sites?.Equals(other.Sites) == true)) &&
                ((this.SiteGroups == null && other.SiteGroups == null) || (this.SiteGroups?.Equals(other.SiteGroups) == true)) &&
                ((this.Exclusive == null && other.Exclusive == null) || (this.Exclusive?.Equals(other.Exclusive) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Sites = {(this.Sites == null ? "null" : $"[{string.Join(", ", this.Sites)} ]")}");
            toStringOutput.Add($"this.SiteGroups = {(this.SiteGroups == null ? "null" : $"[{string.Join(", ", this.SiteGroups)} ]")}");
            toStringOutput.Add($"this.Exclusive = {(this.Exclusive == null ? "null" : this.Exclusive.ToString())}");
        }
    }
}
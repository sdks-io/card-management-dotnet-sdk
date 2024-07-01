// <copyright file="PartnerSiteRestriction.cs" company="APIMatic">
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
    /// PartnerSiteRestriction.
    /// </summary>
    public class PartnerSiteRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerSiteRestriction"/> class.
        /// </summary>
        public PartnerSiteRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerSiteRestriction"/> class.
        /// </summary>
        /// <param name="networkCode">NetworkCode.</param>
        /// <param name="sites">Sites.</param>
        /// <param name="siteGroups">SiteGroups.</param>
        /// <param name="exclusive">Exclusive.</param>
        public PartnerSiteRestriction(
            string networkCode = null,
            List<string> sites = null,
            List<string> siteGroups = null,
            bool? exclusive = null)
        {
            this.NetworkCode = networkCode;
            this.Sites = sites;
            this.SiteGroups = siteGroups;
            this.Exclusive = exclusive;
        }

        /// <summary>
        /// Gateway network codes, typically 7 or 10 digits, where sites and site groups belong to.
        /// Example: 0002003250
        /// </summary>
        [JsonProperty("NetworkCode", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkCode { get; set; }

        /// <summary>
        /// A list of Site IDs in this network which needs to be either restricted or allowed.
        /// For example, 97123, 97155
        /// A list of values must be passed for either Sites or SiteGroups or both.
        /// Max 10 sites are allowed for the Partner site Restriction.
        /// </summary>
        [JsonProperty("Sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sites { get; set; }

        /// <summary>
        /// A list of site group ids in this network which needs to be either restricted or allowed.
        /// For example, 83649200
        /// A list of values must be passed for either Sites or SiteGroups or both.
        /// Max 10 sites groups are allowed for the Partner site Restriction.
        /// </summary>
        [JsonProperty("SiteGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SiteGroups { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Flag indicates whether the profile is inclusive or exclusive.
        /// Mandatory
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

            return $"PartnerSiteRestriction : ({string.Join(", ", toStringOutput)})";
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
            return obj is PartnerSiteRestriction other &&                ((this.NetworkCode == null && other.NetworkCode == null) || (this.NetworkCode?.Equals(other.NetworkCode) == true)) &&
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
            toStringOutput.Add($"this.NetworkCode = {(this.NetworkCode == null ? "null" : this.NetworkCode)}");
            toStringOutput.Add($"this.Sites = {(this.Sites == null ? "null" : $"[{string.Join(", ", this.Sites)} ]")}");
            toStringOutput.Add($"this.SiteGroups = {(this.SiteGroups == null ? "null" : $"[{string.Join(", ", this.SiteGroups)} ]")}");
            toStringOutput.Add($"this.Exclusive = {(this.Exclusive == null ? "null" : this.Exclusive.ToString())}");
        }
    }
}
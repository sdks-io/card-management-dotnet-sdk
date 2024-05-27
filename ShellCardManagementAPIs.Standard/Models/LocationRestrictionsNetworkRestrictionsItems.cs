// <copyright file="LocationRestrictionsNetworkRestrictionsItems.cs" company="APIMatic">
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
    /// LocationRestrictionsNetworkRestrictionsItems.
    /// </summary>
    public class LocationRestrictionsNetworkRestrictionsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictionsNetworkRestrictionsItems"/> class.
        /// </summary>
        public LocationRestrictionsNetworkRestrictionsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictionsNetworkRestrictionsItems"/> class.
        /// </summary>
        /// <param name="country">Country.</param>
        /// <param name="exclusive">Exclusive.</param>
        /// <param name="networks">Networks.</param>
        public LocationRestrictionsNetworkRestrictionsItems(
            string country,
            bool exclusive,
            List<string> networks = null)
        {
            this.Country = country;
            this.Exclusive = exclusive;
            this.Networks = networks;
        }

        /// <summary>
        /// ISO 3166-1 Numeric-3 code of the country where the network restriction is applied.
        /// Example: 826 for United Kingdom.
        /// Mandatory
        /// </summary>
        [JsonProperty("Country")]
        public string Country { get; set; }

        /// <summary>
        /// Flag indicates whether the profile is inclusive or exclusive.
        /// Mandatory
        /// Example: False - (inclusive), i.e. the “Networks” property lists the networks in which the transaction will be allowed.
        /// True - (exclusive), i.e. the “Networks” property lists the networks in which the transactions will be declined.
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool Exclusive { get; set; }

        /// <summary>
        /// A list of Gateway network codes, typically 7 or 10 digits.
        /// Example: 0002003250
        /// </summary>
        [JsonProperty("Networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Networks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationRestrictionsNetworkRestrictionsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationRestrictionsNetworkRestrictionsItems other &&                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                this.Exclusive.Equals(other.Exclusive) &&
                ((this.Networks == null && other.Networks == null) || (this.Networks?.Equals(other.Networks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Exclusive = {this.Exclusive}");
            toStringOutput.Add($"this.Networks = {(this.Networks == null ? "null" : $"[{string.Join(", ", this.Networks)} ]")}");
        }
    }
}
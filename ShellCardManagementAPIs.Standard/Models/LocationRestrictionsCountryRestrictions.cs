// <copyright file="LocationRestrictionsCountryRestrictions.cs" company="APIMatic">
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
    /// LocationRestrictionsCountryRestrictions.
    /// </summary>
    public class LocationRestrictionsCountryRestrictions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictionsCountryRestrictions"/> class.
        /// </summary>
        public LocationRestrictionsCountryRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRestrictionsCountryRestrictions"/> class.
        /// </summary>
        /// <param name="exclusive">Exclusive.</param>
        /// <param name="countries">Countries.</param>
        public LocationRestrictionsCountryRestrictions(
            bool exclusive,
            List<string> countries)
        {
            this.Exclusive = exclusive;
            this.Countries = countries;
        }

        /// <summary>
        /// Boolean	Flag indicates whether the profile is inclusive or exclusive.
        /// Mandatory
        /// Example: False - (inclusive), i.e. the “Countries” property lists the countries where the transactions will be allowed.
        /// True - (exclusive), i.e. the “Countries” property lists the countries where the transactions will be declined.
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool Exclusive { get; set; }

        /// <summary>
        /// ISO 3166-1 Numeric-3 code of the country where the network restriction is applied.
        /// Example: 826 for United Kingdom.
        /// Mandatory
        /// </summary>
        [JsonProperty("Countries")]
        public List<string> Countries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationRestrictionsCountryRestrictions : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationRestrictionsCountryRestrictions other &&                this.Exclusive.Equals(other.Exclusive) &&
                ((this.Countries == null && other.Countries == null) || (this.Countries?.Equals(other.Countries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Exclusive = {this.Exclusive}");
            toStringOutput.Add($"this.Countries = {(this.Countries == null ? "null" : $"[{string.Join(", ", this.Countries)} ]")}");
        }
    }
}
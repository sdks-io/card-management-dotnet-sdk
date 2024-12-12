// <copyright file="CountryRestriction.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellCardManagementAPIs.Standard.Models
{
    /// <summary>
    /// CountryRestriction.
    /// </summary>
    public class CountryRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRestriction"/> class.
        /// </summary>
        public CountryRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRestriction"/> class.
        /// </summary>
        /// <param name="countries">Countries.</param>
        /// <param name="exclusive">Exclusive.</param>
        public CountryRestriction(
            List<string> countries = null,
            bool? exclusive = null)
        {
            this.Countries = countries;
            this.Exclusive = exclusive;
        }

        /// <summary>
        /// A list of ISO 3166-1 Numeric-3 country codes.
        /// Example: 826 for United Kingdom.
        /// </summary>
        [JsonProperty("Countries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Flag indicates whether the profile is inclusive or exclusive.
        /// Example: False - (inclusive), i.e. the “Countries” property lists the countries where the transactions will be allowed.
        /// True - (exclusive), i.e. the “Countries” property lists the countries where the transactions will be declined.
        /// </summary>
        [JsonProperty("Exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclusive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CountryRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CountryRestriction other &&
                (this.Countries == null && other.Countries == null ||
                 this.Countries?.Equals(other.Countries) == true) &&
                (this.Exclusive == null && other.Exclusive == null ||
                 this.Exclusive?.Equals(other.Exclusive) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Countries = {(this.Countries == null ? "null" : $"[{string.Join(", ", this.Countries)} ]")}");
            toStringOutput.Add($"this.Exclusive = {(this.Exclusive == null ? "null" : this.Exclusive.ToString())}");
        }
    }
}
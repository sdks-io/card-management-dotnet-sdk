// <copyright file="NetworkRestriction.cs" company="APIMatic">
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
    /// NetworkRestriction.
    /// </summary>
    public class NetworkRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestriction"/> class.
        /// </summary>
        public NetworkRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestriction"/> class.
        /// </summary>
        /// <param name="country">Country.</param>
        /// <param name="networks">Networks.</param>
        /// <param name="exclusive">Exclusive.</param>
        public NetworkRestriction(
            string country = null,
            List<string> networks = null,
            bool? exclusive = null)
        {
            this.Country = country;
            this.Networks = networks;
            this.Exclusive = exclusive;
        }

        /// <summary>
        /// ISO 3166-1 Numeric-3 code of the country where the network restriction is applied.
        /// Example: 826 for United Kingdom.
        /// </summary>
        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// A list of Gateway network codes, typically 7 or 10 digits.
        /// Example: 0002003250
        /// </summary>
        [JsonProperty("Networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Networks { get; set; }

        /// <summary>
        /// Flag indicates whether the profile is inclusive or exclusive.
        /// Example: False - (inclusive), i.e. the “Networks” property lists the networks in which the transaction will be allowed.
        /// True - (exclusive), i.e. the “Networks” property lists the networks in which the transactions will be declined.
        /// </summary>
        [JsonProperty("Exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclusive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkRestriction other &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.Networks == null && other.Networks == null ||
                 this.Networks?.Equals(other.Networks) == true) &&
                (this.Exclusive == null && other.Exclusive == null ||
                 this.Exclusive?.Equals(other.Exclusive) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Networks = {(this.Networks == null ? "null" : $"[{string.Join(", ", this.Networks)} ]")}");
            toStringOutput.Add($"Exclusive = {(this.Exclusive == null ? "null" : this.Exclusive.ToString())}");
        }
    }
}
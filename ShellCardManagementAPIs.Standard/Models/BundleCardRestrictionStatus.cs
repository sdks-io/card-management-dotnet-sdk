// <copyright file="BundleCardRestrictionStatus.cs" company="APIMatic">
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
    /// BundleCardRestrictionStatus.
    /// </summary>
    public class BundleCardRestrictionStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleCardRestrictionStatus"/> class.
        /// </summary>
        public BundleCardRestrictionStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleCardRestrictionStatus"/> class.
        /// </summary>
        /// <param name="pAN">PAN.</param>
        public BundleCardRestrictionStatus(
            string pAN = null)
        {
            this.PAN = pAN;
        }

        /// <summary>
        /// Card PAN.
        /// Example: 7002051006629890645
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BundleCardRestrictionStatus : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BundleCardRestrictionStatus other &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
        }
    }
}
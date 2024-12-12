// <copyright file="RestrictionProduct.cs" company="APIMatic">
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
    /// RestrictionProduct.
    /// </summary>
    public class RestrictionProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionProduct"/> class.
        /// </summary>
        public RestrictionProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionProduct"/> class.
        /// </summary>
        /// <param name="globalProductCode">GlobalProductCode.</param>
        /// <param name="description">Description.</param>
        public RestrictionProduct(
            string globalProductCode = null,
            string description = null)
        {
            this.GlobalProductCode = globalProductCode;
            this.Description = description;
        }

        /// <summary>
        /// The productCode returned by the Gateway API.
        /// Example: 021
        /// </summary>
        [JsonProperty("GlobalProductCode", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalProductCode { get; set; }

        /// <summary>
        /// The description returned by the Gateway API.
        /// Example: High Performance Diesel
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RestrictionProduct : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RestrictionProduct other &&
                (this.GlobalProductCode == null && other.GlobalProductCode == null ||
                 this.GlobalProductCode?.Equals(other.GlobalProductCode) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GlobalProductCode = {this.GlobalProductCode ?? "null"}");
            toStringOutput.Add($"this.Description = {this.Description ?? "null"}");
        }
    }
}
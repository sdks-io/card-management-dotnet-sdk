// <copyright file="ProductAllOf0.cs" company="APIMatic">
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
    /// ProductAllOf0.
    /// </summary>
    public class ProductAllOf0
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAllOf0"/> class.
        /// </summary>
        public ProductAllOf0()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAllOf0"/> class.
        /// </summary>
        /// <param name="globalProductCode">GlobalProductCode.</param>
        /// <param name="description">Description.</param>
        public ProductAllOf0(
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
        [JsonProperty("GlobalProductCode", NullValueHandling = NullValueHandling.Include)]
        public string GlobalProductCode { get; set; }

        /// <summary>
        /// The description returned by the Gateway API.
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProductAllOf0 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProductAllOf0 other &&                ((this.GlobalProductCode == null && other.GlobalProductCode == null) || (this.GlobalProductCode?.Equals(other.GlobalProductCode) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GlobalProductCode = {(this.GlobalProductCode == null ? "null" : this.GlobalProductCode)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}
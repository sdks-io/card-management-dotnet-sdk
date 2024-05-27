// <copyright file="ProductRestrictions.cs" company="APIMatic">
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
    /// ProductRestrictions.
    /// </summary>
    public class ProductRestrictions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRestrictions"/> class.
        /// </summary>
        public ProductRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRestrictions"/> class.
        /// </summary>
        /// <param name="products">Products.</param>
        /// <param name="productGroups">ProductGroups.</param>
        public ProductRestrictions(
            List<string> products = null,
            List<string> productGroups = null)
        {
            this.Products = products;
            this.ProductGroups = productGroups;
        }

        /// <summary>
        /// An array of 3-digit global product codes.
        /// Optional. However, this field is mandatory when the Product restrictions are migrated to Gateway and Product Groups are not provided.
        /// Example: [ "033", "021", "023" ]
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Products { get; set; }

        /// <summary>
        /// An array of product group ids.
        /// Optional. However, this field is mandatory when the Product restrictions are migrated to Gateway and Products are not provided.
        /// Example: [ "670246404", "40557126" ]
        /// </summary>
        [JsonProperty("ProductGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductGroups { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProductRestrictions : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProductRestrictions other &&                ((this.Products == null && other.Products == null) || (this.Products?.Equals(other.Products) == true)) &&
                ((this.ProductGroups == null && other.ProductGroups == null) || (this.ProductGroups?.Equals(other.ProductGroups) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
            toStringOutput.Add($"this.ProductGroups = {(this.ProductGroups == null ? "null" : $"[{string.Join(", ", this.ProductGroups)} ]")}");
        }
    }
}
// <copyright file="ProductGroup.cs" company="APIMatic">
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
    /// ProductGroup.
    /// </summary>
    public class ProductGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductGroup"/> class.
        /// </summary>
        public ProductGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductGroup"/> class.
        /// </summary>
        /// <param name="referenceId">ReferenceId.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="name">Name.</param>
        /// <param name="isDefault">IsDefault.</param>
        /// <param name="isFuelType">IsFuelType.</param>
        /// <param name="products">Products.</param>
        public ProductGroup(
            int? referenceId = null,
            string productGroupId = null,
            string name = null,
            bool? isDefault = null,
            bool? isFuelType = null,
            List<Models.ProductAllOf0> products = null)
        {
            this.ReferenceId = referenceId;
            this.ProductGroupId = productGroupId;
            this.Name = name;
            this.IsDefault = isDefault;
            this.IsFuelType = isFuelType;
            this.Products = products;
        }

        /// <summary>
        /// Referenced Purchase Category Id
        /// Example: 123, 124
        /// </summary>
        [JsonProperty("ReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Product group ID
        /// </summary>
        [JsonProperty("ProductGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductGroupId { get; set; }

        /// <summary>
        /// Product group name
        /// </summary>
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this is a default Product Group at ColCo level or not.
        /// Note: The Customer level default settings are not considered here.
        /// </summary>
        [JsonProperty("IsDefault", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Identifies the type of Product group.
        /// true - if it is a Fuel type Product group
        /// false - if it is Non-Fuel type
        /// </summary>
        [JsonProperty("IsFuelType", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFuelType { get; set; }

        /// <summary>
        /// Gets or sets Products.
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProductAllOf0> Products { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProductGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProductGroup other &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true) &&
                (this.ProductGroupId == null && other.ProductGroupId == null ||
                 this.ProductGroupId?.Equals(other.ProductGroupId) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.IsDefault == null && other.IsDefault == null ||
                 this.IsDefault?.Equals(other.IsDefault) == true) &&
                (this.IsFuelType == null && other.IsFuelType == null ||
                 this.IsFuelType?.Equals(other.IsFuelType) == true) &&
                (this.Products == null && other.Products == null ||
                 this.Products?.Equals(other.Products) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId.ToString())}");
            toStringOutput.Add($"this.ProductGroupId = {this.ProductGroupId ?? "null"}");
            toStringOutput.Add($"this.Name = {this.Name ?? "null"}");
            toStringOutput.Add($"this.IsDefault = {(this.IsDefault == null ? "null" : this.IsDefault.ToString())}");
            toStringOutput.Add($"this.IsFuelType = {(this.IsFuelType == null ? "null" : this.IsFuelType.ToString())}");
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
        }
    }
}
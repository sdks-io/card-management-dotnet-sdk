// <copyright file="BundledDetailsProductList.cs" company="APIMatic">
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
    /// BundledDetailsProductList.
    /// </summary>
    public class BundledDetailsProductList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundledDetailsProductList"/> class.
        /// </summary>
        public BundledDetailsProductList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundledDetailsProductList"/> class.
        /// </summary>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="products">Products.</param>
        /// <param name="productGroups">ProductGroups.</param>
        /// <param name="fuelSetId">FuelSetId.</param>
        /// <param name="fuelSetName">FuelSetName.</param>
        /// <param name="nonFuelSets">NonFuelSets.</param>
        public BundledDetailsProductList(
            int? purchaseCategoryId = null,
            string purchaseCategoryCode = null,
            List<string> products = null,
            List<string> productGroups = null,
            string fuelSetId = null,
            string fuelSetName = null,
            string nonFuelSets = null)
        {
            this.PurchaseCategoryId = purchaseCategoryId;
            this.PurchaseCategoryCode = purchaseCategoryCode;
            this.Products = products;
            this.ProductGroups = productGroups;
            this.FuelSetId = fuelSetId;
            this.FuelSetName = fuelSetName;
            this.NonFuelSets = nonFuelSets;
        }

        /// <summary>
        /// Purchase category Id
        /// Example: 123, 124, etc.,
        /// </summary>
        [JsonProperty("PurchaseCategoryId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseCategoryId { get; set; }

        /// <summary>
        /// Purchase category name.
        /// Example:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - FuelSave only
        /// 2 - FuelSave and Lubricants
        /// 3 - No Restrictions
        /// </summary>
        [JsonProperty("PurchaseCategoryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseCategoryCode { get; set; }

        /// <summary>
        /// An array of 3-digit global product codes.
        /// Example: [ "033", "021", "023" ]
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Products { get; set; }

        /// <summary>
        /// An array of product group ids.
        /// Example: [ "670246404", "40557126" ]
        /// </summary>
        [JsonProperty("ProductGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductGroups { get; set; }

        /// <summary>
        /// Fuel set id that is allowed to be purchased with the card
        /// </summary>
        [JsonProperty("FuelSetId", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelSetId { get; set; }

        /// <summary>
        /// Fuel set name that is allowed to be purchased with the card
        /// </summary>
        [JsonProperty("FuelSetName", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelSetName { get; set; }

        /// <summary>
        /// Non-Fuel set name that is allowed to be purchased with the card
        /// </summary>
        [JsonProperty("NonFuelSets", NullValueHandling = NullValueHandling.Ignore)]
        public string NonFuelSets { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BundledDetailsProductList : ({string.Join(", ", toStringOutput)})";
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
            return obj is BundledDetailsProductList other &&                ((this.PurchaseCategoryId == null && other.PurchaseCategoryId == null) || (this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.Products == null && other.Products == null) || (this.Products?.Equals(other.Products) == true)) &&
                ((this.ProductGroups == null && other.ProductGroups == null) || (this.ProductGroups?.Equals(other.ProductGroups) == true)) &&
                ((this.FuelSetId == null && other.FuelSetId == null) || (this.FuelSetId?.Equals(other.FuelSetId) == true)) &&
                ((this.FuelSetName == null && other.FuelSetName == null) || (this.FuelSetName?.Equals(other.FuelSetName) == true)) &&
                ((this.NonFuelSets == null && other.NonFuelSets == null) || (this.NonFuelSets?.Equals(other.NonFuelSets) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
            toStringOutput.Add($"this.ProductGroups = {(this.ProductGroups == null ? "null" : $"[{string.Join(", ", this.ProductGroups)} ]")}");
            toStringOutput.Add($"this.FuelSetId = {(this.FuelSetId == null ? "null" : this.FuelSetId)}");
            toStringOutput.Add($"this.FuelSetName = {(this.FuelSetName == null ? "null" : this.FuelSetName)}");
            toStringOutput.Add($"this.NonFuelSets = {(this.NonFuelSets == null ? "null" : this.NonFuelSets)}");
        }
    }
}
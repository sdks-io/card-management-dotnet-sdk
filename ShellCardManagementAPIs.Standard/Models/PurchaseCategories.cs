// <copyright file="PurchaseCategories.cs" company="APIMatic">
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
    /// PurchaseCategories.
    /// </summary>
    public class PurchaseCategories
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategories"/> class.
        /// </summary>
        public PurchaseCategories()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategories"/> class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="code">Code.</param>
        /// <param name="name">Name.</param>
        /// <param name="isVisible">IsVisible.</param>
        /// <param name="productGroups">ProductGroups.</param>
        public PurchaseCategories(
            int? id = null,
            string code = null,
            string name = null,
            bool? isVisible = null,
            string productGroups = null)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.IsVisible = isVisible;
            this.ProductGroups = productGroups;
        }

        /// <summary>
        /// Purchase category Id
        /// </summary>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Purchase category code
        /// Example: 0,1, 2 etc.
        /// Full list below:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - Fuel Save only
        /// 2 - Fuel Save and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and Fuel Save
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and Fuel Save and Lubricants
        /// </summary>
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Purchase category name
        /// Example: Fuel Save Only
        /// Full list below:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - Fuel Save only
        /// 2 - Fuel Save and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and Fuel Save
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and Fuel Save and Lubricants
        /// </summary>
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// If True then PurchaseCategory can be used while submitting new order cards requests.
        /// If false this PurchaseCategory will not be used for Ordering Cards.
        /// </summary>
        [JsonProperty("IsVisible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// List of Default product groups
        /// </summary>
        [JsonProperty("ProductGroups", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductGroups { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PurchaseCategories : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PurchaseCategories other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.IsVisible == null && other.IsVisible == null ||
                 this.IsVisible?.Equals(other.IsVisible) == true) &&
                (this.ProductGroups == null && other.ProductGroups == null ||
                 this.ProductGroups?.Equals(other.ProductGroups) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"IsVisible = {(this.IsVisible == null ? "null" : this.IsVisible.ToString())}");
            toStringOutput.Add($"ProductGroups = {this.ProductGroups ?? "null"}");
        }
    }
}
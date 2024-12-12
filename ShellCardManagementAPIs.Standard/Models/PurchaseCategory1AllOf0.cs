// <copyright file="PurchaseCategory1AllOf0.cs" company="APIMatic">
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
    /// PurchaseCategory1AllOf0.
    /// </summary>
    public class PurchaseCategory1AllOf0
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategory1AllOf0"/> class.
        /// </summary>
        public PurchaseCategory1AllOf0()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategory1AllOf0"/> class.
        /// </summary>
        /// <param name="isVisible">IsVisible.</param>
        /// <param name="productGroups">ProductGroups.</param>
        /// <param name="id">Id.</param>
        /// <param name="code">Code.</param>
        /// <param name="name">Name.</param>
        /// <param name="title">Title.</param>
        /// <param name="description">Description.</param>
        public PurchaseCategory1AllOf0(
            bool isVisible,
            List<Models.ProductGroup> productGroups,
            int? id = null,
            string code = null,
            string name = null,
            string title = null,
            string description = null)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.IsVisible = isVisible;
            this.ProductGroups = productGroups;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Purchase category ID
        /// </summary>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Include)]
        public int? Id { get; set; }

        /// <summary>
        /// Purchase category code
        /// </summary>
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Include)]
        public string Code { get; set; }

        /// <summary>
        /// Name of Purchase category .
        /// </summary>
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// PurchaseCategory can be used while submitting new order cards requests if true else will not be used for ordering cards.
        /// </summary>
        [JsonProperty("IsVisible")]
        public bool IsVisible { get; set; }

        /// <summary>
        /// List of product sets
        /// </summary>
        [JsonProperty("ProductGroups")]
        public List<Models.ProductGroup> ProductGroups { get; set; }

        /// <summary>
        /// Purchase category Title by given language code.
        /// 1.    Basic
        /// 2.    Essentials
        /// 3.    Extra
        /// 4.    Premium
        /// 5.    Basic and LNG
        /// 6.    Essentials and LNG
        /// 7.    Extra and LNG
        /// 8.    Premium and LNG
        /// Note: Purchase Category name (GFN) is returned when Title does not exist for the given language Code and default language code (en-GB).
        /// </summary>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Purchase category description by given language code.
        /// Example:
        /// 0 - Diesel Products and TMF
        /// 1 - All Fuel Products and TMF
        /// 2 - All Fuels Products, Car related items and TMF
        /// 3 - No Restriction
        /// 0 - Diesel Products + LNG and TMF
        /// 1 - All Fuel Products + LNG and TMF
        /// 2 - All Fuels Products + LNG, Car related items and TMF
        /// 3 - No Restriction + LNG
        /// Note: Purchase Category name (GFN) is returned when Title does not exist for the given language Code and default language code (en-GB).
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PurchaseCategory1AllOf0 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PurchaseCategory1AllOf0 other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.IsVisible.Equals(other.IsVisible)) &&
                (this.ProductGroups == null && other.ProductGroups == null ||
                 this.ProductGroups?.Equals(other.ProductGroups) == true) &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Code = {this.Code ?? "null"}");
            toStringOutput.Add($"this.Name = {this.Name ?? "null"}");
            toStringOutput.Add($"this.IsVisible = {this.IsVisible}");
            toStringOutput.Add($"this.ProductGroups = {(this.ProductGroups == null ? "null" : $"[{string.Join(", ", this.ProductGroups)} ]")}");
            toStringOutput.Add($"this.Title = {this.Title ?? "null"}");
            toStringOutput.Add($"this.Description = {this.Description ?? "null"}");
        }
    }
}
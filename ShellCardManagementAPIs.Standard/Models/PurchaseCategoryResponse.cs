// <copyright file="PurchaseCategoryResponse.cs" company="APIMatic">
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
    /// PurchaseCategoryResponse.
    /// </summary>
    public class PurchaseCategoryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryResponse"/> class.
        /// </summary>
        public PurchaseCategoryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryResponse"/> class.
        /// </summary>
        /// <param name="purchaseCategories">PurchaseCategories.</param>
        /// <param name="error">Error.</param>
        public PurchaseCategoryResponse(
            List<Models.PurchaseCategory1AllOf0> purchaseCategories = null,
            Models.ErrorStatus error = null)
        {
            this.PurchaseCategories = purchaseCategories;
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets PurchaseCategories.
        /// </summary>
        [JsonProperty("PurchaseCategories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PurchaseCategory1AllOf0> PurchaseCategories { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PurchaseCategoryResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PurchaseCategoryResponse other &&
                (this.PurchaseCategories == null && other.PurchaseCategories == null ||
                 this.PurchaseCategories?.Equals(other.PurchaseCategories) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PurchaseCategories = {(this.PurchaseCategories == null ? "null" : $"[{string.Join(", ", this.PurchaseCategories)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
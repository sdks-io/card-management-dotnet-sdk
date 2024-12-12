// <copyright file="SearchCardRequest.cs" company="APIMatic">
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
    /// SearchCardRequest.
    /// </summary>
    public class SearchCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRequest"/> class.
        /// </summary>
        public SearchCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCardRequest"/> class.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="page">Page.</param>
        public SearchCardRequest(
            Models.Filters filters = null,
            string pageSize = null,
            string page = null)
        {
            this.Filters = filters;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("Filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Filters Filters { get; set; }

        /// <summary>
        /// Page Size – Number of records to show on a page
        /// Optional
        /// Default value 50
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SearchCardRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchCardRequest other &&
                (this.Filters == null && other.Filters == null ||
                 this.Filters?.Equals(other.Filters) == true) &&
                (this.PageSize == null && other.PageSize == null ||
                 this.PageSize?.Equals(other.PageSize) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"this.PageSize = {this.PageSize ?? "null"}");
            toStringOutput.Add($"this.Page = {this.Page ?? "null"}");
        }
    }
}
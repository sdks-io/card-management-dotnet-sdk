// <copyright file="AuditResponse.cs" company="APIMatic">
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
    /// AuditResponse.
    /// </summary>
    public class AuditResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditResponse"/> class.
        /// </summary>
        public AuditResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditResponse"/> class.
        /// </summary>
        /// <param name="audits">Audits.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="rowCount">RowCount.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public AuditResponse(
            List<Models.AuditResponseAuditsItems> audits = null,
            int? currentPage = null,
            int? rowCount = null,
            int? totalPages = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.Audits = audits;
            this.CurrentPage = currentPage;
            this.RowCount = rowCount;
            this.TotalPages = totalPages;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets Audits.
        /// </summary>
        [JsonProperty("Audits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AuditResponseAuditsItems> Audits { get; set; }

        /// <summary>
        /// Current Page
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Total row count matched for the given input criteria
        /// </summary>
        [JsonProperty("RowCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API RequestId
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AuditResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AuditResponse other &&
                (this.Audits == null && other.Audits == null ||
                 this.Audits?.Equals(other.Audits) == true) &&
                (this.CurrentPage == null && other.CurrentPage == null ||
                 this.CurrentPage?.Equals(other.CurrentPage) == true) &&
                (this.RowCount == null && other.RowCount == null ||
                 this.RowCount?.Equals(other.RowCount) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true) &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Audits = {(this.Audits == null ? "null" : $"[{string.Join(", ", this.Audits)} ]")}");
            toStringOutput.Add($"CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
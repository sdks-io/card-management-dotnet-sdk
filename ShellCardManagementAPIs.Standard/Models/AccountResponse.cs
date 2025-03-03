// <copyright file="AccountResponse.cs" company="APIMatic">
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
    /// AccountResponse.
    /// </summary>
    public class AccountResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponse"/> class.
        /// </summary>
        public AccountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponse"/> class.
        /// </summary>
        /// <param name="accounts">Accounts.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="rowCount">RowCount.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public AccountResponse(
            List<Models.AccountResponseAccountsItems> accounts = null,
            int? currentPage = null,
            int? rowCount = null,
            int? totalPages = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.Accounts = accounts;
            this.CurrentPage = currentPage;
            this.RowCount = rowCount;
            this.TotalPages = totalPages;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountResponseAccountsItems> Accounts { get; set; }

        /// <summary>
        /// current page
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Total row count matched for the given input criteria
        /// </summary>
        [JsonProperty("RowCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria.
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request ID
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountResponse other &&
                (this.Accounts == null && other.Accounts == null ||
                 this.Accounts?.Equals(other.Accounts) == true) &&
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
            toStringOutput.Add($"Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
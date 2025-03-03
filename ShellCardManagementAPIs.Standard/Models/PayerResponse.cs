// <copyright file="PayerResponse.cs" company="APIMatic">
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
    /// PayerResponse.
    /// </summary>
    public class PayerResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerResponse"/> class.
        /// </summary>
        public PayerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="payers">Payers.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="rowCount">RowCount.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="error">Error.</param>
        public PayerResponse(
            string requestId = null,
            List<Models.PayerDetails> payers = null,
            int? currentPage = null,
            int? rowCount = null,
            int? totalPages = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.Payers = payers;
            this.CurrentPage = currentPage;
            this.RowCount = rowCount;
            this.TotalPages = totalPages;
            this.Error = error;
        }

        /// <summary>
        /// Request Id of the API call
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// Gets or sets Payers.
        /// </summary>
        [JsonProperty("Payers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PayerDetails> Payers { get; set; }

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
        /// Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria. Return 1 if the page size is -1 as all records are returned
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

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
            return $"PayerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayerResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Payers == null && other.Payers == null ||
                 this.Payers?.Equals(other.Payers) == true) &&
                (this.CurrentPage == null && other.CurrentPage == null ||
                 this.CurrentPage?.Equals(other.CurrentPage) == true) &&
                (this.RowCount == null && other.RowCount == null ||
                 this.RowCount?.Equals(other.RowCount) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"Payers = {(this.Payers == null ? "null" : $"[{string.Join(", ", this.Payers)} ]")}");
            toStringOutput.Add($"CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
// <copyright file="CardSearchResponse.cs" company="APIMatic">
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
    /// CardSearchResponse.
    /// </summary>
    public class CardSearchResponse
    {
        private string requestId;
        private string status;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
            { "Status", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSearchResponse"/> class.
        /// </summary>
        public CardSearchResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSearchResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="page">Page.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="totalRecords">TotalRecords.</param>
        public CardSearchResponse(
            string requestId = null,
            string status = null,
            List<Models.Card> data = null,
            int? page = null,
            int? pageSize = null,
            int? totalPages = null,
            int? totalRecords = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            if (status != null)
            {
                this.Status = status;
            }
            this.Data = data;
            this.Page = page;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.TotalRecords = totalRecords;
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
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
        /// Indicates overall status of the request. Allowed values: SUCCES, FAILED, PARTIAL_SUCCES
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Card> Data { get; set; }

        /// <summary>
        /// Specifies the returned page of the results
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Specifies the number of records to be returned which could be less than the PageSize in the request
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies the total pages available in the result
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Specifies the total pages available in the result
        /// </summary>
        [JsonProperty("TotalRecords", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardSearchResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardSearchResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PageSize == null && other.PageSize == null ||
                 this.PageSize?.Equals(other.PageSize) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                (this.TotalRecords == null && other.TotalRecords == null ||
                 this.TotalRecords?.Equals(other.TotalRecords) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"this.Status = {this.Status ?? "null"}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
        }
    }
}
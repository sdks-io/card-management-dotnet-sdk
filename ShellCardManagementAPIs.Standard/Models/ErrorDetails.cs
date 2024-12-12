// <copyright file="ErrorDetails.cs" company="APIMatic">
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
    /// ErrorDetails.
    /// </summary>
    public class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails"/> class.
        /// </summary>
        public ErrorDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails"/> class.
        /// </summary>
        /// <param name="code">Code.</param>
        /// <param name="title">Title.</param>
        /// <param name="detail">Detail.</param>
        /// <param name="additionalInfo">AdditionalInfo.</param>
        public ErrorDetails(
            string code = null,
            string title = null,
            string detail = null,
            object additionalInfo = null)
        {
            this.Code = code;
            this.Title = title;
            this.Detail = detail;
            this.AdditionalInfo = additionalInfo;
        }

        /// <summary>
        /// Error code representing the error encountered
        /// </summary>
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Error type description
        /// </summary>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Detailed inforamtion about the error
        /// </summary>
        [JsonProperty("Detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// Applicable when more details related to error to be returned
        /// </summary>
        [JsonProperty("AdditionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public object AdditionalInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ErrorDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ErrorDetails other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Detail == null && other.Detail == null ||
                 this.Detail?.Equals(other.Detail) == true) &&
                (this.AdditionalInfo == null && other.AdditionalInfo == null ||
                 this.AdditionalInfo?.Equals(other.AdditionalInfo) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {this.Code ?? "null"}");
            toStringOutput.Add($"this.Title = {this.Title ?? "null"}");
            toStringOutput.Add($"this.Detail = {this.Detail ?? "null"}");
            toStringOutput.Add($"AdditionalInfo = {(this.AdditionalInfo == null ? "null" : this.AdditionalInfo.ToString())}");
        }
    }
}
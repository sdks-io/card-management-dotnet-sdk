// <copyright file="ErrorObjectException.cs" company="APIMatic">
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
using ShellCardManagementAPIs.Standard.Http.Client;
using ShellCardManagementAPIs.Standard.Models;
using ShellCardManagementAPIs.Standard.Utilities;

namespace ShellCardManagementAPIs.Standard.Exceptions
{
    /// <summary>
    /// ErrorObjectException.
    /// </summary>
    public class ErrorObjectException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObjectException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorObjectException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCES, FAILED, PARTIAL_SUCCESS
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("Errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ErrorDetails> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ErrorObjectException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}
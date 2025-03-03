// <copyright file="FleetmanagementV1CustomerCustomer403ErrorException.cs" company="APIMatic">
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
    /// FleetmanagementV1CustomerCustomer403ErrorException.
    /// </summary>
    public class FleetmanagementV1CustomerCustomer403ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1CustomerCustomer403ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public FleetmanagementV1CustomerCustomer403ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorUserAccessError Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FleetmanagementV1CustomerCustomer403ErrorException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
// <copyright file="FleetmanagementV2RestrictionSearchcard401ErrorException.cs" company="APIMatic">
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
    /// FleetmanagementV2RestrictionSearchcard401ErrorException.
    /// </summary>
    public class FleetmanagementV2RestrictionSearchcard401ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV2RestrictionSearchcard401ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public FleetmanagementV2RestrictionSearchcard401ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Fault.
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fault Fault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FleetmanagementV2RestrictionSearchcard401ErrorException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Fault = {(this.Fault == null ? "null" : this.Fault.ToString())}");
        }
    }
}
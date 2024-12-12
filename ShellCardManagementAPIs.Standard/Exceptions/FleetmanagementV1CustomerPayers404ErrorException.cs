// <copyright file="FleetmanagementV1CustomerPayers404ErrorException.cs" company="APIMatic">
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
    /// FleetmanagementV1CustomerPayers404ErrorException.
    /// </summary>
    public class FleetmanagementV1CustomerPayers404ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1CustomerPayers404ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public FleetmanagementV1CustomerPayers404ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Fault.
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fault Fault { get; set; }
    }
}
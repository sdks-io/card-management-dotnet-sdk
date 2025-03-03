// <copyright file="FleetmanagementV1UserLoggedinuser404Error1.cs" company="APIMatic">
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
    /// FleetmanagementV1UserLoggedinuser404Error1.
    /// </summary>
    public class FleetmanagementV1UserLoggedinuser404Error1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1UserLoggedinuser404Error1"/> class.
        /// </summary>
        public FleetmanagementV1UserLoggedinuser404Error1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetmanagementV1UserLoggedinuser404Error1"/> class.
        /// </summary>
        /// <param name="fault">fault.</param>
        public FleetmanagementV1UserLoggedinuser404Error1(
            Models.Fault fault = null)
        {
            this.Fault = fault;
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
            return $"FleetmanagementV1UserLoggedinuser404Error1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FleetmanagementV1UserLoggedinuser404Error1 other &&
                (this.Fault == null && other.Fault == null ||
                 this.Fault?.Equals(other.Fault) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Fault = {(this.Fault == null ? "null" : this.Fault.ToString())}");
        }
    }
}
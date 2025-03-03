// <copyright file="DefaultError.cs" company="APIMatic">
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
    /// DefaultError.
    /// </summary>
    public class DefaultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultError"/> class.
        /// </summary>
        public DefaultError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultError"/> class.
        /// </summary>
        /// <param name="fault">fault.</param>
        public DefaultError(
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
            return $"DefaultError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DefaultError other &&
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
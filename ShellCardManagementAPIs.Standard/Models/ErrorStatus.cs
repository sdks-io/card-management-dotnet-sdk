// <copyright file="ErrorStatus.cs" company="APIMatic">
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
    /// ErrorStatus.
    /// </summary>
    public class ErrorStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorStatus"/> class.
        /// </summary>
        public ErrorStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorStatus"/> class.
        /// </summary>
        /// <param name="code">Code.</param>
        /// <param name="description">Description.</param>
        public ErrorStatus(
            string code = null,
            string description = null)
        {
            this.Code = code;
            this.Description = description;
        }

        /// <summary>
        /// Error Code
        /// </summary>
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Error Description
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ErrorStatus : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ErrorStatus other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
        }
    }
}
// <copyright file="GeneratePINKeyResponse.cs" company="APIMatic">
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
    /// GeneratePINKeyResponse.
    /// </summary>
    public class GeneratePINKeyResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePINKeyResponse"/> class.
        /// </summary>
        public GeneratePINKeyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePINKeyResponse"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="mValue">value.</param>
        public GeneratePINKeyResponse(
            string uid = null,
            string mValue = null)
        {
            this.Uid = uid;
            this.MValue = mValue;
        }

        /// <summary>
        /// Random generated unique identifier.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GeneratePINKeyResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GeneratePINKeyResponse other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
        }
    }
}
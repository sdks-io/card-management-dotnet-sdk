// <copyright file="DefaultErrorFaultDetail.cs" company="APIMatic">
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
    /// DefaultErrorFaultDetail.
    /// </summary>
    public class DefaultErrorFaultDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultErrorFaultDetail"/> class.
        /// </summary>
        public DefaultErrorFaultDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultErrorFaultDetail"/> class.
        /// </summary>
        /// <param name="errorcode">errorcode.</param>
        public DefaultErrorFaultDetail(
            string errorcode = null)
        {
            this.Errorcode = errorcode;
        }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("errorcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Errorcode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DefaultErrorFaultDetail : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DefaultErrorFaultDetail other &&
                (this.Errorcode == null && other.Errorcode == null ||
                 this.Errorcode?.Equals(other.Errorcode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Errorcode = {this.Errorcode ?? "null"}");
        }
    }
}
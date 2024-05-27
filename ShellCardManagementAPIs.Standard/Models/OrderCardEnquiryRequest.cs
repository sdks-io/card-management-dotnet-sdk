// <copyright file="OrderCardEnquiryRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Models
{
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

    /// <summary>
    /// OrderCardEnquiryRequest.
    /// </summary>
    public class OrderCardEnquiryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiryRequest"/> class.
        /// </summary>
        public OrderCardEnquiryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiryRequest"/> class.
        /// </summary>
        /// <param name="filters">Filters.</param>
        public OrderCardEnquiryRequest(
            Models.OrderCardEnquiryReq filters = null)
        {
            this.Filters = filters;
        }

        /// <summary>
        /// This class holds Order Card Enquiry list based on which the Order Card Enquiry need to be filtered.
        /// </summary>
        [JsonProperty("Filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderCardEnquiryReq Filters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderCardEnquiryRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is OrderCardEnquiryRequest other &&                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
        }
    }
}
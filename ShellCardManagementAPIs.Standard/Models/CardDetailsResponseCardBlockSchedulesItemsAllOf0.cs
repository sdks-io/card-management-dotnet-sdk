// <copyright file="CardDetailsResponseCardBlockSchedulesItemsAllOf0.cs" company="APIMatic">
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
    /// CardDetailsResponseCardBlockSchedulesItemsAllOf0.
    /// </summary>
    public class CardDetailsResponseCardBlockSchedulesItemsAllOf0
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponseCardBlockSchedulesItemsAllOf0"/> class.
        /// </summary>
        public CardDetailsResponseCardBlockSchedulesItemsAllOf0()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponseCardBlockSchedulesItemsAllOf0"/> class.
        /// </summary>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        public CardDetailsResponseCardBlockSchedulesItemsAllOf0(
            string fromDate = null,
            string toDate = null)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        /// <summary>
        /// Effective start date of Block / Unblock
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// Effective end date of Block / Unblock
        /// </summary>
        [JsonProperty("ToDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardDetailsResponseCardBlockSchedulesItemsAllOf0 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardDetailsResponseCardBlockSchedulesItemsAllOf0 other &&
                (this.FromDate == null && other.FromDate == null ||
                 this.FromDate?.Equals(other.FromDate) == true) &&
                (this.ToDate == null && other.ToDate == null ||
                 this.ToDate?.Equals(other.ToDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FromDate = {this.FromDate ?? "null"}");
            toStringOutput.Add($"ToDate = {this.ToDate ?? "null"}");
        }
    }
}
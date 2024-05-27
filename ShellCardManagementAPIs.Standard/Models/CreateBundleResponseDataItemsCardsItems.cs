// <copyright file="CreateBundleResponseDataItemsCardsItems.cs" company="APIMatic">
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
    /// CreateBundleResponseDataItemsCardsItems.
    /// </summary>
    public class CreateBundleResponseDataItemsCardsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponseDataItemsCardsItems"/> class.
        /// </summary>
        public CreateBundleResponseDataItemsCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponseDataItemsCardsItems"/> class.
        /// </summary>
        /// <param name="pAN">PAN.</param>
        public CreateBundleResponseDataItemsCardsItems(
            string pAN = null)
        {
            this.PAN = pAN;
        }

        /// <summary>
        /// Card PAN.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateBundleResponseDataItemsCardsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateBundleResponseDataItemsCardsItems other &&                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
        }
    }
}
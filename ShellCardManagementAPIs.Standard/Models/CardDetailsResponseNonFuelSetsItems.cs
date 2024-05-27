// <copyright file="CardDetailsResponseNonFuelSetsItems.cs" company="APIMatic">
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
    /// CardDetailsResponseNonFuelSetsItems.
    /// </summary>
    public class CardDetailsResponseNonFuelSetsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponseNonFuelSetsItems"/> class.
        /// </summary>
        public CardDetailsResponseNonFuelSetsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponseNonFuelSetsItems"/> class.
        /// </summary>
        /// <param name="productRestrictionId">ProductRestrictionId.</param>
        /// <param name="description">Description.</param>
        public CardDetailsResponseNonFuelSetsItems(
            int productRestrictionId,
            string description)
        {
            this.ProductRestrictionId = productRestrictionId;
            this.Description = description;
        }

        /// <summary>
        /// product restriction identifier
        /// </summary>
        [JsonProperty("ProductRestrictionId")]
        public int ProductRestrictionId { get; set; }

        /// <summary>
        /// product set description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardDetailsResponseNonFuelSetsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardDetailsResponseNonFuelSetsItems other &&                this.ProductRestrictionId.Equals(other.ProductRestrictionId) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductRestrictionId = {this.ProductRestrictionId}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}
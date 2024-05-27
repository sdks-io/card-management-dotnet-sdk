// <copyright file="AutoRenewCardResponseDataItems.cs" company="APIMatic">
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
    /// AutoRenewCardResponseDataItems.
    /// </summary>
    public class AutoRenewCardResponseDataItems
    {
        private int? autoRenewReferenceId;
        private string cardIdAndPAN;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AutoRenewReferenceId", false },
            { "CardIdAndPAN", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardResponseDataItems"/> class.
        /// </summary>
        public AutoRenewCardResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardResponseDataItems"/> class.
        /// </summary>
        /// <param name="autoRenewReferenceId">AutoRenewReferenceId.</param>
        /// <param name="cardIdAndPAN">CardIdAndPAN.</param>
        public AutoRenewCardResponseDataItems(
            int? autoRenewReferenceId = null,
            string cardIdAndPAN = null)
        {
            if (autoRenewReferenceId != null)
            {
                this.AutoRenewReferenceId = autoRenewReferenceId;
            }

            if (cardIdAndPAN != null)
            {
                this.CardIdAndPAN = cardIdAndPAN;
            }

        }

        /// <summary>
        /// CardId and PAN of the card. ;( Semicolon is used as delimiter.
        /// </summary>
        [JsonProperty("AutoRenewReferenceId")]
        public int? AutoRenewReferenceId
        {
            get
            {
                return this.autoRenewReferenceId;
            }

            set
            {
                this.shouldSerialize["AutoRenewReferenceId"] = true;
                this.autoRenewReferenceId = value;
            }
        }

        /// <summary>
        /// Reference number for each individual auto renew card in the order.
        /// </summary>
        [JsonProperty("CardIdAndPAN")]
        public string CardIdAndPAN
        {
            get
            {
                return this.cardIdAndPAN;
            }

            set
            {
                this.shouldSerialize["CardIdAndPAN"] = true;
                this.cardIdAndPAN = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoRenewCardResponseDataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAutoRenewReferenceId()
        {
            this.shouldSerialize["AutoRenewReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardIdAndPAN()
        {
            this.shouldSerialize["CardIdAndPAN"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutoRenewReferenceId()
        {
            return this.shouldSerialize["AutoRenewReferenceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardIdAndPAN()
        {
            return this.shouldSerialize["CardIdAndPAN"];
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
            return obj is AutoRenewCardResponseDataItems other &&                ((this.AutoRenewReferenceId == null && other.AutoRenewReferenceId == null) || (this.AutoRenewReferenceId?.Equals(other.AutoRenewReferenceId) == true)) &&
                ((this.CardIdAndPAN == null && other.CardIdAndPAN == null) || (this.CardIdAndPAN?.Equals(other.CardIdAndPAN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AutoRenewReferenceId = {(this.AutoRenewReferenceId == null ? "null" : this.AutoRenewReferenceId.ToString())}");
            toStringOutput.Add($"this.CardIdAndPAN = {(this.CardIdAndPAN == null ? "null" : this.CardIdAndPAN)}");
        }
    }
}
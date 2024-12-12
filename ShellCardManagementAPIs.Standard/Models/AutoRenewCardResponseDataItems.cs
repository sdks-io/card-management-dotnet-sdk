// <copyright file="AutoRenewCardResponseDataItems.cs" company="APIMatic">
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
    /// AutoRenewCardResponseDataItems.
    /// </summary>
    public class AutoRenewCardResponseDataItems
    {
        private int? autoRenewReferenceId;
        private string cardIdAndPAN;
        private double? pANID;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AutoRenewReferenceId", false },
            { "CardIdAndPAN", false },
            { "PANID", false },
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
        /// <param name="pANID">PANID.</param>
        public AutoRenewCardResponseDataItems(
            int? autoRenewReferenceId = null,
            string cardIdAndPAN = null,
            double? pANID = null)
        {

            if (autoRenewReferenceId != null)
            {
                this.AutoRenewReferenceId = autoRenewReferenceId;
            }

            if (cardIdAndPAN != null)
            {
                this.CardIdAndPAN = cardIdAndPAN;
            }

            if (pANID != null)
            {
                this.PANID = pANID;
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

        /// <summary>
        /// PANID of the card
        /// </summary>
        [JsonProperty("PANID")]
        public double? PANID
        {
            get
            {
                return this.pANID;
            }

            set
            {
                this.shouldSerialize["PANID"] = true;
                this.pANID = value;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAutoRenewReferenceId()
        {
            this.shouldSerialize["AutoRenewReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardIdAndPAN()
        {
            this.shouldSerialize["CardIdAndPAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPANID()
        {
            this.shouldSerialize["PANID"] = false;
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePANID()
        {
            return this.shouldSerialize["PANID"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AutoRenewCardResponseDataItems other &&
                (this.AutoRenewReferenceId == null && other.AutoRenewReferenceId == null ||
                 this.AutoRenewReferenceId?.Equals(other.AutoRenewReferenceId) == true) &&
                (this.CardIdAndPAN == null && other.CardIdAndPAN == null ||
                 this.CardIdAndPAN?.Equals(other.CardIdAndPAN) == true) &&
                (this.PANID == null && other.PANID == null ||
                 this.PANID?.Equals(other.PANID) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AutoRenewReferenceId = {(this.AutoRenewReferenceId == null ? "null" : this.AutoRenewReferenceId.ToString())}");
            toStringOutput.Add($"this.CardIdAndPAN = {this.CardIdAndPAN ?? "null"}");
            toStringOutput.Add($"this.PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
        }
    }
}
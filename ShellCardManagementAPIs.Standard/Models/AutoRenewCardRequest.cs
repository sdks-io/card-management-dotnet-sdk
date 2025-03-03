// <copyright file="AutoRenewCardRequest.cs" company="APIMatic">
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
    /// AutoRenewCardRequest.
    /// </summary>
    public class AutoRenewCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardRequest"/> class.
        /// </summary>
        public AutoRenewCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRenewCardRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="autoRenewCards">AutoRenewCards.</param>
        public AutoRenewCardRequest(
            int? colCoId = null,
            int? colCoCode = null,
            string payerNumber = null,
            int? payerId = null,
            List<Models.AutoRenewCardRequestAutoRenewCardsItems> autoRenewCards = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerNumber = payerNumber;
            this.PayerId = payerId;
            this.AutoRenewCards = autoRenewCards;
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Number (Ex: GB000000123) of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Gets or sets AutoRenewCards.
        /// </summary>
        [JsonProperty("AutoRenewCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AutoRenewCardRequestAutoRenewCardsItems> AutoRenewCards { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AutoRenewCardRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AutoRenewCardRequest other &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.AutoRenewCards == null && other.AutoRenewCards == null ||
                 this.AutoRenewCards?.Equals(other.AutoRenewCards) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"AutoRenewCards = {(this.AutoRenewCards == null ? "null" : $"[{string.Join(", ", this.AutoRenewCards)} ]")}");
        }
    }
}
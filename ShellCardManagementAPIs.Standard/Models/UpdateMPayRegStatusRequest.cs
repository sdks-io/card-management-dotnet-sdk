// <copyright file="UpdateMPayRegStatusRequest.cs" company="APIMatic">
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
    /// UpdateMPayRegStatusRequest.
    /// </summary>
    public class UpdateMPayRegStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMPayRegStatusRequest"/> class.
        /// </summary>
        public UpdateMPayRegStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMPayRegStatusRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="mPayRequests">MPayRequests.</param>
        public UpdateMPayRegStatusRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            List<Models.UpdateMPayRegStatusRequestMPayRequestsItems> mPayRequests = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.MPayRequests = mPayRequests;
        }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
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
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number (Ex: GB000000123) of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// List of MPay Request to be updated for Fleet Manager approval status.
        /// Mandatory
        /// Maximum number of requests that can be submitted are 50
        /// </summary>
        [JsonProperty("MPayRequests", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateMPayRegStatusRequestMPayRequestsItems> MPayRequests { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateMPayRegStatusRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateMPayRegStatusRequest other &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.MPayRequests == null && other.MPayRequests == null ||
                 this.MPayRequests?.Equals(other.MPayRequests) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"this.MPayRequests = {(this.MPayRequests == null ? "null" : $"[{string.Join(", ", this.MPayRequests)} ]")}");
        }
    }
}
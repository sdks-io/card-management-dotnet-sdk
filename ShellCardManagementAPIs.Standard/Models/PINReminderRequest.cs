// <copyright file="PINReminderRequest.cs" company="APIMatic">
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
    /// PINReminderRequest.
    /// </summary>
    public class PINReminderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderRequest"/> class.
        /// </summary>
        public PINReminderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderRequest"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="pINReminderCardDetails">PINReminderCardDetails.</param>
        public PINReminderRequest(
            int? accountId = null,
            string accountNumber = null,
            int? colCoCode = null,
            int? colCoId = null,
            int? payerId = null,
            string payerNumber = null,
            List<Models.PINReminderCardDetails> pINReminderCardDetails = null)
        {
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.ColCoCode = colCoCode;
            this.ColCoId = colCoId;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.PINReminderCardDetails = pINReminderCardDetails;
        }

        /// <summary>
        /// Account Id of the customer.<br />
        /// Optional if AccountNumber is passed, else Mandatory.<br />
        /// This input is a search criterion, if given.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the customer.<br />
        /// Optional if AccountId is passed, else Mandatory.<br />
        /// This input is a search criterion, if given.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer. <br />
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. <br />
        /// It is optional for other countries if ColCoID is provided.
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Collecting Company Id of the selected payer<br />
        /// Optional if ColCoCode is passed else Mandatory.
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Payer Id (i.e. Customer Id of the Payment Customer of the selected payer.<br />
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number (Ex: GB000000123) of the selected payer.<br />
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// List of PINReminderCardDetails entity. The fields of this entity are described below.
        /// </summary>
        [JsonProperty("PINReminderCardDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PINReminderCardDetails> PINReminderCardDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PINReminderRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PINReminderRequest other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PINReminderCardDetails == null && other.PINReminderCardDetails == null) || (this.PINReminderCardDetails?.Equals(other.PINReminderCardDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PINReminderCardDetails = {(this.PINReminderCardDetails == null ? "null" : $"[{string.Join(", ", this.PINReminderCardDetails)} ]")}");
        }
    }
}
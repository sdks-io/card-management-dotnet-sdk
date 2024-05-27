// <copyright file="ScheduleCardBlockCardsItems.cs" company="APIMatic">
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
    /// ScheduleCardBlockCardsItems.
    /// </summary>
    public class ScheduleCardBlockCardsItems
    {
        private string caller;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Caller", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockCardsItems"/> class.
        /// </summary>
        public ScheduleCardBlockCardsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockCardsItems"/> class.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="caller">Caller.</param>
        /// <param name="notifyCaller">NotifyCaller.</param>
        public ScheduleCardBlockCardsItems(
            string action,
            int? colCoCode = null,
            int? colCoId = null,
            int? accountId = null,
            string accountNumber = null,
            int? payerId = null,
            string payerNumber = null,
            int? cardId = null,
            string pAN = null,
            string cardExpiryDate = null,
            string fromDate = null,
            string toDate = null,
            string caller = null,
            bool? notifyCaller = null)
        {
            this.ColCoCode = colCoCode;
            this.ColCoId = colCoId;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.CardId = cardId;
            this.PAN = pAN;
            this.CardExpiryDate = cardExpiryDate;
            this.Action = action;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            if (caller != null)
            {
                this.Caller = caller;
            }

            this.NotifyCaller = notifyCaller;
        }

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
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Account Id of the customer.
        /// Optional if AccountNumber is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the customer.
        /// Optional if AccountId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Payer id of the customer.
        /// Optional if PayerNumber is passed, else Mandatory.
        /// Example: 123456
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// PayerNumber of the customer.
        /// Optional if PayerId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Unique Id of the card.
        /// Optional if PAN is passed, else Mandatory.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// PAN of the card.
        /// Optional if CardId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Expiry date of the card.
        /// Optional if CardId is passed, else Mandatory.
        /// Format: yyyyMMdd
        /// Example: 20170930
        /// </summary>
        [JsonProperty("CardExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// Action
        /// Mandatory
        /// Possible values are:
        /// •	AddOrUpdate – adds a new request or updates any existing requests, with overlapping dates, for the card
        /// •	AddAndOverwriteAll - all the existing requests of the given card will be removed and a new request with the specified FromDate and ToDate will be added.
        /// •	Delete – deletes any existing request with the same start date and end date for the card
        /// •	DeleteAll – deletes all saved future dated requests (all block and unblock requests) of the card.
        /// </summary>
        [JsonProperty("Action")]
        public string Action { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Effective start date of Block / Unblock
        /// Allowed Formats: –
        /// •	yyyyMMdd
        /// •	yyyyMMdd HH:mm
        /// Eg: 20230512 14:30, 20230512
        /// Optional
        /// Default value:
        /// •	 If the card status is “Active” then Current date & Time
        /// •	If the card status is “TemporaryBlock (Customer)” then null.
        /// Note:
        /// •	Time is considered only when “IsTimeSupported” is true else it will be treated as a date.
        /// •	Time will be passed in UTC time-zone.
        /// •	If the Card Status is “Temporary Block (Customer)” and FromDate is provided – The fromdate & time is considered as starting period of unblock request.
        /// ]]>
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Effective end date of Block / Unblock
        /// Allowed Formats: –
        /// •	yyyyMMdd
        /// •	yyyyMMdd HH:mm
        /// Eg: 20230512 14:30, 20230512
        /// Optional – When the Card status is Active else mandatory.
        /// When not provided, the card will remain blocked until manually unblocked.
        /// Note:
        /// •	Time is considered only when the “IsTimeSupported” flag is set as true, else it will be considered as only date.
        /// •	Date & Time passed in the request will be considered in UTC time-zone.
        /// •	If the card is currently in ‘Temporary Block (Customer)’ status, then this date is treated as the unblock date and is mandatory.
        /// •	If the Card Status is “Temporary Block (Customer)” and FromDate & ToDate is provided - The request will be considered as a scheduled specific period unblock request.
        /// ]]>
        /// </summary>
        [JsonProperty("ToDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }

        /// <summary>
        /// The caller to be notified with the status of the scheduled card block / unblock request.
        /// Mandatory, if NotifyCaller is true.
        /// Maximum field length: 20
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller
        {
            get
            {
                return this.caller;
            }

            set
            {
                this.shouldSerialize["Caller"] = true;
                this.caller = value;
            }
        }

        /// <summary>
        /// True/False.
        /// Optional.
        /// Default: False
        /// If true, the caller would be notified back with the status as success or failure after the scheduled card block / unblock request is processed.
        /// </summary>
        [JsonProperty("NotifyCaller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCaller { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScheduleCardBlockCardsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCaller()
        {
            this.shouldSerialize["Caller"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCaller()
        {
            return this.shouldSerialize["Caller"];
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
            return obj is ScheduleCardBlockCardsItems other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardExpiryDate == null && other.CardExpiryDate == null) || (this.CardExpiryDate?.Equals(other.CardExpiryDate) == true)) &&
                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Caller == null && other.Caller == null) || (this.Caller?.Equals(other.Caller) == true)) &&
                ((this.NotifyCaller == null && other.NotifyCaller == null) || (this.NotifyCaller?.Equals(other.NotifyCaller) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardExpiryDate = {(this.CardExpiryDate == null ? "null" : this.CardExpiryDate)}");
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Caller = {(this.Caller == null ? "null" : this.Caller)}");
            toStringOutput.Add($"this.NotifyCaller = {(this.NotifyCaller == null ? "null" : this.NotifyCaller.ToString())}");
        }
    }
}
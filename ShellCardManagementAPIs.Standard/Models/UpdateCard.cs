// <copyright file="UpdateCard.cs" company="APIMatic">
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
    /// UpdateCard.
    /// </summary>
    public class UpdateCard
    {
        private string caller;
        private int? accountId;
        private string accountNumber;
        private string cardExpiryDate;
        private int? cardId;
        private int? colCoCode;
        private int? colCoId;
        private string pAN;
        private double? pANID;
        private int? payerId;
        private string payerNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Caller", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "CardExpiryDate", false },
            { "CardId", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "PAN", false },
            { "PANID", false },
            { "PayerId", false },
            { "PayerNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCard"/> class.
        /// </summary>
        public UpdateCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCard"/> class.
        /// </summary>
        /// <param name="caller">Caller.</param>
        /// <param name="isReplacementChargeable">IsReplacementChargeable.</param>
        /// <param name="notifyCaller">NotifyCaller.</param>
        /// <param name="notifyCallerOnSync">NotifyCallerOnSync.</param>
        /// <param name="orderCardReplacement">OrderCardReplacement.</param>
        /// <param name="cardSettings">CardSettings.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="pANID">PANID.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        public UpdateCard(
            string caller = null,
            bool? isReplacementChargeable = null,
            bool? notifyCaller = null,
            bool? notifyCallerOnSync = null,
            bool? orderCardReplacement = null,
            Models.CardSettings cardSettings = null,
            int? accountId = null,
            string accountNumber = null,
            string cardExpiryDate = null,
            int? cardId = null,
            int? colCoCode = null,
            int? colCoId = null,
            string pAN = null,
            double? pANID = null,
            int? payerId = null,
            string payerNumber = null)
        {

            if (caller != null)
            {
                this.Caller = caller;
            }
            this.IsReplacementChargeable = isReplacementChargeable;
            this.NotifyCaller = notifyCaller;
            this.NotifyCallerOnSync = notifyCallerOnSync;
            this.OrderCardReplacement = orderCardReplacement;
            this.CardSettings = cardSettings;

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (cardExpiryDate != null)
            {
                this.CardExpiryDate = cardExpiryDate;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (pANID != null)
            {
                this.PANID = pANID;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }
        }

        /// <summary>
        /// The caller to be notified with the status of the update card status request. <br />
        /// The caller will also be notified with the status of the replacement card order request, if any.<br />
        /// Mandatory, if NotifyCaller is true. <br />
        /// Maximum field length: 20<br />
        /// Allowed values:<br />
        /// - NextGenUI: This value to be used by next gen UI application.<br />
        /// - Motix: This value to be used by MOTiX application.<br />
        /// - FleetHubUILifeTime: This value to be used by Fleet Hub UI application for life time restriction cards.<br />
        /// Note: The values passed in this field are case insensitive.
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
        /// True/False<br />
        /// Optional<br />
        /// When not provided will considered as default value as True.<br />
        /// If passed True, the replacement card will be chargeable, else replacement card will not be charged.
        /// </summary>
        [JsonProperty("IsReplacementChargeable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReplacementChargeable { get; set; }

        /// <summary>
        /// True/False.<br />
        /// Optional.<br />
        /// Default: False<br />
        /// If true, the caller would be notified back with the status as success or failure after the update card status request is processed.
        /// Notification API subscription required to use this feature , please refer API documetation for more details
        /// </summary>
        [JsonProperty("NotifyCaller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCaller { get; set; }

        /// <summary>
        /// True/False.<br />
        /// Optional.<br />
        /// Default: False<br />
        /// If true, the caller would be notified back with the status as success or failed after the replacement card is synced with Gateway, if a replacement card was requested.
        /// </summary>
        [JsonProperty("NotifyCallerOnSync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCallerOnSync { get; set; }

        /// <summary>
        /// True/False.<br />
        /// Pass True if a replacement order card request is to be placed, else False.<br />
        /// Optional.Default value False.<br />
        /// Replacement of a card is only applicable when the target status requested is either permanently Block or Damaged for the existing card.<br />
        /// Request for Replacement card will be placed only when the Block card or Block damaged card request is successfully placed.<br />
        /// The Replacement card request will be processed only when the permanent Block card request is successfully processed. <br />
        /// In case of damaged card request, the replacement card request will be processed immediately.
        /// </summary>
        [JsonProperty("OrderCardReplacement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderCardReplacement { get; set; }

        /// <summary>
        /// Gets or sets CardSettings.
        /// </summary>
        [JsonProperty("CardSettings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardSettings CardSettings { get; set; }

        /// <summary>
        /// Account Id of the customer.<br />
        /// Optional if AccountNumber is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Account Number of the customer.<br />
        /// Optional if AccountId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Expiry date of the card.<br />
        /// Mandatory if PAN is passed, else optional.<br />
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CardExpiryDate")]
        public string CardExpiryDate
        {
            get
            {
                return this.cardExpiryDate;
            }

            set
            {
                this.shouldSerialize["CardExpiryDate"] = true;
                this.cardExpiryDate = value;
            }
        }

        /// <summary>
        /// Card Id of the card.<br />
        /// Optional if PAN is passed, else Mandatory.
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// Collecting company code of the customer. <br />
        /// Optional if ColCoId is passed, else Mandatory.<br />
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Collecting company id of the customer. <br />
        /// Optional if ColCoCode is passed, else Mandatory.<br />
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// PAN of the card.<br />
        /// Optional if CardId is passed, else Mandatory.<br />
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
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

        /// <summary>
        /// Payer id of the customer.<br />
        /// Optional if PayerNumber is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// PayerNumber of the customer.<br />
        /// Optional if PayerId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCaller()
        {
            this.shouldSerialize["Caller"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardExpiryDate()
        {
            this.shouldSerialize["CardExpiryDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPANID()
        {
            this.shouldSerialize["PANID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCaller()
        {
            return this.shouldSerialize["Caller"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardExpiryDate()
        {
            return this.shouldSerialize["CardExpiryDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePANID()
        {
            return this.shouldSerialize["PANID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCard other &&
                (this.Caller == null && other.Caller == null ||
                 this.Caller?.Equals(other.Caller) == true) &&
                (this.IsReplacementChargeable == null && other.IsReplacementChargeable == null ||
                 this.IsReplacementChargeable?.Equals(other.IsReplacementChargeable) == true) &&
                (this.NotifyCaller == null && other.NotifyCaller == null ||
                 this.NotifyCaller?.Equals(other.NotifyCaller) == true) &&
                (this.NotifyCallerOnSync == null && other.NotifyCallerOnSync == null ||
                 this.NotifyCallerOnSync?.Equals(other.NotifyCallerOnSync) == true) &&
                (this.OrderCardReplacement == null && other.OrderCardReplacement == null ||
                 this.OrderCardReplacement?.Equals(other.OrderCardReplacement) == true) &&
                (this.CardSettings == null && other.CardSettings == null ||
                 this.CardSettings?.Equals(other.CardSettings) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.CardExpiryDate == null && other.CardExpiryDate == null ||
                 this.CardExpiryDate?.Equals(other.CardExpiryDate) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.PANID == null && other.PANID == null ||
                 this.PANID?.Equals(other.PANID) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Caller = {this.Caller ?? "null"}");
            toStringOutput.Add($"IsReplacementChargeable = {(this.IsReplacementChargeable == null ? "null" : this.IsReplacementChargeable.ToString())}");
            toStringOutput.Add($"NotifyCaller = {(this.NotifyCaller == null ? "null" : this.NotifyCaller.ToString())}");
            toStringOutput.Add($"NotifyCallerOnSync = {(this.NotifyCallerOnSync == null ? "null" : this.NotifyCallerOnSync.ToString())}");
            toStringOutput.Add($"OrderCardReplacement = {(this.OrderCardReplacement == null ? "null" : this.OrderCardReplacement.ToString())}");
            toStringOutput.Add($"CardSettings = {(this.CardSettings == null ? "null" : this.CardSettings.ToString())}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"CardExpiryDate = {this.CardExpiryDate ?? "null"}");
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
        }
    }
}
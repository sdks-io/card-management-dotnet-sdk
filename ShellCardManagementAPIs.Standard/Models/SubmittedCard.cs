// <copyright file="SubmittedCard.cs" company="APIMatic">
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
    /// SubmittedCard.
    /// </summary>
    public class SubmittedCard
    {
        private int? replacementCardReference;
        private int? updateCardReference;
        private int? accountId;
        private string accountNumber;
        private string cardExpiryDate;
        private int? cardId;
        private int? colCoCode;
        private int? colCoId;
        private string pAN;
        private double? pANID;
        private string maskedPAN;
        private int? payerId;
        private string payerNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ReplacementCardReference", false },
            { "UpdateCardReference", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "CardExpiryDate", false },
            { "CardId", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "PAN", false },
            { "PANID", false },
            { "MaskedPAN", false },
            { "PayerId", false },
            { "PayerNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmittedCard"/> class.
        /// </summary>
        public SubmittedCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmittedCard"/> class.
        /// </summary>
        /// <param name="replacementCardReference">ReplacementCardReference.</param>
        /// <param name="updateCardReference">UpdateCardReference.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="pANID">PANID.</param>
        /// <param name="maskedPAN">MaskedPAN.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        public SubmittedCard(
            int? replacementCardReference = null,
            int? updateCardReference = null,
            int? accountId = null,
            string accountNumber = null,
            string cardExpiryDate = null,
            int? cardId = null,
            int? colCoCode = null,
            int? colCoId = null,
            string pAN = null,
            double? pANID = null,
            string maskedPAN = null,
            int? payerId = null,
            string payerNumber = null)
        {

            if (replacementCardReference != null)
            {
                this.ReplacementCardReference = replacementCardReference;
            }

            if (updateCardReference != null)
            {
                this.UpdateCardReference = updateCardReference;
            }

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

            if (maskedPAN != null)
            {
                this.MaskedPAN = maskedPAN;
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
        /// Reference number for tracking of replacement card order request of the specific card,<br />
        /// This is applicable for requests with target status as Block and OrderReplacement passed as True.
        /// </summary>
        [JsonProperty("ReplacementCardReference")]
        public int? ReplacementCardReference
        {
            get
            {
                return this.replacementCardReference;
            }

            set
            {
                this.shouldSerialize["ReplacementCardReference"] = true;
                this.replacementCardReference = value;
            }
        }

        /// <summary>
        /// Reference number for tracking of update status request of the specific card,
        /// </summary>
        [JsonProperty("UpdateCardReference")]
        public int? UpdateCardReference
        {
            get
            {
                return this.updateCardReference;
            }

            set
            {
                this.shouldSerialize["UpdateCardReference"] = true;
                this.updateCardReference = value;
            }
        }

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
        /// Card PAN
        /// </summary>
        [JsonProperty("MaskedPAN")]
        public string MaskedPAN
        {
            get
            {
                return this.maskedPAN;
            }

            set
            {
                this.shouldSerialize["MaskedPAN"] = true;
                this.maskedPAN = value;
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
            return $"SubmittedCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReplacementCardReference()
        {
            this.shouldSerialize["ReplacementCardReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdateCardReference()
        {
            this.shouldSerialize["UpdateCardReference"] = false;
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
        public void UnsetMaskedPAN()
        {
            this.shouldSerialize["MaskedPAN"] = false;
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
        public bool ShouldSerializeReplacementCardReference()
        {
            return this.shouldSerialize["ReplacementCardReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdateCardReference()
        {
            return this.shouldSerialize["UpdateCardReference"];
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
        public bool ShouldSerializeMaskedPAN()
        {
            return this.shouldSerialize["MaskedPAN"];
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

            return obj is SubmittedCard other &&
                (this.ReplacementCardReference == null && other.ReplacementCardReference == null ||
                 this.ReplacementCardReference?.Equals(other.ReplacementCardReference) == true) &&
                (this.UpdateCardReference == null && other.UpdateCardReference == null ||
                 this.UpdateCardReference?.Equals(other.UpdateCardReference) == true) &&
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
                (this.MaskedPAN == null && other.MaskedPAN == null ||
                 this.MaskedPAN?.Equals(other.MaskedPAN) == true) &&
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
            toStringOutput.Add($"ReplacementCardReference = {(this.ReplacementCardReference == null ? "null" : this.ReplacementCardReference.ToString())}");
            toStringOutput.Add($"UpdateCardReference = {(this.UpdateCardReference == null ? "null" : this.UpdateCardReference.ToString())}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"CardExpiryDate = {this.CardExpiryDate ?? "null"}");
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
            toStringOutput.Add($"MaskedPAN = {this.MaskedPAN ?? "null"}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
        }
    }
}
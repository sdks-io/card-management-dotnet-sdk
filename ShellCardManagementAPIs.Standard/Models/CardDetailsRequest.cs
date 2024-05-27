// <copyright file="CardDetailsRequest.cs" company="APIMatic">
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
    /// CardDetailsRequest.
    /// </summary>
    public class CardDetailsRequest
    {
        private int? colCoId;
        private string colCoCountryCode;
        private string clientReferenceId;
        private string payerNumber;
        private int? payerId;
        private string accountNumber;
        private int? accountId;
        private string pAN;
        private int? cardId;
        private int? tokenTypeID;
        private string tokenTypeName;
        private string creationDate;
        private string effectiveDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCountryCode", false },
            { "ClientReferenceId", false },
            { "PayerNumber", false },
            { "PayerId", false },
            { "AccountNumber", false },
            { "AccountId", false },
            { "PAN", false },
            { "CardId", false },
            { "TokenTypeID", false },
            { "TokenTypeName", false },
            { "CreationDate", false },
            { "EffectiveDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest"/> class.
        /// </summary>
        public CardDetailsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="clientReferenceId">ClientReferenceId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="tokenTypeID">TokenTypeID.</param>
        /// <param name="tokenTypeName">TokenTypeName.</param>
        /// <param name="creationDate">CreationDate.</param>
        /// <param name="effectiveDate">EffectiveDate.</param>
        /// <param name="includeBundleDetails">IncludeBundleDetails.</param>
        /// <param name="includeIntermediateStatus">IncludeIntermediateStatus.</param>
        /// <param name="includeScheduledCardBlocks">IncludeScheduledCardBlocks.</param>
        public CardDetailsRequest(
            int? colCoCode = null,
            int? colCoId = null,
            string colCoCountryCode = null,
            string clientReferenceId = null,
            string payerNumber = null,
            int? payerId = null,
            string accountNumber = null,
            int? accountId = null,
            string pAN = null,
            int? cardId = null,
            int? tokenTypeID = null,
            string tokenTypeName = null,
            string creationDate = null,
            string effectiveDate = null,
            bool? includeBundleDetails = null,
            bool? includeIntermediateStatus = null,
            bool? includeScheduledCardBlocks = null)
        {
            this.ColCoCode = colCoCode;
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (clientReferenceId != null)
            {
                this.ClientReferenceId = clientReferenceId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (tokenTypeID != null)
            {
                this.TokenTypeID = tokenTypeID;
            }

            if (tokenTypeName != null)
            {
                this.TokenTypeName = tokenTypeName;
            }

            if (creationDate != null)
            {
                this.CreationDate = creationDate;
            }

            if (effectiveDate != null)
            {
                this.EffectiveDate = effectiveDate;
            }

            this.IncludeBundleDetails = includeBundleDetails;
            this.IncludeIntermediateStatus = includeIntermediateStatus;
            this.IncludeScheduledCardBlocks = includeScheduledCardBlocks;
        }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86-Philippines
        /// 5-UK
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
        /// ISO Country code of collecting company
        /// </summary>
        [JsonProperty("ColCoCountryCode")]
        public string ColCoCountryCode
        {
            get
            {
                return this.colCoCountryCode;
            }

            set
            {
                this.shouldSerialize["ColCoCountryCode"] = true;
                this.colCoCountryCode = value;
            }
        }

        /// <summary>
        /// Customer reference number of the card.
        /// Optional
        /// </summary>
        [JsonProperty("ClientReferenceId")]
        public string ClientReferenceId
        {
            get
            {
                return this.clientReferenceId;
            }

            set
            {
                this.shouldSerialize["ClientReferenceId"] = true;
                this.clientReferenceId = value;
            }
        }

        /// <summary>
        /// Payer Number of the selected payer.
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

        /// <summary>
        /// Payer Id (i.e. Customer Id of the Payment of the selected payer.
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
        /// Account Number of the customer.
        /// Optional if AccountId is passed, else mandatory.
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
        /// Account ID of the customer.
        /// Optional if AccountNumber is passed, else mandatory.
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
        /// PAN of the card.
        /// Optional if CardId is passed, else Mandatory.
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
        /// Card Id of the card.
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
        /// Token Type ID for the Card
        /// Optional
        /// </summary>
        [JsonProperty("TokenTypeID")]
        public int? TokenTypeID
        {
            get
            {
                return this.tokenTypeID;
            }

            set
            {
                this.shouldSerialize["TokenTypeID"] = true;
                this.tokenTypeID = value;
            }
        }

        /// <summary>
        /// Token Type name for the Card
        /// Optional
        /// </summary>
        [JsonProperty("TokenTypeName")]
        public string TokenTypeName
        {
            get
            {
                return this.tokenTypeName;
            }

            set
            {
                this.shouldSerialize["TokenTypeName"] = true;
                this.tokenTypeName = value;
            }
        }

        /// <summary>
        /// Card Creation Date time
        /// Optional
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate
        {
            get
            {
                return this.creationDate;
            }

            set
            {
                this.shouldSerialize["CreationDate"] = true;
                this.creationDate = value;
            }
        }

        /// <summary>
        /// Effective date for the Card
        /// Optional
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("EffectiveDate")]
        public string EffectiveDate
        {
            get
            {
                return this.effectiveDate;
            }

            set
            {
                this.shouldSerialize["EffectiveDate"] = true;
                this.effectiveDate = value;
            }
        }

        /// <summary>
        /// When the value is True, API will return bundle Id associated with card in the response, if available.
        /// Note: Use ‘Null’ or ‘False’ for optimum performance. A delay in response is expected when set to ‘True’.
        /// </summary>
        [JsonProperty("IncludeBundleDetails", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeBundleDetails { get; set; }

        /// <summary>
        /// A flag which indicates if the response can contain intermediate statuses
        /// </summary>
        [JsonProperty("IncludeIntermediateStatus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeIntermediateStatus { get; set; }

        /// <summary>
        /// A flag which indicates if the response can contain scheduled card blocks details
        /// </summary>
        [JsonProperty("IncludeScheduledCardBlocks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeScheduledCardBlocks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardDetailsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClientReferenceId()
        {
            this.shouldSerialize["ClientReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTokenTypeID()
        {
            this.shouldSerialize["TokenTypeID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTokenTypeName()
        {
            this.shouldSerialize["TokenTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreationDate()
        {
            this.shouldSerialize["CreationDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEffectiveDate()
        {
            this.shouldSerialize["EffectiveDate"] = false;
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
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClientReferenceId()
        {
            return this.shouldSerialize["ClientReferenceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
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
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
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
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
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
        public bool ShouldSerializeTokenTypeID()
        {
            return this.shouldSerialize["TokenTypeID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTokenTypeName()
        {
            return this.shouldSerialize["TokenTypeName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreationDate()
        {
            return this.shouldSerialize["CreationDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEffectiveDate()
        {
            return this.shouldSerialize["EffectiveDate"];
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
            return obj is CardDetailsRequest other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.ClientReferenceId == null && other.ClientReferenceId == null) || (this.ClientReferenceId?.Equals(other.ClientReferenceId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.TokenTypeID == null && other.TokenTypeID == null) || (this.TokenTypeID?.Equals(other.TokenTypeID) == true)) &&
                ((this.TokenTypeName == null && other.TokenTypeName == null) || (this.TokenTypeName?.Equals(other.TokenTypeName) == true)) &&
                ((this.CreationDate == null && other.CreationDate == null) || (this.CreationDate?.Equals(other.CreationDate) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.IncludeBundleDetails == null && other.IncludeBundleDetails == null) || (this.IncludeBundleDetails?.Equals(other.IncludeBundleDetails) == true)) &&
                ((this.IncludeIntermediateStatus == null && other.IncludeIntermediateStatus == null) || (this.IncludeIntermediateStatus?.Equals(other.IncludeIntermediateStatus) == true)) &&
                ((this.IncludeScheduledCardBlocks == null && other.IncludeScheduledCardBlocks == null) || (this.IncludeScheduledCardBlocks?.Equals(other.IncludeScheduledCardBlocks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.ClientReferenceId = {(this.ClientReferenceId == null ? "null" : this.ClientReferenceId)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.TokenTypeID = {(this.TokenTypeID == null ? "null" : this.TokenTypeID.ToString())}");
            toStringOutput.Add($"this.TokenTypeName = {(this.TokenTypeName == null ? "null" : this.TokenTypeName)}");
            toStringOutput.Add($"this.CreationDate = {(this.CreationDate == null ? "null" : this.CreationDate)}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate)}");
            toStringOutput.Add($"this.IncludeBundleDetails = {(this.IncludeBundleDetails == null ? "null" : this.IncludeBundleDetails.ToString())}");
            toStringOutput.Add($"this.IncludeIntermediateStatus = {(this.IncludeIntermediateStatus == null ? "null" : this.IncludeIntermediateStatus.ToString())}");
            toStringOutput.Add($"this.IncludeScheduledCardBlocks = {(this.IncludeScheduledCardBlocks == null ? "null" : this.IncludeScheduledCardBlocks.ToString())}");
        }
    }
}
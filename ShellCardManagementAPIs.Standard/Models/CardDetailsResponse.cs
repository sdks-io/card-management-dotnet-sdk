// <copyright file="CardDetailsResponse.cs" company="APIMatic">
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
    /// CardDetailsResponse.
    /// </summary>
    public class CardDetailsResponse
    {
        private int? payerId;
        private string payerNumber;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private string colCoCountryCode;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private string pAN;
        private string cardTypeCode;
        private int? cardTypeId;
        private string cardTypeName;
        private int? tokenTypeId;
        private string tokenTypeName;
        private string purchaseCategoryCode;
        private string purchaseCategoryName;
        private string issuedDate;
        private string lastUsedDate;
        private string misuseDate;
        private string temperature;
        private int? cardGroupId;
        private string cardGroupName;
        private string renewalDate;
        private int? renewedCardId;
        private int? renewedCardStatusId;
        private int? renewedCardIssueNumber;
        private string creationDate;
        private string effectiveDate;
        private string lastModifiedDate;
        private string bundleId;
        private List<Models.CardDetailsResponseCardBlockSchedulesItemsAllOf0> cardBlockSchedules;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PayerId", false },
            { "PayerNumber", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "ColCoCountryCode", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "PAN", false },
            { "CardTypeCode", false },
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "TokenTypeId", false },
            { "TokenTypeName", false },
            { "PurchaseCategoryCode", false },
            { "PurchaseCategoryName", false },
            { "IssuedDate", false },
            { "LastUsedDate", false },
            { "MisuseDate", false },
            { "Temperature", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "RenewalDate", false },
            { "RenewedCardId", false },
            { "RenewedCardStatusId", false },
            { "RenewedCardIssueNumber", false },
            { "CreationDate", false },
            { "EffectiveDate", false },
            { "LastModifiedDate", false },
            { "BundleId", false },
            { "CardBlockSchedules", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponse"/> class.
        /// </summary>
        public CardDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponse"/> class.
        /// </summary>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="statusId">StatusId.</param>
        /// <param name="status">Status.</param>
        /// <param name="odometerPrompt">OdometerPrompt.</param>
        /// <param name="fleetIdPrompt">FleetIdPrompt.</param>
        /// <param name="pINType">PINType.</param>
        /// <param name="hasPIN">HasPIN.</param>
        /// <param name="isSelfSelectedPIN">IsSelfSelectedPIN.</param>
        /// <param name="temporaryBlockAllowed">TemporaryBlockAllowed.</param>
        /// <param name="unblockAllowed">UnblockAllowed.</param>
        /// <param name="permanentBlockAllowed">PermanentBlockAllowed.</param>
        /// <param name="issueNumber">IssueNumber.</param>
        /// <param name="reissueSetting">ReissueSetting.</param>
        /// <param name="internationalPOSLanguageID">InternationalPOSLanguageID.</param>
        /// <param name="internationalPOSLanguageCode">InternationalPOSLanguageCode.</param>
        /// <param name="localPOSLanguageID">LocalPOSLanguageID.</param>
        /// <param name="localPOSLanguageCode">LocalPOSLanguageCode.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="tokenTypeId">TokenTypeId.</param>
        /// <param name="tokenTypeName">TokenTypeName.</param>
        /// <param name="isChipCard">IsChipCard.</param>
        /// <param name="isMagStripCard">IsMagStripCard.</param>
        /// <param name="isVirtualCard">IsVirtualCard.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryName">PurchaseCategoryName.</param>
        /// <param name="isCRT">IsCRT.</param>
        /// <param name="isFleet">IsFleet.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="isPartnerSitesIncluded">IsPartnerSitesIncluded.</param>
        /// <param name="isShellSitesOnly">IsShellSitesOnly.</param>
        /// <param name="fuelSets">FuelSets.</param>
        /// <param name="nonFuelSets">NonFuelSets.</param>
        /// <param name="issuedDate">IssuedDate.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="lastUsedDate">LastUsedDate.</param>
        /// <param name="misuseDate">MisuseDate.</param>
        /// <param name="temperature">Temperature.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="embossText">EmbossText.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="renewalDate">RenewalDate.</param>
        /// <param name="renewedCardId">RenewedCardId.</param>
        /// <param name="renewedCardStatusId">RenewedCardStatusId.</param>
        /// <param name="renewedCardStatus">RenewedCardStatus.</param>
        /// <param name="renewedCardExpiryDate">RenewedCardExpiryDate.</param>
        /// <param name="renewedCardIssueNumber">RenewedCardIssueNumber.</param>
        /// <param name="renewedCardReissueSetting">RenewedCardReissueSetting.</param>
        /// <param name="creationDate">CreationDate.</param>
        /// <param name="effectiveDate">EffectiveDate.</param>
        /// <param name="lastModifiedDate">LastModifiedDate.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="cardDeliveryAddress">CardDeliveryAddress.</param>
        /// <param name="pINDeliveryAddress">PINDeliveryAddress.</param>
        /// <param name="cardBlockSchedules">CardBlockSchedules.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public CardDetailsResponse(
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            string colCoCountryCode = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            int? cardId = null,
            string pAN = null,
            Models.CardDetailsResponseStatusIdEnum? statusId = null,
            string status = null,
            bool? odometerPrompt = null,
            bool? fleetIdPrompt = null,
            Models.CardDetailsResponsePINTypeEnum? pINType = null,
            bool? hasPIN = null,
            bool? isSelfSelectedPIN = null,
            bool? temporaryBlockAllowed = null,
            bool? unblockAllowed = null,
            bool? permanentBlockAllowed = null,
            int? issueNumber = null,
            object reissueSetting = null,
            Models.CardDetailsResponseInternationalPOSLanguageIDEnum? internationalPOSLanguageID = null,
            Models.CardDetailsResponseInternationalPOSLanguageCodeEnum? internationalPOSLanguageCode = null,
            Models.CardDetailsResponseInternationalPOSLanguageIDEnum? localPOSLanguageID = null,
            Models.CardDetailsResponseInternationalPOSLanguageCodeEnum? localPOSLanguageCode = null,
            string cardTypeCode = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            int? tokenTypeId = null,
            string tokenTypeName = null,
            bool? isChipCard = null,
            bool? isMagStripCard = null,
            bool? isVirtualCard = null,
            string purchaseCategoryCode = null,
            int? purchaseCategoryId = null,
            string purchaseCategoryName = null,
            bool? isCRT = null,
            bool? isFleet = null,
            bool? isInternational = null,
            bool? isNational = null,
            bool? isPartnerSitesIncluded = null,
            bool? isShellSitesOnly = null,
            List<Models.CardDetailsResponseFuelSetsItems> fuelSets = null,
            List<Models.CardDetailsResponseNonFuelSetsItems> nonFuelSets = null,
            string issuedDate = null,
            string expiryDate = null,
            string lastUsedDate = null,
            string misuseDate = null,
            string temperature = null,
            string driverName = null,
            string vRN = null,
            string embossText = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            string renewalDate = null,
            int? renewedCardId = null,
            int? renewedCardStatusId = null,
            string renewedCardStatus = null,
            string renewedCardExpiryDate = null,
            int? renewedCardIssueNumber = null,
            Models.CardDetailsResponseRenewedCardReissueSettingEnum? renewedCardReissueSetting = null,
            string creationDate = null,
            string effectiveDate = null,
            string lastModifiedDate = null,
            string bundleId = null,
            Models.CardDeliveryAddress cardDeliveryAddress = null,
            Models.PINDeliveryAddress pINDeliveryAddress = null,
            List<Models.CardDetailsResponseCardBlockSchedulesItemsAllOf0> cardBlockSchedules = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (localCurrencyCode != null)
            {
                this.LocalCurrencyCode = localCurrencyCode;
            }

            if (localCurrencySymbol != null)
            {
                this.LocalCurrencySymbol = localCurrencySymbol;
            }

            this.CardId = cardId;
            if (pAN != null)
            {
                this.PAN = pAN;
            }

            this.StatusId = statusId;
            this.Status = status;
            this.OdometerPrompt = odometerPrompt;
            this.FleetIdPrompt = fleetIdPrompt;
            this.PINType = pINType;
            this.HasPIN = hasPIN;
            this.IsSelfSelectedPIN = isSelfSelectedPIN;
            this.TemporaryBlockAllowed = temporaryBlockAllowed;
            this.UnblockAllowed = unblockAllowed;
            this.PermanentBlockAllowed = permanentBlockAllowed;
            this.IssueNumber = issueNumber;
            this.ReissueSetting = reissueSetting;
            this.InternationalPOSLanguageID = internationalPOSLanguageID;
            this.InternationalPOSLanguageCode = internationalPOSLanguageCode;
            this.LocalPOSLanguageID = localPOSLanguageID;
            this.LocalPOSLanguageCode = localPOSLanguageCode;
            if (cardTypeCode != null)
            {
                this.CardTypeCode = cardTypeCode;
            }

            if (cardTypeId != null)
            {
                this.CardTypeId = cardTypeId;
            }

            if (cardTypeName != null)
            {
                this.CardTypeName = cardTypeName;
            }

            if (tokenTypeId != null)
            {
                this.TokenTypeId = tokenTypeId;
            }

            if (tokenTypeName != null)
            {
                this.TokenTypeName = tokenTypeName;
            }

            this.IsChipCard = isChipCard;
            this.IsMagStripCard = isMagStripCard;
            this.IsVirtualCard = isVirtualCard;
            if (purchaseCategoryCode != null)
            {
                this.PurchaseCategoryCode = purchaseCategoryCode;
            }

            this.PurchaseCategoryId = purchaseCategoryId;
            if (purchaseCategoryName != null)
            {
                this.PurchaseCategoryName = purchaseCategoryName;
            }

            this.IsCRT = isCRT;
            this.IsFleet = isFleet;
            this.IsInternational = isInternational;
            this.IsNational = isNational;
            this.IsPartnerSitesIncluded = isPartnerSitesIncluded;
            this.IsShellSitesOnly = isShellSitesOnly;
            this.FuelSets = fuelSets;
            this.NonFuelSets = nonFuelSets;
            if (issuedDate != null)
            {
                this.IssuedDate = issuedDate;
            }

            this.ExpiryDate = expiryDate;
            if (lastUsedDate != null)
            {
                this.LastUsedDate = lastUsedDate;
            }

            if (misuseDate != null)
            {
                this.MisuseDate = misuseDate;
            }

            if (temperature != null)
            {
                this.Temperature = temperature;
            }

            this.DriverName = driverName;
            this.VRN = vRN;
            this.EmbossText = embossText;
            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (renewalDate != null)
            {
                this.RenewalDate = renewalDate;
            }

            if (renewedCardId != null)
            {
                this.RenewedCardId = renewedCardId;
            }

            if (renewedCardStatusId != null)
            {
                this.RenewedCardStatusId = renewedCardStatusId;
            }

            this.RenewedCardStatus = renewedCardStatus;
            this.RenewedCardExpiryDate = renewedCardExpiryDate;
            if (renewedCardIssueNumber != null)
            {
                this.RenewedCardIssueNumber = renewedCardIssueNumber;
            }

            this.RenewedCardReissueSetting = renewedCardReissueSetting;
            if (creationDate != null)
            {
                this.CreationDate = creationDate;
            }

            if (effectiveDate != null)
            {
                this.EffectiveDate = effectiveDate;
            }

            if (lastModifiedDate != null)
            {
                this.LastModifiedDate = lastModifiedDate;
            }

            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }

            this.CardDeliveryAddress = cardDeliveryAddress;
            this.PINDeliveryAddress = pINDeliveryAddress;
            if (cardBlockSchedules != null)
            {
                this.CardBlockSchedules = cardBlockSchedules;
            }

            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Payer Id (i.e. Customer Id of the Payment Customer in the Shell Card Platform) of the selected payer.
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
        /// Account Id (i.e. Customer Id of the Customer in the Shell Card Platform) of the customer.
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
        /// Account Number of the customer.
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
        /// Account short name.
        /// </summary>
        [JsonProperty("AccountShortName")]
        public string AccountShortName
        {
            get
            {
                return this.accountShortName;
            }

            set
            {
                this.shouldSerialize["AccountShortName"] = true;
                this.accountShortName = value;
            }
        }

        /// <summary>
        /// ISO 3166 Alpha-2 Country Code for the customer and card owning country.
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
        /// ISO 4217 Curreny Code of the local currency.
        /// </summary>
        [JsonProperty("LocalCurrencyCode")]
        public string LocalCurrencyCode
        {
            get
            {
                return this.localCurrencyCode;
            }

            set
            {
                this.shouldSerialize["LocalCurrencyCode"] = true;
                this.localCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of local currency.
        /// </summary>
        [JsonProperty("LocalCurrencySymbol")]
        public string LocalCurrencySymbol
        {
            get
            {
                return this.localCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["LocalCurrencySymbol"] = true;
                this.localCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Unique Card Id in Cards platform.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// Card PAN. In the response body the PAN will be masked if the option is enabled in the Shell Card Platform.
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
        /// Gets or sets StatusId.
        /// </summary>
        [JsonProperty("StatusId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseStatusIdEnum? StatusId { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Possible Id’s and description:
        /// * 1  Active
        /// * 7  Blocked Card
        /// * 8  Expired
        /// * 9  Cancelled
        /// * 10  New
        /// * 23  Pending Renewal
        /// * 31  Replaced
        /// * 41  Temporary Block (Customer)
        /// * 42  Temporary Block (Shell)
        /// * 43  Fraud
        /// * 101 Active (Block in progress) *
        /// * 102 Blocked Card (Unblock in progress) *
        /// * 103 Active (Cancel in progress) *
        /// * 104 Active (Marked as damaged) *
        /// * 105 New (Cancel as damaged) *
        /// * 106 Active(Scheduled for block) ”#
        /// * 107 Blocked Card(Scheduled for unblock) *#
        /// * 108 Blocked Card (Cancel in progress) *
        /// > Note:
        /// •  Items marked with * are intermediate statuses  to indicate that there are pending requests in progress. , The response can contain these intermediate statuses only if the IncludeIntermediateStatus flag is true.
        /// •  The placeholder “<Shell Card Platform Status>” in the items marked with # will be replaced with the Shell Card Platform status description. E.g., “Active (Scheduled for block)”
        /// ]]>
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// True if odometer input is enabled on the card, else false
        /// </summary>
        [JsonProperty("OdometerPrompt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OdometerPrompt { get; set; }

        /// <summary>
        /// True if fleet id input is enabled, else false
        /// </summary>
        [JsonProperty("FleetIdPrompt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FleetIdPrompt { get; set; }

        /// <summary>
        /// Gets or sets PINType.
        /// </summary>
        [JsonProperty("PINType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponsePINTypeEnum? PINType { get; set; }

        /// <summary>
        /// True if card has PIN, else false
        /// </summary>
        [JsonProperty("HasPIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPIN { get; set; }

        /// <summary>
        /// True if card has Self Selected PIN, else false
        /// </summary>
        [JsonProperty("IsSelfSelectedPIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelfSelectedPIN { get; set; }

        /// <summary>
        /// True if card can be blocked temporarily, else false
        /// </summary>
        [JsonProperty("TemporaryBlockAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TemporaryBlockAllowed { get; set; }

        /// <summary>
        /// True/False True if card can be Unblocked, else false
        /// </summary>
        [JsonProperty("UnblockAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnblockAllowed { get; set; }

        /// <summary>
        /// True if card can be blocked permanently, else false
        /// </summary>
        [JsonProperty("PermanentBlockAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermanentBlockAllowed { get; set; }

        /// <summary>
        /// Issue number of the card
        /// </summary>
        [JsonProperty("IssueNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueNumber { get; set; }

        /// <summary>
        /// Gets or sets ReissueSetting.
        /// </summary>
        [JsonProperty("ReissueSetting", NullValueHandling = NullValueHandling.Ignore)]
        public object ReissueSetting { get; set; }

        /// <summary>
        /// Gets or sets InternationalPOSLanguageID.
        /// </summary>
        [JsonProperty("InternationalPOSLanguageID", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseInternationalPOSLanguageIDEnum? InternationalPOSLanguageID { get; set; }

        /// <summary>
        /// Gets or sets InternationalPOSLanguageCode.
        /// </summary>
        [JsonProperty("InternationalPOSLanguageCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseInternationalPOSLanguageCodeEnum? InternationalPOSLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets LocalPOSLanguageID.
        /// </summary>
        [JsonProperty("LocalPOSLanguageID", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseInternationalPOSLanguageIDEnum? LocalPOSLanguageID { get; set; }

        /// <summary>
        /// Gets or sets LocalPOSLanguageCode.
        /// </summary>
        [JsonProperty("LocalPOSLanguageCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseInternationalPOSLanguageCodeEnum? LocalPOSLanguageCode { get; set; }

        /// <summary>
        /// ISO code of the card i.e. first 7 digits of the PAN.
        /// </summary>
        [JsonProperty("CardTypeCode")]
        public string CardTypeCode
        {
            get
            {
                return this.cardTypeCode;
            }

            set
            {
                this.shouldSerialize["CardTypeCode"] = true;
                this.cardTypeCode = value;
            }
        }

        /// <summary>
        /// Card Type ID
        /// </summary>
        [JsonProperty("CardTypeId")]
        public int? CardTypeId
        {
            get
            {
                return this.cardTypeId;
            }

            set
            {
                this.shouldSerialize["CardTypeId"] = true;
                this.cardTypeId = value;
            }
        }

        /// <summary>
        /// Card Type Name
        /// </summary>
        [JsonProperty("CardTypeName")]
        public string CardTypeName
        {
            get
            {
                return this.cardTypeName;
            }

            set
            {
                this.shouldSerialize["CardTypeName"] = true;
                this.cardTypeName = value;
            }
        }

        /// <summary>
        /// Token Type ID configured for the Card
        /// </summary>
        [JsonProperty("TokenTypeId")]
        public int? TokenTypeId
        {
            get
            {
                return this.tokenTypeId;
            }

            set
            {
                this.shouldSerialize["TokenTypeId"] = true;
                this.tokenTypeId = value;
            }
        }

        /// <summary>
        /// Token Type Name configured for the Card
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
        /// True if a chip card, else false
        /// </summary>
        [JsonProperty("IsChipCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsChipCard { get; set; }

        /// <summary>
        /// True if it is a magnetic stripe card, else false
        /// </summary>
        [JsonProperty("IsMagStripCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMagStripCard { get; set; }

        /// <summary>
        /// True if it is a virtual card, else false
        /// </summary>
        [JsonProperty("IsVirtualCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtualCard { get; set; }

        /// <summary>
        /// Purchase category code of the card.
        /// </summary>
        [JsonProperty("PurchaseCategoryCode")]
        public string PurchaseCategoryCode
        {
            get
            {
                return this.purchaseCategoryCode;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryCode"] = true;
                this.purchaseCategoryCode = value;
            }
        }

        /// <summary>
        /// Purchase category identifier in the Shell Card Platform.
        /// </summary>
        [JsonProperty("PurchaseCategoryId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseCategoryId { get; set; }

        /// <summary>
        /// Purchase category name
        /// </summary>
        [JsonProperty("PurchaseCategoryName")]
        public string PurchaseCategoryName
        {
            get
            {
                return this.purchaseCategoryName;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryName"] = true;
                this.purchaseCategoryName = value;
            }
        }

        /// <summary>
        /// True if it is a Commercial Road Transport (CRT) card, else false
        /// </summary>
        [JsonProperty("IsCRT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCRT { get; set; }

        /// <summary>
        /// True if it is a Fleet card, else false
        /// </summary>
        [JsonProperty("IsFleet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFleet { get; set; }

        /// <summary>
        /// True if it is an international card, else false
        /// </summary>
        [JsonProperty("IsInternational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; }

        /// <summary>
        /// True if it is a national card, else false
        /// </summary>
        [JsonProperty("IsNational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNational { get; set; }

        /// <summary>
        /// True if it is allowed at all partner sites, else false
        /// </summary>
        [JsonProperty("IsPartnerSitesIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartnerSitesIncluded { get; set; }

        /// <summary>
        /// True if it is only allowed at Shell sites, else false
        /// </summary>
        [JsonProperty("IsShellSitesOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellSitesOnly { get; set; }

        /// <summary>
        /// List of active fuel type product restrictions applied on the card.
        /// </summary>
        [JsonProperty("FuelSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardDetailsResponseFuelSetsItems> FuelSets { get; set; }

        /// <summary>
        /// List of active non-fuel type product restrictions applied on the card.
        /// </summary>
        [JsonProperty("NonFuelSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardDetailsResponseNonFuelSetsItems> NonFuelSets { get; set; }

        /// <summary>
        /// Card issue date.
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate
        {
            get
            {
                return this.issuedDate;
            }

            set
            {
                this.shouldSerialize["IssuedDate"] = true;
                this.issuedDate = value;
            }
        }

        /// <summary>
        /// Expiry date of the card.
        /// </summary>
        [JsonProperty("ExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Card last used date.
        /// </summary>
        [JsonProperty("LastUsedDate")]
        public string LastUsedDate
        {
            get
            {
                return this.lastUsedDate;
            }

            set
            {
                this.shouldSerialize["LastUsedDate"] = true;
                this.lastUsedDate = value;
            }
        }

        /// <summary>
        /// Last misused date of the card.
        /// </summary>
        [JsonProperty("MisuseDate")]
        public string MisuseDate
        {
            get
            {
                return this.misuseDate;
            }

            set
            {
                this.shouldSerialize["MisuseDate"] = true;
                this.misuseDate = value;
            }
        }

        /// <summary>
        /// Hot-list status
        /// </summary>
        [JsonProperty("Temperature")]
        public string Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                this.shouldSerialize["Temperature"] = true;
                this.temperature = value;
            }
        }

        /// <summary>
        /// Driver name of the card. Note- While ordering card, optional when VRN is passed else mandatory.
        /// </summary>
        [JsonProperty("DriverName", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverName { get; set; }

        /// <summary>
        /// Vehicle registration number of the card. Note- While ordering card, optional when DriverName is passed else mandatory.
        /// </summary>
        [JsonProperty("VRN", NullValueHandling = NullValueHandling.Ignore)]
        public string VRN { get; set; }

        /// <summary>
        /// Text printed on the card as account name.
        /// </summary>
        [JsonProperty("EmbossText", NullValueHandling = NullValueHandling.Ignore)]
        public string EmbossText { get; set; }

        /// <summary>
        /// Existing Card Group ID, under which the replacement card is to be created.
        /// Pass “-1” if the replacement card should not be assigned to any card group.
        /// Optional.
        /// If not provided, the replacement card will be created under the same card group as the current card.
        /// Example- 156
        /// </summary>
        [JsonProperty("CardGroupId")]
        public int? CardGroupId
        {
            get
            {
                return this.cardGroupId;
            }

            set
            {
                this.shouldSerialize["CardGroupId"] = true;
                this.cardGroupId = value;
            }
        }

        /// <summary>
        /// Card group name. Note- 1. While ordering card this field is mandatory when IsNewCardGroup is true.
        /// </summary>
        [JsonProperty("CardGroupName")]
        public string CardGroupName
        {
            get
            {
                return this.cardGroupName;
            }

            set
            {
                this.shouldSerialize["CardGroupName"] = true;
                this.cardGroupName = value;
            }
        }

        /// <summary>
        /// Renewal date of the card. Applicable if ReissueSetting is set to True.
        /// </summary>
        [JsonProperty("RenewalDate")]
        public string RenewalDate
        {
            get
            {
                return this.renewalDate;
            }

            set
            {
                this.shouldSerialize["RenewalDate"] = true;
                this.renewalDate = value;
            }
        }

        /// <summary>
        /// Renewed card id.
        /// </summary>
        [JsonProperty("RenewedCardId")]
        public int? RenewedCardId
        {
            get
            {
                return this.renewedCardId;
            }

            set
            {
                this.shouldSerialize["RenewedCardId"] = true;
                this.renewedCardId = value;
            }
        }

        /// <summary>
        /// Renewed card status id.
        /// </summary>
        [JsonProperty("RenewedCardStatusId")]
        public int? RenewedCardStatusId
        {
            get
            {
                return this.renewedCardStatusId;
            }

            set
            {
                this.shouldSerialize["RenewedCardStatusId"] = true;
                this.renewedCardStatusId = value;
            }
        }

        /// <summary>
        /// Renewed card status description.
        /// </summary>
        [JsonProperty("RenewedCardStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewedCardStatus { get; set; }

        /// <summary>
        /// Renewed card expiry date.
        /// </summary>
        [JsonProperty("RenewedCardExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewedCardExpiryDate { get; set; }

        /// <summary>
        /// Renewed card issue number.
        /// </summary>
        [JsonProperty("RenewedCardIssueNumber")]
        public int? RenewedCardIssueNumber
        {
            get
            {
                return this.renewedCardIssueNumber;
            }

            set
            {
                this.shouldSerialize["RenewedCardIssueNumber"] = true;
                this.renewedCardIssueNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets RenewedCardReissueSetting.
        /// </summary>
        [JsonProperty("RenewedCardReissueSetting", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailsResponseRenewedCardReissueSettingEnum? RenewedCardReissueSetting { get; set; }

        /// <summary>
        /// Card Creation Date time
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
        /// Card last modified date
        /// </summary>
        [JsonProperty("LastModifiedDate")]
        public string LastModifiedDate
        {
            get
            {
                return this.lastModifiedDate;
            }

            set
            {
                this.shouldSerialize["LastModifiedDate"] = true;
                this.lastModifiedDate = value;
            }
        }

        /// <summary>
        /// Bundle Id associated with card in the Gateway. This field will have a null value if the card is not associated with any bundle in Gateway or the value of IncludeBundleDetails in request is false.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId
        {
            get
            {
                return this.bundleId;
            }

            set
            {
                this.shouldSerialize["BundleId"] = true;
                this.bundleId = value;
            }
        }

        /// <summary>
        /// Gets or sets CardDeliveryAddress.
        /// </summary>
        [JsonProperty("CardDeliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDeliveryAddress CardDeliveryAddress { get; set; }

        /// <summary>
        /// Gets or sets PINDeliveryAddress.
        /// </summary>
        [JsonProperty("PINDeliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PINDeliveryAddress PINDeliveryAddress { get; set; }

        /// <summary>
        /// Gets or sets CardBlockSchedules.
        /// </summary>
        [JsonProperty("CardBlockSchedules")]
        public List<Models.CardDetailsResponseCardBlockSchedulesItemsAllOf0> CardBlockSchedules
        {
            get
            {
                return this.cardBlockSchedules;
            }

            set
            {
                this.shouldSerialize["CardBlockSchedules"] = true;
                this.cardBlockSchedules = value;
            }
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardDetailsResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountShortName()
        {
            this.shouldSerialize["AccountShortName"] = false;
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
        public void UnsetLocalCurrencyCode()
        {
            this.shouldSerialize["LocalCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalCurrencySymbol()
        {
            this.shouldSerialize["LocalCurrencySymbol"] = false;
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
        public void UnsetCardTypeCode()
        {
            this.shouldSerialize["CardTypeCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeId()
        {
            this.shouldSerialize["CardTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeName()
        {
            this.shouldSerialize["CardTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTokenTypeId()
        {
            this.shouldSerialize["TokenTypeId"] = false;
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
        public void UnsetPurchaseCategoryCode()
        {
            this.shouldSerialize["PurchaseCategoryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchaseCategoryName()
        {
            this.shouldSerialize["PurchaseCategoryName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuedDate()
        {
            this.shouldSerialize["IssuedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastUsedDate()
        {
            this.shouldSerialize["LastUsedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMisuseDate()
        {
            this.shouldSerialize["MisuseDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTemperature()
        {
            this.shouldSerialize["Temperature"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRenewalDate()
        {
            this.shouldSerialize["RenewalDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRenewedCardId()
        {
            this.shouldSerialize["RenewedCardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRenewedCardStatusId()
        {
            this.shouldSerialize["RenewedCardStatusId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRenewedCardIssueNumber()
        {
            this.shouldSerialize["RenewedCardIssueNumber"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastModifiedDate()
        {
            this.shouldSerialize["LastModifiedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardBlockSchedules()
        {
            this.shouldSerialize["CardBlockSchedules"] = false;
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
        public bool ShouldSerializeAccountShortName()
        {
            return this.shouldSerialize["AccountShortName"];
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
        public bool ShouldSerializeLocalCurrencyCode()
        {
            return this.shouldSerialize["LocalCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalCurrencySymbol()
        {
            return this.shouldSerialize["LocalCurrencySymbol"];
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
        public bool ShouldSerializeCardTypeCode()
        {
            return this.shouldSerialize["CardTypeCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeId()
        {
            return this.shouldSerialize["CardTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeName()
        {
            return this.shouldSerialize["CardTypeName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTokenTypeId()
        {
            return this.shouldSerialize["TokenTypeId"];
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
        public bool ShouldSerializePurchaseCategoryCode()
        {
            return this.shouldSerialize["PurchaseCategoryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategoryName()
        {
            return this.shouldSerialize["PurchaseCategoryName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuedDate()
        {
            return this.shouldSerialize["IssuedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastUsedDate()
        {
            return this.shouldSerialize["LastUsedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMisuseDate()
        {
            return this.shouldSerialize["MisuseDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemperature()
        {
            return this.shouldSerialize["Temperature"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupId()
        {
            return this.shouldSerialize["CardGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupName()
        {
            return this.shouldSerialize["CardGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewalDate()
        {
            return this.shouldSerialize["RenewalDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewedCardId()
        {
            return this.shouldSerialize["RenewedCardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewedCardStatusId()
        {
            return this.shouldSerialize["RenewedCardStatusId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewedCardIssueNumber()
        {
            return this.shouldSerialize["RenewedCardIssueNumber"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastModifiedDate()
        {
            return this.shouldSerialize["LastModifiedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardBlockSchedules()
        {
            return this.shouldSerialize["CardBlockSchedules"];
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
            return obj is CardDetailsResponse other &&                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.LocalCurrencyCode == null && other.LocalCurrencyCode == null) || (this.LocalCurrencyCode?.Equals(other.LocalCurrencyCode) == true)) &&
                ((this.LocalCurrencySymbol == null && other.LocalCurrencySymbol == null) || (this.LocalCurrencySymbol?.Equals(other.LocalCurrencySymbol) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.StatusId == null && other.StatusId == null) || (this.StatusId?.Equals(other.StatusId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.OdometerPrompt == null && other.OdometerPrompt == null) || (this.OdometerPrompt?.Equals(other.OdometerPrompt) == true)) &&
                ((this.FleetIdPrompt == null && other.FleetIdPrompt == null) || (this.FleetIdPrompt?.Equals(other.FleetIdPrompt) == true)) &&
                ((this.PINType == null && other.PINType == null) || (this.PINType?.Equals(other.PINType) == true)) &&
                ((this.HasPIN == null && other.HasPIN == null) || (this.HasPIN?.Equals(other.HasPIN) == true)) &&
                ((this.IsSelfSelectedPIN == null && other.IsSelfSelectedPIN == null) || (this.IsSelfSelectedPIN?.Equals(other.IsSelfSelectedPIN) == true)) &&
                ((this.TemporaryBlockAllowed == null && other.TemporaryBlockAllowed == null) || (this.TemporaryBlockAllowed?.Equals(other.TemporaryBlockAllowed) == true)) &&
                ((this.UnblockAllowed == null && other.UnblockAllowed == null) || (this.UnblockAllowed?.Equals(other.UnblockAllowed) == true)) &&
                ((this.PermanentBlockAllowed == null && other.PermanentBlockAllowed == null) || (this.PermanentBlockAllowed?.Equals(other.PermanentBlockAllowed) == true)) &&
                ((this.IssueNumber == null && other.IssueNumber == null) || (this.IssueNumber?.Equals(other.IssueNumber) == true)) &&
                ((this.ReissueSetting == null && other.ReissueSetting == null) || (this.ReissueSetting?.Equals(other.ReissueSetting) == true)) &&
                ((this.InternationalPOSLanguageID == null && other.InternationalPOSLanguageID == null) || (this.InternationalPOSLanguageID?.Equals(other.InternationalPOSLanguageID) == true)) &&
                ((this.InternationalPOSLanguageCode == null && other.InternationalPOSLanguageCode == null) || (this.InternationalPOSLanguageCode?.Equals(other.InternationalPOSLanguageCode) == true)) &&
                ((this.LocalPOSLanguageID == null && other.LocalPOSLanguageID == null) || (this.LocalPOSLanguageID?.Equals(other.LocalPOSLanguageID) == true)) &&
                ((this.LocalPOSLanguageCode == null && other.LocalPOSLanguageCode == null) || (this.LocalPOSLanguageCode?.Equals(other.LocalPOSLanguageCode) == true)) &&
                ((this.CardTypeCode == null && other.CardTypeCode == null) || (this.CardTypeCode?.Equals(other.CardTypeCode) == true)) &&
                ((this.CardTypeId == null && other.CardTypeId == null) || (this.CardTypeId?.Equals(other.CardTypeId) == true)) &&
                ((this.CardTypeName == null && other.CardTypeName == null) || (this.CardTypeName?.Equals(other.CardTypeName) == true)) &&
                ((this.TokenTypeId == null && other.TokenTypeId == null) || (this.TokenTypeId?.Equals(other.TokenTypeId) == true)) &&
                ((this.TokenTypeName == null && other.TokenTypeName == null) || (this.TokenTypeName?.Equals(other.TokenTypeName) == true)) &&
                ((this.IsChipCard == null && other.IsChipCard == null) || (this.IsChipCard?.Equals(other.IsChipCard) == true)) &&
                ((this.IsMagStripCard == null && other.IsMagStripCard == null) || (this.IsMagStripCard?.Equals(other.IsMagStripCard) == true)) &&
                ((this.IsVirtualCard == null && other.IsVirtualCard == null) || (this.IsVirtualCard?.Equals(other.IsVirtualCard) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.PurchaseCategoryId == null && other.PurchaseCategoryId == null) || (this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true)) &&
                ((this.PurchaseCategoryName == null && other.PurchaseCategoryName == null) || (this.PurchaseCategoryName?.Equals(other.PurchaseCategoryName) == true)) &&
                ((this.IsCRT == null && other.IsCRT == null) || (this.IsCRT?.Equals(other.IsCRT) == true)) &&
                ((this.IsFleet == null && other.IsFleet == null) || (this.IsFleet?.Equals(other.IsFleet) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.IsNational == null && other.IsNational == null) || (this.IsNational?.Equals(other.IsNational) == true)) &&
                ((this.IsPartnerSitesIncluded == null && other.IsPartnerSitesIncluded == null) || (this.IsPartnerSitesIncluded?.Equals(other.IsPartnerSitesIncluded) == true)) &&
                ((this.IsShellSitesOnly == null && other.IsShellSitesOnly == null) || (this.IsShellSitesOnly?.Equals(other.IsShellSitesOnly) == true)) &&
                ((this.FuelSets == null && other.FuelSets == null) || (this.FuelSets?.Equals(other.FuelSets) == true)) &&
                ((this.NonFuelSets == null && other.NonFuelSets == null) || (this.NonFuelSets?.Equals(other.NonFuelSets) == true)) &&
                ((this.IssuedDate == null && other.IssuedDate == null) || (this.IssuedDate?.Equals(other.IssuedDate) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true)) &&
                ((this.LastUsedDate == null && other.LastUsedDate == null) || (this.LastUsedDate?.Equals(other.LastUsedDate) == true)) &&
                ((this.MisuseDate == null && other.MisuseDate == null) || (this.MisuseDate?.Equals(other.MisuseDate) == true)) &&
                ((this.Temperature == null && other.Temperature == null) || (this.Temperature?.Equals(other.Temperature) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true)) &&
                ((this.EmbossText == null && other.EmbossText == null) || (this.EmbossText?.Equals(other.EmbossText) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.RenewalDate == null && other.RenewalDate == null) || (this.RenewalDate?.Equals(other.RenewalDate) == true)) &&
                ((this.RenewedCardId == null && other.RenewedCardId == null) || (this.RenewedCardId?.Equals(other.RenewedCardId) == true)) &&
                ((this.RenewedCardStatusId == null && other.RenewedCardStatusId == null) || (this.RenewedCardStatusId?.Equals(other.RenewedCardStatusId) == true)) &&
                ((this.RenewedCardStatus == null && other.RenewedCardStatus == null) || (this.RenewedCardStatus?.Equals(other.RenewedCardStatus) == true)) &&
                ((this.RenewedCardExpiryDate == null && other.RenewedCardExpiryDate == null) || (this.RenewedCardExpiryDate?.Equals(other.RenewedCardExpiryDate) == true)) &&
                ((this.RenewedCardIssueNumber == null && other.RenewedCardIssueNumber == null) || (this.RenewedCardIssueNumber?.Equals(other.RenewedCardIssueNumber) == true)) &&
                ((this.RenewedCardReissueSetting == null && other.RenewedCardReissueSetting == null) || (this.RenewedCardReissueSetting?.Equals(other.RenewedCardReissueSetting) == true)) &&
                ((this.CreationDate == null && other.CreationDate == null) || (this.CreationDate?.Equals(other.CreationDate) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.CardDeliveryAddress == null && other.CardDeliveryAddress == null) || (this.CardDeliveryAddress?.Equals(other.CardDeliveryAddress) == true)) &&
                ((this.PINDeliveryAddress == null && other.PINDeliveryAddress == null) || (this.PINDeliveryAddress?.Equals(other.PINDeliveryAddress) == true)) &&
                ((this.CardBlockSchedules == null && other.CardBlockSchedules == null) || (this.CardBlockSchedules?.Equals(other.CardBlockSchedules) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.StatusId = {(this.StatusId == null ? "null" : this.StatusId.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.OdometerPrompt = {(this.OdometerPrompt == null ? "null" : this.OdometerPrompt.ToString())}");
            toStringOutput.Add($"this.FleetIdPrompt = {(this.FleetIdPrompt == null ? "null" : this.FleetIdPrompt.ToString())}");
            toStringOutput.Add($"this.PINType = {(this.PINType == null ? "null" : this.PINType.ToString())}");
            toStringOutput.Add($"this.HasPIN = {(this.HasPIN == null ? "null" : this.HasPIN.ToString())}");
            toStringOutput.Add($"this.IsSelfSelectedPIN = {(this.IsSelfSelectedPIN == null ? "null" : this.IsSelfSelectedPIN.ToString())}");
            toStringOutput.Add($"this.TemporaryBlockAllowed = {(this.TemporaryBlockAllowed == null ? "null" : this.TemporaryBlockAllowed.ToString())}");
            toStringOutput.Add($"this.UnblockAllowed = {(this.UnblockAllowed == null ? "null" : this.UnblockAllowed.ToString())}");
            toStringOutput.Add($"this.PermanentBlockAllowed = {(this.PermanentBlockAllowed == null ? "null" : this.PermanentBlockAllowed.ToString())}");
            toStringOutput.Add($"this.IssueNumber = {(this.IssueNumber == null ? "null" : this.IssueNumber.ToString())}");
            toStringOutput.Add($"ReissueSetting = {(this.ReissueSetting == null ? "null" : this.ReissueSetting.ToString())}");
            toStringOutput.Add($"this.InternationalPOSLanguageID = {(this.InternationalPOSLanguageID == null ? "null" : this.InternationalPOSLanguageID.ToString())}");
            toStringOutput.Add($"this.InternationalPOSLanguageCode = {(this.InternationalPOSLanguageCode == null ? "null" : this.InternationalPOSLanguageCode.ToString())}");
            toStringOutput.Add($"this.LocalPOSLanguageID = {(this.LocalPOSLanguageID == null ? "null" : this.LocalPOSLanguageID.ToString())}");
            toStringOutput.Add($"this.LocalPOSLanguageCode = {(this.LocalPOSLanguageCode == null ? "null" : this.LocalPOSLanguageCode.ToString())}");
            toStringOutput.Add($"this.CardTypeCode = {(this.CardTypeCode == null ? "null" : this.CardTypeCode)}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.CardTypeName = {(this.CardTypeName == null ? "null" : this.CardTypeName)}");
            toStringOutput.Add($"this.TokenTypeId = {(this.TokenTypeId == null ? "null" : this.TokenTypeId.ToString())}");
            toStringOutput.Add($"this.TokenTypeName = {(this.TokenTypeName == null ? "null" : this.TokenTypeName)}");
            toStringOutput.Add($"this.IsChipCard = {(this.IsChipCard == null ? "null" : this.IsChipCard.ToString())}");
            toStringOutput.Add($"this.IsMagStripCard = {(this.IsMagStripCard == null ? "null" : this.IsMagStripCard.ToString())}");
            toStringOutput.Add($"this.IsVirtualCard = {(this.IsVirtualCard == null ? "null" : this.IsVirtualCard.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryName = {(this.PurchaseCategoryName == null ? "null" : this.PurchaseCategoryName)}");
            toStringOutput.Add($"this.IsCRT = {(this.IsCRT == null ? "null" : this.IsCRT.ToString())}");
            toStringOutput.Add($"this.IsFleet = {(this.IsFleet == null ? "null" : this.IsFleet.ToString())}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"this.IsPartnerSitesIncluded = {(this.IsPartnerSitesIncluded == null ? "null" : this.IsPartnerSitesIncluded.ToString())}");
            toStringOutput.Add($"this.IsShellSitesOnly = {(this.IsShellSitesOnly == null ? "null" : this.IsShellSitesOnly.ToString())}");
            toStringOutput.Add($"this.FuelSets = {(this.FuelSets == null ? "null" : $"[{string.Join(", ", this.FuelSets)} ]")}");
            toStringOutput.Add($"this.NonFuelSets = {(this.NonFuelSets == null ? "null" : $"[{string.Join(", ", this.NonFuelSets)} ]")}");
            toStringOutput.Add($"this.IssuedDate = {(this.IssuedDate == null ? "null" : this.IssuedDate)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
            toStringOutput.Add($"this.LastUsedDate = {(this.LastUsedDate == null ? "null" : this.LastUsedDate)}");
            toStringOutput.Add($"this.MisuseDate = {(this.MisuseDate == null ? "null" : this.MisuseDate)}");
            toStringOutput.Add($"this.Temperature = {(this.Temperature == null ? "null" : this.Temperature)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
            toStringOutput.Add($"this.EmbossText = {(this.EmbossText == null ? "null" : this.EmbossText)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.RenewalDate = {(this.RenewalDate == null ? "null" : this.RenewalDate)}");
            toStringOutput.Add($"this.RenewedCardId = {(this.RenewedCardId == null ? "null" : this.RenewedCardId.ToString())}");
            toStringOutput.Add($"this.RenewedCardStatusId = {(this.RenewedCardStatusId == null ? "null" : this.RenewedCardStatusId.ToString())}");
            toStringOutput.Add($"this.RenewedCardStatus = {(this.RenewedCardStatus == null ? "null" : this.RenewedCardStatus)}");
            toStringOutput.Add($"this.RenewedCardExpiryDate = {(this.RenewedCardExpiryDate == null ? "null" : this.RenewedCardExpiryDate)}");
            toStringOutput.Add($"this.RenewedCardIssueNumber = {(this.RenewedCardIssueNumber == null ? "null" : this.RenewedCardIssueNumber.ToString())}");
            toStringOutput.Add($"this.RenewedCardReissueSetting = {(this.RenewedCardReissueSetting == null ? "null" : this.RenewedCardReissueSetting.ToString())}");
            toStringOutput.Add($"this.CreationDate = {(this.CreationDate == null ? "null" : this.CreationDate)}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate)}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate)}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.CardDeliveryAddress = {(this.CardDeliveryAddress == null ? "null" : this.CardDeliveryAddress.ToString())}");
            toStringOutput.Add($"this.PINDeliveryAddress = {(this.PINDeliveryAddress == null ? "null" : this.PINDeliveryAddress.ToString())}");
            toStringOutput.Add($"this.CardBlockSchedules = {(this.CardBlockSchedules == null ? "null" : $"[{string.Join(", ", this.CardBlockSchedules)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}
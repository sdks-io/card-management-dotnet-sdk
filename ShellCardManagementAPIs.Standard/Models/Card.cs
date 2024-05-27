// <copyright file="Card.cs" company="APIMatic">
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
    /// Card.
    /// </summary>
    public class Card
    {
        private int? accountId;
        private string accountName;
        private string accountNumber;
        private string accountShortName;
        private string bundleId;
        private int? cardGroupId;
        private string cardGroupName;
        private int? cardId;
        private string cardTypeCode;
        private int? cardTypeId;
        private string cardTypeName;
        private string colCoCountryCode;
        private string creationDate;
        private string driverName;
        private string effectiveDate;
        private string expiryDate;
        private string issueDate;
        private string lastModifiedDate;
        private string lastUsedDate;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private string pAN;
        private string purchaseCategoryCode;
        private int? purchaseCategoryId;
        private string purchaseCategoryName;
        private string reason;
        private string reissueSetting;
        private string statusDescription;
        private int? statusId;
        private int? tokenTypeID;
        private string vRN;
        private string clientReferenceId;
        private string rFIDUID;
        private string eMAID;
        private string eVPrintedNumber;
        private string cardMediaCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountName", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "BundleId", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "CardId", false },
            { "CardTypeCode", false },
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "ColCoCountryCode", false },
            { "CreationDate", false },
            { "DriverName", false },
            { "EffectiveDate", false },
            { "ExpiryDate", false },
            { "IssueDate", false },
            { "LastModifiedDate", false },
            { "LastUsedDate", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "PAN", false },
            { "PurchaseCategoryCode", false },
            { "PurchaseCategoryId", false },
            { "PurchaseCategoryName", false },
            { "Reason", false },
            { "ReissueSetting", false },
            { "StatusDescription", false },
            { "StatusId", false },
            { "TokenTypeID", false },
            { "VRN", false },
            { "ClientReferenceId", false },
            { "RFIDUID", false },
            { "EMAID", false },
            { "EVPrintedNumber", false },
            { "CardMediaCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="cardBlockSchedules">CardBlockSchedules.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="creationDate">CreationDate.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="effectiveDate">EffectiveDate.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="fleetIdInput">FleetIdInput.</param>
        /// <param name="isCRT">IsCRT.</param>
        /// <param name="isFleet">IsFleet.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="isPartnerSitesIncluded">IsPartnerSitesIncluded.</param>
        /// <param name="isShellSitesOnly">IsShellSitesOnly.</param>
        /// <param name="issueDate">IssueDate.</param>
        /// <param name="isSuperseded">IsSuperseded.</param>
        /// <param name="isVirtualCard">IsVirtualCard.</param>
        /// <param name="lastModifiedDate">LastModifiedDate.</param>
        /// <param name="lastUsedDate">LastUsedDate.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="odometerInput">OdometerInput.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryName">PurchaseCategoryName.</param>
        /// <param name="reason">Reason.</param>
        /// <param name="reissueSetting">ReissueSetting.</param>
        /// <param name="statusDescription">StatusDescription.</param>
        /// <param name="statusId">StatusId.</param>
        /// <param name="tokenTypeID">TokenTypeID.</param>
        /// <param name="tokenTypeName">TokenTypeName.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="clientReferenceId">ClientReferenceId.</param>
        /// <param name="isEMVContact">IsEMVContact.</param>
        /// <param name="isEMVContactless">IsEMVContactless.</param>
        /// <param name="isRFID">IsRFID.</param>
        /// <param name="rFIDUID">RFIDUID.</param>
        /// <param name="eMAID">EMAID.</param>
        /// <param name="eVPrintedNumber">EVPrintedNumber.</param>
        /// <param name="cardMediaCode">CardMediaCode.</param>
        public Card(
            int? accountId = null,
            string accountName = null,
            string accountNumber = null,
            string accountShortName = null,
            string bundleId = null,
            List<Models.CardBlockSchedule> cardBlockSchedules = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            int? cardId = null,
            string cardTypeCode = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            string colCoCountryCode = null,
            string creationDate = null,
            string driverName = null,
            string effectiveDate = null,
            string expiryDate = null,
            bool? fleetIdInput = null,
            bool? isCRT = null,
            bool? isFleet = null,
            bool? isInternational = null,
            bool? isNational = null,
            bool? isPartnerSitesIncluded = null,
            bool? isShellSitesOnly = null,
            string issueDate = null,
            bool? isSuperseded = null,
            bool? isVirtualCard = null,
            string lastModifiedDate = null,
            string lastUsedDate = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            bool? odometerInput = null,
            string pAN = null,
            string purchaseCategoryCode = null,
            int? purchaseCategoryId = null,
            string purchaseCategoryName = null,
            string reason = null,
            string reissueSetting = null,
            string statusDescription = null,
            int? statusId = null,
            int? tokenTypeID = null,
            string tokenTypeName = null,
            string vRN = null,
            string clientReferenceId = null,
            bool? isEMVContact = null,
            bool? isEMVContactless = null,
            bool? isRFID = null,
            string rFIDUID = null,
            string eMAID = null,
            string eVPrintedNumber = null,
            string cardMediaCode = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }

            this.CardBlockSchedules = cardBlockSchedules;
            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

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

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (creationDate != null)
            {
                this.CreationDate = creationDate;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (effectiveDate != null)
            {
                this.EffectiveDate = effectiveDate;
            }

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }

            this.FleetIdInput = fleetIdInput;
            this.IsCRT = isCRT;
            this.IsFleet = isFleet;
            this.IsInternational = isInternational;
            this.IsNational = isNational;
            this.IsPartnerSitesIncluded = isPartnerSitesIncluded;
            this.IsShellSitesOnly = isShellSitesOnly;
            if (issueDate != null)
            {
                this.IssueDate = issueDate;
            }

            this.IsSuperseded = isSuperseded;
            this.IsVirtualCard = isVirtualCard;
            if (lastModifiedDate != null)
            {
                this.LastModifiedDate = lastModifiedDate;
            }

            if (lastUsedDate != null)
            {
                this.LastUsedDate = lastUsedDate;
            }

            if (localCurrencyCode != null)
            {
                this.LocalCurrencyCode = localCurrencyCode;
            }

            if (localCurrencySymbol != null)
            {
                this.LocalCurrencySymbol = localCurrencySymbol;
            }

            this.OdometerInput = odometerInput;
            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (purchaseCategoryCode != null)
            {
                this.PurchaseCategoryCode = purchaseCategoryCode;
            }

            if (purchaseCategoryId != null)
            {
                this.PurchaseCategoryId = purchaseCategoryId;
            }

            if (purchaseCategoryName != null)
            {
                this.PurchaseCategoryName = purchaseCategoryName;
            }

            if (reason != null)
            {
                this.Reason = reason;
            }

            if (reissueSetting != null)
            {
                this.ReissueSetting = reissueSetting;
            }

            if (statusDescription != null)
            {
                this.StatusDescription = statusDescription;
            }

            if (statusId != null)
            {
                this.StatusId = statusId;
            }

            if (tokenTypeID != null)
            {
                this.TokenTypeID = tokenTypeID;
            }

            this.TokenTypeName = tokenTypeName;
            if (vRN != null)
            {
                this.VRN = vRN;
            }

            if (clientReferenceId != null)
            {
                this.ClientReferenceId = clientReferenceId;
            }

            this.IsEMVContact = isEMVContact;
            this.IsEMVContactless = isEMVContactless;
            this.IsRFID = isRFID;
            if (rFIDUID != null)
            {
                this.RFIDUID = rFIDUID;
            }

            if (eMAID != null)
            {
                this.EMAID = eMAID;
            }

            if (eVPrintedNumber != null)
            {
                this.EVPrintedNumber = eVPrintedNumber;
            }

            if (cardMediaCode != null)
            {
                this.CardMediaCode = cardMediaCode;
            }

        }

        /// <summary>
        /// Account ID
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
        /// Account Name
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
            }
        }

        /// <summary>
        /// Account Number
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
        /// Account Short Name
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
        /// Bundle Id associated with card in the Gateway.<br />
        ///  This field will have null value if the card is not associated with any bundle in Gateway or the value of IncludeBundleDetails in request is false.
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
        /// List of Scheduled Card Blocks details<br />
        /// Entity: CardBlockSchedule
        /// </summary>
        [JsonProperty("CardBlockSchedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardBlockSchedule> CardBlockSchedules { get; set; }

        /// <summary>
        /// Card group ID
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
        /// Card group name
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
        /// Unique Card Id
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
        /// ISO code of the card i.e. first 7 digits of the PAN
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
        /// Card Type ID Example Id and Description: 1 -Philippines CRT 7077861 2-Philippines<br />
        /// Fleet 7002861 5-SHELL FLEET-HONG KONG 7002821 6-SHELL NHF- HONG KONG 7002821 7-SHELL CRT- HONG KONG 7077821
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
        /// Card Type Name Example Id and Description: 1-Philippines CRT 7077861 2-Philippines <br />
        /// Fleet 7002861 5-SHELL FLEET- HONG KONG 7002821 6-SHELL NHF- HONG KONG 7002821 7-SHELL  CRT- HONG KONG 7077821
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
        /// The 2 character ISO Code for the customer and card owning country. <br />
        /// If default card type is not set then the first two alphabets of the account ID is returned.
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
        /// Card Creation datetime.<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: Clients to convert this to appropriate DateTime type.
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
        /// Driver name
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get
            {
                return this.driverName;
            }

            set
            {
                this.shouldSerialize["DriverName"] = true;
                this.driverName = value;
            }
        }

        /// <summary>
        /// Effective date for the Card<br />
        /// Format: yyyyMMdd<br />
        /// Note: Clients to convert this to appropriate DateTime type.
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
        /// Expiry date of the card.<br />
        /// Format: yyyyMMdd<br />
        /// Note: Clients to convert this to appropriate DateTime type.
        /// </summary>
        [JsonProperty("ExpiryDate")]
        public string ExpiryDate
        {
            get
            {
                return this.expiryDate;
            }

            set
            {
                this.shouldSerialize["ExpiryDate"] = true;
                this.expiryDate = value;
            }
        }

        /// <summary>
        /// True/False True if fleet id input is enabled, else false
        /// </summary>
        [JsonProperty("FleetIdInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FleetIdInput { get; set; }

        /// <summary>
        /// True/False True if it is a CRT type card, else false
        /// </summary>
        [JsonProperty("IsCRT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCRT { get; set; }

        /// <summary>
        /// True/False True if it is a Fleet type card, else false
        /// </summary>
        [JsonProperty("IsFleet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFleet { get; set; }

        /// <summary>
        /// True/False True if it is an international card, else false
        /// </summary>
        [JsonProperty("IsInternational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; }

        /// <summary>
        /// True/False True if it is a national card, else false
        /// </summary>
        [JsonProperty("IsNational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNational { get; set; }

        /// <summary>
        /// True/False True if it is allowed at all partner sites, else false
        /// </summary>
        [JsonProperty("IsPartnerSitesIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartnerSitesIncluded { get; set; }

        /// <summary>
        /// True/False True if it is only allowed at Shell sites, else false
        /// </summary>
        [JsonProperty("IsShellSitesOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellSitesOnly { get; set; }

        /// <summary>
        /// Issue date<br />
        /// Format: yyyyMMdd<br />
        /// Note: Clients to convert this to appropriate DateTime type.
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate
        {
            get
            {
                return this.issueDate;
            }

            set
            {
                this.shouldSerialize["IssueDate"] = true;
                this.issueDate = value;
            }
        }

        /// <summary>
        /// True/False True if a new card is issued with the same PAN, else false.
        /// </summary>
        [JsonProperty("IsSuperseded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuperseded { get; set; }

        /// <summary>
        /// True/False True if it is a virtual card, else false
        /// </summary>
        [JsonProperty("IsVirtualCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtualCard { get; set; }

        /// <summary>
        /// Card last modified date and time<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: Clients to convert this to appropriate DateTime type.
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
        /// Card last used date .<br />
        /// Note: last used date of a card will be calculated based on billed/unbilled sales items
        ///       of a given card.The query that extracts the last used dates will be applied on the
        ///       subset of the cards being returned to the client.Unbilled sales items is checked
        ///       first and for those not found in the unbilled table, sales items will be checked
        ///       (only when the last used date is not found in unbilled table for at least a single
        ///       card from the result). The transactions in last 48 hours are not expected to be
        /// Therefore this field gives the correct information up to 48 hours early.<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: Clients to convert this to appropriate DateTime type
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
        /// ISO code of the local currency. <br />
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
        /// Local currency symbol. <br />
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
        /// True/False True if odometer input is enabled on the card, else false
        /// </summary>
        [JsonProperty("OdometerInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OdometerInput { get; set; }

        /// <summary>
        /// Card PAN Mask PAN (Mask all digits except the Last 6 digits of the PAN)
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
        /// Purchase category code
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
        /// Purchase category Id <br />
        /// Note: Not Purchase code.
        /// </summary>
        [JsonProperty("PurchaseCategoryId")]
        public int? PurchaseCategoryId
        {
            get
            {
                return this.purchaseCategoryId;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryId"] = true;
                this.purchaseCategoryId = value;
            }
        }

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
        /// Card Status reason Example: Lost Stolen Card no longer required
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                this.shouldSerialize["Reason"] = true;
                this.reason = value;
            }
        }

        /// <summary>
        /// Reissue setting of the card. If the card is superseded (i.e. a replacement/new card is issued) then reissue setting of the latest card issued. <br />
        /// Values<br />
        /// •True –Card will be Reissued when nearing its expiry date <br />
        /// •False –Card will not be Reissued
        /// </summary>
        [JsonProperty("ReissueSetting")]
        public string ReissueSetting
        {
            get
            {
                return this.reissueSetting;
            }

            set
            {
                this.shouldSerialize["ReissueSetting"] = true;
                this.reissueSetting = value;
            }
        }

        /// <summary>
        /// Status Description (Active, Temporarily Blocked, etc.,)<br />
        /// Possible Ids and description: 1 Active 7 Blocked Card 8 Expired 9 Cancelled 10 New 23 Pending Renewal 31 Replaced 41<br />
        /// Temporary Block(Customer) 42 Temporary Block(Shell) 43 Fraud 101 Active(Block in progress)<br />
        /// * 102 Blocked Card(Unblock in progress) <br />
        /// * 103 Active(Cancel in progress) <br />
        /// * 104 Active(Marked as damaged)<br />
        /// * 105 New(Cancel in progress) <br />
        /// * 106 { Status}(Scheduled for block)<br />
        /// * 107 { Status}(Scheduled for unblock) <br />
        /// *# Note: Items marked with* are intermediate statuses  to indicate that there are pending requests in progress.<br />
        /// The response can contain these intermediate statuses only if the<br />
        /// IncludeIntermediateStatus flag is true. The placeholder { Status} in the items<br />
        /// marked with # will be replaced with the  status description. E.g., Active (Scheduled for block)
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription
        {
            get
            {
                return this.statusDescription;
            }

            set
            {
                this.shouldSerialize["StatusDescription"] = true;
                this.statusDescription = value;
            }
        }

        /// <summary>
        /// Card Status id Possible Ids and description: 1 Active 7 Blocked Card 8 Expired 9 Cancelled 10 New 23 Pending Renewal 31 Replaced 41 Temporary Block(Customer) 42 <br />
        /// Temporary Block(Shell) 43 Fraud 101 Active(Block in progress) <br />
        /// * 102 Blocked Card(Unblock in progress)<br />
        /// * 103 Active(Cancel in progress) <br />
        /// * 104 Active(Marked as damaged) <br />
        /// * 105 New(Cancel in progress)<br />
        /// * 106 { Status}(Scheduled for block) <br />
        /// # 107 {Status}(Scheduled for unblock)<br />
        /// *# Note: Items marked with* are intermediate statuses to indicate that there are pending requests in progress.<br />
        /// The response can contain these intermediate statuses only if the IncludeIntermediateStatus flag is true.<br />
        /// The placeholder { Status} in the items marked with # will be replaced with<br />
        /// the status description. E.g., Active (Scheduled for block)
        /// </summary>
        [JsonProperty("StatusId")]
        public int? StatusId
        {
            get
            {
                return this.statusId;
            }

            set
            {
                this.shouldSerialize["StatusId"] = true;
                this.statusId = value;
            }
        }

        /// <summary>
        /// Token Type ID configured for the Card E.g. 107
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
        /// Token Type Name configured for the Card
        /// </summary>
        [JsonProperty("TokenTypeName", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenTypeName { get; set; }

        /// <summary>
        /// Vehicle registration number
        /// </summary>
        [JsonProperty("VRN")]
        public string VRN
        {
            get
            {
                return this.vRN;
            }

            set
            {
                this.shouldSerialize["VRN"] = true;
                this.vRN = value;
            }
        }

        /// <summary>
        /// Customer reference number of the card.
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
        /// Is Europay, MasterCard, and Visa Contact enabled or not.
        /// </summary>
        [JsonProperty("IsEMVContact", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEMVContact { get; set; }

        /// <summary>
        /// Is Europay, MasterCard, and Visa Contactless enabled or not.
        /// </summary>
        [JsonProperty("IsEMVContactless", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEMVContactless { get; set; }

        /// <summary>
        /// Whether the card type is enabled for RFID (Radio Frequency Identification)
        /// </summary>
        [JsonProperty("IsRFID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRFID { get; set; }

        /// <summary>
        /// RFIDUID
        /// </summary>
        [JsonProperty("RFIDUID")]
        public string RFIDUID
        {
            get
            {
                return this.rFIDUID;
            }

            set
            {
                this.shouldSerialize["RFIDUID"] = true;
                this.rFIDUID = value;
            }
        }

        /// <summary>
        /// EMAID
        /// </summary>
        [JsonProperty("EMAID")]
        public string EMAID
        {
            get
            {
                return this.eMAID;
            }

            set
            {
                this.shouldSerialize["EMAID"] = true;
                this.eMAID = value;
            }
        }

        /// <summary>
        /// EV Printed Number
        /// </summary>
        [JsonProperty("EVPrintedNumber")]
        public string EVPrintedNumber
        {
            get
            {
                return this.eVPrintedNumber;
            }

            set
            {
                this.shouldSerialize["EVPrintedNumber"] = true;
                this.eVPrintedNumber = value;
            }
        }

        /// <summary>
        /// Card Media Code.
        /// </summary>
        [JsonProperty("CardMediaCode")]
        public string CardMediaCode
        {
            get
            {
                return this.cardMediaCode;
            }

            set
            {
                this.shouldSerialize["CardMediaCode"] = true;
                this.cardMediaCode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Card : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
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
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
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
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
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
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
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
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
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
        public void UnsetExpiryDate()
        {
            this.shouldSerialize["ExpiryDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssueDate()
        {
            this.shouldSerialize["IssueDate"] = false;
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
        public void UnsetLastUsedDate()
        {
            this.shouldSerialize["LastUsedDate"] = false;
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
        public void UnsetPurchaseCategoryCode()
        {
            this.shouldSerialize["PurchaseCategoryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchaseCategoryId()
        {
            this.shouldSerialize["PurchaseCategoryId"] = false;
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
        public void UnsetReason()
        {
            this.shouldSerialize["Reason"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReissueSetting()
        {
            this.shouldSerialize["ReissueSetting"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatusDescription()
        {
            this.shouldSerialize["StatusDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatusId()
        {
            this.shouldSerialize["StatusId"] = false;
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
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
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
        public void UnsetRFIDUID()
        {
            this.shouldSerialize["RFIDUID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEMAID()
        {
            this.shouldSerialize["EMAID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVPrintedNumber()
        {
            this.shouldSerialize["EVPrintedNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardMediaCode()
        {
            this.shouldSerialize["CardMediaCode"] = false;
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
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
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
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
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
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
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
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
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
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
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
        public bool ShouldSerializeExpiryDate()
        {
            return this.shouldSerialize["ExpiryDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssueDate()
        {
            return this.shouldSerialize["IssueDate"];
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
        public bool ShouldSerializeLastUsedDate()
        {
            return this.shouldSerialize["LastUsedDate"];
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
        public bool ShouldSerializePurchaseCategoryCode()
        {
            return this.shouldSerialize["PurchaseCategoryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategoryId()
        {
            return this.shouldSerialize["PurchaseCategoryId"];
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
        public bool ShouldSerializeReason()
        {
            return this.shouldSerialize["Reason"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReissueSetting()
        {
            return this.shouldSerialize["ReissueSetting"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatusDescription()
        {
            return this.shouldSerialize["StatusDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatusId()
        {
            return this.shouldSerialize["StatusId"];
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
        public bool ShouldSerializeVRN()
        {
            return this.shouldSerialize["VRN"];
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
        public bool ShouldSerializeRFIDUID()
        {
            return this.shouldSerialize["RFIDUID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEMAID()
        {
            return this.shouldSerialize["EMAID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVPrintedNumber()
        {
            return this.shouldSerialize["EVPrintedNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardMediaCode()
        {
            return this.shouldSerialize["CardMediaCode"];
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
            return obj is Card other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.CardBlockSchedules == null && other.CardBlockSchedules == null) || (this.CardBlockSchedules?.Equals(other.CardBlockSchedules) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardTypeCode == null && other.CardTypeCode == null) || (this.CardTypeCode?.Equals(other.CardTypeCode) == true)) &&
                ((this.CardTypeId == null && other.CardTypeId == null) || (this.CardTypeId?.Equals(other.CardTypeId) == true)) &&
                ((this.CardTypeName == null && other.CardTypeName == null) || (this.CardTypeName?.Equals(other.CardTypeName) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.CreationDate == null && other.CreationDate == null) || (this.CreationDate?.Equals(other.CreationDate) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true)) &&
                ((this.FleetIdInput == null && other.FleetIdInput == null) || (this.FleetIdInput?.Equals(other.FleetIdInput) == true)) &&
                ((this.IsCRT == null && other.IsCRT == null) || (this.IsCRT?.Equals(other.IsCRT) == true)) &&
                ((this.IsFleet == null && other.IsFleet == null) || (this.IsFleet?.Equals(other.IsFleet) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.IsNational == null && other.IsNational == null) || (this.IsNational?.Equals(other.IsNational) == true)) &&
                ((this.IsPartnerSitesIncluded == null && other.IsPartnerSitesIncluded == null) || (this.IsPartnerSitesIncluded?.Equals(other.IsPartnerSitesIncluded) == true)) &&
                ((this.IsShellSitesOnly == null && other.IsShellSitesOnly == null) || (this.IsShellSitesOnly?.Equals(other.IsShellSitesOnly) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.IsSuperseded == null && other.IsSuperseded == null) || (this.IsSuperseded?.Equals(other.IsSuperseded) == true)) &&
                ((this.IsVirtualCard == null && other.IsVirtualCard == null) || (this.IsVirtualCard?.Equals(other.IsVirtualCard) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.LastUsedDate == null && other.LastUsedDate == null) || (this.LastUsedDate?.Equals(other.LastUsedDate) == true)) &&
                ((this.LocalCurrencyCode == null && other.LocalCurrencyCode == null) || (this.LocalCurrencyCode?.Equals(other.LocalCurrencyCode) == true)) &&
                ((this.LocalCurrencySymbol == null && other.LocalCurrencySymbol == null) || (this.LocalCurrencySymbol?.Equals(other.LocalCurrencySymbol) == true)) &&
                ((this.OdometerInput == null && other.OdometerInput == null) || (this.OdometerInput?.Equals(other.OdometerInput) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.PurchaseCategoryId == null && other.PurchaseCategoryId == null) || (this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true)) &&
                ((this.PurchaseCategoryName == null && other.PurchaseCategoryName == null) || (this.PurchaseCategoryName?.Equals(other.PurchaseCategoryName) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReissueSetting == null && other.ReissueSetting == null) || (this.ReissueSetting?.Equals(other.ReissueSetting) == true)) &&
                ((this.StatusDescription == null && other.StatusDescription == null) || (this.StatusDescription?.Equals(other.StatusDescription) == true)) &&
                ((this.StatusId == null && other.StatusId == null) || (this.StatusId?.Equals(other.StatusId) == true)) &&
                ((this.TokenTypeID == null && other.TokenTypeID == null) || (this.TokenTypeID?.Equals(other.TokenTypeID) == true)) &&
                ((this.TokenTypeName == null && other.TokenTypeName == null) || (this.TokenTypeName?.Equals(other.TokenTypeName) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true)) &&
                ((this.ClientReferenceId == null && other.ClientReferenceId == null) || (this.ClientReferenceId?.Equals(other.ClientReferenceId) == true)) &&
                ((this.IsEMVContact == null && other.IsEMVContact == null) || (this.IsEMVContact?.Equals(other.IsEMVContact) == true)) &&
                ((this.IsEMVContactless == null && other.IsEMVContactless == null) || (this.IsEMVContactless?.Equals(other.IsEMVContactless) == true)) &&
                ((this.IsRFID == null && other.IsRFID == null) || (this.IsRFID?.Equals(other.IsRFID) == true)) &&
                ((this.RFIDUID == null && other.RFIDUID == null) || (this.RFIDUID?.Equals(other.RFIDUID) == true)) &&
                ((this.EMAID == null && other.EMAID == null) || (this.EMAID?.Equals(other.EMAID) == true)) &&
                ((this.EVPrintedNumber == null && other.EVPrintedNumber == null) || (this.EVPrintedNumber?.Equals(other.EVPrintedNumber) == true)) &&
                ((this.CardMediaCode == null && other.CardMediaCode == null) || (this.CardMediaCode?.Equals(other.CardMediaCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId)}");
            toStringOutput.Add($"this.CardBlockSchedules = {(this.CardBlockSchedules == null ? "null" : $"[{string.Join(", ", this.CardBlockSchedules)} ]")}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardTypeCode = {(this.CardTypeCode == null ? "null" : this.CardTypeCode)}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.CardTypeName = {(this.CardTypeName == null ? "null" : this.CardTypeName)}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.CreationDate = {(this.CreationDate == null ? "null" : this.CreationDate)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
            toStringOutput.Add($"this.FleetIdInput = {(this.FleetIdInput == null ? "null" : this.FleetIdInput.ToString())}");
            toStringOutput.Add($"this.IsCRT = {(this.IsCRT == null ? "null" : this.IsCRT.ToString())}");
            toStringOutput.Add($"this.IsFleet = {(this.IsFleet == null ? "null" : this.IsFleet.ToString())}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"this.IsPartnerSitesIncluded = {(this.IsPartnerSitesIncluded == null ? "null" : this.IsPartnerSitesIncluded.ToString())}");
            toStringOutput.Add($"this.IsShellSitesOnly = {(this.IsShellSitesOnly == null ? "null" : this.IsShellSitesOnly.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate)}");
            toStringOutput.Add($"this.IsSuperseded = {(this.IsSuperseded == null ? "null" : this.IsSuperseded.ToString())}");
            toStringOutput.Add($"this.IsVirtualCard = {(this.IsVirtualCard == null ? "null" : this.IsVirtualCard.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate)}");
            toStringOutput.Add($"this.LastUsedDate = {(this.LastUsedDate == null ? "null" : this.LastUsedDate)}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.OdometerInput = {(this.OdometerInput == null ? "null" : this.OdometerInput.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryName = {(this.PurchaseCategoryName == null ? "null" : this.PurchaseCategoryName)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReissueSetting = {(this.ReissueSetting == null ? "null" : this.ReissueSetting)}");
            toStringOutput.Add($"this.StatusDescription = {(this.StatusDescription == null ? "null" : this.StatusDescription)}");
            toStringOutput.Add($"this.StatusId = {(this.StatusId == null ? "null" : this.StatusId.ToString())}");
            toStringOutput.Add($"this.TokenTypeID = {(this.TokenTypeID == null ? "null" : this.TokenTypeID.ToString())}");
            toStringOutput.Add($"this.TokenTypeName = {(this.TokenTypeName == null ? "null" : this.TokenTypeName)}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
            toStringOutput.Add($"this.ClientReferenceId = {(this.ClientReferenceId == null ? "null" : this.ClientReferenceId)}");
            toStringOutput.Add($"this.IsEMVContact = {(this.IsEMVContact == null ? "null" : this.IsEMVContact.ToString())}");
            toStringOutput.Add($"this.IsEMVContactless = {(this.IsEMVContactless == null ? "null" : this.IsEMVContactless.ToString())}");
            toStringOutput.Add($"this.IsRFID = {(this.IsRFID == null ? "null" : this.IsRFID.ToString())}");
            toStringOutput.Add($"this.RFIDUID = {(this.RFIDUID == null ? "null" : this.RFIDUID)}");
            toStringOutput.Add($"this.EMAID = {(this.EMAID == null ? "null" : this.EMAID)}");
            toStringOutput.Add($"this.EVPrintedNumber = {(this.EVPrintedNumber == null ? "null" : this.EVPrintedNumber)}");
            toStringOutput.Add($"this.CardMediaCode = {(this.CardMediaCode == null ? "null" : this.CardMediaCode)}");
        }
    }
}
// <copyright file="RestrictionSearchCardResponseDataItems.cs" company="APIMatic">
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
    /// RestrictionSearchCardResponseDataItems.
    /// </summary>
    public class RestrictionSearchCardResponseDataItems
    {
        private string restrictionCurrencyCode;
        private string restrictionCurrencySymbol;
        private int? accountId;
        private string accountName;
        private string accountNumber;
        private string accountShortName;
        private int? cardId;
        private string cardTypeCode;
        private int? cardTypeId;
        private string cardTypeName;
        private string colCoCurrencyCode;
        private string colCoCurrencySymbol;
        private string currencyCode;
        private string currencySymbol;
        private string driverName;
        private string expiryDate;
        private string issueDate;
        private int? issueNumber;
        private string pAN;
        private string purchaseCategoryCode;
        private int? purchaseCategoryId;
        private string purchaseCategoryName;
        private string statusDescription;
        private int? statusId;
        private string vRN;
        private int? mediumTypeID;
        private string mediumType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RestrictionCurrencyCode", false },
            { "RestrictionCurrencySymbol", false },
            { "AccountId", false },
            { "AccountName", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "CardId", false },
            { "CardTypeCode", false },
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "ColCoCurrencyCode", false },
            { "ColCoCurrencySymbol", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "DriverName", false },
            { "ExpiryDate", false },
            { "IssueDate", false },
            { "IssueNumber", false },
            { "PAN", false },
            { "PurchaseCategoryCode", false },
            { "PurchaseCategoryId", false },
            { "PurchaseCategoryName", false },
            { "StatusDescription", false },
            { "StatusId", false },
            { "VRN", false },
            { "MediumTypeID", false },
            { "MediumType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardResponseDataItems"/> class.
        /// </summary>
        public RestrictionSearchCardResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionSearchCardResponseDataItems"/> class.
        /// </summary>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="restrictions">Restrictions.</param>
        /// <param name="restrictionCurrencyCode">RestrictionCurrencyCode.</param>
        /// <param name="restrictionCurrencySymbol">RestrictionCurrencySymbol.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="colCoCurrencyCode">ColCoCurrencyCode.</param>
        /// <param name="colCoCurrencySymbol">ColCoCurrencySymbol.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="isCRT">IsCRT.</param>
        /// <param name="isFleet">IsFleet.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="isPartnerSitesIncluded">IsPartnerSitesIncluded.</param>
        /// <param name="isShellSitesOnly">IsShellSitesOnly.</param>
        /// <param name="issueDate">IssueDate.</param>
        /// <param name="issueNumber">IssueNumber.</param>
        /// <param name="isSuperseded">IsSuperseded.</param>
        /// <param name="isVirtualCard">IsVirtualCard.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryName">PurchaseCategoryName.</param>
        /// <param name="statusDescription">StatusDescription.</param>
        /// <param name="statusId">StatusId.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="mediumTypeID">MediumTypeID.</param>
        /// <param name="mediumType">MediumType.</param>
        public RestrictionSearchCardResponseDataItems(
            int? bundleId = null,
            Models.SearchCardResponseRestrictions restrictions = null,
            string restrictionCurrencyCode = null,
            string restrictionCurrencySymbol = null,
            int? accountId = null,
            string accountName = null,
            string accountNumber = null,
            string accountShortName = null,
            int? cardId = null,
            string cardTypeCode = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            string colCoCurrencyCode = null,
            string colCoCurrencySymbol = null,
            string currencyCode = null,
            string currencySymbol = null,
            string driverName = null,
            string expiryDate = null,
            bool? isCRT = null,
            bool? isFleet = null,
            bool? isInternational = null,
            bool? isNational = null,
            bool? isPartnerSitesIncluded = null,
            bool? isShellSitesOnly = null,
            string issueDate = null,
            int? issueNumber = null,
            bool? isSuperseded = null,
            bool? isVirtualCard = null,
            string pAN = null,
            string purchaseCategoryCode = null,
            int? purchaseCategoryId = null,
            string purchaseCategoryName = null,
            string statusDescription = null,
            int? statusId = null,
            string vRN = null,
            int? mediumTypeID = null,
            string mediumType = null)
        {
            this.BundleId = bundleId;
            this.Restrictions = restrictions;
            if (restrictionCurrencyCode != null)
            {
                this.RestrictionCurrencyCode = restrictionCurrencyCode;
            }

            if (restrictionCurrencySymbol != null)
            {
                this.RestrictionCurrencySymbol = restrictionCurrencySymbol;
            }

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

            if (colCoCurrencyCode != null)
            {
                this.ColCoCurrencyCode = colCoCurrencyCode;
            }

            if (colCoCurrencySymbol != null)
            {
                this.ColCoCurrencySymbol = colCoCurrencySymbol;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }

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

            if (issueNumber != null)
            {
                this.IssueNumber = issueNumber;
            }

            this.IsSuperseded = isSuperseded;
            this.IsVirtualCard = isVirtualCard;
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

            if (statusDescription != null)
            {
                this.StatusDescription = statusDescription;
            }

            if (statusId != null)
            {
                this.StatusId = statusId;
            }

            if (vRN != null)
            {
                this.VRN = vRN;
            }

            if (mediumTypeID != null)
            {
                this.MediumTypeID = mediumTypeID;
            }

            if (mediumType != null)
            {
                this.MediumType = mediumType;
            }

        }

        /// <summary>
        /// Bundle Id associated with card
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public int? BundleId { get; set; }

        /// <summary>
        /// Gets or sets Restrictions.
        /// </summary>
        [JsonProperty("Restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchCardResponseRestrictions Restrictions { get; set; }

        /// <summary>
        /// ISO currency code of the country.
        /// </summary>
        [JsonProperty("RestrictionCurrencyCode")]
        public string RestrictionCurrencyCode
        {
            get
            {
                return this.restrictionCurrencyCode;
            }

            set
            {
                this.shouldSerialize["RestrictionCurrencyCode"] = true;
                this.restrictionCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the country.
        /// </summary>
        [JsonProperty("RestrictionCurrencySymbol")]
        public string RestrictionCurrencySymbol
        {
            get
            {
                return this.restrictionCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["RestrictionCurrencySymbol"] = true;
                this.restrictionCurrencySymbol = value;
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
        /// AccountShortName
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
        /// Unique Card
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
        /// <![CDATA[
        /// Card Type ID
        /// Example Id & Description:
        /// 1 - Philippines CRT 7077861
        /// 2- Philippines Fleet 7002861
        /// 5-SHELL FLEET- HONG KONG 7002821
        /// 6-SHELL NHF- HONG KONG 7002821
        /// 7-SHELL CRT- HONG KONG 7077821
        /// ]]>
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
        /// <![CDATA[
        /// Card Type Name
        /// Example Id & Description:
        /// 1 - Philippines CRT 7077861
        /// 2- Philippines Fleet 7002861
        /// 5-SHELL FLEET- HONG KONG 7002821
        /// 6-SHELL NHF- HONG KONG 7002821
        /// 7-SHELL CRT- HONG KONG 7077821
        /// ]]>
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
        /// ISO currency code of the country
        /// </summary>
        [JsonProperty("ColCoCurrencyCode")]
        public string ColCoCurrencyCode
        {
            get
            {
                return this.colCoCurrencyCode;
            }

            set
            {
                this.shouldSerialize["ColCoCurrencyCode"] = true;
                this.colCoCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the country
        /// </summary>
        [JsonProperty("ColCoCurrencySymbol")]
        public string ColCoCurrencySymbol
        {
            get
            {
                return this.colCoCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["ColCoCurrencySymbol"] = true;
                this.colCoCurrencySymbol = value;
            }
        }

        /// <summary>
        /// ISO currency code of the Customer Currency
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }

            set
            {
                this.shouldSerialize["CurrencyCode"] = true;
                this.currencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the Customer Currency Code
        /// </summary>
        [JsonProperty("CurrencySymbol")]
        public string CurrencySymbol
        {
            get
            {
                return this.currencySymbol;
            }

            set
            {
                this.shouldSerialize["CurrencySymbol"] = true;
                this.currencySymbol = value;
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
        /// Expiry date of the card
        /// Format: yyyyMMdd
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
        /// True if it is a CRT type card, else false
        /// </summary>
        [JsonProperty("IsCRT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCRT { get; set; }

        /// <summary>
        /// True if it is a Fleet type card, else false
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
        /// Issue date
        /// Format: yyyyMMdd
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
        /// Issue Number
        /// </summary>
        [JsonProperty("IssueNumber")]
        public int? IssueNumber
        {
            get
            {
                return this.issueNumber;
            }

            set
            {
                this.shouldSerialize["IssueNumber"] = true;
                this.issueNumber = value;
            }
        }

        /// <summary>
        /// True if a new card is issued with the same PAN, else false
        /// </summary>
        [JsonProperty("IsSuperseded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuperseded { get; set; }

        /// <summary>
        /// True if it is a virtual card, else false
        /// </summary>
        [JsonProperty("IsVirtualCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtualCard { get; set; }

        /// <summary>
        /// Card PAN
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
        /// Example:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - FuelSave only
        /// 2 - FuelSave and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and FuelSave
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and FuelSave and Lubricants
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
        /// Purchase category Id
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
        /// Example:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - FuelSave only
        /// 2 - FuelSave and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and FuelSave
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and FuelSave and Lubricants
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
        /// Status Description (Active, Temporarily Blocked, etc.,)
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
        /// Card Status id
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
        /// Id of the medium type identifier.
        /// Example: 1,2,4
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 4 - Fuel Card and Key fob Card
        /// 5 - Key fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 – Smartpay
        /// </summary>
        [JsonProperty("MediumTypeID")]
        public int? MediumTypeID
        {
            get
            {
                return this.mediumTypeID;
            }

            set
            {
                this.shouldSerialize["MediumTypeID"] = true;
                this.mediumTypeID = value;
            }
        }

        /// <summary>
        /// Name of the medium type identifier.
        /// Example: Fuel Card, Fuel Card with EV, Key fob
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 4 - Fuel Card and Key fob Card
        /// 5 - Key fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 - Smartpay
        /// </summary>
        [JsonProperty("MediumType")]
        public string MediumType
        {
            get
            {
                return this.mediumType;
            }

            set
            {
                this.shouldSerialize["MediumType"] = true;
                this.mediumType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictionSearchCardResponseDataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRestrictionCurrencyCode()
        {
            this.shouldSerialize["RestrictionCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRestrictionCurrencySymbol()
        {
            this.shouldSerialize["RestrictionCurrencySymbol"] = false;
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
        public void UnsetColCoCurrencyCode()
        {
            this.shouldSerialize["ColCoCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCurrencySymbol()
        {
            this.shouldSerialize["ColCoCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrencyCode()
        {
            this.shouldSerialize["CurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrencySymbol()
        {
            this.shouldSerialize["CurrencySymbol"] = false;
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
        public void UnsetIssueNumber()
        {
            this.shouldSerialize["IssueNumber"] = false;
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
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMediumTypeID()
        {
            this.shouldSerialize["MediumTypeID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMediumType()
        {
            this.shouldSerialize["MediumType"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRestrictionCurrencyCode()
        {
            return this.shouldSerialize["RestrictionCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRestrictionCurrencySymbol()
        {
            return this.shouldSerialize["RestrictionCurrencySymbol"];
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
        public bool ShouldSerializeColCoCurrencyCode()
        {
            return this.shouldSerialize["ColCoCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCurrencySymbol()
        {
            return this.shouldSerialize["ColCoCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrencyCode()
        {
            return this.shouldSerialize["CurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrencySymbol()
        {
            return this.shouldSerialize["CurrencySymbol"];
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
        public bool ShouldSerializeIssueNumber()
        {
            return this.shouldSerialize["IssueNumber"];
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
        public bool ShouldSerializeVRN()
        {
            return this.shouldSerialize["VRN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMediumTypeID()
        {
            return this.shouldSerialize["MediumTypeID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMediumType()
        {
            return this.shouldSerialize["MediumType"];
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
            return obj is RestrictionSearchCardResponseDataItems other &&                ((this.BundleId == null && other.BundleId == null) || (this.BundleId?.Equals(other.BundleId) == true)) &&
                ((this.Restrictions == null && other.Restrictions == null) || (this.Restrictions?.Equals(other.Restrictions) == true)) &&
                ((this.RestrictionCurrencyCode == null && other.RestrictionCurrencyCode == null) || (this.RestrictionCurrencyCode?.Equals(other.RestrictionCurrencyCode) == true)) &&
                ((this.RestrictionCurrencySymbol == null && other.RestrictionCurrencySymbol == null) || (this.RestrictionCurrencySymbol?.Equals(other.RestrictionCurrencySymbol) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardTypeCode == null && other.CardTypeCode == null) || (this.CardTypeCode?.Equals(other.CardTypeCode) == true)) &&
                ((this.CardTypeId == null && other.CardTypeId == null) || (this.CardTypeId?.Equals(other.CardTypeId) == true)) &&
                ((this.CardTypeName == null && other.CardTypeName == null) || (this.CardTypeName?.Equals(other.CardTypeName) == true)) &&
                ((this.ColCoCurrencyCode == null && other.ColCoCurrencyCode == null) || (this.ColCoCurrencyCode?.Equals(other.ColCoCurrencyCode) == true)) &&
                ((this.ColCoCurrencySymbol == null && other.ColCoCurrencySymbol == null) || (this.ColCoCurrencySymbol?.Equals(other.ColCoCurrencySymbol) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true)) &&
                ((this.IsCRT == null && other.IsCRT == null) || (this.IsCRT?.Equals(other.IsCRT) == true)) &&
                ((this.IsFleet == null && other.IsFleet == null) || (this.IsFleet?.Equals(other.IsFleet) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.IsNational == null && other.IsNational == null) || (this.IsNational?.Equals(other.IsNational) == true)) &&
                ((this.IsPartnerSitesIncluded == null && other.IsPartnerSitesIncluded == null) || (this.IsPartnerSitesIncluded?.Equals(other.IsPartnerSitesIncluded) == true)) &&
                ((this.IsShellSitesOnly == null && other.IsShellSitesOnly == null) || (this.IsShellSitesOnly?.Equals(other.IsShellSitesOnly) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.IssueNumber == null && other.IssueNumber == null) || (this.IssueNumber?.Equals(other.IssueNumber) == true)) &&
                ((this.IsSuperseded == null && other.IsSuperseded == null) || (this.IsSuperseded?.Equals(other.IsSuperseded) == true)) &&
                ((this.IsVirtualCard == null && other.IsVirtualCard == null) || (this.IsVirtualCard?.Equals(other.IsVirtualCard) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.PurchaseCategoryId == null && other.PurchaseCategoryId == null) || (this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true)) &&
                ((this.PurchaseCategoryName == null && other.PurchaseCategoryName == null) || (this.PurchaseCategoryName?.Equals(other.PurchaseCategoryName) == true)) &&
                ((this.StatusDescription == null && other.StatusDescription == null) || (this.StatusDescription?.Equals(other.StatusDescription) == true)) &&
                ((this.StatusId == null && other.StatusId == null) || (this.StatusId?.Equals(other.StatusId) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true)) &&
                ((this.MediumTypeID == null && other.MediumTypeID == null) || (this.MediumTypeID?.Equals(other.MediumTypeID) == true)) &&
                ((this.MediumType == null && other.MediumType == null) || (this.MediumType?.Equals(other.MediumType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BundleId = {(this.BundleId == null ? "null" : this.BundleId.ToString())}");
            toStringOutput.Add($"this.Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
            toStringOutput.Add($"this.RestrictionCurrencyCode = {(this.RestrictionCurrencyCode == null ? "null" : this.RestrictionCurrencyCode)}");
            toStringOutput.Add($"this.RestrictionCurrencySymbol = {(this.RestrictionCurrencySymbol == null ? "null" : this.RestrictionCurrencySymbol)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardTypeCode = {(this.CardTypeCode == null ? "null" : this.CardTypeCode)}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.CardTypeName = {(this.CardTypeName == null ? "null" : this.CardTypeName)}");
            toStringOutput.Add($"this.ColCoCurrencyCode = {(this.ColCoCurrencyCode == null ? "null" : this.ColCoCurrencyCode)}");
            toStringOutput.Add($"this.ColCoCurrencySymbol = {(this.ColCoCurrencySymbol == null ? "null" : this.ColCoCurrencySymbol)}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
            toStringOutput.Add($"this.IsCRT = {(this.IsCRT == null ? "null" : this.IsCRT.ToString())}");
            toStringOutput.Add($"this.IsFleet = {(this.IsFleet == null ? "null" : this.IsFleet.ToString())}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"this.IsPartnerSitesIncluded = {(this.IsPartnerSitesIncluded == null ? "null" : this.IsPartnerSitesIncluded.ToString())}");
            toStringOutput.Add($"this.IsShellSitesOnly = {(this.IsShellSitesOnly == null ? "null" : this.IsShellSitesOnly.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate)}");
            toStringOutput.Add($"this.IssueNumber = {(this.IssueNumber == null ? "null" : this.IssueNumber.ToString())}");
            toStringOutput.Add($"this.IsSuperseded = {(this.IsSuperseded == null ? "null" : this.IsSuperseded.ToString())}");
            toStringOutput.Add($"this.IsVirtualCard = {(this.IsVirtualCard == null ? "null" : this.IsVirtualCard.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryName = {(this.PurchaseCategoryName == null ? "null" : this.PurchaseCategoryName)}");
            toStringOutput.Add($"this.StatusDescription = {(this.StatusDescription == null ? "null" : this.StatusDescription)}");
            toStringOutput.Add($"this.StatusId = {(this.StatusId == null ? "null" : this.StatusId.ToString())}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
            toStringOutput.Add($"this.MediumTypeID = {(this.MediumTypeID == null ? "null" : this.MediumTypeID.ToString())}");
            toStringOutput.Add($"this.MediumType = {(this.MediumType == null ? "null" : this.MediumType)}");
        }
    }
}
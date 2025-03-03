// <copyright file="CardTypeResponseCustomerCardTypesItems.cs" company="APIMatic">
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
    /// CardTypeResponseCustomerCardTypesItems.
    /// </summary>
    public class CardTypeResponseCustomerCardTypesItems
    {
        private int? cardTypeId;
        private string cardTypeName;
        private string colCoCurrencyCode;
        private int? customerCardTypeId;
        private int? defaultPurchaseCategoryId;
        private string embossAccountName;
        private int? expiryPeriod;
        private int? pANLength;
        private List<Models.PurchaseCategories> purchaseCategories;
        private int? tokenTypeId;
        private string tokenTypeName;
        private int? mediumTypeID;
        private string mediumType;
        private string colCoCurrencySymbol;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "ColCoCurrencyCode", false },
            { "CustomerCardTypeId", false },
            { "DefaultPurchaseCategoryId", false },
            { "EmbossAccountName", false },
            { "ExpiryPeriod", false },
            { "PANLength", false },
            { "PurchaseCategories", false },
            { "TokenTypeId", false },
            { "TokenTypeName", false },
            { "MediumTypeID", false },
            { "MediumType", false },
            { "ColCoCurrencySymbol", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeResponseCustomerCardTypesItems"/> class.
        /// </summary>
        public CardTypeResponseCustomerCardTypesItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeResponseCustomerCardTypesItems"/> class.
        /// </summary>
        /// <param name="canHavePIN">CanHavePIN.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="colCoCurrencyCode">ColCoCurrencyCode.</param>
        /// <param name="customerCardTypeId">CustomerCardTypeId.</param>
        /// <param name="dayTimeRestrictions">DayTimeRestrictions.</param>
        /// <param name="defaultPurchaseCategoryId">DefaultPurchaseCategoryId.</param>
        /// <param name="embossAccountName">EmbossAccountName.</param>
        /// <param name="expiryPeriod">ExpiryPeriod.</param>
        /// <param name="isCRT">IsCRT.</param>
        /// <param name="isFleet">IsFleet.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="isPartnerSitesIncluded">IsPartnerSitesIncluded.</param>
        /// <param name="isShellSitesOnly">IsShellSitesOnly.</param>
        /// <param name="isVirtual">IsVirtual.</param>
        /// <param name="isVisibleToCustomers">IsVisibleToCustomers.</param>
        /// <param name="isActive">IsActive.</param>
        /// <param name="isCardAvailableForDownload">IsCardAvailableForDownload.</param>
        /// <param name="isCardVisibleToCustomers">IsCardVisibleToCustomers.</param>
        /// <param name="pANLength">PANLength.</param>
        /// <param name="purchaseCategories">PurchaseCategories.</param>
        /// <param name="tokenTypeId">TokenTypeId.</param>
        /// <param name="tokenTypeName">TokenTypeName.</param>
        /// <param name="usageRestrictions">UsageRestrictions.</param>
        /// <param name="eMVContactless">EMVContactless.</param>
        /// <param name="rFID">RFID.</param>
        /// <param name="pINChangeSupported">PINChangeSupported.</param>
        /// <param name="requirePIN">RequirePIN.</param>
        /// <param name="offlinePIN">OfflinePIN.</param>
        /// <param name="isDefault">IsDefault.</param>
        /// <param name="applicationsToShowNPIITokens">ApplicationsToShowNPIITokens.</param>
        /// <param name="mediumTypeID">MediumTypeID.</param>
        /// <param name="mediumType">MediumType.</param>
        /// <param name="colCoCurrencySymbol">ColCoCurrencySymbol.</param>
        public CardTypeResponseCustomerCardTypesItems(
            bool? canHavePIN = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            string colCoCurrencyCode = null,
            int? customerCardTypeId = null,
            Models.CardDayTimeRestrictions dayTimeRestrictions = null,
            int? defaultPurchaseCategoryId = null,
            string embossAccountName = null,
            int? expiryPeriod = null,
            bool? isCRT = null,
            bool? isFleet = null,
            bool? isInternational = null,
            bool? isNational = null,
            bool? isPartnerSitesIncluded = null,
            bool? isShellSitesOnly = null,
            bool? isVirtual = null,
            bool? isVisibleToCustomers = null,
            bool? isActive = null,
            bool? isCardAvailableForDownload = null,
            bool? isCardVisibleToCustomers = null,
            int? pANLength = null,
            List<Models.PurchaseCategories> purchaseCategories = null,
            int? tokenTypeId = null,
            string tokenTypeName = null,
            Models.CardUsageRestrictions usageRestrictions = null,
            bool? eMVContactless = null,
            bool? rFID = null,
            bool? pINChangeSupported = null,
            bool? requirePIN = null,
            bool? offlinePIN = null,
            bool? isDefault = null,
            bool? applicationsToShowNPIITokens = null,
            int? mediumTypeID = null,
            string mediumType = null,
            string colCoCurrencySymbol = null)
        {
            this.CanHavePIN = canHavePIN;

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

            if (customerCardTypeId != null)
            {
                this.CustomerCardTypeId = customerCardTypeId;
            }
            this.DayTimeRestrictions = dayTimeRestrictions;

            if (defaultPurchaseCategoryId != null)
            {
                this.DefaultPurchaseCategoryId = defaultPurchaseCategoryId;
            }

            if (embossAccountName != null)
            {
                this.EmbossAccountName = embossAccountName;
            }

            if (expiryPeriod != null)
            {
                this.ExpiryPeriod = expiryPeriod;
            }
            this.IsCRT = isCRT;
            this.IsFleet = isFleet;
            this.IsInternational = isInternational;
            this.IsNational = isNational;
            this.IsPartnerSitesIncluded = isPartnerSitesIncluded;
            this.IsShellSitesOnly = isShellSitesOnly;
            this.IsVirtual = isVirtual;
            this.IsVisibleToCustomers = isVisibleToCustomers;
            this.IsActive = isActive;
            this.IsCardAvailableForDownload = isCardAvailableForDownload;
            this.IsCardVisibleToCustomers = isCardVisibleToCustomers;

            if (pANLength != null)
            {
                this.PANLength = pANLength;
            }

            if (purchaseCategories != null)
            {
                this.PurchaseCategories = purchaseCategories;
            }

            if (tokenTypeId != null)
            {
                this.TokenTypeId = tokenTypeId;
            }

            if (tokenTypeName != null)
            {
                this.TokenTypeName = tokenTypeName;
            }
            this.UsageRestrictions = usageRestrictions;
            this.EMVContactless = eMVContactless;
            this.RFID = rFID;
            this.PINChangeSupported = pINChangeSupported;
            this.RequirePIN = requirePIN;
            this.OfflinePIN = offlinePIN;
            this.IsDefault = isDefault;
            this.ApplicationsToShowNPIITokens = applicationsToShowNPIITokens;

            if (mediumTypeID != null)
            {
                this.MediumTypeID = mediumTypeID;
            }

            if (mediumType != null)
            {
                this.MediumType = mediumType;
            }

            if (colCoCurrencySymbol != null)
            {
                this.ColCoCurrencySymbol = colCoCurrencySymbol;
            }
        }

        /// <summary>
        /// True/False – Whether the cards of this card type can have PIN.
        /// </summary>
        [JsonProperty("CanHavePIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanHavePIN { get; set; }

        /// <summary>
        /// Card Type Id
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
        /// Card Type Name.
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
        /// ISO currency code of the country.
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
        /// Customer Card Type Id
        /// </summary>
        [JsonProperty("CustomerCardTypeId")]
        public int? CustomerCardTypeId
        {
            get
            {
                return this.customerCardTypeId;
            }

            set
            {
                this.shouldSerialize["CustomerCardTypeId"] = true;
                this.customerCardTypeId = value;
            }
        }

        /// <summary>
        /// Gets or sets DayTimeRestrictions.
        /// </summary>
        [JsonProperty("DayTimeRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDayTimeRestrictions DayTimeRestrictions { get; set; }

        /// <summary>
        /// Default Purchase category of the card type.
        /// </summary>
        [JsonProperty("DefaultPurchaseCategoryId")]
        public int? DefaultPurchaseCategoryId
        {
            get
            {
                return this.defaultPurchaseCategoryId;
            }

            set
            {
                this.shouldSerialize["DefaultPurchaseCategoryId"] = true;
                this.defaultPurchaseCategoryId = value;
            }
        }

        /// <summary>
        /// Default Name to be embossed on the card
        /// </summary>
        [JsonProperty("EmbossAccountName")]
        public string EmbossAccountName
        {
            get
            {
                return this.embossAccountName;
            }

            set
            {
                this.shouldSerialize["EmbossAccountName"] = true;
                this.embossAccountName = value;
            }
        }

        /// <summary>
        /// Default Expiry period.
        /// </summary>
        [JsonProperty("ExpiryPeriod")]
        public int? ExpiryPeriod
        {
            get
            {
                return this.expiryPeriod;
            }

            set
            {
                this.shouldSerialize["ExpiryPeriod"] = true;
                this.expiryPeriod = value;
            }
        }

        /// <summary>
        /// True/False – Wether it is a CRT Card type or not.
        /// </summary>
        [JsonProperty("IsCRT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCRT { get; set; }

        /// <summary>
        /// True/False – Whether it is it a Fleet Card typeor not.
        /// </summary>
        [JsonProperty("IsFleet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFleet { get; set; }

        /// <summary>
        /// True/False – Whether it is an International Card type or not.
        /// </summary>
        [JsonProperty("IsInternational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; }

        /// <summary>
        /// True/False – Whether it is a National Card type or not.
        /// </summary>
        [JsonProperty("IsNational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNational { get; set; }

        /// <summary>
        /// True/False – Whether this card type is allowed in partner Stations.
        /// </summary>
        [JsonProperty("IsPartnerSitesIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartnerSitesIncluded { get; set; }

        /// <summary>
        /// True/False – Whether it is only allowed in Shell Stations or not.
        /// </summary>
        [JsonProperty("IsShellSitesOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellSitesOnly { get; set; }

        /// <summary>
        /// True/False - Whether it is a Virtual Card type or not.
        /// </summary>
        [JsonProperty("IsVirtual", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtual { get; set; }

        /// <summary>
        /// True/False – Whether this card type is visible in SFH for card ordering.
        /// </summary>
        [JsonProperty("IsVisibleToCustomers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVisibleToCustomers { get; set; }

        /// <summary>
        /// Whether card type is active or not.
        /// </summary>
        [JsonProperty("IsActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets IsCardAvailableForDownload.
        /// </summary>
        [JsonProperty("IsCardAvailableForDownload", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCardAvailableForDownload { get; set; }

        /// <summary>
        /// Gets or sets IsCardVisibleToCustomers.
        /// </summary>
        [JsonProperty("IsCardVisibleToCustomers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCardVisibleToCustomers { get; set; }

        /// <summary>
        /// PAN Length
        /// </summary>
        [JsonProperty("PANLength")]
        public int? PANLength
        {
            get
            {
                return this.pANLength;
            }

            set
            {
                this.shouldSerialize["PANLength"] = true;
                this.pANLength = value;
            }
        }

        /// <summary>
        /// Gets or sets PurchaseCategories.
        /// </summary>
        [JsonProperty("PurchaseCategories")]
        public List<Models.PurchaseCategories> PurchaseCategories
        {
            get
            {
                return this.purchaseCategories;
            }

            set
            {
                this.shouldSerialize["PurchaseCategories"] = true;
                this.purchaseCategories = value;
            }
        }

        /// <summary>
        /// Token type identifier.
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
        /// Token Type Name.
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
        /// Gets or sets UsageRestrictions.
        /// </summary>
        [JsonProperty("UsageRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardUsageRestrictions UsageRestrictions { get; set; }

        /// <summary>
        /// Is Europay, MasterCard, and Visa Contactless enabled or not.
        /// </summary>
        [JsonProperty("EMVContactless", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EMVContactless { get; set; }

        /// <summary>
        /// Whether the card type is enabled for RFID (Radio Frequency Identification)
        /// </summary>
        [JsonProperty("RFID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RFID { get; set; }

        /// <summary>
        /// PIN change supported or not.
        /// </summary>
        [JsonProperty("PINChangeSupported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PINChangeSupported { get; set; }

        /// <summary>
        /// Whether a PIN is mandatory for the cards of this card type.
        /// </summary>
        [JsonProperty("RequirePIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequirePIN { get; set; }

        /// <summary>
        /// Whether offline PIN is enabled or not.
        /// </summary>
        [JsonProperty("OfflinePIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OfflinePIN { get; set; }

        /// <summary>
        /// Whether card type is default or not.
        /// </summary>
        [JsonProperty("IsDefault", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// True/False
        /// Note: ApplicationsToShowNPIITokens will be set as ‘True’ when the accessing application API key exists in the “ApplicationsToShowNPIITokens” card type configuration else “False”.
        /// </summary>
        [JsonProperty("ApplicationsToShowNPIITokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplicationsToShowNPIITokens { get; set; }

        /// <summary>
        /// Id of the medium type identifier.
        /// Example: 1,2,4
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 3 - EV only
        /// 4 - Fuel Card and Key Fob
        /// 5 - Key Fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 – Smartpay Token
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
        /// Example: Fuel Card, Fuel Card with EV, Key Fob
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 3 - EV only
        /// 4 - Fuel Card and Key Fob
        /// 5 - Key Fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 - Smartpay Token
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

        /// <summary>
        /// Currency symbol of the country.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardTypeResponseCustomerCardTypesItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardTypeId()
        {
            this.shouldSerialize["CardTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardTypeName()
        {
            this.shouldSerialize["CardTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoCurrencyCode()
        {
            this.shouldSerialize["ColCoCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerCardTypeId()
        {
            this.shouldSerialize["CustomerCardTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultPurchaseCategoryId()
        {
            this.shouldSerialize["DefaultPurchaseCategoryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmbossAccountName()
        {
            this.shouldSerialize["EmbossAccountName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiryPeriod()
        {
            this.shouldSerialize["ExpiryPeriod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPANLength()
        {
            this.shouldSerialize["PANLength"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPurchaseCategories()
        {
            this.shouldSerialize["PurchaseCategories"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTokenTypeId()
        {
            this.shouldSerialize["TokenTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTokenTypeName()
        {
            this.shouldSerialize["TokenTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMediumTypeID()
        {
            this.shouldSerialize["MediumTypeID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMediumType()
        {
            this.shouldSerialize["MediumType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoCurrencySymbol()
        {
            this.shouldSerialize["ColCoCurrencySymbol"] = false;
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
        public bool ShouldSerializeCustomerCardTypeId()
        {
            return this.shouldSerialize["CustomerCardTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultPurchaseCategoryId()
        {
            return this.shouldSerialize["DefaultPurchaseCategoryId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmbossAccountName()
        {
            return this.shouldSerialize["EmbossAccountName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryPeriod()
        {
            return this.shouldSerialize["ExpiryPeriod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePANLength()
        {
            return this.shouldSerialize["PANLength"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategories()
        {
            return this.shouldSerialize["PurchaseCategories"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCurrencySymbol()
        {
            return this.shouldSerialize["ColCoCurrencySymbol"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardTypeResponseCustomerCardTypesItems other &&
                (this.CanHavePIN == null && other.CanHavePIN == null ||
                 this.CanHavePIN?.Equals(other.CanHavePIN) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.CardTypeName == null && other.CardTypeName == null ||
                 this.CardTypeName?.Equals(other.CardTypeName) == true) &&
                (this.ColCoCurrencyCode == null && other.ColCoCurrencyCode == null ||
                 this.ColCoCurrencyCode?.Equals(other.ColCoCurrencyCode) == true) &&
                (this.CustomerCardTypeId == null && other.CustomerCardTypeId == null ||
                 this.CustomerCardTypeId?.Equals(other.CustomerCardTypeId) == true) &&
                (this.DayTimeRestrictions == null && other.DayTimeRestrictions == null ||
                 this.DayTimeRestrictions?.Equals(other.DayTimeRestrictions) == true) &&
                (this.DefaultPurchaseCategoryId == null && other.DefaultPurchaseCategoryId == null ||
                 this.DefaultPurchaseCategoryId?.Equals(other.DefaultPurchaseCategoryId) == true) &&
                (this.EmbossAccountName == null && other.EmbossAccountName == null ||
                 this.EmbossAccountName?.Equals(other.EmbossAccountName) == true) &&
                (this.ExpiryPeriod == null && other.ExpiryPeriod == null ||
                 this.ExpiryPeriod?.Equals(other.ExpiryPeriod) == true) &&
                (this.IsCRT == null && other.IsCRT == null ||
                 this.IsCRT?.Equals(other.IsCRT) == true) &&
                (this.IsFleet == null && other.IsFleet == null ||
                 this.IsFleet?.Equals(other.IsFleet) == true) &&
                (this.IsInternational == null && other.IsInternational == null ||
                 this.IsInternational?.Equals(other.IsInternational) == true) &&
                (this.IsNational == null && other.IsNational == null ||
                 this.IsNational?.Equals(other.IsNational) == true) &&
                (this.IsPartnerSitesIncluded == null && other.IsPartnerSitesIncluded == null ||
                 this.IsPartnerSitesIncluded?.Equals(other.IsPartnerSitesIncluded) == true) &&
                (this.IsShellSitesOnly == null && other.IsShellSitesOnly == null ||
                 this.IsShellSitesOnly?.Equals(other.IsShellSitesOnly) == true) &&
                (this.IsVirtual == null && other.IsVirtual == null ||
                 this.IsVirtual?.Equals(other.IsVirtual) == true) &&
                (this.IsVisibleToCustomers == null && other.IsVisibleToCustomers == null ||
                 this.IsVisibleToCustomers?.Equals(other.IsVisibleToCustomers) == true) &&
                (this.IsActive == null && other.IsActive == null ||
                 this.IsActive?.Equals(other.IsActive) == true) &&
                (this.IsCardAvailableForDownload == null && other.IsCardAvailableForDownload == null ||
                 this.IsCardAvailableForDownload?.Equals(other.IsCardAvailableForDownload) == true) &&
                (this.IsCardVisibleToCustomers == null && other.IsCardVisibleToCustomers == null ||
                 this.IsCardVisibleToCustomers?.Equals(other.IsCardVisibleToCustomers) == true) &&
                (this.PANLength == null && other.PANLength == null ||
                 this.PANLength?.Equals(other.PANLength) == true) &&
                (this.PurchaseCategories == null && other.PurchaseCategories == null ||
                 this.PurchaseCategories?.Equals(other.PurchaseCategories) == true) &&
                (this.TokenTypeId == null && other.TokenTypeId == null ||
                 this.TokenTypeId?.Equals(other.TokenTypeId) == true) &&
                (this.TokenTypeName == null && other.TokenTypeName == null ||
                 this.TokenTypeName?.Equals(other.TokenTypeName) == true) &&
                (this.UsageRestrictions == null && other.UsageRestrictions == null ||
                 this.UsageRestrictions?.Equals(other.UsageRestrictions) == true) &&
                (this.EMVContactless == null && other.EMVContactless == null ||
                 this.EMVContactless?.Equals(other.EMVContactless) == true) &&
                (this.RFID == null && other.RFID == null ||
                 this.RFID?.Equals(other.RFID) == true) &&
                (this.PINChangeSupported == null && other.PINChangeSupported == null ||
                 this.PINChangeSupported?.Equals(other.PINChangeSupported) == true) &&
                (this.RequirePIN == null && other.RequirePIN == null ||
                 this.RequirePIN?.Equals(other.RequirePIN) == true) &&
                (this.OfflinePIN == null && other.OfflinePIN == null ||
                 this.OfflinePIN?.Equals(other.OfflinePIN) == true) &&
                (this.IsDefault == null && other.IsDefault == null ||
                 this.IsDefault?.Equals(other.IsDefault) == true) &&
                (this.ApplicationsToShowNPIITokens == null && other.ApplicationsToShowNPIITokens == null ||
                 this.ApplicationsToShowNPIITokens?.Equals(other.ApplicationsToShowNPIITokens) == true) &&
                (this.MediumTypeID == null && other.MediumTypeID == null ||
                 this.MediumTypeID?.Equals(other.MediumTypeID) == true) &&
                (this.MediumType == null && other.MediumType == null ||
                 this.MediumType?.Equals(other.MediumType) == true) &&
                (this.ColCoCurrencySymbol == null && other.ColCoCurrencySymbol == null ||
                 this.ColCoCurrencySymbol?.Equals(other.ColCoCurrencySymbol) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CanHavePIN = {(this.CanHavePIN == null ? "null" : this.CanHavePIN.ToString())}");
            toStringOutput.Add($"CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"CardTypeName = {this.CardTypeName ?? "null"}");
            toStringOutput.Add($"ColCoCurrencyCode = {this.ColCoCurrencyCode ?? "null"}");
            toStringOutput.Add($"CustomerCardTypeId = {(this.CustomerCardTypeId == null ? "null" : this.CustomerCardTypeId.ToString())}");
            toStringOutput.Add($"DayTimeRestrictions = {(this.DayTimeRestrictions == null ? "null" : this.DayTimeRestrictions.ToString())}");
            toStringOutput.Add($"DefaultPurchaseCategoryId = {(this.DefaultPurchaseCategoryId == null ? "null" : this.DefaultPurchaseCategoryId.ToString())}");
            toStringOutput.Add($"EmbossAccountName = {this.EmbossAccountName ?? "null"}");
            toStringOutput.Add($"ExpiryPeriod = {(this.ExpiryPeriod == null ? "null" : this.ExpiryPeriod.ToString())}");
            toStringOutput.Add($"IsCRT = {(this.IsCRT == null ? "null" : this.IsCRT.ToString())}");
            toStringOutput.Add($"IsFleet = {(this.IsFleet == null ? "null" : this.IsFleet.ToString())}");
            toStringOutput.Add($"IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"IsPartnerSitesIncluded = {(this.IsPartnerSitesIncluded == null ? "null" : this.IsPartnerSitesIncluded.ToString())}");
            toStringOutput.Add($"IsShellSitesOnly = {(this.IsShellSitesOnly == null ? "null" : this.IsShellSitesOnly.ToString())}");
            toStringOutput.Add($"IsVirtual = {(this.IsVirtual == null ? "null" : this.IsVirtual.ToString())}");
            toStringOutput.Add($"IsVisibleToCustomers = {(this.IsVisibleToCustomers == null ? "null" : this.IsVisibleToCustomers.ToString())}");
            toStringOutput.Add($"IsActive = {(this.IsActive == null ? "null" : this.IsActive.ToString())}");
            toStringOutput.Add($"IsCardAvailableForDownload = {(this.IsCardAvailableForDownload == null ? "null" : this.IsCardAvailableForDownload.ToString())}");
            toStringOutput.Add($"IsCardVisibleToCustomers = {(this.IsCardVisibleToCustomers == null ? "null" : this.IsCardVisibleToCustomers.ToString())}");
            toStringOutput.Add($"PANLength = {(this.PANLength == null ? "null" : this.PANLength.ToString())}");
            toStringOutput.Add($"PurchaseCategories = {(this.PurchaseCategories == null ? "null" : $"[{string.Join(", ", this.PurchaseCategories)} ]")}");
            toStringOutput.Add($"TokenTypeId = {(this.TokenTypeId == null ? "null" : this.TokenTypeId.ToString())}");
            toStringOutput.Add($"TokenTypeName = {this.TokenTypeName ?? "null"}");
            toStringOutput.Add($"UsageRestrictions = {(this.UsageRestrictions == null ? "null" : this.UsageRestrictions.ToString())}");
            toStringOutput.Add($"EMVContactless = {(this.EMVContactless == null ? "null" : this.EMVContactless.ToString())}");
            toStringOutput.Add($"RFID = {(this.RFID == null ? "null" : this.RFID.ToString())}");
            toStringOutput.Add($"PINChangeSupported = {(this.PINChangeSupported == null ? "null" : this.PINChangeSupported.ToString())}");
            toStringOutput.Add($"RequirePIN = {(this.RequirePIN == null ? "null" : this.RequirePIN.ToString())}");
            toStringOutput.Add($"OfflinePIN = {(this.OfflinePIN == null ? "null" : this.OfflinePIN.ToString())}");
            toStringOutput.Add($"IsDefault = {(this.IsDefault == null ? "null" : this.IsDefault.ToString())}");
            toStringOutput.Add($"ApplicationsToShowNPIITokens = {(this.ApplicationsToShowNPIITokens == null ? "null" : this.ApplicationsToShowNPIITokens.ToString())}");
            toStringOutput.Add($"MediumTypeID = {(this.MediumTypeID == null ? "null" : this.MediumTypeID.ToString())}");
            toStringOutput.Add($"MediumType = {this.MediumType ?? "null"}");
            toStringOutput.Add($"ColCoCurrencySymbol = {this.ColCoCurrencySymbol ?? "null"}");
        }
    }
}
// <copyright file="AccountResponseAccountsItems.cs" company="APIMatic">
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
    /// AccountResponseAccountsItems.
    /// </summary>
    public class AccountResponseAccountsItems
    {
        private string accountFullName;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private string billingFrequencyType;
        private int? billingFrequencyTypeId;
        private string billingRunFrequency;
        private int? billingRunFrequencyTypeId;
        private string colCoCountryCode;
        private string currencyCode;
        private string currencySymbol;
        private int? day1Run;
        private int? day2Run;
        private int? day3Run;
        private int? day4Run;
        private string frequencyType;
        private double? grossAmount;
        private string internationalPOSLanguageCode;
        private int? internationalPOSLanguageID;
        private int? invoiceAccountID;
        private string invoiceAccountNumber;
        private string invoiceAccountShortName;
        private bool? isInternational;
        private bool? isInvoicePoint;
        private string lastModifiedDate;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private string localPOSLanguageCode;
        private int? localPOSLanguageID;
        private double? netAmount;
        private double? outstandingBalance;
        private double? paidAmount;
        private string status;
        private string statusReason;
        private int? totalActiveCardGroups;
        private int? totalActiveCards;
        private int? totalBlockedCards;
        private int? totalCancelledCards;
        private int? totalCards;
        private int? totalExpiredCards;
        private int? totalFraudCards;
        private int? totalNewCards;
        private int? totalRenewalPendingCards;
        private int? totalReplacedCards;
        private int? totalTemporaryBlockCardsByCustomer;
        private int? totalTemporaryBlockCardsByShell;
        private double? vATAmount;
        private int? isPartnerCard;
        private string tollsCustomerId;
        private string tollsColcoCountryTypeId;
        private string isConsortiumMember;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountFullName", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "BillingFrequencyType", false },
            { "BillingFrequencyTypeId", false },
            { "BillingRunFrequency", false },
            { "BillingRunFrequencyTypeId", false },
            { "ColCoCountryCode", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "Day1Run", false },
            { "Day2Run", false },
            { "Day3Run", false },
            { "Day4Run", false },
            { "FrequencyType", false },
            { "GrossAmount", false },
            { "InternationalPOSLanguageCode", false },
            { "InternationalPOSLanguageID", false },
            { "InvoiceAccountID", false },
            { "InvoiceAccountNumber", false },
            { "InvoiceAccountShortName", false },
            { "IsInternational", false },
            { "IsInvoicePoint", false },
            { "LastModifiedDate", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "LocalPOSLanguageCode", false },
            { "LocalPOSLanguageID", false },
            { "NetAmount", false },
            { "OutstandingBalance", false },
            { "PaidAmount", false },
            { "Status", false },
            { "StatusReason", false },
            { "TotalActiveCardGroups", false },
            { "TotalActiveCards", false },
            { "TotalBlockedCards", false },
            { "TotalCancelledCards", false },
            { "TotalCards", false },
            { "TotalExpiredCards", false },
            { "TotalFraudCards", false },
            { "TotalNewCards", false },
            { "TotalRenewalPendingCards", false },
            { "TotalReplacedCards", false },
            { "TotalTemporaryBlockCardsByCustomer", false },
            { "TotalTemporaryBlockCardsByShell", false },
            { "VATAmount", false },
            { "IsPartnerCard", false },
            { "TollsCustomerId", false },
            { "TollsColcoCountryTypeId", false },
            { "IsConsortiumMember", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseAccountsItems"/> class.
        /// </summary>
        public AccountResponseAccountsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseAccountsItems"/> class.
        /// </summary>
        /// <param name="accountFullName">AccountFullName.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="bestOfIndicator">BestOfIndicator.</param>
        /// <param name="billingFrequencyType">BillingFrequencyType.</param>
        /// <param name="billingFrequencyTypeId">BillingFrequencyTypeId.</param>
        /// <param name="billingRunFrequency">BillingRunFrequency.</param>
        /// <param name="billingRunFrequencyTypeId">BillingRunFrequencyTypeId.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="day1Run">Day1Run.</param>
        /// <param name="day2Run">Day2Run.</param>
        /// <param name="day3Run">Day3Run.</param>
        /// <param name="day4Run">Day4Run.</param>
        /// <param name="frequencyType">FrequencyType.</param>
        /// <param name="grossAmount">GrossAmount.</param>
        /// <param name="internationalPOSLanguageCode">InternationalPOSLanguageCode.</param>
        /// <param name="internationalPOSLanguageID">InternationalPOSLanguageID.</param>
        /// <param name="invoiceAccountID">InvoiceAccountID.</param>
        /// <param name="invoiceAccountNumber">InvoiceAccountNumber.</param>
        /// <param name="invoiceAccountShortName">InvoiceAccountShortName.</param>
        /// <param name="invoiceDistributionMethods">InvoiceDistributionMethods.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isInvoicePoint">IsInvoicePoint.</param>
        /// <param name="lastModifiedDate">LastModifiedDate.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="localPOSLanguageCode">LocalPOSLanguageCode.</param>
        /// <param name="localPOSLanguageID">LocalPOSLanguageID.</param>
        /// <param name="netAmount">NetAmount.</param>
        /// <param name="outstandingBalance">OutstandingBalance.</param>
        /// <param name="paidAmount">PaidAmount.</param>
        /// <param name="status">Status.</param>
        /// <param name="statusReason">StatusReason.</param>
        /// <param name="totalActiveCardGroups">TotalActiveCardGroups.</param>
        /// <param name="totalActiveCards">TotalActiveCards.</param>
        /// <param name="totalBlockedCards">TotalBlockedCards.</param>
        /// <param name="totalCancelledCards">TotalCancelledCards.</param>
        /// <param name="totalCards">TotalCards.</param>
        /// <param name="totalExpiredCards">TotalExpiredCards.</param>
        /// <param name="totalFraudCards">TotalFraudCards.</param>
        /// <param name="totalNewCards">TotalNewCards.</param>
        /// <param name="totalRenewalPendingCards">TotalRenewalPendingCards.</param>
        /// <param name="totalReplacedCards">TotalReplacedCards.</param>
        /// <param name="totalTemporaryBlockCardsByCustomer">TotalTemporaryBlockCardsByCustomer.</param>
        /// <param name="totalTemporaryBlockCardsByShell">TotalTemporaryBlockCardsByShell.</param>
        /// <param name="vATAmount">VATAmount.</param>
        /// <param name="isPartnerCard">IsPartnerCard.</param>
        /// <param name="tollsCustomerId">TollsCustomerId.</param>
        /// <param name="tollsColcoCountryTypeId">TollsColcoCountryTypeId.</param>
        /// <param name="contracts">Contracts.</param>
        /// <param name="isConsortiumMember">IsConsortiumMember.</param>
        public AccountResponseAccountsItems(
            string accountFullName = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            bool? bestOfIndicator = null,
            string billingFrequencyType = null,
            int? billingFrequencyTypeId = null,
            string billingRunFrequency = null,
            int? billingRunFrequencyTypeId = null,
            string colCoCountryCode = null,
            string currencyCode = null,
            string currencySymbol = null,
            int? day1Run = null,
            int? day2Run = null,
            int? day3Run = null,
            int? day4Run = null,
            string frequencyType = null,
            double? grossAmount = null,
            string internationalPOSLanguageCode = null,
            int? internationalPOSLanguageID = null,
            int? invoiceAccountID = null,
            string invoiceAccountNumber = null,
            string invoiceAccountShortName = null,
            List<Models.InvoiceDistributionMethod> invoiceDistributionMethods = null,
            bool? isInternational = null,
            bool? isInvoicePoint = null,
            string lastModifiedDate = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            string localPOSLanguageCode = null,
            int? localPOSLanguageID = null,
            double? netAmount = null,
            double? outstandingBalance = null,
            double? paidAmount = null,
            string status = null,
            string statusReason = null,
            int? totalActiveCardGroups = null,
            int? totalActiveCards = null,
            int? totalBlockedCards = null,
            int? totalCancelledCards = null,
            int? totalCards = null,
            int? totalExpiredCards = null,
            int? totalFraudCards = null,
            int? totalNewCards = null,
            int? totalRenewalPendingCards = null,
            int? totalReplacedCards = null,
            int? totalTemporaryBlockCardsByCustomer = null,
            int? totalTemporaryBlockCardsByShell = null,
            double? vATAmount = null,
            int? isPartnerCard = null,
            string tollsCustomerId = null,
            string tollsColcoCountryTypeId = null,
            List<Models.CustomerContract> contracts = null,
            string isConsortiumMember = null)
        {
            if (accountFullName != null)
            {
                this.AccountFullName = accountFullName;
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

            this.BestOfIndicator = bestOfIndicator;
            if (billingFrequencyType != null)
            {
                this.BillingFrequencyType = billingFrequencyType;
            }

            if (billingFrequencyTypeId != null)
            {
                this.BillingFrequencyTypeId = billingFrequencyTypeId;
            }

            if (billingRunFrequency != null)
            {
                this.BillingRunFrequency = billingRunFrequency;
            }

            if (billingRunFrequencyTypeId != null)
            {
                this.BillingRunFrequencyTypeId = billingRunFrequencyTypeId;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (day1Run != null)
            {
                this.Day1Run = day1Run;
            }

            if (day2Run != null)
            {
                this.Day2Run = day2Run;
            }

            if (day3Run != null)
            {
                this.Day3Run = day3Run;
            }

            if (day4Run != null)
            {
                this.Day4Run = day4Run;
            }

            if (frequencyType != null)
            {
                this.FrequencyType = frequencyType;
            }

            if (grossAmount != null)
            {
                this.GrossAmount = grossAmount;
            }

            if (internationalPOSLanguageCode != null)
            {
                this.InternationalPOSLanguageCode = internationalPOSLanguageCode;
            }

            if (internationalPOSLanguageID != null)
            {
                this.InternationalPOSLanguageID = internationalPOSLanguageID;
            }

            if (invoiceAccountID != null)
            {
                this.InvoiceAccountID = invoiceAccountID;
            }

            if (invoiceAccountNumber != null)
            {
                this.InvoiceAccountNumber = invoiceAccountNumber;
            }

            if (invoiceAccountShortName != null)
            {
                this.InvoiceAccountShortName = invoiceAccountShortName;
            }

            this.InvoiceDistributionMethods = invoiceDistributionMethods;
            if (isInternational != null)
            {
                this.IsInternational = isInternational;
            }

            if (isInvoicePoint != null)
            {
                this.IsInvoicePoint = isInvoicePoint;
            }

            if (lastModifiedDate != null)
            {
                this.LastModifiedDate = lastModifiedDate;
            }

            if (localCurrencyCode != null)
            {
                this.LocalCurrencyCode = localCurrencyCode;
            }

            if (localCurrencySymbol != null)
            {
                this.LocalCurrencySymbol = localCurrencySymbol;
            }

            if (localPOSLanguageCode != null)
            {
                this.LocalPOSLanguageCode = localPOSLanguageCode;
            }

            if (localPOSLanguageID != null)
            {
                this.LocalPOSLanguageID = localPOSLanguageID;
            }

            if (netAmount != null)
            {
                this.NetAmount = netAmount;
            }

            if (outstandingBalance != null)
            {
                this.OutstandingBalance = outstandingBalance;
            }

            if (paidAmount != null)
            {
                this.PaidAmount = paidAmount;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (statusReason != null)
            {
                this.StatusReason = statusReason;
            }

            if (totalActiveCardGroups != null)
            {
                this.TotalActiveCardGroups = totalActiveCardGroups;
            }

            if (totalActiveCards != null)
            {
                this.TotalActiveCards = totalActiveCards;
            }

            if (totalBlockedCards != null)
            {
                this.TotalBlockedCards = totalBlockedCards;
            }

            if (totalCancelledCards != null)
            {
                this.TotalCancelledCards = totalCancelledCards;
            }

            if (totalCards != null)
            {
                this.TotalCards = totalCards;
            }

            if (totalExpiredCards != null)
            {
                this.TotalExpiredCards = totalExpiredCards;
            }

            if (totalFraudCards != null)
            {
                this.TotalFraudCards = totalFraudCards;
            }

            if (totalNewCards != null)
            {
                this.TotalNewCards = totalNewCards;
            }

            if (totalRenewalPendingCards != null)
            {
                this.TotalRenewalPendingCards = totalRenewalPendingCards;
            }

            if (totalReplacedCards != null)
            {
                this.TotalReplacedCards = totalReplacedCards;
            }

            if (totalTemporaryBlockCardsByCustomer != null)
            {
                this.TotalTemporaryBlockCardsByCustomer = totalTemporaryBlockCardsByCustomer;
            }

            if (totalTemporaryBlockCardsByShell != null)
            {
                this.TotalTemporaryBlockCardsByShell = totalTemporaryBlockCardsByShell;
            }

            if (vATAmount != null)
            {
                this.VATAmount = vATAmount;
            }

            if (isPartnerCard != null)
            {
                this.IsPartnerCard = isPartnerCard;
            }

            if (tollsCustomerId != null)
            {
                this.TollsCustomerId = tollsCustomerId;
            }

            if (tollsColcoCountryTypeId != null)
            {
                this.TollsColcoCountryTypeId = tollsColcoCountryTypeId;
            }

            this.Contracts = contracts;
            if (isConsortiumMember != null)
            {
                this.IsConsortiumMember = isConsortiumMember;
            }

        }

        /// <summary>
        /// Account Full Name
        /// </summary>
        [JsonProperty("AccountFullName")]
        public string AccountFullName
        {
            get
            {
                return this.accountFullName;
            }

            set
            {
                this.shouldSerialize["AccountFullName"] = true;
                this.accountFullName = value;
            }
        }

        /// <summary>
        /// Account Id
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
        /// Best of Indicator of the Pricing customer/account configured.
        /// </summary>
        [JsonProperty("BestOfIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BestOfIndicator { get; set; }

        /// <summary>
        /// Billing/Invoice frequency. The frequency in which the transactions will be considered for invoicing in a bulling run
        /// E.g.:
        /// 1	Daily (all days)
        /// 2	Daily (only working days)
        /// 3	Weekly - Monday
        /// 4	Weekly – Tuesday
        /// Etc.
        /// </summary>
        [JsonProperty("BillingFrequencyType")]
        public string BillingFrequencyType
        {
            get
            {
                return this.billingFrequencyType;
            }

            set
            {
                this.shouldSerialize["BillingFrequencyType"] = true;
                this.billingFrequencyType = value;
            }
        }

        /// <summary>
        /// Billing/Invoice frequency Identifier. Indicates the frequency in which the transactions will be considered for invoicing in a bulling run
        /// </summary>
        [JsonProperty("BillingFrequencyTypeId")]
        public int? BillingFrequencyTypeId
        {
            get
            {
                return this.billingFrequencyTypeId;
            }

            set
            {
                this.shouldSerialize["BillingFrequencyTypeId"] = true;
                this.billingFrequencyTypeId = value;
            }
        }

        /// <summary>
        /// Frequency at which the billing process is triggered. E.g.:
        /// 1	Daily (all days)
        /// 2	Daily (only working days)
        /// 3	Weekly - Monday
        /// 4	Weekly – Tuesday
        /// Etc.
        /// </summary>
        [JsonProperty("BillingRunFrequency")]
        public string BillingRunFrequency
        {
            get
            {
                return this.billingRunFrequency;
            }

            set
            {
                this.shouldSerialize["BillingRunFrequency"] = true;
                this.billingRunFrequency = value;
            }
        }

        /// <summary>
        /// Frequency at which the billing process is triggered.
        /// E.g.: 1, 2, 3, etc.
        /// </summary>
        [JsonProperty("BillingRunFrequencyTypeId")]
        public int? BillingRunFrequencyTypeId
        {
            get
            {
                return this.billingRunFrequencyTypeId;
            }

            set
            {
                this.shouldSerialize["BillingRunFrequencyTypeId"] = true;
                this.billingRunFrequencyTypeId = value;
            }
        }

        /// <summary>
        /// The 2-character ISO Code for the customer and card owning country.
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
        /// ISO code of customer currency.
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
        /// €
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
        /// The first day in a month when the billing should run in case of multiple billing runs configured with in a single month
        /// </summary>
        [JsonProperty("Day1Run")]
        public int? Day1Run
        {
            get
            {
                return this.day1Run;
            }

            set
            {
                this.shouldSerialize["Day1Run"] = true;
                this.day1Run = value;
            }
        }

        /// <summary>
        /// The second day in a month when the billing should run in case of multiple billing runs configured with in a single month
        /// </summary>
        [JsonProperty("Day2Run")]
        public int? Day2Run
        {
            get
            {
                return this.day2Run;
            }

            set
            {
                this.shouldSerialize["Day2Run"] = true;
                this.day2Run = value;
            }
        }

        /// <summary>
        /// The third day in a month when the billing should run in case of multiple billing runs configured with in a single month
        /// </summary>
        [JsonProperty("Day3Run")]
        public int? Day3Run
        {
            get
            {
                return this.day3Run;
            }

            set
            {
                this.shouldSerialize["Day3Run"] = true;
                this.day3Run = value;
            }
        }

        /// <summary>
        /// The fourth day in a month when the billing should run in case of multiple billing runs configured with in a single month
        /// </summary>
        [JsonProperty("Day4Run")]
        public int? Day4Run
        {
            get
            {
                return this.day4Run;
            }

            set
            {
                this.shouldSerialize["Day4Run"] = true;
                this.day4Run = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Frequency type unit id & description
        /// E.g.:
        /// 1 - Daily
        /// 2 - Weekly
        /// 3 - Monthly
        /// 4 - Invoicing
        /// 6 - Calendar quarter
        /// ]]>
        /// </summary>
        [JsonProperty("FrequencyType")]
        public string FrequencyType
        {
            get
            {
                return this.frequencyType;
            }

            set
            {
                this.shouldSerialize["FrequencyType"] = true;
                this.frequencyType = value;
            }
        }

        /// <summary>
        /// Gross amount in customer currency.
        /// </summary>
        [JsonProperty("GrossAmount")]
        public double? GrossAmount
        {
            get
            {
                return this.grossAmount;
            }

            set
            {
                this.shouldSerialize["GrossAmount"] = true;
                this.grossAmount = value;
            }
        }

        /// <summary>
        /// POS international language code
        /// </summary>
        [JsonProperty("InternationalPOSLanguageCode")]
        public string InternationalPOSLanguageCode
        {
            get
            {
                return this.internationalPOSLanguageCode;
            }

            set
            {
                this.shouldSerialize["InternationalPOSLanguageCode"] = true;
                this.internationalPOSLanguageCode = value;
            }
        }

        /// <summary>
        /// POS international language ID
        /// </summary>
        [JsonProperty("InternationalPOSLanguageID")]
        public int? InternationalPOSLanguageID
        {
            get
            {
                return this.internationalPOSLanguageID;
            }

            set
            {
                this.shouldSerialize["InternationalPOSLanguageID"] = true;
                this.internationalPOSLanguageID = value;
            }
        }

        /// <summary>
        /// The Account ID of the account on which the invoice is generated.
        /// </summary>
        [JsonProperty("InvoiceAccountID")]
        public int? InvoiceAccountID
        {
            get
            {
                return this.invoiceAccountID;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountID"] = true;
                this.invoiceAccountID = value;
            }
        }

        /// <summary>
        /// The Account Number of the account on which the invoice is generated.
        /// </summary>
        [JsonProperty("InvoiceAccountNumber")]
        public string InvoiceAccountNumber
        {
            get
            {
                return this.invoiceAccountNumber;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountNumber"] = true;
                this.invoiceAccountNumber = value;
            }
        }

        /// <summary>
        /// The Account Short Name of the account on which the invoice is generated.
        /// </summary>
        [JsonProperty("InvoiceAccountShortName")]
        public string InvoiceAccountShortName
        {
            get
            {
                return this.invoiceAccountShortName;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountShortName"] = true;
                this.invoiceAccountShortName = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoiceDistributionMethods.
        /// </summary>
        [JsonProperty("InvoiceDistributionMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceDistributionMethod> InvoiceDistributionMethods { get; set; }

        /// <summary>
        /// Whether the account is international.
        /// </summary>
        [JsonProperty("IsInternational")]
        public bool? IsInternational
        {
            get
            {
                return this.isInternational;
            }

            set
            {
                this.shouldSerialize["IsInternational"] = true;
                this.isInternational = value;
            }
        }

        /// <summary>
        /// Whether the account is an invoice point.
        /// </summary>
        [JsonProperty("IsInvoicePoint")]
        public bool? IsInvoicePoint
        {
            get
            {
                return this.isInvoicePoint;
            }

            set
            {
                this.shouldSerialize["IsInvoicePoint"] = true;
                this.isInvoicePoint = value;
            }
        }

        /// <summary>
        /// Account last modified date and time
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
        /// ISO code of customer currency.
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
        /// Customer currency symbol.
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
        /// POS local language code
        /// </summary>
        [JsonProperty("LocalPOSLanguageCode")]
        public string LocalPOSLanguageCode
        {
            get
            {
                return this.localPOSLanguageCode;
            }

            set
            {
                this.shouldSerialize["LocalPOSLanguageCode"] = true;
                this.localPOSLanguageCode = value;
            }
        }

        /// <summary>
        /// POS local language ID
        /// </summary>
        [JsonProperty("LocalPOSLanguageID")]
        public int? LocalPOSLanguageID
        {
            get
            {
                return this.localPOSLanguageID;
            }

            set
            {
                this.shouldSerialize["LocalPOSLanguageID"] = true;
                this.localPOSLanguageID = value;
            }
        }

        /// <summary>
        /// Net amount in customer currency.
        /// </summary>
        [JsonProperty("NetAmount")]
        public double? NetAmount
        {
            get
            {
                return this.netAmount;
            }

            set
            {
                this.shouldSerialize["NetAmount"] = true;
                this.netAmount = value;
            }
        }

        /// <summary>
        /// Outstanding balance in customer currency.
        /// </summary>
        [JsonProperty("OutstandingBalance")]
        public double? OutstandingBalance
        {
            get
            {
                return this.outstandingBalance;
            }

            set
            {
                this.shouldSerialize["OutstandingBalance"] = true;
                this.outstandingBalance = value;
            }
        }

        /// <summary>
        /// Amount paid in customer currency.
        /// </summary>
        [JsonProperty("PaidAmount")]
        public double? PaidAmount
        {
            get
            {
                return this.paidAmount;
            }

            set
            {
                this.shouldSerialize["PaidAmount"] = true;
                this.paidAmount = value;
            }
        }

        /// <summary>
        /// Account Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Account status change reason id-description for the Status Reason, if any
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason
        {
            get
            {
                return this.statusReason;
            }

            set
            {
                this.shouldSerialize["StatusReason"] = true;
                this.statusReason = value;
            }
        }

        /// <summary>
        /// Total number of active card groups under the account
        /// </summary>
        [JsonProperty("TotalActiveCardGroups")]
        public int? TotalActiveCardGroups
        {
            get
            {
                return this.totalActiveCardGroups;
            }

            set
            {
                this.shouldSerialize["TotalActiveCardGroups"] = true;
                this.totalActiveCardGroups = value;
            }
        }

        /// <summary>
        /// Total number of active cards under the account.
        /// </summary>
        [JsonProperty("TotalActiveCards")]
        public int? TotalActiveCards
        {
            get
            {
                return this.totalActiveCards;
            }

            set
            {
                this.shouldSerialize["TotalActiveCards"] = true;
                this.totalActiveCards = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account that are permanently blocked
        /// </summary>
        [JsonProperty("TotalBlockedCards")]
        public int? TotalBlockedCards
        {
            get
            {
                return this.totalBlockedCards;
            }

            set
            {
                this.shouldSerialize["TotalBlockedCards"] = true;
                this.totalBlockedCards = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account that are cancelled
        /// </summary>
        [JsonProperty("TotalCancelledCards")]
        public int? TotalCancelledCards
        {
            get
            {
                return this.totalCancelledCards;
            }

            set
            {
                this.shouldSerialize["TotalCancelledCards"] = true;
                this.totalCancelledCards = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account.
        /// </summary>
        [JsonProperty("TotalCards")]
        public int? TotalCards
        {
            get
            {
                return this.totalCards;
            }

            set
            {
                this.shouldSerialize["TotalCards"] = true;
                this.totalCards = value;
            }
        }

        /// <summary>
        /// Total number of expired cards under the account.
        /// </summary>
        [JsonProperty("TotalExpiredCards")]
        public int? TotalExpiredCards
        {
            get
            {
                return this.totalExpiredCards;
            }

            set
            {
                this.shouldSerialize["TotalExpiredCards"] = true;
                this.totalExpiredCards = value;
            }
        }

        /// <summary>
        /// Total number of cards in Fraud status.
        /// </summary>
        [JsonProperty("TotalFraudCards")]
        public int? TotalFraudCards
        {
            get
            {
                return this.totalFraudCards;
            }

            set
            {
                this.shouldSerialize["TotalFraudCards"] = true;
                this.totalFraudCards = value;
            }
        }

        /// <summary>
        /// Total number of cards in “New” status.
        /// </summary>
        [JsonProperty("TotalNewCards")]
        public int? TotalNewCards
        {
            get
            {
                return this.totalNewCards;
            }

            set
            {
                this.shouldSerialize["TotalNewCards"] = true;
                this.totalNewCards = value;
            }
        }

        /// <summary>
        /// Total number of Renewal Pending account under the payer
        /// </summary>
        [JsonProperty("TotalRenewalPendingCards")]
        public int? TotalRenewalPendingCards
        {
            get
            {
                return this.totalRenewalPendingCards;
            }

            set
            {
                this.shouldSerialize["TotalRenewalPendingCards"] = true;
                this.totalRenewalPendingCards = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account with status as “Replaced”
        /// </summary>
        [JsonProperty("TotalReplacedCards")]
        public int? TotalReplacedCards
        {
            get
            {
                return this.totalReplacedCards;
            }

            set
            {
                this.shouldSerialize["TotalReplacedCards"] = true;
                this.totalReplacedCards = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account that are temporarily blocked by customer.
        /// </summary>
        [JsonProperty("TotalTemporaryBlockCardsByCustomer")]
        public int? TotalTemporaryBlockCardsByCustomer
        {
            get
            {
                return this.totalTemporaryBlockCardsByCustomer;
            }

            set
            {
                this.shouldSerialize["TotalTemporaryBlockCardsByCustomer"] = true;
                this.totalTemporaryBlockCardsByCustomer = value;
            }
        }

        /// <summary>
        /// Total number of cards under the account that are temporarily blocked by Shell.
        /// </summary>
        [JsonProperty("TotalTemporaryBlockCardsByShell")]
        public int? TotalTemporaryBlockCardsByShell
        {
            get
            {
                return this.totalTemporaryBlockCardsByShell;
            }

            set
            {
                this.shouldSerialize["TotalTemporaryBlockCardsByShell"] = true;
                this.totalTemporaryBlockCardsByShell = value;
            }
        }

        /// <summary>
        /// VAT amount in customer currency.
        /// </summary>
        [JsonProperty("VATAmount")]
        public double? VATAmount
        {
            get
            {
                return this.vATAmount;
            }

            set
            {
                this.shouldSerialize["VATAmount"] = true;
                this.vATAmount = value;
            }
        }

        /// <summary>
        /// The account / sub-account is partner card account or not.
        /// Possible values (1= Non-PC account, 2= PC account, 3= PC Payer with Card Types, 4= PC Payer)
        /// Note: A partner card account is assumed to have only partner card card-types associated
        /// </summary>
        [JsonProperty("IsPartnerCard")]
        public int? IsPartnerCard
        {
            get
            {
                return this.isPartnerCard;
            }

            set
            {
                this.shouldSerialize["IsPartnerCard"] = true;
                this.isPartnerCard = value;
            }
        }

        /// <summary>
        /// Customer id in e-TM system
        /// </summary>
        [JsonProperty("TollsCustomerId")]
        public string TollsCustomerId
        {
            get
            {
                return this.tollsCustomerId;
            }

            set
            {
                this.shouldSerialize["TollsCustomerId"] = true;
                this.tollsCustomerId = value;
            }
        }

        /// <summary>
        /// Colco country type id in e-TM system
        /// </summary>
        [JsonProperty("TollsColcoCountryTypeId")]
        public string TollsColcoCountryTypeId
        {
            get
            {
                return this.tollsColcoCountryTypeId;
            }

            set
            {
                this.shouldSerialize["TollsColcoCountryTypeId"] = true;
                this.tollsColcoCountryTypeId = value;
            }
        }

        /// <summary>
        /// Gets or sets Contracts.
        /// </summary>
        [JsonProperty("Contracts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomerContract> Contracts { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [JsonProperty("IsConsortiumMember")]
        public string IsConsortiumMember
        {
            get
            {
                return this.isConsortiumMember;
            }

            set
            {
                this.shouldSerialize["IsConsortiumMember"] = true;
                this.isConsortiumMember = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountResponseAccountsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountFullName()
        {
            this.shouldSerialize["AccountFullName"] = false;
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
        public void UnsetBillingFrequencyType()
        {
            this.shouldSerialize["BillingFrequencyType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingFrequencyTypeId()
        {
            this.shouldSerialize["BillingFrequencyTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingRunFrequency()
        {
            this.shouldSerialize["BillingRunFrequency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingRunFrequencyTypeId()
        {
            this.shouldSerialize["BillingRunFrequencyTypeId"] = false;
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
        public void UnsetDay1Run()
        {
            this.shouldSerialize["Day1Run"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDay2Run()
        {
            this.shouldSerialize["Day2Run"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDay3Run()
        {
            this.shouldSerialize["Day3Run"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDay4Run()
        {
            this.shouldSerialize["Day4Run"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFrequencyType()
        {
            this.shouldSerialize["FrequencyType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGrossAmount()
        {
            this.shouldSerialize["GrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInternationalPOSLanguageCode()
        {
            this.shouldSerialize["InternationalPOSLanguageCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInternationalPOSLanguageID()
        {
            this.shouldSerialize["InternationalPOSLanguageID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountID()
        {
            this.shouldSerialize["InvoiceAccountID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountNumber()
        {
            this.shouldSerialize["InvoiceAccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountShortName()
        {
            this.shouldSerialize["InvoiceAccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsInternational()
        {
            this.shouldSerialize["IsInternational"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsInvoicePoint()
        {
            this.shouldSerialize["IsInvoicePoint"] = false;
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
        public void UnsetLocalPOSLanguageCode()
        {
            this.shouldSerialize["LocalPOSLanguageCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalPOSLanguageID()
        {
            this.shouldSerialize["LocalPOSLanguageID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetAmount()
        {
            this.shouldSerialize["NetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOutstandingBalance()
        {
            this.shouldSerialize["OutstandingBalance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaidAmount()
        {
            this.shouldSerialize["PaidAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatusReason()
        {
            this.shouldSerialize["StatusReason"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalActiveCardGroups()
        {
            this.shouldSerialize["TotalActiveCardGroups"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalActiveCards()
        {
            this.shouldSerialize["TotalActiveCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalBlockedCards()
        {
            this.shouldSerialize["TotalBlockedCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalCancelledCards()
        {
            this.shouldSerialize["TotalCancelledCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalCards()
        {
            this.shouldSerialize["TotalCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalExpiredCards()
        {
            this.shouldSerialize["TotalExpiredCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalFraudCards()
        {
            this.shouldSerialize["TotalFraudCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalNewCards()
        {
            this.shouldSerialize["TotalNewCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalRenewalPendingCards()
        {
            this.shouldSerialize["TotalRenewalPendingCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalReplacedCards()
        {
            this.shouldSerialize["TotalReplacedCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalTemporaryBlockCardsByCustomer()
        {
            this.shouldSerialize["TotalTemporaryBlockCardsByCustomer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalTemporaryBlockCardsByShell()
        {
            this.shouldSerialize["TotalTemporaryBlockCardsByShell"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATAmount()
        {
            this.shouldSerialize["VATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsPartnerCard()
        {
            this.shouldSerialize["IsPartnerCard"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTollsCustomerId()
        {
            this.shouldSerialize["TollsCustomerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTollsColcoCountryTypeId()
        {
            this.shouldSerialize["TollsColcoCountryTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsConsortiumMember()
        {
            this.shouldSerialize["IsConsortiumMember"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountFullName()
        {
            return this.shouldSerialize["AccountFullName"];
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
        public bool ShouldSerializeBillingFrequencyType()
        {
            return this.shouldSerialize["BillingFrequencyType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingFrequencyTypeId()
        {
            return this.shouldSerialize["BillingFrequencyTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingRunFrequency()
        {
            return this.shouldSerialize["BillingRunFrequency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingRunFrequencyTypeId()
        {
            return this.shouldSerialize["BillingRunFrequencyTypeId"];
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
        public bool ShouldSerializeDay1Run()
        {
            return this.shouldSerialize["Day1Run"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDay2Run()
        {
            return this.shouldSerialize["Day2Run"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDay3Run()
        {
            return this.shouldSerialize["Day3Run"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDay4Run()
        {
            return this.shouldSerialize["Day4Run"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrequencyType()
        {
            return this.shouldSerialize["FrequencyType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrossAmount()
        {
            return this.shouldSerialize["GrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInternationalPOSLanguageCode()
        {
            return this.shouldSerialize["InternationalPOSLanguageCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInternationalPOSLanguageID()
        {
            return this.shouldSerialize["InternationalPOSLanguageID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountID()
        {
            return this.shouldSerialize["InvoiceAccountID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountNumber()
        {
            return this.shouldSerialize["InvoiceAccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountShortName()
        {
            return this.shouldSerialize["InvoiceAccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsInternational()
        {
            return this.shouldSerialize["IsInternational"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsInvoicePoint()
        {
            return this.shouldSerialize["IsInvoicePoint"];
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
        public bool ShouldSerializeLocalPOSLanguageCode()
        {
            return this.shouldSerialize["LocalPOSLanguageCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalPOSLanguageID()
        {
            return this.shouldSerialize["LocalPOSLanguageID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetAmount()
        {
            return this.shouldSerialize["NetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOutstandingBalance()
        {
            return this.shouldSerialize["OutstandingBalance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAmount()
        {
            return this.shouldSerialize["PaidAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatusReason()
        {
            return this.shouldSerialize["StatusReason"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalActiveCardGroups()
        {
            return this.shouldSerialize["TotalActiveCardGroups"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalActiveCards()
        {
            return this.shouldSerialize["TotalActiveCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalBlockedCards()
        {
            return this.shouldSerialize["TotalBlockedCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCancelledCards()
        {
            return this.shouldSerialize["TotalCancelledCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCards()
        {
            return this.shouldSerialize["TotalCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalExpiredCards()
        {
            return this.shouldSerialize["TotalExpiredCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalFraudCards()
        {
            return this.shouldSerialize["TotalFraudCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalNewCards()
        {
            return this.shouldSerialize["TotalNewCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalRenewalPendingCards()
        {
            return this.shouldSerialize["TotalRenewalPendingCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalReplacedCards()
        {
            return this.shouldSerialize["TotalReplacedCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalTemporaryBlockCardsByCustomer()
        {
            return this.shouldSerialize["TotalTemporaryBlockCardsByCustomer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalTemporaryBlockCardsByShell()
        {
            return this.shouldSerialize["TotalTemporaryBlockCardsByShell"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATAmount()
        {
            return this.shouldSerialize["VATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsPartnerCard()
        {
            return this.shouldSerialize["IsPartnerCard"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTollsCustomerId()
        {
            return this.shouldSerialize["TollsCustomerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTollsColcoCountryTypeId()
        {
            return this.shouldSerialize["TollsColcoCountryTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsConsortiumMember()
        {
            return this.shouldSerialize["IsConsortiumMember"];
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
            return obj is AccountResponseAccountsItems other &&                ((this.AccountFullName == null && other.AccountFullName == null) || (this.AccountFullName?.Equals(other.AccountFullName) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.BestOfIndicator == null && other.BestOfIndicator == null) || (this.BestOfIndicator?.Equals(other.BestOfIndicator) == true)) &&
                ((this.BillingFrequencyType == null && other.BillingFrequencyType == null) || (this.BillingFrequencyType?.Equals(other.BillingFrequencyType) == true)) &&
                ((this.BillingFrequencyTypeId == null && other.BillingFrequencyTypeId == null) || (this.BillingFrequencyTypeId?.Equals(other.BillingFrequencyTypeId) == true)) &&
                ((this.BillingRunFrequency == null && other.BillingRunFrequency == null) || (this.BillingRunFrequency?.Equals(other.BillingRunFrequency) == true)) &&
                ((this.BillingRunFrequencyTypeId == null && other.BillingRunFrequencyTypeId == null) || (this.BillingRunFrequencyTypeId?.Equals(other.BillingRunFrequencyTypeId) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.Day1Run == null && other.Day1Run == null) || (this.Day1Run?.Equals(other.Day1Run) == true)) &&
                ((this.Day2Run == null && other.Day2Run == null) || (this.Day2Run?.Equals(other.Day2Run) == true)) &&
                ((this.Day3Run == null && other.Day3Run == null) || (this.Day3Run?.Equals(other.Day3Run) == true)) &&
                ((this.Day4Run == null && other.Day4Run == null) || (this.Day4Run?.Equals(other.Day4Run) == true)) &&
                ((this.FrequencyType == null && other.FrequencyType == null) || (this.FrequencyType?.Equals(other.FrequencyType) == true)) &&
                ((this.GrossAmount == null && other.GrossAmount == null) || (this.GrossAmount?.Equals(other.GrossAmount) == true)) &&
                ((this.InternationalPOSLanguageCode == null && other.InternationalPOSLanguageCode == null) || (this.InternationalPOSLanguageCode?.Equals(other.InternationalPOSLanguageCode) == true)) &&
                ((this.InternationalPOSLanguageID == null && other.InternationalPOSLanguageID == null) || (this.InternationalPOSLanguageID?.Equals(other.InternationalPOSLanguageID) == true)) &&
                ((this.InvoiceAccountID == null && other.InvoiceAccountID == null) || (this.InvoiceAccountID?.Equals(other.InvoiceAccountID) == true)) &&
                ((this.InvoiceAccountNumber == null && other.InvoiceAccountNumber == null) || (this.InvoiceAccountNumber?.Equals(other.InvoiceAccountNumber) == true)) &&
                ((this.InvoiceAccountShortName == null && other.InvoiceAccountShortName == null) || (this.InvoiceAccountShortName?.Equals(other.InvoiceAccountShortName) == true)) &&
                ((this.InvoiceDistributionMethods == null && other.InvoiceDistributionMethods == null) || (this.InvoiceDistributionMethods?.Equals(other.InvoiceDistributionMethods) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.IsInvoicePoint == null && other.IsInvoicePoint == null) || (this.IsInvoicePoint?.Equals(other.IsInvoicePoint) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.LocalCurrencyCode == null && other.LocalCurrencyCode == null) || (this.LocalCurrencyCode?.Equals(other.LocalCurrencyCode) == true)) &&
                ((this.LocalCurrencySymbol == null && other.LocalCurrencySymbol == null) || (this.LocalCurrencySymbol?.Equals(other.LocalCurrencySymbol) == true)) &&
                ((this.LocalPOSLanguageCode == null && other.LocalPOSLanguageCode == null) || (this.LocalPOSLanguageCode?.Equals(other.LocalPOSLanguageCode) == true)) &&
                ((this.LocalPOSLanguageID == null && other.LocalPOSLanguageID == null) || (this.LocalPOSLanguageID?.Equals(other.LocalPOSLanguageID) == true)) &&
                ((this.NetAmount == null && other.NetAmount == null) || (this.NetAmount?.Equals(other.NetAmount) == true)) &&
                ((this.OutstandingBalance == null && other.OutstandingBalance == null) || (this.OutstandingBalance?.Equals(other.OutstandingBalance) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.TotalActiveCardGroups == null && other.TotalActiveCardGroups == null) || (this.TotalActiveCardGroups?.Equals(other.TotalActiveCardGroups) == true)) &&
                ((this.TotalActiveCards == null && other.TotalActiveCards == null) || (this.TotalActiveCards?.Equals(other.TotalActiveCards) == true)) &&
                ((this.TotalBlockedCards == null && other.TotalBlockedCards == null) || (this.TotalBlockedCards?.Equals(other.TotalBlockedCards) == true)) &&
                ((this.TotalCancelledCards == null && other.TotalCancelledCards == null) || (this.TotalCancelledCards?.Equals(other.TotalCancelledCards) == true)) &&
                ((this.TotalCards == null && other.TotalCards == null) || (this.TotalCards?.Equals(other.TotalCards) == true)) &&
                ((this.TotalExpiredCards == null && other.TotalExpiredCards == null) || (this.TotalExpiredCards?.Equals(other.TotalExpiredCards) == true)) &&
                ((this.TotalFraudCards == null && other.TotalFraudCards == null) || (this.TotalFraudCards?.Equals(other.TotalFraudCards) == true)) &&
                ((this.TotalNewCards == null && other.TotalNewCards == null) || (this.TotalNewCards?.Equals(other.TotalNewCards) == true)) &&
                ((this.TotalRenewalPendingCards == null && other.TotalRenewalPendingCards == null) || (this.TotalRenewalPendingCards?.Equals(other.TotalRenewalPendingCards) == true)) &&
                ((this.TotalReplacedCards == null && other.TotalReplacedCards == null) || (this.TotalReplacedCards?.Equals(other.TotalReplacedCards) == true)) &&
                ((this.TotalTemporaryBlockCardsByCustomer == null && other.TotalTemporaryBlockCardsByCustomer == null) || (this.TotalTemporaryBlockCardsByCustomer?.Equals(other.TotalTemporaryBlockCardsByCustomer) == true)) &&
                ((this.TotalTemporaryBlockCardsByShell == null && other.TotalTemporaryBlockCardsByShell == null) || (this.TotalTemporaryBlockCardsByShell?.Equals(other.TotalTemporaryBlockCardsByShell) == true)) &&
                ((this.VATAmount == null && other.VATAmount == null) || (this.VATAmount?.Equals(other.VATAmount) == true)) &&
                ((this.IsPartnerCard == null && other.IsPartnerCard == null) || (this.IsPartnerCard?.Equals(other.IsPartnerCard) == true)) &&
                ((this.TollsCustomerId == null && other.TollsCustomerId == null) || (this.TollsCustomerId?.Equals(other.TollsCustomerId) == true)) &&
                ((this.TollsColcoCountryTypeId == null && other.TollsColcoCountryTypeId == null) || (this.TollsColcoCountryTypeId?.Equals(other.TollsColcoCountryTypeId) == true)) &&
                ((this.Contracts == null && other.Contracts == null) || (this.Contracts?.Equals(other.Contracts) == true)) &&
                ((this.IsConsortiumMember == null && other.IsConsortiumMember == null) || (this.IsConsortiumMember?.Equals(other.IsConsortiumMember) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountFullName = {(this.AccountFullName == null ? "null" : this.AccountFullName)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.BestOfIndicator = {(this.BestOfIndicator == null ? "null" : this.BestOfIndicator.ToString())}");
            toStringOutput.Add($"this.BillingFrequencyType = {(this.BillingFrequencyType == null ? "null" : this.BillingFrequencyType)}");
            toStringOutput.Add($"this.BillingFrequencyTypeId = {(this.BillingFrequencyTypeId == null ? "null" : this.BillingFrequencyTypeId.ToString())}");
            toStringOutput.Add($"this.BillingRunFrequency = {(this.BillingRunFrequency == null ? "null" : this.BillingRunFrequency)}");
            toStringOutput.Add($"this.BillingRunFrequencyTypeId = {(this.BillingRunFrequencyTypeId == null ? "null" : this.BillingRunFrequencyTypeId.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.Day1Run = {(this.Day1Run == null ? "null" : this.Day1Run.ToString())}");
            toStringOutput.Add($"this.Day2Run = {(this.Day2Run == null ? "null" : this.Day2Run.ToString())}");
            toStringOutput.Add($"this.Day3Run = {(this.Day3Run == null ? "null" : this.Day3Run.ToString())}");
            toStringOutput.Add($"this.Day4Run = {(this.Day4Run == null ? "null" : this.Day4Run.ToString())}");
            toStringOutput.Add($"this.FrequencyType = {(this.FrequencyType == null ? "null" : this.FrequencyType)}");
            toStringOutput.Add($"this.GrossAmount = {(this.GrossAmount == null ? "null" : this.GrossAmount.ToString())}");
            toStringOutput.Add($"this.InternationalPOSLanguageCode = {(this.InternationalPOSLanguageCode == null ? "null" : this.InternationalPOSLanguageCode)}");
            toStringOutput.Add($"this.InternationalPOSLanguageID = {(this.InternationalPOSLanguageID == null ? "null" : this.InternationalPOSLanguageID.ToString())}");
            toStringOutput.Add($"this.InvoiceAccountID = {(this.InvoiceAccountID == null ? "null" : this.InvoiceAccountID.ToString())}");
            toStringOutput.Add($"this.InvoiceAccountNumber = {(this.InvoiceAccountNumber == null ? "null" : this.InvoiceAccountNumber)}");
            toStringOutput.Add($"this.InvoiceAccountShortName = {(this.InvoiceAccountShortName == null ? "null" : this.InvoiceAccountShortName)}");
            toStringOutput.Add($"this.InvoiceDistributionMethods = {(this.InvoiceDistributionMethods == null ? "null" : $"[{string.Join(", ", this.InvoiceDistributionMethods)} ]")}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.IsInvoicePoint = {(this.IsInvoicePoint == null ? "null" : this.IsInvoicePoint.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate)}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.LocalPOSLanguageCode = {(this.LocalPOSLanguageCode == null ? "null" : this.LocalPOSLanguageCode)}");
            toStringOutput.Add($"this.LocalPOSLanguageID = {(this.LocalPOSLanguageID == null ? "null" : this.LocalPOSLanguageID.ToString())}");
            toStringOutput.Add($"this.NetAmount = {(this.NetAmount == null ? "null" : this.NetAmount.ToString())}");
            toStringOutput.Add($"this.OutstandingBalance = {(this.OutstandingBalance == null ? "null" : this.OutstandingBalance.ToString())}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.TotalActiveCardGroups = {(this.TotalActiveCardGroups == null ? "null" : this.TotalActiveCardGroups.ToString())}");
            toStringOutput.Add($"this.TotalActiveCards = {(this.TotalActiveCards == null ? "null" : this.TotalActiveCards.ToString())}");
            toStringOutput.Add($"this.TotalBlockedCards = {(this.TotalBlockedCards == null ? "null" : this.TotalBlockedCards.ToString())}");
            toStringOutput.Add($"this.TotalCancelledCards = {(this.TotalCancelledCards == null ? "null" : this.TotalCancelledCards.ToString())}");
            toStringOutput.Add($"this.TotalCards = {(this.TotalCards == null ? "null" : this.TotalCards.ToString())}");
            toStringOutput.Add($"this.TotalExpiredCards = {(this.TotalExpiredCards == null ? "null" : this.TotalExpiredCards.ToString())}");
            toStringOutput.Add($"this.TotalFraudCards = {(this.TotalFraudCards == null ? "null" : this.TotalFraudCards.ToString())}");
            toStringOutput.Add($"this.TotalNewCards = {(this.TotalNewCards == null ? "null" : this.TotalNewCards.ToString())}");
            toStringOutput.Add($"this.TotalRenewalPendingCards = {(this.TotalRenewalPendingCards == null ? "null" : this.TotalRenewalPendingCards.ToString())}");
            toStringOutput.Add($"this.TotalReplacedCards = {(this.TotalReplacedCards == null ? "null" : this.TotalReplacedCards.ToString())}");
            toStringOutput.Add($"this.TotalTemporaryBlockCardsByCustomer = {(this.TotalTemporaryBlockCardsByCustomer == null ? "null" : this.TotalTemporaryBlockCardsByCustomer.ToString())}");
            toStringOutput.Add($"this.TotalTemporaryBlockCardsByShell = {(this.TotalTemporaryBlockCardsByShell == null ? "null" : this.TotalTemporaryBlockCardsByShell.ToString())}");
            toStringOutput.Add($"this.VATAmount = {(this.VATAmount == null ? "null" : this.VATAmount.ToString())}");
            toStringOutput.Add($"this.IsPartnerCard = {(this.IsPartnerCard == null ? "null" : this.IsPartnerCard.ToString())}");
            toStringOutput.Add($"this.TollsCustomerId = {(this.TollsCustomerId == null ? "null" : this.TollsCustomerId)}");
            toStringOutput.Add($"this.TollsColcoCountryTypeId = {(this.TollsColcoCountryTypeId == null ? "null" : this.TollsColcoCountryTypeId)}");
            toStringOutput.Add($"this.Contracts = {(this.Contracts == null ? "null" : $"[{string.Join(", ", this.Contracts)} ]")}");
            toStringOutput.Add($"this.IsConsortiumMember = {(this.IsConsortiumMember == null ? "null" : this.IsConsortiumMember)}");
        }
    }
}
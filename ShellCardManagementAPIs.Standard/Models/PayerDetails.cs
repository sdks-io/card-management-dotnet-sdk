// <copyright file="PayerDetails.cs" company="APIMatic">
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
    /// PayerDetails.
    /// </summary>
    public class PayerDetails
    {
        private int? colCoId;
        private int? colCoCode;
        private string countryCode;
        private string country;
        private int? payerId;
        private string payerNumber;
        private string payerFullName;
        private string payerShortName;
        private int? payerGroupId;
        private double? amountDue;
        private double? amountOverdue;
        private double? amountNotOverdue;
        private double? outstandingBalance;
        private double? unallocatedPayment;
        private string sOACurrencyCode;
        private string sOACurrencySymbol;
        private string sOACreditLimitCurrencyCode;
        private string sOACreditLimitCurrencySymbol;
        private string lastPaymentCurrencyCode;
        private string lastPaymentCurrencySymbol;
        private double? lastPaymentAmount;
        private string lastPaymentDate;
        private double? sOALastPaymentAmount;
        private string sOALastPaymentDate;
        private string currencyCode;
        private string currencySymbol;
        private string colCoCountryCode;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private double? localCurrencyExchangeRate;
        private double? localCurrencyExchangeRateSoA;
        private int? billingFrequencyTypeId;
        private string billingFrequencyType;
        private int? billingRunFrequencyTypeId;
        private string billingRunFrequnecy;
        private int? day1Run;
        private int? day2Run;
        private int? day3Run;
        private int? day4Run;
        private string outputType;
        private int? invoiceAccountID;
        private string invoiceAccountNumber;
        private string invoiceAccountShortName;
        private int? totalAccounts;
        private int? totalActiveAccounts;
        private int? totalCards;
        private int? totalActiveCards;
        private int? totalBlockedCards;
        private int? totalCancelledCards;
        private int? totalExpiredCards;
        private int? totalRenewalPendingCards;
        private int? totalReplacedCards;
        private int? totalTemporaryBlockCardsByCustomer;
        private int? totalTemporaryBlockCardsByShell;
        private int? totalNewCards;
        private int? totalFraudCards;
        private int? totalBlockedAccounts;
        private int? totalCancelledAccounts;
        private string payerTradingName;
        private string billingLanguage;
        private string legalEntity;
        private string dateEstablished;
        private string customerClassification;
        private string industryClass;
        private string marketingSegmentation;
        private string lineOfBusiness;
        private string cardGroupType;
        private string vATRegNumber;
        private string registrationNumber;
        private string registrationNumber2;
        private double? salesLedgerBalance;
        private double? exposure;
        private double? outstandingDebt;
        private double? availableCredit;
        private string band;
        private string globalCustomerReferenceId;
        private double? creditLimit;
        private double? creditLimitInCustomerCurrency;
        private string billingCurrencyCode;
        private string billingCurrencySymbol;
        private string paymentMethod;
        private string paymentTerms;
        private double? temporaryCreditLimitIncrease;
        private double? temporaryCreditLimitIncreaseInCustomerCurrency;
        private string temporaryCreditLimitExpiryDate;
        private string tollsCustomerId;
        private string tollsColcoCountryTypeId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "CountryCode", false },
            { "Country", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerFullName", false },
            { "PayerShortName", false },
            { "PayerGroupId", false },
            { "AmountDue", false },
            { "AmountOverdue", false },
            { "AmountNotOverdue", false },
            { "OutstandingBalance", false },
            { "UnallocatedPayment", false },
            { "SOACurrencyCode", false },
            { "SOACurrencySymbol", false },
            { "SOACreditLimitCurrencyCode", false },
            { "SOACreditLimitCurrencySymbol", false },
            { "LastPaymentCurrencyCode", false },
            { "LastPaymentCurrencySymbol", false },
            { "LastPaymentAmount", false },
            { "LastPaymentDate", false },
            { "SOALastPaymentAmount", false },
            { "SOALastPaymentDate", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "ColCoCountryCode", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "LocalCurrencyExchangeRate", false },
            { "LocalCurrencyExchangeRate_SoA", false },
            { "BillingFrequencyTypeId", false },
            { "BillingFrequencyType", false },
            { "BillingRunFrequencyTypeId", false },
            { "BillingRunFrequnecy", false },
            { "Day1Run", false },
            { "Day2Run", false },
            { "Day3Run", false },
            { "Day4Run", false },
            { "OutputType", false },
            { "InvoiceAccountID", false },
            { "InvoiceAccountNumber", false },
            { "InvoiceAccountShortName", false },
            { "TotalAccounts", false },
            { "TotalActiveAccounts", false },
            { "TotalCards", false },
            { "TotalActiveCards", false },
            { "TotalBlockedCards", false },
            { "TotalCancelledCards", false },
            { "TotalExpiredCards", false },
            { "TotalRenewalPendingCards", false },
            { "TotalReplacedCards", false },
            { "TotalTemporaryBlockCardsByCustomer", false },
            { "TotalTemporaryBlockCardsByShell", false },
            { "TotalNewCards", false },
            { "TotalFraudCards", false },
            { "TotalBlockedAccounts", false },
            { "TotalCancelledAccounts", false },
            { "PayerTradingName", false },
            { "BillingLanguage", false },
            { "LegalEntity", false },
            { "DateEstablished", false },
            { "CustomerClassification", false },
            { "IndustryClass", false },
            { "MarketingSegmentation", false },
            { "LineOfBusiness", false },
            { "CardGroupType", false },
            { "VATRegNumber", false },
            { "RegistrationNumber", false },
            { "RegistrationNumber2", false },
            { "SalesLedgerBalance", false },
            { "Exposure", false },
            { "OutstandingDebt", false },
            { "AvailableCredit", false },
            { "Band", false },
            { "GlobalCustomerReferenceId", false },
            { "CreditLimit", false },
            { "CreditLimitInCustomerCurrency", false },
            { "BillingCurrencyCode", false },
            { "BillingCurrencySymbol", false },
            { "PaymentMethod", false },
            { "PaymentTerms", false },
            { "TemporaryCreditLimitIncrease", false },
            { "TemporaryCreditLimitIncreaseInCustomerCurrency", false },
            { "TemporaryCreditLimitExpiryDate", false },
            { "TollsCustomerId", false },
            { "TollsColcoCountryTypeId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerDetails"/> class.
        /// </summary>
        public PayerDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerDetails"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="countryCode">CountryCode.</param>
        /// <param name="country">Country.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerFullName">PayerFullName.</param>
        /// <param name="payerShortName">PayerShortName.</param>
        /// <param name="payerGroupId">PayerGroupId.</param>
        /// <param name="amountDue">AmountDue.</param>
        /// <param name="amountOverdue">AmountOverdue.</param>
        /// <param name="amountNotOverdue">AmountNotOverdue.</param>
        /// <param name="outstandingBalance">OutstandingBalance.</param>
        /// <param name="unallocatedPayment">UnallocatedPayment.</param>
        /// <param name="sOACurrencyCode">SOACurrencyCode.</param>
        /// <param name="sOACurrencySymbol">SOACurrencySymbol.</param>
        /// <param name="sOACreditLimitCurrencyCode">SOACreditLimitCurrencyCode.</param>
        /// <param name="sOACreditLimitCurrencySymbol">SOACreditLimitCurrencySymbol.</param>
        /// <param name="lastPaymentCurrencyCode">LastPaymentCurrencyCode.</param>
        /// <param name="lastPaymentCurrencySymbol">LastPaymentCurrencySymbol.</param>
        /// <param name="lastPaymentAmount">LastPaymentAmount.</param>
        /// <param name="lastPaymentDate">LastPaymentDate.</param>
        /// <param name="sOALastPaymentAmount">SOALastPaymentAmount.</param>
        /// <param name="sOALastPaymentDate">SOALastPaymentDate.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="localCurrencyExchangeRate">LocalCurrencyExchangeRate.</param>
        /// <param name="localCurrencyExchangeRateSoA">LocalCurrencyExchangeRate_SoA.</param>
        /// <param name="billingFrequencyTypeId">BillingFrequencyTypeId.</param>
        /// <param name="billingFrequencyType">BillingFrequencyType.</param>
        /// <param name="billingRunFrequencyTypeId">BillingRunFrequencyTypeId.</param>
        /// <param name="billingRunFrequnecy">BillingRunFrequnecy.</param>
        /// <param name="day1Run">Day1Run.</param>
        /// <param name="day2Run">Day2Run.</param>
        /// <param name="day3Run">Day3Run.</param>
        /// <param name="day4Run">Day4Run.</param>
        /// <param name="invoiceDistributionMethods">InvoiceDistributionMethods.</param>
        /// <param name="outputType">OutputType.</param>
        /// <param name="invoiceAccountID">InvoiceAccountID.</param>
        /// <param name="invoiceAccountNumber">InvoiceAccountNumber.</param>
        /// <param name="invoiceAccountShortName">InvoiceAccountShortName.</param>
        /// <param name="bestOfIndicator">BestOfIndicator.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="totalAccounts">TotalAccounts.</param>
        /// <param name="totalActiveAccounts">TotalActiveAccounts.</param>
        /// <param name="totalCards">TotalCards.</param>
        /// <param name="totalActiveCards">TotalActiveCards.</param>
        /// <param name="totalBlockedCards">TotalBlockedCards.</param>
        /// <param name="totalCancelledCards">TotalCancelledCards.</param>
        /// <param name="totalExpiredCards">TotalExpiredCards.</param>
        /// <param name="totalRenewalPendingCards">TotalRenewalPendingCards.</param>
        /// <param name="totalReplacedCards">TotalReplacedCards.</param>
        /// <param name="totalTemporaryBlockCardsByCustomer">TotalTemporaryBlockCardsByCustomer.</param>
        /// <param name="totalTemporaryBlockCardsByShell">TotalTemporaryBlockCardsByShell.</param>
        /// <param name="totalNewCards">TotalNewCards.</param>
        /// <param name="totalFraudCards">TotalFraudCards.</param>
        /// <param name="totalBlockedAccounts">TotalBlockedAccounts.</param>
        /// <param name="totalCancelledAccounts">TotalCancelledAccounts.</param>
        /// <param name="payerTradingName">PayerTradingName.</param>
        /// <param name="status">Status.</param>
        /// <param name="billingLanguage">BillingLanguage.</param>
        /// <param name="legalEntity">LegalEntity.</param>
        /// <param name="dateEstablished">DateEstablished.</param>
        /// <param name="customerClassification">CustomerClassification.</param>
        /// <param name="industryClass">IndustryClass.</param>
        /// <param name="marketingSegmentation">MarketingSegmentation.</param>
        /// <param name="lineOfBusiness">LineOfBusiness.</param>
        /// <param name="printCreditLimit">PrintCreditLimit.</param>
        /// <param name="cardGroupType">CardGroupType.</param>
        /// <param name="renewCards">RenewCards.</param>
        /// <param name="allowSelectPIN">AllowSelectPIN.</param>
        /// <param name="useFleetPIN">UseFleetPIN.</param>
        /// <param name="vATRegNumber">VATRegNumber.</param>
        /// <param name="vATRegNumber2">VATRegNumber2.</param>
        /// <param name="registrationNumber">RegistrationNumber.</param>
        /// <param name="registrationNumber2">RegistrationNumber2.</param>
        /// <param name="salesLedgerBalance">SalesLedgerBalance.</param>
        /// <param name="exposure">Exposure.</param>
        /// <param name="outstandingDebt">OutstandingDebt.</param>
        /// <param name="availableCredit">AvailableCredit.</param>
        /// <param name="band">Band.</param>
        /// <param name="globalCustomerReferenceId">GlobalCustomerReferenceId.</param>
        /// <param name="creditLimit">CreditLimit.</param>
        /// <param name="creditLimitInCustomerCurrency">CreditLimitInCustomerCurrency.</param>
        /// <param name="billingCurrencyCode">BillingCurrencyCode.</param>
        /// <param name="billingCurrencySymbol">BillingCurrencySymbol.</param>
        /// <param name="paymentMethod">PaymentMethod.</param>
        /// <param name="paymentTerms">PaymentTerms.</param>
        /// <param name="temporaryCreditLimitIncrease">TemporaryCreditLimitIncrease.</param>
        /// <param name="temporaryCreditLimitIncreaseInCustomerCurrency">TemporaryCreditLimitIncreaseInCustomerCurrency.</param>
        /// <param name="temporaryCreditLimitExpiryDate">TemporaryCreditLimitExpiryDate.</param>
        /// <param name="payerBankAccount">PayerBankAccount.</param>
        /// <param name="cardDeliveryAddress">CardDeliveryAddress.</param>
        /// <param name="correspondanceAddress">CorrespondanceAddress.</param>
        /// <param name="billingAddress">BillingAddress.</param>
        /// <param name="hasActiveVolBasedPricing">HasActiveVolBasedPricing.</param>
        /// <param name="hasActiveVolBasedBonus">HasActiveVolBasedBonus.</param>
        /// <param name="hasActiveVolBasedAssociationBonus">HasActiveVolBasedAssociationBonus.</param>
        /// <param name="financeCurrency">FinanceCurrency.</param>
        /// <param name="tollsCustomerId">TollsCustomerId.</param>
        /// <param name="tollsColcoCountryTypeId">TollsColcoCountryTypeId.</param>
        /// <param name="contracts">Contracts.</param>
        public PayerDetails(
            int? colCoId = null,
            int? colCoCode = null,
            string countryCode = null,
            string country = null,
            int? payerId = null,
            string payerNumber = null,
            string payerFullName = null,
            string payerShortName = null,
            int? payerGroupId = null,
            double? amountDue = null,
            double? amountOverdue = null,
            double? amountNotOverdue = null,
            double? outstandingBalance = null,
            double? unallocatedPayment = null,
            string sOACurrencyCode = null,
            string sOACurrencySymbol = null,
            string sOACreditLimitCurrencyCode = null,
            string sOACreditLimitCurrencySymbol = null,
            string lastPaymentCurrencyCode = null,
            string lastPaymentCurrencySymbol = null,
            double? lastPaymentAmount = null,
            string lastPaymentDate = null,
            double? sOALastPaymentAmount = null,
            string sOALastPaymentDate = null,
            string currencyCode = null,
            string currencySymbol = null,
            string colCoCountryCode = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            double? localCurrencyExchangeRate = null,
            double? localCurrencyExchangeRateSoA = null,
            int? billingFrequencyTypeId = null,
            string billingFrequencyType = null,
            int? billingRunFrequencyTypeId = null,
            string billingRunFrequnecy = null,
            int? day1Run = null,
            int? day2Run = null,
            int? day3Run = null,
            int? day4Run = null,
            List<Models.InvoiceDistributionMethod> invoiceDistributionMethods = null,
            string outputType = null,
            int? invoiceAccountID = null,
            string invoiceAccountNumber = null,
            string invoiceAccountShortName = null,
            bool? bestOfIndicator = false,
            bool? isInternational = false,
            int? totalAccounts = null,
            int? totalActiveAccounts = null,
            int? totalCards = null,
            int? totalActiveCards = null,
            int? totalBlockedCards = null,
            int? totalCancelledCards = null,
            int? totalExpiredCards = null,
            int? totalRenewalPendingCards = null,
            int? totalReplacedCards = null,
            int? totalTemporaryBlockCardsByCustomer = null,
            int? totalTemporaryBlockCardsByShell = null,
            int? totalNewCards = null,
            int? totalFraudCards = null,
            int? totalBlockedAccounts = null,
            int? totalCancelledAccounts = null,
            string payerTradingName = null,
            string status = null,
            string billingLanguage = null,
            string legalEntity = null,
            string dateEstablished = null,
            string customerClassification = null,
            string industryClass = null,
            string marketingSegmentation = null,
            string lineOfBusiness = null,
            bool? printCreditLimit = false,
            string cardGroupType = null,
            bool? renewCards = false,
            bool? allowSelectPIN = false,
            bool? useFleetPIN = null,
            string vATRegNumber = null,
            string vATRegNumber2 = null,
            string registrationNumber = null,
            string registrationNumber2 = null,
            double? salesLedgerBalance = null,
            double? exposure = null,
            double? outstandingDebt = null,
            double? availableCredit = null,
            string band = null,
            string globalCustomerReferenceId = null,
            double? creditLimit = null,
            double? creditLimitInCustomerCurrency = null,
            string billingCurrencyCode = null,
            string billingCurrencySymbol = null,
            string paymentMethod = null,
            string paymentTerms = null,
            double? temporaryCreditLimitIncrease = null,
            double? temporaryCreditLimitIncreaseInCustomerCurrency = null,
            string temporaryCreditLimitExpiryDate = null,
            List<Models.BankAccount> payerBankAccount = null,
            Models.Address cardDeliveryAddress = null,
            Models.Address correspondanceAddress = null,
            Models.Address billingAddress = null,
            bool? hasActiveVolBasedPricing = null,
            bool? hasActiveVolBasedBonus = null,
            bool? hasActiveVolBasedAssociationBonus = null,
            Models.FinanceCurrency2 financeCurrency = null,
            string tollsCustomerId = null,
            string tollsColcoCountryTypeId = null,
            List<Models.CustomerContract> contracts = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (countryCode != null)
            {
                this.CountryCode = countryCode;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerFullName != null)
            {
                this.PayerFullName = payerFullName;
            }

            if (payerShortName != null)
            {
                this.PayerShortName = payerShortName;
            }

            if (payerGroupId != null)
            {
                this.PayerGroupId = payerGroupId;
            }

            if (amountDue != null)
            {
                this.AmountDue = amountDue;
            }

            if (amountOverdue != null)
            {
                this.AmountOverdue = amountOverdue;
            }

            if (amountNotOverdue != null)
            {
                this.AmountNotOverdue = amountNotOverdue;
            }

            if (outstandingBalance != null)
            {
                this.OutstandingBalance = outstandingBalance;
            }

            if (unallocatedPayment != null)
            {
                this.UnallocatedPayment = unallocatedPayment;
            }

            if (sOACurrencyCode != null)
            {
                this.SOACurrencyCode = sOACurrencyCode;
            }

            if (sOACurrencySymbol != null)
            {
                this.SOACurrencySymbol = sOACurrencySymbol;
            }

            if (sOACreditLimitCurrencyCode != null)
            {
                this.SOACreditLimitCurrencyCode = sOACreditLimitCurrencyCode;
            }

            if (sOACreditLimitCurrencySymbol != null)
            {
                this.SOACreditLimitCurrencySymbol = sOACreditLimitCurrencySymbol;
            }

            if (lastPaymentCurrencyCode != null)
            {
                this.LastPaymentCurrencyCode = lastPaymentCurrencyCode;
            }

            if (lastPaymentCurrencySymbol != null)
            {
                this.LastPaymentCurrencySymbol = lastPaymentCurrencySymbol;
            }

            if (lastPaymentAmount != null)
            {
                this.LastPaymentAmount = lastPaymentAmount;
            }

            if (lastPaymentDate != null)
            {
                this.LastPaymentDate = lastPaymentDate;
            }

            if (sOALastPaymentAmount != null)
            {
                this.SOALastPaymentAmount = sOALastPaymentAmount;
            }

            if (sOALastPaymentDate != null)
            {
                this.SOALastPaymentDate = sOALastPaymentDate;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
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

            if (localCurrencyExchangeRate != null)
            {
                this.LocalCurrencyExchangeRate = localCurrencyExchangeRate;
            }

            if (localCurrencyExchangeRateSoA != null)
            {
                this.LocalCurrencyExchangeRateSoA = localCurrencyExchangeRateSoA;
            }

            if (billingFrequencyTypeId != null)
            {
                this.BillingFrequencyTypeId = billingFrequencyTypeId;
            }

            if (billingFrequencyType != null)
            {
                this.BillingFrequencyType = billingFrequencyType;
            }

            if (billingRunFrequencyTypeId != null)
            {
                this.BillingRunFrequencyTypeId = billingRunFrequencyTypeId;
            }

            if (billingRunFrequnecy != null)
            {
                this.BillingRunFrequnecy = billingRunFrequnecy;
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

            this.InvoiceDistributionMethods = invoiceDistributionMethods;
            if (outputType != null)
            {
                this.OutputType = outputType;
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

            this.BestOfIndicator = bestOfIndicator;
            this.IsInternational = isInternational;
            if (totalAccounts != null)
            {
                this.TotalAccounts = totalAccounts;
            }

            if (totalActiveAccounts != null)
            {
                this.TotalActiveAccounts = totalActiveAccounts;
            }

            if (totalCards != null)
            {
                this.TotalCards = totalCards;
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

            if (totalExpiredCards != null)
            {
                this.TotalExpiredCards = totalExpiredCards;
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

            if (totalNewCards != null)
            {
                this.TotalNewCards = totalNewCards;
            }

            if (totalFraudCards != null)
            {
                this.TotalFraudCards = totalFraudCards;
            }

            if (totalBlockedAccounts != null)
            {
                this.TotalBlockedAccounts = totalBlockedAccounts;
            }

            if (totalCancelledAccounts != null)
            {
                this.TotalCancelledAccounts = totalCancelledAccounts;
            }

            if (payerTradingName != null)
            {
                this.PayerTradingName = payerTradingName;
            }

            this.Status = status;
            if (billingLanguage != null)
            {
                this.BillingLanguage = billingLanguage;
            }

            if (legalEntity != null)
            {
                this.LegalEntity = legalEntity;
            }

            if (dateEstablished != null)
            {
                this.DateEstablished = dateEstablished;
            }

            if (customerClassification != null)
            {
                this.CustomerClassification = customerClassification;
            }

            if (industryClass != null)
            {
                this.IndustryClass = industryClass;
            }

            if (marketingSegmentation != null)
            {
                this.MarketingSegmentation = marketingSegmentation;
            }

            if (lineOfBusiness != null)
            {
                this.LineOfBusiness = lineOfBusiness;
            }

            this.PrintCreditLimit = printCreditLimit;
            if (cardGroupType != null)
            {
                this.CardGroupType = cardGroupType;
            }

            this.RenewCards = renewCards;
            this.AllowSelectPIN = allowSelectPIN;
            this.UseFleetPIN = useFleetPIN;
            if (vATRegNumber != null)
            {
                this.VATRegNumber = vATRegNumber;
            }

            this.VATRegNumber2 = vATRegNumber2;
            if (registrationNumber != null)
            {
                this.RegistrationNumber = registrationNumber;
            }

            if (registrationNumber2 != null)
            {
                this.RegistrationNumber2 = registrationNumber2;
            }

            if (salesLedgerBalance != null)
            {
                this.SalesLedgerBalance = salesLedgerBalance;
            }

            if (exposure != null)
            {
                this.Exposure = exposure;
            }

            if (outstandingDebt != null)
            {
                this.OutstandingDebt = outstandingDebt;
            }

            if (availableCredit != null)
            {
                this.AvailableCredit = availableCredit;
            }

            if (band != null)
            {
                this.Band = band;
            }

            if (globalCustomerReferenceId != null)
            {
                this.GlobalCustomerReferenceId = globalCustomerReferenceId;
            }

            if (creditLimit != null)
            {
                this.CreditLimit = creditLimit;
            }

            if (creditLimitInCustomerCurrency != null)
            {
                this.CreditLimitInCustomerCurrency = creditLimitInCustomerCurrency;
            }

            if (billingCurrencyCode != null)
            {
                this.BillingCurrencyCode = billingCurrencyCode;
            }

            if (billingCurrencySymbol != null)
            {
                this.BillingCurrencySymbol = billingCurrencySymbol;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (paymentTerms != null)
            {
                this.PaymentTerms = paymentTerms;
            }

            if (temporaryCreditLimitIncrease != null)
            {
                this.TemporaryCreditLimitIncrease = temporaryCreditLimitIncrease;
            }

            if (temporaryCreditLimitIncreaseInCustomerCurrency != null)
            {
                this.TemporaryCreditLimitIncreaseInCustomerCurrency = temporaryCreditLimitIncreaseInCustomerCurrency;
            }

            if (temporaryCreditLimitExpiryDate != null)
            {
                this.TemporaryCreditLimitExpiryDate = temporaryCreditLimitExpiryDate;
            }

            this.PayerBankAccount = payerBankAccount;
            this.CardDeliveryAddress = cardDeliveryAddress;
            this.CorrespondanceAddress = correspondanceAddress;
            this.BillingAddress = billingAddress;
            this.HasActiveVolBasedPricing = hasActiveVolBasedPricing;
            this.HasActiveVolBasedBonus = hasActiveVolBasedBonus;
            this.HasActiveVolBasedAssociationBonus = hasActiveVolBasedAssociationBonus;
            this.FinanceCurrency = financeCurrency;
            if (tollsCustomerId != null)
            {
                this.TollsCustomerId = tollsCustomerId;
            }

            if (tollsColcoCountryTypeId != null)
            {
                this.TollsColcoCountryTypeId = tollsColcoCountryTypeId;
            }

            this.Contracts = contracts;
        }

        /// <summary>
        /// Collecting company id of the customer.
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
        /// Collecting company code of the customer.
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
        /// ISO code of the customer country.
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }

            set
            {
                this.shouldSerialize["CountryCode"] = true;
                this.countryCode = value;
            }
        }

        /// <summary>
        /// Country of the customer
        /// </summary>
        [JsonProperty("Country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["Country"] = true;
                this.country = value;
            }
        }

        /// <summary>
        /// Payer id of the customer
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
        /// Payer Number of the customer
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
        /// Full Name of the Payer
        /// </summary>
        [JsonProperty("PayerFullName")]
        public string PayerFullName
        {
            get
            {
                return this.payerFullName;
            }

            set
            {
                this.shouldSerialize["PayerFullName"] = true;
                this.payerFullName = value;
            }
        }

        /// <summary>
        /// Short name of the payer
        /// </summary>
        [JsonProperty("PayerShortName")]
        public string PayerShortName
        {
            get
            {
                return this.payerShortName;
            }

            set
            {
                this.shouldSerialize["PayerShortName"] = true;
                this.payerShortName = value;
            }
        }

        /// <summary>
        /// Payer Group Id
        /// </summary>
        [JsonProperty("PayerGroupId")]
        public int? PayerGroupId
        {
            get
            {
                return this.payerGroupId;
            }

            set
            {
                this.shouldSerialize["PayerGroupId"] = true;
                this.payerGroupId = value;
            }
        }

        /// <summary>
        /// Invoiced amount and due for payment from the last SOA.
        /// </summary>
        [JsonProperty("AmountDue")]
        public double? AmountDue
        {
            get
            {
                return this.amountDue;
            }

            set
            {
                this.shouldSerialize["AmountDue"] = true;
                this.amountDue = value;
            }
        }

        /// <summary>
        /// Invoiced amount and overdue for payment from the last SOA.
        /// </summary>
        [JsonProperty("AmountOverdue")]
        public double? AmountOverdue
        {
            get
            {
                return this.amountOverdue;
            }

            set
            {
                this.shouldSerialize["AmountOverdue"] = true;
                this.amountOverdue = value;
            }
        }

        /// <summary>
        /// Invoiced amount and not overdue for payment from the last SOA.
        /// </summary>
        [JsonProperty("AmountNotOverdue")]
        public double? AmountNotOverdue
        {
            get
            {
                return this.amountNotOverdue;
            }

            set
            {
                this.shouldSerialize["AmountNotOverdue"] = true;
                this.amountNotOverdue = value;
            }
        }

        /// <summary>
        /// Current outstanding balance amount from the last SOA.
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
        /// Unallocated payment.
        /// When negative, indicates overdue amount from the last SOA.
        /// </summary>
        [JsonProperty("UnallocatedPayment")]
        public double? UnallocatedPayment
        {
            get
            {
                return this.unallocatedPayment;
            }

            set
            {
                this.shouldSerialize["UnallocatedPayment"] = true;
                this.unallocatedPayment = value;
            }
        }

        /// <summary>
        /// Currency ISO code
        /// </summary>
        [JsonProperty("SOACurrencyCode")]
        public string SOACurrencyCode
        {
            get
            {
                return this.sOACurrencyCode;
            }

            set
            {
                this.shouldSerialize["SOACurrencyCode"] = true;
                this.sOACurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol
        /// </summary>
        [JsonProperty("SOACurrencySymbol")]
        public string SOACurrencySymbol
        {
            get
            {
                return this.sOACurrencySymbol;
            }

            set
            {
                this.shouldSerialize["SOACurrencySymbol"] = true;
                this.sOACurrencySymbol = value;
            }
        }

        /// <summary>
        /// Currency ISO code
        /// </summary>
        [JsonProperty("SOACreditLimitCurrencyCode")]
        public string SOACreditLimitCurrencyCode
        {
            get
            {
                return this.sOACreditLimitCurrencyCode;
            }

            set
            {
                this.shouldSerialize["SOACreditLimitCurrencyCode"] = true;
                this.sOACreditLimitCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol
        /// </summary>
        [JsonProperty("SOACreditLimitCurrencySymbol")]
        public string SOACreditLimitCurrencySymbol
        {
            get
            {
                return this.sOACreditLimitCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["SOACreditLimitCurrencySymbol"] = true;
                this.sOACreditLimitCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Currency ISO code
        /// </summary>
        [JsonProperty("LastPaymentCurrencyCode")]
        public string LastPaymentCurrencyCode
        {
            get
            {
                return this.lastPaymentCurrencyCode;
            }

            set
            {
                this.shouldSerialize["LastPaymentCurrencyCode"] = true;
                this.lastPaymentCurrencyCode = value;
            }
        }

        /// <summary>
        /// currency symbol
        /// </summary>
        [JsonProperty("LastPaymentCurrencySymbol")]
        public string LastPaymentCurrencySymbol
        {
            get
            {
                return this.lastPaymentCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["LastPaymentCurrencySymbol"] = true;
                this.lastPaymentCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Latest payment amount for the requested payer.
        /// </summary>
        [JsonProperty("LastPaymentAmount")]
        public double? LastPaymentAmount
        {
            get
            {
                return this.lastPaymentAmount;
            }

            set
            {
                this.shouldSerialize["LastPaymentAmount"] = true;
                this.lastPaymentAmount = value;
            }
        }

        /// <summary>
        /// Latest payment date for the requested payer.
        /// </summary>
        [JsonProperty("LastPaymentDate")]
        public string LastPaymentDate
        {
            get
            {
                return this.lastPaymentDate;
            }

            set
            {
                this.shouldSerialize["LastPaymentDate"] = true;
                this.lastPaymentDate = value;
            }
        }

        /// <summary>
        /// Last payment amount in statement of account for the requested payer.
        /// </summary>
        [JsonProperty("SOALastPaymentAmount")]
        public double? SOALastPaymentAmount
        {
            get
            {
                return this.sOALastPaymentAmount;
            }

            set
            {
                this.shouldSerialize["SOALastPaymentAmount"] = true;
                this.sOALastPaymentAmount = value;
            }
        }

        /// <summary>
        /// Last payment date in statement of account for the requested payer.
        /// </summary>
        [JsonProperty("SOALastPaymentDate")]
        public string SOALastPaymentDate
        {
            get
            {
                return this.sOALastPaymentDate;
            }

            set
            {
                this.shouldSerialize["SOALastPaymentDate"] = true;
                this.sOALastPaymentDate = value;
            }
        }

        /// <summary>
        /// Currency ISO code
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
        /// Currency Symbol
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
        /// Currency ISO code of the local country.
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
        /// Currency Symbol of the local country
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
        /// Exchange rate from OU base currency to local currency.
        /// </summary>
        [JsonProperty("LocalCurrencyExchangeRate")]
        public double? LocalCurrencyExchangeRate
        {
            get
            {
                return this.localCurrencyExchangeRate;
            }

            set
            {
                this.shouldSerialize["LocalCurrencyExchangeRate"] = true;
                this.localCurrencyExchangeRate = value;
            }
        }

        /// <summary>
        /// Exchange rate from SoA credit limit currency to local currency
        /// </summary>
        [JsonProperty("LocalCurrencyExchangeRate_SoA")]
        public double? LocalCurrencyExchangeRateSoA
        {
            get
            {
                return this.localCurrencyExchangeRateSoA;
            }

            set
            {
                this.shouldSerialize["LocalCurrencyExchangeRate_SoA"] = true;
                this.localCurrencyExchangeRateSoA = value;
            }
        }

        /// <summary>
        /// Billing/Invoice frequency Identifier. Indicates the frequency in which the transactions will be considered for invoicing in a bulling run
        /// E.g.: 1, 2, 3, etc.
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
        /// Frequency at which the billing process is triggered.E.g.:
        /// 1	Daily (all days)
        /// 2	Daily (only working days)
        /// 3	Weekly - Monday
        /// 4	Weekly – Tuesday
        /// Etc.
        /// </summary>
        [JsonProperty("BillingRunFrequnecy")]
        public string BillingRunFrequnecy
        {
            get
            {
                return this.billingRunFrequnecy;
            }

            set
            {
                this.shouldSerialize["BillingRunFrequnecy"] = true;
                this.billingRunFrequnecy = value;
            }
        }

        /// <summary>
        /// The first day in a month when the billing should run in case of multiple billing runs configured with in a single month.
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
        /// The second day in a month when the billing should run in case of multiple billing runs configured with in a single month.
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
        /// The third day in a month when the billing should run in case of multiple billing runs configured with in a single month.
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
        /// The fourth day in a month when the billing should run in case of multiple billing runs configured with in a single month.
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
        /// Gets or sets InvoiceDistributionMethods.
        /// </summary>
        [JsonProperty("InvoiceDistributionMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceDistributionMethod> InvoiceDistributionMethods { get; set; }

        /// <summary>
        /// Invoice output type (Id-Description)
        /// E.g.:
        /// 1-PDF
        /// 6-Print
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType
        {
            get
            {
                return this.outputType;
            }

            set
            {
                this.shouldSerialize["OutputType"] = true;
                this.outputType = value;
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
        /// Best of Indicator of the Pricing customer/account configured.
        /// </summary>
        [JsonProperty("BestOfIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BestOfIndicator { get; set; }

        /// <summary>
        /// Whether the account is international.
        /// </summary>
        [JsonProperty("IsInternational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; }

        /// <summary>
        /// Total number of accounts under the payer.
        /// </summary>
        [JsonProperty("TotalAccounts")]
        public int? TotalAccounts
        {
            get
            {
                return this.totalAccounts;
            }

            set
            {
                this.shouldSerialize["TotalAccounts"] = true;
                this.totalAccounts = value;
            }
        }

        /// <summary>
        /// Total number of active accounts under the payer.
        /// </summary>
        [JsonProperty("TotalActiveAccounts")]
        public int? TotalActiveAccounts
        {
            get
            {
                return this.totalActiveAccounts;
            }

            set
            {
                this.shouldSerialize["TotalActiveAccounts"] = true;
                this.totalActiveAccounts = value;
            }
        }

        /// <summary>
        /// Total number of cards under the payer.
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
        /// Total number of active cards under the payer.
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
        /// Total number of cards under the payer that are permanently blocked
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
        /// Total number of cards under the payer that are cancelled
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
        /// Total number of expired cards under the payer.
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
        /// Total number of Renewal Pending cards under the payer.
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
        /// Total number of cards under the payer with status as “Replaced
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
        /// Total number of cards under the payer that are temporarily blocked by customer.
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
        /// Total number of cards under the payer that are temporarily blocked by Shell.
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
        /// Total number of cards in “New” status
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
        /// Total number of cards in Fraud status
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
        /// Total number of accounts in Blocked status
        /// </summary>
        [JsonProperty("TotalBlockedAccounts")]
        public int? TotalBlockedAccounts
        {
            get
            {
                return this.totalBlockedAccounts;
            }

            set
            {
                this.shouldSerialize["TotalBlockedAccounts"] = true;
                this.totalBlockedAccounts = value;
            }
        }

        /// <summary>
        /// Total number of accounts in Cancel status
        /// </summary>
        [JsonProperty("TotalCancelledAccounts")]
        public int? TotalCancelledAccounts
        {
            get
            {
                return this.totalCancelledAccounts;
            }

            set
            {
                this.shouldSerialize["TotalCancelledAccounts"] = true;
                this.totalCancelledAccounts = value;
            }
        }

        /// <summary>
        /// Trading name for the Payer
        /// </summary>
        [JsonProperty("PayerTradingName")]
        public string PayerTradingName
        {
            get
            {
                return this.payerTradingName;
            }

            set
            {
                this.shouldSerialize["PayerTradingName"] = true;
                this.payerTradingName = value;
            }
        }

        /// <summary>
        /// Payer current status id and description
        /// e.g. (Id – Description):
        /// 1-Active
        /// 2-Requested from UTA
        /// 3-Awaiting embossing
        /// 4-Manufactured
        /// 5-Awaiting despatch
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Payer Billing Language id and description
        /// </summary>
        [JsonProperty("BillingLanguage")]
        public string BillingLanguage
        {
            get
            {
                return this.billingLanguage;
            }

            set
            {
                this.shouldSerialize["BillingLanguage"] = true;
                this.billingLanguage = value;
            }
        }

        /// <summary>
        /// Legal entity id and description of the Payer
        /// </summary>
        [JsonProperty("LegalEntity")]
        public string LegalEntity
        {
            get
            {
                return this.legalEntity;
            }

            set
            {
                this.shouldSerialize["LegalEntity"] = true;
                this.legalEntity = value;
            }
        }

        /// <summary>
        /// Payer/Company Established Date.
        /// </summary>
        [JsonProperty("DateEstablished")]
        public string DateEstablished
        {
            get
            {
                return this.dateEstablished;
            }

            set
            {
                this.shouldSerialize["DateEstablished"] = true;
                this.dateEstablished = value;
            }
        }

        /// <summary>
        /// Payer/Company Classification id and description
        /// </summary>
        [JsonProperty("CustomerClassification")]
        public string CustomerClassification
        {
            get
            {
                return this.customerClassification;
            }

            set
            {
                this.shouldSerialize["CustomerClassification"] = true;
                this.customerClassification = value;
            }
        }

        /// <summary>
        /// Payer/Company Industry class id and description
        /// </summary>
        [JsonProperty("IndustryClass")]
        public string IndustryClass
        {
            get
            {
                return this.industryClass;
            }

            set
            {
                this.shouldSerialize["IndustryClass"] = true;
                this.industryClass = value;
            }
        }

        /// <summary>
        /// Marketing Segmentation id and description
        /// </summary>
        [JsonProperty("MarketingSegmentation")]
        public string MarketingSegmentation
        {
            get
            {
                return this.marketingSegmentation;
            }

            set
            {
                this.shouldSerialize["MarketingSegmentation"] = true;
                this.marketingSegmentation = value;
            }
        }

        /// <summary>
        /// Payer/Company Line of Business Id and Description
        /// </summary>
        [JsonProperty("LineOfBusiness")]
        public string LineOfBusiness
        {
            get
            {
                return this.lineOfBusiness;
            }

            set
            {
                this.shouldSerialize["LineOfBusiness"] = true;
                this.lineOfBusiness = value;
            }
        }

        /// <summary>
        /// Is Credit Limit printed on the statement of account: True/False
        /// If True Credit Limit is printed on invoice/SOA
        /// </summary>
        [JsonProperty("PrintCreditLimit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintCreditLimit { get; set; }

        /// <summary>
        /// Card Group Type configured for Payer
        /// e.g. (Id – Description):
        /// 1-Horizontal only
        /// 2-Vertical only
        /// 3-Both
        /// </summary>
        [JsonProperty("CardGroupType")]
        public string CardGroupType
        {
            get
            {
                return this.cardGroupType;
            }

            set
            {
                this.shouldSerialize["CardGroupType"] = true;
                this.cardGroupType = value;
            }
        }

        /// <summary>
        /// If set to True cards will be automatically renewed on expiry
        /// </summary>
        [JsonProperty("RenewCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenewCards { get; set; }

        /// <summary>
        /// If set to True then Self Select PIN is allowed for Payer
        /// </summary>
        [JsonProperty("AllowSelectPIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSelectPIN { get; set; }

        /// <summary>
        /// If set to True then Fleet PIN is applied for the cards directly under payer
        /// </summary>
        [JsonProperty("UseFleetPIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseFleetPIN { get; set; }

        /// <summary>
        /// Payer/Company VAT registration number.
        /// </summary>
        [JsonProperty("VATRegNumber")]
        public string VATRegNumber
        {
            get
            {
                return this.vATRegNumber;
            }

            set
            {
                this.shouldSerialize["VATRegNumber"] = true;
                this.vATRegNumber = value;
            }
        }

        /// <summary>
        /// Payer/Company VAT registration number 2.
        /// </summary>
        [JsonProperty("VATRegNumber2", NullValueHandling = NullValueHandling.Ignore)]
        public string VATRegNumber2 { get; set; }

        /// <summary>
        /// Payer/Company Registration number
        /// </summary>
        [JsonProperty("RegistrationNumber")]
        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                this.shouldSerialize["RegistrationNumber"] = true;
                this.registrationNumber = value;
            }
        }

        /// <summary>
        /// Payer/Company Registration number2
        /// </summary>
        [JsonProperty("RegistrationNumber2")]
        public string RegistrationNumber2
        {
            get
            {
                return this.registrationNumber2;
            }

            set
            {
                this.shouldSerialize["RegistrationNumber2"] = true;
                this.registrationNumber2 = value;
            }
        }

        /// <summary>
        /// Sales Ledger Balance (Billed)
        /// </summary>
        [JsonProperty("SalesLedgerBalance")]
        public double? SalesLedgerBalance
        {
            get
            {
                return this.salesLedgerBalance;
            }

            set
            {
                this.shouldSerialize["SalesLedgerBalance"] = true;
                this.salesLedgerBalance = value;
            }
        }

        /// <summary>
        /// Exposure after guarantee
        /// </summary>
        [JsonProperty("Exposure")]
        public double? Exposure
        {
            get
            {
                return this.exposure;
            }

            set
            {
                this.shouldSerialize["Exposure"] = true;
                this.exposure = value;
            }
        }

        /// <summary>
        /// Total outstanding debt (including billed and unbilled sales and fee items)
        /// </summary>
        [JsonProperty("OutstandingDebt")]
        public double? OutstandingDebt
        {
            get
            {
                return this.outstandingDebt;
            }

            set
            {
                this.shouldSerialize["OutstandingDebt"] = true;
                this.outstandingDebt = value;
            }
        }

        /// <summary>
        /// The available credit for the payer.
        /// This is the credit limit minus the outstanding debt.
        /// </summary>
        [JsonProperty("AvailableCredit")]
        public double? AvailableCredit
        {
            get
            {
                return this.availableCredit;
            }

            set
            {
                this.shouldSerialize["AvailableCredit"] = true;
                this.availableCredit = value;
            }
        }

        /// <summary>
        /// Band Id and Description of the Payer in Card Platform.
        /// e.g. (Id – Description):
        /// 1-Platinum
        /// 2-Gold
        /// 3-Silver
        /// 4-Bronze
        /// </summary>
        [JsonProperty("Band")]
        public string Band
        {
            get
            {
                return this.band;
            }

            set
            {
                this.shouldSerialize["Band"] = true;
                this.band = value;
            }
        }

        /// <summary>
        /// Global Customer reference id configured in card platform for Payer (Same as Payer Group)
        /// </summary>
        [JsonProperty("GlobalCustomerReferenceId")]
        public string GlobalCustomerReferenceId
        {
            get
            {
                return this.globalCustomerReferenceId;
            }

            set
            {
                this.shouldSerialize["GlobalCustomerReferenceId"] = true;
                this.globalCustomerReferenceId = value;
            }
        }

        /// <summary>
        /// Payment Credit limit of Payer.
        /// </summary>
        [JsonProperty("CreditLimit")]
        public double? CreditLimit
        {
            get
            {
                return this.creditLimit;
            }

            set
            {
                this.shouldSerialize["CreditLimit"] = true;
                this.creditLimit = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Credit limit in Customer currency.
        /// Note: For currency details refer the parameters CurrencyCode & CurrencySymbol in the PayerDetail response.
        /// ]]>
        /// </summary>
        [JsonProperty("CreditLimitInCustomerCurrency")]
        public double? CreditLimitInCustomerCurrency
        {
            get
            {
                return this.creditLimitInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["CreditLimitInCustomerCurrency"] = true;
                this.creditLimitInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Customer Billing currency ISO code.
        /// </summary>
        [JsonProperty("BillingCurrencyCode")]
        public string BillingCurrencyCode
        {
            get
            {
                return this.billingCurrencyCode;
            }

            set
            {
                this.shouldSerialize["BillingCurrencyCode"] = true;
                this.billingCurrencyCode = value;
            }
        }

        /// <summary>
        /// Customer Billing currency Symbol.
        /// </summary>
        [JsonProperty("BillingCurrencySymbol")]
        public string BillingCurrencySymbol
        {
            get
            {
                return this.billingCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["BillingCurrencySymbol"] = true;
                this.billingCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Payment method Id and Description as configured for Payer in Card Platform
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod
        {
            get
            {
                return this.paymentMethod;
            }

            set
            {
                this.shouldSerialize["PaymentMethod"] = true;
                this.paymentMethod = value;
            }
        }

        /// <summary>
        /// Payment terms Id and Description as configured for Payer in Card Platform
        /// </summary>
        [JsonProperty("PaymentTerms")]
        public string PaymentTerms
        {
            get
            {
                return this.paymentTerms;
            }

            set
            {
                this.shouldSerialize["PaymentTerms"] = true;
                this.paymentTerms = value;
            }
        }

        /// <summary>
        /// Temporary Credit limit increase value
        /// </summary>
        [JsonProperty("TemporaryCreditLimitIncrease")]
        public double? TemporaryCreditLimitIncrease
        {
            get
            {
                return this.temporaryCreditLimitIncrease;
            }

            set
            {
                this.shouldSerialize["TemporaryCreditLimitIncrease"] = true;
                this.temporaryCreditLimitIncrease = value;
            }
        }

        /// <summary>
        /// Temporary Credit limit increase value
        /// </summary>
        [JsonProperty("TemporaryCreditLimitIncreaseInCustomerCurrency")]
        public double? TemporaryCreditLimitIncreaseInCustomerCurrency
        {
            get
            {
                return this.temporaryCreditLimitIncreaseInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["TemporaryCreditLimitIncreaseInCustomerCurrency"] = true;
                this.temporaryCreditLimitIncreaseInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Temporary Credit limit expiry date
        /// </summary>
        [JsonProperty("TemporaryCreditLimitExpiryDate")]
        public string TemporaryCreditLimitExpiryDate
        {
            get
            {
                return this.temporaryCreditLimitExpiryDate;
            }

            set
            {
                this.shouldSerialize["TemporaryCreditLimitExpiryDate"] = true;
                this.temporaryCreditLimitExpiryDate = value;
            }
        }

        /// <summary>
        /// Gets or sets PayerBankAccount.
        /// </summary>
        [JsonProperty("PayerBankAccount", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccount> PayerBankAccount { get; set; }

        /// <summary>
        /// Gets or sets CardDeliveryAddress.
        /// </summary>
        [JsonProperty("CardDeliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address CardDeliveryAddress { get; set; }

        /// <summary>
        /// Gets or sets CorrespondanceAddress.
        /// </summary>
        [JsonProperty("CorrespondanceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address CorrespondanceAddress { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("BillingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// True, if the payer is setup for volume-based pricing and is active on the current date, else false.
        /// This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null.
        /// </summary>
        [JsonProperty("HasActiveVolBasedPricing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasActiveVolBasedPricing { get; set; }

        /// <summary>
        /// True, if the payer is setup for volume-based bonus and is active on the current date, else false.
        /// This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null.
        /// </summary>
        [JsonProperty("HasActiveVolBasedBonus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasActiveVolBasedBonus { get; set; }

        /// <summary>
        /// True, if the payer is setup for volume-based association bonus and is active on the current date, else false.
        /// This field is returned only when IncludeBonusParameters is set to True in the request. Else set to null.
        /// </summary>
        [JsonProperty("HasActiveVolBasedAssociationBonus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasActiveVolBasedAssociationBonus { get; set; }

        /// <summary>
        /// Gets or sets FinanceCurrency.
        /// </summary>
        [JsonProperty("FinanceCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FinanceCurrency2 FinanceCurrency { get; set; }

        /// <summary>
        /// Customer id in e-TM system
        /// This field will have value only when ReturnTollsCustomerId is set to true in the request else set to null or empty.
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
        /// String	Colco country type id in e-TM system
        /// This field will have value only when ReturnTollsCustomerId is set to true in the request else set to null or empty.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayerDetails : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryCode()
        {
            this.shouldSerialize["CountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
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
        public void UnsetPayerFullName()
        {
            this.shouldSerialize["PayerFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerShortName()
        {
            this.shouldSerialize["PayerShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerGroupId()
        {
            this.shouldSerialize["PayerGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountDue()
        {
            this.shouldSerialize["AmountDue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountOverdue()
        {
            this.shouldSerialize["AmountOverdue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountNotOverdue()
        {
            this.shouldSerialize["AmountNotOverdue"] = false;
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
        public void UnsetUnallocatedPayment()
        {
            this.shouldSerialize["UnallocatedPayment"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOACurrencyCode()
        {
            this.shouldSerialize["SOACurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOACurrencySymbol()
        {
            this.shouldSerialize["SOACurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOACreditLimitCurrencyCode()
        {
            this.shouldSerialize["SOACreditLimitCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOACreditLimitCurrencySymbol()
        {
            this.shouldSerialize["SOACreditLimitCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentCurrencyCode()
        {
            this.shouldSerialize["LastPaymentCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentCurrencySymbol()
        {
            this.shouldSerialize["LastPaymentCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentAmount()
        {
            this.shouldSerialize["LastPaymentAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentDate()
        {
            this.shouldSerialize["LastPaymentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOALastPaymentAmount()
        {
            this.shouldSerialize["SOALastPaymentAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSOALastPaymentDate()
        {
            this.shouldSerialize["SOALastPaymentDate"] = false;
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
        public void UnsetLocalCurrencyExchangeRate()
        {
            this.shouldSerialize["LocalCurrencyExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalCurrencyExchangeRateSoA()
        {
            this.shouldSerialize["LocalCurrencyExchangeRate_SoA"] = false;
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
        public void UnsetBillingFrequencyType()
        {
            this.shouldSerialize["BillingFrequencyType"] = false;
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
        public void UnsetBillingRunFrequnecy()
        {
            this.shouldSerialize["BillingRunFrequnecy"] = false;
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
        public void UnsetOutputType()
        {
            this.shouldSerialize["OutputType"] = false;
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
        public void UnsetTotalAccounts()
        {
            this.shouldSerialize["TotalAccounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalActiveAccounts()
        {
            this.shouldSerialize["TotalActiveAccounts"] = false;
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
        public void UnsetTotalExpiredCards()
        {
            this.shouldSerialize["TotalExpiredCards"] = false;
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
        public void UnsetTotalNewCards()
        {
            this.shouldSerialize["TotalNewCards"] = false;
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
        public void UnsetTotalBlockedAccounts()
        {
            this.shouldSerialize["TotalBlockedAccounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalCancelledAccounts()
        {
            this.shouldSerialize["TotalCancelledAccounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerTradingName()
        {
            this.shouldSerialize["PayerTradingName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingLanguage()
        {
            this.shouldSerialize["BillingLanguage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLegalEntity()
        {
            this.shouldSerialize["LegalEntity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateEstablished()
        {
            this.shouldSerialize["DateEstablished"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerClassification()
        {
            this.shouldSerialize["CustomerClassification"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIndustryClass()
        {
            this.shouldSerialize["IndustryClass"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMarketingSegmentation()
        {
            this.shouldSerialize["MarketingSegmentation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLineOfBusiness()
        {
            this.shouldSerialize["LineOfBusiness"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupType()
        {
            this.shouldSerialize["CardGroupType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATRegNumber()
        {
            this.shouldSerialize["VATRegNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegistrationNumber()
        {
            this.shouldSerialize["RegistrationNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegistrationNumber2()
        {
            this.shouldSerialize["RegistrationNumber2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSalesLedgerBalance()
        {
            this.shouldSerialize["SalesLedgerBalance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExposure()
        {
            this.shouldSerialize["Exposure"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOutstandingDebt()
        {
            this.shouldSerialize["OutstandingDebt"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAvailableCredit()
        {
            this.shouldSerialize["AvailableCredit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBand()
        {
            this.shouldSerialize["Band"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGlobalCustomerReferenceId()
        {
            this.shouldSerialize["GlobalCustomerReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimit()
        {
            this.shouldSerialize["CreditLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimitInCustomerCurrency()
        {
            this.shouldSerialize["CreditLimitInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCurrencyCode()
        {
            this.shouldSerialize["BillingCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCurrencySymbol()
        {
            this.shouldSerialize["BillingCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["PaymentMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentTerms()
        {
            this.shouldSerialize["PaymentTerms"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTemporaryCreditLimitIncrease()
        {
            this.shouldSerialize["TemporaryCreditLimitIncrease"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTemporaryCreditLimitIncreaseInCustomerCurrency()
        {
            this.shouldSerialize["TemporaryCreditLimitIncreaseInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTemporaryCreditLimitExpiryDate()
        {
            this.shouldSerialize["TemporaryCreditLimitExpiryDate"] = false;
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryCode()
        {
            return this.shouldSerialize["CountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["Country"];
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
        public bool ShouldSerializePayerFullName()
        {
            return this.shouldSerialize["PayerFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerShortName()
        {
            return this.shouldSerialize["PayerShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerGroupId()
        {
            return this.shouldSerialize["PayerGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountDue()
        {
            return this.shouldSerialize["AmountDue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountOverdue()
        {
            return this.shouldSerialize["AmountOverdue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountNotOverdue()
        {
            return this.shouldSerialize["AmountNotOverdue"];
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
        public bool ShouldSerializeUnallocatedPayment()
        {
            return this.shouldSerialize["UnallocatedPayment"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOACurrencyCode()
        {
            return this.shouldSerialize["SOACurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOACurrencySymbol()
        {
            return this.shouldSerialize["SOACurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOACreditLimitCurrencyCode()
        {
            return this.shouldSerialize["SOACreditLimitCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOACreditLimitCurrencySymbol()
        {
            return this.shouldSerialize["SOACreditLimitCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentCurrencyCode()
        {
            return this.shouldSerialize["LastPaymentCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentCurrencySymbol()
        {
            return this.shouldSerialize["LastPaymentCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentAmount()
        {
            return this.shouldSerialize["LastPaymentAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentDate()
        {
            return this.shouldSerialize["LastPaymentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOALastPaymentAmount()
        {
            return this.shouldSerialize["SOALastPaymentAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSOALastPaymentDate()
        {
            return this.shouldSerialize["SOALastPaymentDate"];
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
        public bool ShouldSerializeLocalCurrencyExchangeRate()
        {
            return this.shouldSerialize["LocalCurrencyExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalCurrencyExchangeRateSoA()
        {
            return this.shouldSerialize["LocalCurrencyExchangeRate_SoA"];
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
        public bool ShouldSerializeBillingFrequencyType()
        {
            return this.shouldSerialize["BillingFrequencyType"];
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
        public bool ShouldSerializeBillingRunFrequnecy()
        {
            return this.shouldSerialize["BillingRunFrequnecy"];
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
        public bool ShouldSerializeOutputType()
        {
            return this.shouldSerialize["OutputType"];
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
        public bool ShouldSerializeTotalAccounts()
        {
            return this.shouldSerialize["TotalAccounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalActiveAccounts()
        {
            return this.shouldSerialize["TotalActiveAccounts"];
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
        public bool ShouldSerializeTotalExpiredCards()
        {
            return this.shouldSerialize["TotalExpiredCards"];
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
        public bool ShouldSerializeTotalNewCards()
        {
            return this.shouldSerialize["TotalNewCards"];
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
        public bool ShouldSerializeTotalBlockedAccounts()
        {
            return this.shouldSerialize["TotalBlockedAccounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCancelledAccounts()
        {
            return this.shouldSerialize["TotalCancelledAccounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerTradingName()
        {
            return this.shouldSerialize["PayerTradingName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingLanguage()
        {
            return this.shouldSerialize["BillingLanguage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLegalEntity()
        {
            return this.shouldSerialize["LegalEntity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateEstablished()
        {
            return this.shouldSerialize["DateEstablished"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerClassification()
        {
            return this.shouldSerialize["CustomerClassification"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIndustryClass()
        {
            return this.shouldSerialize["IndustryClass"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMarketingSegmentation()
        {
            return this.shouldSerialize["MarketingSegmentation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLineOfBusiness()
        {
            return this.shouldSerialize["LineOfBusiness"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupType()
        {
            return this.shouldSerialize["CardGroupType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATRegNumber()
        {
            return this.shouldSerialize["VATRegNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegistrationNumber()
        {
            return this.shouldSerialize["RegistrationNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegistrationNumber2()
        {
            return this.shouldSerialize["RegistrationNumber2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSalesLedgerBalance()
        {
            return this.shouldSerialize["SalesLedgerBalance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExposure()
        {
            return this.shouldSerialize["Exposure"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOutstandingDebt()
        {
            return this.shouldSerialize["OutstandingDebt"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAvailableCredit()
        {
            return this.shouldSerialize["AvailableCredit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBand()
        {
            return this.shouldSerialize["Band"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGlobalCustomerReferenceId()
        {
            return this.shouldSerialize["GlobalCustomerReferenceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimit()
        {
            return this.shouldSerialize["CreditLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimitInCustomerCurrency()
        {
            return this.shouldSerialize["CreditLimitInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCurrencyCode()
        {
            return this.shouldSerialize["BillingCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCurrencySymbol()
        {
            return this.shouldSerialize["BillingCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["PaymentMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentTerms()
        {
            return this.shouldSerialize["PaymentTerms"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryCreditLimitIncrease()
        {
            return this.shouldSerialize["TemporaryCreditLimitIncrease"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryCreditLimitIncreaseInCustomerCurrency()
        {
            return this.shouldSerialize["TemporaryCreditLimitIncreaseInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryCreditLimitExpiryDate()
        {
            return this.shouldSerialize["TemporaryCreditLimitExpiryDate"];
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
            return obj is PayerDetails other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerFullName == null && other.PayerFullName == null) || (this.PayerFullName?.Equals(other.PayerFullName) == true)) &&
                ((this.PayerShortName == null && other.PayerShortName == null) || (this.PayerShortName?.Equals(other.PayerShortName) == true)) &&
                ((this.PayerGroupId == null && other.PayerGroupId == null) || (this.PayerGroupId?.Equals(other.PayerGroupId) == true)) &&
                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                ((this.AmountOverdue == null && other.AmountOverdue == null) || (this.AmountOverdue?.Equals(other.AmountOverdue) == true)) &&
                ((this.AmountNotOverdue == null && other.AmountNotOverdue == null) || (this.AmountNotOverdue?.Equals(other.AmountNotOverdue) == true)) &&
                ((this.OutstandingBalance == null && other.OutstandingBalance == null) || (this.OutstandingBalance?.Equals(other.OutstandingBalance) == true)) &&
                ((this.UnallocatedPayment == null && other.UnallocatedPayment == null) || (this.UnallocatedPayment?.Equals(other.UnallocatedPayment) == true)) &&
                ((this.SOACurrencyCode == null && other.SOACurrencyCode == null) || (this.SOACurrencyCode?.Equals(other.SOACurrencyCode) == true)) &&
                ((this.SOACurrencySymbol == null && other.SOACurrencySymbol == null) || (this.SOACurrencySymbol?.Equals(other.SOACurrencySymbol) == true)) &&
                ((this.SOACreditLimitCurrencyCode == null && other.SOACreditLimitCurrencyCode == null) || (this.SOACreditLimitCurrencyCode?.Equals(other.SOACreditLimitCurrencyCode) == true)) &&
                ((this.SOACreditLimitCurrencySymbol == null && other.SOACreditLimitCurrencySymbol == null) || (this.SOACreditLimitCurrencySymbol?.Equals(other.SOACreditLimitCurrencySymbol) == true)) &&
                ((this.LastPaymentCurrencyCode == null && other.LastPaymentCurrencyCode == null) || (this.LastPaymentCurrencyCode?.Equals(other.LastPaymentCurrencyCode) == true)) &&
                ((this.LastPaymentCurrencySymbol == null && other.LastPaymentCurrencySymbol == null) || (this.LastPaymentCurrencySymbol?.Equals(other.LastPaymentCurrencySymbol) == true)) &&
                ((this.LastPaymentAmount == null && other.LastPaymentAmount == null) || (this.LastPaymentAmount?.Equals(other.LastPaymentAmount) == true)) &&
                ((this.LastPaymentDate == null && other.LastPaymentDate == null) || (this.LastPaymentDate?.Equals(other.LastPaymentDate) == true)) &&
                ((this.SOALastPaymentAmount == null && other.SOALastPaymentAmount == null) || (this.SOALastPaymentAmount?.Equals(other.SOALastPaymentAmount) == true)) &&
                ((this.SOALastPaymentDate == null && other.SOALastPaymentDate == null) || (this.SOALastPaymentDate?.Equals(other.SOALastPaymentDate) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.LocalCurrencyCode == null && other.LocalCurrencyCode == null) || (this.LocalCurrencyCode?.Equals(other.LocalCurrencyCode) == true)) &&
                ((this.LocalCurrencySymbol == null && other.LocalCurrencySymbol == null) || (this.LocalCurrencySymbol?.Equals(other.LocalCurrencySymbol) == true)) &&
                ((this.LocalCurrencyExchangeRate == null && other.LocalCurrencyExchangeRate == null) || (this.LocalCurrencyExchangeRate?.Equals(other.LocalCurrencyExchangeRate) == true)) &&
                ((this.LocalCurrencyExchangeRateSoA == null && other.LocalCurrencyExchangeRateSoA == null) || (this.LocalCurrencyExchangeRateSoA?.Equals(other.LocalCurrencyExchangeRateSoA) == true)) &&
                ((this.BillingFrequencyTypeId == null && other.BillingFrequencyTypeId == null) || (this.BillingFrequencyTypeId?.Equals(other.BillingFrequencyTypeId) == true)) &&
                ((this.BillingFrequencyType == null && other.BillingFrequencyType == null) || (this.BillingFrequencyType?.Equals(other.BillingFrequencyType) == true)) &&
                ((this.BillingRunFrequencyTypeId == null && other.BillingRunFrequencyTypeId == null) || (this.BillingRunFrequencyTypeId?.Equals(other.BillingRunFrequencyTypeId) == true)) &&
                ((this.BillingRunFrequnecy == null && other.BillingRunFrequnecy == null) || (this.BillingRunFrequnecy?.Equals(other.BillingRunFrequnecy) == true)) &&
                ((this.Day1Run == null && other.Day1Run == null) || (this.Day1Run?.Equals(other.Day1Run) == true)) &&
                ((this.Day2Run == null && other.Day2Run == null) || (this.Day2Run?.Equals(other.Day2Run) == true)) &&
                ((this.Day3Run == null && other.Day3Run == null) || (this.Day3Run?.Equals(other.Day3Run) == true)) &&
                ((this.Day4Run == null && other.Day4Run == null) || (this.Day4Run?.Equals(other.Day4Run) == true)) &&
                ((this.InvoiceDistributionMethods == null && other.InvoiceDistributionMethods == null) || (this.InvoiceDistributionMethods?.Equals(other.InvoiceDistributionMethods) == true)) &&
                ((this.OutputType == null && other.OutputType == null) || (this.OutputType?.Equals(other.OutputType) == true)) &&
                ((this.InvoiceAccountID == null && other.InvoiceAccountID == null) || (this.InvoiceAccountID?.Equals(other.InvoiceAccountID) == true)) &&
                ((this.InvoiceAccountNumber == null && other.InvoiceAccountNumber == null) || (this.InvoiceAccountNumber?.Equals(other.InvoiceAccountNumber) == true)) &&
                ((this.InvoiceAccountShortName == null && other.InvoiceAccountShortName == null) || (this.InvoiceAccountShortName?.Equals(other.InvoiceAccountShortName) == true)) &&
                ((this.BestOfIndicator == null && other.BestOfIndicator == null) || (this.BestOfIndicator?.Equals(other.BestOfIndicator) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.TotalAccounts == null && other.TotalAccounts == null) || (this.TotalAccounts?.Equals(other.TotalAccounts) == true)) &&
                ((this.TotalActiveAccounts == null && other.TotalActiveAccounts == null) || (this.TotalActiveAccounts?.Equals(other.TotalActiveAccounts) == true)) &&
                ((this.TotalCards == null && other.TotalCards == null) || (this.TotalCards?.Equals(other.TotalCards) == true)) &&
                ((this.TotalActiveCards == null && other.TotalActiveCards == null) || (this.TotalActiveCards?.Equals(other.TotalActiveCards) == true)) &&
                ((this.TotalBlockedCards == null && other.TotalBlockedCards == null) || (this.TotalBlockedCards?.Equals(other.TotalBlockedCards) == true)) &&
                ((this.TotalCancelledCards == null && other.TotalCancelledCards == null) || (this.TotalCancelledCards?.Equals(other.TotalCancelledCards) == true)) &&
                ((this.TotalExpiredCards == null && other.TotalExpiredCards == null) || (this.TotalExpiredCards?.Equals(other.TotalExpiredCards) == true)) &&
                ((this.TotalRenewalPendingCards == null && other.TotalRenewalPendingCards == null) || (this.TotalRenewalPendingCards?.Equals(other.TotalRenewalPendingCards) == true)) &&
                ((this.TotalReplacedCards == null && other.TotalReplacedCards == null) || (this.TotalReplacedCards?.Equals(other.TotalReplacedCards) == true)) &&
                ((this.TotalTemporaryBlockCardsByCustomer == null && other.TotalTemporaryBlockCardsByCustomer == null) || (this.TotalTemporaryBlockCardsByCustomer?.Equals(other.TotalTemporaryBlockCardsByCustomer) == true)) &&
                ((this.TotalTemporaryBlockCardsByShell == null && other.TotalTemporaryBlockCardsByShell == null) || (this.TotalTemporaryBlockCardsByShell?.Equals(other.TotalTemporaryBlockCardsByShell) == true)) &&
                ((this.TotalNewCards == null && other.TotalNewCards == null) || (this.TotalNewCards?.Equals(other.TotalNewCards) == true)) &&
                ((this.TotalFraudCards == null && other.TotalFraudCards == null) || (this.TotalFraudCards?.Equals(other.TotalFraudCards) == true)) &&
                ((this.TotalBlockedAccounts == null && other.TotalBlockedAccounts == null) || (this.TotalBlockedAccounts?.Equals(other.TotalBlockedAccounts) == true)) &&
                ((this.TotalCancelledAccounts == null && other.TotalCancelledAccounts == null) || (this.TotalCancelledAccounts?.Equals(other.TotalCancelledAccounts) == true)) &&
                ((this.PayerTradingName == null && other.PayerTradingName == null) || (this.PayerTradingName?.Equals(other.PayerTradingName) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.BillingLanguage == null && other.BillingLanguage == null) || (this.BillingLanguage?.Equals(other.BillingLanguage) == true)) &&
                ((this.LegalEntity == null && other.LegalEntity == null) || (this.LegalEntity?.Equals(other.LegalEntity) == true)) &&
                ((this.DateEstablished == null && other.DateEstablished == null) || (this.DateEstablished?.Equals(other.DateEstablished) == true)) &&
                ((this.CustomerClassification == null && other.CustomerClassification == null) || (this.CustomerClassification?.Equals(other.CustomerClassification) == true)) &&
                ((this.IndustryClass == null && other.IndustryClass == null) || (this.IndustryClass?.Equals(other.IndustryClass) == true)) &&
                ((this.MarketingSegmentation == null && other.MarketingSegmentation == null) || (this.MarketingSegmentation?.Equals(other.MarketingSegmentation) == true)) &&
                ((this.LineOfBusiness == null && other.LineOfBusiness == null) || (this.LineOfBusiness?.Equals(other.LineOfBusiness) == true)) &&
                ((this.PrintCreditLimit == null && other.PrintCreditLimit == null) || (this.PrintCreditLimit?.Equals(other.PrintCreditLimit) == true)) &&
                ((this.CardGroupType == null && other.CardGroupType == null) || (this.CardGroupType?.Equals(other.CardGroupType) == true)) &&
                ((this.RenewCards == null && other.RenewCards == null) || (this.RenewCards?.Equals(other.RenewCards) == true)) &&
                ((this.AllowSelectPIN == null && other.AllowSelectPIN == null) || (this.AllowSelectPIN?.Equals(other.AllowSelectPIN) == true)) &&
                ((this.UseFleetPIN == null && other.UseFleetPIN == null) || (this.UseFleetPIN?.Equals(other.UseFleetPIN) == true)) &&
                ((this.VATRegNumber == null && other.VATRegNumber == null) || (this.VATRegNumber?.Equals(other.VATRegNumber) == true)) &&
                ((this.VATRegNumber2 == null && other.VATRegNumber2 == null) || (this.VATRegNumber2?.Equals(other.VATRegNumber2) == true)) &&
                ((this.RegistrationNumber == null && other.RegistrationNumber == null) || (this.RegistrationNumber?.Equals(other.RegistrationNumber) == true)) &&
                ((this.RegistrationNumber2 == null && other.RegistrationNumber2 == null) || (this.RegistrationNumber2?.Equals(other.RegistrationNumber2) == true)) &&
                ((this.SalesLedgerBalance == null && other.SalesLedgerBalance == null) || (this.SalesLedgerBalance?.Equals(other.SalesLedgerBalance) == true)) &&
                ((this.Exposure == null && other.Exposure == null) || (this.Exposure?.Equals(other.Exposure) == true)) &&
                ((this.OutstandingDebt == null && other.OutstandingDebt == null) || (this.OutstandingDebt?.Equals(other.OutstandingDebt) == true)) &&
                ((this.AvailableCredit == null && other.AvailableCredit == null) || (this.AvailableCredit?.Equals(other.AvailableCredit) == true)) &&
                ((this.Band == null && other.Band == null) || (this.Band?.Equals(other.Band) == true)) &&
                ((this.GlobalCustomerReferenceId == null && other.GlobalCustomerReferenceId == null) || (this.GlobalCustomerReferenceId?.Equals(other.GlobalCustomerReferenceId) == true)) &&
                ((this.CreditLimit == null && other.CreditLimit == null) || (this.CreditLimit?.Equals(other.CreditLimit) == true)) &&
                ((this.CreditLimitInCustomerCurrency == null && other.CreditLimitInCustomerCurrency == null) || (this.CreditLimitInCustomerCurrency?.Equals(other.CreditLimitInCustomerCurrency) == true)) &&
                ((this.BillingCurrencyCode == null && other.BillingCurrencyCode == null) || (this.BillingCurrencyCode?.Equals(other.BillingCurrencyCode) == true)) &&
                ((this.BillingCurrencySymbol == null && other.BillingCurrencySymbol == null) || (this.BillingCurrencySymbol?.Equals(other.BillingCurrencySymbol) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.PaymentTerms == null && other.PaymentTerms == null) || (this.PaymentTerms?.Equals(other.PaymentTerms) == true)) &&
                ((this.TemporaryCreditLimitIncrease == null && other.TemporaryCreditLimitIncrease == null) || (this.TemporaryCreditLimitIncrease?.Equals(other.TemporaryCreditLimitIncrease) == true)) &&
                ((this.TemporaryCreditLimitIncreaseInCustomerCurrency == null && other.TemporaryCreditLimitIncreaseInCustomerCurrency == null) || (this.TemporaryCreditLimitIncreaseInCustomerCurrency?.Equals(other.TemporaryCreditLimitIncreaseInCustomerCurrency) == true)) &&
                ((this.TemporaryCreditLimitExpiryDate == null && other.TemporaryCreditLimitExpiryDate == null) || (this.TemporaryCreditLimitExpiryDate?.Equals(other.TemporaryCreditLimitExpiryDate) == true)) &&
                ((this.PayerBankAccount == null && other.PayerBankAccount == null) || (this.PayerBankAccount?.Equals(other.PayerBankAccount) == true)) &&
                ((this.CardDeliveryAddress == null && other.CardDeliveryAddress == null) || (this.CardDeliveryAddress?.Equals(other.CardDeliveryAddress) == true)) &&
                ((this.CorrespondanceAddress == null && other.CorrespondanceAddress == null) || (this.CorrespondanceAddress?.Equals(other.CorrespondanceAddress) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.HasActiveVolBasedPricing == null && other.HasActiveVolBasedPricing == null) || (this.HasActiveVolBasedPricing?.Equals(other.HasActiveVolBasedPricing) == true)) &&
                ((this.HasActiveVolBasedBonus == null && other.HasActiveVolBasedBonus == null) || (this.HasActiveVolBasedBonus?.Equals(other.HasActiveVolBasedBonus) == true)) &&
                ((this.HasActiveVolBasedAssociationBonus == null && other.HasActiveVolBasedAssociationBonus == null) || (this.HasActiveVolBasedAssociationBonus?.Equals(other.HasActiveVolBasedAssociationBonus) == true)) &&
                ((this.FinanceCurrency == null && other.FinanceCurrency == null) || (this.FinanceCurrency?.Equals(other.FinanceCurrency) == true)) &&
                ((this.TollsCustomerId == null && other.TollsCustomerId == null) || (this.TollsCustomerId?.Equals(other.TollsCustomerId) == true)) &&
                ((this.TollsColcoCountryTypeId == null && other.TollsColcoCountryTypeId == null) || (this.TollsColcoCountryTypeId?.Equals(other.TollsColcoCountryTypeId) == true)) &&
                ((this.Contracts == null && other.Contracts == null) || (this.Contracts?.Equals(other.Contracts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerFullName = {(this.PayerFullName == null ? "null" : this.PayerFullName)}");
            toStringOutput.Add($"this.PayerShortName = {(this.PayerShortName == null ? "null" : this.PayerShortName)}");
            toStringOutput.Add($"this.PayerGroupId = {(this.PayerGroupId == null ? "null" : this.PayerGroupId.ToString())}");
            toStringOutput.Add($"this.AmountDue = {(this.AmountDue == null ? "null" : this.AmountDue.ToString())}");
            toStringOutput.Add($"this.AmountOverdue = {(this.AmountOverdue == null ? "null" : this.AmountOverdue.ToString())}");
            toStringOutput.Add($"this.AmountNotOverdue = {(this.AmountNotOverdue == null ? "null" : this.AmountNotOverdue.ToString())}");
            toStringOutput.Add($"this.OutstandingBalance = {(this.OutstandingBalance == null ? "null" : this.OutstandingBalance.ToString())}");
            toStringOutput.Add($"this.UnallocatedPayment = {(this.UnallocatedPayment == null ? "null" : this.UnallocatedPayment.ToString())}");
            toStringOutput.Add($"this.SOACurrencyCode = {(this.SOACurrencyCode == null ? "null" : this.SOACurrencyCode)}");
            toStringOutput.Add($"this.SOACurrencySymbol = {(this.SOACurrencySymbol == null ? "null" : this.SOACurrencySymbol)}");
            toStringOutput.Add($"this.SOACreditLimitCurrencyCode = {(this.SOACreditLimitCurrencyCode == null ? "null" : this.SOACreditLimitCurrencyCode)}");
            toStringOutput.Add($"this.SOACreditLimitCurrencySymbol = {(this.SOACreditLimitCurrencySymbol == null ? "null" : this.SOACreditLimitCurrencySymbol)}");
            toStringOutput.Add($"this.LastPaymentCurrencyCode = {(this.LastPaymentCurrencyCode == null ? "null" : this.LastPaymentCurrencyCode)}");
            toStringOutput.Add($"this.LastPaymentCurrencySymbol = {(this.LastPaymentCurrencySymbol == null ? "null" : this.LastPaymentCurrencySymbol)}");
            toStringOutput.Add($"this.LastPaymentAmount = {(this.LastPaymentAmount == null ? "null" : this.LastPaymentAmount.ToString())}");
            toStringOutput.Add($"this.LastPaymentDate = {(this.LastPaymentDate == null ? "null" : this.LastPaymentDate)}");
            toStringOutput.Add($"this.SOALastPaymentAmount = {(this.SOALastPaymentAmount == null ? "null" : this.SOALastPaymentAmount.ToString())}");
            toStringOutput.Add($"this.SOALastPaymentDate = {(this.SOALastPaymentDate == null ? "null" : this.SOALastPaymentDate)}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.LocalCurrencyExchangeRate = {(this.LocalCurrencyExchangeRate == null ? "null" : this.LocalCurrencyExchangeRate.ToString())}");
            toStringOutput.Add($"this.LocalCurrencyExchangeRateSoA = {(this.LocalCurrencyExchangeRateSoA == null ? "null" : this.LocalCurrencyExchangeRateSoA.ToString())}");
            toStringOutput.Add($"this.BillingFrequencyTypeId = {(this.BillingFrequencyTypeId == null ? "null" : this.BillingFrequencyTypeId.ToString())}");
            toStringOutput.Add($"this.BillingFrequencyType = {(this.BillingFrequencyType == null ? "null" : this.BillingFrequencyType)}");
            toStringOutput.Add($"this.BillingRunFrequencyTypeId = {(this.BillingRunFrequencyTypeId == null ? "null" : this.BillingRunFrequencyTypeId.ToString())}");
            toStringOutput.Add($"this.BillingRunFrequnecy = {(this.BillingRunFrequnecy == null ? "null" : this.BillingRunFrequnecy)}");
            toStringOutput.Add($"this.Day1Run = {(this.Day1Run == null ? "null" : this.Day1Run.ToString())}");
            toStringOutput.Add($"this.Day2Run = {(this.Day2Run == null ? "null" : this.Day2Run.ToString())}");
            toStringOutput.Add($"this.Day3Run = {(this.Day3Run == null ? "null" : this.Day3Run.ToString())}");
            toStringOutput.Add($"this.Day4Run = {(this.Day4Run == null ? "null" : this.Day4Run.ToString())}");
            toStringOutput.Add($"this.InvoiceDistributionMethods = {(this.InvoiceDistributionMethods == null ? "null" : $"[{string.Join(", ", this.InvoiceDistributionMethods)} ]")}");
            toStringOutput.Add($"this.OutputType = {(this.OutputType == null ? "null" : this.OutputType)}");
            toStringOutput.Add($"this.InvoiceAccountID = {(this.InvoiceAccountID == null ? "null" : this.InvoiceAccountID.ToString())}");
            toStringOutput.Add($"this.InvoiceAccountNumber = {(this.InvoiceAccountNumber == null ? "null" : this.InvoiceAccountNumber)}");
            toStringOutput.Add($"this.InvoiceAccountShortName = {(this.InvoiceAccountShortName == null ? "null" : this.InvoiceAccountShortName)}");
            toStringOutput.Add($"this.BestOfIndicator = {(this.BestOfIndicator == null ? "null" : this.BestOfIndicator.ToString())}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.TotalAccounts = {(this.TotalAccounts == null ? "null" : this.TotalAccounts.ToString())}");
            toStringOutput.Add($"this.TotalActiveAccounts = {(this.TotalActiveAccounts == null ? "null" : this.TotalActiveAccounts.ToString())}");
            toStringOutput.Add($"this.TotalCards = {(this.TotalCards == null ? "null" : this.TotalCards.ToString())}");
            toStringOutput.Add($"this.TotalActiveCards = {(this.TotalActiveCards == null ? "null" : this.TotalActiveCards.ToString())}");
            toStringOutput.Add($"this.TotalBlockedCards = {(this.TotalBlockedCards == null ? "null" : this.TotalBlockedCards.ToString())}");
            toStringOutput.Add($"this.TotalCancelledCards = {(this.TotalCancelledCards == null ? "null" : this.TotalCancelledCards.ToString())}");
            toStringOutput.Add($"this.TotalExpiredCards = {(this.TotalExpiredCards == null ? "null" : this.TotalExpiredCards.ToString())}");
            toStringOutput.Add($"this.TotalRenewalPendingCards = {(this.TotalRenewalPendingCards == null ? "null" : this.TotalRenewalPendingCards.ToString())}");
            toStringOutput.Add($"this.TotalReplacedCards = {(this.TotalReplacedCards == null ? "null" : this.TotalReplacedCards.ToString())}");
            toStringOutput.Add($"this.TotalTemporaryBlockCardsByCustomer = {(this.TotalTemporaryBlockCardsByCustomer == null ? "null" : this.TotalTemporaryBlockCardsByCustomer.ToString())}");
            toStringOutput.Add($"this.TotalTemporaryBlockCardsByShell = {(this.TotalTemporaryBlockCardsByShell == null ? "null" : this.TotalTemporaryBlockCardsByShell.ToString())}");
            toStringOutput.Add($"this.TotalNewCards = {(this.TotalNewCards == null ? "null" : this.TotalNewCards.ToString())}");
            toStringOutput.Add($"this.TotalFraudCards = {(this.TotalFraudCards == null ? "null" : this.TotalFraudCards.ToString())}");
            toStringOutput.Add($"this.TotalBlockedAccounts = {(this.TotalBlockedAccounts == null ? "null" : this.TotalBlockedAccounts.ToString())}");
            toStringOutput.Add($"this.TotalCancelledAccounts = {(this.TotalCancelledAccounts == null ? "null" : this.TotalCancelledAccounts.ToString())}");
            toStringOutput.Add($"this.PayerTradingName = {(this.PayerTradingName == null ? "null" : this.PayerTradingName)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.BillingLanguage = {(this.BillingLanguage == null ? "null" : this.BillingLanguage)}");
            toStringOutput.Add($"this.LegalEntity = {(this.LegalEntity == null ? "null" : this.LegalEntity)}");
            toStringOutput.Add($"this.DateEstablished = {(this.DateEstablished == null ? "null" : this.DateEstablished)}");
            toStringOutput.Add($"this.CustomerClassification = {(this.CustomerClassification == null ? "null" : this.CustomerClassification)}");
            toStringOutput.Add($"this.IndustryClass = {(this.IndustryClass == null ? "null" : this.IndustryClass)}");
            toStringOutput.Add($"this.MarketingSegmentation = {(this.MarketingSegmentation == null ? "null" : this.MarketingSegmentation)}");
            toStringOutput.Add($"this.LineOfBusiness = {(this.LineOfBusiness == null ? "null" : this.LineOfBusiness)}");
            toStringOutput.Add($"this.PrintCreditLimit = {(this.PrintCreditLimit == null ? "null" : this.PrintCreditLimit.ToString())}");
            toStringOutput.Add($"this.CardGroupType = {(this.CardGroupType == null ? "null" : this.CardGroupType)}");
            toStringOutput.Add($"this.RenewCards = {(this.RenewCards == null ? "null" : this.RenewCards.ToString())}");
            toStringOutput.Add($"this.AllowSelectPIN = {(this.AllowSelectPIN == null ? "null" : this.AllowSelectPIN.ToString())}");
            toStringOutput.Add($"this.UseFleetPIN = {(this.UseFleetPIN == null ? "null" : this.UseFleetPIN.ToString())}");
            toStringOutput.Add($"this.VATRegNumber = {(this.VATRegNumber == null ? "null" : this.VATRegNumber)}");
            toStringOutput.Add($"this.VATRegNumber2 = {(this.VATRegNumber2 == null ? "null" : this.VATRegNumber2)}");
            toStringOutput.Add($"this.RegistrationNumber = {(this.RegistrationNumber == null ? "null" : this.RegistrationNumber)}");
            toStringOutput.Add($"this.RegistrationNumber2 = {(this.RegistrationNumber2 == null ? "null" : this.RegistrationNumber2)}");
            toStringOutput.Add($"this.SalesLedgerBalance = {(this.SalesLedgerBalance == null ? "null" : this.SalesLedgerBalance.ToString())}");
            toStringOutput.Add($"this.Exposure = {(this.Exposure == null ? "null" : this.Exposure.ToString())}");
            toStringOutput.Add($"this.OutstandingDebt = {(this.OutstandingDebt == null ? "null" : this.OutstandingDebt.ToString())}");
            toStringOutput.Add($"this.AvailableCredit = {(this.AvailableCredit == null ? "null" : this.AvailableCredit.ToString())}");
            toStringOutput.Add($"this.Band = {(this.Band == null ? "null" : this.Band)}");
            toStringOutput.Add($"this.GlobalCustomerReferenceId = {(this.GlobalCustomerReferenceId == null ? "null" : this.GlobalCustomerReferenceId)}");
            toStringOutput.Add($"this.CreditLimit = {(this.CreditLimit == null ? "null" : this.CreditLimit.ToString())}");
            toStringOutput.Add($"this.CreditLimitInCustomerCurrency = {(this.CreditLimitInCustomerCurrency == null ? "null" : this.CreditLimitInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.BillingCurrencyCode = {(this.BillingCurrencyCode == null ? "null" : this.BillingCurrencyCode)}");
            toStringOutput.Add($"this.BillingCurrencySymbol = {(this.BillingCurrencySymbol == null ? "null" : this.BillingCurrencySymbol)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod)}");
            toStringOutput.Add($"this.PaymentTerms = {(this.PaymentTerms == null ? "null" : this.PaymentTerms)}");
            toStringOutput.Add($"this.TemporaryCreditLimitIncrease = {(this.TemporaryCreditLimitIncrease == null ? "null" : this.TemporaryCreditLimitIncrease.ToString())}");
            toStringOutput.Add($"this.TemporaryCreditLimitIncreaseInCustomerCurrency = {(this.TemporaryCreditLimitIncreaseInCustomerCurrency == null ? "null" : this.TemporaryCreditLimitIncreaseInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.TemporaryCreditLimitExpiryDate = {(this.TemporaryCreditLimitExpiryDate == null ? "null" : this.TemporaryCreditLimitExpiryDate)}");
            toStringOutput.Add($"this.PayerBankAccount = {(this.PayerBankAccount == null ? "null" : $"[{string.Join(", ", this.PayerBankAccount)} ]")}");
            toStringOutput.Add($"this.CardDeliveryAddress = {(this.CardDeliveryAddress == null ? "null" : this.CardDeliveryAddress.ToString())}");
            toStringOutput.Add($"this.CorrespondanceAddress = {(this.CorrespondanceAddress == null ? "null" : this.CorrespondanceAddress.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.HasActiveVolBasedPricing = {(this.HasActiveVolBasedPricing == null ? "null" : this.HasActiveVolBasedPricing.ToString())}");
            toStringOutput.Add($"this.HasActiveVolBasedBonus = {(this.HasActiveVolBasedBonus == null ? "null" : this.HasActiveVolBasedBonus.ToString())}");
            toStringOutput.Add($"this.HasActiveVolBasedAssociationBonus = {(this.HasActiveVolBasedAssociationBonus == null ? "null" : this.HasActiveVolBasedAssociationBonus.ToString())}");
            toStringOutput.Add($"this.FinanceCurrency = {(this.FinanceCurrency == null ? "null" : this.FinanceCurrency.ToString())}");
            toStringOutput.Add($"this.TollsCustomerId = {(this.TollsCustomerId == null ? "null" : this.TollsCustomerId)}");
            toStringOutput.Add($"this.TollsColcoCountryTypeId = {(this.TollsColcoCountryTypeId == null ? "null" : this.TollsColcoCountryTypeId)}");
            toStringOutput.Add($"this.Contracts = {(this.Contracts == null ? "null" : $"[{string.Join(", ", this.Contracts)} ]")}");
        }
    }
}
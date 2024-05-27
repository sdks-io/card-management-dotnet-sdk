// <copyright file="FinanceCurrency.cs" company="APIMatic">
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
    /// FinanceCurrency.
    /// </summary>
    public class FinanceCurrency
    {
        private string currencyCode;
        private string currencySymbol;
        private double? invoiceExchangeRate;
        private double? creditLimitExchangeRate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "Invoice_ExchangeRate", false },
            { "CreditLimit_ExchangeRate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceCurrency"/> class.
        /// </summary>
        public FinanceCurrency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceCurrency"/> class.
        /// </summary>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="invoiceExchangeRate">Invoice_ExchangeRate.</param>
        /// <param name="creditLimitExchangeRate">CreditLimit_ExchangeRate.</param>
        public FinanceCurrency(
            string currencyCode = null,
            string currencySymbol = null,
            double? invoiceExchangeRate = null,
            double? creditLimitExchangeRate = null)
        {
            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (invoiceExchangeRate != null)
            {
                this.InvoiceExchangeRate = invoiceExchangeRate;
            }

            if (creditLimitExchangeRate != null)
            {
                this.CreditLimitExchangeRate = creditLimitExchangeRate;
            }

        }

        /// <summary>
        /// Currency ISO Code used for the Finance Widget.
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
        /// Factor to be used for converting the amounts in invoice currency to finance widget currency. (If finance currency is same as invoice currency, then the value of this field will be “1” so that the value does not change)
        /// </summary>
        [JsonProperty("Invoice_ExchangeRate")]
        public double? InvoiceExchangeRate
        {
            get
            {
                return this.invoiceExchangeRate;
            }

            set
            {
                this.shouldSerialize["Invoice_ExchangeRate"] = true;
                this.invoiceExchangeRate = value;
            }
        }

        /// <summary>
        /// Factor to be used for converting the amounts in credit limit currency to finance widget currency. (If finance currency is same as credit limit currency, then the value of this field will be “1” so that the value does not change)
        /// </summary>
        [JsonProperty("CreditLimit_ExchangeRate")]
        public double? CreditLimitExchangeRate
        {
            get
            {
                return this.creditLimitExchangeRate;
            }

            set
            {
                this.shouldSerialize["CreditLimit_ExchangeRate"] = true;
                this.creditLimitExchangeRate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FinanceCurrency : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetInvoiceExchangeRate()
        {
            this.shouldSerialize["Invoice_ExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimitExchangeRate()
        {
            this.shouldSerialize["CreditLimit_ExchangeRate"] = false;
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
        public bool ShouldSerializeInvoiceExchangeRate()
        {
            return this.shouldSerialize["Invoice_ExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimitExchangeRate()
        {
            return this.shouldSerialize["CreditLimit_ExchangeRate"];
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
            return obj is FinanceCurrency other &&                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.InvoiceExchangeRate == null && other.InvoiceExchangeRate == null) || (this.InvoiceExchangeRate?.Equals(other.InvoiceExchangeRate) == true)) &&
                ((this.CreditLimitExchangeRate == null && other.CreditLimitExchangeRate == null) || (this.CreditLimitExchangeRate?.Equals(other.CreditLimitExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.InvoiceExchangeRate = {(this.InvoiceExchangeRate == null ? "null" : this.InvoiceExchangeRate.ToString())}");
            toStringOutput.Add($"this.CreditLimitExchangeRate = {(this.CreditLimitExchangeRate == null ? "null" : this.CreditLimitExchangeRate.ToString())}");
        }
    }
}
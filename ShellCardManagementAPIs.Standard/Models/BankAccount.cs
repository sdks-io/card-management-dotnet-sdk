// <copyright file="BankAccount.cs" company="APIMatic">
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
    /// BankAccount.
    /// </summary>
    public class BankAccount
    {
        private string accountNumber;
        private string bankName;
        private string accountName;
        private string dateEffective;
        private string dateTerminated;
        private string iBAN;
        private string currencyCode;
        private string currencySymbol;
        private string countryISOCode;
        private string country;
        private string sortCode;
        private string swiftCode;
        private string bankType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountNumber", false },
            { "BankName", false },
            { "AccountName", false },
            { "DateEffective", false },
            { "DateTerminated", false },
            { "IBAN", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "CountryISOCode", false },
            { "Country", false },
            { "SortCode", false },
            { "SwiftCode", false },
            { "BankType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        public BankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="bankName">BankName.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="dateEffective">DateEffective.</param>
        /// <param name="dateTerminated">DateTerminated.</param>
        /// <param name="iBAN">IBAN.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="countryISOCode">CountryISOCode.</param>
        /// <param name="country">Country.</param>
        /// <param name="sortCode">SortCode.</param>
        /// <param name="swiftCode">SwiftCode.</param>
        /// <param name="bankType">BankType.</param>
        public BankAccount(
            string accountNumber = null,
            string bankName = null,
            string accountName = null,
            string dateEffective = null,
            string dateTerminated = null,
            string iBAN = null,
            string currencyCode = null,
            string currencySymbol = null,
            string countryISOCode = null,
            string country = null,
            string sortCode = null,
            string swiftCode = null,
            string bankType = null)
        {

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (bankName != null)
            {
                this.BankName = bankName;
            }

            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (dateEffective != null)
            {
                this.DateEffective = dateEffective;
            }

            if (dateTerminated != null)
            {
                this.DateTerminated = dateTerminated;
            }

            if (iBAN != null)
            {
                this.IBAN = iBAN;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (countryISOCode != null)
            {
                this.CountryISOCode = countryISOCode;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (sortCode != null)
            {
                this.SortCode = sortCode;
            }

            if (swiftCode != null)
            {
                this.SwiftCode = swiftCode;
            }

            if (bankType != null)
            {
                this.BankType = bankType;
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
        /// Bank Name
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName
        {
            get
            {
                return this.bankName;
            }

            set
            {
                this.shouldSerialize["BankName"] = true;
                this.bankName = value;
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
        /// Bank Account effective date for the payer
        /// </summary>
        [JsonProperty("DateEffective")]
        public string DateEffective
        {
            get
            {
                return this.dateEffective;
            }

            set
            {
                this.shouldSerialize["DateEffective"] = true;
                this.dateEffective = value;
            }
        }

        /// <summary>
        /// Bank Account terminated date. Default is null
        /// </summary>
        [JsonProperty("DateTerminated")]
        public string DateTerminated
        {
            get
            {
                return this.dateTerminated;
            }

            set
            {
                this.shouldSerialize["DateTerminated"] = true;
                this.dateTerminated = value;
            }
        }

        /// <summary>
        /// Bank Account IBAN for Payer
        /// </summary>
        [JsonProperty("IBAN")]
        public string IBAN
        {
            get
            {
                return this.iBAN;
            }

            set
            {
                this.shouldSerialize["IBAN"] = true;
                this.iBAN = value;
            }
        }

        /// <summary>
        /// Bank Account currency ISO code.
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
        /// Bank Account currency Symbol.
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
        /// Bank Account Country ISO Code
        /// </summary>
        [JsonProperty("CountryISOCode")]
        public string CountryISOCode
        {
            get
            {
                return this.countryISOCode;
            }

            set
            {
                this.shouldSerialize["CountryISOCode"] = true;
                this.countryISOCode = value;
            }
        }

        /// <summary>
        /// Bank Account Country Name
        /// 1-Austria
        /// 2-Belgium
        /// 3-Bulgaria
        /// 4-Croatia
        /// 5-Czech Republic
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
        /// Payer bank Sort Code
        /// </summary>
        [JsonProperty("SortCode")]
        public string SortCode
        {
            get
            {
                return this.sortCode;
            }

            set
            {
                this.shouldSerialize["SortCode"] = true;
                this.sortCode = value;
            }
        }

        /// <summary>
        /// Payer Bank Swift Code
        /// </summary>
        [JsonProperty("SwiftCode")]
        public string SwiftCode
        {
            get
            {
                return this.swiftCode;
            }

            set
            {
                this.shouldSerialize["SwiftCode"] = true;
                this.swiftCode = value;
            }
        }

        /// <summary>
        /// Bank Type Id and Description
        /// </summary>
        [JsonProperty("BankType")]
        public string BankType
        {
            get
            {
                return this.bankType;
            }

            set
            {
                this.shouldSerialize["BankType"] = true;
                this.bankType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccount : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetBankName()
        {
            this.shouldSerialize["BankName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDateEffective()
        {
            this.shouldSerialize["DateEffective"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDateTerminated()
        {
            this.shouldSerialize["DateTerminated"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIBAN()
        {
            this.shouldSerialize["IBAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCurrencyCode()
        {
            this.shouldSerialize["CurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCurrencySymbol()
        {
            this.shouldSerialize["CurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountryISOCode()
        {
            this.shouldSerialize["CountryISOCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSortCode()
        {
            this.shouldSerialize["SortCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSwiftCode()
        {
            this.shouldSerialize["SwiftCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankType()
        {
            this.shouldSerialize["BankType"] = false;
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
        public bool ShouldSerializeBankName()
        {
            return this.shouldSerialize["BankName"];
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
        public bool ShouldSerializeDateEffective()
        {
            return this.shouldSerialize["DateEffective"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateTerminated()
        {
            return this.shouldSerialize["DateTerminated"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIBAN()
        {
            return this.shouldSerialize["IBAN"];
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
        public bool ShouldSerializeCountryISOCode()
        {
            return this.shouldSerialize["CountryISOCode"];
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
        public bool ShouldSerializeSortCode()
        {
            return this.shouldSerialize["SortCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSwiftCode()
        {
            return this.shouldSerialize["SwiftCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankType()
        {
            return this.shouldSerialize["BankType"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccount other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.BankName == null && other.BankName == null ||
                 this.BankName?.Equals(other.BankName) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.DateEffective == null && other.DateEffective == null ||
                 this.DateEffective?.Equals(other.DateEffective) == true) &&
                (this.DateTerminated == null && other.DateTerminated == null ||
                 this.DateTerminated?.Equals(other.DateTerminated) == true) &&
                (this.IBAN == null && other.IBAN == null ||
                 this.IBAN?.Equals(other.IBAN) == true) &&
                (this.CurrencyCode == null && other.CurrencyCode == null ||
                 this.CurrencyCode?.Equals(other.CurrencyCode) == true) &&
                (this.CurrencySymbol == null && other.CurrencySymbol == null ||
                 this.CurrencySymbol?.Equals(other.CurrencySymbol) == true) &&
                (this.CountryISOCode == null && other.CountryISOCode == null ||
                 this.CountryISOCode?.Equals(other.CountryISOCode) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.SortCode == null && other.SortCode == null ||
                 this.SortCode?.Equals(other.SortCode) == true) &&
                (this.SwiftCode == null && other.SwiftCode == null ||
                 this.SwiftCode?.Equals(other.SwiftCode) == true) &&
                (this.BankType == null && other.BankType == null ||
                 this.BankType?.Equals(other.BankType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"this.BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"this.AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"this.DateEffective = {this.DateEffective ?? "null"}");
            toStringOutput.Add($"this.DateTerminated = {this.DateTerminated ?? "null"}");
            toStringOutput.Add($"this.IBAN = {this.IBAN ?? "null"}");
            toStringOutput.Add($"this.CurrencyCode = {this.CurrencyCode ?? "null"}");
            toStringOutput.Add($"this.CurrencySymbol = {this.CurrencySymbol ?? "null"}");
            toStringOutput.Add($"this.CountryISOCode = {this.CountryISOCode ?? "null"}");
            toStringOutput.Add($"this.Country = {this.Country ?? "null"}");
            toStringOutput.Add($"this.SortCode = {this.SortCode ?? "null"}");
            toStringOutput.Add($"this.SwiftCode = {this.SwiftCode ?? "null"}");
            toStringOutput.Add($"this.BankType = {this.BankType ?? "null"}");
        }
    }
}
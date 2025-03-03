// <copyright file="AccountAccess.cs" company="APIMatic">
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
    /// AccountAccess.
    /// </summary>
    public class AccountAccess
    {
        private int? colcoId;
        private int? colcoCode;
        private int? payerId;
        private string payerNumber;
        private string payerName;
        private int? accountId;
        private string accountName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColcoId", false },
            { "ColcoCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerName", false },
            { "AccountId", false },
            { "AccountName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAccess"/> class.
        /// </summary>
        public AccountAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAccess"/> class.
        /// </summary>
        /// <param name="colcoId">ColcoId.</param>
        /// <param name="colcoCode">ColcoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountName">AccountName.</param>
        public AccountAccess(
            int? colcoId = null,
            int? colcoCode = null,
            int? payerId = null,
            string payerNumber = null,
            string payerName = null,
            int? accountId = null,
            string accountNumber = null,
            string accountName = null)
        {

            if (colcoId != null)
            {
                this.ColcoId = colcoId;
            }

            if (colcoCode != null)
            {
                this.ColcoCode = colcoCode;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }
            this.AccountNumber = accountNumber;

            if (accountName != null)
            {
                this.AccountName = accountName;
            }
        }

        /// <summary>
        /// Collecting company id.
        /// </summary>
        [JsonProperty("ColcoId")]
        public int? ColcoId
        {
            get
            {
                return this.colcoId;
            }

            set
            {
                this.shouldSerialize["ColcoId"] = true;
                this.colcoId = value;
            }
        }

        /// <summary>
        /// Collecting company code.
        /// </summary>
        [JsonProperty("ColcoCode")]
        public int? ColcoCode
        {
            get
            {
                return this.colcoCode;
            }

            set
            {
                this.shouldSerialize["ColcoCode"] = true;
                this.colcoCode = value;
            }
        }

        /// <summary>
        /// Payer Id to which the user has access
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
        /// Payer Number to which the user has access
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
        /// Name of the Payer to which the user has access
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }

            set
            {
                this.shouldSerialize["PayerName"] = true;
                this.payerName = value;
            }
        }

        /// <summary>
        /// Account Id to which the user has access
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
        /// Account Number to which the user has access
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Name of the Account to which the user has access
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountAccess : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColcoId()
        {
            this.shouldSerialize["ColcoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColcoCode()
        {
            this.shouldSerialize["ColcoCode"] = false;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerName()
        {
            this.shouldSerialize["PayerName"] = false;
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
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColcoId()
        {
            return this.shouldSerialize["ColcoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColcoCode()
        {
            return this.shouldSerialize["ColcoCode"];
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
        public bool ShouldSerializePayerName()
        {
            return this.shouldSerialize["PayerName"];
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountAccess other &&
                (this.ColcoId == null && other.ColcoId == null ||
                 this.ColcoId?.Equals(other.ColcoId) == true) &&
                (this.ColcoCode == null && other.ColcoCode == null ||
                 this.ColcoCode?.Equals(other.ColcoCode) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.PayerName == null && other.PayerName == null ||
                 this.PayerName?.Equals(other.PayerName) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ColcoId = {(this.ColcoId == null ? "null" : this.ColcoId.ToString())}");
            toStringOutput.Add($"ColcoCode = {(this.ColcoCode == null ? "null" : this.ColcoCode.ToString())}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"PayerName = {this.PayerName ?? "null"}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
        }
    }
}
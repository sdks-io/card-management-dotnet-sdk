// <copyright file="PayerAccess.cs" company="APIMatic">
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
    /// PayerAccess.
    /// </summary>
    public class PayerAccess
    {
        private int? colcoId;
        private int? colcoCode;
        private string colCoCountryCode;
        private int? payerGroupId;
        private string payerGroup;
        private int? payerId;
        private string payerNumber;
        private string payerName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColcoId", false },
            { "ColcoCode", false },
            { "ColCoCountryCode", false },
            { "PayerGroupId", false },
            { "PayerGroup", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerAccess"/> class.
        /// </summary>
        public PayerAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerAccess"/> class.
        /// </summary>
        /// <param name="isDefault">IsDefault.</param>
        /// <param name="colcoId">ColcoId.</param>
        /// <param name="colcoCode">ColcoCode.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="payerGroupId">PayerGroupId.</param>
        /// <param name="payerGroup">PayerGroup.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerName">PayerName.</param>
        public PayerAccess(
            bool? isDefault = false,
            int? colcoId = null,
            int? colcoCode = null,
            string colCoCountryCode = null,
            int? payerGroupId = null,
            string payerGroup = null,
            int? payerId = null,
            string payerNumber = null,
            string payerName = null)
        {
            this.IsDefault = isDefault;

            if (colcoId != null)
            {
                this.ColcoId = colcoId;
            }

            if (colcoCode != null)
            {
                this.ColcoCode = colcoCode;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (payerGroupId != null)
            {
                this.PayerGroupId = payerGroupId;
            }

            if (payerGroup != null)
            {
                this.PayerGroup = payerGroup;
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
        }

        /// <summary>
        /// Whether this payer is the default payer of the user.
        /// </summary>
        [JsonProperty("IsDefault", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

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
        /// Example:
        /// 86-Philippines
        /// 5-UK
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
        /// The 2-character ISO Code for the customer and card owning country
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
        /// Payer Group Id of the payer.
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
        /// Payer group of the payer.
        /// The value of this parameter will always be null when the input parameter “IncludePayerGroup” is false.
        /// </summary>
        [JsonProperty("PayerGroup")]
        public string PayerGroup
        {
            get
            {
                return this.payerGroup;
            }

            set
            {
                this.shouldSerialize["PayerGroup"] = true;
                this.payerGroup = value;
            }
        }

        /// <summary>
        /// Payer Id to which the user has access
        /// Example: 123456
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
        /// Example: GB000000123
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayerAccess : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerGroupId()
        {
            this.shouldSerialize["PayerGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerGroup()
        {
            this.shouldSerialize["PayerGroup"] = false;
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
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
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
        public bool ShouldSerializePayerGroup()
        {
            return this.shouldSerialize["PayerGroup"];
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayerAccess other &&
                (this.IsDefault == null && other.IsDefault == null ||
                 this.IsDefault?.Equals(other.IsDefault) == true) &&
                (this.ColcoId == null && other.ColcoId == null ||
                 this.ColcoId?.Equals(other.ColcoId) == true) &&
                (this.ColcoCode == null && other.ColcoCode == null ||
                 this.ColcoCode?.Equals(other.ColcoCode) == true) &&
                (this.ColCoCountryCode == null && other.ColCoCountryCode == null ||
                 this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true) &&
                (this.PayerGroupId == null && other.PayerGroupId == null ||
                 this.PayerGroupId?.Equals(other.PayerGroupId) == true) &&
                (this.PayerGroup == null && other.PayerGroup == null ||
                 this.PayerGroup?.Equals(other.PayerGroup) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.PayerName == null && other.PayerName == null ||
                 this.PayerName?.Equals(other.PayerName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsDefault = {(this.IsDefault == null ? "null" : this.IsDefault.ToString())}");
            toStringOutput.Add($"this.ColcoId = {(this.ColcoId == null ? "null" : this.ColcoId.ToString())}");
            toStringOutput.Add($"this.ColcoCode = {(this.ColcoCode == null ? "null" : this.ColcoCode.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {this.ColCoCountryCode ?? "null"}");
            toStringOutput.Add($"this.PayerGroupId = {(this.PayerGroupId == null ? "null" : this.PayerGroupId.ToString())}");
            toStringOutput.Add($"this.PayerGroup = {this.PayerGroup ?? "null"}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"this.PayerName = {this.PayerName ?? "null"}");
        }
    }
}
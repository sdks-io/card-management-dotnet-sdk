// <copyright file="RestrictionCardResponseDataItems.cs" company="APIMatic">
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
    /// RestrictionCardResponseDataItems.
    /// </summary>
    public class RestrictionCardResponseDataItems
    {
        private int? accountId;
        private string accountNumber;
        private int? cardId;
        private string dayTimeRestrictionDescription;
        private string dayTimeRestrictionStatus;
        private string locationRestrictionDescription;
        private string locationRestrictionStatus;
        private string pAN;
        private string productRestrictionDescription;
        private string productRestrictionStatus;
        private string usageRestrictionDescription;
        private string usageRestrictionStatus;
        private string validationErrorCode;
        private string validationErrorDescription;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "CardId", false },
            { "DayTimeRestrictionDescription", false },
            { "DayTimeRestrictionStatus", false },
            { "LocationRestrictionDescription", false },
            { "LocationRestrictionStatus", false },
            { "PAN", false },
            { "ProductRestrictionDescription", false },
            { "ProductRestrictionStatus", false },
            { "UsageRestrictionDescription", false },
            { "UsageRestrictionStatus", false },
            { "ValidationErrorCode", false },
            { "ValidationErrorDescription", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardResponseDataItems"/> class.
        /// </summary>
        public RestrictionCardResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardResponseDataItems"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="dayTimeRestrictionDescription">DayTimeRestrictionDescription.</param>
        /// <param name="dayTimeRestrictionStatus">DayTimeRestrictionStatus.</param>
        /// <param name="locationRestrictionDescription">LocationRestrictionDescription.</param>
        /// <param name="locationRestrictionStatus">LocationRestrictionStatus.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="productRestrictionDescription">ProductRestrictionDescription.</param>
        /// <param name="productRestrictionStatus">ProductRestrictionStatus.</param>
        /// <param name="usageRestrictionDescription">UsageRestrictionDescription.</param>
        /// <param name="usageRestrictionStatus">UsageRestrictionStatus.</param>
        /// <param name="validationErrorCode">ValidationErrorCode.</param>
        /// <param name="validationErrorDescription">ValidationErrorDescription.</param>
        public RestrictionCardResponseDataItems(
            int? accountId = null,
            string accountNumber = null,
            int? cardId = null,
            string dayTimeRestrictionDescription = null,
            string dayTimeRestrictionStatus = null,
            string locationRestrictionDescription = null,
            string locationRestrictionStatus = null,
            string pAN = null,
            string productRestrictionDescription = null,
            string productRestrictionStatus = null,
            string usageRestrictionDescription = null,
            string usageRestrictionStatus = null,
            string validationErrorCode = null,
            string validationErrorDescription = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (dayTimeRestrictionDescription != null)
            {
                this.DayTimeRestrictionDescription = dayTimeRestrictionDescription;
            }

            if (dayTimeRestrictionStatus != null)
            {
                this.DayTimeRestrictionStatus = dayTimeRestrictionStatus;
            }

            if (locationRestrictionDescription != null)
            {
                this.LocationRestrictionDescription = locationRestrictionDescription;
            }

            if (locationRestrictionStatus != null)
            {
                this.LocationRestrictionStatus = locationRestrictionStatus;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (productRestrictionDescription != null)
            {
                this.ProductRestrictionDescription = productRestrictionDescription;
            }

            if (productRestrictionStatus != null)
            {
                this.ProductRestrictionStatus = productRestrictionStatus;
            }

            if (usageRestrictionDescription != null)
            {
                this.UsageRestrictionDescription = usageRestrictionDescription;
            }

            if (usageRestrictionStatus != null)
            {
                this.UsageRestrictionStatus = usageRestrictionStatus;
            }

            if (validationErrorCode != null)
            {
                this.ValidationErrorCode = validationErrorCode;
            }

            if (validationErrorDescription != null)
            {
                this.ValidationErrorDescription = validationErrorDescription;
            }

        }

        /// <summary>
        /// Account Id of the customer.
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
        /// This field will have a value only when “DayTimeRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("DayTimeRestrictionDescription")]
        public string DayTimeRestrictionDescription
        {
            get
            {
                return this.dayTimeRestrictionDescription;
            }

            set
            {
                this.shouldSerialize["DayTimeRestrictionDescription"] = true;
                this.dayTimeRestrictionDescription = value;
            }
        }

        /// <summary>
        /// Status of the card day/time restriction submitted to API. Based on the response from API value will be set as either “Success” or “Failed”.
        /// </summary>
        [JsonProperty("DayTimeRestrictionStatus")]
        public string DayTimeRestrictionStatus
        {
            get
            {
                return this.dayTimeRestrictionStatus;
            }

            set
            {
                this.shouldSerialize["DayTimeRestrictionStatus"] = true;
                this.dayTimeRestrictionStatus = value;
            }
        }

        /// <summary>
        /// This field will have a value only when “LocationRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("LocationRestrictionDescription")]
        public string LocationRestrictionDescription
        {
            get
            {
                return this.locationRestrictionDescription;
            }

            set
            {
                this.shouldSerialize["LocationRestrictionDescription"] = true;
                this.locationRestrictionDescription = value;
            }
        }

        /// <summary>
        /// Card Location restriction submitted to gateway based on gateway response value set as “Success” or “Failed”.
        /// </summary>
        [JsonProperty("LocationRestrictionStatus")]
        public string LocationRestrictionStatus
        {
            get
            {
                return this.locationRestrictionStatus;
            }

            set
            {
                this.shouldSerialize["LocationRestrictionStatus"] = true;
                this.locationRestrictionStatus = value;
            }
        }

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
        /// This field will have a value only when “ProductRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("ProductRestrictionDescription")]
        public string ProductRestrictionDescription
        {
            get
            {
                return this.productRestrictionDescription;
            }

            set
            {
                this.shouldSerialize["ProductRestrictionDescription"] = true;
                this.productRestrictionDescription = value;
            }
        }

        /// <summary>
        /// Status of the card product restriction submitted
        /// </summary>
        [JsonProperty("ProductRestrictionStatus")]
        public string ProductRestrictionStatus
        {
            get
            {
                return this.productRestrictionStatus;
            }

            set
            {
                this.shouldSerialize["ProductRestrictionStatus"] = true;
                this.productRestrictionStatus = value;
            }
        }

        /// <summary>
        /// This field will have a value only when “UsageRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("UsageRestrictionDescription")]
        public string UsageRestrictionDescription
        {
            get
            {
                return this.usageRestrictionDescription;
            }

            set
            {
                this.shouldSerialize["UsageRestrictionDescription"] = true;
                this.usageRestrictionDescription = value;
            }
        }

        /// <summary>
        /// Status of the card usage restriction submitted
        /// </summary>
        [JsonProperty("UsageRestrictionStatus")]
        public string UsageRestrictionStatus
        {
            get
            {
                return this.usageRestrictionStatus;
            }

            set
            {
                this.shouldSerialize["UsageRestrictionStatus"] = true;
                this.usageRestrictionStatus = value;
            }
        }

        /// <summary>
        /// Error code for validation failure.
        /// Example error codes:
        /// 0007, 9007, 7000, 7001.
        /// </summary>
        [JsonProperty("ValidationErrorCode")]
        public string ValidationErrorCode
        {
            get
            {
                return this.validationErrorCode;
            }

            set
            {
                this.shouldSerialize["ValidationErrorCode"] = true;
                this.validationErrorCode = value;
            }
        }

        /// <summary>
        /// Description of validation failure.
        /// </summary>
        [JsonProperty("ValidationErrorDescription")]
        public string ValidationErrorDescription
        {
            get
            {
                return this.validationErrorDescription;
            }

            set
            {
                this.shouldSerialize["ValidationErrorDescription"] = true;
                this.validationErrorDescription = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictionCardResponseDataItems : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDayTimeRestrictionDescription()
        {
            this.shouldSerialize["DayTimeRestrictionDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDayTimeRestrictionStatus()
        {
            this.shouldSerialize["DayTimeRestrictionStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationRestrictionDescription()
        {
            this.shouldSerialize["LocationRestrictionDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationRestrictionStatus()
        {
            this.shouldSerialize["LocationRestrictionStatus"] = false;
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
        public void UnsetProductRestrictionDescription()
        {
            this.shouldSerialize["ProductRestrictionDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductRestrictionStatus()
        {
            this.shouldSerialize["ProductRestrictionStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUsageRestrictionDescription()
        {
            this.shouldSerialize["UsageRestrictionDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUsageRestrictionStatus()
        {
            this.shouldSerialize["UsageRestrictionStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetValidationErrorCode()
        {
            this.shouldSerialize["ValidationErrorCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetValidationErrorDescription()
        {
            this.shouldSerialize["ValidationErrorDescription"] = false;
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
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDayTimeRestrictionDescription()
        {
            return this.shouldSerialize["DayTimeRestrictionDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDayTimeRestrictionStatus()
        {
            return this.shouldSerialize["DayTimeRestrictionStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationRestrictionDescription()
        {
            return this.shouldSerialize["LocationRestrictionDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationRestrictionStatus()
        {
            return this.shouldSerialize["LocationRestrictionStatus"];
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
        public bool ShouldSerializeProductRestrictionDescription()
        {
            return this.shouldSerialize["ProductRestrictionDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductRestrictionStatus()
        {
            return this.shouldSerialize["ProductRestrictionStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageRestrictionDescription()
        {
            return this.shouldSerialize["UsageRestrictionDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageRestrictionStatus()
        {
            return this.shouldSerialize["UsageRestrictionStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeValidationErrorCode()
        {
            return this.shouldSerialize["ValidationErrorCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeValidationErrorDescription()
        {
            return this.shouldSerialize["ValidationErrorDescription"];
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
            return obj is RestrictionCardResponseDataItems other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.DayTimeRestrictionDescription == null && other.DayTimeRestrictionDescription == null) || (this.DayTimeRestrictionDescription?.Equals(other.DayTimeRestrictionDescription) == true)) &&
                ((this.DayTimeRestrictionStatus == null && other.DayTimeRestrictionStatus == null) || (this.DayTimeRestrictionStatus?.Equals(other.DayTimeRestrictionStatus) == true)) &&
                ((this.LocationRestrictionDescription == null && other.LocationRestrictionDescription == null) || (this.LocationRestrictionDescription?.Equals(other.LocationRestrictionDescription) == true)) &&
                ((this.LocationRestrictionStatus == null && other.LocationRestrictionStatus == null) || (this.LocationRestrictionStatus?.Equals(other.LocationRestrictionStatus) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.ProductRestrictionDescription == null && other.ProductRestrictionDescription == null) || (this.ProductRestrictionDescription?.Equals(other.ProductRestrictionDescription) == true)) &&
                ((this.ProductRestrictionStatus == null && other.ProductRestrictionStatus == null) || (this.ProductRestrictionStatus?.Equals(other.ProductRestrictionStatus) == true)) &&
                ((this.UsageRestrictionDescription == null && other.UsageRestrictionDescription == null) || (this.UsageRestrictionDescription?.Equals(other.UsageRestrictionDescription) == true)) &&
                ((this.UsageRestrictionStatus == null && other.UsageRestrictionStatus == null) || (this.UsageRestrictionStatus?.Equals(other.UsageRestrictionStatus) == true)) &&
                ((this.ValidationErrorCode == null && other.ValidationErrorCode == null) || (this.ValidationErrorCode?.Equals(other.ValidationErrorCode) == true)) &&
                ((this.ValidationErrorDescription == null && other.ValidationErrorDescription == null) || (this.ValidationErrorDescription?.Equals(other.ValidationErrorDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictionDescription = {(this.DayTimeRestrictionDescription == null ? "null" : this.DayTimeRestrictionDescription)}");
            toStringOutput.Add($"this.DayTimeRestrictionStatus = {(this.DayTimeRestrictionStatus == null ? "null" : this.DayTimeRestrictionStatus)}");
            toStringOutput.Add($"this.LocationRestrictionDescription = {(this.LocationRestrictionDescription == null ? "null" : this.LocationRestrictionDescription)}");
            toStringOutput.Add($"this.LocationRestrictionStatus = {(this.LocationRestrictionStatus == null ? "null" : this.LocationRestrictionStatus)}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.ProductRestrictionDescription = {(this.ProductRestrictionDescription == null ? "null" : this.ProductRestrictionDescription)}");
            toStringOutput.Add($"this.ProductRestrictionStatus = {(this.ProductRestrictionStatus == null ? "null" : this.ProductRestrictionStatus)}");
            toStringOutput.Add($"this.UsageRestrictionDescription = {(this.UsageRestrictionDescription == null ? "null" : this.UsageRestrictionDescription)}");
            toStringOutput.Add($"this.UsageRestrictionStatus = {(this.UsageRestrictionStatus == null ? "null" : this.UsageRestrictionStatus)}");
            toStringOutput.Add($"this.ValidationErrorCode = {(this.ValidationErrorCode == null ? "null" : this.ValidationErrorCode)}");
            toStringOutput.Add($"this.ValidationErrorDescription = {(this.ValidationErrorDescription == null ? "null" : this.ValidationErrorDescription)}");
        }
    }
}
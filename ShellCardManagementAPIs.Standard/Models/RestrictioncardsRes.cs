// <copyright file="RestrictioncardsRes.cs" company="APIMatic">
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
    /// RestrictioncardsRes.
    /// </summary>
    public class RestrictioncardsRes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictioncardsRes"/> class.
        /// </summary>
        public RestrictioncardsRes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictioncardsRes"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="usageRestrictionStatus">UsageRestrictionStatus.</param>
        /// <param name="usageRestrictionDescription">UsageRestrictionDescription.</param>
        /// <param name="dayTimeRestrictionStatus">DayTimeRestrictionStatus.</param>
        /// <param name="dayTimeRestrictionDescription">DayTimeRestrictionDescription.</param>
        /// <param name="productRestrictionStatus">ProductRestrictionStatus.</param>
        /// <param name="productRestrictionDescription">ProductRestrictionDescription.</param>
        /// <param name="locationRestrictionStatus">LocationRestrictionStatus.</param>
        /// <param name="locationRestrictionStatusDescription">LocationRestrictionStatusDescription.</param>
        /// <param name="validationErrorCode">ValidationErrorCode.</param>
        /// <param name="validationErrorDescription">ValidationErrorDescription.</param>
        public RestrictioncardsRes(
            int? accountId = null,
            string accountNumber = null,
            string cardId = null,
            string pAN = null,
            string usageRestrictionStatus = null,
            string usageRestrictionDescription = null,
            string dayTimeRestrictionStatus = null,
            string dayTimeRestrictionDescription = null,
            string productRestrictionStatus = null,
            string productRestrictionDescription = null,
            string locationRestrictionStatus = null,
            string locationRestrictionStatusDescription = null,
            string validationErrorCode = null,
            string validationErrorDescription = null)
        {
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.CardId = cardId;
            this.PAN = pAN;
            this.UsageRestrictionStatus = usageRestrictionStatus;
            this.UsageRestrictionDescription = usageRestrictionDescription;
            this.DayTimeRestrictionStatus = dayTimeRestrictionStatus;
            this.DayTimeRestrictionDescription = dayTimeRestrictionDescription;
            this.ProductRestrictionStatus = productRestrictionStatus;
            this.ProductRestrictionDescription = productRestrictionDescription;
            this.LocationRestrictionStatus = locationRestrictionStatus;
            this.LocationRestrictionStatusDescription = locationRestrictionStatusDescription;
            this.ValidationErrorCode = validationErrorCode;
            this.ValidationErrorDescription = validationErrorDescription;
        }

        /// <summary>
        /// Account Id of the customer.
        /// Example: 123456
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the customer.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Unique Card Id
        /// Example: 275549
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Card PAN.
        /// Example: 7002051006629890645
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Status of the card usage restriction submitted. Based on the response the value will be set as either “Success” or “Failed”.
        /// </summary>
        [JsonProperty("UsageRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRestrictionStatus { get; set; }

        /// <summary>
        /// Response for the usage restriction in case of an error. This field will have a value only when “UsageRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("UsageRestrictionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRestrictionDescription { get; set; }

        /// <summary>
        /// Status of the card day/time restriction submitted. Based on the response from Gateway value will be set as either “Success” or “Failed”.
        /// </summary>
        [JsonProperty("DayTimeRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string DayTimeRestrictionStatus { get; set; }

        /// <summary>
        /// Response for the day/time restriction in case of an error. This field will have a value only when “DayTimeRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("DayTimeRestrictionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string DayTimeRestrictionDescription { get; set; }

        /// <summary>
        /// Status of the card product restriction submitted. Based on the response  the value will be set  either as “Success” or “Failed”.
        /// </summary>
        [JsonProperty("ProductRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRestrictionStatus { get; set; }

        /// <summary>
        /// Response for the product restriction in case of an error. This field will have a value only when “ProductRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("ProductRestrictionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRestrictionDescription { get; set; }

        /// <summary>
        /// Card Location restriction submitted, based on response value set as “Success” or “Failed”.
        /// </summary>
        [JsonProperty("LocationRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationRestrictionStatus { get; set; }

        /// <summary>
        /// Response for the location restriction in case of an error. This field will have a value only when “LocationRestrictionStatus” is “Failed”.
        /// </summary>
        [JsonProperty("LocationRestrictionStatusDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationRestrictionStatusDescription { get; set; }

        /// <summary>
        /// Error code for validation failure.
        /// </summary>
        [JsonProperty("ValidationErrorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationErrorCode { get; set; }

        /// <summary>
        /// Description of validation failure.
        /// </summary>
        [JsonProperty("ValidationErrorDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationErrorDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestrictioncardsRes : ({string.Join(", ", toStringOutput)})";
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
            return obj is RestrictioncardsRes other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.UsageRestrictionStatus == null && other.UsageRestrictionStatus == null) || (this.UsageRestrictionStatus?.Equals(other.UsageRestrictionStatus) == true)) &&
                ((this.UsageRestrictionDescription == null && other.UsageRestrictionDescription == null) || (this.UsageRestrictionDescription?.Equals(other.UsageRestrictionDescription) == true)) &&
                ((this.DayTimeRestrictionStatus == null && other.DayTimeRestrictionStatus == null) || (this.DayTimeRestrictionStatus?.Equals(other.DayTimeRestrictionStatus) == true)) &&
                ((this.DayTimeRestrictionDescription == null && other.DayTimeRestrictionDescription == null) || (this.DayTimeRestrictionDescription?.Equals(other.DayTimeRestrictionDescription) == true)) &&
                ((this.ProductRestrictionStatus == null && other.ProductRestrictionStatus == null) || (this.ProductRestrictionStatus?.Equals(other.ProductRestrictionStatus) == true)) &&
                ((this.ProductRestrictionDescription == null && other.ProductRestrictionDescription == null) || (this.ProductRestrictionDescription?.Equals(other.ProductRestrictionDescription) == true)) &&
                ((this.LocationRestrictionStatus == null && other.LocationRestrictionStatus == null) || (this.LocationRestrictionStatus?.Equals(other.LocationRestrictionStatus) == true)) &&
                ((this.LocationRestrictionStatusDescription == null && other.LocationRestrictionStatusDescription == null) || (this.LocationRestrictionStatusDescription?.Equals(other.LocationRestrictionStatusDescription) == true)) &&
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
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId)}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.UsageRestrictionStatus = {(this.UsageRestrictionStatus == null ? "null" : this.UsageRestrictionStatus)}");
            toStringOutput.Add($"this.UsageRestrictionDescription = {(this.UsageRestrictionDescription == null ? "null" : this.UsageRestrictionDescription)}");
            toStringOutput.Add($"this.DayTimeRestrictionStatus = {(this.DayTimeRestrictionStatus == null ? "null" : this.DayTimeRestrictionStatus)}");
            toStringOutput.Add($"this.DayTimeRestrictionDescription = {(this.DayTimeRestrictionDescription == null ? "null" : this.DayTimeRestrictionDescription)}");
            toStringOutput.Add($"this.ProductRestrictionStatus = {(this.ProductRestrictionStatus == null ? "null" : this.ProductRestrictionStatus)}");
            toStringOutput.Add($"this.ProductRestrictionDescription = {(this.ProductRestrictionDescription == null ? "null" : this.ProductRestrictionDescription)}");
            toStringOutput.Add($"this.LocationRestrictionStatus = {(this.LocationRestrictionStatus == null ? "null" : this.LocationRestrictionStatus)}");
            toStringOutput.Add($"this.LocationRestrictionStatusDescription = {(this.LocationRestrictionStatusDescription == null ? "null" : this.LocationRestrictionStatusDescription)}");
            toStringOutput.Add($"this.ValidationErrorCode = {(this.ValidationErrorCode == null ? "null" : this.ValidationErrorCode)}");
            toStringOutput.Add($"this.ValidationErrorDescription = {(this.ValidationErrorDescription == null ? "null" : this.ValidationErrorDescription)}");
        }
    }
}
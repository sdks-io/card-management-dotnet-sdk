// <copyright file="UpdateCardRenewalAddress2.cs" company="APIMatic">
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
    /// UpdateCardRenewalAddress2.
    /// </summary>
    public class UpdateCardRenewalAddress2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardRenewalAddress2"/> class.
        /// </summary>
        public UpdateCardRenewalAddress2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardRenewalAddress2"/> class.
        /// </summary>
        /// <param name="contactName">ContactName.</param>
        /// <param name="companyName">CompanyName.</param>
        /// <param name="addressLine">AddressLine.</param>
        /// <param name="zipCode">ZipCode.</param>
        /// <param name="countryID">CountryID.</param>
        /// <param name="contactTitle">ContactTitle.</param>
        /// <param name="city">City.</param>
        /// <param name="regionID">RegionID.</param>
        /// <param name="emailAddress">EmailAddress.</param>
        /// <param name="phoneNumber">PhoneNumber.</param>
        public UpdateCardRenewalAddress2(
            string contactName,
            string companyName,
            string addressLine,
            string zipCode,
            int countryID,
            string contactTitle = null,
            string city = null,
            int? regionID = null,
            string emailAddress = null,
            string phoneNumber = null)
        {
            this.ContactName = contactName;
            this.ContactTitle = contactTitle;
            this.CompanyName = companyName;
            this.AddressLine = addressLine;
            this.ZipCode = zipCode;
            this.City = city;
            this.RegionID = regionID;
            this.CountryID = countryID;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Contact name
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// Max Length: 50
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// Title
        /// Max Length: 50
        /// </summary>
        [JsonProperty("ContactTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactTitle { get; set; }

        /// <summary>
        /// Company name.
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// Max Length: 50
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Address line 1,2 and 3
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// Max Length: 128
        /// Note: -Each address line should be separated by “\r\n”.
        /// </summary>
        [JsonProperty("AddressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// ZipCode
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// Max Length: 10
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// City
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// Max Length: 40
        /// </summary>
        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Region id of card.
        /// </summary>
        [JsonProperty("RegionID", NullValueHandling = NullValueHandling.Ignore)]
        public int? RegionID { get; set; }

        /// <summary>
        /// Country ID
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// </summary>
        [JsonProperty("CountryID")]
        public int CountryID { get; set; }

        /// <summary>
        /// Email Address
        /// Max Length: 90
        /// Note: -
        /// Based on the international standard that there can be
        /// •    Max Length 64 before the @ (the 'Local part’) =64(minimum of 1)
        /// •    Max Lenth after the (the domain) = 88 (Minimum of 2)
        /// </summary>
        [JsonProperty("EmailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Phone number
        /// Optional
        /// Max Length: 16
        /// </summary>
        [JsonProperty("PhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardRenewalAddress2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardRenewalAddress2 other &&
                (this.ContactName == null && other.ContactName == null ||
                 this.ContactName?.Equals(other.ContactName) == true) &&
                (this.ContactTitle == null && other.ContactTitle == null ||
                 this.ContactTitle?.Equals(other.ContactTitle) == true) &&
                (this.CompanyName == null && other.CompanyName == null ||
                 this.CompanyName?.Equals(other.CompanyName) == true) &&
                (this.AddressLine == null && other.AddressLine == null ||
                 this.AddressLine?.Equals(other.AddressLine) == true) &&
                (this.ZipCode == null && other.ZipCode == null ||
                 this.ZipCode?.Equals(other.ZipCode) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.RegionID == null && other.RegionID == null ||
                 this.RegionID?.Equals(other.RegionID) == true) &&
                (this.CountryID.Equals(other.CountryID)) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContactName = {this.ContactName ?? "null"}");
            toStringOutput.Add($"this.ContactTitle = {this.ContactTitle ?? "null"}");
            toStringOutput.Add($"this.CompanyName = {this.CompanyName ?? "null"}");
            toStringOutput.Add($"this.AddressLine = {this.AddressLine ?? "null"}");
            toStringOutput.Add($"this.ZipCode = {this.ZipCode ?? "null"}");
            toStringOutput.Add($"this.City = {this.City ?? "null"}");
            toStringOutput.Add($"this.RegionID = {(this.RegionID == null ? "null" : this.RegionID.ToString())}");
            toStringOutput.Add($"this.CountryID = {this.CountryID}");
            toStringOutput.Add($"this.EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"this.PhoneNumber = {this.PhoneNumber ?? "null"}");
        }
    }
}
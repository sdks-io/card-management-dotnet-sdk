// <copyright file="PINDeliveryDetails.cs" company="APIMatic">
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
    /// PINDeliveryDetails.
    /// </summary>
    public class PINDeliveryDetails
    {
        private string contactName;
        private string contactTitle;
        private int? regionID;
        private int? countryID;
        private string phoneNumber;
        private string emailAddress;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ContactName", false },
            { "ContactTitle", false },
            { "RegionID", false },
            { "CountryID", false },
            { "PhoneNumber", false },
            { "EmailAddress", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PINDeliveryDetails"/> class.
        /// </summary>
        public PINDeliveryDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINDeliveryDetails"/> class.
        /// </summary>
        /// <param name="companyName">CompanyName.</param>
        /// <param name="addressLine">AddressLine.</param>
        /// <param name="city">City.</param>
        /// <param name="contactName">ContactName.</param>
        /// <param name="contactTitle">ContactTitle.</param>
        /// <param name="zipCode">ZipCode.</param>
        /// <param name="regionID">RegionID.</param>
        /// <param name="countryID">CountryID.</param>
        /// <param name="phoneNumber">PhoneNumber.</param>
        /// <param name="emailAddress">EmailAddress.</param>
        /// <param name="savePINReminder">SavePINReminder.</param>
        public PINDeliveryDetails(
            string companyName,
            string addressLine,
            string city,
            string contactName = null,
            string contactTitle = null,
            string zipCode = null,
            int? regionID = null,
            int? countryID = null,
            string phoneNumber = null,
            string emailAddress = null,
            bool? savePINReminder = null)
        {

            if (contactName != null)
            {
                this.ContactName = contactName;
            }

            if (contactTitle != null)
            {
                this.ContactTitle = contactTitle;
            }
            this.CompanyName = companyName;
            this.AddressLine = addressLine;
            this.ZipCode = zipCode;
            this.City = city;

            if (regionID != null)
            {
                this.RegionID = regionID;
            }

            if (countryID != null)
            {
                this.CountryID = countryID;
            }

            if (phoneNumber != null)
            {
                this.PhoneNumber = phoneNumber;
            }

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }
            this.SavePINReminder = savePINReminder;
        }

        /// <summary>
        /// Contact Name
        /// Max Length: 50
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName
        {
            get
            {
                return this.contactName;
            }

            set
            {
                this.shouldSerialize["ContactName"] = true;
                this.contactName = value;
            }
        }

        /// <summary>
        /// Contact Title
        /// Max Length: 50
        /// </summary>
        [JsonProperty("ContactTitle")]
        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }

            set
            {
                this.shouldSerialize["ContactTitle"] = true;
                this.contactTitle = value;
            }
        }

        /// <summary>
        /// Company Name for PIN delivery.
        /// Max Length: 50
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Address Lines
        /// Max Length: 1024
        /// </summary>
        [JsonProperty("AddressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Zip Code
        /// Max Length: 10
        /// </summary>
        [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Include)]
        public string ZipCode { get; set; }

        /// <summary>
        /// City
        /// Max Length: 40
        /// </summary>
        [JsonProperty("City")]
        public string City { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("RegionID")]
        public int? RegionID
        {
            get
            {
                return this.regionID;
            }

            set
            {
                this.shouldSerialize["RegionID"] = true;
                this.regionID = value;
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("CountryID")]
        public int? CountryID
        {
            get
            {
                return this.countryID;
            }

            set
            {
                this.shouldSerialize["CountryID"] = true;
                this.countryID = value;
            }
        }

        /// <summary>
        /// Cardholder phone number for PIN delivery.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.shouldSerialize["PhoneNumber"] = true;
                this.phoneNumber = value;
            }
        }

        /// <summary>
        /// Cardholder email address for PIN delivery
        /// Max Length : 90
        /// Example: xxxxxx@example.com <br/>Note:Based on the international standard that there can be Max Length 64 before the @ (the 'Local part’) =64(minimum of 1) Max Lenth after the (the domain) = 88 (Minimum of 2)
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }

            set
            {
                this.shouldSerialize["EmailAddress"] = true;
                this.emailAddress = value;
            }
        }

        /// <summary>
        /// Save PIN Reminder
        /// If SavePINReminder is true, the contact address will be saved database for PIN reminder.
        ///  <br/>Only allowed for PIN Advice paper delivery.
        /// </summary>
        [JsonProperty("SavePINReminder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SavePINReminder { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PINDeliveryDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetContactName()
        {
            this.shouldSerialize["ContactName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetContactTitle()
        {
            this.shouldSerialize["ContactTitle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRegionID()
        {
            this.shouldSerialize["RegionID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountryID()
        {
            this.shouldSerialize["CountryID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPhoneNumber()
        {
            this.shouldSerialize["PhoneNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmailAddress()
        {
            this.shouldSerialize["EmailAddress"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactName()
        {
            return this.shouldSerialize["ContactName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactTitle()
        {
            return this.shouldSerialize["ContactTitle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegionID()
        {
            return this.shouldSerialize["RegionID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryID()
        {
            return this.shouldSerialize["CountryID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePhoneNumber()
        {
            return this.shouldSerialize["PhoneNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmailAddress()
        {
            return this.shouldSerialize["EmailAddress"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PINDeliveryDetails other &&
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
                (this.CountryID == null && other.CountryID == null ||
                 this.CountryID?.Equals(other.CountryID) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.SavePINReminder == null && other.SavePINReminder == null ||
                 this.SavePINReminder?.Equals(other.SavePINReminder) == true);
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
            toStringOutput.Add($"this.CountryID = {(this.CountryID == null ? "null" : this.CountryID.ToString())}");
            toStringOutput.Add($"this.PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"this.EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"this.SavePINReminder = {(this.SavePINReminder == null ? "null" : this.SavePINReminder.ToString())}");
        }
    }
}
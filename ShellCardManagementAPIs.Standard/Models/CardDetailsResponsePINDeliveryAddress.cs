// <copyright file="CardDetailsResponsePINDeliveryAddress.cs" company="APIMatic">
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
    /// CardDetailsResponsePINDeliveryAddress.
    /// </summary>
    public class CardDetailsResponsePINDeliveryAddress
    {
        private string contactForeName;
        private string contactMiddleName;
        private string contactLastName;
        private string contactTitle;
        private int? regionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ContactForeName", false },
            { "ContactMiddleName", false },
            { "ContactLastName", false },
            { "ContactTitle", false },
            { "RegionId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponsePINDeliveryAddress"/> class.
        /// </summary>
        public CardDetailsResponsePINDeliveryAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponsePINDeliveryAddress"/> class.
        /// </summary>
        /// <param name="companyName">CompanyName.</param>
        /// <param name="addressId">AddressId.</param>
        /// <param name="addressLine1">AddressLine1.</param>
        /// <param name="zipCode">ZipCode.</param>
        /// <param name="countryId">CountryId.</param>
        /// <param name="countryISOCode">CountryISOCode.</param>
        /// <param name="country">Country.</param>
        /// <param name="contactForeName">ContactForeName.</param>
        /// <param name="contactMiddleName">ContactMiddleName.</param>
        /// <param name="contactLastName">ContactLastName.</param>
        /// <param name="contactTitle">ContactTitle.</param>
        /// <param name="addressLine2">AddressLine2.</param>
        /// <param name="addressLine3">AddressLine3.</param>
        /// <param name="city">City.</param>
        /// <param name="regionId">RegionId.</param>
        /// <param name="region">Region.</param>
        public CardDetailsResponsePINDeliveryAddress(
            string companyName,
            int addressId,
            string addressLine1,
            string zipCode,
            int countryId,
            string countryISOCode,
            string country,
            string contactForeName = null,
            string contactMiddleName = null,
            string contactLastName = null,
            string contactTitle = null,
            string addressLine2 = null,
            string addressLine3 = null,
            string city = null,
            int? regionId = null,
            string region = null)
        {

            if (contactForeName != null)
            {
                this.ContactForeName = contactForeName;
            }

            if (contactMiddleName != null)
            {
                this.ContactMiddleName = contactMiddleName;
            }

            if (contactLastName != null)
            {
                this.ContactLastName = contactLastName;
            }

            if (contactTitle != null)
            {
                this.ContactTitle = contactTitle;
            }
            this.CompanyName = companyName;
            this.AddressId = addressId;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.ZipCode = zipCode;
            this.City = city;

            if (regionId != null)
            {
                this.RegionId = regionId;
            }
            this.Region = region;
            this.CountryId = countryId;
            this.CountryISOCode = countryISOCode;
            this.Country = country;
        }

        /// <summary>
        /// Fore name of the contact person
        /// </summary>
        [JsonProperty("ContactForeName")]
        public string ContactForeName
        {
            get
            {
                return this.contactForeName;
            }

            set
            {
                this.shouldSerialize["ContactForeName"] = true;
                this.contactForeName = value;
            }
        }

        /// <summary>
        /// Middle name of the contact person
        /// </summary>
        [JsonProperty("ContactMiddleName")]
        public string ContactMiddleName
        {
            get
            {
                return this.contactMiddleName;
            }

            set
            {
                this.shouldSerialize["ContactMiddleName"] = true;
                this.contactMiddleName = value;
            }
        }

        /// <summary>
        /// Last name of the contact person
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName
        {
            get
            {
                return this.contactLastName;
            }

            set
            {
                this.shouldSerialize["ContactLastName"] = true;
                this.contactLastName = value;
            }
        }

        /// <summary>
        /// Title of the contact person Optional Max field length- 10 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
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
        /// Company name Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. True, Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Address Id in cards platform.
        /// </summary>
        [JsonProperty("AddressId")]
        public int AddressId { get; set; }

        /// <summary>
        /// Address line 1 Mandatory if IsNewDeliveryAddress and OrderReplacement are passed True. Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 Optional Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("AddressLine2", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address line Optional Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("AddressLine3", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// ZIP code Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. True, Max field length- 10 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// City Max field length- 40 Note- If the Shell Card Platform configuration is set to clear the personal details captured on card orders, this value will be cleared from the record after processing the request.
        /// </summary>
        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Region Id
        /// </summary>
        [JsonProperty("RegionId")]
        public int? RegionId
        {
            get
            {
                return this.regionId;
            }

            set
            {
                this.shouldSerialize["RegionId"] = true;
                this.regionId = value;
            }
        }

        /// <summary>
        /// Region Optional When region is passed, Shell Card Platform will look up for the region id for the given region.  If the option to clear personal details is set in the Shell Card Platform, then this value will be cleared from the record after processing the request .
        /// </summary>
        [JsonProperty("Region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Country Id in cards platform.
        /// </summary>
        [JsonProperty("CountryId")]
        public int CountryId { get; set; }

        /// <summary>
        /// The ISO code of the country. Mandatory if IsNewDeliveryAddress and OrderReplacement are passed. If the option to clear personal details is set in the Shell Card Platform, then this value will be cleared from the record after processing the request .
        /// </summary>
        [JsonProperty("CountryISOCode")]
        public string CountryISOCode { get; set; }

        /// <summary>
        /// Country name.
        /// </summary>
        [JsonProperty("Country")]
        public string Country { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardDetailsResponsePINDeliveryAddress : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetContactForeName()
        {
            this.shouldSerialize["ContactForeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetContactMiddleName()
        {
            this.shouldSerialize["ContactMiddleName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetContactLastName()
        {
            this.shouldSerialize["ContactLastName"] = false;
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
        public void UnsetRegionId()
        {
            this.shouldSerialize["RegionId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactForeName()
        {
            return this.shouldSerialize["ContactForeName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactMiddleName()
        {
            return this.shouldSerialize["ContactMiddleName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactLastName()
        {
            return this.shouldSerialize["ContactLastName"];
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
        public bool ShouldSerializeRegionId()
        {
            return this.shouldSerialize["RegionId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardDetailsResponsePINDeliveryAddress other &&
                (this.ContactForeName == null && other.ContactForeName == null ||
                 this.ContactForeName?.Equals(other.ContactForeName) == true) &&
                (this.ContactMiddleName == null && other.ContactMiddleName == null ||
                 this.ContactMiddleName?.Equals(other.ContactMiddleName) == true) &&
                (this.ContactLastName == null && other.ContactLastName == null ||
                 this.ContactLastName?.Equals(other.ContactLastName) == true) &&
                (this.ContactTitle == null && other.ContactTitle == null ||
                 this.ContactTitle?.Equals(other.ContactTitle) == true) &&
                (this.CompanyName == null && other.CompanyName == null ||
                 this.CompanyName?.Equals(other.CompanyName) == true) &&
                (this.AddressId.Equals(other.AddressId)) &&
                (this.AddressLine1 == null && other.AddressLine1 == null ||
                 this.AddressLine1?.Equals(other.AddressLine1) == true) &&
                (this.AddressLine2 == null && other.AddressLine2 == null ||
                 this.AddressLine2?.Equals(other.AddressLine2) == true) &&
                (this.AddressLine3 == null && other.AddressLine3 == null ||
                 this.AddressLine3?.Equals(other.AddressLine3) == true) &&
                (this.ZipCode == null && other.ZipCode == null ||
                 this.ZipCode?.Equals(other.ZipCode) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.RegionId == null && other.RegionId == null ||
                 this.RegionId?.Equals(other.RegionId) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.CountryId.Equals(other.CountryId)) &&
                (this.CountryISOCode == null && other.CountryISOCode == null ||
                 this.CountryISOCode?.Equals(other.CountryISOCode) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ContactForeName = {this.ContactForeName ?? "null"}");
            toStringOutput.Add($"ContactMiddleName = {this.ContactMiddleName ?? "null"}");
            toStringOutput.Add($"ContactLastName = {this.ContactLastName ?? "null"}");
            toStringOutput.Add($"ContactTitle = {this.ContactTitle ?? "null"}");
            toStringOutput.Add($"CompanyName = {this.CompanyName ?? "null"}");
            toStringOutput.Add($"AddressId = {this.AddressId}");
            toStringOutput.Add($"AddressLine1 = {this.AddressLine1 ?? "null"}");
            toStringOutput.Add($"AddressLine2 = {this.AddressLine2 ?? "null"}");
            toStringOutput.Add($"AddressLine3 = {this.AddressLine3 ?? "null"}");
            toStringOutput.Add($"ZipCode = {this.ZipCode ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"RegionId = {(this.RegionId == null ? "null" : this.RegionId.ToString())}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"CountryId = {this.CountryId}");
            toStringOutput.Add($"CountryISOCode = {this.CountryISOCode ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
        }
    }
}
// <copyright file="Address.cs" company="APIMatic">
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
    /// Address.
    /// </summary>
    public class Address
    {
        private int? addressId;
        private string addressLine1;
        private string addressLine2;
        private string addressLine3;
        private string zipCode;
        private string city;
        private int? regionId;
        private string countryISOCode;
        private string country;
        private string telephone;
        private string emailAddress;
        private string fax;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AddressId", false },
            { "AddressLine1", false },
            { "AddressLine2", false },
            { "AddressLine3", false },
            { "ZipCode", false },
            { "City", false },
            { "RegionId", false },
            { "CountryISOCode", false },
            { "Country", false },
            { "Telephone", false },
            { "EmailAddress", false },
            { "Fax", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="addressId">AddressId.</param>
        /// <param name="addressLine1">AddressLine1.</param>
        /// <param name="addressLine2">AddressLine2.</param>
        /// <param name="addressLine3">AddressLine3.</param>
        /// <param name="zipCode">ZipCode.</param>
        /// <param name="city">City.</param>
        /// <param name="regionId">RegionId.</param>
        /// <param name="countryISOCode">CountryISOCode.</param>
        /// <param name="country">Country.</param>
        /// <param name="telephone">Telephone.</param>
        /// <param name="emailAddress">EmailAddress.</param>
        /// <param name="fax">Fax.</param>
        public Address(
            int? addressId = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string addressLine3 = null,
            string zipCode = null,
            string city = null,
            int? regionId = null,
            string countryISOCode = null,
            string country = null,
            string telephone = null,
            string emailAddress = null,
            string fax = null)
        {

            if (addressId != null)
            {
                this.AddressId = addressId;
            }

            if (addressLine1 != null)
            {
                this.AddressLine1 = addressLine1;
            }

            if (addressLine2 != null)
            {
                this.AddressLine2 = addressLine2;
            }

            if (addressLine3 != null)
            {
                this.AddressLine3 = addressLine3;
            }

            if (zipCode != null)
            {
                this.ZipCode = zipCode;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (regionId != null)
            {
                this.RegionId = regionId;
            }

            if (countryISOCode != null)
            {
                this.CountryISOCode = countryISOCode;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (telephone != null)
            {
                this.Telephone = telephone;
            }

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }

            if (fax != null)
            {
                this.Fax = fax;
            }
        }

        /// <summary>
        /// Address Id in cards platform.
        /// </summary>
        [JsonProperty("AddressId")]
        public int? AddressId
        {
            get
            {
                return this.addressId;
            }

            set
            {
                this.shouldSerialize["AddressId"] = true;
                this.addressId = value;
            }
        }

        /// <summary>
        /// Address line1
        /// </summary>
        [JsonProperty("AddressLine1")]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }

            set
            {
                this.shouldSerialize["AddressLine1"] = true;
                this.addressLine1 = value;
            }
        }

        /// <summary>
        /// Address line2
        /// </summary>
        [JsonProperty("AddressLine2")]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }

            set
            {
                this.shouldSerialize["AddressLine2"] = true;
                this.addressLine2 = value;
            }
        }

        /// <summary>
        /// AddressLine3
        /// </summary>
        [JsonProperty("AddressLine3")]
        public string AddressLine3
        {
            get
            {
                return this.addressLine3;
            }

            set
            {
                this.shouldSerialize["AddressLine3"] = true;
                this.addressLine3 = value;
            }
        }

        /// <summary>
        /// ZipCode
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode
        {
            get
            {
                return this.zipCode;
            }

            set
            {
                this.shouldSerialize["ZipCode"] = true;
                this.zipCode = value;
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("City")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["City"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Region Id of the address.
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
        /// Country ISO code of the address
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
        /// Country for the address
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
        /// Telephone number of the address contact
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone
        {
            get
            {
                return this.telephone;
            }

            set
            {
                this.shouldSerialize["Telephone"] = true;
                this.telephone = value;
            }
        }

        /// <summary>
        /// Email address of the address contact
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
        /// Fax number of the address contact
        /// </summary>
        [JsonProperty("Fax")]
        public string Fax
        {
            get
            {
                return this.fax;
            }

            set
            {
                this.shouldSerialize["Fax"] = true;
                this.fax = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Address : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddressId()
        {
            this.shouldSerialize["AddressId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddressLine1()
        {
            this.shouldSerialize["AddressLine1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddressLine2()
        {
            this.shouldSerialize["AddressLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddressLine3()
        {
            this.shouldSerialize["AddressLine3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetZipCode()
        {
            this.shouldSerialize["ZipCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["City"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRegionId()
        {
            this.shouldSerialize["RegionId"] = false;
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
        public void UnsetTelephone()
        {
            this.shouldSerialize["Telephone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmailAddress()
        {
            this.shouldSerialize["EmailAddress"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFax()
        {
            this.shouldSerialize["Fax"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressId()
        {
            return this.shouldSerialize["AddressId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressLine1()
        {
            return this.shouldSerialize["AddressLine1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressLine2()
        {
            return this.shouldSerialize["AddressLine2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressLine3()
        {
            return this.shouldSerialize["AddressLine3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZipCode()
        {
            return this.shouldSerialize["ZipCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["City"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegionId()
        {
            return this.shouldSerialize["RegionId"];
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
        public bool ShouldSerializeTelephone()
        {
            return this.shouldSerialize["Telephone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmailAddress()
        {
            return this.shouldSerialize["EmailAddress"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFax()
        {
            return this.shouldSerialize["Fax"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Address other &&
                (this.AddressId == null && other.AddressId == null ||
                 this.AddressId?.Equals(other.AddressId) == true) &&
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
                (this.CountryISOCode == null && other.CountryISOCode == null ||
                 this.CountryISOCode?.Equals(other.CountryISOCode) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.Telephone == null && other.Telephone == null ||
                 this.Telephone?.Equals(other.Telephone) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.Fax == null && other.Fax == null ||
                 this.Fax?.Equals(other.Fax) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressId = {(this.AddressId == null ? "null" : this.AddressId.ToString())}");
            toStringOutput.Add($"this.AddressLine1 = {this.AddressLine1 ?? "null"}");
            toStringOutput.Add($"this.AddressLine2 = {this.AddressLine2 ?? "null"}");
            toStringOutput.Add($"this.AddressLine3 = {this.AddressLine3 ?? "null"}");
            toStringOutput.Add($"this.ZipCode = {this.ZipCode ?? "null"}");
            toStringOutput.Add($"this.City = {this.City ?? "null"}");
            toStringOutput.Add($"this.RegionId = {(this.RegionId == null ? "null" : this.RegionId.ToString())}");
            toStringOutput.Add($"this.CountryISOCode = {this.CountryISOCode ?? "null"}");
            toStringOutput.Add($"this.Country = {this.Country ?? "null"}");
            toStringOutput.Add($"this.Telephone = {this.Telephone ?? "null"}");
            toStringOutput.Add($"this.EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"this.Fax = {this.Fax ?? "null"}");
        }
    }
}
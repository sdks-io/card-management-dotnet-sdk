// <copyright file="DeliveryAddresses.cs" company="APIMatic">
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
    /// DeliveryAddresses.
    /// </summary>
    public class DeliveryAddresses
    {
        private int? addressId;
        private string addressLine1;
        private string addressLine2;
        private string addressLine3;
        private string city;
        private string companyName;
        private string contactForeName;
        private string contactLastName;
        private string contactMiddleName;
        private string contactTitle;
        private string country;
        private int? countryId;
        private string countryISOCode;
        private string fax;
        private string region;
        private int? regionId;
        private string telephone;
        private string zipCode;
        private int? addressType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AddressId", false },
            { "AddressLine1", false },
            { "AddressLine2", false },
            { "AddressLine3", false },
            { "City", false },
            { "CompanyName", false },
            { "ContactForeName", false },
            { "ContactLastName", false },
            { "ContactMiddleName", false },
            { "ContactTitle", false },
            { "Country", false },
            { "CountryId", false },
            { "CountryISOCode", false },
            { "Fax", false },
            { "Region", false },
            { "RegionId", false },
            { "Telephone", false },
            { "ZipCode", false },
            { "AddressType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddresses"/> class.
        /// </summary>
        public DeliveryAddresses()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddresses"/> class.
        /// </summary>
        /// <param name="addressId">AddressId.</param>
        /// <param name="addressLine1">AddressLine1.</param>
        /// <param name="addressLine2">AddressLine2.</param>
        /// <param name="addressLine3">AddressLine3.</param>
        /// <param name="city">City.</param>
        /// <param name="companyName">CompanyName.</param>
        /// <param name="contactForeName">ContactForeName.</param>
        /// <param name="contactLastName">ContactLastName.</param>
        /// <param name="contactMiddleName">ContactMiddleName.</param>
        /// <param name="contactTitle">ContactTitle.</param>
        /// <param name="country">Country.</param>
        /// <param name="countryId">CountryId.</param>
        /// <param name="countryISOCode">CountryISOCode.</param>
        /// <param name="fax">Fax.</param>
        /// <param name="region">Region.</param>
        /// <param name="regionId">RegionId.</param>
        /// <param name="telephone">Telephone.</param>
        /// <param name="zipCode">ZipCode.</param>
        /// <param name="addressType">AddressType.</param>
        public DeliveryAddresses(
            int? addressId = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string addressLine3 = null,
            string city = null,
            string companyName = null,
            string contactForeName = null,
            string contactLastName = null,
            string contactMiddleName = null,
            string contactTitle = null,
            string country = null,
            int? countryId = null,
            string countryISOCode = null,
            string fax = null,
            string region = null,
            int? regionId = null,
            string telephone = null,
            string zipCode = null,
            int? addressType = null)
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

            if (city != null)
            {
                this.City = city;
            }

            if (companyName != null)
            {
                this.CompanyName = companyName;
            }

            if (contactForeName != null)
            {
                this.ContactForeName = contactForeName;
            }

            if (contactLastName != null)
            {
                this.ContactLastName = contactLastName;
            }

            if (contactMiddleName != null)
            {
                this.ContactMiddleName = contactMiddleName;
            }

            if (contactTitle != null)
            {
                this.ContactTitle = contactTitle;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (countryId != null)
            {
                this.CountryId = countryId;
            }

            if (countryISOCode != null)
            {
                this.CountryISOCode = countryISOCode;
            }

            if (fax != null)
            {
                this.Fax = fax;
            }

            if (region != null)
            {
                this.Region = region;
            }

            if (regionId != null)
            {
                this.RegionId = regionId;
            }

            if (telephone != null)
            {
                this.Telephone = telephone;
            }

            if (zipCode != null)
            {
                this.ZipCode = zipCode;
            }

            if (addressType != null)
            {
                this.AddressType = addressType;
            }

        }

        /// <summary>
        /// Address Id
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
        /// AddressLine1
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
        /// AddressLine2
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
        /// Account Name
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                this.shouldSerialize["CompanyName"] = true;
                this.companyName = value;
            }
        }

        /// <summary>
        /// Contact fore name of the delivery address.
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
        /// Contact last name of the delivery address.
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
        /// Contact middle name of the delivery address.
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
        /// ContactTitle
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
        /// Country
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
        /// Country Id
        /// </summary>
        [JsonProperty("CountryId")]
        public int? CountryId
        {
            get
            {
                return this.countryId;
            }

            set
            {
                this.shouldSerialize["CountryId"] = true;
                this.countryId = value;
            }
        }

        /// <summary>
        /// Country ISO code
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
        /// Fax number of the address contact.
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

        /// <summary>
        /// Region of the Card Delivery address
        /// </summary>
        [JsonProperty("Region")]
        public string Region
        {
            get
            {
                return this.region;
            }

            set
            {
                this.shouldSerialize["Region"] = true;
                this.region = value;
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
        /// Delivery Zip code
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
        /// Delivery address type.
        /// Possible Values:
        /// 1 – Card and PIN delivery address
        /// 2 – Card delivery address
        /// 3 – PIN delivery address
        /// </summary>
        [JsonProperty("AddressType")]
        public int? AddressType
        {
            get
            {
                return this.addressType;
            }

            set
            {
                this.shouldSerialize["AddressType"] = true;
                this.addressType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeliveryAddresses : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressId()
        {
            this.shouldSerialize["AddressId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressLine1()
        {
            this.shouldSerialize["AddressLine1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressLine2()
        {
            this.shouldSerialize["AddressLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressLine3()
        {
            this.shouldSerialize["AddressLine3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["City"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompanyName()
        {
            this.shouldSerialize["CompanyName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactForeName()
        {
            this.shouldSerialize["ContactForeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactLastName()
        {
            this.shouldSerialize["ContactLastName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactMiddleName()
        {
            this.shouldSerialize["ContactMiddleName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactTitle()
        {
            this.shouldSerialize["ContactTitle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryId()
        {
            this.shouldSerialize["CountryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryISOCode()
        {
            this.shouldSerialize["CountryISOCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFax()
        {
            this.shouldSerialize["Fax"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegion()
        {
            this.shouldSerialize["Region"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegionId()
        {
            this.shouldSerialize["RegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTelephone()
        {
            this.shouldSerialize["Telephone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetZipCode()
        {
            this.shouldSerialize["ZipCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressType()
        {
            this.shouldSerialize["AddressType"] = false;
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
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["City"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompanyName()
        {
            return this.shouldSerialize["CompanyName"];
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
        public bool ShouldSerializeContactLastName()
        {
            return this.shouldSerialize["ContactLastName"];
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
        public bool ShouldSerializeContactTitle()
        {
            return this.shouldSerialize["ContactTitle"];
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
        public bool ShouldSerializeCountryId()
        {
            return this.shouldSerialize["CountryId"];
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
        public bool ShouldSerializeFax()
        {
            return this.shouldSerialize["Fax"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegion()
        {
            return this.shouldSerialize["Region"];
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
        public bool ShouldSerializeTelephone()
        {
            return this.shouldSerialize["Telephone"];
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
        public bool ShouldSerializeAddressType()
        {
            return this.shouldSerialize["AddressType"];
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
            return obj is DeliveryAddresses other &&                ((this.AddressId == null && other.AddressId == null) || (this.AddressId?.Equals(other.AddressId) == true)) &&
                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.AddressLine3 == null && other.AddressLine3 == null) || (this.AddressLine3?.Equals(other.AddressLine3) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
                ((this.ContactForeName == null && other.ContactForeName == null) || (this.ContactForeName?.Equals(other.ContactForeName) == true)) &&
                ((this.ContactLastName == null && other.ContactLastName == null) || (this.ContactLastName?.Equals(other.ContactLastName) == true)) &&
                ((this.ContactMiddleName == null && other.ContactMiddleName == null) || (this.ContactMiddleName?.Equals(other.ContactMiddleName) == true)) &&
                ((this.ContactTitle == null && other.ContactTitle == null) || (this.ContactTitle?.Equals(other.ContactTitle) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CountryId == null && other.CountryId == null) || (this.CountryId?.Equals(other.CountryId) == true)) &&
                ((this.CountryISOCode == null && other.CountryISOCode == null) || (this.CountryISOCode?.Equals(other.CountryISOCode) == true)) &&
                ((this.Fax == null && other.Fax == null) || (this.Fax?.Equals(other.Fax) == true)) &&
                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.RegionId == null && other.RegionId == null) || (this.RegionId?.Equals(other.RegionId) == true)) &&
                ((this.Telephone == null && other.Telephone == null) || (this.Telephone?.Equals(other.Telephone) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.AddressType == null && other.AddressType == null) || (this.AddressType?.Equals(other.AddressType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressId = {(this.AddressId == null ? "null" : this.AddressId.ToString())}");
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.AddressLine3 = {(this.AddressLine3 == null ? "null" : this.AddressLine3)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName)}");
            toStringOutput.Add($"this.ContactForeName = {(this.ContactForeName == null ? "null" : this.ContactForeName)}");
            toStringOutput.Add($"this.ContactLastName = {(this.ContactLastName == null ? "null" : this.ContactLastName)}");
            toStringOutput.Add($"this.ContactMiddleName = {(this.ContactMiddleName == null ? "null" : this.ContactMiddleName)}");
            toStringOutput.Add($"this.ContactTitle = {(this.ContactTitle == null ? "null" : this.ContactTitle)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CountryId = {(this.CountryId == null ? "null" : this.CountryId.ToString())}");
            toStringOutput.Add($"this.CountryISOCode = {(this.CountryISOCode == null ? "null" : this.CountryISOCode)}");
            toStringOutput.Add($"this.Fax = {(this.Fax == null ? "null" : this.Fax)}");
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region)}");
            toStringOutput.Add($"this.RegionId = {(this.RegionId == null ? "null" : this.RegionId.ToString())}");
            toStringOutput.Add($"this.Telephone = {(this.Telephone == null ? "null" : this.Telephone)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.AddressType = {(this.AddressType == null ? "null" : this.AddressType.ToString())}");
        }
    }
}
// <copyright file="CardContact.cs" company="APIMatic">
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
    /// CardContact.
    /// </summary>
    public class CardContact
    {
        private string deliveryContactTitle;
        private string deliveryAddressLine2;
        private string deliveryAddressLine3;
        private int? deliveryRegionId;
        private string deliveryRegion;
        private string phoneNumber;
        private string emailAddress;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DeliveryContactTitle", false },
            { "DeliveryAddressLine2", false },
            { "DeliveryAddressLine3", false },
            { "DeliveryRegionId", false },
            { "DeliveryRegion", false },
            { "PhoneNumber", false },
            { "EmailAddress", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardContact"/> class.
        /// </summary>
        public CardContact()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardContact"/> class.
        /// </summary>
        /// <param name="deliveryContactTitle">DeliveryContactTitle.</param>
        /// <param name="deliveryContactName">DeliveryContactName.</param>
        /// <param name="deliveryCompanyName">DeliveryCompanyName.</param>
        /// <param name="deliveryAddressLine1">DeliveryAddressLine1.</param>
        /// <param name="deliveryAddressLine2">DeliveryAddressLine2.</param>
        /// <param name="deliveryAddressLine3">DeliveryAddressLine3.</param>
        /// <param name="deliveryZipCode">DeliveryZipCode.</param>
        /// <param name="deliveryCity">DeliveryCity.</param>
        /// <param name="deliveryRegionId">DeliveryRegionId.</param>
        /// <param name="deliveryRegion">DeliveryRegion.</param>
        /// <param name="deliveryCountry">DeliveryCountry.</param>
        /// <param name="phoneNumber">PhoneNumber.</param>
        /// <param name="emailAddress">EmailAddress.</param>
        /// <param name="saveForCardReissue">SaveForCardReissue.</param>
        public CardContact(
            string deliveryContactTitle = null,
            string deliveryContactName = null,
            string deliveryCompanyName = null,
            string deliveryAddressLine1 = null,
            string deliveryAddressLine2 = null,
            string deliveryAddressLine3 = null,
            string deliveryZipCode = null,
            string deliveryCity = null,
            int? deliveryRegionId = null,
            string deliveryRegion = null,
            string deliveryCountry = null,
            string phoneNumber = null,
            string emailAddress = null,
            bool? saveForCardReissue = null)
        {

            if (deliveryContactTitle != null)
            {
                this.DeliveryContactTitle = deliveryContactTitle;
            }
            this.DeliveryContactName = deliveryContactName;
            this.DeliveryCompanyName = deliveryCompanyName;
            this.DeliveryAddressLine1 = deliveryAddressLine1;

            if (deliveryAddressLine2 != null)
            {
                this.DeliveryAddressLine2 = deliveryAddressLine2;
            }

            if (deliveryAddressLine3 != null)
            {
                this.DeliveryAddressLine3 = deliveryAddressLine3;
            }
            this.DeliveryZipCode = deliveryZipCode;
            this.DeliveryCity = deliveryCity;

            if (deliveryRegionId != null)
            {
                this.DeliveryRegionId = deliveryRegionId;
            }

            if (deliveryRegion != null)
            {
                this.DeliveryRegion = deliveryRegion;
            }
            this.DeliveryCountry = deliveryCountry;

            if (phoneNumber != null)
            {
                this.PhoneNumber = phoneNumber;
            }

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }
            this.SaveForCardReissue = saveForCardReissue;
        }

        /// <summary>
        /// Title of the contact person <br />
        /// Optional
        /// Max field length: 10
        /// </summary>
        [JsonProperty("DeliveryContactTitle")]
        public string DeliveryContactTitle
        {
            get
            {
                return this.deliveryContactTitle;
            }

            set
            {
                this.shouldSerialize["DeliveryContactTitle"] = true;
                this.deliveryContactTitle = value;
            }
        }

        /// <summary>
        /// Name of the contact person <br />
        /// Mandatory  <br />
        /// Max field length: 50
        /// </summary>
        [JsonProperty("DeliveryContactName", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryContactName { get; set; }

        /// <summary>
        /// Company name <br />
        /// Mandatory  <br />
        /// Max field length: 50
        /// </summary>
        [JsonProperty("DeliveryCompanyName", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryCompanyName { get; set; }

        /// <summary>
        /// Address line 1 <br />
        /// Mandatory<br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("DeliveryAddressLine1", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryAddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 <br />
        /// Optional <br />
        /// Max field length: 40  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryAddressLine2")]
        public string DeliveryAddressLine2
        {
            get
            {
                return this.deliveryAddressLine2;
            }

            set
            {
                this.shouldSerialize["DeliveryAddressLine2"] = true;
                this.deliveryAddressLine2 = value;
            }
        }

        /// <summary>
        /// Address line 3 <br />
        /// Optional <br />
        /// Max field length: 40  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryAddressLine3")]
        public string DeliveryAddressLine3
        {
            get
            {
                return this.deliveryAddressLine3;
            }

            set
            {
                this.shouldSerialize["DeliveryAddressLine3"] = true;
                this.deliveryAddressLine3 = value;
            }
        }

        /// <summary>
        /// ZIP code <br />
        /// Mandatory  <br />
        /// Max field length: 10  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryZipCode", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryZipCode { get; set; }

        /// <summary>
        /// City  <br />
        /// Mandatory  <br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("DeliveryCity", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryCity { get; set; }

        /// <summary>
        /// Region Id  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryRegionId")]
        public int? DeliveryRegionId
        {
            get
            {
                return this.deliveryRegionId;
            }

            set
            {
                this.shouldSerialize["DeliveryRegionId"] = true;
                this.deliveryRegionId = value;
            }
        }

        /// <summary>
        /// Region  <br />
        /// Optional<br />
        /// When region is passed
        /// </summary>
        [JsonProperty("DeliveryRegion")]
        public string DeliveryRegion
        {
            get
            {
                return this.deliveryRegion;
            }

            set
            {
                this.shouldSerialize["DeliveryRegion"] = true;
                this.deliveryRegion = value;
            }
        }

        /// <summary>
        /// The ISO code of the country.<br />
        /// </summary>
        [JsonProperty("DeliveryCountry", NullValueHandling = NullValueHandling.Include)]
        public string DeliveryCountry { get; set; }

        /// <summary>
        /// Phone number for courier delivery.<br />
        /// Optional.<br />
        /// Max field length: 20
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
        /// Email address for courier delivery.<br />
        /// Optional.<br />
        /// Max field length: 90 <br/>Note:Based on the international standard that there can be Max Length 64 before the @ (the 'Local part’) =64(minimum of 1) Max Lenth after the (the domain) = 88 (Minimum of 2)
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
        /// If this is specified, the contact address will be saved in cards platform for card reissue processing.<br />
        /// Optional
        /// </summary>
        [JsonProperty("SaveForCardReissue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SaveForCardReissue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardContact : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryContactTitle()
        {
            this.shouldSerialize["DeliveryContactTitle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryAddressLine2()
        {
            this.shouldSerialize["DeliveryAddressLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryAddressLine3()
        {
            this.shouldSerialize["DeliveryAddressLine3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryRegionId()
        {
            this.shouldSerialize["DeliveryRegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryRegion()
        {
            this.shouldSerialize["DeliveryRegion"] = false;
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
        public bool ShouldSerializeDeliveryContactTitle()
        {
            return this.shouldSerialize["DeliveryContactTitle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryAddressLine2()
        {
            return this.shouldSerialize["DeliveryAddressLine2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryAddressLine3()
        {
            return this.shouldSerialize["DeliveryAddressLine3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryRegionId()
        {
            return this.shouldSerialize["DeliveryRegionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryRegion()
        {
            return this.shouldSerialize["DeliveryRegion"];
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

            return obj is CardContact other &&
                (this.DeliveryContactTitle == null && other.DeliveryContactTitle == null ||
                 this.DeliveryContactTitle?.Equals(other.DeliveryContactTitle) == true) &&
                (this.DeliveryContactName == null && other.DeliveryContactName == null ||
                 this.DeliveryContactName?.Equals(other.DeliveryContactName) == true) &&
                (this.DeliveryCompanyName == null && other.DeliveryCompanyName == null ||
                 this.DeliveryCompanyName?.Equals(other.DeliveryCompanyName) == true) &&
                (this.DeliveryAddressLine1 == null && other.DeliveryAddressLine1 == null ||
                 this.DeliveryAddressLine1?.Equals(other.DeliveryAddressLine1) == true) &&
                (this.DeliveryAddressLine2 == null && other.DeliveryAddressLine2 == null ||
                 this.DeliveryAddressLine2?.Equals(other.DeliveryAddressLine2) == true) &&
                (this.DeliveryAddressLine3 == null && other.DeliveryAddressLine3 == null ||
                 this.DeliveryAddressLine3?.Equals(other.DeliveryAddressLine3) == true) &&
                (this.DeliveryZipCode == null && other.DeliveryZipCode == null ||
                 this.DeliveryZipCode?.Equals(other.DeliveryZipCode) == true) &&
                (this.DeliveryCity == null && other.DeliveryCity == null ||
                 this.DeliveryCity?.Equals(other.DeliveryCity) == true) &&
                (this.DeliveryRegionId == null && other.DeliveryRegionId == null ||
                 this.DeliveryRegionId?.Equals(other.DeliveryRegionId) == true) &&
                (this.DeliveryRegion == null && other.DeliveryRegion == null ||
                 this.DeliveryRegion?.Equals(other.DeliveryRegion) == true) &&
                (this.DeliveryCountry == null && other.DeliveryCountry == null ||
                 this.DeliveryCountry?.Equals(other.DeliveryCountry) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.SaveForCardReissue == null && other.SaveForCardReissue == null ||
                 this.SaveForCardReissue?.Equals(other.SaveForCardReissue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeliveryContactTitle = {this.DeliveryContactTitle ?? "null"}");
            toStringOutput.Add($"this.DeliveryContactName = {this.DeliveryContactName ?? "null"}");
            toStringOutput.Add($"this.DeliveryCompanyName = {this.DeliveryCompanyName ?? "null"}");
            toStringOutput.Add($"this.DeliveryAddressLine1 = {this.DeliveryAddressLine1 ?? "null"}");
            toStringOutput.Add($"this.DeliveryAddressLine2 = {this.DeliveryAddressLine2 ?? "null"}");
            toStringOutput.Add($"this.DeliveryAddressLine3 = {this.DeliveryAddressLine3 ?? "null"}");
            toStringOutput.Add($"this.DeliveryZipCode = {this.DeliveryZipCode ?? "null"}");
            toStringOutput.Add($"this.DeliveryCity = {this.DeliveryCity ?? "null"}");
            toStringOutput.Add($"this.DeliveryRegionId = {(this.DeliveryRegionId == null ? "null" : this.DeliveryRegionId.ToString())}");
            toStringOutput.Add($"this.DeliveryRegion = {this.DeliveryRegion ?? "null"}");
            toStringOutput.Add($"this.DeliveryCountry = {this.DeliveryCountry ?? "null"}");
            toStringOutput.Add($"this.PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"this.EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"this.SaveForCardReissue = {(this.SaveForCardReissue == null ? "null" : this.SaveForCardReissue.ToString())}");
        }
    }
}
// <copyright file="PINContact.cs" company="APIMatic">
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
    /// PINContact.
    /// </summary>
    public class PINContact
    {
        private string deliveryContactTitle;
        private string deliveryContactName;
        private string deliveryCompanyName;
        private string deliveryAddressLine1;
        private string deliveryAddressLine2;
        private string deliveryAddressLine3;
        private string deliveryZipCode;
        private string deliveryCity;
        private int? deliveryRegionId;
        private string deliveryRegion;
        private string deliveryCountry;
        private string phoneNumber;
        private string emailAddress;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DeliveryContactTitle", false },
            { "DeliveryContactName", false },
            { "DeliveryCompanyName", false },
            { "DeliveryAddressLine1", false },
            { "DeliveryAddressLine2", false },
            { "DeliveryAddressLine3", false },
            { "DeliveryZipCode", false },
            { "DeliveryCity", false },
            { "DeliveryRegionId", false },
            { "DeliveryRegion", false },
            { "DeliveryCountry", false },
            { "PhoneNumber", false },
            { "EmailAddress", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PINContact"/> class.
        /// </summary>
        public PINContact()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINContact"/> class.
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
        /// <param name="saveForPINReminder">SaveForPINReminder.</param>
        public PINContact(
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
            bool? saveForPINReminder = null)
        {
            if (deliveryContactTitle != null)
            {
                this.DeliveryContactTitle = deliveryContactTitle;
            }

            if (deliveryContactName != null)
            {
                this.DeliveryContactName = deliveryContactName;
            }

            if (deliveryCompanyName != null)
            {
                this.DeliveryCompanyName = deliveryCompanyName;
            }

            if (deliveryAddressLine1 != null)
            {
                this.DeliveryAddressLine1 = deliveryAddressLine1;
            }

            if (deliveryAddressLine2 != null)
            {
                this.DeliveryAddressLine2 = deliveryAddressLine2;
            }

            if (deliveryAddressLine3 != null)
            {
                this.DeliveryAddressLine3 = deliveryAddressLine3;
            }

            if (deliveryZipCode != null)
            {
                this.DeliveryZipCode = deliveryZipCode;
            }

            if (deliveryCity != null)
            {
                this.DeliveryCity = deliveryCity;
            }

            if (deliveryRegionId != null)
            {
                this.DeliveryRegionId = deliveryRegionId;
            }

            if (deliveryRegion != null)
            {
                this.DeliveryRegion = deliveryRegion;
            }

            if (deliveryCountry != null)
            {
                this.DeliveryCountry = deliveryCountry;
            }

            if (phoneNumber != null)
            {
                this.PhoneNumber = phoneNumber;
            }

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }

            this.SaveForPINReminder = saveForPINReminder;
        }

        /// <summary>
        /// Title of the contact person <br />
        /// Optional
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
        /// Mandatory - If PINAdviceType is paper else optional. <br />
        /// Max field length: 50  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryContactName")]
        public string DeliveryContactName
        {
            get
            {
                return this.deliveryContactName;
            }

            set
            {
                this.shouldSerialize["DeliveryContactName"] = true;
                this.deliveryContactName = value;
            }
        }

        /// <summary>
        /// Company name <br />
        /// Mandatory - If PINAdviceType is paper else optional. <br />
        /// Max field length: 50  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryCompanyName")]
        public string DeliveryCompanyName
        {
            get
            {
                return this.deliveryCompanyName;
            }

            set
            {
                this.shouldSerialize["DeliveryCompanyName"] = true;
                this.deliveryCompanyName = value;
            }
        }

        /// <summary>
        /// Address line 1 <br />
        /// Mandatory - if PINAdviceType is paper else optional.<br />
        /// Max field length: 40  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryAddressLine1")]
        public string DeliveryAddressLine1
        {
            get
            {
                return this.deliveryAddressLine1;
            }

            set
            {
                this.shouldSerialize["DeliveryAddressLine1"] = true;
                this.deliveryAddressLine1 = value;
            }
        }

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
        /// Mandatory - if PINAdviceType is paper else optional. <br />
        /// Max field length: 10  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryZipCode")]
        public string DeliveryZipCode
        {
            get
            {
                return this.deliveryZipCode;
            }

            set
            {
                this.shouldSerialize["DeliveryZipCode"] = true;
                this.deliveryZipCode = value;
            }
        }

        /// <summary>
        /// City  <br />
        /// Mandatory - If PINAdviceType is paper else optional. <br />
        /// Max field length: 40  <br />
        /// Optional
        /// </summary>
        [JsonProperty("DeliveryCity")]
        public string DeliveryCity
        {
            get
            {
                return this.deliveryCity;
            }

            set
            {
                this.shouldSerialize["DeliveryCity"] = true;
                this.deliveryCity = value;
            }
        }

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
        /// Mandatory if PINAdviceType is paper else optional.
        /// </summary>
        [JsonProperty("DeliveryCountry")]
        public string DeliveryCountry
        {
            get
            {
                return this.deliveryCountry;
            }

            set
            {
                this.shouldSerialize["DeliveryCountry"] = true;
                this.deliveryCountry = value;
            }
        }

        /// <summary>
        /// Phone number for to send SMS of the PIN in case PINAdviceType is SMS.<br />
        /// Mandatory if PINAdviceType is SMS else optional.<br />
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
        /// Email address for to send email of the PIN in case PINAdviceType is Email.<br />
        /// Mandatory if PINAdviceType is email else optional.<br />
        /// Max field length: 90. <br/>Note:Based on the international standard that there can be Max Length 64 before the @ (the 'Local part’) =64(minimum of 1) Max Lenth after the (the domain) = 88 (Minimum of 2)
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
        /// The given address will be used for sending PIN reminders in future when requested.<br />
        /// Only allowed for paper delivery<br />
        /// Optional
        /// </summary>
        [JsonProperty("SaveForPINReminder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SaveForPINReminder { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PINContact : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryContactTitle()
        {
            this.shouldSerialize["DeliveryContactTitle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryContactName()
        {
            this.shouldSerialize["DeliveryContactName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryCompanyName()
        {
            this.shouldSerialize["DeliveryCompanyName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryAddressLine1()
        {
            this.shouldSerialize["DeliveryAddressLine1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryAddressLine2()
        {
            this.shouldSerialize["DeliveryAddressLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryAddressLine3()
        {
            this.shouldSerialize["DeliveryAddressLine3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryZipCode()
        {
            this.shouldSerialize["DeliveryZipCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryCity()
        {
            this.shouldSerialize["DeliveryCity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryRegionId()
        {
            this.shouldSerialize["DeliveryRegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryRegion()
        {
            this.shouldSerialize["DeliveryRegion"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeliveryCountry()
        {
            this.shouldSerialize["DeliveryCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPhoneNumber()
        {
            this.shouldSerialize["PhoneNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
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
        public bool ShouldSerializeDeliveryContactName()
        {
            return this.shouldSerialize["DeliveryContactName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryCompanyName()
        {
            return this.shouldSerialize["DeliveryCompanyName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryAddressLine1()
        {
            return this.shouldSerialize["DeliveryAddressLine1"];
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
        public bool ShouldSerializeDeliveryZipCode()
        {
            return this.shouldSerialize["DeliveryZipCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeliveryCity()
        {
            return this.shouldSerialize["DeliveryCity"];
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
        public bool ShouldSerializeDeliveryCountry()
        {
            return this.shouldSerialize["DeliveryCountry"];
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PINContact other &&                ((this.DeliveryContactTitle == null && other.DeliveryContactTitle == null) || (this.DeliveryContactTitle?.Equals(other.DeliveryContactTitle) == true)) &&
                ((this.DeliveryContactName == null && other.DeliveryContactName == null) || (this.DeliveryContactName?.Equals(other.DeliveryContactName) == true)) &&
                ((this.DeliveryCompanyName == null && other.DeliveryCompanyName == null) || (this.DeliveryCompanyName?.Equals(other.DeliveryCompanyName) == true)) &&
                ((this.DeliveryAddressLine1 == null && other.DeliveryAddressLine1 == null) || (this.DeliveryAddressLine1?.Equals(other.DeliveryAddressLine1) == true)) &&
                ((this.DeliveryAddressLine2 == null && other.DeliveryAddressLine2 == null) || (this.DeliveryAddressLine2?.Equals(other.DeliveryAddressLine2) == true)) &&
                ((this.DeliveryAddressLine3 == null && other.DeliveryAddressLine3 == null) || (this.DeliveryAddressLine3?.Equals(other.DeliveryAddressLine3) == true)) &&
                ((this.DeliveryZipCode == null && other.DeliveryZipCode == null) || (this.DeliveryZipCode?.Equals(other.DeliveryZipCode) == true)) &&
                ((this.DeliveryCity == null && other.DeliveryCity == null) || (this.DeliveryCity?.Equals(other.DeliveryCity) == true)) &&
                ((this.DeliveryRegionId == null && other.DeliveryRegionId == null) || (this.DeliveryRegionId?.Equals(other.DeliveryRegionId) == true)) &&
                ((this.DeliveryRegion == null && other.DeliveryRegion == null) || (this.DeliveryRegion?.Equals(other.DeliveryRegion) == true)) &&
                ((this.DeliveryCountry == null && other.DeliveryCountry == null) || (this.DeliveryCountry?.Equals(other.DeliveryCountry) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.SaveForPINReminder == null && other.SaveForPINReminder == null) || (this.SaveForPINReminder?.Equals(other.SaveForPINReminder) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeliveryContactTitle = {(this.DeliveryContactTitle == null ? "null" : this.DeliveryContactTitle)}");
            toStringOutput.Add($"this.DeliveryContactName = {(this.DeliveryContactName == null ? "null" : this.DeliveryContactName)}");
            toStringOutput.Add($"this.DeliveryCompanyName = {(this.DeliveryCompanyName == null ? "null" : this.DeliveryCompanyName)}");
            toStringOutput.Add($"this.DeliveryAddressLine1 = {(this.DeliveryAddressLine1 == null ? "null" : this.DeliveryAddressLine1)}");
            toStringOutput.Add($"this.DeliveryAddressLine2 = {(this.DeliveryAddressLine2 == null ? "null" : this.DeliveryAddressLine2)}");
            toStringOutput.Add($"this.DeliveryAddressLine3 = {(this.DeliveryAddressLine3 == null ? "null" : this.DeliveryAddressLine3)}");
            toStringOutput.Add($"this.DeliveryZipCode = {(this.DeliveryZipCode == null ? "null" : this.DeliveryZipCode)}");
            toStringOutput.Add($"this.DeliveryCity = {(this.DeliveryCity == null ? "null" : this.DeliveryCity)}");
            toStringOutput.Add($"this.DeliveryRegionId = {(this.DeliveryRegionId == null ? "null" : this.DeliveryRegionId.ToString())}");
            toStringOutput.Add($"this.DeliveryRegion = {(this.DeliveryRegion == null ? "null" : this.DeliveryRegion)}");
            toStringOutput.Add($"this.DeliveryCountry = {(this.DeliveryCountry == null ? "null" : this.DeliveryCountry)}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.SaveForPINReminder = {(this.SaveForPINReminder == null ? "null" : this.SaveForPINReminder.ToString())}");
        }
    }
}
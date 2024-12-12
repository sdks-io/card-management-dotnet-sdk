// <copyright file="CardSettings.cs" company="APIMatic">
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
    /// CardSettings.
    /// </summary>
    public class CardSettings
    {
        private string selfSelectedEncryptedPIN;
        private string selfSelectedPINKeyID;
        private string selfSelectedPINSessionKey;
        private int? cardGroupId;
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
        private int? deliveryCountryId;
        private string emailAddress;
        private int? pINDeliveryAddressType;
        private int? pINAdviceType;
        private string pINDeliveryContactTitle;
        private string pINDeliveryContactName;
        private string pINDeliveryCompanyName;
        private string pINDeliveryAddressLine1;
        private string pINDeliveryAddressLine2;
        private string pINDeliveryAddressLine3;
        private string pINDeliveryZipCode;
        private string pINDeliveryCity;
        private int? pINDeliveryRegionId;
        private string pINDeliveryRegion;
        private string pINDeliveryCountry;
        private int? pINDeliveryCountryId;
        private string pINPhoneNumber;
        private string pINEmailAddress;
        private string expiryDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "SelfSelectedEncryptedPIN", false },
            { "SelfSelectedPINKeyID", false },
            { "SelfSelectedPINSessionKey", false },
            { "CardGroupId", false },
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
            { "DeliveryCountryId", false },
            { "EmailAddress", false },
            { "PINDeliveryAddressType", false },
            { "PINAdviceType", false },
            { "PINDeliveryContactTitle", false },
            { "PINDeliveryContactName", false },
            { "PINDeliveryCompanyName", false },
            { "PINDeliveryAddressLine1", false },
            { "PINDeliveryAddressLine2", false },
            { "PINDeliveryAddressLine3", false },
            { "PINDeliveryZipCode", false },
            { "PINDeliveryCity", false },
            { "PINDeliveryRegionId", false },
            { "PINDeliveryRegion", false },
            { "PINDeliveryCountry", false },
            { "PINDeliveryCountryId", false },
            { "PINPhoneNumber", false },
            { "PINEmailAddress", false },
            { "ExpiryDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSettings"/> class.
        /// </summary>
        public CardSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSettings"/> class.
        /// </summary>
        /// <param name="selfSelectedEncryptedPIN">SelfSelectedEncryptedPIN.</param>
        /// <param name="selfSelectedPINKeyID">SelfSelectedPINKeyID.</param>
        /// <param name="selfSelectedPINSessionKey">SelfSelectedPINSessionKey.</param>
        /// <param name="validateFleetId">ValidateFleetId.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardDeliveryType">CardDeliveryType.</param>
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
        /// <param name="deliveryCountryId">DeliveryCountryId.</param>
        /// <param name="phoneNumber">PhoneNumber.</param>
        /// <param name="emailAddress">EmailAddress.</param>
        /// <param name="pINDeliveryAddressType">PINDeliveryAddressType.</param>
        /// <param name="pINAdviceType">PINAdviceType.</param>
        /// <param name="pINDeliveryContactTitle">PINDeliveryContactTitle.</param>
        /// <param name="pINDeliveryContactName">PINDeliveryContactName.</param>
        /// <param name="pINDeliveryCompanyName">PINDeliveryCompanyName.</param>
        /// <param name="pINDeliveryAddressLine1">PINDeliveryAddressLine1.</param>
        /// <param name="pINDeliveryAddressLine2">PINDeliveryAddressLine2.</param>
        /// <param name="pINDeliveryAddressLine3">PINDeliveryAddressLine3.</param>
        /// <param name="pINDeliveryZipCode">PINDeliveryZipCode.</param>
        /// <param name="pINDeliveryCity">PINDeliveryCity.</param>
        /// <param name="pINDeliveryRegionId">PINDeliveryRegionId.</param>
        /// <param name="pINDeliveryRegion">PINDeliveryRegion.</param>
        /// <param name="pINDeliveryCountry">PINDeliveryCountry.</param>
        /// <param name="pINDeliveryCountryId">PINDeliveryCountryId.</param>
        /// <param name="pINPhoneNumber">PINPhoneNumber.</param>
        /// <param name="pINEmailAddress">PINEmailAddress.</param>
        /// <param name="saveForPINReminder">SaveForPINReminder.</param>
        /// <param name="saveForCardReissue">SaveForCardReissue.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        public CardSettings(
            string selfSelectedEncryptedPIN = null,
            string selfSelectedPINKeyID = null,
            string selfSelectedPINSessionKey = null,
            bool? validateFleetId = null,
            int? cardGroupId = null,
            int? cardDeliveryType = null,
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
            int? deliveryCountryId = null,
            string phoneNumber = null,
            string emailAddress = null,
            int? pINDeliveryAddressType = null,
            int? pINAdviceType = null,
            string pINDeliveryContactTitle = null,
            string pINDeliveryContactName = null,
            string pINDeliveryCompanyName = null,
            string pINDeliveryAddressLine1 = null,
            string pINDeliveryAddressLine2 = null,
            string pINDeliveryAddressLine3 = null,
            string pINDeliveryZipCode = null,
            string pINDeliveryCity = null,
            int? pINDeliveryRegionId = null,
            string pINDeliveryRegion = null,
            string pINDeliveryCountry = null,
            int? pINDeliveryCountryId = null,
            string pINPhoneNumber = null,
            string pINEmailAddress = null,
            bool? saveForPINReminder = null,
            bool? saveForCardReissue = null,
            string expiryDate = null)
        {

            if (selfSelectedEncryptedPIN != null)
            {
                this.SelfSelectedEncryptedPIN = selfSelectedEncryptedPIN;
            }

            if (selfSelectedPINKeyID != null)
            {
                this.SelfSelectedPINKeyID = selfSelectedPINKeyID;
            }

            if (selfSelectedPINSessionKey != null)
            {
                this.SelfSelectedPINSessionKey = selfSelectedPINSessionKey;
            }
            this.ValidateFleetId = validateFleetId;

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }
            this.CardDeliveryType = cardDeliveryType;

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

            if (deliveryCountryId != null)
            {
                this.DeliveryCountryId = deliveryCountryId;
            }
            this.PhoneNumber = phoneNumber;

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }

            if (pINDeliveryAddressType != null)
            {
                this.PINDeliveryAddressType = pINDeliveryAddressType;
            }

            if (pINAdviceType != null)
            {
                this.PINAdviceType = pINAdviceType;
            }

            if (pINDeliveryContactTitle != null)
            {
                this.PINDeliveryContactTitle = pINDeliveryContactTitle;
            }

            if (pINDeliveryContactName != null)
            {
                this.PINDeliveryContactName = pINDeliveryContactName;
            }

            if (pINDeliveryCompanyName != null)
            {
                this.PINDeliveryCompanyName = pINDeliveryCompanyName;
            }

            if (pINDeliveryAddressLine1 != null)
            {
                this.PINDeliveryAddressLine1 = pINDeliveryAddressLine1;
            }

            if (pINDeliveryAddressLine2 != null)
            {
                this.PINDeliveryAddressLine2 = pINDeliveryAddressLine2;
            }

            if (pINDeliveryAddressLine3 != null)
            {
                this.PINDeliveryAddressLine3 = pINDeliveryAddressLine3;
            }

            if (pINDeliveryZipCode != null)
            {
                this.PINDeliveryZipCode = pINDeliveryZipCode;
            }

            if (pINDeliveryCity != null)
            {
                this.PINDeliveryCity = pINDeliveryCity;
            }

            if (pINDeliveryRegionId != null)
            {
                this.PINDeliveryRegionId = pINDeliveryRegionId;
            }

            if (pINDeliveryRegion != null)
            {
                this.PINDeliveryRegion = pINDeliveryRegion;
            }

            if (pINDeliveryCountry != null)
            {
                this.PINDeliveryCountry = pINDeliveryCountry;
            }

            if (pINDeliveryCountryId != null)
            {
                this.PINDeliveryCountryId = pINDeliveryCountryId;
            }

            if (pINPhoneNumber != null)
            {
                this.PINPhoneNumber = pINPhoneNumber;
            }

            if (pINEmailAddress != null)
            {
                this.PINEmailAddress = pINEmailAddress;
            }
            this.SaveForPINReminder = saveForPINReminder;
            this.SaveForCardReissue = saveForCardReissue;

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }
        }

        /// <summary>
        /// The encrypted value of self-selected PIN.<br />
        /// Optional – When not provided, the PIN will be auto generated(if the card token type supports PIN) and delivered based on the given PIN delivery option.<br />
        /// Max Length: 256
        /// </summary>
        [JsonProperty("SelfSelectedEncryptedPIN")]
        public string SelfSelectedEncryptedPIN
        {
            get
            {
                return this.selfSelectedEncryptedPIN;
            }

            set
            {
                this.shouldSerialize["SelfSelectedEncryptedPIN"] = true;
                this.selfSelectedEncryptedPIN = value;
            }
        }

        /// <summary>
        /// KeyId of the PIN encrypted value.<br />
        /// Mandatory, if opted for self-selected PIN else optional.<br />
        /// Max Length: 30
        /// </summary>
        [JsonProperty("SelfSelectedPINKeyID")]
        public string SelfSelectedPINKeyID
        {
            get
            {
                return this.selfSelectedPINKeyID;
            }

            set
            {
                this.shouldSerialize["SelfSelectedPINKeyID"] = true;
                this.selfSelectedPINKeyID = value;
            }
        }

        /// <summary>
        /// Encoded message of the TCS form which is used for encrypting the PIN of this card.<br />
        /// The encode message forms are provided to clients by another API (“TCS”).<br />
        /// Instructions to encrypt the PIN is covered in the related API specifications document.<br />
        /// Mandatory –If opted for self-selected PIN else optional.
        /// Max Length: 1024
        /// </summary>
        [JsonProperty("SelfSelectedPINSessionKey")]
        public string SelfSelectedPINSessionKey
        {
            get
            {
                return this.selfSelectedPINSessionKey;
            }

            set
            {
                this.shouldSerialize["SelfSelectedPINSessionKey"] = true;
                this.selfSelectedPINSessionKey = value;
            }
        }

        /// <summary>
        /// True/False.<br />
        /// Optional <br />
        /// Default: False<br />
        /// For cards ordered with Validate Fleet Id parameter set to true, CFGW will be notified to enable this validation for the card.<br />
        /// Note: When “FleetIdInputRequired” is not set on the card, validate fleet id will be considered false regardless of the value passed on this parameter.
        /// </summary>
        [JsonProperty("ValidateFleetId", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateFleetId { get; set; }

        /// <summary>
        /// Existing Card Group ID, under which the replacement card is to be created.<br />
        /// Pass “-1” if the replacement card should not be assigned to any card group.<br />
        /// Optional <br />
        /// If not provided, the replacement card will be created under the same card group as the current card.
        /// </summary>
        [JsonProperty("CardGroupId")]
        public int? CardGroupId
        {
            get
            {
                return this.cardGroupId;
            }

            set
            {
                this.shouldSerialize["CardGroupId"] = true;
                this.cardGroupId = value;
            }
        }

        /// <summary>
        /// Card delivery type.<br />
        /// Mandatory <br />
        /// Allowed Value: <br />
        /// 1.    Customer Address(Default) <br />
        /// 2.    New Delivery Address <br />
        /// 3.    Old Card Address
        /// </summary>
        [JsonProperty("CardDeliveryType", NullValueHandling = NullValueHandling.Include)]
        public int? CardDeliveryType { get; set; }

        /// <summary>
        /// Title of the contact person. <br />
        /// Optional<br />
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br />
        /// Max field length: 50
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.
        /// Max field length: 50
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br />
        /// Max field length: 40
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
        /// Max field length: 40
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
        /// Optional<br />
        /// Max field length: 40
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br />
        /// Max field length: 10
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true.<br />
        /// Max field length: 40
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
        /// Mandatory - If CardDeliveryType  is 2 and OrderCardReplacement is passed as true
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
        /// The countryId of gicen country.<br />
        /// </summary>
        [JsonProperty("DeliveryCountryId")]
        public int? DeliveryCountryId
        {
            get
            {
                return this.deliveryCountryId;
            }

            set
            {
                this.shouldSerialize["DeliveryCountryId"] = true;
                this.deliveryCountryId = value;
            }
        }

        /// <summary>
        /// Phone number for to send SMS. <br />
        /// Optional<br />
        /// Max field length: 20
        /// </summary>
        [JsonProperty("PhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email address for to send email.<br />
        /// Mandatory if PINAdviceType is email else optional.<br />
        /// Max field length: 90
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
        /// PIN delivery address type selection.<br />
        /// Optional<br />
        /// Allowed Values:<br />
        /// 1.    Customer Address(Default)<br />
        /// 2.    Card Address<br />
        /// 3.    New Delivery Address
        /// </summary>
        [JsonProperty("PINDeliveryAddressType")]
        public int? PINDeliveryAddressType
        {
            get
            {
                return this.pINDeliveryAddressType;
            }

            set
            {
                this.shouldSerialize["PINDeliveryAddressType"] = true;
                this.pINDeliveryAddressType = value;
            }
        }

        /// <summary>
        /// PIN delivery method.<br />
        /// Mandatory when OrderReplacement Is true.<br />
        /// Allowed Values:<br />
        /// 1.    Paper<br />
        /// 2.    Email<br />
        /// 3.    SMS<br />
        /// 4.    None
        /// </summary>
        [JsonProperty("PINAdviceType")]
        public int? PINAdviceType
        {
            get
            {
                return this.pINAdviceType;
            }

            set
            {
                this.shouldSerialize["PINAdviceType"] = true;
                this.pINAdviceType = value;
            }
        }

        /// <summary>
        /// Title of the contact person.<br />
        /// Optional <br />
        /// Max field length: 10
        /// </summary>
        [JsonProperty("PINDeliveryContactTitle")]
        public string PINDeliveryContactTitle
        {
            get
            {
                return this.pINDeliveryContactTitle;
            }

            set
            {
                this.shouldSerialize["PINDeliveryContactTitle"] = true;
                this.pINDeliveryContactTitle = value;
            }
        }

        /// <summary>
        /// Name of the contact person.<br />
        /// Mandatory - If PINAdviceType is paper else optional.<br />
        /// Max field length: 50
        /// </summary>
        [JsonProperty("PINDeliveryContactName")]
        public string PINDeliveryContactName
        {
            get
            {
                return this.pINDeliveryContactName;
            }

            set
            {
                this.shouldSerialize["PINDeliveryContactName"] = true;
                this.pINDeliveryContactName = value;
            }
        }

        /// <summary>
        /// Company name.<br />
        /// Mandatory - If PINAdviceType is paper else optional.<br />
        /// Max field length: 50
        /// </summary>
        [JsonProperty("PINDeliveryCompanyName")]
        public string PINDeliveryCompanyName
        {
            get
            {
                return this.pINDeliveryCompanyName;
            }

            set
            {
                this.shouldSerialize["PINDeliveryCompanyName"] = true;
                this.pINDeliveryCompanyName = value;
            }
        }

        /// <summary>
        /// Address line 1.<br />
        /// Mandatory - If PINAdviceType is paper else optional.<br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("PINDeliveryAddressLine1")]
        public string PINDeliveryAddressLine1
        {
            get
            {
                return this.pINDeliveryAddressLine1;
            }

            set
            {
                this.shouldSerialize["PINDeliveryAddressLine1"] = true;
                this.pINDeliveryAddressLine1 = value;
            }
        }

        /// <summary>
        /// Address line 2.<br />
        /// Optional <br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("PINDeliveryAddressLine2")]
        public string PINDeliveryAddressLine2
        {
            get
            {
                return this.pINDeliveryAddressLine2;
            }

            set
            {
                this.shouldSerialize["PINDeliveryAddressLine2"] = true;
                this.pINDeliveryAddressLine2 = value;
            }
        }

        /// <summary>
        /// Address line 3.<br />
        /// Optional <br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("PINDeliveryAddressLine3")]
        public string PINDeliveryAddressLine3
        {
            get
            {
                return this.pINDeliveryAddressLine3;
            }

            set
            {
                this.shouldSerialize["PINDeliveryAddressLine3"] = true;
                this.pINDeliveryAddressLine3 = value;
            }
        }

        /// <summary>
        /// ZIP code.<br />
        /// Mandatory - if PINAdviceType is paper else optional. <br />
        /// Max field length: 10
        /// </summary>
        [JsonProperty("PINDeliveryZipCode")]
        public string PINDeliveryZipCode
        {
            get
            {
                return this.pINDeliveryZipCode;
            }

            set
            {
                this.shouldSerialize["PINDeliveryZipCode"] = true;
                this.pINDeliveryZipCode = value;
            }
        }

        /// <summary>
        /// City.<br />
        /// Mandatory - If PINAdviceType is paper else optional. <br />
        /// Max field length: 40
        /// </summary>
        [JsonProperty("PINDeliveryCity")]
        public string PINDeliveryCity
        {
            get
            {
                return this.pINDeliveryCity;
            }

            set
            {
                this.shouldSerialize["PINDeliveryCity"] = true;
                this.pINDeliveryCity = value;
            }
        }

        /// <summary>
        /// Region Id.<br />
        /// Optional
        /// </summary>
        [JsonProperty("PINDeliveryRegionId")]
        public int? PINDeliveryRegionId
        {
            get
            {
                return this.pINDeliveryRegionId;
            }

            set
            {
                this.shouldSerialize["PINDeliveryRegionId"] = true;
                this.pINDeliveryRegionId = value;
            }
        }

        /// <summary>
        /// Region.<br />
        /// When region is passed
        /// </summary>
        [JsonProperty("PINDeliveryRegion")]
        public string PINDeliveryRegion
        {
            get
            {
                return this.pINDeliveryRegion;
            }

            set
            {
                this.shouldSerialize["PINDeliveryRegion"] = true;
                this.pINDeliveryRegion = value;
            }
        }

        /// <summary>
        /// The ISO code of the country.<br />
        /// Mappings for ISO code <br />
        /// Mandatory if PINAdviceType is paper else optional.
        /// </summary>
        [JsonProperty("PINDeliveryCountry")]
        public string PINDeliveryCountry
        {
            get
            {
                return this.pINDeliveryCountry;
            }

            set
            {
                this.shouldSerialize["PINDeliveryCountry"] = true;
                this.pINDeliveryCountry = value;
            }
        }

        /// <summary>
        /// The countryId of the country.<br />
        /// Mappings for ISO code<br />
        /// This is not an input parameter.
        /// </summary>
        [JsonProperty("PINDeliveryCountryId")]
        public int? PINDeliveryCountryId
        {
            get
            {
                return this.pINDeliveryCountryId;
            }

            set
            {
                this.shouldSerialize["PINDeliveryCountryId"] = true;
                this.pINDeliveryCountryId = value;
            }
        }

        /// <summary>
        /// Phone number for to send SMS of the PIN in case PINAdviceType is SMS.<br />
        /// Mandatory if PINAdviceType is SMS else optional.<br />
        /// Max field length: 20
        /// </summary>
        [JsonProperty("PINPhoneNumber")]
        public string PINPhoneNumber
        {
            get
            {
                return this.pINPhoneNumber;
            }

            set
            {
                this.shouldSerialize["PINPhoneNumber"] = true;
                this.pINPhoneNumber = value;
            }
        }

        /// <summary>
        /// Email address for to send email of the PIN in case PINAdviceType is Email.<br />
        /// Mandatory if PINAdviceType is email else optional.<br />
        /// Max field length: 90
        /// </summary>
        [JsonProperty("PINEmailAddress")]
        public string PINEmailAddress
        {
            get
            {
                return this.pINEmailAddress;
            }

            set
            {
                this.shouldSerialize["PINEmailAddress"] = true;
                this.pINEmailAddress = value;
            }
        }

        /// <summary>
        /// The given address will be used for sending PIN reminders in future when requested.<br />
        /// PIN Advice type should be Paper
        /// Optional
        /// </summary>
        [JsonProperty("SaveForPINReminder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SaveForPINReminder { get; set; }

        /// <summary>
        /// If this is specified, the contact address will be saved in cards platform for card reissue processing.<br />
        /// Optional
        /// </summary>
        [JsonProperty("SaveForCardReissue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SaveForCardReissue { get; set; }

        /// <summary>
        /// Expiry Date for newly created card to be update in cards plot form.<br />
        /// Optional <br />
        /// Format: MMyy <br />
        /// Eg:1221 <br />
        /// If not apply the default Expiry Date.<br />
        /// Note:<br />
        /// There is a limit to the ExpiryDate which the user can choose for the Card.
        /// If the user chooses a later ExpiryDate than the allowed value for the CardType of the OU,
        /// the background service logs the respective error code and description
        /// </summary>
        [JsonProperty("ExpiryDate")]
        public string ExpiryDate
        {
            get
            {
                return this.expiryDate;
            }

            set
            {
                this.shouldSerialize["ExpiryDate"] = true;
                this.expiryDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSelfSelectedEncryptedPIN()
        {
            this.shouldSerialize["SelfSelectedEncryptedPIN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSelfSelectedPINKeyID()
        {
            this.shouldSerialize["SelfSelectedPINKeyID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSelfSelectedPINSessionKey()
        {
            this.shouldSerialize["SelfSelectedPINSessionKey"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
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
        public void UnsetDeliveryContactName()
        {
            this.shouldSerialize["DeliveryContactName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryCompanyName()
        {
            this.shouldSerialize["DeliveryCompanyName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryAddressLine1()
        {
            this.shouldSerialize["DeliveryAddressLine1"] = false;
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
        public void UnsetDeliveryZipCode()
        {
            this.shouldSerialize["DeliveryZipCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryCity()
        {
            this.shouldSerialize["DeliveryCity"] = false;
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
        public void UnsetDeliveryCountry()
        {
            this.shouldSerialize["DeliveryCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeliveryCountryId()
        {
            this.shouldSerialize["DeliveryCountryId"] = false;
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
        public void UnsetPINDeliveryAddressType()
        {
            this.shouldSerialize["PINDeliveryAddressType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINAdviceType()
        {
            this.shouldSerialize["PINAdviceType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryContactTitle()
        {
            this.shouldSerialize["PINDeliveryContactTitle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryContactName()
        {
            this.shouldSerialize["PINDeliveryContactName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryCompanyName()
        {
            this.shouldSerialize["PINDeliveryCompanyName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryAddressLine1()
        {
            this.shouldSerialize["PINDeliveryAddressLine1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryAddressLine2()
        {
            this.shouldSerialize["PINDeliveryAddressLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryAddressLine3()
        {
            this.shouldSerialize["PINDeliveryAddressLine3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryZipCode()
        {
            this.shouldSerialize["PINDeliveryZipCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryCity()
        {
            this.shouldSerialize["PINDeliveryCity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryRegionId()
        {
            this.shouldSerialize["PINDeliveryRegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryRegion()
        {
            this.shouldSerialize["PINDeliveryRegion"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryCountry()
        {
            this.shouldSerialize["PINDeliveryCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINDeliveryCountryId()
        {
            this.shouldSerialize["PINDeliveryCountryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINPhoneNumber()
        {
            this.shouldSerialize["PINPhoneNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPINEmailAddress()
        {
            this.shouldSerialize["PINEmailAddress"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiryDate()
        {
            this.shouldSerialize["ExpiryDate"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSelfSelectedEncryptedPIN()
        {
            return this.shouldSerialize["SelfSelectedEncryptedPIN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSelfSelectedPINKeyID()
        {
            return this.shouldSerialize["SelfSelectedPINKeyID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSelfSelectedPINSessionKey()
        {
            return this.shouldSerialize["SelfSelectedPINSessionKey"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupId()
        {
            return this.shouldSerialize["CardGroupId"];
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
        public bool ShouldSerializeDeliveryCountryId()
        {
            return this.shouldSerialize["DeliveryCountryId"];
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
        public bool ShouldSerializePINDeliveryAddressType()
        {
            return this.shouldSerialize["PINDeliveryAddressType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINAdviceType()
        {
            return this.shouldSerialize["PINAdviceType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryContactTitle()
        {
            return this.shouldSerialize["PINDeliveryContactTitle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryContactName()
        {
            return this.shouldSerialize["PINDeliveryContactName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryCompanyName()
        {
            return this.shouldSerialize["PINDeliveryCompanyName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryAddressLine1()
        {
            return this.shouldSerialize["PINDeliveryAddressLine1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryAddressLine2()
        {
            return this.shouldSerialize["PINDeliveryAddressLine2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryAddressLine3()
        {
            return this.shouldSerialize["PINDeliveryAddressLine3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryZipCode()
        {
            return this.shouldSerialize["PINDeliveryZipCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryCity()
        {
            return this.shouldSerialize["PINDeliveryCity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryRegionId()
        {
            return this.shouldSerialize["PINDeliveryRegionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryRegion()
        {
            return this.shouldSerialize["PINDeliveryRegion"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryCountry()
        {
            return this.shouldSerialize["PINDeliveryCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINDeliveryCountryId()
        {
            return this.shouldSerialize["PINDeliveryCountryId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINPhoneNumber()
        {
            return this.shouldSerialize["PINPhoneNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINEmailAddress()
        {
            return this.shouldSerialize["PINEmailAddress"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryDate()
        {
            return this.shouldSerialize["ExpiryDate"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardSettings other &&
                (this.SelfSelectedEncryptedPIN == null && other.SelfSelectedEncryptedPIN == null ||
                 this.SelfSelectedEncryptedPIN?.Equals(other.SelfSelectedEncryptedPIN) == true) &&
                (this.SelfSelectedPINKeyID == null && other.SelfSelectedPINKeyID == null ||
                 this.SelfSelectedPINKeyID?.Equals(other.SelfSelectedPINKeyID) == true) &&
                (this.SelfSelectedPINSessionKey == null && other.SelfSelectedPINSessionKey == null ||
                 this.SelfSelectedPINSessionKey?.Equals(other.SelfSelectedPINSessionKey) == true) &&
                (this.ValidateFleetId == null && other.ValidateFleetId == null ||
                 this.ValidateFleetId?.Equals(other.ValidateFleetId) == true) &&
                (this.CardGroupId == null && other.CardGroupId == null ||
                 this.CardGroupId?.Equals(other.CardGroupId) == true) &&
                (this.CardDeliveryType == null && other.CardDeliveryType == null ||
                 this.CardDeliveryType?.Equals(other.CardDeliveryType) == true) &&
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
                (this.DeliveryCountryId == null && other.DeliveryCountryId == null ||
                 this.DeliveryCountryId?.Equals(other.DeliveryCountryId) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.PINDeliveryAddressType == null && other.PINDeliveryAddressType == null ||
                 this.PINDeliveryAddressType?.Equals(other.PINDeliveryAddressType) == true) &&
                (this.PINAdviceType == null && other.PINAdviceType == null ||
                 this.PINAdviceType?.Equals(other.PINAdviceType) == true) &&
                (this.PINDeliveryContactTitle == null && other.PINDeliveryContactTitle == null ||
                 this.PINDeliveryContactTitle?.Equals(other.PINDeliveryContactTitle) == true) &&
                (this.PINDeliveryContactName == null && other.PINDeliveryContactName == null ||
                 this.PINDeliveryContactName?.Equals(other.PINDeliveryContactName) == true) &&
                (this.PINDeliveryCompanyName == null && other.PINDeliveryCompanyName == null ||
                 this.PINDeliveryCompanyName?.Equals(other.PINDeliveryCompanyName) == true) &&
                (this.PINDeliveryAddressLine1 == null && other.PINDeliveryAddressLine1 == null ||
                 this.PINDeliveryAddressLine1?.Equals(other.PINDeliveryAddressLine1) == true) &&
                (this.PINDeliveryAddressLine2 == null && other.PINDeliveryAddressLine2 == null ||
                 this.PINDeliveryAddressLine2?.Equals(other.PINDeliveryAddressLine2) == true) &&
                (this.PINDeliveryAddressLine3 == null && other.PINDeliveryAddressLine3 == null ||
                 this.PINDeliveryAddressLine3?.Equals(other.PINDeliveryAddressLine3) == true) &&
                (this.PINDeliveryZipCode == null && other.PINDeliveryZipCode == null ||
                 this.PINDeliveryZipCode?.Equals(other.PINDeliveryZipCode) == true) &&
                (this.PINDeliveryCity == null && other.PINDeliveryCity == null ||
                 this.PINDeliveryCity?.Equals(other.PINDeliveryCity) == true) &&
                (this.PINDeliveryRegionId == null && other.PINDeliveryRegionId == null ||
                 this.PINDeliveryRegionId?.Equals(other.PINDeliveryRegionId) == true) &&
                (this.PINDeliveryRegion == null && other.PINDeliveryRegion == null ||
                 this.PINDeliveryRegion?.Equals(other.PINDeliveryRegion) == true) &&
                (this.PINDeliveryCountry == null && other.PINDeliveryCountry == null ||
                 this.PINDeliveryCountry?.Equals(other.PINDeliveryCountry) == true) &&
                (this.PINDeliveryCountryId == null && other.PINDeliveryCountryId == null ||
                 this.PINDeliveryCountryId?.Equals(other.PINDeliveryCountryId) == true) &&
                (this.PINPhoneNumber == null && other.PINPhoneNumber == null ||
                 this.PINPhoneNumber?.Equals(other.PINPhoneNumber) == true) &&
                (this.PINEmailAddress == null && other.PINEmailAddress == null ||
                 this.PINEmailAddress?.Equals(other.PINEmailAddress) == true) &&
                (this.SaveForPINReminder == null && other.SaveForPINReminder == null ||
                 this.SaveForPINReminder?.Equals(other.SaveForPINReminder) == true) &&
                (this.SaveForCardReissue == null && other.SaveForCardReissue == null ||
                 this.SaveForCardReissue?.Equals(other.SaveForCardReissue) == true) &&
                (this.ExpiryDate == null && other.ExpiryDate == null ||
                 this.ExpiryDate?.Equals(other.ExpiryDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SelfSelectedEncryptedPIN = {this.SelfSelectedEncryptedPIN ?? "null"}");
            toStringOutput.Add($"this.SelfSelectedPINKeyID = {this.SelfSelectedPINKeyID ?? "null"}");
            toStringOutput.Add($"this.SelfSelectedPINSessionKey = {this.SelfSelectedPINSessionKey ?? "null"}");
            toStringOutput.Add($"this.ValidateFleetId = {(this.ValidateFleetId == null ? "null" : this.ValidateFleetId.ToString())}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardDeliveryType = {(this.CardDeliveryType == null ? "null" : this.CardDeliveryType.ToString())}");
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
            toStringOutput.Add($"this.DeliveryCountryId = {(this.DeliveryCountryId == null ? "null" : this.DeliveryCountryId.ToString())}");
            toStringOutput.Add($"this.PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"this.EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryAddressType = {(this.PINDeliveryAddressType == null ? "null" : this.PINDeliveryAddressType.ToString())}");
            toStringOutput.Add($"this.PINAdviceType = {(this.PINAdviceType == null ? "null" : this.PINAdviceType.ToString())}");
            toStringOutput.Add($"this.PINDeliveryContactTitle = {this.PINDeliveryContactTitle ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryContactName = {this.PINDeliveryContactName ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryCompanyName = {this.PINDeliveryCompanyName ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryAddressLine1 = {this.PINDeliveryAddressLine1 ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryAddressLine2 = {this.PINDeliveryAddressLine2 ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryAddressLine3 = {this.PINDeliveryAddressLine3 ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryZipCode = {this.PINDeliveryZipCode ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryCity = {this.PINDeliveryCity ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryRegionId = {(this.PINDeliveryRegionId == null ? "null" : this.PINDeliveryRegionId.ToString())}");
            toStringOutput.Add($"this.PINDeliveryRegion = {this.PINDeliveryRegion ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryCountry = {this.PINDeliveryCountry ?? "null"}");
            toStringOutput.Add($"this.PINDeliveryCountryId = {(this.PINDeliveryCountryId == null ? "null" : this.PINDeliveryCountryId.ToString())}");
            toStringOutput.Add($"this.PINPhoneNumber = {this.PINPhoneNumber ?? "null"}");
            toStringOutput.Add($"this.PINEmailAddress = {this.PINEmailAddress ?? "null"}");
            toStringOutput.Add($"this.SaveForPINReminder = {(this.SaveForPINReminder == null ? "null" : this.SaveForPINReminder.ToString())}");
            toStringOutput.Add($"this.SaveForCardReissue = {(this.SaveForCardReissue == null ? "null" : this.SaveForCardReissue.ToString())}");
            toStringOutput.Add($"this.ExpiryDate = {this.ExpiryDate ?? "null"}");
        }
    }
}
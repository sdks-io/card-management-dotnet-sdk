// <copyright file="CustomerDetailResponse.cs" company="APIMatic">
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
    /// CustomerDetailResponse.
    /// </summary>
    public class CustomerDetailResponse
    {
        private int? accountId;
        private string accountName;
        private string accountNumber;
        private string accountShortName;
        private string accountTradingName;
        private string band;
        private string cardGroupPosition;
        private string fullName;
        private int? invoiceCustomerId;
        private string invoiceCustomerShortName;
        private bool? isInvoicePoint;
        private string marketingSegmentation;
        private string vATNumber;
        private int? payerId;
        private string payerName;
        private string payerNumber;
        private bool? selfSelectedPin;
        private string status;
        private int? defaultPINAdviceType;
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountName", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "AccountTradingName", false },
            { "Band", false },
            { "CardGroupPosition", false },
            { "FullName", false },
            { "InvoiceCustomerId", false },
            { "InvoiceCustomerShortName", false },
            { "IsInvoicePoint", false },
            { "MarketingSegmentation", false },
            { "VATNumber", false },
            { "PayerId", false },
            { "PayerName", false },
            { "PayerNumber", false },
            { "SelfSelectedPin", false },
            { "Status", false },
            { "DefaultPINAdviceType", false },
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailResponse"/> class.
        /// </summary>
        public CustomerDetailResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailResponse"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="accountTradingName">AccountTradingName.</param>
        /// <param name="allowFleetIdInput">AllowFleetIdInput.</param>
        /// <param name="band">Band.</param>
        /// <param name="billingAddress">BillingAddress.</param>
        /// <param name="cardGroupPosition">CardGroupPosition.</param>
        /// <param name="correspondenceAddress">CorrespondenceAddress.</param>
        /// <param name="deliveryAddresses">DeliveryAddresses.</param>
        /// <param name="fleetPin">FleetPin.</param>
        /// <param name="fullName">FullName.</param>
        /// <param name="invoiceCustomerId">InvoiceCustomerId.</param>
        /// <param name="invoiceCustomerShortName">InvoiceCustomerShortName.</param>
        /// <param name="isInvoicePoint">IsInvoicePoint.</param>
        /// <param name="marketingSegmentation">MarketingSegmentation.</param>
        /// <param name="vATNumber">VATNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="selfSelectedPin">SelfSelectedPin.</param>
        /// <param name="status">Status.</param>
        /// <param name="defaultPINAdviceType">DefaultPINAdviceType.</param>
        /// <param name="pINAdviceTypes">PINAdviceTypes.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="pINChangeAllowedByCardholder">PINChangeAllowedByCardholder.</param>
        /// <param name="pINChangeAllowedFromFleetPIN">PINChangeAllowedFromFleetPIN.</param>
        public CustomerDetailResponse(
            int? accountId = null,
            string accountName = null,
            string accountNumber = null,
            string accountShortName = null,
            string accountTradingName = null,
            bool? allowFleetIdInput = null,
            string band = null,
            Models.Address billingAddress = null,
            string cardGroupPosition = null,
            Models.Address correspondenceAddress = null,
            List<Models.DeliveryAddresses> deliveryAddresses = null,
            bool? fleetPin = null,
            string fullName = null,
            int? invoiceCustomerId = null,
            string invoiceCustomerShortName = null,
            bool? isInvoicePoint = null,
            string marketingSegmentation = null,
            string vATNumber = null,
            int? payerId = null,
            string payerName = null,
            string payerNumber = null,
            bool? selfSelectedPin = null,
            string status = null,
            int? defaultPINAdviceType = null,
            List<Models.PINAdviceTypes> pINAdviceTypes = null,
            Models.ErrorStatus error = null,
            string requestId = null,
            bool? pINChangeAllowedByCardholder = null,
            bool? pINChangeAllowedFromFleetPIN = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (accountTradingName != null)
            {
                this.AccountTradingName = accountTradingName;
            }

            this.AllowFleetIdInput = allowFleetIdInput;
            if (band != null)
            {
                this.Band = band;
            }

            this.BillingAddress = billingAddress;
            if (cardGroupPosition != null)
            {
                this.CardGroupPosition = cardGroupPosition;
            }

            this.CorrespondenceAddress = correspondenceAddress;
            this.DeliveryAddresses = deliveryAddresses;
            this.FleetPin = fleetPin;
            if (fullName != null)
            {
                this.FullName = fullName;
            }

            if (invoiceCustomerId != null)
            {
                this.InvoiceCustomerId = invoiceCustomerId;
            }

            if (invoiceCustomerShortName != null)
            {
                this.InvoiceCustomerShortName = invoiceCustomerShortName;
            }

            if (isInvoicePoint != null)
            {
                this.IsInvoicePoint = isInvoicePoint;
            }

            if (marketingSegmentation != null)
            {
                this.MarketingSegmentation = marketingSegmentation;
            }

            if (vATNumber != null)
            {
                this.VATNumber = vATNumber;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (selfSelectedPin != null)
            {
                this.SelfSelectedPin = selfSelectedPin;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (defaultPINAdviceType != null)
            {
                this.DefaultPINAdviceType = defaultPINAdviceType;
            }

            this.PINAdviceTypes = pINAdviceTypes;
            this.Error = error;
            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            this.PINChangeAllowedByCardholder = pINChangeAllowedByCardholder;
            this.PINChangeAllowedFromFleetPIN = pINChangeAllowedFromFleetPIN;
        }

        /// <summary>
        /// Account Id of the selected account.
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
        /// Account Name of the selected account.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
            }
        }

        /// <summary>
        /// Account Number of the selected account.
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
        /// Short name of the customer.
        /// </summary>
        [JsonProperty("AccountShortName")]
        public string AccountShortName
        {
            get
            {
                return this.accountShortName;
            }

            set
            {
                this.shouldSerialize["AccountShortName"] = true;
                this.accountShortName = value;
            }
        }

        /// <summary>
        /// Trading name of the customer
        /// </summary>
        [JsonProperty("AccountTradingName")]
        public string AccountTradingName
        {
            get
            {
                return this.accountTradingName;
            }

            set
            {
                this.shouldSerialize["AccountTradingName"] = true;
                this.accountTradingName = value;
            }
        }

        /// <summary>
        /// True/False.
        /// When false, users should not be allowed to enable Fleet Id prompt option while ordering cards under this account.
        /// </summary>
        [JsonProperty("AllowFleetIdInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowFleetIdInput { get; set; }

        /// <summary>
        /// Band Id and Description of the Payer in Card Platform
        /// e.g. (Id – Description):
        /// 1-Platinum
        /// 2-Gold
        /// 3-Silver
        /// 4-Bronze
        /// </summary>
        [JsonProperty("Band")]
        public string Band
        {
            get
            {
                return this.band;
            }

            set
            {
                this.shouldSerialize["Band"] = true;
                this.band = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("BillingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// Card group position at –
        /// •	Payer – Payer level
        /// •	Account – Account level
        /// </summary>
        [JsonProperty("CardGroupPosition")]
        public string CardGroupPosition
        {
            get
            {
                return this.cardGroupPosition;
            }

            set
            {
                this.shouldSerialize["CardGroupPosition"] = true;
                this.cardGroupPosition = value;
            }
        }

        /// <summary>
        /// Gets or sets CorrespondenceAddress.
        /// </summary>
        [JsonProperty("CorrespondenceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address CorrespondenceAddress { get; set; }

        /// <summary>
        /// Gets or sets DeliveryAddresses.
        /// </summary>
        [JsonProperty("DeliveryAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeliveryAddresses> DeliveryAddresses { get; set; }

        /// <summary>
        /// Is Fleet Pin optional enabled for the selected account
        /// </summary>
        [JsonProperty("FleetPin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FleetPin { get; set; }

        /// <summary>
        /// Full Name of the customer
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName
        {
            get
            {
                return this.fullName;
            }

            set
            {
                this.shouldSerialize["FullName"] = true;
                this.fullName = value;
            }
        }

        /// <summary>
        /// Customer Id of the Invoice Point of the account
        /// </summary>
        [JsonProperty("InvoiceCustomerId")]
        public int? InvoiceCustomerId
        {
            get
            {
                return this.invoiceCustomerId;
            }

            set
            {
                this.shouldSerialize["InvoiceCustomerId"] = true;
                this.invoiceCustomerId = value;
            }
        }

        /// <summary>
        /// Short Name of the Invoice Point of the account
        /// </summary>
        [JsonProperty("InvoiceCustomerShortName")]
        public string InvoiceCustomerShortName
        {
            get
            {
                return this.invoiceCustomerShortName;
            }

            set
            {
                this.shouldSerialize["InvoiceCustomerShortName"] = true;
                this.invoiceCustomerShortName = value;
            }
        }

        /// <summary>
        /// Whether the account is an invoice point.
        /// </summary>
        [JsonProperty("IsInvoicePoint")]
        public bool? IsInvoicePoint
        {
            get
            {
                return this.isInvoicePoint;
            }

            set
            {
                this.shouldSerialize["IsInvoicePoint"] = true;
                this.isInvoicePoint = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Marketing Segmentation id and description
        /// e.g. (Id – Description):
        /// 1-National CRT
        /// 2-International CRT & IKAs
        /// 3-Small Customers
        /// 4-National/International Fleet/IKA
        /// ]]>
        /// </summary>
        [JsonProperty("MarketingSegmentation")]
        public string MarketingSegmentation
        {
            get
            {
                return this.marketingSegmentation;
            }

            set
            {
                this.shouldSerialize["MarketingSegmentation"] = true;
                this.marketingSegmentation = value;
            }
        }

        /// <summary>
        /// VAT Registration Number of Customer
        /// </summary>
        [JsonProperty("VATNumber")]
        public string VATNumber
        {
            get
            {
                return this.vATNumber;
            }

            set
            {
                this.shouldSerialize["VATNumber"] = true;
                this.vATNumber = value;
            }
        }

        /// <summary>
        /// Payer Id of the selected account.
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// Payer Name of the selected account.
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }

            set
            {
                this.shouldSerialize["PayerName"] = true;
                this.payerName = value;
            }
        }

        /// <summary>
        /// Payer Number of the selected account.
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Is Self-selected Pin enabled for the account
        /// </summary>
        [JsonProperty("SelfSelectedPin")]
        public bool? SelfSelectedPin
        {
            get
            {
                return this.selfSelectedPin;
            }

            set
            {
                this.shouldSerialize["SelfSelectedPin"] = true;
                this.selfSelectedPin = value;
            }
        }

        /// <summary>
        /// Payer current status id and description
        /// e.g. (Id – Description):
        /// 1-Active
        /// 2-Requested from UTA
        /// 3-Awaiting embossing
        /// 4-Manufactured
        /// 5-Awaiting despatch
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Default PIN AdviceType of the customer.
        /// Possible Values:
        /// 1.	Paper
        /// 2.	Email
        /// 3.	SMS
        /// 4.	None
        /// </summary>
        [JsonProperty("DefaultPINAdviceType")]
        public int? DefaultPINAdviceType
        {
            get
            {
                return this.defaultPINAdviceType;
            }

            set
            {
                this.shouldSerialize["DefaultPINAdviceType"] = true;
                this.defaultPINAdviceType = value;
            }
        }

        /// <summary>
        /// Gets or sets PINAdviceTypes.
        /// </summary>
        [JsonProperty("PINAdviceTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PINAdviceTypes> PINAdviceTypes { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request id
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// PIN change allowed for card holder or not.
        /// </summary>
        [JsonProperty("PINChangeAllowedByCardholder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PINChangeAllowedByCardholder { get; set; }

        /// <summary>
        /// PIN change allowed from fleetpin or not.
        /// </summary>
        [JsonProperty("PINChangeAllowedFromFleetPIN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PINChangeAllowedFromFleetPIN { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerDetailResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
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
        public void UnsetAccountShortName()
        {
            this.shouldSerialize["AccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountTradingName()
        {
            this.shouldSerialize["AccountTradingName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBand()
        {
            this.shouldSerialize["Band"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupPosition()
        {
            this.shouldSerialize["CardGroupPosition"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFullName()
        {
            this.shouldSerialize["FullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCustomerId()
        {
            this.shouldSerialize["InvoiceCustomerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCustomerShortName()
        {
            this.shouldSerialize["InvoiceCustomerShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsInvoicePoint()
        {
            this.shouldSerialize["IsInvoicePoint"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMarketingSegmentation()
        {
            this.shouldSerialize["MarketingSegmentation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATNumber()
        {
            this.shouldSerialize["VATNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerName()
        {
            this.shouldSerialize["PayerName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSelfSelectedPin()
        {
            this.shouldSerialize["SelfSelectedPin"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDefaultPINAdviceType()
        {
            this.shouldSerialize["DefaultPINAdviceType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
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
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
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
        public bool ShouldSerializeAccountShortName()
        {
            return this.shouldSerialize["AccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountTradingName()
        {
            return this.shouldSerialize["AccountTradingName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBand()
        {
            return this.shouldSerialize["Band"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupPosition()
        {
            return this.shouldSerialize["CardGroupPosition"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFullName()
        {
            return this.shouldSerialize["FullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCustomerId()
        {
            return this.shouldSerialize["InvoiceCustomerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCustomerShortName()
        {
            return this.shouldSerialize["InvoiceCustomerShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsInvoicePoint()
        {
            return this.shouldSerialize["IsInvoicePoint"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMarketingSegmentation()
        {
            return this.shouldSerialize["MarketingSegmentation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATNumber()
        {
            return this.shouldSerialize["VATNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerName()
        {
            return this.shouldSerialize["PayerName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSelfSelectedPin()
        {
            return this.shouldSerialize["SelfSelectedPin"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultPINAdviceType()
        {
            return this.shouldSerialize["DefaultPINAdviceType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
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
            return obj is CustomerDetailResponse other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.AccountTradingName == null && other.AccountTradingName == null) || (this.AccountTradingName?.Equals(other.AccountTradingName) == true)) &&
                ((this.AllowFleetIdInput == null && other.AllowFleetIdInput == null) || (this.AllowFleetIdInput?.Equals(other.AllowFleetIdInput) == true)) &&
                ((this.Band == null && other.Band == null) || (this.Band?.Equals(other.Band) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.CardGroupPosition == null && other.CardGroupPosition == null) || (this.CardGroupPosition?.Equals(other.CardGroupPosition) == true)) &&
                ((this.CorrespondenceAddress == null && other.CorrespondenceAddress == null) || (this.CorrespondenceAddress?.Equals(other.CorrespondenceAddress) == true)) &&
                ((this.DeliveryAddresses == null && other.DeliveryAddresses == null) || (this.DeliveryAddresses?.Equals(other.DeliveryAddresses) == true)) &&
                ((this.FleetPin == null && other.FleetPin == null) || (this.FleetPin?.Equals(other.FleetPin) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.InvoiceCustomerId == null && other.InvoiceCustomerId == null) || (this.InvoiceCustomerId?.Equals(other.InvoiceCustomerId) == true)) &&
                ((this.InvoiceCustomerShortName == null && other.InvoiceCustomerShortName == null) || (this.InvoiceCustomerShortName?.Equals(other.InvoiceCustomerShortName) == true)) &&
                ((this.IsInvoicePoint == null && other.IsInvoicePoint == null) || (this.IsInvoicePoint?.Equals(other.IsInvoicePoint) == true)) &&
                ((this.MarketingSegmentation == null && other.MarketingSegmentation == null) || (this.MarketingSegmentation?.Equals(other.MarketingSegmentation) == true)) &&
                ((this.VATNumber == null && other.VATNumber == null) || (this.VATNumber?.Equals(other.VATNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.SelfSelectedPin == null && other.SelfSelectedPin == null) || (this.SelfSelectedPin?.Equals(other.SelfSelectedPin) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.DefaultPINAdviceType == null && other.DefaultPINAdviceType == null) || (this.DefaultPINAdviceType?.Equals(other.DefaultPINAdviceType) == true)) &&
                ((this.PINAdviceTypes == null && other.PINAdviceTypes == null) || (this.PINAdviceTypes?.Equals(other.PINAdviceTypes) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.PINChangeAllowedByCardholder == null && other.PINChangeAllowedByCardholder == null) || (this.PINChangeAllowedByCardholder?.Equals(other.PINChangeAllowedByCardholder) == true)) &&
                ((this.PINChangeAllowedFromFleetPIN == null && other.PINChangeAllowedFromFleetPIN == null) || (this.PINChangeAllowedFromFleetPIN?.Equals(other.PINChangeAllowedFromFleetPIN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.AccountTradingName = {(this.AccountTradingName == null ? "null" : this.AccountTradingName)}");
            toStringOutput.Add($"this.AllowFleetIdInput = {(this.AllowFleetIdInput == null ? "null" : this.AllowFleetIdInput.ToString())}");
            toStringOutput.Add($"this.Band = {(this.Band == null ? "null" : this.Band)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.CardGroupPosition = {(this.CardGroupPosition == null ? "null" : this.CardGroupPosition)}");
            toStringOutput.Add($"this.CorrespondenceAddress = {(this.CorrespondenceAddress == null ? "null" : this.CorrespondenceAddress.ToString())}");
            toStringOutput.Add($"this.DeliveryAddresses = {(this.DeliveryAddresses == null ? "null" : $"[{string.Join(", ", this.DeliveryAddresses)} ]")}");
            toStringOutput.Add($"this.FleetPin = {(this.FleetPin == null ? "null" : this.FleetPin.ToString())}");
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
            toStringOutput.Add($"this.InvoiceCustomerId = {(this.InvoiceCustomerId == null ? "null" : this.InvoiceCustomerId.ToString())}");
            toStringOutput.Add($"this.InvoiceCustomerShortName = {(this.InvoiceCustomerShortName == null ? "null" : this.InvoiceCustomerShortName)}");
            toStringOutput.Add($"this.IsInvoicePoint = {(this.IsInvoicePoint == null ? "null" : this.IsInvoicePoint.ToString())}");
            toStringOutput.Add($"this.MarketingSegmentation = {(this.MarketingSegmentation == null ? "null" : this.MarketingSegmentation)}");
            toStringOutput.Add($"this.VATNumber = {(this.VATNumber == null ? "null" : this.VATNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.SelfSelectedPin = {(this.SelfSelectedPin == null ? "null" : this.SelfSelectedPin.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.DefaultPINAdviceType = {(this.DefaultPINAdviceType == null ? "null" : this.DefaultPINAdviceType.ToString())}");
            toStringOutput.Add($"this.PINAdviceTypes = {(this.PINAdviceTypes == null ? "null" : $"[{string.Join(", ", this.PINAdviceTypes)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.PINChangeAllowedByCardholder = {(this.PINChangeAllowedByCardholder == null ? "null" : this.PINChangeAllowedByCardholder.ToString())}");
            toStringOutput.Add($"this.PINChangeAllowedFromFleetPIN = {(this.PINChangeAllowedFromFleetPIN == null ? "null" : this.PINChangeAllowedFromFleetPIN.ToString())}");
        }
    }
}
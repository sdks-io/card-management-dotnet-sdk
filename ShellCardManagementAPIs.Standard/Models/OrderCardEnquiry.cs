// <copyright file="OrderCardEnquiry.cs" company="APIMatic">
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
    /// OrderCardEnquiry.
    /// </summary>
    public class OrderCardEnquiry
    {
        private int? accountId;
        private string accountNumber;
        private int? bCOReference;
        private int? bCORowNumber;
        private int? cardGroupId;
        private string cardGroupName;
        private int? cardId;
        private string cardPAN;
        private string cardTypeCode;
        private int? cardTypeId;
        private string cardTypeName;
        private string driverName;
        private string errorCode;
        private string errorDescription;
        private string gatewaySyncErrorCode;
        private string gatewaySyncErrorDescription;
        private string gatewaySyncStatus;
        private string orderStatus;
        private string payerNumber;
        private string processedDate;
        private string purchaseCategoryCode;
        private int? purchaseCategoryId;
        private string purchaseCategoryName;
        private string submittedDate;
        private string syncProcessedDate;
        private string syncRequestedDate;
        private string vRN;
        private string orderRequestId;
        private string expiryDate;
        private string clientReferenceId;
        private string statusDescription;
        private int? colCoId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "BCOReference", false },
            { "BCORowNumber", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "CardId", false },
            { "CardPAN", false },
            { "CardTypeCode", false },
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "DriverName", false },
            { "ErrorCode", false },
            { "ErrorDescription", false },
            { "GatewaySyncErrorCode", false },
            { "GatewaySyncErrorDescription", false },
            { "GatewaySyncStatus", false },
            { "OrderStatus", false },
            { "PayerNumber", false },
            { "ProcessedDate", false },
            { "PurchaseCategoryCode", false },
            { "PurchaseCategoryId", false },
            { "PurchaseCategoryName", false },
            { "SubmittedDate", false },
            { "SyncProcessedDate", false },
            { "SyncRequestedDate", false },
            { "VRN", false },
            { "OrderRequestId", false },
            { "ExpiryDate", false },
            { "ClientReferenceId", false },
            { "StatusDescription", false },
            { "ColCoId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiry"/> class.
        /// </summary>
        public OrderCardEnquiry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCardEnquiry"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="bCOReference">BCOReference.</param>
        /// <param name="bCORowNumber">BCORowNumber.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="errorCode">ErrorCode.</param>
        /// <param name="errorDescription">ErrorDescription.</param>
        /// <param name="gatewaySyncErrorCode">GatewaySyncErrorCode.</param>
        /// <param name="gatewaySyncErrorDescription">GatewaySyncErrorDescription.</param>
        /// <param name="gatewaySyncStatus">GatewaySyncStatus.</param>
        /// <param name="mainReference">MainReference.</param>
        /// <param name="orderCardReference">OrderCardReference.</param>
        /// <param name="orderStatus">OrderStatus.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="processedDate">ProcessedDate.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryName">PurchaseCategoryName.</param>
        /// <param name="submittedDate">SubmittedDate.</param>
        /// <param name="syncProcessedDate">SyncProcessedDate.</param>
        /// <param name="syncRequestedDate">SyncRequestedDate.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="orderRequestId">OrderRequestId.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="clientReferenceId">ClientReferenceId.</param>
        /// <param name="statusDescription">StatusDescription.</param>
        /// <param name="colCoId">ColCoId.</param>
        public OrderCardEnquiry(
            int? accountId = null,
            string accountNumber = null,
            int? bCOReference = null,
            int? bCORowNumber = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            int? cardId = null,
            string cardPAN = null,
            string cardTypeCode = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            string driverName = null,
            string errorCode = null,
            string errorDescription = null,
            string gatewaySyncErrorCode = null,
            string gatewaySyncErrorDescription = null,
            string gatewaySyncStatus = null,
            int? mainReference = null,
            int? orderCardReference = null,
            string orderStatus = null,
            int? payerId = null,
            string payerNumber = null,
            string processedDate = null,
            string purchaseCategoryCode = null,
            int? purchaseCategoryId = null,
            string purchaseCategoryName = null,
            string submittedDate = null,
            string syncProcessedDate = null,
            string syncRequestedDate = null,
            string vRN = null,
            string orderRequestId = null,
            string expiryDate = null,
            string clientReferenceId = null,
            string statusDescription = null,
            int? colCoId = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (bCOReference != null)
            {
                this.BCOReference = bCOReference;
            }

            if (bCORowNumber != null)
            {
                this.BCORowNumber = bCORowNumber;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (cardTypeCode != null)
            {
                this.CardTypeCode = cardTypeCode;
            }

            if (cardTypeId != null)
            {
                this.CardTypeId = cardTypeId;
            }

            if (cardTypeName != null)
            {
                this.CardTypeName = cardTypeName;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (errorCode != null)
            {
                this.ErrorCode = errorCode;
            }

            if (errorDescription != null)
            {
                this.ErrorDescription = errorDescription;
            }

            if (gatewaySyncErrorCode != null)
            {
                this.GatewaySyncErrorCode = gatewaySyncErrorCode;
            }

            if (gatewaySyncErrorDescription != null)
            {
                this.GatewaySyncErrorDescription = gatewaySyncErrorDescription;
            }

            if (gatewaySyncStatus != null)
            {
                this.GatewaySyncStatus = gatewaySyncStatus;
            }

            this.MainReference = mainReference;
            this.OrderCardReference = orderCardReference;
            if (orderStatus != null)
            {
                this.OrderStatus = orderStatus;
            }

            this.PayerId = payerId;
            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (processedDate != null)
            {
                this.ProcessedDate = processedDate;
            }

            if (purchaseCategoryCode != null)
            {
                this.PurchaseCategoryCode = purchaseCategoryCode;
            }

            if (purchaseCategoryId != null)
            {
                this.PurchaseCategoryId = purchaseCategoryId;
            }

            if (purchaseCategoryName != null)
            {
                this.PurchaseCategoryName = purchaseCategoryName;
            }

            if (submittedDate != null)
            {
                this.SubmittedDate = submittedDate;
            }

            if (syncProcessedDate != null)
            {
                this.SyncProcessedDate = syncProcessedDate;
            }

            if (syncRequestedDate != null)
            {
                this.SyncRequestedDate = syncRequestedDate;
            }

            if (vRN != null)
            {
                this.VRN = vRN;
            }

            if (orderRequestId != null)
            {
                this.OrderRequestId = orderRequestId;
            }

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }

            if (clientReferenceId != null)
            {
                this.ClientReferenceId = clientReferenceId;
            }

            if (statusDescription != null)
            {
                this.StatusDescription = statusDescription;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

        }

        /// <summary>
        /// Account ID on the card request
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
        /// AccountNumber
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
        /// Bulk card order request refrence numer.<br />
        /// This field will be null if the order is not through BCO.
        /// </summary>
        [JsonProperty("BCOReference")]
        public int? BCOReference
        {
            get
            {
                return this.bCOReference;
            }

            set
            {
                this.shouldSerialize["BCOReference"] = true;
                this.bCOReference = value;
            }
        }

        /// <summary>
        /// Row number of the request in the BCO file.<br />
        /// This field will be null if the order is not through BCO.
        /// </summary>
        [JsonProperty("BCORowNumber")]
        public int? BCORowNumber
        {
            get
            {
                return this.bCORowNumber;
            }

            set
            {
                this.shouldSerialize["BCORowNumber"] = true;
                this.bCORowNumber = value;
            }
        }

        /// <summary>
        /// Card group ID
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
        /// Card group name
        /// </summary>
        [JsonProperty("CardGroupName")]
        public string CardGroupName
        {
            get
            {
                return this.cardGroupName;
            }

            set
            {
                this.shouldSerialize["CardGroupName"] = true;
                this.cardGroupName = value;
            }
        }

        /// <summary>
        /// Unique Card Id.<br />
        /// The field will be null if the card order request is not successly processed.
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// Card PAN.<br />
        /// Mask PAN (Mask all digits except the Last 6 digits of the PAN).<br />
        /// The field will be null if the card order request is not successly processed.
        /// </summary>
        [JsonProperty("CardPAN")]
        public string CardPAN
        {
            get
            {
                return this.cardPAN;
            }

            set
            {
                this.shouldSerialize["CardPAN"] = true;
                this.cardPAN = value;
            }
        }

        /// <summary>
        /// CardTypeCode<br />
        /// ISO code of the card i.e. first 7 digits of the PAN
        /// </summary>
        [JsonProperty("CardTypeCode")]
        public string CardTypeCode
        {
            get
            {
                return this.cardTypeCode;
            }

            set
            {
                this.shouldSerialize["CardTypeCode"] = true;
                this.cardTypeCode = value;
            }
        }

        /// <summary>
        /// CardTypeId
        /// </summary>
        [JsonProperty("CardTypeId")]
        public int? CardTypeId
        {
            get
            {
                return this.cardTypeId;
            }

            set
            {
                this.shouldSerialize["CardTypeId"] = true;
                this.cardTypeId = value;
            }
        }

        /// <summary>
        /// CardTypeName
        /// </summary>
        [JsonProperty("CardTypeName")]
        public string CardTypeName
        {
            get
            {
                return this.cardTypeName;
            }

            set
            {
                this.shouldSerialize["CardTypeName"] = true;
                this.cardTypeName = value;
            }
        }

        /// <summary>
        /// Driver name
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get
            {
                return this.driverName;
            }

            set
            {
                this.shouldSerialize["DriverName"] = true;
                this.driverName = value;
            }
        }

        /// <summary>
        /// Error code for the order card request.<br />
        /// The value will be 0000 if it is processed without errors.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode
        {
            get
            {
                return this.errorCode;
            }

            set
            {
                this.shouldSerialize["ErrorCode"] = true;
                this.errorCode = value;
            }
        }

        /// <summary>
        /// Error description for the order card request.<br />
        /// The value will be empty string if it is processed without errors.
        /// </summary>
        [JsonProperty("ErrorDescription")]
        public string ErrorDescription
        {
            get
            {
                return this.errorDescription;
            }

            set
            {
                this.shouldSerialize["ErrorDescription"] = true;
                this.errorDescription = value;
            }
        }

        /// <summary>
        /// Error code for the Gateway sync error.<br />
        /// The value will be 0000 if it is processed without errors.
        /// </summary>
        [JsonProperty("GatewaySyncErrorCode")]
        public string GatewaySyncErrorCode
        {
            get
            {
                return this.gatewaySyncErrorCode;
            }

            set
            {
                this.shouldSerialize["GatewaySyncErrorCode"] = true;
                this.gatewaySyncErrorCode = value;
            }
        }

        /// <summary>
        /// Error description for the Gateway sync error.<br />
        /// The value will be empty string if it is processed without errors.
        /// </summary>
        [JsonProperty("GatewaySyncErrorDescription")]
        public string GatewaySyncErrorDescription
        {
            get
            {
                return this.gatewaySyncErrorDescription;
            }

            set
            {
                this.shouldSerialize["GatewaySyncErrorDescription"] = true;
                this.gatewaySyncErrorDescription = value;
            }
        }

        /// <summary>
        /// GatewaySyncStatus<br />
        /// Status of the card sync with CFGW.<br />
        /// Possible values:<br />
        /// -Success<br />
        /// -Failed<br />
        /// -In Progress<br />
        /// -Not Submitted
        /// </summary>
        [JsonProperty("GatewaySyncStatus")]
        public string GatewaySyncStatus
        {
            get
            {
                return this.gatewaySyncStatus;
            }

            set
            {
                this.shouldSerialize["GatewaySyncStatus"] = true;
                this.gatewaySyncStatus = value;
            }
        }

        /// <summary>
        /// Main reference number for the order card request.<br />
        /// This field will be null if the order is through BCO.
        /// </summary>
        [JsonProperty("MainReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? MainReference { get; set; }

        /// <summary>
        /// Indivitual card reference number for the order card request.<br />
        /// This field will be null if the order is through BCO.
        /// </summary>
        [JsonProperty("OrderCardReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderCardReference { get; set; }

        /// <summary>
        /// Order status.<br />
        /// Possible values:<br />
        /// P   Pending<br />
        /// I   Picked up for processing<br />
        /// PX	Failed at Queue but retry attempts pending<br />
        /// X	Failed  at Queue<br />
        /// R	Card is processed, awaiting for PAN update.<br />
        /// S	Processed<br />
        /// F	Failed
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus
        {
            get
            {
                return this.orderStatus;
            }

            set
            {
                this.shouldSerialize["OrderStatus"] = true;
                this.orderStatus = value;
            }
        }

        /// <summary>
        /// Payer ID on the card request.
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number on the card request
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
        /// Date and time (in cutomers local time) when the card order request is processed<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: The client application to convert the string to appropriate date/time type.
        /// </summary>
        [JsonProperty("ProcessedDate")]
        public string ProcessedDate
        {
            get
            {
                return this.processedDate;
            }

            set
            {
                this.shouldSerialize["ProcessedDate"] = true;
                this.processedDate = value;
            }
        }

        /// <summary>
        /// PurchaseCategoryCode
        /// </summary>
        [JsonProperty("PurchaseCategoryCode")]
        public string PurchaseCategoryCode
        {
            get
            {
                return this.purchaseCategoryCode;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryCode"] = true;
                this.purchaseCategoryCode = value;
            }
        }

        /// <summary>
        /// PurchaseCategoryId <br />
        /// Note: Not Purchase code. This is a unique purchase category id assigned
        /// </summary>
        [JsonProperty("PurchaseCategoryId")]
        public int? PurchaseCategoryId
        {
            get
            {
                return this.purchaseCategoryId;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryId"] = true;
                this.purchaseCategoryId = value;
            }
        }

        /// <summary>
        /// PurchaseCategoryName
        /// </summary>
        [JsonProperty("PurchaseCategoryName")]
        public string PurchaseCategoryName
        {
            get
            {
                return this.purchaseCategoryName;
            }

            set
            {
                this.shouldSerialize["PurchaseCategoryName"] = true;
                this.purchaseCategoryName = value;
            }
        }

        /// <summary>
        /// Date and time (in cutomers local time) when the card order request is submitted.<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: The client application to convert the string to appropriate date/time type.
        /// </summary>
        [JsonProperty("SubmittedDate")]
        public string SubmittedDate
        {
            get
            {
                return this.submittedDate;
            }

            set
            {
                this.shouldSerialize["SubmittedDate"] = true;
                this.submittedDate = value;
            }
        }

        /// <summary>
        /// SyncProcessedDate<br />
        /// Date and time (in cutomers local time) when the sync card request is processed.<br />
        /// Format: yyyyMMdd HH:mm:ss<br />
        /// Note: The client application to convert the string to appropriate date/time type.
        /// </summary>
        [JsonProperty("SyncProcessedDate")]
        public string SyncProcessedDate
        {
            get
            {
                return this.syncProcessedDate;
            }

            set
            {
                this.shouldSerialize["SyncProcessedDate"] = true;
                this.syncProcessedDate = value;
            }
        }

        /// <summary>
        /// SyncRequestedDate<br />
        /// Date and time (in cutomers local time) when the sync card request is submitted.<br />
        /// Format: yyyyMMdd HH:mm:ss <br />
        /// Note: The client application to convert the string to appropriate date/time type.
        /// </summary>
        [JsonProperty("SyncRequestedDate")]
        public string SyncRequestedDate
        {
            get
            {
                return this.syncRequestedDate;
            }

            set
            {
                this.shouldSerialize["SyncRequestedDate"] = true;
                this.syncRequestedDate = value;
            }
        }

        /// <summary>
        /// Vehicle registration number
        /// </summary>
        [JsonProperty("VRN")]
        public string VRN
        {
            get
            {
                return this.vRN;
            }

            set
            {
                this.shouldSerialize["VRN"] = true;
                this.vRN = value;
            }
        }

        /// <summary>
        /// Unique Id of the Original Order card request, the status of which is enquired by this API. <br />
        /// This is returned for end to end traceability of a request based on the original Order Card request.
        /// </summary>
        [JsonProperty("OrderRequestId")]
        public string OrderRequestId
        {
            get
            {
                return this.orderRequestId;
            }

            set
            {
                this.shouldSerialize["OrderRequestId"] = true;
                this.orderRequestId = value;
            }
        }

        /// <summary>
        /// Expiry date of the card.<br />
        /// Format: MMyy<br />
        /// (Clients to convert this to appropriate DateTime type.)<br />
        /// Note: This is the Expiry Date saved.<br />
        /// If the Order Card request is still not processed, i.e.PAN is not yet issued, this field will be null or empty. <br />
        /// For a Card Order with a custom Expiry Date passed in the request, this value will be returned after it is updated successfully.
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

        /// <summary>
        /// This is the Client Reference Id of card in the order which needs to be passed by the client.
        /// </summary>
        [JsonProperty("ClientReferenceId")]
        public string ClientReferenceId
        {
            get
            {
                return this.clientReferenceId;
            }

            set
            {
                this.shouldSerialize["ClientReferenceId"] = true;
                this.clientReferenceId = value;
            }
        }

        /// <summary>
        /// Order status.<br />
        /// Possible values<br />
        ///  Success<br />
        ///  Failed<br />
        ///  InProgress<br />
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription
        {
            get
            {
                return this.statusDescription;
            }

            set
            {
                this.shouldSerialize["StatusDescription"] = true;
                this.statusDescription = value;
            }
        }

        /// <summary>
        /// Colcoid
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderCardEnquiry : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBCOReference()
        {
            this.shouldSerialize["BCOReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBCORowNumber()
        {
            this.shouldSerialize["BCORowNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardPAN()
        {
            this.shouldSerialize["CardPAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeCode()
        {
            this.shouldSerialize["CardTypeCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeId()
        {
            this.shouldSerialize["CardTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeName()
        {
            this.shouldSerialize["CardTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrorCode()
        {
            this.shouldSerialize["ErrorCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrorDescription()
        {
            this.shouldSerialize["ErrorDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGatewaySyncErrorCode()
        {
            this.shouldSerialize["GatewaySyncErrorCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGatewaySyncErrorDescription()
        {
            this.shouldSerialize["GatewaySyncErrorDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGatewaySyncStatus()
        {
            this.shouldSerialize["GatewaySyncStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOrderStatus()
        {
            this.shouldSerialize["OrderStatus"] = false;
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
        public void UnsetProcessedDate()
        {
            this.shouldSerialize["ProcessedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchaseCategoryCode()
        {
            this.shouldSerialize["PurchaseCategoryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchaseCategoryId()
        {
            this.shouldSerialize["PurchaseCategoryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchaseCategoryName()
        {
            this.shouldSerialize["PurchaseCategoryName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubmittedDate()
        {
            this.shouldSerialize["SubmittedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSyncProcessedDate()
        {
            this.shouldSerialize["SyncProcessedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSyncRequestedDate()
        {
            this.shouldSerialize["SyncRequestedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOrderRequestId()
        {
            this.shouldSerialize["OrderRequestId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiryDate()
        {
            this.shouldSerialize["ExpiryDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClientReferenceId()
        {
            this.shouldSerialize["ClientReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatusDescription()
        {
            this.shouldSerialize["StatusDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
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
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBCOReference()
        {
            return this.shouldSerialize["BCOReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBCORowNumber()
        {
            return this.shouldSerialize["BCORowNumber"];
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
        public bool ShouldSerializeCardGroupName()
        {
            return this.shouldSerialize["CardGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardPAN()
        {
            return this.shouldSerialize["CardPAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeCode()
        {
            return this.shouldSerialize["CardTypeCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeId()
        {
            return this.shouldSerialize["CardTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeName()
        {
            return this.shouldSerialize["CardTypeName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorCode()
        {
            return this.shouldSerialize["ErrorCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorDescription()
        {
            return this.shouldSerialize["ErrorDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewaySyncErrorCode()
        {
            return this.shouldSerialize["GatewaySyncErrorCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewaySyncErrorDescription()
        {
            return this.shouldSerialize["GatewaySyncErrorDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewaySyncStatus()
        {
            return this.shouldSerialize["GatewaySyncStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrderStatus()
        {
            return this.shouldSerialize["OrderStatus"];
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
        public bool ShouldSerializeProcessedDate()
        {
            return this.shouldSerialize["ProcessedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategoryCode()
        {
            return this.shouldSerialize["PurchaseCategoryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategoryId()
        {
            return this.shouldSerialize["PurchaseCategoryId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseCategoryName()
        {
            return this.shouldSerialize["PurchaseCategoryName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubmittedDate()
        {
            return this.shouldSerialize["SubmittedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSyncProcessedDate()
        {
            return this.shouldSerialize["SyncProcessedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSyncRequestedDate()
        {
            return this.shouldSerialize["SyncRequestedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVRN()
        {
            return this.shouldSerialize["VRN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrderRequestId()
        {
            return this.shouldSerialize["OrderRequestId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryDate()
        {
            return this.shouldSerialize["ExpiryDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClientReferenceId()
        {
            return this.shouldSerialize["ClientReferenceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatusDescription()
        {
            return this.shouldSerialize["StatusDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
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
            return obj is OrderCardEnquiry other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.BCOReference == null && other.BCOReference == null) || (this.BCOReference?.Equals(other.BCOReference) == true)) &&
                ((this.BCORowNumber == null && other.BCORowNumber == null) || (this.BCORowNumber?.Equals(other.BCORowNumber) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.CardTypeCode == null && other.CardTypeCode == null) || (this.CardTypeCode?.Equals(other.CardTypeCode) == true)) &&
                ((this.CardTypeId == null && other.CardTypeId == null) || (this.CardTypeId?.Equals(other.CardTypeId) == true)) &&
                ((this.CardTypeName == null && other.CardTypeName == null) || (this.CardTypeName?.Equals(other.CardTypeName) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.ErrorCode == null && other.ErrorCode == null) || (this.ErrorCode?.Equals(other.ErrorCode) == true)) &&
                ((this.ErrorDescription == null && other.ErrorDescription == null) || (this.ErrorDescription?.Equals(other.ErrorDescription) == true)) &&
                ((this.GatewaySyncErrorCode == null && other.GatewaySyncErrorCode == null) || (this.GatewaySyncErrorCode?.Equals(other.GatewaySyncErrorCode) == true)) &&
                ((this.GatewaySyncErrorDescription == null && other.GatewaySyncErrorDescription == null) || (this.GatewaySyncErrorDescription?.Equals(other.GatewaySyncErrorDescription) == true)) &&
                ((this.GatewaySyncStatus == null && other.GatewaySyncStatus == null) || (this.GatewaySyncStatus?.Equals(other.GatewaySyncStatus) == true)) &&
                ((this.MainReference == null && other.MainReference == null) || (this.MainReference?.Equals(other.MainReference) == true)) &&
                ((this.OrderCardReference == null && other.OrderCardReference == null) || (this.OrderCardReference?.Equals(other.OrderCardReference) == true)) &&
                ((this.OrderStatus == null && other.OrderStatus == null) || (this.OrderStatus?.Equals(other.OrderStatus) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.ProcessedDate == null && other.ProcessedDate == null) || (this.ProcessedDate?.Equals(other.ProcessedDate) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.PurchaseCategoryId == null && other.PurchaseCategoryId == null) || (this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true)) &&
                ((this.PurchaseCategoryName == null && other.PurchaseCategoryName == null) || (this.PurchaseCategoryName?.Equals(other.PurchaseCategoryName) == true)) &&
                ((this.SubmittedDate == null && other.SubmittedDate == null) || (this.SubmittedDate?.Equals(other.SubmittedDate) == true)) &&
                ((this.SyncProcessedDate == null && other.SyncProcessedDate == null) || (this.SyncProcessedDate?.Equals(other.SyncProcessedDate) == true)) &&
                ((this.SyncRequestedDate == null && other.SyncRequestedDate == null) || (this.SyncRequestedDate?.Equals(other.SyncRequestedDate) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true)) &&
                ((this.OrderRequestId == null && other.OrderRequestId == null) || (this.OrderRequestId?.Equals(other.OrderRequestId) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true)) &&
                ((this.ClientReferenceId == null && other.ClientReferenceId == null) || (this.ClientReferenceId?.Equals(other.ClientReferenceId) == true)) &&
                ((this.StatusDescription == null && other.StatusDescription == null) || (this.StatusDescription?.Equals(other.StatusDescription) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.BCOReference = {(this.BCOReference == null ? "null" : this.BCOReference.ToString())}");
            toStringOutput.Add($"this.BCORowNumber = {(this.BCORowNumber == null ? "null" : this.BCORowNumber.ToString())}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.CardTypeCode = {(this.CardTypeCode == null ? "null" : this.CardTypeCode)}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.CardTypeName = {(this.CardTypeName == null ? "null" : this.CardTypeName)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode)}");
            toStringOutput.Add($"this.ErrorDescription = {(this.ErrorDescription == null ? "null" : this.ErrorDescription)}");
            toStringOutput.Add($"this.GatewaySyncErrorCode = {(this.GatewaySyncErrorCode == null ? "null" : this.GatewaySyncErrorCode)}");
            toStringOutput.Add($"this.GatewaySyncErrorDescription = {(this.GatewaySyncErrorDescription == null ? "null" : this.GatewaySyncErrorDescription)}");
            toStringOutput.Add($"this.GatewaySyncStatus = {(this.GatewaySyncStatus == null ? "null" : this.GatewaySyncStatus)}");
            toStringOutput.Add($"this.MainReference = {(this.MainReference == null ? "null" : this.MainReference.ToString())}");
            toStringOutput.Add($"this.OrderCardReference = {(this.OrderCardReference == null ? "null" : this.OrderCardReference.ToString())}");
            toStringOutput.Add($"this.OrderStatus = {(this.OrderStatus == null ? "null" : this.OrderStatus)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.ProcessedDate = {(this.ProcessedDate == null ? "null" : this.ProcessedDate)}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryName = {(this.PurchaseCategoryName == null ? "null" : this.PurchaseCategoryName)}");
            toStringOutput.Add($"this.SubmittedDate = {(this.SubmittedDate == null ? "null" : this.SubmittedDate)}");
            toStringOutput.Add($"this.SyncProcessedDate = {(this.SyncProcessedDate == null ? "null" : this.SyncProcessedDate)}");
            toStringOutput.Add($"this.SyncRequestedDate = {(this.SyncRequestedDate == null ? "null" : this.SyncRequestedDate)}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
            toStringOutput.Add($"this.OrderRequestId = {(this.OrderRequestId == null ? "null" : this.OrderRequestId)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
            toStringOutput.Add($"this.ClientReferenceId = {(this.ClientReferenceId == null ? "null" : this.ClientReferenceId)}");
            toStringOutput.Add($"this.StatusDescription = {(this.StatusDescription == null ? "null" : this.StatusDescription)}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
        }
    }
}
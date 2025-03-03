// <copyright file="AuditResponseAuditsItems.cs" company="APIMatic">
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
    /// AuditResponseAuditsItems.
    /// </summary>
    public class AuditResponseAuditsItems
    {
        private int? accountId;
        private string accountNumber;
        private string additionalInformation1;
        private string additionalInformation2;
        private string additionalInformation3;
        private string additionalInformation4;
        private string additionalInformation5;
        private string additionalInformation6;
        private string additionalInformation7;
        private string additionalInformation8;
        private string additionalInformation9;
        private int? cardGroupId;
        private string cardGroupName;
        private int? cardId;
        private int? colCoCode;
        private int? colCoId;
        private string errorString;
        private string globalRequestID;
        private string pAN;
        private int? payerId;
        private string payerNumber;
        private string processedOn;
        private string requestedBy;
        private string requestedOperation;
        private int? requestReference;
        private string requestType;
        private string status;
        private string submittedOn;
        private int? subRequestReference;
        private string userDisplayName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "AdditionalInformation1", false },
            { "AdditionalInformation2", false },
            { "AdditionalInformation3", false },
            { "AdditionalInformation4", false },
            { "AdditionalInformation5", false },
            { "AdditionalInformation6", false },
            { "AdditionalInformation7", false },
            { "AdditionalInformation8", false },
            { "AdditionalInformation9", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "CardId", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "ErrorString", false },
            { "GlobalRequestID", false },
            { "PAN", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "ProcessedOn", false },
            { "RequestedBy", false },
            { "RequestedOperation", false },
            { "RequestReference", false },
            { "RequestType", false },
            { "Status", false },
            { "SubmittedOn", false },
            { "SubRequestReference", false },
            { "UserDisplayName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditResponseAuditsItems"/> class.
        /// </summary>
        public AuditResponseAuditsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditResponseAuditsItems"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="additionalInformation1">AdditionalInformation1.</param>
        /// <param name="additionalInformation2">AdditionalInformation2.</param>
        /// <param name="additionalInformation3">AdditionalInformation3.</param>
        /// <param name="additionalInformation4">AdditionalInformation4.</param>
        /// <param name="additionalInformation5">AdditionalInformation5.</param>
        /// <param name="additionalInformation6">AdditionalInformation6.</param>
        /// <param name="additionalInformation7">AdditionalInformation7.</param>
        /// <param name="additionalInformation8">AdditionalInformation8.</param>
        /// <param name="additionalInformation9">AdditionalInformation9.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="errorCode">ErrorCode.</param>
        /// <param name="errorString">ErrorString.</param>
        /// <param name="globalRequestID">GlobalRequestID.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="processedOn">ProcessedOn.</param>
        /// <param name="requestedBy">RequestedBy.</param>
        /// <param name="requestedOperation">RequestedOperation.</param>
        /// <param name="requestReference">RequestReference.</param>
        /// <param name="requestType">RequestType.</param>
        /// <param name="status">Status.</param>
        /// <param name="submittedOn">SubmittedOn.</param>
        /// <param name="subRequestReference">SubRequestReference.</param>
        /// <param name="userDisplayName">UserDisplayName.</param>
        public AuditResponseAuditsItems(
            int? accountId = null,
            string accountNumber = null,
            string additionalInformation1 = null,
            string additionalInformation2 = null,
            string additionalInformation3 = null,
            string additionalInformation4 = null,
            string additionalInformation5 = null,
            string additionalInformation6 = null,
            string additionalInformation7 = null,
            string additionalInformation8 = null,
            string additionalInformation9 = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            int? cardId = null,
            int? colCoCode = null,
            int? colCoId = null,
            string errorCode = null,
            string errorString = null,
            string globalRequestID = null,
            string pAN = null,
            int? payerId = null,
            string payerNumber = null,
            string processedOn = null,
            string requestedBy = null,
            string requestedOperation = null,
            int? requestReference = null,
            string requestType = null,
            string status = null,
            string submittedOn = null,
            int? subRequestReference = null,
            string userDisplayName = null)
        {

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (additionalInformation1 != null)
            {
                this.AdditionalInformation1 = additionalInformation1;
            }

            if (additionalInformation2 != null)
            {
                this.AdditionalInformation2 = additionalInformation2;
            }

            if (additionalInformation3 != null)
            {
                this.AdditionalInformation3 = additionalInformation3;
            }

            if (additionalInformation4 != null)
            {
                this.AdditionalInformation4 = additionalInformation4;
            }

            if (additionalInformation5 != null)
            {
                this.AdditionalInformation5 = additionalInformation5;
            }

            if (additionalInformation6 != null)
            {
                this.AdditionalInformation6 = additionalInformation6;
            }

            if (additionalInformation7 != null)
            {
                this.AdditionalInformation7 = additionalInformation7;
            }

            if (additionalInformation8 != null)
            {
                this.AdditionalInformation8 = additionalInformation8;
            }

            if (additionalInformation9 != null)
            {
                this.AdditionalInformation9 = additionalInformation9;
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

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }
            this.ErrorCode = errorCode;

            if (errorString != null)
            {
                this.ErrorString = errorString;
            }

            if (globalRequestID != null)
            {
                this.GlobalRequestID = globalRequestID;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (processedOn != null)
            {
                this.ProcessedOn = processedOn;
            }

            if (requestedBy != null)
            {
                this.RequestedBy = requestedBy;
            }

            if (requestedOperation != null)
            {
                this.RequestedOperation = requestedOperation;
            }

            if (requestReference != null)
            {
                this.RequestReference = requestReference;
            }

            if (requestType != null)
            {
                this.RequestType = requestType;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (submittedOn != null)
            {
                this.SubmittedOn = submittedOn;
            }

            if (subRequestReference != null)
            {
                this.SubRequestReference = subRequestReference;
            }

            if (userDisplayName != null)
            {
                this.UserDisplayName = userDisplayName;
            }
        }

        /// <summary>
        /// Account id of the customer.
        /// It will be the source account id in case of “Fund Transfer
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
        /// Account number of the customer.
        /// It will be the source account number in case of “Fund Transfer”
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
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation1")]
        public string AdditionalInformation1
        {
            get
            {
                return this.additionalInformation1;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation1"] = true;
                this.additionalInformation1 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation2")]
        public string AdditionalInformation2
        {
            get
            {
                return this.additionalInformation2;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation2"] = true;
                this.additionalInformation2 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation3")]
        public string AdditionalInformation3
        {
            get
            {
                return this.additionalInformation3;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation3"] = true;
                this.additionalInformation3 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation4")]
        public string AdditionalInformation4
        {
            get
            {
                return this.additionalInformation4;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation4"] = true;
                this.additionalInformation4 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation5")]
        public string AdditionalInformation5
        {
            get
            {
                return this.additionalInformation5;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation5"] = true;
                this.additionalInformation5 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation6")]
        public string AdditionalInformation6
        {
            get
            {
                return this.additionalInformation6;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation6"] = true;
                this.additionalInformation6 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation7")]
        public string AdditionalInformation7
        {
            get
            {
                return this.additionalInformation7;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation7"] = true;
                this.additionalInformation7 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation8")]
        public string AdditionalInformation8
        {
            get
            {
                return this.additionalInformation8;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation8"] = true;
                this.additionalInformation8 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
        /// </summary>
        [JsonProperty("AdditionalInformation9")]
        public string AdditionalInformation9
        {
            get
            {
                return this.additionalInformation9;
            }

            set
            {
                this.shouldSerialize["AdditionalInformation9"] = true;
                this.additionalInformation9 = value;
            }
        }

        /// <summary>
        /// Additional information in the request.
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
        /// Card group name in the request.
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
        /// Card Id in the request
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
        /// Collecting company code of the customer
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Collecting company id of the customer.
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

        /// <summary>
        /// Error code of the request
        /// </summary>
        [JsonProperty("ErrorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error description of the request
        /// </summary>
        [JsonProperty("ErrorString")]
        public string ErrorString
        {
            get
            {
                return this.errorString;
            }

            set
            {
                this.shouldSerialize["ErrorString"] = true;
                this.errorString = value;
            }
        }

        /// <summary>
        /// Global unique request reference provided by client application.
        /// </summary>
        [JsonProperty("GlobalRequestID")]
        public string GlobalRequestID
        {
            get
            {
                return this.globalRequestID;
            }

            set
            {
                this.shouldSerialize["GlobalRequestID"] = true;
                this.globalRequestID = value;
            }
        }

        /// <summary>
        /// PAN in the request.
        /// If Mask PAN is enabled at Microservices configuration then all digits of the PAN, except the last 6 digits, will be masked.
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
            }
        }

        /// <summary>
        /// Payer id of the customer.
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
        /// Payer number of the customer.
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
        /// Request processed date.
        /// Format: yyyyMMdd HH:mm: ss
        /// </summary>
        [JsonProperty("ProcessedOn")]
        public string ProcessedOn
        {
            get
            {
                return this.processedOn;
            }

            set
            {
                this.shouldSerialize["ProcessedOn"] = true;
                this.processedOn = value;
            }
        }

        /// <summary>
        /// vUUID of the user who submitted this request.
        /// It will be the UUID of the Driver in the case of “MobilePaymentRegistration”
        /// </summary>
        [JsonProperty("RequestedBy")]
        public string RequestedBy
        {
            get
            {
                return this.requestedBy;
            }

            set
            {
                this.shouldSerialize["RequestedBy"] = true;
                this.requestedBy = value;
            }
        }

        /// <summary>
        /// User requested operation.
        /// Possible values:
        /// •    OrderCard
        /// •    CreateCardGroup
        /// •    PINReminder
        /// •    MoveCard
        /// •    UpdateCardStatus
        /// •    UpdateCardGroup
        /// •    AutoRenew
        /// •    BulkCardOrder
        /// •    BulkCardBlock
        /// •    BulkCardOrderMultiAccount
        /// •    MobilePaymentRegistration
        /// •    UpdateCompanyInfo
        /// •    BCOSummary
        /// •    BCOMultiAccountSummary
        /// •    BCBSummary
        /// •    FundTransfer
        /// •    DeliveryAddressUpdate
        /// </summary>
        [JsonProperty("RequestedOperation")]
        public string RequestedOperation
        {
            get
            {
                return this.requestedOperation;
            }

            set
            {
                this.shouldSerialize["RequestedOperation"] = true;
                this.requestedOperation = value;
            }
        }

        /// <summary>
        /// Reference number for the requested operation.
        /// </summary>
        [JsonProperty("RequestReference")]
        public int? RequestReference
        {
            get
            {
                return this.requestReference;
            }

            set
            {
                this.shouldSerialize["RequestReference"] = true;
                this.requestReference = value;
            }
        }

        /// <summary>
        /// Request type initiated under the requested operation.
        /// Possible values:
        /// •    OrderCard
        /// •    CreateCardGroup
        /// •    PINReminder
        /// •    MoveCard
        /// •    UpdateCardStatus
        /// •    UpdateCardGroup
        /// •    AutoRenew
        /// •    BulkCardOrder
        /// •    BulkCardBlock
        /// •    BulkCardOrderMultiAccount
        /// •    MobilePaymentRegistration
        /// •    UpdateCompanyInfo
        /// •    BCOSummary
        /// •    BCOMultiAccountSummary
        /// •    BCBSummary
        /// •    FundTransfer
        /// •    DeliveryAddressUpdate
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType
        {
            get
            {
                return this.requestType;
            }

            set
            {
                this.shouldSerialize["RequestType"] = true;
                this.requestType = value;
            }
        }

        /// <summary>
        /// Status of the request.
        /// Possible values:
        /// •    Success
        /// •    Failed
        /// •    InProgress
        /// •    Submitted
        /// •    Rejected
        /// •    PendingApproval
        /// •    MailedToCSC
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
        /// Request submitted date.
        /// Format: yyyyMMdd HH:mm: ss
        /// </summary>
        [JsonProperty("SubmittedOn")]
        public string SubmittedOn
        {
            get
            {
                return this.submittedOn;
            }

            set
            {
                this.shouldSerialize["SubmittedOn"] = true;
                this.submittedOn = value;
            }
        }

        /// <summary>
        /// Reference number for the individual request type.
        /// </summary>
        [JsonProperty("SubRequestReference")]
        public int? SubRequestReference
        {
            get
            {
                return this.subRequestReference;
            }

            set
            {
                this.shouldSerialize["SubRequestReference"] = true;
                this.subRequestReference = value;
            }
        }

        /// <summary>
        /// Display name of the user who submitted this request.
        /// It will be the Display Name of the Driver in the case of “MobilePaymentRegistration” in the below format:
        /// </summary>
        [JsonProperty("UserDisplayName")]
        public string UserDisplayName
        {
            get
            {
                return this.userDisplayName;
            }

            set
            {
                this.shouldSerialize["UserDisplayName"] = true;
                this.userDisplayName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AuditResponseAuditsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation1()
        {
            this.shouldSerialize["AdditionalInformation1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation2()
        {
            this.shouldSerialize["AdditionalInformation2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation3()
        {
            this.shouldSerialize["AdditionalInformation3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation4()
        {
            this.shouldSerialize["AdditionalInformation4"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation5()
        {
            this.shouldSerialize["AdditionalInformation5"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation6()
        {
            this.shouldSerialize["AdditionalInformation6"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation7()
        {
            this.shouldSerialize["AdditionalInformation7"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation8()
        {
            this.shouldSerialize["AdditionalInformation8"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation9()
        {
            this.shouldSerialize["AdditionalInformation9"] = false;
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
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetErrorString()
        {
            this.shouldSerialize["ErrorString"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGlobalRequestID()
        {
            this.shouldSerialize["GlobalRequestID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProcessedOn()
        {
            this.shouldSerialize["ProcessedOn"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestedBy()
        {
            this.shouldSerialize["RequestedBy"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestedOperation()
        {
            this.shouldSerialize["RequestedOperation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestReference()
        {
            this.shouldSerialize["RequestReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestType()
        {
            this.shouldSerialize["RequestType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubmittedOn()
        {
            this.shouldSerialize["SubmittedOn"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubRequestReference()
        {
            this.shouldSerialize["SubRequestReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserDisplayName()
        {
            this.shouldSerialize["UserDisplayName"] = false;
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
        public bool ShouldSerializeAdditionalInformation1()
        {
            return this.shouldSerialize["AdditionalInformation1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation2()
        {
            return this.shouldSerialize["AdditionalInformation2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation3()
        {
            return this.shouldSerialize["AdditionalInformation3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation4()
        {
            return this.shouldSerialize["AdditionalInformation4"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation5()
        {
            return this.shouldSerialize["AdditionalInformation5"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation6()
        {
            return this.shouldSerialize["AdditionalInformation6"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation7()
        {
            return this.shouldSerialize["AdditionalInformation7"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation8()
        {
            return this.shouldSerialize["AdditionalInformation8"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation9()
        {
            return this.shouldSerialize["AdditionalInformation9"];
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorString()
        {
            return this.shouldSerialize["ErrorString"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGlobalRequestID()
        {
            return this.shouldSerialize["GlobalRequestID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
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
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProcessedOn()
        {
            return this.shouldSerialize["ProcessedOn"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestedBy()
        {
            return this.shouldSerialize["RequestedBy"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestedOperation()
        {
            return this.shouldSerialize["RequestedOperation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestReference()
        {
            return this.shouldSerialize["RequestReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestType()
        {
            return this.shouldSerialize["RequestType"];
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
        public bool ShouldSerializeSubmittedOn()
        {
            return this.shouldSerialize["SubmittedOn"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubRequestReference()
        {
            return this.shouldSerialize["SubRequestReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserDisplayName()
        {
            return this.shouldSerialize["UserDisplayName"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AuditResponseAuditsItems other &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AdditionalInformation1 == null && other.AdditionalInformation1 == null ||
                 this.AdditionalInformation1?.Equals(other.AdditionalInformation1) == true) &&
                (this.AdditionalInformation2 == null && other.AdditionalInformation2 == null ||
                 this.AdditionalInformation2?.Equals(other.AdditionalInformation2) == true) &&
                (this.AdditionalInformation3 == null && other.AdditionalInformation3 == null ||
                 this.AdditionalInformation3?.Equals(other.AdditionalInformation3) == true) &&
                (this.AdditionalInformation4 == null && other.AdditionalInformation4 == null ||
                 this.AdditionalInformation4?.Equals(other.AdditionalInformation4) == true) &&
                (this.AdditionalInformation5 == null && other.AdditionalInformation5 == null ||
                 this.AdditionalInformation5?.Equals(other.AdditionalInformation5) == true) &&
                (this.AdditionalInformation6 == null && other.AdditionalInformation6 == null ||
                 this.AdditionalInformation6?.Equals(other.AdditionalInformation6) == true) &&
                (this.AdditionalInformation7 == null && other.AdditionalInformation7 == null ||
                 this.AdditionalInformation7?.Equals(other.AdditionalInformation7) == true) &&
                (this.AdditionalInformation8 == null && other.AdditionalInformation8 == null ||
                 this.AdditionalInformation8?.Equals(other.AdditionalInformation8) == true) &&
                (this.AdditionalInformation9 == null && other.AdditionalInformation9 == null ||
                 this.AdditionalInformation9?.Equals(other.AdditionalInformation9) == true) &&
                (this.CardGroupId == null && other.CardGroupId == null ||
                 this.CardGroupId?.Equals(other.CardGroupId) == true) &&
                (this.CardGroupName == null && other.CardGroupName == null ||
                 this.CardGroupName?.Equals(other.CardGroupName) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.ErrorCode == null && other.ErrorCode == null ||
                 this.ErrorCode?.Equals(other.ErrorCode) == true) &&
                (this.ErrorString == null && other.ErrorString == null ||
                 this.ErrorString?.Equals(other.ErrorString) == true) &&
                (this.GlobalRequestID == null && other.GlobalRequestID == null ||
                 this.GlobalRequestID?.Equals(other.GlobalRequestID) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.ProcessedOn == null && other.ProcessedOn == null ||
                 this.ProcessedOn?.Equals(other.ProcessedOn) == true) &&
                (this.RequestedBy == null && other.RequestedBy == null ||
                 this.RequestedBy?.Equals(other.RequestedBy) == true) &&
                (this.RequestedOperation == null && other.RequestedOperation == null ||
                 this.RequestedOperation?.Equals(other.RequestedOperation) == true) &&
                (this.RequestReference == null && other.RequestReference == null ||
                 this.RequestReference?.Equals(other.RequestReference) == true) &&
                (this.RequestType == null && other.RequestType == null ||
                 this.RequestType?.Equals(other.RequestType) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.SubmittedOn == null && other.SubmittedOn == null ||
                 this.SubmittedOn?.Equals(other.SubmittedOn) == true) &&
                (this.SubRequestReference == null && other.SubRequestReference == null ||
                 this.SubRequestReference?.Equals(other.SubRequestReference) == true) &&
                (this.UserDisplayName == null && other.UserDisplayName == null ||
                 this.UserDisplayName?.Equals(other.UserDisplayName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AdditionalInformation1 = {this.AdditionalInformation1 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation2 = {this.AdditionalInformation2 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation3 = {this.AdditionalInformation3 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation4 = {this.AdditionalInformation4 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation5 = {this.AdditionalInformation5 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation6 = {this.AdditionalInformation6 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation7 = {this.AdditionalInformation7 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation8 = {this.AdditionalInformation8 ?? "null"}");
            toStringOutput.Add($"AdditionalInformation9 = {this.AdditionalInformation9 ?? "null"}");
            toStringOutput.Add($"CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"CardGroupName = {this.CardGroupName ?? "null"}");
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"ErrorCode = {this.ErrorCode ?? "null"}");
            toStringOutput.Add($"ErrorString = {this.ErrorString ?? "null"}");
            toStringOutput.Add($"GlobalRequestID = {this.GlobalRequestID ?? "null"}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"ProcessedOn = {this.ProcessedOn ?? "null"}");
            toStringOutput.Add($"RequestedBy = {this.RequestedBy ?? "null"}");
            toStringOutput.Add($"RequestedOperation = {this.RequestedOperation ?? "null"}");
            toStringOutput.Add($"RequestReference = {(this.RequestReference == null ? "null" : this.RequestReference.ToString())}");
            toStringOutput.Add($"RequestType = {this.RequestType ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"SubmittedOn = {this.SubmittedOn ?? "null"}");
            toStringOutput.Add($"SubRequestReference = {(this.SubRequestReference == null ? "null" : this.SubRequestReference.ToString())}");
            toStringOutput.Add($"UserDisplayName = {this.UserDisplayName ?? "null"}");
        }
    }
}
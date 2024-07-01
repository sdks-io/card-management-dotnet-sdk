// <copyright file="Filters1.cs" company="APIMatic">
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
    /// Filters1.
    /// </summary>
    public class Filters1
    {
        private int? accountId;
        private string accountNumber;
        private int? colCoCode;
        private string colCoCountryCode;
        private int? colCoId;
        private int? payerId;
        private string payerNumber;
        private int? cardGroupId;
        private string cardGroupName;
        private int? expiringInDays;
        private string issuedAfter;
        private string pANEndsWith;
        private string excludeBundleId;
        private string cardSegment;
        private string purchaseCategoryCode;
        private string cardTypeCode;
        private int? excludeCardGroupId;
        private string excludeCardGroupName;
        private string creationDate;
        private string effectiveDate;
        private string network;
        private string coverage;
        private string expiryMonth;
        private string reissueSetting;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "ColCoCode", false },
            { "ColCoCountryCode", false },
            { "ColCoId", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "ExpiringInDays", false },
            { "IssuedAfter", false },
            { "PANEndsWith", false },
            { "ExcludeBundleId", false },
            { "CardSegment", false },
            { "PurchaseCategoryCode", false },
            { "CardTypeCode", false },
            { "ExcludeCardGroupId", false },
            { "ExcludeCardGroupName", false },
            { "CreationDate", false },
            { "EffectiveDate", false },
            { "Network", false },
            { "Coverage", false },
            { "ExpiryMonth", false },
            { "ReissueSetting", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters1"/> class.
        /// </summary>
        public Filters1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters1"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="cardStatus">CardStatus.</param>
        /// <param name="expiringInDays">ExpiringInDays.</param>
        /// <param name="issuedAfter">IssuedAfter.</param>
        /// <param name="pANEndsWith">PANEndsWith.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="vehicleRegistrationNumber">VehicleRegistrationNumber.</param>
        /// <param name="includeCards">IncludeCards.</param>
        /// <param name="excludeCards">ExcludeCards.</param>
        /// <param name="excludeBundleId">ExcludeBundleId.</param>
        /// <param name="cardSegment">CardSegment.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="excludePendingRenewalCards">ExcludePendingRenewalCards.</param>
        /// <param name="excludeCancelledCards">ExcludeCancelledCards.</param>
        /// <param name="excludeReplacedCards">ExcludeReplacedCards.</param>
        /// <param name="excludeFraudCards">ExcludeFraudCards.</param>
        /// <param name="excludeCardGroupId">ExcludeCardGroupId.</param>
        /// <param name="excludeCardGroupName">ExcludeCardGroupName.</param>
        /// <param name="creationDate">CreationDate.</param>
        /// <param name="effectiveDate">EffectiveDate.</param>
        /// <param name="network">Network.</param>
        /// <param name="coverage">Coverage.</param>
        /// <param name="expiryMonth">ExpiryMonth.</param>
        /// <param name="excludeOldCards">ExcludeOldCards.</param>
        /// <param name="reissueSetting">ReissueSetting.</param>
        /// <param name="requestId">RequestId.</param>
        public Filters1(
            int? accountId = null,
            string accountNumber = null,
            int? colCoCode = null,
            string colCoCountryCode = null,
            int? colCoId = null,
            int? payerId = null,
            string payerNumber = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            List<string> cardStatus = null,
            int? expiringInDays = null,
            string issuedAfter = null,
            string pANEndsWith = null,
            List<string> driverName = null,
            List<string> vehicleRegistrationNumber = null,
            List<Models.SearchCard> includeCards = null,
            List<Models.SearchCard> excludeCards = null,
            string excludeBundleId = null,
            string cardSegment = null,
            string purchaseCategoryCode = null,
            string cardTypeCode = null,
            bool? excludePendingRenewalCards = null,
            bool? excludeCancelledCards = null,
            bool? excludeReplacedCards = null,
            bool? excludeFraudCards = null,
            int? excludeCardGroupId = null,
            string excludeCardGroupName = null,
            string creationDate = null,
            string effectiveDate = null,
            string network = null,
            string coverage = null,
            string expiryMonth = null,
            bool? excludeOldCards = null,
            string reissueSetting = null,
            string requestId = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            this.CardStatus = cardStatus;
            if (expiringInDays != null)
            {
                this.ExpiringInDays = expiringInDays;
            }

            if (issuedAfter != null)
            {
                this.IssuedAfter = issuedAfter;
            }

            if (pANEndsWith != null)
            {
                this.PANEndsWith = pANEndsWith;
            }

            this.DriverName = driverName;
            this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            this.IncludeCards = includeCards;
            this.ExcludeCards = excludeCards;
            if (excludeBundleId != null)
            {
                this.ExcludeBundleId = excludeBundleId;
            }

            if (cardSegment != null)
            {
                this.CardSegment = cardSegment;
            }

            if (purchaseCategoryCode != null)
            {
                this.PurchaseCategoryCode = purchaseCategoryCode;
            }

            if (cardTypeCode != null)
            {
                this.CardTypeCode = cardTypeCode;
            }

            this.ExcludePendingRenewalCards = excludePendingRenewalCards;
            this.ExcludeCancelledCards = excludeCancelledCards;
            this.ExcludeReplacedCards = excludeReplacedCards;
            this.ExcludeFraudCards = excludeFraudCards;
            if (excludeCardGroupId != null)
            {
                this.ExcludeCardGroupId = excludeCardGroupId;
            }

            if (excludeCardGroupName != null)
            {
                this.ExcludeCardGroupName = excludeCardGroupName;
            }

            if (creationDate != null)
            {
                this.CreationDate = creationDate;
            }

            if (effectiveDate != null)
            {
                this.EffectiveDate = effectiveDate;
            }

            if (network != null)
            {
                this.Network = network;
            }

            if (coverage != null)
            {
                this.Coverage = coverage;
            }

            if (expiryMonth != null)
            {
                this.ExpiryMonth = expiryMonth;
            }

            this.ExcludeOldCards = excludeOldCards;
            if (reissueSetting != null)
            {
                this.ReissueSetting = reissueSetting;
            }

            this.RequestId = requestId;
        }

        /// <summary>
        /// Account ID of the customer.<br/> Optional.<br/> This input is a search criterion, if given.
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
        /// Account Number of the customer.<br/> Optional.<br/> This input is a search criterion, if given.
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
        /// Collecting Company Code (Shell Code) of the selected payer. <br />
        /// Optional If ColCo Id or ColCoCountryCode is passed else Mandatory.<br />
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
        /// The 2 character ISO Code for the customer and card owning country.<br />
        /// Optional If ColCoId or ColCoCode is passed else Mandatory.<br />
        /// </summary>
        [JsonProperty("ColCoCountryCode")]
        public string ColCoCountryCode
        {
            get
            {
                return this.colCoCountryCode;
            }

            set
            {
                this.shouldSerialize["ColCoCountryCode"] = true;
                this.colCoCountryCode = value;
            }
        }

        /// <summary>
        /// Collecting Company Id (in ) of the selected payer.<br />
        /// Optional If ColCo Codeor ColCoCountryCode is passed else Mandatory <br />
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
        /// Payer Id (i.e. Customer Id of the Payment Customer ) of the selected payer.<br />
        /// Optional if PayerNumber is passed else Mandatory
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
        /// Payer Number of the selected payer.<br />
        /// Optional if PayerId is passed else Mandatory
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
        /// Card group id.<br />
        /// Optional. <br />
        /// This input is a search criterion, if given.<br />
        /// When -1 is passed, those cards that does not belong to any card group will be returned.
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
        /// Card group name.<br />
        /// Optional.<br />
        /// This input is a search criterion, if given.<br />
        /// If CardGroupId is provided then this search criterion will be ignored, else, those cards that have the card group name completely matching with the entered value will be returned
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
        /// Status of the card.<br />
        /// Mandatory.<br />
        /// Multiple statuses are allowed to be included in the search criteria.<br />
        /// CardStatus filter accepts either of the two values for each status as described below. However, the output field “StatusDescription” is aligned with second value highlighted in italics.<br />
        /// Below are the possible allowed statuses: <br />
        /// • ACTIVE or Active – Cards at status Active (The result will include all the cards having the following intermediate statuses as defined s, if the IncludeIntermediateStatus flag is true: Active (Block in progress), Active (Cancel in progress), Active (Marked as damaged)), New (Cancel in progress).<br />
        /// • ON_ORDER or New – Cards at status New <br />
        /// • EXPIRED or Expired – Cards at status Expired<br />
        /// • BLOCKED or Blocked Card – Cards at status Block (The result will include all cards having the following intermediate status as defined, if the IncludeIntermediateStatus flag is true: Blocked card (Unblock in progress))<br />
        /// • TEMP_BLOCKED_CUSTOMER or Temporary Block(Customer) – Cards at status Temporary Blocked By Customer<br />
        /// • TEMP_BLOCKED_SHELL or Temporary Block (Shell) – Cards at Status Temporary Blocked by Shell<br />
        /// • CANCELLED or Cancelled – Cards at status Cancelled<br />
        /// • PENDING_RENEWAL or Pending Renewal - Cards that are in renewal process<br />
        /// • REPLACED or Replaced – Cards at Status Replaced<br />
        /// • FRAUD or Fraud – Cards at Status FRAUD<br />
        /// • ALL
        /// </summary>
        [JsonProperty("CardStatus", NullValueHandling = NullValueHandling.Include)]
        public List<string> CardStatus { get; set; }

        /// <summary>
        /// Cards active and expiring in given number of days.<br />
        /// Optional<br />
        /// Note: When a value is passed in this parameter, only active cards will be considered while searching.
        /// </summary>
        [JsonProperty("ExpiringInDays")]
        public int? ExpiringInDays
        {
            get
            {
                return this.expiringInDays;
            }

            set
            {
                this.shouldSerialize["ExpiringInDays"] = true;
                this.expiringInDays = value;
            }
        }

        /// <summary>
        /// If provided, only list cards issued after the given date<br />
        /// Optional<br />
        /// Format: yyyyMMdd<br />
        /// Note: Clients to convert this to appropriate DateTime type.
        /// </summary>
        [JsonProperty("IssuedAfter")]
        public string IssuedAfter
        {
            get
            {
                return this.issuedAfter;
            }

            set
            {
                this.shouldSerialize["IssuedAfter"] = true;
                this.issuedAfter = value;
            }
        }

        /// <summary>
        /// Last digits of the PAN number<br />
        /// Minimum 4 last digits of the card should be sent for this field to be considered as part of the search criteria.<br />
        /// Optional<br />
        /// Max Length: 50
        /// </summary>
        [JsonProperty("PANEndsWith")]
        public string PANEndsWith
        {
            get
            {
                return this.pANEndsWith;
            }

            set
            {
                this.shouldSerialize["PANEndsWith"] = true;
                this.pANEndsWith = value;
            }
        }

        /// <summary>
        /// Driver Name embossed on the card<br />
        /// Optional<br />
        /// Up to 10 driver names could be passed in the parameter.<br />
        /// Minimum of 4 characters should be provided for each driver name else not considered.<br />
        /// Those cards will be returned when part of the driver name matches with any of the string passed in the list.<br />
        /// Max Length for each Driver name: 50
        /// </summary>
        [JsonProperty("DriverName", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DriverName { get; set; }

        /// <summary>
        /// Vehicle Registration embossed on the card<br />
        /// Optional<br />
        /// Up to 10 vehicle registration numbers could be passed in the parameter.<br />
        /// Minimum of 4 characters should be provided for each VRN else not considered<br />
        /// Those cards will be returned when part of the VRN matches with any of the string passed in the list.<br />
        /// Max Length for each VRN: 50
        /// </summary>
        [JsonProperty("VehicleRegistrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VehicleRegistrationNumber { get; set; }

        /// <summary>
        /// List of SearchCard entity i.e., Card Id or PAN, which needs to be included in the response.<br />
        /// Details of the SerachCard entity are given below.
        /// </summary>
        [JsonProperty("IncludeCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchCard> IncludeCards { get; set; }

        /// <summary>
        /// List of SearchCard entity i.e., Card Id or PAN, which needs to be excluded in the response. <br />
        /// Details of the SerachCard entity are given below.
        /// </summary>
        [JsonProperty("ExcludeCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchCard> ExcludeCards { get; set; }

        /// <summary>
        /// Bundle Id for the Card, which needs to be excluded in the response.<br />
        /// Optional
        /// </summary>
        [JsonProperty("ExcludeBundleId")]
        public string ExcludeBundleId
        {
            get
            {
                return this.excludeBundleId;
            }

            set
            {
                this.shouldSerialize["ExcludeBundleId"] = true;
                this.excludeBundleId = value;
            }
        }

        /// <summary>
        /// Market segment to which card belongs to.<br />
        /// Optional.<br />
        /// Allowed values<br />
        /// • CRT<br />
        /// • Fleet
        /// </summary>
        [JsonProperty("CardSegment")]
        public string CardSegment
        {
            get
            {
                return this.cardSegment;
            }

            set
            {
                this.shouldSerialize["CardSegment"] = true;
                this.cardSegment = value;
            }
        }

        /// <summary>
        /// Purchase category code of the card.<br />
        /// Optional.
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
        /// ISO code of the card i.e. first 7 digits of the PAN<br />
        /// Optional.
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
        /// Default value is True.<br />
        /// When true, the API will not return cards that are at Pending Renewal Status in Cards Platform
        /// </summary>
        [JsonProperty("ExcludePendingRenewalCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludePendingRenewalCards { get; set; }

        /// <summary>
        /// Default value is True.<br />
        /// When true, the API will not return cards that are at Cancelled Status in Cards Platform
        /// </summary>
        [JsonProperty("ExcludeCancelledCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeCancelledCards { get; set; }

        /// <summary>
        /// Default value is False.<br />
        /// When true, the API will not return cards that are at Replaced Status in Cards Platform
        /// </summary>
        [JsonProperty("ExcludeReplacedCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeReplacedCards { get; set; }

        /// <summary>
        /// Default value is False.<br />
        /// When true, the API will not return cards that are at Fraud Status in Cards Platform
        /// </summary>
        [JsonProperty("ExcludeFraudCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFraudCards { get; set; }

        /// <summary>
        /// Optional<br />
        /// When passed, the API will not return cards that are currently in the Card Group specified
        /// </summary>
        [JsonProperty("ExcludeCardGroupId")]
        public int? ExcludeCardGroupId
        {
            get
            {
                return this.excludeCardGroupId;
            }

            set
            {
                this.shouldSerialize["ExcludeCardGroupId"] = true;
                this.excludeCardGroupId = value;
            }
        }

        /// <summary>
        /// Optional<br />
        /// When passed, the API will not return cards that are currently in the Card Group specified
        /// </summary>
        [JsonProperty("ExcludeCardGroupName")]
        public string ExcludeCardGroupName
        {
            get
            {
                return this.excludeCardGroupName;
            }

            set
            {
                this.shouldSerialize["ExcludeCardGroupName"] = true;
                this.excludeCardGroupName = value;
            }
        }

        /// <summary>
        /// Card Creation Date<br />
        /// Optional<br />
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate
        {
            get
            {
                return this.creationDate;
            }

            set
            {
                this.shouldSerialize["CreationDate"] = true;
                this.creationDate = value;
            }
        }

        /// <summary>
        /// Effective date for the Card<br />
        /// Optional<br />
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("EffectiveDate")]
        public string EffectiveDate
        {
            get
            {
                return this.effectiveDate;
            }

            set
            {
                this.shouldSerialize["EffectiveDate"] = true;
                this.effectiveDate = value;
            }
        }

        /// <summary>
        /// Cards allowed to be used in site.<br />
        /// Optional.<br />
        /// Allowed values<br />
        /// • ShellSitesOnly<br />
        /// • PartnersSitesIncluded<br />
        /// </summary>
        [JsonProperty("Network")]
        public string Network
        {
            get
            {
                return this.network;
            }

            set
            {
                this.shouldSerialize["Network"] = true;
                this.network = value;
            }
        }

        /// <summary>
        /// Cards allowed to used nationally/internationally.<br />
        /// Optional.<br />
        /// Allowed values<br />
        ///  -National<br />
        ///  -International
        /// </summary>
        [JsonProperty("Coverage")]
        public string Coverage
        {
            get
            {
                return this.coverage;
            }

            set
            {
                this.shouldSerialize["Coverage"] = true;
                this.coverage = value;
            }
        }

        /// <summary>
        /// Month in which the card is expiring.<br />
        /// Optional.<br />
        /// Format: MMYYYY
        /// </summary>
        [JsonProperty("ExpiryMonth")]
        public string ExpiryMonth
        {
            get
            {
                return this.expiryMonth;
            }

            set
            {
                this.shouldSerialize["ExpiryMonth"] = true;
                this.expiryMonth = value;
            }
        }

        /// <summary>
        /// Default Value: False<br />
        /// When this field is set to True, cards with below status 2 years (configurable) ago and earlier are excluded from the result<br />
        ///  -Blocked Card<br />
        ///  -Expired<br />
        ///  -Cancelled<br />
        ///  -Suspended<br />
        ///  -Blocked<br />
        ///  -Expired and Cancelled<br />
        ///  -Replaced<br />
        ///  -Replaced By<br />
        ///  -Closed<br />
        ///  -Fraud<br />
        /// </summary>
        [JsonProperty("ExcludeOldCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeOldCards { get; set; }

        /// <summary>
        /// Default Value: All<br />
        /// Optional<br />
        /// This option is used to filter the list of cards with ‘ReissueSetting’.<br />
        /// If ‘True’, the API will return cards with ReIssueSetting value is true.<br />
        /// If ‘False’, the API will return cards with ReIsssueSetting value is false.<br />
        /// If ‘ALL’, API will return cards with ReIssueSetting value True &amp; False both.<br />
        /// Allowed Values:<br />
        /// 1.	All<br />
        /// 2.	True<br />
        /// 3.	False
        /// </summary>
        [JsonProperty("ReissueSetting")]
        public string ReissueSetting
        {
            get
            {
                return this.reissueSetting;
            }

            set
            {
                this.shouldSerialize["ReissueSetting"] = true;
                this.reissueSetting = value;
            }
        }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Include)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filters1 : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
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
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetExpiringInDays()
        {
            this.shouldSerialize["ExpiringInDays"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuedAfter()
        {
            this.shouldSerialize["IssuedAfter"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPANEndsWith()
        {
            this.shouldSerialize["PANEndsWith"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExcludeBundleId()
        {
            this.shouldSerialize["ExcludeBundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardSegment()
        {
            this.shouldSerialize["CardSegment"] = false;
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
        public void UnsetCardTypeCode()
        {
            this.shouldSerialize["CardTypeCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExcludeCardGroupId()
        {
            this.shouldSerialize["ExcludeCardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExcludeCardGroupName()
        {
            this.shouldSerialize["ExcludeCardGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreationDate()
        {
            this.shouldSerialize["CreationDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEffectiveDate()
        {
            this.shouldSerialize["EffectiveDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetwork()
        {
            this.shouldSerialize["Network"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCoverage()
        {
            this.shouldSerialize["Coverage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiryMonth()
        {
            this.shouldSerialize["ExpiryMonth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReissueSetting()
        {
            this.shouldSerialize["ReissueSetting"] = false;
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
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
        public bool ShouldSerializeExpiringInDays()
        {
            return this.shouldSerialize["ExpiringInDays"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuedAfter()
        {
            return this.shouldSerialize["IssuedAfter"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePANEndsWith()
        {
            return this.shouldSerialize["PANEndsWith"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExcludeBundleId()
        {
            return this.shouldSerialize["ExcludeBundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardSegment()
        {
            return this.shouldSerialize["CardSegment"];
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
        public bool ShouldSerializeCardTypeCode()
        {
            return this.shouldSerialize["CardTypeCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExcludeCardGroupId()
        {
            return this.shouldSerialize["ExcludeCardGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExcludeCardGroupName()
        {
            return this.shouldSerialize["ExcludeCardGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreationDate()
        {
            return this.shouldSerialize["CreationDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEffectiveDate()
        {
            return this.shouldSerialize["EffectiveDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetwork()
        {
            return this.shouldSerialize["Network"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCoverage()
        {
            return this.shouldSerialize["Coverage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryMonth()
        {
            return this.shouldSerialize["ExpiryMonth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReissueSetting()
        {
            return this.shouldSerialize["ReissueSetting"];
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
            return obj is Filters1 other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.CardStatus == null && other.CardStatus == null) || (this.CardStatus?.Equals(other.CardStatus) == true)) &&
                ((this.ExpiringInDays == null && other.ExpiringInDays == null) || (this.ExpiringInDays?.Equals(other.ExpiringInDays) == true)) &&
                ((this.IssuedAfter == null && other.IssuedAfter == null) || (this.IssuedAfter?.Equals(other.IssuedAfter) == true)) &&
                ((this.PANEndsWith == null && other.PANEndsWith == null) || (this.PANEndsWith?.Equals(other.PANEndsWith) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.VehicleRegistrationNumber == null && other.VehicleRegistrationNumber == null) || (this.VehicleRegistrationNumber?.Equals(other.VehicleRegistrationNumber) == true)) &&
                ((this.IncludeCards == null && other.IncludeCards == null) || (this.IncludeCards?.Equals(other.IncludeCards) == true)) &&
                ((this.ExcludeCards == null && other.ExcludeCards == null) || (this.ExcludeCards?.Equals(other.ExcludeCards) == true)) &&
                ((this.ExcludeBundleId == null && other.ExcludeBundleId == null) || (this.ExcludeBundleId?.Equals(other.ExcludeBundleId) == true)) &&
                ((this.CardSegment == null && other.CardSegment == null) || (this.CardSegment?.Equals(other.CardSegment) == true)) &&
                ((this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null) || (this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true)) &&
                ((this.CardTypeCode == null && other.CardTypeCode == null) || (this.CardTypeCode?.Equals(other.CardTypeCode) == true)) &&
                ((this.ExcludePendingRenewalCards == null && other.ExcludePendingRenewalCards == null) || (this.ExcludePendingRenewalCards?.Equals(other.ExcludePendingRenewalCards) == true)) &&
                ((this.ExcludeCancelledCards == null && other.ExcludeCancelledCards == null) || (this.ExcludeCancelledCards?.Equals(other.ExcludeCancelledCards) == true)) &&
                ((this.ExcludeReplacedCards == null && other.ExcludeReplacedCards == null) || (this.ExcludeReplacedCards?.Equals(other.ExcludeReplacedCards) == true)) &&
                ((this.ExcludeFraudCards == null && other.ExcludeFraudCards == null) || (this.ExcludeFraudCards?.Equals(other.ExcludeFraudCards) == true)) &&
                ((this.ExcludeCardGroupId == null && other.ExcludeCardGroupId == null) || (this.ExcludeCardGroupId?.Equals(other.ExcludeCardGroupId) == true)) &&
                ((this.ExcludeCardGroupName == null && other.ExcludeCardGroupName == null) || (this.ExcludeCardGroupName?.Equals(other.ExcludeCardGroupName) == true)) &&
                ((this.CreationDate == null && other.CreationDate == null) || (this.CreationDate?.Equals(other.CreationDate) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Coverage == null && other.Coverage == null) || (this.Coverage?.Equals(other.Coverage) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExcludeOldCards == null && other.ExcludeOldCards == null) || (this.ExcludeOldCards?.Equals(other.ExcludeOldCards) == true)) &&
                ((this.ReissueSetting == null && other.ReissueSetting == null) || (this.ReissueSetting?.Equals(other.ReissueSetting) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.CardStatus = {(this.CardStatus == null ? "null" : $"[{string.Join(", ", this.CardStatus)} ]")}");
            toStringOutput.Add($"this.ExpiringInDays = {(this.ExpiringInDays == null ? "null" : this.ExpiringInDays.ToString())}");
            toStringOutput.Add($"this.IssuedAfter = {(this.IssuedAfter == null ? "null" : this.IssuedAfter)}");
            toStringOutput.Add($"this.PANEndsWith = {(this.PANEndsWith == null ? "null" : this.PANEndsWith)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : $"[{string.Join(", ", this.DriverName)} ]")}");
            toStringOutput.Add($"this.VehicleRegistrationNumber = {(this.VehicleRegistrationNumber == null ? "null" : $"[{string.Join(", ", this.VehicleRegistrationNumber)} ]")}");
            toStringOutput.Add($"this.IncludeCards = {(this.IncludeCards == null ? "null" : $"[{string.Join(", ", this.IncludeCards)} ]")}");
            toStringOutput.Add($"this.ExcludeCards = {(this.ExcludeCards == null ? "null" : $"[{string.Join(", ", this.ExcludeCards)} ]")}");
            toStringOutput.Add($"this.ExcludeBundleId = {(this.ExcludeBundleId == null ? "null" : this.ExcludeBundleId)}");
            toStringOutput.Add($"this.CardSegment = {(this.CardSegment == null ? "null" : this.CardSegment)}");
            toStringOutput.Add($"this.PurchaseCategoryCode = {(this.PurchaseCategoryCode == null ? "null" : this.PurchaseCategoryCode)}");
            toStringOutput.Add($"this.CardTypeCode = {(this.CardTypeCode == null ? "null" : this.CardTypeCode)}");
            toStringOutput.Add($"this.ExcludePendingRenewalCards = {(this.ExcludePendingRenewalCards == null ? "null" : this.ExcludePendingRenewalCards.ToString())}");
            toStringOutput.Add($"this.ExcludeCancelledCards = {(this.ExcludeCancelledCards == null ? "null" : this.ExcludeCancelledCards.ToString())}");
            toStringOutput.Add($"this.ExcludeReplacedCards = {(this.ExcludeReplacedCards == null ? "null" : this.ExcludeReplacedCards.ToString())}");
            toStringOutput.Add($"this.ExcludeFraudCards = {(this.ExcludeFraudCards == null ? "null" : this.ExcludeFraudCards.ToString())}");
            toStringOutput.Add($"this.ExcludeCardGroupId = {(this.ExcludeCardGroupId == null ? "null" : this.ExcludeCardGroupId.ToString())}");
            toStringOutput.Add($"this.ExcludeCardGroupName = {(this.ExcludeCardGroupName == null ? "null" : this.ExcludeCardGroupName)}");
            toStringOutput.Add($"this.CreationDate = {(this.CreationDate == null ? "null" : this.CreationDate)}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate)}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network)}");
            toStringOutput.Add($"this.Coverage = {(this.Coverage == null ? "null" : this.Coverage)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth)}");
            toStringOutput.Add($"this.ExcludeOldCards = {(this.ExcludeOldCards == null ? "null" : this.ExcludeOldCards.ToString())}");
            toStringOutput.Add($"this.ReissueSetting = {(this.ReissueSetting == null ? "null" : this.ReissueSetting)}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}
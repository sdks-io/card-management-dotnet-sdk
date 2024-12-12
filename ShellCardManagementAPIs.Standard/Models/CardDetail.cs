// <copyright file="CardDetail.cs" company="APIMatic">
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
    /// CardDetail.
    /// </summary>
    public class CardDetail
    {
        private int? payerId;
        private string payerNumber;
        private int? accountId;
        private string accountNumber;
        private int? colCoCode;
        private int? colCoId;
        private int? cardTypeId;
        private int? tokenTypeId;
        private string embossText;
        private string vRN;
        private string driverName;
        private int? purchaseCategoryId;
        private string selfSelectedPINKeyID;
        private string selfSelectedPINSessionKey;
        private int? cardGroupId;
        private string cardGroupName;
        private int? pINDeliveryAddressType;
        private string caller;
        private string fleetOption;
        private string bundleId;
        private string usageRestrictionAction;
        private string productRestrictionAction;
        private string expiryDate;
        private string clientReferenceId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PayerId", false },
            { "PayerNumber", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "CardTypeId", false },
            { "TokenTypeId", false },
            { "EmbossText", false },
            { "VRN", false },
            { "DriverName", false },
            { "PurchaseCategoryId", false },
            { "SelfSelectedPINKeyID", false },
            { "SelfSelectedPINSessionKey", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "PINDeliveryAddressType", false },
            { "Caller", false },
            { "FleetOption", false },
            { "BundleId", false },
            { "UsageRestrictionAction", false },
            { "ProductRestrictionAction", false },
            { "ExpiryDate", false },
            { "ClientReferenceId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetail"/> class.
        /// </summary>
        public CardDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetail"/> class.
        /// </summary>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="tokenTypeId">TokenTypeId.</param>
        /// <param name="embossText">EmbossText.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="odometerInputRequired">OdometerInputRequired.</param>
        /// <param name="fleetIdInputRequired">FleetIdInputRequired.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="selfSelectedEncryptedPIN">SelfSelectedEncryptedPIN.</param>
        /// <param name="selfSelectedPINKeyID">SelfSelectedPINKeyID.</param>
        /// <param name="selfSelectedPINSessionKey">SelfSelectedPINSessionKey.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="isNewCardGroup">IsNewCardGroup.</param>
        /// <param name="embossCardGroup">EmbossCardGroup.</param>
        /// <param name="cardDeliveryType">CardDeliveryType.</param>
        /// <param name="cardContact">CardContact.</param>
        /// <param name="pINDeliveryAddressType">PINDeliveryAddressType.</param>
        /// <param name="pINAdviceType">PINAdviceType.</param>
        /// <param name="pINContact">PINContact.</param>
        /// <param name="notifyCaller">NotifyCaller.</param>
        /// <param name="caller">Caller.</param>
        /// <param name="notifyCallerOnSync">NotifyCallerOnSync.</param>
        /// <param name="validateFleetId">ValidateFleetId.</param>
        /// <param name="fleetOption">FleetOption.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="usageRestrictionAction">UsageRestrictionAction.</param>
        /// <param name="productRestrictionAction">ProductRestrictionAction.</param>
        /// <param name="products">Products.</param>
        /// <param name="productGroups">ProductGroups.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="clientReferenceId">ClientReferenceId.</param>
        /// <param name="autoRenew">AutoRenew.</param>
        public CardDetail(
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            int? colCoCode = null,
            int? colCoId = null,
            int? cardTypeId = null,
            int? tokenTypeId = null,
            string embossText = null,
            string vRN = null,
            string driverName = null,
            bool? odometerInputRequired = null,
            bool? fleetIdInputRequired = null,
            int? purchaseCategoryId = null,
            string selfSelectedEncryptedPIN = null,
            string selfSelectedPINKeyID = null,
            string selfSelectedPINSessionKey = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            bool? isNewCardGroup = null,
            bool? embossCardGroup = null,
            int? cardDeliveryType = null,
            Models.CardContact cardContact = null,
            int? pINDeliveryAddressType = null,
            int? pINAdviceType = null,
            Models.PINContact pINContact = null,
            bool? notifyCaller = null,
            string caller = null,
            bool? notifyCallerOnSync = null,
            bool? validateFleetId = null,
            string fleetOption = null,
            string bundleId = null,
            string usageRestrictionAction = null,
            string productRestrictionAction = null,
            List<string> products = null,
            List<string> productGroups = null,
            string expiryDate = null,
            string clientReferenceId = null,
            Models.CardDetailAutoRenewEnum? autoRenew = null)
        {

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

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

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (cardTypeId != null)
            {
                this.CardTypeId = cardTypeId;
            }

            if (tokenTypeId != null)
            {
                this.TokenTypeId = tokenTypeId;
            }

            if (embossText != null)
            {
                this.EmbossText = embossText;
            }

            if (vRN != null)
            {
                this.VRN = vRN;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }
            this.OdometerInputRequired = odometerInputRequired;
            this.FleetIdInputRequired = fleetIdInputRequired;

            if (purchaseCategoryId != null)
            {
                this.PurchaseCategoryId = purchaseCategoryId;
            }
            this.SelfSelectedEncryptedPIN = selfSelectedEncryptedPIN;

            if (selfSelectedPINKeyID != null)
            {
                this.SelfSelectedPINKeyID = selfSelectedPINKeyID;
            }

            if (selfSelectedPINSessionKey != null)
            {
                this.SelfSelectedPINSessionKey = selfSelectedPINSessionKey;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }
            this.IsNewCardGroup = isNewCardGroup;
            this.EmbossCardGroup = embossCardGroup;
            this.CardDeliveryType = cardDeliveryType;
            this.CardContact = cardContact;

            if (pINDeliveryAddressType != null)
            {
                this.PINDeliveryAddressType = pINDeliveryAddressType;
            }
            this.PINAdviceType = pINAdviceType;
            this.PINContact = pINContact;
            this.NotifyCaller = notifyCaller;

            if (caller != null)
            {
                this.Caller = caller;
            }
            this.NotifyCallerOnSync = notifyCallerOnSync;
            this.ValidateFleetId = validateFleetId;

            if (fleetOption != null)
            {
                this.FleetOption = fleetOption;
            }

            if (bundleId != null)
            {
                this.BundleId = bundleId;
            }

            if (usageRestrictionAction != null)
            {
                this.UsageRestrictionAction = usageRestrictionAction;
            }

            if (productRestrictionAction != null)
            {
                this.ProductRestrictionAction = productRestrictionAction;
            }
            this.Products = products;
            this.ProductGroups = productGroups;

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }

            if (clientReferenceId != null)
            {
                this.ClientReferenceId = clientReferenceId;
            }
            this.AutoRenew = autoRenew;
        }

        /// <summary>
        /// Payer Id  of the selected payer.<br />
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
        /// Account ID of the customer.<br />
        /// Optional if AccountNumber is passed, else mandatory.<br />
        /// This input is a search criterion, if given.
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
        /// Account Number of the customer.<br />
        /// Optional if AccountId is passed, else mandatory.<br />
        /// This input is a search criterion, if given.
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
        /// Collecting Company Code (Shell Code) of the selected payer.<br />
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
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
        /// Collecting Company Id of the selected payer.<br />
        /// Optional If ColCo Code is passed else Mandatory
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
        /// Card Type ID<br />
        /// Mandatory
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
        /// Token Type Id – Linked to the selected card type<br />
        /// Optional<br />
        /// Default – Assign the default token type associated with the card type of the card being created.<br />
        /// The default value will be set by the background process and an error (code 12009) will be thrown by the background process when default value is not identified or invalid token type id is passed in the request.
        /// </summary>
        [JsonProperty("TokenTypeId")]
        public int? TokenTypeId
        {
            get
            {
                return this.tokenTypeId;
            }

            set
            {
                this.shouldSerialize["TokenTypeId"] = true;
                this.tokenTypeId = value;
            }
        }

        /// <summary>
        /// Text to be printed on the card as Account Name.<br />
        /// Optional – When not provided default emboss text associated with the card type will be embossed.<br />
        /// Max length: 27<br />
        /// The value should be validated against a configured list of allowed characters.<br />
        /// [-0-9A-Z,/''.&amp; ÄÖÜÅÆÉØ]
        /// </summary>
        [JsonProperty("EmbossText")]
        public string EmbossText
        {
            get
            {
                return this.embossText;
            }

            set
            {
                this.shouldSerialize["EmbossText"] = true;
                this.embossText = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Vehicle registration number.<br/>
        /// Optional when DriverName is passed else mandatory.<br/>
        /// Mandatory when ColCo setting is marked as ‘VRN mandatory’.<br />
        /// Max length: 24<br />
        /// The value will be validated against a configured list of allowed characters.<br />
        /// Default value for the configuration is: [-0-9A-Z,/''.&amp; ÄÖÜÅÆÉØ] .
        /// </br>Note: If Driver Name is null or empty, max allowed characters for VRN is 16.  When Driver Name is provided, max allowed characters for VRN is 24.
        /// ]]>
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
        /// Driver Name.<br />
        /// Optional when VRN is passed else mandatory.<br />
        /// Max length: 27<br />
        /// The value will be validated against a configured list of allowed characters.<br />
        /// Default value for the configuration is: [-0-9A-Z,/''.&amp; ÄÖÜÅÆÉØ]<br />
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
        /// Odometer Input to be enabled on the card<br />
        /// Optional.<br />
        /// Default is False
        /// </summary>
        [JsonProperty("OdometerInputRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OdometerInputRequired { get; set; }

        /// <summary>
        /// FleetId Input to be enabled on the card<br />
        /// Optional.<br />
        /// Default is False<br />
        /// Note: If AllowFleetIdInput settings of the account is disabled and this flag is marked
        ///       true in the request, then request will be processed with VRN input required
        ///       enabled instead of Fleet Id input required
        /// </summary>
        [JsonProperty("FleetIdInputRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FleetIdInputRequired { get; set; }

        /// <summary>
        /// Purchase category Id<br />
        /// Mandatory
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
        /// The encrypted value of self-selected PIN.<br />
        /// Optional – When not provided, the PIN will be auto generated(if the card token type supports PIN) and delivered based on the given PIN delivery option.<br />
        /// Max Length: 256
        /// </summary>
        [JsonProperty("SelfSelectedEncryptedPIN", NullValueHandling = NullValueHandling.Ignore)]
        public string SelfSelectedEncryptedPIN { get; set; }

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
        /// Card group ID<br />
        /// Optional
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
        /// Card group name<br />
        /// This field is mandatory when IsNewCardGroup parameter is set to true.<br />
        /// Maximum field length: 40<br />
        /// The value will be validated against a configured list of allowed characters.<br />
        /// Default value for the configuration is: [0-9A-Z.]
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
        /// This need to be set to true if the card group needs to be created prior to processing the card order and the card needs to be assigned to the newly created card group.<br />
        /// Optional<br />
        /// Default - False
        /// </summary>
        [JsonProperty("IsNewCardGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewCardGroup { get; set; }

        /// <summary>
        /// This should be set to true if the card group name needs to be printed on the newly created card under a new card group.<br />
        /// Optional<br />
        /// Default – False<br />
        /// Note: This value will be considered only if a new CardGroup is created for the Card.(i.e.when IsNewCardGroup is true)
        ///       If the Card is added to an existing CardGroup,
        ///       the property ‘PrintOnCard’ set for the CardGroup will determine whether the CardGroupName should be embossed on the Card.
        /// </summary>
        [JsonProperty("EmbossCardGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmbossCardGroup { get; set; }

        /// <summary>
        /// Card delivery type.<br />
        /// Mandatory <br />
        /// Allowed Value: <br />
        /// 1.    Customer Address(Default) <br />
        /// 2.    New Delivery Address
        /// </summary>
        [JsonProperty("CardDeliveryType", NullValueHandling = NullValueHandling.Include)]
        public int? CardDeliveryType { get; set; }

        /// <summary>
        /// Gets or sets CardContact.
        /// </summary>
        [JsonProperty("CardContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardContact CardContact { get; set; }

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
        /// Mandatory<br />
        /// Allowed Values:<br />
        /// 1.    Paper<br />
        /// 2.    Email<br />
        /// 3.    SMS<br />
        /// 4.    None <br /> **Note:** Paper delivery not applicable for selfselctedPIN type
        /// </summary>
        [JsonProperty("PINAdviceType", NullValueHandling = NullValueHandling.Include)]
        public int? PINAdviceType { get; set; }

        /// <summary>
        /// Gets or sets PINContact.
        /// </summary>
        [JsonProperty("PINContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PINContact PINContact { get; set; }

        /// <summary>
        /// True/False.<br />
        /// Optional.<br />
        /// Default: False<br />
        /// If true, the caller would be notified back with the status as success or failure after the card order is processed.
        /// This webhook feature has to be subscribed by the customer prior to use , please refer the API documentation for the more details.
        /// </summary>
        [JsonProperty("NotifyCaller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCaller { get; set; }

        /// <summary>
        /// The caller to be notified with the status of the card order.<br />
        /// Mandatory, if NotifyCaller is true.<br />
        /// Maximum field length: 20<br />
        /// Allowed values:<br />
        /// •    “NextGenUI”: This value to be used by next gen UI application.<br />
        /// •    “FleetHubUILifeTime”: This value to be used by Fleet Hub UI application for life time restriction cards.<br />
        /// Note: The values passed in this field are case insensitive
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller
        {
            get
            {
                return this.caller;
            }

            set
            {
                this.shouldSerialize["Caller"] = true;
                this.caller = value;
            }
        }

        /// <summary>
        /// True/False.<br />
        /// Optional.<br />
        /// Default: False<br />
        /// If true, the caller would be notified back with the status as success or failed after the processed card is synced with Gateway.
        /// </summary>
        [JsonProperty("NotifyCallerOnSync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCallerOnSync { get; set; }

        /// <summary>
        /// True/False.<br />
        /// Optional.<br />
        /// Default: False<br />
        /// For cards ordered with Validate Fleet Id parameter set to true, CFGW will be notified to enable this validation for the card.<br />
        /// Note: When “FleetIdInputRequired” is not set on the card, validate fleet id will be considered false regardless of the value passed on this parameter.
        /// </summary>
        [JsonProperty("ValidateFleetId", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateFleetId { get; set; }

        /// <summary>
        /// Type of action will be performed for the card when the fleet Id is validated.<br />
        /// Optional.<br />
        /// Default: NO_VALIDATION<br />
        /// Allowed values:<br />
        /// •    ALERT<br />
        /// •    DECLINE<br />
        /// •    DECLINE_ALERT<br />
        /// •    NO_VALIDATION<br />
        /// Note: When FleetIdOption is not provided and validatefleetid is true then by default allowed value is NO_VALIDATION.
        /// </summary>
        [JsonProperty("FleetOption")]
        public string FleetOption
        {
            get
            {
                return this.fleetOption;
            }

            set
            {
                this.shouldSerialize["FleetOption"] = true;
                this.fleetOption = value;
            }
        }

        /// <summary>
        /// Gateway Bundle Id to which the ordered card will be added.<br />
        /// Optional.<br />
        /// When a valid bundle Id is passed, upon successful processing of Card Order, the card will be added to the provided bundle in Gateway.
        /// If card bundle has crossed the limit of 500 cards or if the card bundle is not available in the gateway then the background services will fail to added the card to the bundle.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId
        {
            get
            {
                return this.bundleId;
            }

            set
            {
                this.shouldSerialize["BundleId"] = true;
                this.bundleId = value;
            }
        }

        /// <summary>
        /// The value indicates what actions is to be performed with respect to usage restrictions on the card being ordered.<br />
        /// UsageRestrictionAction is mandatory when bundle Id is passed. Else ignored.<br />
        /// Allowed values: –<br />
        /// • Update<br />
        /// • Default<br />
        /// • None
        /// </summary>
        [JsonProperty("UsageRestrictionAction")]
        public string UsageRestrictionAction
        {
            get
            {
                return this.usageRestrictionAction;
            }

            set
            {
                this.shouldSerialize["UsageRestrictionAction"] = true;
                this.usageRestrictionAction = value;
            }
        }

        /// <summary>
        /// The value indicates what actions is to be performed with respect to product restrictions on the card being ordered.<br />
        /// ProductRestrictionAction is mandatory when bundle Id is passed. Else ignored.<br />
        /// Allowed values: -<br />
        /// • Update<br />
        /// • Default<br />
        /// • None<br />
        /// Note: This field is applicable when product restrictions
        /// </summary>
        [JsonProperty("ProductRestrictionAction")]
        public string ProductRestrictionAction
        {
            get
            {
                return this.productRestrictionAction;
            }

            set
            {
                this.shouldSerialize["ProductRestrictionAction"] = true;
                this.productRestrictionAction = value;
            }
        }

        /// <summary>
        /// An array of 3-digit global product codes.<br />
        /// Optional.<br />
        /// Default restrictions will be applied both products and product groups are null or empty.<br />
        /// Note: This field is applicable when product restrictions are migrated to CFGW else, it will be ignored.
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Products { get; set; }

        /// <summary>
        /// An array of product group ids.<br />
        /// Optional.<br />
        /// Default restrictions will be applied both products and product groups are null or empty.<br />
        /// Note: This field is applicable when product restrictions are migrated to CFGW else, it will be ignored
        /// </summary>
        [JsonProperty("ProductGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductGroups { get; set; }

        /// <summary>
        /// Expiry Date for newly created card to be update in cards plot form.<br />
        /// Optional.<br />
        /// Format: MMyy<br />
        /// If not apply default Expiry Date.<br />
        /// Note: There is a limit to the ExpiryDate which the user can choose for the Card.
        ///       The expiry date which can be set for a card depends on the Card Type and the associated business rules for the OU.
        ///       If the user chooses a later ExpiryDate than the allowed value for the CardType for the OU,
        ///  Default Assigned Expiry Date will be applied on the card.
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
        /// This is the Client Reference Id of card in the order which needs to be passed by the client.This will be playback in the ordercard enquiry<br />
        /// Optional
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
        /// Gets or sets AutoRenew.
        /// </summary>
        [JsonProperty("AutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardDetailAutoRenewEnum? AutoRenew { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardDetail : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCardTypeId()
        {
            this.shouldSerialize["CardTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTokenTypeId()
        {
            this.shouldSerialize["TokenTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmbossText()
        {
            this.shouldSerialize["EmbossText"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPurchaseCategoryId()
        {
            this.shouldSerialize["PurchaseCategoryId"] = false;
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
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
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
        public void UnsetCaller()
        {
            this.shouldSerialize["Caller"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFleetOption()
        {
            this.shouldSerialize["FleetOption"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBundleId()
        {
            this.shouldSerialize["BundleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUsageRestrictionAction()
        {
            this.shouldSerialize["UsageRestrictionAction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProductRestrictionAction()
        {
            this.shouldSerialize["ProductRestrictionAction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiryDate()
        {
            this.shouldSerialize["ExpiryDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetClientReferenceId()
        {
            this.shouldSerialize["ClientReferenceId"] = false;
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
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
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
        public bool ShouldSerializeTokenTypeId()
        {
            return this.shouldSerialize["TokenTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmbossText()
        {
            return this.shouldSerialize["EmbossText"];
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
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
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
        public bool ShouldSerializeCardGroupName()
        {
            return this.shouldSerialize["CardGroupName"];
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
        public bool ShouldSerializeCaller()
        {
            return this.shouldSerialize["Caller"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFleetOption()
        {
            return this.shouldSerialize["FleetOption"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundleId()
        {
            return this.shouldSerialize["BundleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageRestrictionAction()
        {
            return this.shouldSerialize["UsageRestrictionAction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductRestrictionAction()
        {
            return this.shouldSerialize["ProductRestrictionAction"];
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardDetail other &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.TokenTypeId == null && other.TokenTypeId == null ||
                 this.TokenTypeId?.Equals(other.TokenTypeId) == true) &&
                (this.EmbossText == null && other.EmbossText == null ||
                 this.EmbossText?.Equals(other.EmbossText) == true) &&
                (this.VRN == null && other.VRN == null ||
                 this.VRN?.Equals(other.VRN) == true) &&
                (this.DriverName == null && other.DriverName == null ||
                 this.DriverName?.Equals(other.DriverName) == true) &&
                (this.OdometerInputRequired == null && other.OdometerInputRequired == null ||
                 this.OdometerInputRequired?.Equals(other.OdometerInputRequired) == true) &&
                (this.FleetIdInputRequired == null && other.FleetIdInputRequired == null ||
                 this.FleetIdInputRequired?.Equals(other.FleetIdInputRequired) == true) &&
                (this.PurchaseCategoryId == null && other.PurchaseCategoryId == null ||
                 this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true) &&
                (this.SelfSelectedEncryptedPIN == null && other.SelfSelectedEncryptedPIN == null ||
                 this.SelfSelectedEncryptedPIN?.Equals(other.SelfSelectedEncryptedPIN) == true) &&
                (this.SelfSelectedPINKeyID == null && other.SelfSelectedPINKeyID == null ||
                 this.SelfSelectedPINKeyID?.Equals(other.SelfSelectedPINKeyID) == true) &&
                (this.SelfSelectedPINSessionKey == null && other.SelfSelectedPINSessionKey == null ||
                 this.SelfSelectedPINSessionKey?.Equals(other.SelfSelectedPINSessionKey) == true) &&
                (this.CardGroupId == null && other.CardGroupId == null ||
                 this.CardGroupId?.Equals(other.CardGroupId) == true) &&
                (this.CardGroupName == null && other.CardGroupName == null ||
                 this.CardGroupName?.Equals(other.CardGroupName) == true) &&
                (this.IsNewCardGroup == null && other.IsNewCardGroup == null ||
                 this.IsNewCardGroup?.Equals(other.IsNewCardGroup) == true) &&
                (this.EmbossCardGroup == null && other.EmbossCardGroup == null ||
                 this.EmbossCardGroup?.Equals(other.EmbossCardGroup) == true) &&
                (this.CardDeliveryType == null && other.CardDeliveryType == null ||
                 this.CardDeliveryType?.Equals(other.CardDeliveryType) == true) &&
                (this.CardContact == null && other.CardContact == null ||
                 this.CardContact?.Equals(other.CardContact) == true) &&
                (this.PINDeliveryAddressType == null && other.PINDeliveryAddressType == null ||
                 this.PINDeliveryAddressType?.Equals(other.PINDeliveryAddressType) == true) &&
                (this.PINAdviceType == null && other.PINAdviceType == null ||
                 this.PINAdviceType?.Equals(other.PINAdviceType) == true) &&
                (this.PINContact == null && other.PINContact == null ||
                 this.PINContact?.Equals(other.PINContact) == true) &&
                (this.NotifyCaller == null && other.NotifyCaller == null ||
                 this.NotifyCaller?.Equals(other.NotifyCaller) == true) &&
                (this.Caller == null && other.Caller == null ||
                 this.Caller?.Equals(other.Caller) == true) &&
                (this.NotifyCallerOnSync == null && other.NotifyCallerOnSync == null ||
                 this.NotifyCallerOnSync?.Equals(other.NotifyCallerOnSync) == true) &&
                (this.ValidateFleetId == null && other.ValidateFleetId == null ||
                 this.ValidateFleetId?.Equals(other.ValidateFleetId) == true) &&
                (this.FleetOption == null && other.FleetOption == null ||
                 this.FleetOption?.Equals(other.FleetOption) == true) &&
                (this.BundleId == null && other.BundleId == null ||
                 this.BundleId?.Equals(other.BundleId) == true) &&
                (this.UsageRestrictionAction == null && other.UsageRestrictionAction == null ||
                 this.UsageRestrictionAction?.Equals(other.UsageRestrictionAction) == true) &&
                (this.ProductRestrictionAction == null && other.ProductRestrictionAction == null ||
                 this.ProductRestrictionAction?.Equals(other.ProductRestrictionAction) == true) &&
                (this.Products == null && other.Products == null ||
                 this.Products?.Equals(other.Products) == true) &&
                (this.ProductGroups == null && other.ProductGroups == null ||
                 this.ProductGroups?.Equals(other.ProductGroups) == true) &&
                (this.ExpiryDate == null && other.ExpiryDate == null ||
                 this.ExpiryDate?.Equals(other.ExpiryDate) == true) &&
                (this.ClientReferenceId == null && other.ClientReferenceId == null ||
                 this.ClientReferenceId?.Equals(other.ClientReferenceId) == true) &&
                (this.AutoRenew == null && other.AutoRenew == null ||
                 this.AutoRenew?.Equals(other.AutoRenew) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.TokenTypeId = {(this.TokenTypeId == null ? "null" : this.TokenTypeId.ToString())}");
            toStringOutput.Add($"this.EmbossText = {this.EmbossText ?? "null"}");
            toStringOutput.Add($"this.VRN = {this.VRN ?? "null"}");
            toStringOutput.Add($"this.DriverName = {this.DriverName ?? "null"}");
            toStringOutput.Add($"this.OdometerInputRequired = {(this.OdometerInputRequired == null ? "null" : this.OdometerInputRequired.ToString())}");
            toStringOutput.Add($"this.FleetIdInputRequired = {(this.FleetIdInputRequired == null ? "null" : this.FleetIdInputRequired.ToString())}");
            toStringOutput.Add($"this.PurchaseCategoryId = {(this.PurchaseCategoryId == null ? "null" : this.PurchaseCategoryId.ToString())}");
            toStringOutput.Add($"this.SelfSelectedEncryptedPIN = {this.SelfSelectedEncryptedPIN ?? "null"}");
            toStringOutput.Add($"this.SelfSelectedPINKeyID = {this.SelfSelectedPINKeyID ?? "null"}");
            toStringOutput.Add($"this.SelfSelectedPINSessionKey = {this.SelfSelectedPINSessionKey ?? "null"}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {this.CardGroupName ?? "null"}");
            toStringOutput.Add($"this.IsNewCardGroup = {(this.IsNewCardGroup == null ? "null" : this.IsNewCardGroup.ToString())}");
            toStringOutput.Add($"this.EmbossCardGroup = {(this.EmbossCardGroup == null ? "null" : this.EmbossCardGroup.ToString())}");
            toStringOutput.Add($"this.CardDeliveryType = {(this.CardDeliveryType == null ? "null" : this.CardDeliveryType.ToString())}");
            toStringOutput.Add($"this.CardContact = {(this.CardContact == null ? "null" : this.CardContact.ToString())}");
            toStringOutput.Add($"this.PINDeliveryAddressType = {(this.PINDeliveryAddressType == null ? "null" : this.PINDeliveryAddressType.ToString())}");
            toStringOutput.Add($"this.PINAdviceType = {(this.PINAdviceType == null ? "null" : this.PINAdviceType.ToString())}");
            toStringOutput.Add($"this.PINContact = {(this.PINContact == null ? "null" : this.PINContact.ToString())}");
            toStringOutput.Add($"this.NotifyCaller = {(this.NotifyCaller == null ? "null" : this.NotifyCaller.ToString())}");
            toStringOutput.Add($"this.Caller = {this.Caller ?? "null"}");
            toStringOutput.Add($"this.NotifyCallerOnSync = {(this.NotifyCallerOnSync == null ? "null" : this.NotifyCallerOnSync.ToString())}");
            toStringOutput.Add($"this.ValidateFleetId = {(this.ValidateFleetId == null ? "null" : this.ValidateFleetId.ToString())}");
            toStringOutput.Add($"this.FleetOption = {this.FleetOption ?? "null"}");
            toStringOutput.Add($"this.BundleId = {this.BundleId ?? "null"}");
            toStringOutput.Add($"this.UsageRestrictionAction = {this.UsageRestrictionAction ?? "null"}");
            toStringOutput.Add($"this.ProductRestrictionAction = {this.ProductRestrictionAction ?? "null"}");
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
            toStringOutput.Add($"this.ProductGroups = {(this.ProductGroups == null ? "null" : $"[{string.Join(", ", this.ProductGroups)} ]")}");
            toStringOutput.Add($"this.ExpiryDate = {this.ExpiryDate ?? "null"}");
            toStringOutput.Add($"this.ClientReferenceId = {this.ClientReferenceId ?? "null"}");
            toStringOutput.Add($"this.AutoRenew = {(this.AutoRenew == null ? "null" : this.AutoRenew.ToString())}");
        }
    }
}
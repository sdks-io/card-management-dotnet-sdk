// <copyright file="CardGroupResponseCardGroupsItems.cs" company="APIMatic">
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
    /// CardGroupResponseCardGroupsItems.
    /// </summary>
    public class CardGroupResponseCardGroupsItems
    {
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private int? activeCards;
        private int? blockedCards;
        private int? cancelledCards;
        private bool? cardDeliveryPoint;
        private int? cardGroupId;
        private string cardGroupName;
        private string cardTypeCode;
        private int? cardTypeId;
        private string cardTypeName;
        private int? expiredCards;
        private string expiryDate;
        private bool? printOnCard;
        private int? renewalPendingCards;
        private int? replacedCards;
        private string status;
        private int? temporaryBlockByCustomer;
        private int? temporaryBlockByShell;
        private string terminatedDate;
        private int? totalCards;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "ActiveCards", false },
            { "BlockedCards", false },
            { "CancelledCards", false },
            { "CardDeliveryPoint", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "CardTypeCode", false },
            { "CardTypeId", false },
            { "CardTypeName", false },
            { "ExpiredCards", false },
            { "ExpiryDate", false },
            { "PrintOnCard", false },
            { "RenewalPendingCards", false },
            { "ReplacedCards", false },
            { "Status", false },
            { "TemporaryBlockByCustomer", false },
            { "TemporaryBlockByShell", false },
            { "TerminatedDate", false },
            { "TotalCards", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardGroupResponseCardGroupsItems"/> class.
        /// </summary>
        public CardGroupResponseCardGroupsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardGroupResponseCardGroupsItems"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="activeCards">ActiveCards.</param>
        /// <param name="blockedCards">BlockedCards.</param>
        /// <param name="cancelledCards">CancelledCards.</param>
        /// <param name="cardDeliveryPoint">CardDeliveryPoint.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="expiredCards">ExpiredCards.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="printOnCard">PrintOnCard.</param>
        /// <param name="renewalPendingCards">RenewalPendingCards.</param>
        /// <param name="replacedCards">ReplacedCards.</param>
        /// <param name="status">Status.</param>
        /// <param name="temporaryBlockByCustomer">TemporaryBlockByCustomer.</param>
        /// <param name="temporaryBlockByShell">TemporaryBlockByShell.</param>
        /// <param name="terminatedDate">TerminatedDate.</param>
        /// <param name="totalCards">TotalCards.</param>
        public CardGroupResponseCardGroupsItems(
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            int? activeCards = null,
            int? blockedCards = null,
            int? cancelledCards = null,
            bool? cardDeliveryPoint = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            string cardTypeCode = null,
            int? cardTypeId = null,
            string cardTypeName = null,
            int? expiredCards = null,
            string expiryDate = null,
            bool? printOnCard = null,
            int? renewalPendingCards = null,
            int? replacedCards = null,
            string status = null,
            int? temporaryBlockByCustomer = null,
            int? temporaryBlockByShell = null,
            string terminatedDate = null,
            int? totalCards = null)
        {

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (activeCards != null)
            {
                this.ActiveCards = activeCards;
            }

            if (blockedCards != null)
            {
                this.BlockedCards = blockedCards;
            }

            if (cancelledCards != null)
            {
                this.CancelledCards = cancelledCards;
            }

            if (cardDeliveryPoint != null)
            {
                this.CardDeliveryPoint = cardDeliveryPoint;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
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

            if (expiredCards != null)
            {
                this.ExpiredCards = expiredCards;
            }

            if (expiryDate != null)
            {
                this.ExpiryDate = expiryDate;
            }

            if (printOnCard != null)
            {
                this.PrintOnCard = printOnCard;
            }

            if (renewalPendingCards != null)
            {
                this.RenewalPendingCards = renewalPendingCards;
            }

            if (replacedCards != null)
            {
                this.ReplacedCards = replacedCards;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (temporaryBlockByCustomer != null)
            {
                this.TemporaryBlockByCustomer = temporaryBlockByCustomer;
            }

            if (temporaryBlockByShell != null)
            {
                this.TemporaryBlockByShell = temporaryBlockByShell;
            }

            if (terminatedDate != null)
            {
                this.TerminatedDate = terminatedDate;
            }

            if (totalCards != null)
            {
                this.TotalCards = totalCards;
            }
        }

        /// <summary>
        /// Account Id for the associated card group
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
        /// Account number for the associated card group
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
        /// Account short name for the associated card group
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
        /// Total number of active cards for the given search criteria
        /// </summary>
        [JsonProperty("ActiveCards")]
        public int? ActiveCards
        {
            get
            {
                return this.activeCards;
            }

            set
            {
                this.shouldSerialize["ActiveCards"] = true;
                this.activeCards = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are permanently blocked
        /// </summary>
        [JsonProperty("BlockedCards")]
        public int? BlockedCards
        {
            get
            {
                return this.blockedCards;
            }

            set
            {
                this.shouldSerialize["BlockedCards"] = true;
                this.blockedCards = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are cancelled
        /// </summary>
        [JsonProperty("CancelledCards")]
        public int? CancelledCards
        {
            get
            {
                return this.cancelledCards;
            }

            set
            {
                this.shouldSerialize["CancelledCards"] = true;
                this.cancelledCards = value;
            }
        }

        /// <summary>
        /// card delivery point enabled or not
        /// </summary>
        [JsonProperty("CardDeliveryPoint")]
        public bool? CardDeliveryPoint
        {
            get
            {
                return this.cardDeliveryPoint;
            }

            set
            {
                this.shouldSerialize["CardDeliveryPoint"] = true;
                this.cardDeliveryPoint = value;
            }
        }

        /// <summary>
        /// Id of the card group matching the search criteria.
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
        /// Name of the card group matching the search criteria.
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
        /// Card Type Code
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
        /// Card Type Id
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
        /// Card Type Name
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
        /// Total number of expired cards for the given search criteria
        /// </summary>
        [JsonProperty("ExpiredCards")]
        public int? ExpiredCards
        {
            get
            {
                return this.expiredCards;
            }

            set
            {
                this.shouldSerialize["ExpiredCards"] = true;
                this.expiredCards = value;
            }
        }

        /// <summary>
        /// Expiry date of the card.
        /// Format: yyyyMMdd
        /// Note: Clients to convert this to appropriate DateTime type.
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
        /// PrintOnCard true/false
        /// </summary>
        [JsonProperty("PrintOnCard")]
        public bool? PrintOnCard
        {
            get
            {
                return this.printOnCard;
            }

            set
            {
                this.shouldSerialize["PrintOnCard"] = true;
                this.printOnCard = value;
            }
        }

        /// <summary>
        /// Total number of Renewal Pending Cards for the given search criteria
        /// </summary>
        [JsonProperty("RenewalPendingCards")]
        public int? RenewalPendingCards
        {
            get
            {
                return this.renewalPendingCards;
            }

            set
            {
                this.shouldSerialize["RenewalPendingCards"] = true;
                this.renewalPendingCards = value;
            }
        }

        /// <summary>
        /// Gets or sets ReplacedCards.
        /// </summary>
        [JsonProperty("ReplacedCards")]
        public int? ReplacedCards
        {
            get
            {
                return this.replacedCards;
            }

            set
            {
                this.shouldSerialize["ReplacedCards"] = true;
                this.replacedCards = value;
            }
        }

        /// <summary>
        /// Status of the card group.
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
        /// Total number of cards for the given search criteria that are temporarily blocked by customer
        /// </summary>
        [JsonProperty("TemporaryBlockByCustomer")]
        public int? TemporaryBlockByCustomer
        {
            get
            {
                return this.temporaryBlockByCustomer;
            }

            set
            {
                this.shouldSerialize["TemporaryBlockByCustomer"] = true;
                this.temporaryBlockByCustomer = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are temporarily blocked by Shell
        /// </summary>
        [JsonProperty("TemporaryBlockByShell")]
        public int? TemporaryBlockByShell
        {
            get
            {
                return this.temporaryBlockByShell;
            }

            set
            {
                this.shouldSerialize["TemporaryBlockByShell"] = true;
                this.temporaryBlockByShell = value;
            }
        }

        /// <summary>
        /// Terminated Date.
        /// Format: yyyyMMdd
        /// Note: Clients to convert this to appropriate Date Time type.
        /// </summary>
        [JsonProperty("TerminatedDate")]
        public string TerminatedDate
        {
            get
            {
                return this.terminatedDate;
            }

            set
            {
                this.shouldSerialize["TerminatedDate"] = true;
                this.terminatedDate = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria
        /// </summary>
        [JsonProperty("TotalCards")]
        public int? TotalCards
        {
            get
            {
                return this.totalCards;
            }

            set
            {
                this.shouldSerialize["TotalCards"] = true;
                this.totalCards = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardGroupResponseCardGroupsItems : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountShortName()
        {
            this.shouldSerialize["AccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetActiveCards()
        {
            this.shouldSerialize["ActiveCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBlockedCards()
        {
            this.shouldSerialize["BlockedCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCancelledCards()
        {
            this.shouldSerialize["CancelledCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardDeliveryPoint()
        {
            this.shouldSerialize["CardDeliveryPoint"] = false;
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
        public void UnsetCardTypeCode()
        {
            this.shouldSerialize["CardTypeCode"] = false;
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
        public void UnsetCardTypeName()
        {
            this.shouldSerialize["CardTypeName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiredCards()
        {
            this.shouldSerialize["ExpiredCards"] = false;
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
        public void UnsetPrintOnCard()
        {
            this.shouldSerialize["PrintOnCard"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRenewalPendingCards()
        {
            this.shouldSerialize["RenewalPendingCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReplacedCards()
        {
            this.shouldSerialize["ReplacedCards"] = false;
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
        public void UnsetTemporaryBlockByCustomer()
        {
            this.shouldSerialize["TemporaryBlockByCustomer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTemporaryBlockByShell()
        {
            this.shouldSerialize["TemporaryBlockByShell"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTerminatedDate()
        {
            this.shouldSerialize["TerminatedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotalCards()
        {
            this.shouldSerialize["TotalCards"] = false;
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
        public bool ShouldSerializeAccountShortName()
        {
            return this.shouldSerialize["AccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeActiveCards()
        {
            return this.shouldSerialize["ActiveCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBlockedCards()
        {
            return this.shouldSerialize["BlockedCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancelledCards()
        {
            return this.shouldSerialize["CancelledCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardDeliveryPoint()
        {
            return this.shouldSerialize["CardDeliveryPoint"];
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
        public bool ShouldSerializeExpiredCards()
        {
            return this.shouldSerialize["ExpiredCards"];
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
        public bool ShouldSerializePrintOnCard()
        {
            return this.shouldSerialize["PrintOnCard"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewalPendingCards()
        {
            return this.shouldSerialize["RenewalPendingCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReplacedCards()
        {
            return this.shouldSerialize["ReplacedCards"];
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
        public bool ShouldSerializeTemporaryBlockByCustomer()
        {
            return this.shouldSerialize["TemporaryBlockByCustomer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryBlockByShell()
        {
            return this.shouldSerialize["TemporaryBlockByShell"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTerminatedDate()
        {
            return this.shouldSerialize["TerminatedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCards()
        {
            return this.shouldSerialize["TotalCards"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardGroupResponseCardGroupsItems other &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountShortName == null && other.AccountShortName == null ||
                 this.AccountShortName?.Equals(other.AccountShortName) == true) &&
                (this.ActiveCards == null && other.ActiveCards == null ||
                 this.ActiveCards?.Equals(other.ActiveCards) == true) &&
                (this.BlockedCards == null && other.BlockedCards == null ||
                 this.BlockedCards?.Equals(other.BlockedCards) == true) &&
                (this.CancelledCards == null && other.CancelledCards == null ||
                 this.CancelledCards?.Equals(other.CancelledCards) == true) &&
                (this.CardDeliveryPoint == null && other.CardDeliveryPoint == null ||
                 this.CardDeliveryPoint?.Equals(other.CardDeliveryPoint) == true) &&
                (this.CardGroupId == null && other.CardGroupId == null ||
                 this.CardGroupId?.Equals(other.CardGroupId) == true) &&
                (this.CardGroupName == null && other.CardGroupName == null ||
                 this.CardGroupName?.Equals(other.CardGroupName) == true) &&
                (this.CardTypeCode == null && other.CardTypeCode == null ||
                 this.CardTypeCode?.Equals(other.CardTypeCode) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.CardTypeName == null && other.CardTypeName == null ||
                 this.CardTypeName?.Equals(other.CardTypeName) == true) &&
                (this.ExpiredCards == null && other.ExpiredCards == null ||
                 this.ExpiredCards?.Equals(other.ExpiredCards) == true) &&
                (this.ExpiryDate == null && other.ExpiryDate == null ||
                 this.ExpiryDate?.Equals(other.ExpiryDate) == true) &&
                (this.PrintOnCard == null && other.PrintOnCard == null ||
                 this.PrintOnCard?.Equals(other.PrintOnCard) == true) &&
                (this.RenewalPendingCards == null && other.RenewalPendingCards == null ||
                 this.RenewalPendingCards?.Equals(other.RenewalPendingCards) == true) &&
                (this.ReplacedCards == null && other.ReplacedCards == null ||
                 this.ReplacedCards?.Equals(other.ReplacedCards) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.TemporaryBlockByCustomer == null && other.TemporaryBlockByCustomer == null ||
                 this.TemporaryBlockByCustomer?.Equals(other.TemporaryBlockByCustomer) == true) &&
                (this.TemporaryBlockByShell == null && other.TemporaryBlockByShell == null ||
                 this.TemporaryBlockByShell?.Equals(other.TemporaryBlockByShell) == true) &&
                (this.TerminatedDate == null && other.TerminatedDate == null ||
                 this.TerminatedDate?.Equals(other.TerminatedDate) == true) &&
                (this.TotalCards == null && other.TotalCards == null ||
                 this.TotalCards?.Equals(other.TotalCards) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountShortName = {this.AccountShortName ?? "null"}");
            toStringOutput.Add($"ActiveCards = {(this.ActiveCards == null ? "null" : this.ActiveCards.ToString())}");
            toStringOutput.Add($"BlockedCards = {(this.BlockedCards == null ? "null" : this.BlockedCards.ToString())}");
            toStringOutput.Add($"CancelledCards = {(this.CancelledCards == null ? "null" : this.CancelledCards.ToString())}");
            toStringOutput.Add($"CardDeliveryPoint = {(this.CardDeliveryPoint == null ? "null" : this.CardDeliveryPoint.ToString())}");
            toStringOutput.Add($"CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"CardGroupName = {this.CardGroupName ?? "null"}");
            toStringOutput.Add($"CardTypeCode = {this.CardTypeCode ?? "null"}");
            toStringOutput.Add($"CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"CardTypeName = {this.CardTypeName ?? "null"}");
            toStringOutput.Add($"ExpiredCards = {(this.ExpiredCards == null ? "null" : this.ExpiredCards.ToString())}");
            toStringOutput.Add($"ExpiryDate = {this.ExpiryDate ?? "null"}");
            toStringOutput.Add($"PrintOnCard = {(this.PrintOnCard == null ? "null" : this.PrintOnCard.ToString())}");
            toStringOutput.Add($"RenewalPendingCards = {(this.RenewalPendingCards == null ? "null" : this.RenewalPendingCards.ToString())}");
            toStringOutput.Add($"ReplacedCards = {(this.ReplacedCards == null ? "null" : this.ReplacedCards.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"TemporaryBlockByCustomer = {(this.TemporaryBlockByCustomer == null ? "null" : this.TemporaryBlockByCustomer.ToString())}");
            toStringOutput.Add($"TemporaryBlockByShell = {(this.TemporaryBlockByShell == null ? "null" : this.TemporaryBlockByShell.ToString())}");
            toStringOutput.Add($"TerminatedDate = {this.TerminatedDate ?? "null"}");
            toStringOutput.Add($"TotalCards = {(this.TotalCards == null ? "null" : this.TotalCards.ToString())}");
        }
    }
}
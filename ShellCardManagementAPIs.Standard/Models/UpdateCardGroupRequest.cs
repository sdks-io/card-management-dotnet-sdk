// <copyright file="UpdateCardGroupRequest.cs" company="APIMatic">
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
    /// UpdateCardGroupRequest.
    /// </summary>
    public class UpdateCardGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupRequest"/> class.
        /// </summary>
        public UpdateCardGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardGroupRequest"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="printOnCard">PrintOnCard.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="terminateCardGroup">TerminateCardGroup.</param>
        /// <param name="moveCards">MoveCards.</param>
        /// <param name="targetAccountId">TargetAccountId.</param>
        /// <param name="targetAccountNumber">TargetAccountNumber.</param>
        /// <param name="targetNewCardGroupName">TargetNewCardGroupName.</param>
        /// <param name="targetCardGroupId">TargetCardGroupId.</param>
        public UpdateCardGroupRequest(
            int? colCoCode = null,
            int? colCoId = null,
            string payerNumber = null,
            int? payerId = null,
            int? accountId = null,
            string accountNumber = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            bool? printOnCard = null,
            int? cardTypeId = null,
            bool? terminateCardGroup = null,
            bool? moveCards = null,
            int? targetAccountId = null,
            string targetAccountNumber = null,
            string targetNewCardGroupName = null,
            int? targetCardGroupId = null)
        {
            this.ColCoCode = colCoCode;
            this.ColCoId = colCoId;
            this.PayerNumber = payerNumber;
            this.PayerId = payerId;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.CardGroupId = cardGroupId;
            this.CardGroupName = cardGroupName;
            this.PrintOnCard = printOnCard;
            this.CardTypeId = cardTypeId;
            this.TerminateCardGroup = terminateCardGroup;
            this.MoveCards = moveCards;
            this.TargetAccountId = targetAccountId;
            this.TargetAccountNumber = targetAccountNumber;
            this.TargetNewCardGroupName = targetNewCardGroupName;
            this.TargetCardGroupId = targetCardGroupId;
        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Payer Id (i.e., Customer Id of the Payment Customer) of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// Example: 123456
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Account ID of the card-group to be updated/terminated.
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number of the card-group to be updated/terminated.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Unique Id of the card group that needs to be updated or terminated.
        /// </summary>
        [JsonProperty("CardGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardGroupId { get; set; }

        /// <summary>
        /// <![CDATA[
        /// New name for the card group if it needs to be updated. Set this field to ‘null’ if no change required to the current card group name.
        /// Optional
        /// Minimum length: 1 (Configurable)
        /// Maximum length: 40 (Configurable)
        /// Allowed characters (Configurable) are: - A-Z 0-9, / ‘. & Ä Ö Ü Å Æ É Ø
        /// Note: The card group name has to be unique for customer. Else an error with error code 9015 is returned.
        /// ]]>
        /// </summary>
        [JsonProperty("CardGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string CardGroupName { get; set; }

        /// <summary>
        /// Whether to emboss the card group name on the cards.
        /// Populate this field only if the value needs to be updated. Otherwise set to ‘null’.
        /// </summary>
        [JsonProperty("PrintOnCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintOnCard { get; set; }

        /// <summary>
        /// Card Type ID of the card group.
        /// Populate this field if the value needs to be updated. Otherwise set to ‘null’.
        /// Optional
        /// Note:
        /// 1)    If a card type is passed, the cardgorup will allow cards with same card type to be moved in to the card group.
        /// 2)    Pass ‘-1’ to remove the card type from the card group.
        /// </summary>
        [JsonProperty("CardTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardTypeId { get; set; }

        /// <summary>
        /// Whether to terminate the card group.
        /// When set to true, the card group will be terminated by setting current date as it’s termination date.
        /// Optional, False by default .
        /// </summary>
        [JsonProperty("TerminateCardGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TerminateCardGroup { get; set; }

        /// <summary>
        /// Whether to move the cards from this CardGroup in to a different or a new CardGroup.
        /// Optional
        /// When the value is set to ‘False’ or ‘null’, the cards that are currently in the card-group will remain under the same card-group.
        /// </summary>
        [JsonProperty("MoveCards", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MoveCards { get; set; }

        /// <summary>
        /// Account ID of the new/target card-group.
        /// Either TargetAccountId or TargetAccountNumber is mandatory when MoveCards is set to True.
        /// </summary>
        [JsonProperty("TargetAccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetAccountId { get; set; }

        /// <summary>
        /// Account Number of the new/target card-group.
        /// Either TargetAccountId or TargetAccountNumber is mandatory when MoveCards is set to True.
        /// </summary>
        [JsonProperty("TargetAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetAccountNumber { get; set; }

        /// <summary>
        /// Name of the new card group if the cards in the existing card-group have to be moved to a new card-group.
        /// Mandatory when MoveCards parameter is True and TargetCardGroupId is null.
        /// Minimum length: 1 (Configurable)
        /// Maximum length: 30 (Configurable)
        /// </summary>
        [JsonProperty("TargetNewCardGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetNewCardGroupName { get; set; }

        /// <summary>
        /// ID of the card group if the cards in the existing card-group have to be moved to another existing card-group.
        /// Mandatory when MoveCards parameter is True and TargetNewCardGroupName is null.
        /// If the value is “-1” then the cards will be moved out of the current CardGroup.
        /// </summary>
        [JsonProperty("TargetCardGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetCardGroupId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardGroupRequest other &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.ColCoId == null && other.ColCoId == null ||
                 this.ColCoId?.Equals(other.ColCoId) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.CardGroupId == null && other.CardGroupId == null ||
                 this.CardGroupId?.Equals(other.CardGroupId) == true) &&
                (this.CardGroupName == null && other.CardGroupName == null ||
                 this.CardGroupName?.Equals(other.CardGroupName) == true) &&
                (this.PrintOnCard == null && other.PrintOnCard == null ||
                 this.PrintOnCard?.Equals(other.PrintOnCard) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.TerminateCardGroup == null && other.TerminateCardGroup == null ||
                 this.TerminateCardGroup?.Equals(other.TerminateCardGroup) == true) &&
                (this.MoveCards == null && other.MoveCards == null ||
                 this.MoveCards?.Equals(other.MoveCards) == true) &&
                (this.TargetAccountId == null && other.TargetAccountId == null ||
                 this.TargetAccountId?.Equals(other.TargetAccountId) == true) &&
                (this.TargetAccountNumber == null && other.TargetAccountNumber == null ||
                 this.TargetAccountNumber?.Equals(other.TargetAccountNumber) == true) &&
                (this.TargetNewCardGroupName == null && other.TargetNewCardGroupName == null ||
                 this.TargetNewCardGroupName?.Equals(other.TargetNewCardGroupName) == true) &&
                (this.TargetCardGroupId == null && other.TargetCardGroupId == null ||
                 this.TargetCardGroupId?.Equals(other.TargetCardGroupId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {this.CardGroupName ?? "null"}");
            toStringOutput.Add($"this.PrintOnCard = {(this.PrintOnCard == null ? "null" : this.PrintOnCard.ToString())}");
            toStringOutput.Add($"this.CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"this.TerminateCardGroup = {(this.TerminateCardGroup == null ? "null" : this.TerminateCardGroup.ToString())}");
            toStringOutput.Add($"this.MoveCards = {(this.MoveCards == null ? "null" : this.MoveCards.ToString())}");
            toStringOutput.Add($"this.TargetAccountId = {(this.TargetAccountId == null ? "null" : this.TargetAccountId.ToString())}");
            toStringOutput.Add($"this.TargetAccountNumber = {this.TargetAccountNumber ?? "null"}");
            toStringOutput.Add($"this.TargetNewCardGroupName = {this.TargetNewCardGroupName ?? "null"}");
            toStringOutput.Add($"this.TargetCardGroupId = {(this.TargetCardGroupId == null ? "null" : this.TargetCardGroupId.ToString())}");
        }
    }
}
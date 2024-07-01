// <copyright file="PINReminderCardDetails.cs" company="APIMatic">
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
    /// PINReminderCardDetails.
    /// </summary>
    public class PINReminderCardDetails
    {
        private string cardExpiryDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CardExpiryDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderCardDetails"/> class.
        /// </summary>
        public PINReminderCardDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINReminderCardDetails"/> class.
        /// </summary>
        /// <param name="pINAdviceType">PINAdviceType.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pANID">PANID.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="pINContactType">PINContactType.</param>
        /// <param name="pINDeliverTo">PINDeliverTo.</param>
        public PINReminderCardDetails(
            int pINAdviceType,
            int? cardId = null,
            int? pANID = null,
            string pAN = null,
            string cardExpiryDate = null,
            int? pINContactType = null,
            Models.PINDeliverTo pINDeliverTo = null)
        {
            this.CardId = cardId;
            this.PANID = pANID;
            this.PAN = pAN;
            if (cardExpiryDate != null)
            {
                this.CardExpiryDate = cardExpiryDate;
            }

            this.PINAdviceType = pINAdviceType;
            this.PINContactType = pINContactType;
            this.PINDeliverTo = pINDeliverTo;
        }

        /// <summary>
        /// <![CDATA[
        /// Card Id
        /// Optional if Either PANID AND CardExpiryDate or PAN AND CardExpiryDate is passed, else Mandatory. Example: 275549 .<br/>Note:PANID, PAN & ExpiryDate parameters will be ignored if CardId is provided.
        /// ]]>
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// PAN ID - Unique PAN ID
        /// Optional if Either CardId or PAN AND  ExpiryDate is passed, else Mandatory. Example: 123456. <br/>Note:PANID parameter will be considered only if CardId is not provided
        /// </summary>
        [JsonProperty("PANID", NullValueHandling = NullValueHandling.Ignore)]
        public int? PANID { get; set; }

        /// <summary>
        /// <![CDATA[
        /// PAN of the card.
        /// Optional if Either CardId or PANID is passed, else Mandatory. <br/>Note:PAN & ExpiryDate parameters will be considered only if CardId & PANID are not provided
        /// ]]>
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Expiry date of the card.
        /// Mandatory if Either PAN or PANID is passed, else optional.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CardExpiryDate")]
        public string CardExpiryDate
        {
            get
            {
                return this.cardExpiryDate;
            }

            set
            {
                this.shouldSerialize["CardExpiryDate"] = true;
                this.cardExpiryDate = value;
            }
        }

        /// <summary>
        /// PIN delivery method.
        /// Mandatory
        /// Allowed Values:
        ///    1.	Paper
        ///    2.	Email
        ///    3.	SMS
        /// </summary>
        [JsonProperty("PINAdviceType")]
        public int PINAdviceType { get; set; }

        /// <summary>
        /// PIN Contact Type.
        /// Mandatory
        /// Allowed Values:
        /// 1.	Use PIN Delivery contact details stored previously for this card
        /// 2.	Use Card Delivery contact details stored previously for this card
        /// 3.	Use default PIN Delivery contact details stored for this customer
        /// 4.	Use new specific contact for PIN Reminder only
        /// Note: - PINContactType “3” is only allowed for Paper delivery
        /// </summary>
        [JsonProperty("PINContactType", NullValueHandling = NullValueHandling.Ignore)]
        public int? PINContactType { get; set; }

        /// <summary>
        /// Gets or sets PINDeliverTo.
        /// </summary>
        [JsonProperty("PINDeliverTo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PINDeliverTo PINDeliverTo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PINReminderCardDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardExpiryDate()
        {
            this.shouldSerialize["CardExpiryDate"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardExpiryDate()
        {
            return this.shouldSerialize["CardExpiryDate"];
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
            return obj is PINReminderCardDetails other &&                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PANID == null && other.PANID == null) || (this.PANID?.Equals(other.PANID) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardExpiryDate == null && other.CardExpiryDate == null) || (this.CardExpiryDate?.Equals(other.CardExpiryDate) == true)) &&
                this.PINAdviceType.Equals(other.PINAdviceType) &&
                ((this.PINContactType == null && other.PINContactType == null) || (this.PINContactType?.Equals(other.PINContactType) == true)) &&
                ((this.PINDeliverTo == null && other.PINDeliverTo == null) || (this.PINDeliverTo?.Equals(other.PINDeliverTo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PANID = {(this.PANID == null ? "null" : this.PANID.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardExpiryDate = {(this.CardExpiryDate == null ? "null" : this.CardExpiryDate)}");
            toStringOutput.Add($"this.PINAdviceType = {this.PINAdviceType}");
            toStringOutput.Add($"this.PINContactType = {(this.PINContactType == null ? "null" : this.PINContactType.ToString())}");
            toStringOutput.Add($"this.PINDeliverTo = {(this.PINDeliverTo == null ? "null" : this.PINDeliverTo.ToString())}");
        }
    }
}
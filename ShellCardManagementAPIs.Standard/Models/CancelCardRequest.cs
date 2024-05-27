// <copyright file="CancelCardRequest.cs" company="APIMatic">
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
    /// CancelCardRequest.
    /// </summary>
    public class CancelCardRequest
    {
        private int? reasonId;
        private string reasonText;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ReasonId", false },
            { "ReasonText", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCardRequest"/> class.
        /// </summary>
        public CancelCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCardRequest"/> class.
        /// </summary>
        /// <param name="cards">Cards.</param>
        /// <param name="reasonId">ReasonId.</param>
        /// <param name="reasonText">ReasonText.</param>
        public CancelCardRequest(
            List<Models.UpdateCard> cards,
            int? reasonId = null,
            string reasonText = null)
        {
            this.Cards = cards;
            if (reasonId != null)
            {
                this.ReasonId = reasonId;
            }

            if (reasonText != null)
            {
                this.ReasonText = reasonText;
            }

        }

        /// <summary>
        /// List of CancelCardRequest entity.
        /// Each card in the list will be Cancelled.
        /// The details of the entity are given below.
        /// </summary>
        [JsonProperty("Cards")]
        public List<Models.UpdateCard> Cards { get; set; }

        /// <summary>
        /// Reason id for cancelling the card.<br />
        /// Optional if ReasonText is passed, else mandatory<br />
        /// When passed, the reason Id will be validated with the allowed reason id’s configured for the card type of the card.<br />
        /// If the reason Id is not allowed, then it will be included on the error cards response.
        /// Possible values:
        /// 1 (Lost)
        /// 2 (Stolen)
        /// 3 (Card no longer required)
        /// </summary>
        [JsonProperty("ReasonId")]
        public int? ReasonId
        {
            get
            {
                return this.reasonId;
            }

            set
            {
                this.shouldSerialize["ReasonId"] = true;
                this.reasonId = value;
            }
        }

        /// <summary>
        /// Reason text for cancelling the card.<br />
        /// Optional if ReasonId is passed, else mandatory<br />
        /// When Reason Id is not known to the client, the reason text can be passed.<br />
        /// When Reason Text is passed and the Target Status is either Block or Damaged, the text will be validated with the allowed list of values configured for the card type of the card.
        /// If the text is not allowed, then it will be included on the error cards response.
        /// However, if the Target status is Temporary block or Unblock then the text will be submitted
        /// Possible Values:
        /// 1) Lost
        /// 2) Stolen
        /// 3) Card no longer required
        /// </summary>
        [JsonProperty("ReasonText")]
        public string ReasonText
        {
            get
            {
                return this.reasonText;
            }

            set
            {
                this.shouldSerialize["ReasonText"] = true;
                this.reasonText = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancelCardRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReasonId()
        {
            this.shouldSerialize["ReasonId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReasonText()
        {
            this.shouldSerialize["ReasonText"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReasonId()
        {
            return this.shouldSerialize["ReasonId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReasonText()
        {
            return this.shouldSerialize["ReasonText"];
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
            return obj is CancelCardRequest other &&                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.ReasonId == null && other.ReasonId == null) || (this.ReasonId?.Equals(other.ReasonId) == true)) &&
                ((this.ReasonText == null && other.ReasonText == null) || (this.ReasonText?.Equals(other.ReasonText) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.ReasonId = {(this.ReasonId == null ? "null" : this.ReasonId.ToString())}");
            toStringOutput.Add($"this.ReasonText = {(this.ReasonText == null ? "null" : this.ReasonText)}");
        }
    }
}
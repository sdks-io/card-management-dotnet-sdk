// <copyright file="UpdateCardStatusRequest.cs" company="APIMatic">
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
    /// UpdateCardStatusRequest.
    /// </summary>
    public class UpdateCardStatusRequest
    {
        private int? reasonId;
        private string reasonText;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ReasonId", false },
            { "ReasonText", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardStatusRequest"/> class.
        /// </summary>
        public UpdateCardStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardStatusRequest"/> class.
        /// </summary>
        /// <param name="cards">Cards.</param>
        /// <param name="targetStatus">TargetStatus.</param>
        /// <param name="reasonId">ReasonId.</param>
        /// <param name="reasonText">ReasonText.</param>
        public UpdateCardStatusRequest(
            List<Models.UpdateCard> cards,
            string targetStatus,
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
            this.TargetStatus = targetStatus;
        }

        /// <summary>
        /// List of UpdateCardRequest entity. Each card in the list will be updated to the given target status. The details of the entity are given below.
        /// </summary>
        [JsonProperty("Cards")]
        public List<Models.UpdateCard> Cards { get; set; }

        /// <summary>
        /// Reason id for updating the card status.<br />
        /// Optional<br />
        /// Either Reason ID or Text is madatory when TargetStatus is ‘Block’ or ‘Damaged’. Else ignored.<br />
        /// Possible values:<br />
        /// -Lost <br />
        /// -Stolen <br />
        /// -Card no longer required<br />
        /// When passed, the reason Id will be validated with the allowed reason ids configured for the card type of the card.<br />
        /// . If the given reason Id is not allowed for certain card types, then the request will be rejected as invalid ResonId.
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
        /// Reason text for updating the card status.<br />
        /// Optional Either Reason ID or Text is madatory when TargetStatus is ‘Block’ or ‘Damaged’. Else ignored.<br />
        /// Possible values:<br />
        /// -Lost <br />
        /// -Stolen <br />
        /// -Card no longer required <br />
        ///  Optional – However, either Reason ID or Text is madatory when TargetStatus is ‘Block’ or ‘Damaged’.<br />
        ///  When Reason Text is passed and the Target Status is either Block or Damaged, the text will be validated with the allowed list of values configured for the card type of the card.<br />
        ///  If the text is not allowed, request will be rejected as invaid ResonText.<br />
        ///  Note:<br />
        ///  Customer blocked’ will be used as the reason for ‘Temporary Block’.
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

        /// <summary>
        /// The list of cards passed in Cards parameter will be updated to this status.<br />
        /// Mandatory<br />
        /// Allowed values:<br />
        /// -TemporaryBlock<br />
        /// -Unblock<br />
        /// -Block<br />
        /// -Damaged<br />
        /// </summary>
        [JsonProperty("TargetStatus")]
        public string TargetStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardStatusRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReasonId()
        {
            this.shouldSerialize["ReasonId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardStatusRequest other &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
                (this.ReasonId == null && other.ReasonId == null ||
                 this.ReasonId?.Equals(other.ReasonId) == true) &&
                (this.ReasonText == null && other.ReasonText == null ||
                 this.ReasonText?.Equals(other.ReasonText) == true) &&
                (this.TargetStatus == null && other.TargetStatus == null ||
                 this.TargetStatus?.Equals(other.TargetStatus) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.ReasonId = {(this.ReasonId == null ? "null" : this.ReasonId.ToString())}");
            toStringOutput.Add($"this.ReasonText = {this.ReasonText ?? "null"}");
            toStringOutput.Add($"this.TargetStatus = {this.TargetStatus ?? "null"}");
        }
    }
}
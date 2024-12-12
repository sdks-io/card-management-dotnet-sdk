// <copyright file="ScheduleCardBlockResponseDataItems.cs" company="APIMatic">
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
    /// ScheduleCardBlockResponseDataItems.
    /// </summary>
    public class ScheduleCardBlockResponseDataItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockResponseDataItems"/> class.
        /// </summary>
        public ScheduleCardBlockResponseDataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockResponseDataItems"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="referenceId">ReferenceId.</param>
        public ScheduleCardBlockResponseDataItems(
            int? cardId = null,
            string fromDate = null,
            string toDate = null,
            int? referenceId = null)
        {
            this.CardId = cardId;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// Unique Id of the card.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Effective start date & time of Block / Unblock as updated in the intermediate queue table.
        /// Format: yyyyMMdd HH:mm
        /// Eg: 20230512 12:30
        /// ]]>
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Effective end date & time of Block / Unblock as updated in the intermediate queue table.
        /// Format: yyyyMMdd HH:mm
        /// Eg: 20230512 14:30
        /// ]]>
        /// </summary>
        [JsonProperty("ToDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Effective end date & time of Block / Unblock as updated in the intermediate queue table.
        /// Format: yyyyMMdd HH:mm
        /// Eg: 20230512 14:30
        /// ]]>
        /// </summary>
        [JsonProperty("ReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduleCardBlockResponseDataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduleCardBlockResponseDataItems other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.FromDate == null && other.FromDate == null ||
                 this.FromDate?.Equals(other.FromDate) == true) &&
                (this.ToDate == null && other.ToDate == null ||
                 this.ToDate?.Equals(other.ToDate) == true) &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.FromDate = {this.FromDate ?? "null"}");
            toStringOutput.Add($"this.ToDate = {this.ToDate ?? "null"}");
            toStringOutput.Add($"this.ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId.ToString())}");
        }
    }
}
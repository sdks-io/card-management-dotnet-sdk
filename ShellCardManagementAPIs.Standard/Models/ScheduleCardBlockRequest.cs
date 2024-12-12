// <copyright file="ScheduleCardBlockRequest.cs" company="APIMatic">
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
    /// ScheduleCardBlockRequest.
    /// </summary>
    public class ScheduleCardBlockRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockRequest"/> class.
        /// </summary>
        public ScheduleCardBlockRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCardBlockRequest"/> class.
        /// </summary>
        /// <param name="isTimeSupported">IsTimeSupported.</param>
        /// <param name="scheduleCardBlockCards">ScheduleCardBlockCards.</param>
        public ScheduleCardBlockRequest(
            bool? isTimeSupported = null,
            List<Models.ScheduleCardBlockCardsItems> scheduleCardBlockCards = null)
        {
            this.IsTimeSupported = isTimeSupported;
            this.ScheduleCardBlockCards = scheduleCardBlockCards;
        }

        /// <summary>
        /// <![CDATA[
        /// Default: False
        /// True – It supports both date & time.
        /// False – It supports only date. Time will be ignored if it is provided in the request.
        /// ]]>
        /// </summary>
        [JsonProperty("IsTimeSupported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTimeSupported { get; set; }

        /// <summary>
        /// List of ScheduleCardBlockCard entity. Each card in the list will be scheduled for Block or Unblock. The details of the entity are given below.
        /// </summary>
        [JsonProperty("ScheduleCardBlockCards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ScheduleCardBlockCardsItems> ScheduleCardBlockCards { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduleCardBlockRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduleCardBlockRequest other &&
                (this.IsTimeSupported == null && other.IsTimeSupported == null ||
                 this.IsTimeSupported?.Equals(other.IsTimeSupported) == true) &&
                (this.ScheduleCardBlockCards == null && other.ScheduleCardBlockCards == null ||
                 this.ScheduleCardBlockCards?.Equals(other.ScheduleCardBlockCards) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsTimeSupported = {(this.IsTimeSupported == null ? "null" : this.IsTimeSupported.ToString())}");
            toStringOutput.Add($"this.ScheduleCardBlockCards = {(this.ScheduleCardBlockCards == null ? "null" : $"[{string.Join(", ", this.ScheduleCardBlockCards)} ]")}");
        }
    }
}
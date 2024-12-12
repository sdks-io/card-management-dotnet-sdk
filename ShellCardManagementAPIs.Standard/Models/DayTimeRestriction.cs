// <copyright file="DayTimeRestriction.cs" company="APIMatic">
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
    /// DayTimeRestriction.
    /// </summary>
    public class DayTimeRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DayTimeRestriction"/> class.
        /// </summary>
        public DayTimeRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayTimeRestriction"/> class.
        /// </summary>
        /// <param name="monday">Monday.</param>
        /// <param name="tuesday">Tuesday.</param>
        /// <param name="wednesday">Wednesday.</param>
        /// <param name="thursday">Thursday.</param>
        /// <param name="friday">Friday.</param>
        /// <param name="saturday">Saturday.</param>
        /// <param name="sunday">Sunday.</param>
        /// <param name="timeFrom">TimeFrom.</param>
        /// <param name="timeTo">TimeTo.</param>
        public DayTimeRestriction(
            bool? monday = null,
            bool? tuesday = null,
            bool? wednesday = null,
            bool? thursday = null,
            bool? friday = null,
            bool? saturday = null,
            bool? sunday = null,
            string timeFrom = null,
            string timeTo = null)
        {
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
            this.TimeFrom = timeFrom;
            this.TimeTo = timeTo;
        }

        /// <summary>
        /// True if card could be used on a Monday, else false
        /// </summary>
        [JsonProperty("Monday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monday { get; set; }

        /// <summary>
        /// True if card could be used on a Tuesday, else false.
        /// </summary>
        [JsonProperty("Tuesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tuesday { get; set; }

        /// <summary>
        /// True if card could be used on a Wednesday, else false.
        /// </summary>
        [JsonProperty("Wednesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wednesday { get; set; }

        /// <summary>
        /// True if card could be used on a Thursday, else false
        /// </summary>
        [JsonProperty("Thursday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Thursday { get; set; }

        /// <summary>
        /// True if card could be used on a Friday, else false
        /// </summary>
        [JsonProperty("Friday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Friday { get; set; }

        /// <summary>
        /// True if card could be used on a Saturday, else false
        /// </summary>
        [JsonProperty("Saturday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saturday { get; set; }

        /// <summary>
        /// True if card could be used on a Sunday, else false.
        /// </summary>
        [JsonProperty("Sunday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sunday { get; set; }

        /// <summary>
        /// Card could be used from this time in a day.
        /// Format: HH:mm (24-hour format)
        /// Note:
        /// 1.    Clients to convert this to appropriate DateTime or TimeSpan type.
        /// “00:00” is the lowest time value and “23:59” is the highest time value.
        /// </summary>
        [JsonProperty("TimeFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Card could be used up to this time in a day.
        /// Format: HH:mm (24-hour format)
        /// Note:
        /// 1.    Clients to convert this to appropriate DateTime or TimeSpan type.
        /// “00:00” is the lowest time value and “23:59” is the highest time value.
        /// </summary>
        [JsonProperty("TimeTo", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeTo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DayTimeRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DayTimeRestriction other &&
                (this.Monday == null && other.Monday == null ||
                 this.Monday?.Equals(other.Monday) == true) &&
                (this.Tuesday == null && other.Tuesday == null ||
                 this.Tuesday?.Equals(other.Tuesday) == true) &&
                (this.Wednesday == null && other.Wednesday == null ||
                 this.Wednesday?.Equals(other.Wednesday) == true) &&
                (this.Thursday == null && other.Thursday == null ||
                 this.Thursday?.Equals(other.Thursday) == true) &&
                (this.Friday == null && other.Friday == null ||
                 this.Friday?.Equals(other.Friday) == true) &&
                (this.Saturday == null && other.Saturday == null ||
                 this.Saturday?.Equals(other.Saturday) == true) &&
                (this.Sunday == null && other.Sunday == null ||
                 this.Sunday?.Equals(other.Sunday) == true) &&
                (this.TimeFrom == null && other.TimeFrom == null ||
                 this.TimeFrom?.Equals(other.TimeFrom) == true) &&
                (this.TimeTo == null && other.TimeTo == null ||
                 this.TimeTo?.Equals(other.TimeTo) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Monday = {(this.Monday == null ? "null" : this.Monday.ToString())}");
            toStringOutput.Add($"this.Tuesday = {(this.Tuesday == null ? "null" : this.Tuesday.ToString())}");
            toStringOutput.Add($"this.Wednesday = {(this.Wednesday == null ? "null" : this.Wednesday.ToString())}");
            toStringOutput.Add($"this.Thursday = {(this.Thursday == null ? "null" : this.Thursday.ToString())}");
            toStringOutput.Add($"this.Friday = {(this.Friday == null ? "null" : this.Friday.ToString())}");
            toStringOutput.Add($"this.Saturday = {(this.Saturday == null ? "null" : this.Saturday.ToString())}");
            toStringOutput.Add($"this.Sunday = {(this.Sunday == null ? "null" : this.Sunday.ToString())}");
            toStringOutput.Add($"this.TimeFrom = {this.TimeFrom ?? "null"}");
            toStringOutput.Add($"this.TimeTo = {this.TimeTo ?? "null"}");
        }
    }
}
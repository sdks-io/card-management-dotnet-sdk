// <copyright file="DayTimeRestrictions.cs" company="APIMatic">
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
    /// DayTimeRestrictions.
    /// </summary>
    public class DayTimeRestrictions
    {
        private string timeFrom;
        private string timeTo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TimeFrom", false },
            { "TimeTo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DayTimeRestrictions"/> class.
        /// </summary>
        public DayTimeRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayTimeRestrictions"/> class.
        /// </summary>
        /// <param name="friday">Friday.</param>
        /// <param name="monday">Monday.</param>
        /// <param name="saturday">Saturday.</param>
        /// <param name="sunday">Sunday.</param>
        /// <param name="thursday">Thursday.</param>
        /// <param name="timeFrom">TimeFrom.</param>
        /// <param name="timeTo">TimeTo.</param>
        /// <param name="tuesday">Tuesday.</param>
        /// <param name="wednesday">Wednesday.</param>
        public DayTimeRestrictions(
            bool? friday = false,
            bool? monday = false,
            bool? saturday = false,
            bool? sunday = false,
            bool? thursday = false,
            string timeFrom = null,
            string timeTo = null,
            bool? tuesday = false,
            bool? wednesday = false)
        {
            this.Friday = friday;
            this.Monday = monday;
            this.Saturday = saturday;
            this.Sunday = sunday;
            this.Thursday = thursday;
            if (timeFrom != null)
            {
                this.TimeFrom = timeFrom;
            }

            if (timeTo != null)
            {
                this.TimeTo = timeTo;
            }

            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
        }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Friday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Friday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Friday { get; set; }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Monday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Monday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monday { get; set; }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Saturday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Saturday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saturday { get; set; }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Sunday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Sunday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sunday { get; set; }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Thursday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Thursday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Thursday { get; set; }

        /// <summary>
        /// Card could be used from this time in a day.
        /// Mandatory if TimeTo is passed, else optional.
        /// Format: HH:mm (24-hour format)
        /// Note:
        /// 2.	“00:00” is the lowest time value and “23:59” is the highest time value.
        /// To allow card to be used throughout the day pass null in TimeFrom and TimeTo.
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom
        {
            get
            {
                return this.timeFrom;
            }

            set
            {
                this.shouldSerialize["TimeFrom"] = true;
                this.timeFrom = value;
            }
        }

        /// <summary>
        /// Card could be used up to this time in a day.
        /// Mandatory if TimeFrom is passed, else optional.
        /// Format: HH:mm (24-hour format)
        /// Note:
        /// 2.	“00:00” is the lowest time value and “23:59” is the highest time value.
        /// To allow card to be used throughout the day pass null in TimeFrom and TimeTo.
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo
        {
            get
            {
                return this.timeTo;
            }

            set
            {
                this.shouldSerialize["TimeTo"] = true;
                this.timeTo = value;
            }
        }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Tuesday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Tuesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tuesday { get; set; }

        /// <summary>
        /// True/False.
        /// True if card could be used on a Wednesday, else false.
        /// Default value: false.
        /// </summary>
        [JsonProperty("Wednesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wednesday { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DayTimeRestrictions : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTimeFrom()
        {
            this.shouldSerialize["TimeFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTimeTo()
        {
            this.shouldSerialize["TimeTo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTimeFrom()
        {
            return this.shouldSerialize["TimeFrom"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTimeTo()
        {
            return this.shouldSerialize["TimeTo"];
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
            return obj is DayTimeRestrictions other &&                ((this.Friday == null && other.Friday == null) || (this.Friday?.Equals(other.Friday) == true)) &&
                ((this.Monday == null && other.Monday == null) || (this.Monday?.Equals(other.Monday) == true)) &&
                ((this.Saturday == null && other.Saturday == null) || (this.Saturday?.Equals(other.Saturday) == true)) &&
                ((this.Sunday == null && other.Sunday == null) || (this.Sunday?.Equals(other.Sunday) == true)) &&
                ((this.Thursday == null && other.Thursday == null) || (this.Thursday?.Equals(other.Thursday) == true)) &&
                ((this.TimeFrom == null && other.TimeFrom == null) || (this.TimeFrom?.Equals(other.TimeFrom) == true)) &&
                ((this.TimeTo == null && other.TimeTo == null) || (this.TimeTo?.Equals(other.TimeTo) == true)) &&
                ((this.Tuesday == null && other.Tuesday == null) || (this.Tuesday?.Equals(other.Tuesday) == true)) &&
                ((this.Wednesday == null && other.Wednesday == null) || (this.Wednesday?.Equals(other.Wednesday) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Friday = {(this.Friday == null ? "null" : this.Friday.ToString())}");
            toStringOutput.Add($"this.Monday = {(this.Monday == null ? "null" : this.Monday.ToString())}");
            toStringOutput.Add($"this.Saturday = {(this.Saturday == null ? "null" : this.Saturday.ToString())}");
            toStringOutput.Add($"this.Sunday = {(this.Sunday == null ? "null" : this.Sunday.ToString())}");
            toStringOutput.Add($"this.Thursday = {(this.Thursday == null ? "null" : this.Thursday.ToString())}");
            toStringOutput.Add($"this.TimeFrom = {(this.TimeFrom == null ? "null" : this.TimeFrom)}");
            toStringOutput.Add($"this.TimeTo = {(this.TimeTo == null ? "null" : this.TimeTo)}");
            toStringOutput.Add($"this.Tuesday = {(this.Tuesday == null ? "null" : this.Tuesday.ToString())}");
            toStringOutput.Add($"this.Wednesday = {(this.Wednesday == null ? "null" : this.Wednesday.ToString())}");
        }
    }
}
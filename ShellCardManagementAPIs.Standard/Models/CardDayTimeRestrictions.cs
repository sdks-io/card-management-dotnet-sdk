// <copyright file="CardDayTimeRestrictions.cs" company="APIMatic">
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
    /// CardDayTimeRestrictions.
    /// </summary>
    public class CardDayTimeRestrictions
    {
        private string level;
        private string timeFrom;
        private string timeTo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Level", false },
            { "TimeFrom", false },
            { "TimeTo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDayTimeRestrictions"/> class.
        /// </summary>
        public CardDayTimeRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDayTimeRestrictions"/> class.
        /// </summary>
        /// <param name="level">Level.</param>
        /// <param name="monday">Monday.</param>
        /// <param name="tuesday">Tuesday.</param>
        /// <param name="wednesday">Wednesday.</param>
        /// <param name="thursday">Thursday.</param>
        /// <param name="friday">Friday.</param>
        /// <param name="saturday">Saturday.</param>
        /// <param name="sunday">Sunday.</param>
        /// <param name="timeFrom">TimeFrom.</param>
        /// <param name="timeTo">TimeTo.</param>
        public CardDayTimeRestrictions(
            string level = null,
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

            if (level != null)
            {
                this.Level = level;
            }
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;

            if (timeFrom != null)
            {
                this.TimeFrom = timeFrom;
            }

            if (timeTo != null)
            {
                this.TimeTo = timeTo;
            }
        }

        /// <summary>
        /// Describes at which level the restriction is set at.
        /// Possible values:
        /// OU = Restriction set at ColCo card type
        /// Customer = Restriction set at customer card type
        /// </summary>
        [JsonProperty("Level")]
        public string Level
        {
            get
            {
                return this.level;
            }

            set
            {
                this.shouldSerialize["Level"] = true;
                this.level = value;
            }
        }

        /// <summary>
        /// Whether the transaction is allowed on Mondays or not.
        /// </summary>
        [JsonProperty("Monday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Tuesdays or not.
        /// </summary>
        [JsonProperty("Tuesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tuesday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Wednesdays or not.
        /// </summary>
        [JsonProperty("Wednesday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wednesday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Thursdays or not.
        /// </summary>
        [JsonProperty("Thursday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Thursday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Fridays or not.
        /// </summary>
        [JsonProperty("Friday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Friday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Saturdays or not.
        /// </summary>
        [JsonProperty("Saturday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saturday { get; set; }

        /// <summary>
        /// Whether the transaction is allowed on Sundays or not.
        /// </summary>
        [JsonProperty("Sunday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sunday { get; set; }

        /// <summary>
        /// The time in the day from when the transaction is allowed.
        /// Format: HH:mm: ss
        /// E.g., 21:00:00
        /// Note:
        /// 1) The client application has to convert the value to the required date-time data type.
        /// 2) The value will be 00:00:00 when no restriction set for this field.
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
        /// allowed.
        /// Format: HH:mm: ss
        /// E.g., 21:00:00
        /// Note:
        /// 1) The client application has to convert the value to the required date-time data type.
        /// 2) The value will be 00:00:00 when no restriction set for this field.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardDayTimeRestrictions : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLevel()
        {
            this.shouldSerialize["Level"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTimeFrom()
        {
            this.shouldSerialize["TimeFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTimeTo()
        {
            this.shouldSerialize["TimeTo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLevel()
        {
            return this.shouldSerialize["Level"];
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardDayTimeRestrictions other &&
                (this.Level == null && other.Level == null ||
                 this.Level?.Equals(other.Level) == true) &&
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
            toStringOutput.Add($"Level = {this.Level ?? "null"}");
            toStringOutput.Add($"Monday = {(this.Monday == null ? "null" : this.Monday.ToString())}");
            toStringOutput.Add($"Tuesday = {(this.Tuesday == null ? "null" : this.Tuesday.ToString())}");
            toStringOutput.Add($"Wednesday = {(this.Wednesday == null ? "null" : this.Wednesday.ToString())}");
            toStringOutput.Add($"Thursday = {(this.Thursday == null ? "null" : this.Thursday.ToString())}");
            toStringOutput.Add($"Friday = {(this.Friday == null ? "null" : this.Friday.ToString())}");
            toStringOutput.Add($"Saturday = {(this.Saturday == null ? "null" : this.Saturday.ToString())}");
            toStringOutput.Add($"Sunday = {(this.Sunday == null ? "null" : this.Sunday.ToString())}");
            toStringOutput.Add($"TimeFrom = {this.TimeFrom ?? "null"}");
            toStringOutput.Add($"TimeTo = {this.TimeTo ?? "null"}");
        }
    }
}
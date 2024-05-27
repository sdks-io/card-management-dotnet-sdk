// <copyright file="PINAdviceTypes.cs" company="APIMatic">
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
    /// PINAdviceTypes.
    /// </summary>
    public class PINAdviceTypes
    {
        private int? pINAdviceTypeID;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PINAdviceTypeID", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PINAdviceTypes"/> class.
        /// </summary>
        public PINAdviceTypes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PINAdviceTypes"/> class.
        /// </summary>
        /// <param name="pINAdviceTypeID">PINAdviceTypeID.</param>
        /// <param name="isCardOrderOption">IsCardOrderOption.</param>
        /// <param name="isPINReminderOption">IsPINReminderOption.</param>
        public PINAdviceTypes(
            int? pINAdviceTypeID = null,
            bool? isCardOrderOption = null,
            bool? isPINReminderOption = null)
        {
            if (pINAdviceTypeID != null)
            {
                this.PINAdviceTypeID = pINAdviceTypeID;
            }

            this.IsCardOrderOption = isCardOrderOption;
            this.IsPINReminderOption = isPINReminderOption;
        }

        /// <summary>
        /// Id of of PIN advice type.
        /// Possible Values:
        /// 1.	Paper
        /// 2.	Email
        /// 3.	SMS
        /// 4.	None
        /// </summary>
        [JsonProperty("PINAdviceTypeID")]
        public int? PINAdviceTypeID
        {
            get
            {
                return this.pINAdviceTypeID;
            }

            set
            {
                this.shouldSerialize["PINAdviceTypeID"] = true;
                this.pINAdviceTypeID = value;
            }
        }

        /// <summary>
        /// Whether the PIN advice type is available for card ordering
        /// </summary>
        [JsonProperty("IsCardOrderOption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCardOrderOption { get; set; }

        /// <summary>
        /// Whether the PIN advice type is available for PIN Reminder
        /// </summary>
        [JsonProperty("IsPINReminderOption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPINReminderOption { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PINAdviceTypes : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPINAdviceTypeID()
        {
            this.shouldSerialize["PINAdviceTypeID"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINAdviceTypeID()
        {
            return this.shouldSerialize["PINAdviceTypeID"];
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
            return obj is PINAdviceTypes other &&                ((this.PINAdviceTypeID == null && other.PINAdviceTypeID == null) || (this.PINAdviceTypeID?.Equals(other.PINAdviceTypeID) == true)) &&
                ((this.IsCardOrderOption == null && other.IsCardOrderOption == null) || (this.IsCardOrderOption?.Equals(other.IsCardOrderOption) == true)) &&
                ((this.IsPINReminderOption == null && other.IsPINReminderOption == null) || (this.IsPINReminderOption?.Equals(other.IsPINReminderOption) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PINAdviceTypeID = {(this.PINAdviceTypeID == null ? "null" : this.PINAdviceTypeID.ToString())}");
            toStringOutput.Add($"this.IsCardOrderOption = {(this.IsCardOrderOption == null ? "null" : this.IsCardOrderOption.ToString())}");
            toStringOutput.Add($"this.IsPINReminderOption = {(this.IsPINReminderOption == null ? "null" : this.IsPINReminderOption.ToString())}");
        }
    }
}
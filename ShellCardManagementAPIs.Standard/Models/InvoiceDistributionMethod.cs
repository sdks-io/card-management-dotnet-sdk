// <copyright file="InvoiceDistributionMethod.cs" company="APIMatic">
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
    /// InvoiceDistributionMethod.
    /// </summary>
    public class InvoiceDistributionMethod
    {
        private string frequencyType;
        private string distributionMethod;
        private string outputType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FrequencyType", false },
            { "DistributionMethod", false },
            { "OutputType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDistributionMethod"/> class.
        /// </summary>
        public InvoiceDistributionMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDistributionMethod"/> class.
        /// </summary>
        /// <param name="isPrimary">IsPrimary.</param>
        /// <param name="frequencyType">FrequencyType.</param>
        /// <param name="distributionMethod">DistributionMethod.</param>
        /// <param name="outputType">OutputType.</param>
        public InvoiceDistributionMethod(
            bool? isPrimary = true,
            string frequencyType = null,
            string distributionMethod = null,
            string outputType = null)
        {
            this.IsPrimary = isPrimary;

            if (frequencyType != null)
            {
                this.FrequencyType = frequencyType;
            }

            if (distributionMethod != null)
            {
                this.DistributionMethod = distributionMethod;
            }

            if (outputType != null)
            {
                this.OutputType = outputType;
            }
        }

        /// <summary>
        /// If True then this distribution method is the default distribution method.
        /// </summary>
        [JsonProperty("IsPrimary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Frequency type unit Id & description
        /// E.g.:
        /// 1- Daily
        /// 2-Weekly
        /// 3-Monthly
        /// 4-Invoicing
        /// 6-Calendar quarter
        /// ]]>
        /// </summary>
        [JsonProperty("FrequencyType")]
        public string FrequencyType
        {
            get
            {
                return this.frequencyType;
            }

            set
            {
                this.shouldSerialize["FrequencyType"] = true;
                this.frequencyType = value;
            }
        }

        /// <summary>
        /// Invoice Distribution Method (Id-Description)
        /// E.g.:
        /// 1-e-mail
        /// 2-Fax
        /// 3-Courier to Customer
        /// 4-Courier to Client
        /// 5-Print
        /// 6-FTP
        /// 7-SMS
        /// </summary>
        [JsonProperty("DistributionMethod")]
        public string DistributionMethod
        {
            get
            {
                return this.distributionMethod;
            }

            set
            {
                this.shouldSerialize["DistributionMethod"] = true;
                this.distributionMethod = value;
            }
        }

        /// <summary>
        /// Invoice output type (Id - Description)
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType
        {
            get
            {
                return this.outputType;
            }

            set
            {
                this.shouldSerialize["OutputType"] = true;
                this.outputType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceDistributionMethod : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFrequencyType()
        {
            this.shouldSerialize["FrequencyType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDistributionMethod()
        {
            this.shouldSerialize["DistributionMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOutputType()
        {
            this.shouldSerialize["OutputType"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrequencyType()
        {
            return this.shouldSerialize["FrequencyType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDistributionMethod()
        {
            return this.shouldSerialize["DistributionMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOutputType()
        {
            return this.shouldSerialize["OutputType"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceDistributionMethod other &&
                (this.IsPrimary == null && other.IsPrimary == null ||
                 this.IsPrimary?.Equals(other.IsPrimary) == true) &&
                (this.FrequencyType == null && other.FrequencyType == null ||
                 this.FrequencyType?.Equals(other.FrequencyType) == true) &&
                (this.DistributionMethod == null && other.DistributionMethod == null ||
                 this.DistributionMethod?.Equals(other.DistributionMethod) == true) &&
                (this.OutputType == null && other.OutputType == null ||
                 this.OutputType?.Equals(other.OutputType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsPrimary = {(this.IsPrimary == null ? "null" : this.IsPrimary.ToString())}");
            toStringOutput.Add($"this.FrequencyType = {this.FrequencyType ?? "null"}");
            toStringOutput.Add($"this.DistributionMethod = {this.DistributionMethod ?? "null"}");
            toStringOutput.Add($"this.OutputType = {this.OutputType ?? "null"}");
        }
    }
}
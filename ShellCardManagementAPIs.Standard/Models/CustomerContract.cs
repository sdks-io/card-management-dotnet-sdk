// <copyright file="CustomerContract.cs" company="APIMatic">
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
    /// CustomerContract.
    /// </summary>
    public class CustomerContract
    {
        private string partnerId;
        private string partnerName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PartnerId", false },
            { "PartnerName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerContract"/> class.
        /// </summary>
        public CustomerContract()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerContract"/> class.
        /// </summary>
        /// <param name="partnerId">PartnerId.</param>
        /// <param name="partnerName">PartnerName.</param>
        public CustomerContract(
            string partnerId = null,
            string partnerName = null)
        {

            if (partnerId != null)
            {
                this.PartnerId = partnerId;
            }

            if (partnerName != null)
            {
                this.PartnerName = partnerName;
            }
        }

        /// <summary>
        /// Partner Id in e-TM system
        /// </summary>
        [JsonProperty("PartnerId")]
        public string PartnerId
        {
            get
            {
                return this.partnerId;
            }

            set
            {
                this.shouldSerialize["PartnerId"] = true;
                this.partnerId = value;
            }
        }

        /// <summary>
        /// Partner Name in e-TM system
        /// </summary>
        [JsonProperty("PartnerName")]
        public string PartnerName
        {
            get
            {
                return this.partnerName;
            }

            set
            {
                this.shouldSerialize["PartnerName"] = true;
                this.partnerName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomerContract : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPartnerId()
        {
            this.shouldSerialize["PartnerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPartnerName()
        {
            this.shouldSerialize["PartnerName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePartnerId()
        {
            return this.shouldSerialize["PartnerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePartnerName()
        {
            return this.shouldSerialize["PartnerName"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomerContract other &&
                (this.PartnerId == null && other.PartnerId == null ||
                 this.PartnerId?.Equals(other.PartnerId) == true) &&
                (this.PartnerName == null && other.PartnerName == null ||
                 this.PartnerName?.Equals(other.PartnerName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PartnerId = {this.PartnerId ?? "null"}");
            toStringOutput.Add($"this.PartnerName = {this.PartnerName ?? "null"}");
        }
    }
}
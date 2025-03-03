// <copyright file="CreateCardResponse.cs" company="APIMatic">
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
    /// CreateCardResponse.
    /// </summary>
    public class CreateCardResponse
    {
        private string driverAndVRN;
        private int? orderCardReference;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DriverAndVRN", false },
            { "OrderCardReference", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardResponse"/> class.
        /// </summary>
        public CreateCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardResponse"/> class.
        /// </summary>
        /// <param name="driverAndVRN">DriverAndVRN.</param>
        /// <param name="orderCardReference">OrderCardReference.</param>
        public CreateCardResponse(
            string driverAndVRN = null,
            int? orderCardReference = null)
        {

            if (driverAndVRN != null)
            {
                this.DriverAndVRN = driverAndVRN;
            }

            if (orderCardReference != null)
            {
                this.OrderCardReference = orderCardReference;
            }
        }

        /// <summary>
        /// Driver and VRN of the card. ;( semicolon) is used as delimiter
        /// </summary>
        [JsonProperty("DriverAndVRN")]
        public string DriverAndVRN
        {
            get
            {
                return this.driverAndVRN;
            }

            set
            {
                this.shouldSerialize["DriverAndVRN"] = true;
                this.driverAndVRN = value;
            }
        }

        /// <summary>
        /// Reference number for each individual card in the order
        /// </summary>
        [JsonProperty("OrderCardReference")]
        public int? OrderCardReference
        {
            get
            {
                return this.orderCardReference;
            }

            set
            {
                this.shouldSerialize["OrderCardReference"] = true;
                this.orderCardReference = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCardResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDriverAndVRN()
        {
            this.shouldSerialize["DriverAndVRN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOrderCardReference()
        {
            this.shouldSerialize["OrderCardReference"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDriverAndVRN()
        {
            return this.shouldSerialize["DriverAndVRN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrderCardReference()
        {
            return this.shouldSerialize["OrderCardReference"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCardResponse other &&
                (this.DriverAndVRN == null && other.DriverAndVRN == null ||
                 this.DriverAndVRN?.Equals(other.DriverAndVRN) == true) &&
                (this.OrderCardReference == null && other.OrderCardReference == null ||
                 this.OrderCardReference?.Equals(other.OrderCardReference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DriverAndVRN = {this.DriverAndVRN ?? "null"}");
            toStringOutput.Add($"OrderCardReference = {(this.OrderCardReference == null ? "null" : this.OrderCardReference.ToString())}");
        }
    }
}
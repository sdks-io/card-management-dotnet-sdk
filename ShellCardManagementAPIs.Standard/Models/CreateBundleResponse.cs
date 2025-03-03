// <copyright file="CreateBundleResponse.cs" company="APIMatic">
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
    /// CreateBundleResponse.
    /// </summary>
    public class CreateBundleResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponse"/> class.
        /// </summary>
        public CreateBundleResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBundleResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="bundleCreationStatus">BundleCreationStatus.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="dayTimeRestrictionStatus">DayTimeRestrictionStatus.</param>
        /// <param name="dayTimeRestrictionProfileId">DayTimeRestrictionProfileId.</param>
        /// <param name="locationRestrictionStatus">LocationRestrictionStatus.</param>
        /// <param name="locationRestrictionProfileId">LocationRestrictionProfileId.</param>
        /// <param name="usageRestrictionStatus">UsageRestrictionStatus.</param>
        /// <param name="productRestrictionStatus">ProductRestrictionStatus.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="error">Error.</param>
        public CreateBundleResponse(
            string requestId = null,
            Models.ErrorStatus bundleCreationStatus = null,
            string bundleId = null,
            Models.ErrorStatus dayTimeRestrictionStatus = null,
            string dayTimeRestrictionProfileId = null,
            Models.ErrorStatus locationRestrictionStatus = null,
            string locationRestrictionProfileId = null,
            Models.ErrorStatus usageRestrictionStatus = null,
            Models.ErrorStatus productRestrictionStatus = null,
            Models.BundleCardRestrictionStatus cards = null,
            Models.ErrorStatus error = null)
        {

            if (requestId != null)
            {
                this.RequestId = requestId;
            }
            this.BundleCreationStatus = bundleCreationStatus;
            this.BundleId = bundleId;
            this.DayTimeRestrictionStatus = dayTimeRestrictionStatus;
            this.DayTimeRestrictionProfileId = dayTimeRestrictionProfileId;
            this.LocationRestrictionStatus = locationRestrictionStatus;
            this.LocationRestrictionProfileId = locationRestrictionProfileId;
            this.UsageRestrictionStatus = usageRestrictionStatus;
            this.ProductRestrictionStatus = productRestrictionStatus;
            this.Cards = cards;
            this.Error = error;
        }

        /// <summary>
        /// Request Id of the API call
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// Gets or sets BundleCreationStatus.
        /// </summary>
        [JsonProperty("BundleCreationStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus BundleCreationStatus { get; set; }

        /// <summary>
        /// Identifier of the newly created bundle
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// Gets or sets DayTimeRestrictionStatus.
        /// </summary>
        [JsonProperty("DayTimeRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus DayTimeRestrictionStatus { get; set; }

        /// <summary>
        /// Identifier of the day/time restriction profile created
        /// </summary>
        [JsonProperty("DayTimeRestrictionProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string DayTimeRestrictionProfileId { get; set; }

        /// <summary>
        /// Gets or sets LocationRestrictionStatus.
        /// </summary>
        [JsonProperty("LocationRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus LocationRestrictionStatus { get; set; }

        /// <summary>
        /// Identifier of the location restriction profile created
        /// </summary>
        [JsonProperty("LocationRestrictionProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationRestrictionProfileId { get; set; }

        /// <summary>
        /// Gets or sets UsageRestrictionStatus.
        /// </summary>
        [JsonProperty("UsageRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus UsageRestrictionStatus { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictionStatus.
        /// </summary>
        [JsonProperty("ProductRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus ProductRestrictionStatus { get; set; }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BundleCardRestrictionStatus Cards { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateBundleResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateBundleResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true) &&
                (this.BundleCreationStatus == null && other.BundleCreationStatus == null ||
                 this.BundleCreationStatus?.Equals(other.BundleCreationStatus) == true) &&
                (this.BundleId == null && other.BundleId == null ||
                 this.BundleId?.Equals(other.BundleId) == true) &&
                (this.DayTimeRestrictionStatus == null && other.DayTimeRestrictionStatus == null ||
                 this.DayTimeRestrictionStatus?.Equals(other.DayTimeRestrictionStatus) == true) &&
                (this.DayTimeRestrictionProfileId == null && other.DayTimeRestrictionProfileId == null ||
                 this.DayTimeRestrictionProfileId?.Equals(other.DayTimeRestrictionProfileId) == true) &&
                (this.LocationRestrictionStatus == null && other.LocationRestrictionStatus == null ||
                 this.LocationRestrictionStatus?.Equals(other.LocationRestrictionStatus) == true) &&
                (this.LocationRestrictionProfileId == null && other.LocationRestrictionProfileId == null ||
                 this.LocationRestrictionProfileId?.Equals(other.LocationRestrictionProfileId) == true) &&
                (this.UsageRestrictionStatus == null && other.UsageRestrictionStatus == null ||
                 this.UsageRestrictionStatus?.Equals(other.UsageRestrictionStatus) == true) &&
                (this.ProductRestrictionStatus == null && other.ProductRestrictionStatus == null ||
                 this.ProductRestrictionStatus?.Equals(other.ProductRestrictionStatus) == true) &&
                (this.Cards == null && other.Cards == null ||
                 this.Cards?.Equals(other.Cards) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
            toStringOutput.Add($"BundleCreationStatus = {(this.BundleCreationStatus == null ? "null" : this.BundleCreationStatus.ToString())}");
            toStringOutput.Add($"BundleId = {this.BundleId ?? "null"}");
            toStringOutput.Add($"DayTimeRestrictionStatus = {(this.DayTimeRestrictionStatus == null ? "null" : this.DayTimeRestrictionStatus.ToString())}");
            toStringOutput.Add($"DayTimeRestrictionProfileId = {this.DayTimeRestrictionProfileId ?? "null"}");
            toStringOutput.Add($"LocationRestrictionStatus = {(this.LocationRestrictionStatus == null ? "null" : this.LocationRestrictionStatus.ToString())}");
            toStringOutput.Add($"LocationRestrictionProfileId = {this.LocationRestrictionProfileId ?? "null"}");
            toStringOutput.Add($"UsageRestrictionStatus = {(this.UsageRestrictionStatus == null ? "null" : this.UsageRestrictionStatus.ToString())}");
            toStringOutput.Add($"ProductRestrictionStatus = {(this.ProductRestrictionStatus == null ? "null" : this.ProductRestrictionStatus.ToString())}");
            toStringOutput.Add($"Cards = {(this.Cards == null ? "null" : this.Cards.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
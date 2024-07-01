// <copyright file="UpdateBundleResponse.cs" company="APIMatic">
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
    /// UpdateBundleResponse.
    /// </summary>
    public class UpdateBundleResponse
    {
        private string requestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBundleResponse"/> class.
        /// </summary>
        public UpdateBundleResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBundleResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="requestActionStatus">RequestActionStatus.</param>
        /// <param name="dayTimeRestrictionStatus">DayTimeRestrictionStatus.</param>
        /// <param name="locationRestrictionStatus">LocationRestrictionStatus.</param>
        /// <param name="productRestrictionStatus">ProductRestrictionStatus.</param>
        /// <param name="usageRestrictionStatus">UsageRestrictionStatus.</param>
        /// <param name="error">Error.</param>
        public UpdateBundleResponse(
            string requestId = null,
            Models.ErrorStatus requestActionStatus = null,
            Models.ErrorStatus dayTimeRestrictionStatus = null,
            Models.ErrorStatus locationRestrictionStatus = null,
            Models.ErrorStatus productRestrictionStatus = null,
            Models.ErrorStatus usageRestrictionStatus = null,
            Models.ErrorStatus error = null)
        {
            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            this.RequestActionStatus = requestActionStatus;
            this.DayTimeRestrictionStatus = dayTimeRestrictionStatus;
            this.LocationRestrictionStatus = locationRestrictionStatus;
            this.ProductRestrictionStatus = productRestrictionStatus;
            this.UsageRestrictionStatus = usageRestrictionStatus;
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
        /// Gets or sets RequestActionStatus.
        /// </summary>
        [JsonProperty("RequestActionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus RequestActionStatus { get; set; }

        /// <summary>
        /// Gets or sets DayTimeRestrictionStatus.
        /// </summary>
        [JsonProperty("DayTimeRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus DayTimeRestrictionStatus { get; set; }

        /// <summary>
        /// Gets or sets LocationRestrictionStatus.
        /// </summary>
        [JsonProperty("LocationRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus LocationRestrictionStatus { get; set; }

        /// <summary>
        /// Gets or sets ProductRestrictionStatus.
        /// </summary>
        [JsonProperty("ProductRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus ProductRestrictionStatus { get; set; }

        /// <summary>
        /// Gets or sets UsageRestrictionStatus.
        /// </summary>
        [JsonProperty("UsageRestrictionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus UsageRestrictionStatus { get; set; }

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

            return $"UpdateBundleResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is UpdateBundleResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.RequestActionStatus == null && other.RequestActionStatus == null) || (this.RequestActionStatus?.Equals(other.RequestActionStatus) == true)) &&
                ((this.DayTimeRestrictionStatus == null && other.DayTimeRestrictionStatus == null) || (this.DayTimeRestrictionStatus?.Equals(other.DayTimeRestrictionStatus) == true)) &&
                ((this.LocationRestrictionStatus == null && other.LocationRestrictionStatus == null) || (this.LocationRestrictionStatus?.Equals(other.LocationRestrictionStatus) == true)) &&
                ((this.ProductRestrictionStatus == null && other.ProductRestrictionStatus == null) || (this.ProductRestrictionStatus?.Equals(other.ProductRestrictionStatus) == true)) &&
                ((this.UsageRestrictionStatus == null && other.UsageRestrictionStatus == null) || (this.UsageRestrictionStatus?.Equals(other.UsageRestrictionStatus) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.RequestActionStatus = {(this.RequestActionStatus == null ? "null" : this.RequestActionStatus.ToString())}");
            toStringOutput.Add($"this.DayTimeRestrictionStatus = {(this.DayTimeRestrictionStatus == null ? "null" : this.DayTimeRestrictionStatus.ToString())}");
            toStringOutput.Add($"this.LocationRestrictionStatus = {(this.LocationRestrictionStatus == null ? "null" : this.LocationRestrictionStatus.ToString())}");
            toStringOutput.Add($"this.ProductRestrictionStatus = {(this.ProductRestrictionStatus == null ? "null" : this.ProductRestrictionStatus.ToString())}");
            toStringOutput.Add($"this.UsageRestrictionStatus = {(this.UsageRestrictionStatus == null ? "null" : this.UsageRestrictionStatus.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}
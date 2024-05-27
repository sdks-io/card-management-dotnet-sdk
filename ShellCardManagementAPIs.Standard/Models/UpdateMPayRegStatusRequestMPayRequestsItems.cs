// <copyright file="UpdateMPayRegStatusRequestMPayRequestsItems.cs" company="APIMatic">
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
    /// UpdateMPayRegStatusRequestMPayRequestsItems.
    /// </summary>
    public class UpdateMPayRegStatusRequestMPayRequestsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMPayRegStatusRequestMPayRequestsItems"/> class.
        /// </summary>
        public UpdateMPayRegStatusRequestMPayRequestsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMPayRegStatusRequestMPayRequestsItems"/> class.
        /// </summary>
        /// <param name="globalRequestID">GlobalRequestID.</param>
        /// <param name="status">Status.</param>
        /// <param name="approverUserID">ApproverUserID.</param>
        /// <param name="approverUserDisplayName">ApproverUserDisplayName.</param>
        /// <param name="reason">Reason.</param>
        public UpdateMPayRegStatusRequestMPayRequestsItems(
            string globalRequestID = null,
            string status = null,
            string approverUserID = null,
            string approverUserDisplayName = null,
            string reason = null)
        {
            this.GlobalRequestID = globalRequestID;
            this.Status = status;
            this.ApproverUserID = approverUserID;
            this.ApproverUserDisplayName = approverUserDisplayName;
            this.Reason = reason;
        }

        /// <summary>
        /// List of MPay Request to be updated for Fleet Manager approval status.
        /// Mandatory
        /// Maximum number of requests that can be submitted are 50
        /// </summary>
        [JsonProperty("GlobalRequestID", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalRequestID { get; set; }

        /// <summary>
        /// Status of mobile payment registration request
        /// Mandatory.
        /// Allowed values –
        /// •	Approved
        /// •   Rejected
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Approver’s User ID
        /// ApproverUserID is mandatory when Status is Approved else optional
        /// </summary>
        [JsonProperty("ApproverUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string ApproverUserID { get; set; }

        /// <summary>
        /// Approver’s display name
        /// Mandatory when Status is Approved else optional.
        /// </summary>
        [JsonProperty("ApproverUserDisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string ApproverUserDisplayName { get; set; }

        /// <summary>
        /// Reason for Fleet Manager approval/rejection.
        /// Optional
        /// </summary>
        [JsonProperty("Reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateMPayRegStatusRequestMPayRequestsItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateMPayRegStatusRequestMPayRequestsItems other &&                ((this.GlobalRequestID == null && other.GlobalRequestID == null) || (this.GlobalRequestID?.Equals(other.GlobalRequestID) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ApproverUserID == null && other.ApproverUserID == null) || (this.ApproverUserID?.Equals(other.ApproverUserID) == true)) &&
                ((this.ApproverUserDisplayName == null && other.ApproverUserDisplayName == null) || (this.ApproverUserDisplayName?.Equals(other.ApproverUserDisplayName) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GlobalRequestID = {(this.GlobalRequestID == null ? "null" : this.GlobalRequestID)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.ApproverUserID = {(this.ApproverUserID == null ? "null" : this.ApproverUserID)}");
            toStringOutput.Add($"this.ApproverUserDisplayName = {(this.ApproverUserDisplayName == null ? "null" : this.ApproverUserDisplayName)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
        }
    }
}
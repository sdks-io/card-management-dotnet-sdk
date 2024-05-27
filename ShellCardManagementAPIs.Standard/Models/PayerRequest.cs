// <copyright file="PayerRequest.cs" company="APIMatic">
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
    /// PayerRequest.
    /// </summary>
    public class PayerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayerRequest"/> class.
        /// </summary>
        public PayerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerRequest"/> class.
        /// </summary>
        /// <param name="payers">Payers.</param>
        /// <param name="returnBasicDetailsOnly">ReturnBasicDetailsOnly.</param>
        /// <param name="includeAddresses">IncludeAddresses.</param>
        /// <param name="includeBonusParameters">IncludeBonusParameters.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="pageSize">PageSize.</param>
        public PayerRequest(
            List<Models.Payers> payers = null,
            bool? returnBasicDetailsOnly = false,
            bool? includeAddresses = false,
            bool? includeBonusParameters = false,
            int? currentPage = null,
            int? pageSize = null)
        {
            this.Payers = payers;
            this.ReturnBasicDetailsOnly = returnBasicDetailsOnly;
            this.IncludeAddresses = includeAddresses;
            this.IncludeBonusParameters = includeBonusParameters;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// List of Payer entity.
        /// Optional.
        /// Note:
        /// •	Max number of payers allowed in the input is 10, if it exceeds in the input it will throw an error.
        /// •	This value is configurable. Initial configuration will be 1000 and will change to 10 once SFH changes are integrated.
        /// </summary>
        [JsonProperty("Payers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Payers> Payers { get; set; }

        /// <summary>
        /// Returns only the high-level basic details of payers. Set this field to ‘true’ when only the basic details are required to get the result quicker.
        /// </summary>
        [JsonProperty("ReturnBasicDetailsOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnBasicDetailsOnly { get; set; }

        /// <summary>
        /// Include address related fields on the response. Set this field to ‘False’ when Address fields are not required to get the result quicker.
        /// </summary>
        [JsonProperty("IncludeAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAddresses { get; set; }

        /// <summary>
        /// Include the Finance Currency, used for Finance Widget, in the response
        /// </summary>
        [JsonProperty("IncludeBonusParameters", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeBonusParameters { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Page Size – Number of records to show on a page
        /// Default value 50
        /// Return 250 rows only in the response if -1 is supplied as page size.
        /// Note:
        /// •	Max page size is 250, if the user provided value is more than 250 then it will throw error.
        /// •	This value is configurable.
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayerRequest other &&                ((this.Payers == null && other.Payers == null) || (this.Payers?.Equals(other.Payers) == true)) &&
                ((this.ReturnBasicDetailsOnly == null && other.ReturnBasicDetailsOnly == null) || (this.ReturnBasicDetailsOnly?.Equals(other.ReturnBasicDetailsOnly) == true)) &&
                ((this.IncludeAddresses == null && other.IncludeAddresses == null) || (this.IncludeAddresses?.Equals(other.IncludeAddresses) == true)) &&
                ((this.IncludeBonusParameters == null && other.IncludeBonusParameters == null) || (this.IncludeBonusParameters?.Equals(other.IncludeBonusParameters) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payers = {(this.Payers == null ? "null" : $"[{string.Join(", ", this.Payers)} ]")}");
            toStringOutput.Add($"this.ReturnBasicDetailsOnly = {(this.ReturnBasicDetailsOnly == null ? "null" : this.ReturnBasicDetailsOnly.ToString())}");
            toStringOutput.Add($"this.IncludeAddresses = {(this.IncludeAddresses == null ? "null" : this.IncludeAddresses.ToString())}");
            toStringOutput.Add($"this.IncludeBonusParameters = {(this.IncludeBonusParameters == null ? "null" : this.IncludeBonusParameters.ToString())}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}
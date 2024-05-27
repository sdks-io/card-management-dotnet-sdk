// <copyright file="AccountRequest.cs" company="APIMatic">
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
    /// AccountRequest.
    /// </summary>
    public class AccountRequest
    {
        private string status;
        private int? payerId;
        private string payerNumber;
        private int? pageSize;
        private string requestId;
        private int? colCoCode;
        private string colCoCountryCode;
        private int? currentPage;
        private bool? invoicePointsOnly;
        private int? colCoId;
        private string accountName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Status", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PageSize", false },
            { "RequestId", false },
            { "ColCoCode", false },
            { "ColCoCountryCode", false },
            { "CurrentPage", false },
            { "InvoicePointsOnly", true },
            { "ColCoId", false },
            { "AccountName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRequest"/> class.
        /// </summary>
        public AccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRequest"/> class.
        /// </summary>
        /// <param name="status">Status.</param>
        /// <param name="includeCardSummary">IncludeCardSummary.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="invoicePointsOnly">InvoicePointsOnly.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="returnTollsCustomerId">ReturnTollsCustomerId.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="statusList">StatusList.</param>
        public AccountRequest(
            string status = null,
            bool? includeCardSummary = true,
            int? payerId = null,
            string payerNumber = null,
            int? pageSize = null,
            string requestId = null,
            int? colCoCode = null,
            string colCoCountryCode = null,
            int? currentPage = null,
            bool? invoicePointsOnly = false,
            int? colCoId = null,
            bool? returnTollsCustomerId = null,
            List<Models.Accounts> accounts = null,
            string accountName = null,
            List<string> statusList = null)
        {
            if (status != null)
            {
                this.Status = status;
            }

            this.IncludeCardSummary = includeCardSummary;
            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (pageSize != null)
            {
                this.PageSize = pageSize;
            }

            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (currentPage != null)
            {
                this.CurrentPage = currentPage;
            }

            this.InvoicePointsOnly = invoicePointsOnly;
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            this.ReturnTollsCustomerId = returnTollsCustomerId;
            this.Accounts = accounts;
            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            this.StatusList = statusList;
        }

        /// <summary>
        /// Account Status.
        /// Optional if StatusList is passed, else mandatory.
        /// Ignored if StatusList is passed.
        /// Allowed values:
        /// •	ALL
        /// •	ACTIVE
        /// •	BLOCKED
        /// •	CANCELLED
        /// •	CREDITLOCK
        /// •	DELINQUENCYLOCK
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Include card summary details in the response.
        /// When passed as false, the card summary related parameters on response will be set to null.
        /// Optional – default value: true.
        /// </summary>
        [JsonProperty("IncludeCardSummary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeCardSummary { get; set; }

        /// <summary>
        /// Payer id of the customer.
        /// Optional if PayerNumber is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// PayerNumber of the customer.
        /// Optional if PayerId is passed, else Mandatory.
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Page Size – Number of records to show on a page.
        /// Optional
        /// Default value 50
        /// </summary>
        [JsonProperty("PageSize")]
        public int? PageSize
        {
            get
            {
                return this.pageSize;
            }

            set
            {
                this.shouldSerialize["PageSize"] = true;
                this.pageSize = value;
            }
        }

        /// <summary>
        /// API Request Id
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
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// ColCoCode or ColCoCountryCode  is Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// The 2-character ISO Code for the customer and card owning country.
        /// ColCoCode or ColCoCountryCode  is Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// </summary>
        [JsonProperty("ColCoCountryCode")]
        public string ColCoCountryCode
        {
            get
            {
                return this.colCoCountryCode;
            }

            set
            {
                this.shouldSerialize["ColCoCountryCode"] = true;
                this.colCoCountryCode = value;
            }
        }

        /// <summary>
        /// Page Number (as shown to the users)
        /// Optional
        /// Default value 1
        /// </summary>
        [JsonProperty("CurrentPage")]
        public int? CurrentPage
        {
            get
            {
                return this.currentPage;
            }

            set
            {
                this.shouldSerialize["CurrentPage"] = true;
                this.currentPage = value;
            }
        }

        /// <summary>
        /// Optional – default value: false.
        /// When passed as true, the API will return accounts that are configured as Invoice Point only.
        /// </summary>
        [JsonProperty("InvoicePointsOnly")]
        public bool? InvoicePointsOnly
        {
            get
            {
                return this.invoicePointsOnly;
            }

            set
            {
                this.shouldSerialize["InvoicePointsOnly"] = true;
                this.invoicePointsOnly = value;
            }
        }

        /// <summary>
        /// Collecting Company Id (in GFN) of the selected payer.
        /// Optional if ColCoCode or ColCoCountryCode  is passed else Mandatory.
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// Return e-Toll Customer details When True.
        /// </summary>
        [JsonProperty("ReturnTollsCustomerId", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTollsCustomerId { get; set; }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Accounts> Accounts { get; set; }

        /// <summary>
        /// Account Name of the customer.
        /// Optional.
        /// Minimum of 4 characters should be provided else not considered.
        /// Accounts those have the entered value at any part of the Name will be returned.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
            }
        }

        /// <summary>
        /// Account Statuses.
        /// Optional
        /// Multiple statuses are allowed to be included in the search criteria.
        /// Allowed values:
        /// •	ACTIVE
        /// •	BLOCKED
        /// •	CANCELLED
        /// •	CREDITLOCK
        /// •	DELINQUENCYLOCK
        /// </summary>
        [JsonProperty("StatusList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatusList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPageSize()
        {
            this.shouldSerialize["PageSize"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentPage()
        {
            this.shouldSerialize["CurrentPage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoicePointsOnly()
        {
            this.shouldSerialize["InvoicePointsOnly"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePageSize()
        {
            return this.shouldSerialize["PageSize"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentPage()
        {
            return this.shouldSerialize["CurrentPage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoicePointsOnly()
        {
            return this.shouldSerialize["InvoicePointsOnly"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
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
            return obj is AccountRequest other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.IncludeCardSummary == null && other.IncludeCardSummary == null) || (this.IncludeCardSummary?.Equals(other.IncludeCardSummary) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.InvoicePointsOnly == null && other.InvoicePointsOnly == null) || (this.InvoicePointsOnly?.Equals(other.InvoicePointsOnly) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ReturnTollsCustomerId == null && other.ReturnTollsCustomerId == null) || (this.ReturnTollsCustomerId?.Equals(other.ReturnTollsCustomerId) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.StatusList == null && other.StatusList == null) || (this.StatusList?.Equals(other.StatusList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.IncludeCardSummary = {(this.IncludeCardSummary == null ? "null" : this.IncludeCardSummary.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.InvoicePointsOnly = {(this.InvoicePointsOnly == null ? "null" : this.InvoicePointsOnly.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ReturnTollsCustomerId = {(this.ReturnTollsCustomerId == null ? "null" : this.ReturnTollsCustomerId.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.StatusList = {(this.StatusList == null ? "null" : $"[{string.Join(", ", this.StatusList)} ]")}");
        }
    }
}
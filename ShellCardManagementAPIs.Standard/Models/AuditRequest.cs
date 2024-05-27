// <copyright file="AuditRequest.cs" company="APIMatic">
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
    /// AuditRequest.
    /// </summary>
    public class AuditRequest
    {
        private string payerNumber;
        private int? payerId;
        private string accountNumber;
        private int? colCoCode;
        private int? colCoId;
        private string sortOrder;
        private string searchText;
        private int? currentPage;
        private string fromDate;
        private string toDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PayerNumber", false },
            { "PayerId", false },
            { "AccountNumber", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "SortOrder", false },
            { "SearchText", false },
            { "CurrentPage", false },
            { "FromDate", false },
            { "ToDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditRequest"/> class.
        /// </summary>
        public AuditRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditRequest"/> class.
        /// </summary>
        /// <param name="status">Status.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="requestedOperation">RequestedOperation.</param>
        /// <param name="sortOrder">SortOrder.</param>
        /// <param name="searchText">SearchText.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        public AuditRequest(
            string status = null,
            string payerNumber = null,
            int? payerId = null,
            string accountNumber = null,
            int? colCoCode = null,
            int? colCoId = null,
            Models.Accounts accounts = null,
            int? pageSize = null,
            List<string> requestedOperation = null,
            string sortOrder = null,
            string searchText = null,
            int? currentPage = null,
            string fromDate = null,
            string toDate = null)
        {
            this.Status = status;
            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            this.Accounts = accounts;
            this.PageSize = pageSize;
            this.RequestedOperation = requestedOperation;
            if (sortOrder != null)
            {
                this.SortOrder = sortOrder;
            }

            if (searchText != null)
            {
                this.SearchText = searchText;
            }

            if (currentPage != null)
            {
                this.CurrentPage = currentPage;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

        }

        /// <summary>
        /// Status of requests to be fetched.
        /// •	Success
        /// •	Failed
        /// •	InProgress
        /// •	Submitted
        /// •	Rejected
        /// •	PendingApproval
        /// •	All
        /// •	MailedToCSC
        /// Optional
        /// If not passed “All” will be considered as the default value.
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
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
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// Example: 123456
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
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
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
        /// Collecting Company Id  of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
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
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Accounts Accounts { get; set; }

        /// <summary>
        /// Page Size – Number of records to show on a page
        /// Optional
        /// Default value 50
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// To search for requests submitted until this date.
        /// Optional
        /// Format: yyyyMMdd
        /// Example: 20200130
        /// If ToDate is not provided and FromDate is provided, then ToDate will be considered as current date or 30 days from FromDate, whichever is earlier. However, when both FromDate and ToDate is not provided then last 30 days will be considered for filtering.
        /// </summary>
        [JsonProperty("RequestedOperation", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequestedOperation { get; set; }

        /// <summary>
        /// Allowed Sorting Options:
        /// 1.	SubmittedDateDescending
        /// 2.	SubmittedDateAscending
        /// 3.	AccountNumberAscending
        /// 4.	AccountNumberDescending
        /// Optional: Default value is 1
        /// Example value to be passed: 1,3
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder
        {
            get
            {
                return this.sortOrder;
            }

            set
            {
                this.shouldSerialize["SortOrder"] = true;
                this.sortOrder = value;
            }
        }

        /// <summary>
        /// Search text used as criteria to filter the requests.
        /// Optional
        /// Minimum length is 4 characters (configurable). Else, an error (0007) will be returned. When valid text is provided, MS will return all the records that contains the Search Text within any of the look up fields
        /// </summary>
        [JsonProperty("SearchText")]
        public string SearchText
        {
            get
            {
                return this.searchText;
            }

            set
            {
                this.shouldSerialize["SearchText"] = true;
                this.searchText = value;
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
        /// To search for requests submitted from this date.
        /// Optional
        /// Maximum of X days duration allowed per search. The X value is configurable and initially set to 180 days.
        /// Format: yyyyMMdd
        /// Example: 20200101
        /// If FromDate is not provided and ToDate is provided, then FromDate will be considered as 30 days less than ToDate. However, when both FromDate and ToDate is not provided then last 30 days will be considered for filtering.
        /// </summary>
        [JsonProperty("FromDate")]
        public string FromDate
        {
            get
            {
                return this.fromDate;
            }

            set
            {
                this.shouldSerialize["FromDate"] = true;
                this.fromDate = value;
            }
        }

        /// <summary>
        /// To search for requests submitted until this date.
        /// Optional
        /// Format: yyyyMMdd
        /// Example: 20200130
        /// If ToDate is not provided and FromDate is provided, then ToDate will be considered as current date or 30 days from FromDate, whichever is earlier. However, when both FromDate and ToDate is not provided then last 30 days will be considered for filtering.
        /// </summary>
        [JsonProperty("ToDate")]
        public string ToDate
        {
            get
            {
                return this.toDate;
            }

            set
            {
                this.shouldSerialize["ToDate"] = true;
                this.toDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuditRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
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
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSortOrder()
        {
            this.shouldSerialize["SortOrder"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSearchText()
        {
            this.shouldSerialize["SearchText"] = false;
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
        public void UnsetFromDate()
        {
            this.shouldSerialize["FromDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToDate()
        {
            this.shouldSerialize["ToDate"] = false;
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
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
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
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSortOrder()
        {
            return this.shouldSerialize["SortOrder"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSearchText()
        {
            return this.shouldSerialize["SearchText"];
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
        public bool ShouldSerializeFromDate()
        {
            return this.shouldSerialize["FromDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToDate()
        {
            return this.shouldSerialize["ToDate"];
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
            return obj is AuditRequest other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.RequestedOperation == null && other.RequestedOperation == null) || (this.RequestedOperation?.Equals(other.RequestedOperation) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true)) &&
                ((this.SearchText == null && other.SearchText == null) || (this.SearchText?.Equals(other.SearchText) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.RequestedOperation = {(this.RequestedOperation == null ? "null" : $"[{string.Join(", ", this.RequestedOperation)} ]")}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder)}");
            toStringOutput.Add($"this.SearchText = {(this.SearchText == null ? "null" : this.SearchText)}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
        }
    }
}
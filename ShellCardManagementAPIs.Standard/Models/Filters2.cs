// <copyright file="Filters2.cs" company="APIMatic">
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
    /// Filters2.
    /// </summary>
    public class Filters2
    {
        private int? accountId;
        private string accountNumber;
        private int? colCoCode;
        private int? colCoId;
        private string colCoCountryCode;
        private int? payerId;
        private string payerNumber;
        private string fromDate;
        private string toDate;
        private string orderRequestId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "ColCoCode", false },
            { "ColCoId", false },
            { "ColCoCountryCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "FromDate", false },
            { "ToDate", false },
            { "OrderRequestId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters2"/> class.
        /// </summary>
        public Filters2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters2"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCountryCode">ColCoCountryCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="referenceNumber">ReferenceNumber.</param>
        /// <param name="referenceType">ReferenceType.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="orderRequestId">OrderRequestId.</param>
        public Filters2(
            int? accountId = null,
            string accountNumber = null,
            int? colCoCode = null,
            int? colCoId = null,
            string colCoCountryCode = null,
            int? payerId = null,
            string payerNumber = null,
            int? referenceNumber = null,
            Models.OrderCardEnquiryReqReferenceTypeEnum? referenceType = null,
            string fromDate = null,
            string toDate = null,
            string orderRequestId = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
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

            if (colCoCountryCode != null)
            {
                this.ColCoCountryCode = colCoCountryCode;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            this.ReferenceNumber = referenceNumber;
            this.ReferenceType = referenceType;
            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (orderRequestId != null)
            {
                this.OrderRequestId = orderRequestId;
            }

        }

        /// <summary>
        /// Account ID of the customer.<br/> Optional if AccountNumber is passed, else mandatory. <br/> This input is a search criterion, if given.
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Account Number of the customer.<br/> Optional if AccountId is passed, else mandatory.<br/> This input is a search criterion, if given.
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
        /// Collecting Company Code (Shell Code) of the selected payer. <br />
        /// Optional – when ‘ReferenceNumber’ is provided.<br />
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
        /// Collecting Company Id (in ) of the selected payer. <br />
        /// Optional – when ‘ReferenceNumber’ is provided. Else, either ‘ColCoId’ or ‘ColCoCode’ is mandatory.<br />
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
        /// ISO 3166 Alpha-2 Country Code for the customer and card owning country.
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
        /// Payer Id (i.e. Customer Id of the Payment Customer) of the selected payer.<br />
        /// Optional – when ‘ReferenceNumber’ is provided. Else, either ‘PayerId’ or ‘PayerNumber’ is mandatory.
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
        /// Payer Number of the selected payer.<br />
        /// Optional – when ‘ReferenceNumber’ is provided. Else, either ‘PayerId’ or ‘PayerNumber’ is mandatory.
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
        /// Reference number of the Card Order/ Bulk Card Order/ Order Card Request.<br />
        /// Mandatory when ColCo and Payer fields are not provided. Else, optional.
        /// </summary>
        [JsonProperty("ReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets ReferenceType.
        /// </summary>
        [JsonProperty("ReferenceType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderCardEnquiryReqReferenceTypeEnum? ReferenceType { get; set; }

        /// <summary>
        /// Card Orders from Date/Time.<br />
        /// Optional.<br />
        /// Value should be with in last 7 days<br />
        /// This field is ignored if ReferenceNumber is provided <br />
        /// This field is optional when not provided and ReferenceNumber is null or empty then the value should be set to D-7(Where D is current date)<br />
        /// Format: yyyyMMdd
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
        /// Card Order to Date/Time<br />
        /// Optional<br />
        /// Value should be with in last 7 days<br />
        /// This field is ignored if ReferenceNumber is provided <br />
        /// This field is optional when not provided and ReferenceNumber is null or empty then the value should be set to current date<br />
        /// Format: yyyyMMdd
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

        /// <summary>
        /// Client provided Unique Id of the original Order Card request, the status of which is enquired by this API
        /// </summary>
        [JsonProperty("OrderRequestId")]
        public string OrderRequestId
        {
            get
            {
                return this.orderRequestId;
            }

            set
            {
                this.shouldSerialize["OrderRequestId"] = true;
                this.orderRequestId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filters2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
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
        public void UnsetColCoCountryCode()
        {
            this.shouldSerialize["ColCoCountryCode"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOrderRequestId()
        {
            this.shouldSerialize["OrderRequestId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
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
        public bool ShouldSerializeColCoCountryCode()
        {
            return this.shouldSerialize["ColCoCountryCode"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrderRequestId()
        {
            return this.shouldSerialize["OrderRequestId"];
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
            return obj is Filters2 other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCountryCode == null && other.ColCoCountryCode == null) || (this.ColCoCountryCode?.Equals(other.ColCoCountryCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.ReferenceNumber == null && other.ReferenceNumber == null) || (this.ReferenceNumber?.Equals(other.ReferenceNumber) == true)) &&
                ((this.ReferenceType == null && other.ReferenceType == null) || (this.ReferenceType?.Equals(other.ReferenceType) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.OrderRequestId == null && other.OrderRequestId == null) || (this.OrderRequestId?.Equals(other.OrderRequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCountryCode = {(this.ColCoCountryCode == null ? "null" : this.ColCoCountryCode)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.ReferenceNumber = {(this.ReferenceNumber == null ? "null" : this.ReferenceNumber.ToString())}");
            toStringOutput.Add($"this.ReferenceType = {(this.ReferenceType == null ? "null" : this.ReferenceType.ToString())}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.OrderRequestId = {(this.OrderRequestId == null ? "null" : this.OrderRequestId)}");
        }
    }
}
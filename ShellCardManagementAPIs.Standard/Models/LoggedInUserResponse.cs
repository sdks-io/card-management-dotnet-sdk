// <copyright file="LoggedInUserResponse.cs" company="APIMatic">
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
    /// LoggedInUserResponse.
    /// </summary>
    public class LoggedInUserResponse
    {
        private string userName;
        private string displayName;
        private string idMSSOID;
        private string preferredLanguage;
        private string dateFormat;
        private string timeFormat;
        private int? weekBegins;
        private string cSVSeparator;
        private string decimalSeparator;
        private string reportFormat;
        private string userClassificationBySystem;
        private string userClassificationByShell;
        private int? payerCount;
        private int? accountCount;
        private int? cardCount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "UserName", false },
            { "DisplayName", false },
            { "IdMSSOID", false },
            { "PreferredLanguage", false },
            { "DateFormat", false },
            { "TimeFormat", false },
            { "WeekBegins", false },
            { "CSVSeparator", false },
            { "DecimalSeparator", false },
            { "ReportFormat", false },
            { "UserClassificationBySystem", false },
            { "UserClassificationByShell", false },
            { "PayerCount", false },
            { "AccountCount", false },
            { "CardCount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedInUserResponse"/> class.
        /// </summary>
        public LoggedInUserResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedInUserResponse"/> class.
        /// </summary>
        /// <param name="userName">UserName.</param>
        /// <param name="displayName">DisplayName.</param>
        /// <param name="idMSSOID">IdMSSOID.</param>
        /// <param name="preferredLanguage">PreferredLanguage.</param>
        /// <param name="isSuperAdmin">IsSuperAdmin.</param>
        /// <param name="dateFormat">DateFormat.</param>
        /// <param name="timeFormat">TimeFormat.</param>
        /// <param name="weekBegins">WeekBegins.</param>
        /// <param name="displayWeek">DisplayWeek.</param>
        /// <param name="cSVSeparator">CSVSeparator.</param>
        /// <param name="decimalSeparator">DecimalSeparator.</param>
        /// <param name="reportFormat">ReportFormat.</param>
        /// <param name="hasAPIAccess">HasAPIAccess.</param>
        /// <param name="roles">Roles.</param>
        /// <param name="payers">Payers.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="collectingCompanies">CollectingCompanies.</param>
        /// <param name="eIDAccessDetails">EIDAccessDetails.</param>
        /// <param name="userClassificationBySystem">UserClassificationBySystem.</param>
        /// <param name="userClassificationByShell">UserClassificationByShell.</param>
        /// <param name="payerCount">PayerCount.</param>
        /// <param name="accountCount">AccountCount.</param>
        /// <param name="cardCount">CardCount.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public LoggedInUserResponse(
            string userName = null,
            string displayName = null,
            string idMSSOID = null,
            string preferredLanguage = null,
            bool? isSuperAdmin = false,
            string dateFormat = null,
            string timeFormat = null,
            int? weekBegins = null,
            bool? displayWeek = true,
            string cSVSeparator = null,
            string decimalSeparator = null,
            string reportFormat = null,
            bool? hasAPIAccess = true,
            List<Models.Role> roles = null,
            List<Models.PayerAccess> payers = null,
            List<Models.AccountAccess> accounts = null,
            List<Models.ColCoAccess> collectingCompanies = null,
            List<Models.EIDAccess> eIDAccessDetails = null,
            string userClassificationBySystem = null,
            string userClassificationByShell = null,
            int? payerCount = null,
            int? accountCount = null,
            int? cardCount = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {

            if (userName != null)
            {
                this.UserName = userName;
            }

            if (displayName != null)
            {
                this.DisplayName = displayName;
            }

            if (idMSSOID != null)
            {
                this.IdMSSOID = idMSSOID;
            }

            if (preferredLanguage != null)
            {
                this.PreferredLanguage = preferredLanguage;
            }
            this.IsSuperAdmin = isSuperAdmin;

            if (dateFormat != null)
            {
                this.DateFormat = dateFormat;
            }

            if (timeFormat != null)
            {
                this.TimeFormat = timeFormat;
            }

            if (weekBegins != null)
            {
                this.WeekBegins = weekBegins;
            }
            this.DisplayWeek = displayWeek;

            if (cSVSeparator != null)
            {
                this.CSVSeparator = cSVSeparator;
            }

            if (decimalSeparator != null)
            {
                this.DecimalSeparator = decimalSeparator;
            }

            if (reportFormat != null)
            {
                this.ReportFormat = reportFormat;
            }
            this.HasAPIAccess = hasAPIAccess;
            this.Roles = roles;
            this.Payers = payers;
            this.Accounts = accounts;
            this.CollectingCompanies = collectingCompanies;
            this.EIDAccessDetails = eIDAccessDetails;

            if (userClassificationBySystem != null)
            {
                this.UserClassificationBySystem = userClassificationBySystem;
            }

            if (userClassificationByShell != null)
            {
                this.UserClassificationByShell = userClassificationByShell;
            }

            if (payerCount != null)
            {
                this.PayerCount = payerCount;
            }

            if (accountCount != null)
            {
                this.AccountCount = accountCount;
            }

            if (cardCount != null)
            {
                this.CardCount = cardCount;
            }
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Logged in User Identifier
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.shouldSerialize["UserName"] = true;
                this.userName = value;
            }
        }

        /// <summary>
        /// Name of the logged in user.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName
        {
            get
            {
                return this.displayName;
            }

            set
            {
                this.shouldSerialize["DisplayName"] = true;
                this.displayName = value;
            }
        }

        /// <summary>
        /// Single Sign On/Unique Identifier of the User in Identity Management system
        /// </summary>
        [JsonProperty("IdMSSOID")]
        public string IdMSSOID
        {
            get
            {
                return this.idMSSOID;
            }

            set
            {
                this.shouldSerialize["IdMSSOID"] = true;
                this.idMSSOID = value;
            }
        }

        /// <summary>
        /// ISO culture code/ Language chosen by the logged in user
        /// </summary>
        [JsonProperty("PreferredLanguage")]
        public string PreferredLanguage
        {
            get
            {
                return this.preferredLanguage;
            }

            set
            {
                this.shouldSerialize["PreferredLanguage"] = true;
                this.preferredLanguage = value;
            }
        }

        /// <summary>
        /// Whether the user is a super administrator
        /// </summary>
        [JsonProperty("IsSuperAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuperAdmin { get; set; }

        /// <summary>
        /// Preferred Date format for the logged in user
        /// </summary>
        [JsonProperty("DateFormat")]
        public string DateFormat
        {
            get
            {
                return this.dateFormat;
            }

            set
            {
                this.shouldSerialize["DateFormat"] = true;
                this.dateFormat = value;
            }
        }

        /// <summary>
        /// Preferred Time format for the logged in user
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat
        {
            get
            {
                return this.timeFormat;
            }

            set
            {
                this.shouldSerialize["TimeFormat"] = true;
                this.timeFormat = value;
            }
        }

        /// <summary>
        /// Preferred Day to Begin the Week. The value will be between 1 to 7 or null.
        /// </summary>
        [JsonProperty("WeekBegins")]
        public int? WeekBegins
        {
            get
            {
                return this.weekBegins;
            }

            set
            {
                this.shouldSerialize["WeekBegins"] = true;
                this.weekBegins = value;
            }
        }

        /// <summary>
        /// Preferred Display Week on Fuel Prices configuration for the logged in User.
        /// </summary>
        [JsonProperty("DisplayWeek", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayWeek { get; set; }

        /// <summary>
        /// Preferred CSV Separator for the logged in user.
        /// </summary>
        [JsonProperty("CSVSeparator")]
        public string CSVSeparator
        {
            get
            {
                return this.cSVSeparator;
            }

            set
            {
                this.shouldSerialize["CSVSeparator"] = true;
                this.cSVSeparator = value;
            }
        }

        /// <summary>
        /// Preferred Decimal separator configured for the logged in user
        /// Note: - Colco default value (configured at Microservices) is returned when the user is not provided or does not exist.
        /// </summary>
        [JsonProperty("DecimalSeparator")]
        public string DecimalSeparator
        {
            get
            {
                return this.decimalSeparator;
            }

            set
            {
                this.shouldSerialize["DecimalSeparator"] = true;
                this.decimalSeparator = value;
            }
        }

        /// <summary>
        /// Preferred report format configured for the logged in user
        /// </summary>
        [JsonProperty("ReportFormat")]
        public string ReportFormat
        {
            get
            {
                return this.reportFormat;
            }

            set
            {
                this.shouldSerialize["ReportFormat"] = true;
                this.reportFormat = value;
            }
        }

        /// <summary>
        /// True/False
        /// True, if user has access to the requested API. This is validated based on the role Vs API access matrix and client Vs API access matrix.
        /// </summary>
        [JsonProperty("HasAPIAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasAPIAccess { get; set; }

        /// <summary>
        /// List of roles the user have access to
        /// </summary>
        [JsonProperty("Roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Role> Roles { get; set; }

        /// <summary>
        /// List of payers which the user has access to.
        /// •    It will return 250 payers only and it is configurable. If the user has more than that, the remaining will be ignored.
        /// •    The payer which is marked as default will be the first item in the output.
        /// Note: This list will be empty for users mapped with roles which has either IsShellAdmin or IsServiceAccount set to true as their access level is controlled at ColCo level only.
        /// </summary>
        [JsonProperty("Payers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PayerAccess> Payers { get; set; }

        /// <summary>
        /// List of accounts which the user has access to.
        /// Note: This list will be empty for users mapped with roles which has either IsCustomerAdmin, IsShellAdmin or IsServiceAccount set to true as their access level is controller at either ColCo or payer level only.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountAccess> Accounts { get; set; }

        /// <summary>
        /// List of collecting companies to which the user has access to
        /// Note: This list will be empty for users mapped with roles which has either IsCustomerAdmin or IsCustomerUser set to true as their access level is controller at Payer or Account level.
        /// </summary>
        [JsonProperty("CollectingCompanies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ColCoAccess> CollectingCompanies { get; set; }

        /// <summary>
        /// List of Electronic Invoice Data configured for the user.
        /// Note: This list will be empty if the value of EIDDetails is set to false or empty in the request.
        /// </summary>
        [JsonProperty("EIDAccessDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EIDAccess> EIDAccessDetails { get; set; }

        /// <summary>
        /// User classification by system.
        /// </summary>
        [JsonProperty("UserClassificationBySystem")]
        public string UserClassificationBySystem
        {
            get
            {
                return this.userClassificationBySystem;
            }

            set
            {
                this.shouldSerialize["UserClassificationBySystem"] = true;
                this.userClassificationBySystem = value;
            }
        }

        /// <summary>
        /// User classification by Shell.
        /// </summary>
        [JsonProperty("UserClassificationByShell")]
        public string UserClassificationByShell
        {
            get
            {
                return this.userClassificationByShell;
            }

            set
            {
                this.shouldSerialize["UserClassificationByShell"] = true;
                this.userClassificationByShell = value;
            }
        }

        /// <summary>
        /// Count of payers accessible to the user at the time when user was created or last updated.
        /// Note:
        /// Count may vary based on customer operations hence it may not be an up to date value.
        /// </summary>
        [JsonProperty("PayerCount")]
        public int? PayerCount
        {
            get
            {
                return this.payerCount;
            }

            set
            {
                this.shouldSerialize["PayerCount"] = true;
                this.payerCount = value;
            }
        }

        /// <summary>
        /// Count of accounts at the time when the user was created or last updated.
        /// Note:
        /// Count may vary based on customer operations hence it may not be an up to date value.
        /// </summary>
        [JsonProperty("AccountCount")]
        public int? AccountCount
        {
            get
            {
                return this.accountCount;
            }

            set
            {
                this.shouldSerialize["AccountCount"] = true;
                this.accountCount = value;
            }
        }

        /// <summary>
        /// Count of cards at the time when the user was created or last updated.
        /// Note:
        /// Count may vary based on customer operations hence it may not be an up to date value.
        /// </summary>
        [JsonProperty("CardCount")]
        public int? CardCount
        {
            get
            {
                return this.cardCount;
            }

            set
            {
                this.shouldSerialize["CardCount"] = true;
                this.cardCount = value;
            }
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// Request Id of the API call
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LoggedInUserResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserName()
        {
            this.shouldSerialize["UserName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDisplayName()
        {
            this.shouldSerialize["DisplayName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIdMSSOID()
        {
            this.shouldSerialize["IdMSSOID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPreferredLanguage()
        {
            this.shouldSerialize["PreferredLanguage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDateFormat()
        {
            this.shouldSerialize["DateFormat"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTimeFormat()
        {
            this.shouldSerialize["TimeFormat"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeekBegins()
        {
            this.shouldSerialize["WeekBegins"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCSVSeparator()
        {
            this.shouldSerialize["CSVSeparator"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDecimalSeparator()
        {
            this.shouldSerialize["DecimalSeparator"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReportFormat()
        {
            this.shouldSerialize["ReportFormat"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserClassificationBySystem()
        {
            this.shouldSerialize["UserClassificationBySystem"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserClassificationByShell()
        {
            this.shouldSerialize["UserClassificationByShell"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayerCount()
        {
            this.shouldSerialize["PayerCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountCount()
        {
            this.shouldSerialize["AccountCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardCount()
        {
            this.shouldSerialize["CardCount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserName()
        {
            return this.shouldSerialize["UserName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisplayName()
        {
            return this.shouldSerialize["DisplayName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIdMSSOID()
        {
            return this.shouldSerialize["IdMSSOID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePreferredLanguage()
        {
            return this.shouldSerialize["PreferredLanguage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateFormat()
        {
            return this.shouldSerialize["DateFormat"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTimeFormat()
        {
            return this.shouldSerialize["TimeFormat"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeekBegins()
        {
            return this.shouldSerialize["WeekBegins"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCSVSeparator()
        {
            return this.shouldSerialize["CSVSeparator"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDecimalSeparator()
        {
            return this.shouldSerialize["DecimalSeparator"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReportFormat()
        {
            return this.shouldSerialize["ReportFormat"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserClassificationBySystem()
        {
            return this.shouldSerialize["UserClassificationBySystem"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserClassificationByShell()
        {
            return this.shouldSerialize["UserClassificationByShell"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerCount()
        {
            return this.shouldSerialize["PayerCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountCount()
        {
            return this.shouldSerialize["AccountCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardCount()
        {
            return this.shouldSerialize["CardCount"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LoggedInUserResponse other &&
                (this.UserName == null && other.UserName == null ||
                 this.UserName?.Equals(other.UserName) == true) &&
                (this.DisplayName == null && other.DisplayName == null ||
                 this.DisplayName?.Equals(other.DisplayName) == true) &&
                (this.IdMSSOID == null && other.IdMSSOID == null ||
                 this.IdMSSOID?.Equals(other.IdMSSOID) == true) &&
                (this.PreferredLanguage == null && other.PreferredLanguage == null ||
                 this.PreferredLanguage?.Equals(other.PreferredLanguage) == true) &&
                (this.IsSuperAdmin == null && other.IsSuperAdmin == null ||
                 this.IsSuperAdmin?.Equals(other.IsSuperAdmin) == true) &&
                (this.DateFormat == null && other.DateFormat == null ||
                 this.DateFormat?.Equals(other.DateFormat) == true) &&
                (this.TimeFormat == null && other.TimeFormat == null ||
                 this.TimeFormat?.Equals(other.TimeFormat) == true) &&
                (this.WeekBegins == null && other.WeekBegins == null ||
                 this.WeekBegins?.Equals(other.WeekBegins) == true) &&
                (this.DisplayWeek == null && other.DisplayWeek == null ||
                 this.DisplayWeek?.Equals(other.DisplayWeek) == true) &&
                (this.CSVSeparator == null && other.CSVSeparator == null ||
                 this.CSVSeparator?.Equals(other.CSVSeparator) == true) &&
                (this.DecimalSeparator == null && other.DecimalSeparator == null ||
                 this.DecimalSeparator?.Equals(other.DecimalSeparator) == true) &&
                (this.ReportFormat == null && other.ReportFormat == null ||
                 this.ReportFormat?.Equals(other.ReportFormat) == true) &&
                (this.HasAPIAccess == null && other.HasAPIAccess == null ||
                 this.HasAPIAccess?.Equals(other.HasAPIAccess) == true) &&
                (this.Roles == null && other.Roles == null ||
                 this.Roles?.Equals(other.Roles) == true) &&
                (this.Payers == null && other.Payers == null ||
                 this.Payers?.Equals(other.Payers) == true) &&
                (this.Accounts == null && other.Accounts == null ||
                 this.Accounts?.Equals(other.Accounts) == true) &&
                (this.CollectingCompanies == null && other.CollectingCompanies == null ||
                 this.CollectingCompanies?.Equals(other.CollectingCompanies) == true) &&
                (this.EIDAccessDetails == null && other.EIDAccessDetails == null ||
                 this.EIDAccessDetails?.Equals(other.EIDAccessDetails) == true) &&
                (this.UserClassificationBySystem == null && other.UserClassificationBySystem == null ||
                 this.UserClassificationBySystem?.Equals(other.UserClassificationBySystem) == true) &&
                (this.UserClassificationByShell == null && other.UserClassificationByShell == null ||
                 this.UserClassificationByShell?.Equals(other.UserClassificationByShell) == true) &&
                (this.PayerCount == null && other.PayerCount == null ||
                 this.PayerCount?.Equals(other.PayerCount) == true) &&
                (this.AccountCount == null && other.AccountCount == null ||
                 this.AccountCount?.Equals(other.AccountCount) == true) &&
                (this.CardCount == null && other.CardCount == null ||
                 this.CardCount?.Equals(other.CardCount) == true) &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true) &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"UserName = {this.UserName ?? "null"}");
            toStringOutput.Add($"DisplayName = {this.DisplayName ?? "null"}");
            toStringOutput.Add($"IdMSSOID = {this.IdMSSOID ?? "null"}");
            toStringOutput.Add($"PreferredLanguage = {this.PreferredLanguage ?? "null"}");
            toStringOutput.Add($"IsSuperAdmin = {(this.IsSuperAdmin == null ? "null" : this.IsSuperAdmin.ToString())}");
            toStringOutput.Add($"DateFormat = {this.DateFormat ?? "null"}");
            toStringOutput.Add($"TimeFormat = {this.TimeFormat ?? "null"}");
            toStringOutput.Add($"WeekBegins = {(this.WeekBegins == null ? "null" : this.WeekBegins.ToString())}");
            toStringOutput.Add($"DisplayWeek = {(this.DisplayWeek == null ? "null" : this.DisplayWeek.ToString())}");
            toStringOutput.Add($"CSVSeparator = {this.CSVSeparator ?? "null"}");
            toStringOutput.Add($"DecimalSeparator = {this.DecimalSeparator ?? "null"}");
            toStringOutput.Add($"ReportFormat = {this.ReportFormat ?? "null"}");
            toStringOutput.Add($"HasAPIAccess = {(this.HasAPIAccess == null ? "null" : this.HasAPIAccess.ToString())}");
            toStringOutput.Add($"Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
            toStringOutput.Add($"Payers = {(this.Payers == null ? "null" : $"[{string.Join(", ", this.Payers)} ]")}");
            toStringOutput.Add($"Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"CollectingCompanies = {(this.CollectingCompanies == null ? "null" : $"[{string.Join(", ", this.CollectingCompanies)} ]")}");
            toStringOutput.Add($"EIDAccessDetails = {(this.EIDAccessDetails == null ? "null" : $"[{string.Join(", ", this.EIDAccessDetails)} ]")}");
            toStringOutput.Add($"UserClassificationBySystem = {this.UserClassificationBySystem ?? "null"}");
            toStringOutput.Add($"UserClassificationByShell = {this.UserClassificationByShell ?? "null"}");
            toStringOutput.Add($"PayerCount = {(this.PayerCount == null ? "null" : this.PayerCount.ToString())}");
            toStringOutput.Add($"AccountCount = {(this.AccountCount == null ? "null" : this.AccountCount.ToString())}");
            toStringOutput.Add($"CardCount = {(this.CardCount == null ? "null" : this.CardCount.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}
// <copyright file="RestrictionCardList.cs" company="APIMatic">
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
    /// RestrictionCardList.
    /// </summary>
    public class RestrictionCardList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardList"/> class.
        /// </summary>
        public RestrictionCardList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionCardList"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        /// <param name="statusId">StatusId.</param>
        /// <param name="statusDescription">StatusDescription.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="issueDate">IssueDate.</param>
        /// <param name="issueNumber">IssueNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="colCoCurrencyCode">ColCoCurrencyCode.</param>
        /// <param name="colCoCurrencySymbol">ColCoCurrencySymbol.</param>
        /// <param name="restrictionCurrencyCode">RestrictionCurrencyCode.</param>
        /// <param name="restrictionCurrencySymbol">RestrictionCurrencySymbol.</param>
        /// <param name="purchaseCategoryId">PurchaseCategoryId.</param>
        /// <param name="purchaseCategoryCode">PurchaseCategoryCode.</param>
        /// <param name="purchaseCategoryName">PurchaseCategoryName.</param>
        /// <param name="isSuperseded">IsSuperseded.</param>
        /// <param name="isVirtualCard">IsVirtualCard.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isCRT">IsCRT.</param>
        /// <param name="isFleet">IsFleet.</param>
        /// <param name="isShellSitesOnly">IsShellSitesOnly.</param>
        /// <param name="isPartnerSitesIncluded">IsPartnerSitesIncluded.</param>
        /// <param name="cardTypeId">CardTypeId.</param>
        /// <param name="cardTypeCode">CardTypeCode.</param>
        /// <param name="cardTypeName">CardTypeName.</param>
        /// <param name="bundleId">BundleId.</param>
        /// <param name="mediumTypeID">MediumTypeID.</param>
        /// <param name="mediumType">MediumType.</param>
        public RestrictionCardList(
            int? cardId = null,
            string pAN = null,
            string expiryDate = null,
            int? statusId = null,
            string statusDescription = null,
            string driverName = null,
            string vRN = null,
            string issueDate = null,
            int? issueNumber = null,
            int? accountId = null,
            string accountNumber = null,
            string accountName = null,
            string accountShortName = null,
            string currencyCode = null,
            string colCoCurrencyCode = null,
            string colCoCurrencySymbol = null,
            string restrictionCurrencyCode = null,
            string restrictionCurrencySymbol = null,
            string purchaseCategoryId = null,
            string purchaseCategoryCode = null,
            string purchaseCategoryName = null,
            bool? isSuperseded = null,
            bool? isVirtualCard = null,
            bool? isNational = null,
            bool? isInternational = null,
            bool? isCRT = null,
            bool? isFleet = null,
            bool? isShellSitesOnly = null,
            bool? isPartnerSitesIncluded = null,
            int? cardTypeId = null,
            string cardTypeCode = null,
            string cardTypeName = null,
            string bundleId = null,
            int? mediumTypeID = null,
            string mediumType = null)
        {
            this.CardId = cardId;
            this.PAN = pAN;
            this.ExpiryDate = expiryDate;
            this.StatusId = statusId;
            this.StatusDescription = statusDescription;
            this.DriverName = driverName;
            this.VRN = vRN;
            this.IssueDate = issueDate;
            this.IssueNumber = issueNumber;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.AccountShortName = accountShortName;
            this.CurrencyCode = currencyCode;
            this.ColCoCurrencyCode = colCoCurrencyCode;
            this.ColCoCurrencySymbol = colCoCurrencySymbol;
            this.RestrictionCurrencyCode = restrictionCurrencyCode;
            this.RestrictionCurrencySymbol = restrictionCurrencySymbol;
            this.PurchaseCategoryId = purchaseCategoryId;
            this.PurchaseCategoryCode = purchaseCategoryCode;
            this.PurchaseCategoryName = purchaseCategoryName;
            this.IsSuperseded = isSuperseded;
            this.IsVirtualCard = isVirtualCard;
            this.IsNational = isNational;
            this.IsInternational = isInternational;
            this.IsCRT = isCRT;
            this.IsFleet = isFleet;
            this.IsShellSitesOnly = isShellSitesOnly;
            this.IsPartnerSitesIncluded = isPartnerSitesIncluded;
            this.CardTypeId = cardTypeId;
            this.CardTypeCode = cardTypeCode;
            this.CardTypeName = cardTypeName;
            this.BundleId = bundleId;
            this.MediumTypeID = mediumTypeID;
            this.MediumType = mediumType;
        }

        /// <summary>
        /// Unique Card Id
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// Card PAN
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Expiry date of the card
        /// Format: yyyyMMdd
        /// Note: Clients to convert this to appropriate DateTime type.
        /// </summary>
        [JsonProperty("ExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Card Status id
        /// </summary>
        [JsonProperty("StatusId", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>
        /// Status Description (Active, Temporarily Blocked, etc.,)
        /// </summary>
        [JsonProperty("StatusDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Driver name
        /// Example:  ANDREW GILBERRY
        /// </summary>
        [JsonProperty("DriverName", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverName { get; set; }

        /// <summary>
        /// Vehicle registration number
        /// Example: MV65YLH
        /// </summary>
        [JsonProperty("VRN", NullValueHandling = NullValueHandling.Ignore)]
        public string VRN { get; set; }

        /// <summary>
        /// Issue date
        /// Format: yyyyMMdd
        /// Note: Clients to convert this to appropriate DateTime type.
        /// </summary>
        [JsonProperty("IssueDate", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// Issue Number
        /// </summary>
        [JsonProperty("IssueNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueNumber { get; set; }

        /// <summary>
        /// Account ID
        /// Example: 29484
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number
        /// Example: GB99215176
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Account Name
        /// Example: MATTHEW ALGIE & COMPANY LIMITED
        /// ]]>
        /// </summary>
        [JsonProperty("AccountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Account Short Name
        /// </summary>
        [JsonProperty("AccountShortName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountShortName { get; set; }

        /// <summary>
        /// ISO currency code of the Customer Currency
        /// Example: GBP
        /// </summary>
        [JsonProperty("CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// ISO currency code of the country.
        /// Example: GBP
        /// </summary>
        [JsonProperty("ColCoCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ColCoCurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol of the country.
        /// Example: £, $
        /// </summary>
        [JsonProperty("ColCoCurrencySymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string ColCoCurrencySymbol { get; set; }

        /// <summary>
        /// ISO currency code of the country.
        /// Example: GBP
        /// </summary>
        [JsonProperty("RestrictionCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrictionCurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol of the country.
        /// Example: £, $
        /// </summary>
        [JsonProperty("RestrictionCurrencySymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrictionCurrencySymbol { get; set; }

        /// <summary>
        /// Purchase category Id
        /// Example: 123, 124, etc.,
        /// </summary>
        [JsonProperty("PurchaseCategoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseCategoryId { get; set; }

        /// <summary>
        /// Purchase category code
        /// Example:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - FuelSave only
        /// 2 - FuelSave and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and FuelSave
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and FuelSave and Lubricants
        /// </summary>
        [JsonProperty("PurchaseCategoryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseCategoryCode { get; set; }

        /// <summary>
        /// Purchase category name
        /// Example:
        /// 0 - All Fuels (without VP) and Lubricants
        /// 1 - FuelSave only
        /// 2 - FuelSave and Lubricants
        /// 3 - No Restrictions
        /// 4 - VP and FuelSave
        /// 5 - Diesel ONLY
        /// 6 - Diesel and Lubricants
        /// 7 - VP and Lubricants
        /// 8 - VP and FuelSave and Lubricants
        /// </summary>
        [JsonProperty("PurchaseCategoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseCategoryName { get; set; }

        /// <summary>
        /// True/False
        /// True if a new card is issued with the same PAN, else false
        /// </summary>
        [JsonProperty("IsSuperseded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuperseded { get; set; }

        /// <summary>
        /// True/False
        /// True if it is a virtual card, else false
        /// </summary>
        [JsonProperty("IsVirtualCard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtualCard { get; set; }

        /// <summary>
        /// True/False
        /// True if it is a national card, else false
        /// </summary>
        [JsonProperty("IsNational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNational { get; set; }

        /// <summary>
        /// True/False
        /// True if it is an international card, else false
        /// </summary>
        [JsonProperty("IsInternational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; }

        /// <summary>
        /// True/False
        /// True if it is a CRT type card, else false
        /// </summary>
        [JsonProperty("IsCRT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCRT { get; set; }

        /// <summary>
        /// True/False
        /// True if it is a Fleet type card, else false
        /// </summary>
        [JsonProperty("IsFleet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFleet { get; set; }

        /// <summary>
        /// True/False
        /// True if it is only allowed at Shell sites, else false
        /// </summary>
        [JsonProperty("IsShellSitesOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellSitesOnly { get; set; }

        /// <summary>
        /// True/False
        /// True if it is allowed at all partner sites, else false
        /// </summary>
        [JsonProperty("IsPartnerSitesIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartnerSitesIncluded { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Card Type ID
        /// Example Id & Description:
        /// 1 - Philippines CRT 7077861
        /// 2- Philippines Fleet 7002861
        /// 5-SHELL FLEET- HONG KONG 7002821
        /// 6-SHELL NHF- HONG KONG 7002821
        /// 7-SHELL CRT- HONG KONG 7077821
        /// ]]>
        /// </summary>
        [JsonProperty("CardTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardTypeId { get; set; }

        /// <summary>
        /// ISO code of the card i.e. first 7 digits of the PAN
        /// </summary>
        [JsonProperty("CardTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CardTypeCode { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Card Type Name
        /// Example Id & Description:
        /// 1 - Philippines CRT 7077861
        /// 2- Philippines Fleet 7002861
        /// 5-SHELL FLEET- HONG KONG 7002821
        /// 6-SHELL NHF- HONG KONG 7002821
        /// 7-SHELL CRT- HONG KONG 7077821
        /// ]]>
        /// </summary>
        [JsonProperty("CardTypeName", NullValueHandling = NullValueHandling.Ignore)]
        public string CardTypeName { get; set; }

        /// <summary>
        /// Bundle Id associated with card in the Gateway.
        /// This field will have a null value if the card is not associated with any bundle of IncludeBundleDetails in request is false.
        /// If the search is based on a bundle Id, the same will be returned.
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// Id of the medium type identifier.
        /// Example: 1,2,4
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 4 - Fuel Card and Key fob Card
        /// 5 - Key fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 – Smartpay
        /// </summary>
        [JsonProperty("MediumTypeID", NullValueHandling = NullValueHandling.Ignore)]
        public int? MediumTypeID { get; set; }

        /// <summary>
        /// Name of the medium type identifier.
        /// Example: Fuel Card, Fuel Card with EV, Key fob
        /// Full list below:
        /// 1 - Fuel Card
        /// 2 - Fuel Card with EV
        /// 4 - Fuel Card and Key fob Card
        /// 5 - Key fob
        /// 6 - Virtual Card
        /// 7 - NPII Token
        /// 8 - Smartpay
        /// </summary>
        [JsonProperty("MediumType", NullValueHandling = NullValueHandling.Ignore)]
        public string MediumType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RestrictionCardList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RestrictionCardList other &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.ExpiryDate == null && other.ExpiryDate == null ||
                 this.ExpiryDate?.Equals(other.ExpiryDate) == true) &&
                (this.StatusId == null && other.StatusId == null ||
                 this.StatusId?.Equals(other.StatusId) == true) &&
                (this.StatusDescription == null && other.StatusDescription == null ||
                 this.StatusDescription?.Equals(other.StatusDescription) == true) &&
                (this.DriverName == null && other.DriverName == null ||
                 this.DriverName?.Equals(other.DriverName) == true) &&
                (this.VRN == null && other.VRN == null ||
                 this.VRN?.Equals(other.VRN) == true) &&
                (this.IssueDate == null && other.IssueDate == null ||
                 this.IssueDate?.Equals(other.IssueDate) == true) &&
                (this.IssueNumber == null && other.IssueNumber == null ||
                 this.IssueNumber?.Equals(other.IssueNumber) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AccountShortName == null && other.AccountShortName == null ||
                 this.AccountShortName?.Equals(other.AccountShortName) == true) &&
                (this.CurrencyCode == null && other.CurrencyCode == null ||
                 this.CurrencyCode?.Equals(other.CurrencyCode) == true) &&
                (this.ColCoCurrencyCode == null && other.ColCoCurrencyCode == null ||
                 this.ColCoCurrencyCode?.Equals(other.ColCoCurrencyCode) == true) &&
                (this.ColCoCurrencySymbol == null && other.ColCoCurrencySymbol == null ||
                 this.ColCoCurrencySymbol?.Equals(other.ColCoCurrencySymbol) == true) &&
                (this.RestrictionCurrencyCode == null && other.RestrictionCurrencyCode == null ||
                 this.RestrictionCurrencyCode?.Equals(other.RestrictionCurrencyCode) == true) &&
                (this.RestrictionCurrencySymbol == null && other.RestrictionCurrencySymbol == null ||
                 this.RestrictionCurrencySymbol?.Equals(other.RestrictionCurrencySymbol) == true) &&
                (this.PurchaseCategoryId == null && other.PurchaseCategoryId == null ||
                 this.PurchaseCategoryId?.Equals(other.PurchaseCategoryId) == true) &&
                (this.PurchaseCategoryCode == null && other.PurchaseCategoryCode == null ||
                 this.PurchaseCategoryCode?.Equals(other.PurchaseCategoryCode) == true) &&
                (this.PurchaseCategoryName == null && other.PurchaseCategoryName == null ||
                 this.PurchaseCategoryName?.Equals(other.PurchaseCategoryName) == true) &&
                (this.IsSuperseded == null && other.IsSuperseded == null ||
                 this.IsSuperseded?.Equals(other.IsSuperseded) == true) &&
                (this.IsVirtualCard == null && other.IsVirtualCard == null ||
                 this.IsVirtualCard?.Equals(other.IsVirtualCard) == true) &&
                (this.IsNational == null && other.IsNational == null ||
                 this.IsNational?.Equals(other.IsNational) == true) &&
                (this.IsInternational == null && other.IsInternational == null ||
                 this.IsInternational?.Equals(other.IsInternational) == true) &&
                (this.IsCRT == null && other.IsCRT == null ||
                 this.IsCRT?.Equals(other.IsCRT) == true) &&
                (this.IsFleet == null && other.IsFleet == null ||
                 this.IsFleet?.Equals(other.IsFleet) == true) &&
                (this.IsShellSitesOnly == null && other.IsShellSitesOnly == null ||
                 this.IsShellSitesOnly?.Equals(other.IsShellSitesOnly) == true) &&
                (this.IsPartnerSitesIncluded == null && other.IsPartnerSitesIncluded == null ||
                 this.IsPartnerSitesIncluded?.Equals(other.IsPartnerSitesIncluded) == true) &&
                (this.CardTypeId == null && other.CardTypeId == null ||
                 this.CardTypeId?.Equals(other.CardTypeId) == true) &&
                (this.CardTypeCode == null && other.CardTypeCode == null ||
                 this.CardTypeCode?.Equals(other.CardTypeCode) == true) &&
                (this.CardTypeName == null && other.CardTypeName == null ||
                 this.CardTypeName?.Equals(other.CardTypeName) == true) &&
                (this.BundleId == null && other.BundleId == null ||
                 this.BundleId?.Equals(other.BundleId) == true) &&
                (this.MediumTypeID == null && other.MediumTypeID == null ||
                 this.MediumTypeID?.Equals(other.MediumTypeID) == true) &&
                (this.MediumType == null && other.MediumType == null ||
                 this.MediumType?.Equals(other.MediumType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"ExpiryDate = {this.ExpiryDate ?? "null"}");
            toStringOutput.Add($"StatusId = {(this.StatusId == null ? "null" : this.StatusId.ToString())}");
            toStringOutput.Add($"StatusDescription = {this.StatusDescription ?? "null"}");
            toStringOutput.Add($"DriverName = {this.DriverName ?? "null"}");
            toStringOutput.Add($"VRN = {this.VRN ?? "null"}");
            toStringOutput.Add($"IssueDate = {this.IssueDate ?? "null"}");
            toStringOutput.Add($"IssueNumber = {(this.IssueNumber == null ? "null" : this.IssueNumber.ToString())}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"AccountShortName = {this.AccountShortName ?? "null"}");
            toStringOutput.Add($"CurrencyCode = {this.CurrencyCode ?? "null"}");
            toStringOutput.Add($"ColCoCurrencyCode = {this.ColCoCurrencyCode ?? "null"}");
            toStringOutput.Add($"ColCoCurrencySymbol = {this.ColCoCurrencySymbol ?? "null"}");
            toStringOutput.Add($"RestrictionCurrencyCode = {this.RestrictionCurrencyCode ?? "null"}");
            toStringOutput.Add($"RestrictionCurrencySymbol = {this.RestrictionCurrencySymbol ?? "null"}");
            toStringOutput.Add($"PurchaseCategoryId = {this.PurchaseCategoryId ?? "null"}");
            toStringOutput.Add($"PurchaseCategoryCode = {this.PurchaseCategoryCode ?? "null"}");
            toStringOutput.Add($"PurchaseCategoryName = {this.PurchaseCategoryName ?? "null"}");
            toStringOutput.Add($"IsSuperseded = {(this.IsSuperseded == null ? "null" : this.IsSuperseded.ToString())}");
            toStringOutput.Add($"IsVirtualCard = {(this.IsVirtualCard == null ? "null" : this.IsVirtualCard.ToString())}");
            toStringOutput.Add($"IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"IsCRT = {(this.IsCRT == null ? "null" : this.IsCRT.ToString())}");
            toStringOutput.Add($"IsFleet = {(this.IsFleet == null ? "null" : this.IsFleet.ToString())}");
            toStringOutput.Add($"IsShellSitesOnly = {(this.IsShellSitesOnly == null ? "null" : this.IsShellSitesOnly.ToString())}");
            toStringOutput.Add($"IsPartnerSitesIncluded = {(this.IsPartnerSitesIncluded == null ? "null" : this.IsPartnerSitesIncluded.ToString())}");
            toStringOutput.Add($"CardTypeId = {(this.CardTypeId == null ? "null" : this.CardTypeId.ToString())}");
            toStringOutput.Add($"CardTypeCode = {this.CardTypeCode ?? "null"}");
            toStringOutput.Add($"CardTypeName = {this.CardTypeName ?? "null"}");
            toStringOutput.Add($"BundleId = {this.BundleId ?? "null"}");
            toStringOutput.Add($"MediumTypeID = {(this.MediumTypeID == null ? "null" : this.MediumTypeID.ToString())}");
            toStringOutput.Add($"MediumType = {this.MediumType ?? "null"}");
        }
    }
}
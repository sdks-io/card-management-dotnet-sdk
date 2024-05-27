// <copyright file="DeliveryAddressUpdate.cs" company="APIMatic">
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
    /// DeliveryAddressUpdate.
    /// </summary>
    public class DeliveryAddressUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdate"/> class.
        /// </summary>
        public DeliveryAddressUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddressUpdate"/> class.
        /// </summary>
        /// <param name="useCustomerDefaultAddress">UseCustomerDefaultAddress.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardExpiryDate">CardExpiryDate.</param>
        /// <param name="updateCardRenewalAddress">UpdateCardRenewalAddress.</param>
        public DeliveryAddressUpdate(
            bool useCustomerDefaultAddress,
            int? cardId = null,
            string pAN = null,
            string cardExpiryDate = null,
            Models.UpdateCardRenewalAddress updateCardRenewalAddress = null)
        {
            this.CardId = cardId;
            this.PAN = pAN;
            this.CardExpiryDate = cardExpiryDate;
            this.UseCustomerDefaultAddress = useCustomerDefaultAddress;
            this.UpdateCardRenewalAddress = updateCardRenewalAddress;
        }

        /// <summary>
        /// Card Id of the card.
        /// Optional if  PAN is passed, else Mandatory.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// <![CDATA[
        /// PAN of the card.
        /// Optional if CardId is passed, else Mandatory.
        /// Note: -
        /// PAN & ExpiryDate parameters will be considered only if CardId & PANID are not provided.
        /// ]]>
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Expiry date of the card.
        /// Mandatory if PAN is passed, else optional.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CardExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// Whether to use the default delivery address configured at customer (or card group) level as the delivery address for this card.
        /// Mandatory
        /// Note: If value is false then ‘UpdateCardRenewalAddress’ is mandatory. If value set to ‘True’ then
        /// ‘UpdateCardRenewalAddress’ may be null/empty. It will be ignored if provided.
        /// </summary>
        [JsonProperty("UseCustomerDefaultAddress")]
        public bool UseCustomerDefaultAddress { get; set; }

        /// <summary>
        /// Delivery address of card. This address will be used for card reissue and PIN reminders in future.
        /// Note: Mandatory when ‘UseCustomerDefaultAddress’ is set to ‘false’. The field is ignored otherwise.
        /// </summary>
        [JsonProperty("UpdateCardRenewalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdateCardRenewalAddress UpdateCardRenewalAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeliveryAddressUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeliveryAddressUpdate other &&                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardExpiryDate == null && other.CardExpiryDate == null) || (this.CardExpiryDate?.Equals(other.CardExpiryDate) == true)) &&
                this.UseCustomerDefaultAddress.Equals(other.UseCustomerDefaultAddress) &&
                ((this.UpdateCardRenewalAddress == null && other.UpdateCardRenewalAddress == null) || (this.UpdateCardRenewalAddress?.Equals(other.UpdateCardRenewalAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardExpiryDate = {(this.CardExpiryDate == null ? "null" : this.CardExpiryDate)}");
            toStringOutput.Add($"this.UseCustomerDefaultAddress = {this.UseCustomerDefaultAddress}");
            toStringOutput.Add($"this.UpdateCardRenewalAddress = {(this.UpdateCardRenewalAddress == null ? "null" : this.UpdateCardRenewalAddress.ToString())}");
        }
    }
}
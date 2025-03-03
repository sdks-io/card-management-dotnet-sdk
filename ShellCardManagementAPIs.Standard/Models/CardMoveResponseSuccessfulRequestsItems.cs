// <copyright file="CardMoveResponseSuccessfulRequestsItems.cs" company="APIMatic">
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
    /// CardMoveResponseSuccessfulRequestsItems.
    /// </summary>
    public class CardMoveResponseSuccessfulRequestsItems
    {
        private string accountNumber;
        private int? accountId;
        private string pAN;
        private int? cardId;
        private int? moveCardReference;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountNumber", false },
            { "AccountId", false },
            { "PAN", false },
            { "CardId", false },
            { "MoveCardReference", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveResponseSuccessfulRequestsItems"/> class.
        /// </summary>
        public CardMoveResponseSuccessfulRequestsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMoveResponseSuccessfulRequestsItems"/> class.
        /// </summary>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="moveCardReference">MoveCardReference.</param>
        public CardMoveResponseSuccessfulRequestsItems(
            string accountNumber = null,
            int? accountId = null,
            string pAN = null,
            int? cardId = null,
            int? moveCardReference = null)
        {

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (moveCardReference != null)
            {
                this.MoveCardReference = moveCardReference;
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
        /// Gets or sets AccountId.
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
        /// Gets or sets PAN.
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
            }
        }

        /// <summary>
        /// Gets or sets CardId.
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// Gets or sets MoveCardReference.
        /// </summary>
        [JsonProperty("MoveCardReference")]
        public int? MoveCardReference
        {
            get
            {
                return this.moveCardReference;
            }

            set
            {
                this.shouldSerialize["MoveCardReference"] = true;
                this.moveCardReference = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardMoveResponseSuccessfulRequestsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMoveCardReference()
        {
            this.shouldSerialize["MoveCardReference"] = false;
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
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMoveCardReference()
        {
            return this.shouldSerialize["MoveCardReference"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardMoveResponseSuccessfulRequestsItems other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.PAN == null && other.PAN == null ||
                 this.PAN?.Equals(other.PAN) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.MoveCardReference == null && other.MoveCardReference == null ||
                 this.MoveCardReference?.Equals(other.MoveCardReference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"PAN = {this.PAN ?? "null"}");
            toStringOutput.Add($"CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"MoveCardReference = {(this.MoveCardReference == null ? "null" : this.MoveCardReference.ToString())}");
        }
    }
}
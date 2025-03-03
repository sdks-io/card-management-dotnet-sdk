// <copyright file="SummaryResponse.cs" company="APIMatic">
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
    /// SummaryResponse.
    /// </summary>
    public class SummaryResponse
    {
        private int? activeCards;
        private int? blockedCards;
        private int? cancelledCards;
        private int? expiredCards;
        private int? expiringCards;
        private int? fraudCards;
        private int? newCards;
        private int? renewalPendingCards;
        private int? replacedCards;
        private int? temporaryBlockByCustomer;
        private int? temporaryBlockByShell;
        private int? totalCards;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ActiveCards", false },
            { "BlockedCards", false },
            { "CancelledCards", false },
            { "ExpiredCards", false },
            { "ExpiringCards", false },
            { "FraudCards", false },
            { "NewCards", false },
            { "RenewalPendingCards", false },
            { "ReplacedCards", false },
            { "TemporaryBlockByCustomer", false },
            { "TemporaryBlockByShell", false },
            { "TotalCards", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryResponse"/> class.
        /// </summary>
        public SummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryResponse"/> class.
        /// </summary>
        /// <param name="activeCards">ActiveCards.</param>
        /// <param name="blockedCards">BlockedCards.</param>
        /// <param name="cancelledCards">CancelledCards.</param>
        /// <param name="expiredCards">ExpiredCards.</param>
        /// <param name="expiringCards">ExpiringCards.</param>
        /// <param name="fraudCards">FraudCards.</param>
        /// <param name="newCards">NewCards.</param>
        /// <param name="renewalPendingCards">RenewalPendingCards.</param>
        /// <param name="replacedCards">ReplacedCards.</param>
        /// <param name="temporaryBlockByCustomer">TemporaryBlockByCustomer.</param>
        /// <param name="temporaryBlockByShell">TemporaryBlockByShell.</param>
        /// <param name="totalCards">TotalCards.</param>
        public SummaryResponse(
            int? activeCards = null,
            int? blockedCards = null,
            int? cancelledCards = null,
            int? expiredCards = null,
            int? expiringCards = null,
            int? fraudCards = null,
            int? newCards = null,
            int? renewalPendingCards = null,
            int? replacedCards = null,
            int? temporaryBlockByCustomer = null,
            int? temporaryBlockByShell = null,
            int? totalCards = null)
        {

            if (activeCards != null)
            {
                this.ActiveCards = activeCards;
            }

            if (blockedCards != null)
            {
                this.BlockedCards = blockedCards;
            }

            if (cancelledCards != null)
            {
                this.CancelledCards = cancelledCards;
            }

            if (expiredCards != null)
            {
                this.ExpiredCards = expiredCards;
            }

            if (expiringCards != null)
            {
                this.ExpiringCards = expiringCards;
            }

            if (fraudCards != null)
            {
                this.FraudCards = fraudCards;
            }

            if (newCards != null)
            {
                this.NewCards = newCards;
            }

            if (renewalPendingCards != null)
            {
                this.RenewalPendingCards = renewalPendingCards;
            }

            if (replacedCards != null)
            {
                this.ReplacedCards = replacedCards;
            }

            if (temporaryBlockByCustomer != null)
            {
                this.TemporaryBlockByCustomer = temporaryBlockByCustomer;
            }

            if (temporaryBlockByShell != null)
            {
                this.TemporaryBlockByShell = temporaryBlockByShell;
            }

            if (totalCards != null)
            {
                this.TotalCards = totalCards;
            }
        }

        /// <summary>
        /// Total number of active cards for the given search criteria
        /// </summary>
        [JsonProperty("ActiveCards")]
        public int? ActiveCards
        {
            get
            {
                return this.activeCards;
            }

            set
            {
                this.shouldSerialize["ActiveCards"] = true;
                this.activeCards = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are permanently blocked (Blocked)
        /// </summary>
        [JsonProperty("BlockedCards")]
        public int? BlockedCards
        {
            get
            {
                return this.blockedCards;
            }

            set
            {
                this.shouldSerialize["BlockedCards"] = true;
                this.blockedCards = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are cancelled (at cancelled status) blocked by customer
        /// </summary>
        [JsonProperty("CancelledCards")]
        public int? CancelledCards
        {
            get
            {
                return this.cancelledCards;
            }

            set
            {
                this.shouldSerialize["CancelledCards"] = true;
                this.cancelledCards = value;
            }
        }

        /// <summary>
        /// Total number of expired cards for the given search criteria
        /// </summary>
        [JsonProperty("ExpiredCards")]
        public int? ExpiredCards
        {
            get
            {
                return this.expiredCards;
            }

            set
            {
                this.shouldSerialize["ExpiredCards"] = true;
                this.expiredCards = value;
            }
        }

        /// <summary>
        /// Cards that are active and expiring in X days, X should be configurable
        /// </summary>
        [JsonProperty("ExpiringCards")]
        public int? ExpiringCards
        {
            get
            {
                return this.expiringCards;
            }

            set
            {
                this.shouldSerialize["ExpiringCards"] = true;
                this.expiringCards = value;
            }
        }

        /// <summary>
        /// Totalnumber of Cards in Fraud status for the given search criteria.
        /// </summary>
        [JsonProperty("FraudCards")]
        public int? FraudCards
        {
            get
            {
                return this.fraudCards;
            }

            set
            {
                this.shouldSerialize["FraudCards"] = true;
                this.fraudCards = value;
            }
        }

        /// <summary>
        /// Total number of cards in New status for the given search criteria.
        /// </summary>
        [JsonProperty("NewCards")]
        public int? NewCards
        {
            get
            {
                return this.newCards;
            }

            set
            {
                this.shouldSerialize["NewCards"] = true;
                this.newCards = value;
            }
        }

        /// <summary>
        /// Total number of Renewal Pending cards for the given search criteria
        /// </summary>
        [JsonProperty("RenewalPendingCards")]
        public int? RenewalPendingCards
        {
            get
            {
                return this.renewalPendingCards;
            }

            set
            {
                this.shouldSerialize["RenewalPendingCards"] = true;
                this.renewalPendingCards = value;
            }
        }

        /// <summary>
        /// Cards with status Replaced
        /// </summary>
        [JsonProperty("ReplacedCards")]
        public int? ReplacedCards
        {
            get
            {
                return this.replacedCards;
            }

            set
            {
                this.shouldSerialize["ReplacedCards"] = true;
                this.replacedCards = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are temporarily blocked by customer
        /// </summary>
        [JsonProperty("TemporaryBlockByCustomer")]
        public int? TemporaryBlockByCustomer
        {
            get
            {
                return this.temporaryBlockByCustomer;
            }

            set
            {
                this.shouldSerialize["TemporaryBlockByCustomer"] = true;
                this.temporaryBlockByCustomer = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria that are temporarily blocked by Shell
        /// </summary>
        [JsonProperty("TemporaryBlockByShell")]
        public int? TemporaryBlockByShell
        {
            get
            {
                return this.temporaryBlockByShell;
            }

            set
            {
                this.shouldSerialize["TemporaryBlockByShell"] = true;
                this.temporaryBlockByShell = value;
            }
        }

        /// <summary>
        /// Total number of cards for the given search criteria
        /// </summary>
        [JsonProperty("TotalCards")]
        public int? TotalCards
        {
            get
            {
                return this.totalCards;
            }

            set
            {
                this.shouldSerialize["TotalCards"] = true;
                this.totalCards = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SummaryResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetActiveCards()
        {
            this.shouldSerialize["ActiveCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBlockedCards()
        {
            this.shouldSerialize["BlockedCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCancelledCards()
        {
            this.shouldSerialize["CancelledCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiredCards()
        {
            this.shouldSerialize["ExpiredCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiringCards()
        {
            this.shouldSerialize["ExpiringCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFraudCards()
        {
            this.shouldSerialize["FraudCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNewCards()
        {
            this.shouldSerialize["NewCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRenewalPendingCards()
        {
            this.shouldSerialize["RenewalPendingCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReplacedCards()
        {
            this.shouldSerialize["ReplacedCards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTemporaryBlockByCustomer()
        {
            this.shouldSerialize["TemporaryBlockByCustomer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTemporaryBlockByShell()
        {
            this.shouldSerialize["TemporaryBlockByShell"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotalCards()
        {
            this.shouldSerialize["TotalCards"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeActiveCards()
        {
            return this.shouldSerialize["ActiveCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBlockedCards()
        {
            return this.shouldSerialize["BlockedCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancelledCards()
        {
            return this.shouldSerialize["CancelledCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiredCards()
        {
            return this.shouldSerialize["ExpiredCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiringCards()
        {
            return this.shouldSerialize["ExpiringCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFraudCards()
        {
            return this.shouldSerialize["FraudCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNewCards()
        {
            return this.shouldSerialize["NewCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRenewalPendingCards()
        {
            return this.shouldSerialize["RenewalPendingCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReplacedCards()
        {
            return this.shouldSerialize["ReplacedCards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryBlockByCustomer()
        {
            return this.shouldSerialize["TemporaryBlockByCustomer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTemporaryBlockByShell()
        {
            return this.shouldSerialize["TemporaryBlockByShell"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalCards()
        {
            return this.shouldSerialize["TotalCards"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SummaryResponse other &&
                (this.ActiveCards == null && other.ActiveCards == null ||
                 this.ActiveCards?.Equals(other.ActiveCards) == true) &&
                (this.BlockedCards == null && other.BlockedCards == null ||
                 this.BlockedCards?.Equals(other.BlockedCards) == true) &&
                (this.CancelledCards == null && other.CancelledCards == null ||
                 this.CancelledCards?.Equals(other.CancelledCards) == true) &&
                (this.ExpiredCards == null && other.ExpiredCards == null ||
                 this.ExpiredCards?.Equals(other.ExpiredCards) == true) &&
                (this.ExpiringCards == null && other.ExpiringCards == null ||
                 this.ExpiringCards?.Equals(other.ExpiringCards) == true) &&
                (this.FraudCards == null && other.FraudCards == null ||
                 this.FraudCards?.Equals(other.FraudCards) == true) &&
                (this.NewCards == null && other.NewCards == null ||
                 this.NewCards?.Equals(other.NewCards) == true) &&
                (this.RenewalPendingCards == null && other.RenewalPendingCards == null ||
                 this.RenewalPendingCards?.Equals(other.RenewalPendingCards) == true) &&
                (this.ReplacedCards == null && other.ReplacedCards == null ||
                 this.ReplacedCards?.Equals(other.ReplacedCards) == true) &&
                (this.TemporaryBlockByCustomer == null && other.TemporaryBlockByCustomer == null ||
                 this.TemporaryBlockByCustomer?.Equals(other.TemporaryBlockByCustomer) == true) &&
                (this.TemporaryBlockByShell == null && other.TemporaryBlockByShell == null ||
                 this.TemporaryBlockByShell?.Equals(other.TemporaryBlockByShell) == true) &&
                (this.TotalCards == null && other.TotalCards == null ||
                 this.TotalCards?.Equals(other.TotalCards) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ActiveCards = {(this.ActiveCards == null ? "null" : this.ActiveCards.ToString())}");
            toStringOutput.Add($"BlockedCards = {(this.BlockedCards == null ? "null" : this.BlockedCards.ToString())}");
            toStringOutput.Add($"CancelledCards = {(this.CancelledCards == null ? "null" : this.CancelledCards.ToString())}");
            toStringOutput.Add($"ExpiredCards = {(this.ExpiredCards == null ? "null" : this.ExpiredCards.ToString())}");
            toStringOutput.Add($"ExpiringCards = {(this.ExpiringCards == null ? "null" : this.ExpiringCards.ToString())}");
            toStringOutput.Add($"FraudCards = {(this.FraudCards == null ? "null" : this.FraudCards.ToString())}");
            toStringOutput.Add($"NewCards = {(this.NewCards == null ? "null" : this.NewCards.ToString())}");
            toStringOutput.Add($"RenewalPendingCards = {(this.RenewalPendingCards == null ? "null" : this.RenewalPendingCards.ToString())}");
            toStringOutput.Add($"ReplacedCards = {(this.ReplacedCards == null ? "null" : this.ReplacedCards.ToString())}");
            toStringOutput.Add($"TemporaryBlockByCustomer = {(this.TemporaryBlockByCustomer == null ? "null" : this.TemporaryBlockByCustomer.ToString())}");
            toStringOutput.Add($"TemporaryBlockByShell = {(this.TemporaryBlockByShell == null ? "null" : this.TemporaryBlockByShell.ToString())}");
            toStringOutput.Add($"TotalCards = {(this.TotalCards == null ? "null" : this.TotalCards.ToString())}");
        }
    }
}
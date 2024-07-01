// <copyright file="CardManagementV1OrdercardRequest.cs" company="APIMatic">
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
    /// CardManagementV1OrdercardRequest.
    /// </summary>
    public class CardManagementV1OrdercardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardManagementV1OrdercardRequest"/> class.
        /// </summary>
        public CardManagementV1OrdercardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardManagementV1OrdercardRequest"/> class.
        /// </summary>
        /// <param name="cardDetails">CardDetails.</param>
        public CardManagementV1OrdercardRequest(
            List<Models.CardDetail> cardDetails = null)
        {
            this.CardDetails = cardDetails;
        }

        /// <summary>
        /// List of CardOrder entity. The fields in this entity are described below.
        /// </summary>
        [JsonProperty("CardDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardDetail> CardDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardManagementV1OrdercardRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardManagementV1OrdercardRequest other &&                ((this.CardDetails == null && other.CardDetails == null) || (this.CardDetails?.Equals(other.CardDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardDetails = {(this.CardDetails == null ? "null" : $"[{string.Join(", ", this.CardDetails)} ]")}");
        }
    }
}
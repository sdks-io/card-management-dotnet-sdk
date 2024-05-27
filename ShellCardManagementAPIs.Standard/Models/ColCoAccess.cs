// <copyright file="ColCoAccess.cs" company="APIMatic">
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
    /// ColCoAccess.
    /// </summary>
    public class ColCoAccess
    {
        private string colCoId;
        private string colCoCode;
        private string colCoCountryName;
        private string issuingCountryNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "ColCoCountryName", false },
            { "IssuingCountryNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ColCoAccess"/> class.
        /// </summary>
        public ColCoAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColCoAccess"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="colCoCountryName">ColCoCountryName.</param>
        /// <param name="issuingCountryNumber">IssuingCountryNumber.</param>
        public ColCoAccess(
            string colCoId = null,
            string colCoCode = null,
            string colCoCountryName = null,
            string issuingCountryNumber = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (colCoCountryName != null)
            {
                this.ColCoCountryName = colCoCountryName;
            }

            if (issuingCountryNumber != null)
            {
                this.IssuingCountryNumber = issuingCountryNumber;
            }

        }

        /// <summary>
        /// Collecting company ID.
        /// </summary>
        [JsonProperty("ColCoId")]
        public string ColCoId
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
        /// Collecting company code.
        /// </summary>
        [JsonProperty("ColCoCode")]
        public string ColCoCode
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
        /// Collecting company’s Country name. ex: United Kingdom
        /// </summary>
        [JsonProperty("ColCoCountryName")]
        public string ColCoCountryName
        {
            get
            {
                return this.colCoCountryName;
            }

            set
            {
                this.shouldSerialize["ColCoCountryName"] = true;
                this.colCoCountryName = value;
            }
        }

        /// <summary>
        /// Issuing Country Number.
        ///  ex: 032 - Czech Republic
        /// </summary>
        [JsonProperty("IssuingCountryNumber")]
        public string IssuingCountryNumber
        {
            get
            {
                return this.issuingCountryNumber;
            }

            set
            {
                this.shouldSerialize["IssuingCountryNumber"] = true;
                this.issuingCountryNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ColCoAccess : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCountryName()
        {
            this.shouldSerialize["ColCoCountryName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuingCountryNumber()
        {
            this.shouldSerialize["IssuingCountryNumber"] = false;
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
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCountryName()
        {
            return this.shouldSerialize["ColCoCountryName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuingCountryNumber()
        {
            return this.shouldSerialize["IssuingCountryNumber"];
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
            return obj is ColCoAccess other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.ColCoCountryName == null && other.ColCoCountryName == null) || (this.ColCoCountryName?.Equals(other.ColCoCountryName) == true)) &&
                ((this.IssuingCountryNumber == null && other.IssuingCountryNumber == null) || (this.IssuingCountryNumber?.Equals(other.IssuingCountryNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode)}");
            toStringOutput.Add($"this.ColCoCountryName = {(this.ColCoCountryName == null ? "null" : this.ColCoCountryName)}");
            toStringOutput.Add($"this.IssuingCountryNumber = {(this.IssuingCountryNumber == null ? "null" : this.IssuingCountryNumber)}");
        }
    }
}
// <copyright file="CardDetailsResponsePINTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using ShellCardManagementAPIs.Standard;
using ShellCardManagementAPIs.Standard.Utilities;

namespace ShellCardManagementAPIs.Standard.Models
{
    /// <summary>
    /// CardDetailsResponsePINTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardDetailsResponsePINTypeEnum
    {
        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "Card")]
        Card,

        /// <summary>
        /// Fleet.
        /// </summary>
        [EnumMember(Value = "Fleet")]
        Fleet
    }
}
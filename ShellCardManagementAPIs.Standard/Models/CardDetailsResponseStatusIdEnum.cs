// <copyright file="CardDetailsResponseStatusIdEnum.cs" company="APIMatic">
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
    /// CardDetailsResponseStatusIdEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum CardDetailsResponseStatusIdEnum
    {
        /// <summary>
        /// Enum1.
        /// </summary>
        Enum1 = 1,

        /// <summary>
        /// Enum7.
        /// </summary>
        Enum7 = 7,

        /// <summary>
        /// Enum8.
        /// </summary>
        Enum8 = 8,

        /// <summary>
        /// Enum9.
        /// </summary>
        Enum9 = 9,

        /// <summary>
        /// Enum10.
        /// </summary>
        Enum10 = 10,

        /// <summary>
        /// Enum23.
        /// </summary>
        Enum23 = 23,

        /// <summary>
        /// Enum31.
        /// </summary>
        Enum31 = 31,

        /// <summary>
        /// Enum41.
        /// </summary>
        Enum41 = 41,

        /// <summary>
        /// Enum42.
        /// </summary>
        Enum42 = 42,

        /// <summary>
        /// Enum43.
        /// </summary>
        Enum43 = 43,

        /// <summary>
        /// Enum101.
        /// </summary>
        Enum101 = 101,

        /// <summary>
        /// Enum102.
        /// </summary>
        Enum102 = 102,

        /// <summary>
        /// Enum103.
        /// </summary>
        Enum103 = 103,

        /// <summary>
        /// Enum104.
        /// </summary>
        Enum104 = 104,

        /// <summary>
        /// Enum105.
        /// </summary>
        Enum105 = 105,

        /// <summary>
        /// Enum106.
        /// </summary>
        Enum106 = 106,

        /// <summary>
        /// Enum107.
        /// </summary>
        Enum107 = 107,

        /// <summary>
        /// Enum108.
        /// </summary>
        Enum108 = 108
    }
}
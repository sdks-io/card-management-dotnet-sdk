// <copyright file="CardDetailAutoRenewEnum.cs" company="APIMatic">
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
    /// CardDetailAutoRenewEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum CardDetailAutoRenewEnum
    {
        /// <summary>
        /// Enum1.
        /// </summary>
        Enum1 = 1,

        /// <summary>
        /// Enum2.
        /// </summary>
        Enum2 = 2,

        /// <summary>
        /// Enum3.
        /// </summary>
        Enum3 = 3
    }
}
// <copyright file="CardDetailsResponseReissueSettingEnum.cs" company="APIMatic">
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
    /// CardDetailsResponseReissueSettingEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardDetailsResponseReissueSettingEnum
    {
        /// <summary>
        /// True.
        /// </summary>
        [EnumMember(Value = "True")]
        True,

        /// <summary>
        /// False.
        /// </summary>
        [EnumMember(Value = "False")]
        False
    }
}
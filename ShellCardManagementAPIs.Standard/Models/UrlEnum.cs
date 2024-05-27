// <copyright file="UrlEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using ShellCardManagementAPIs.Standard;
    using ShellCardManagementAPIs.Standard.Utilities;

    /// <summary>
    /// UrlEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UrlEnum
    {
        /// <summary>
        /// EnumApitestshellcomtest.
        /// </summary>
        [EnumMember(Value = "api-test.shell.com/test")]
        EnumApitestshellcomtest,

        /// <summary>
        /// EnumApishellcom.
        /// </summary>
        [EnumMember(Value = "api.shell.com")]
        EnumApishellcom
    }
}
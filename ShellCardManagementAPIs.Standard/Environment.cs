// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShellCardManagementAPIs.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// SIT.
        /// </summary>
        [EnumMember(Value = "SIT")]
        SIT,

        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "Production")]
        Production,
    }
}

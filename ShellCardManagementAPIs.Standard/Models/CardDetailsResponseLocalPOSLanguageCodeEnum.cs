// <copyright file="CardDetailsResponseLocalPOSLanguageCodeEnum.cs" company="APIMatic">
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
    /// CardDetailsResponseLocalPOSLanguageCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardDetailsResponseLocalPOSLanguageCodeEnum
    {
        /// <summary>
        /// Deu.
        /// </summary>
        [EnumMember(Value = "deu")]
        Deu,

        /// <summary>
        /// Fra.
        /// </summary>
        [EnumMember(Value = "fra")]
        Fra,

        /// <summary>
        /// Bul.
        /// </summary>
        [EnumMember(Value = "bul")]
        Bul,

        /// <summary>
        /// Hrv.
        /// </summary>
        [EnumMember(Value = "hrv")]
        Hrv,

        /// <summary>
        /// Ces.
        /// </summary>
        [EnumMember(Value = "ces")]
        Ces,

        /// <summary>
        /// Dan.
        /// </summary>
        [EnumMember(Value = "dan")]
        Dan,

        /// <summary>
        /// Fin.
        /// </summary>
        [EnumMember(Value = "fin")]
        Fin,

        /// <summary>
        /// Eng.
        /// </summary>
        [EnumMember(Value = "eng")]
        Eng,

        /// <summary>
        /// Ell.
        /// </summary>
        [EnumMember(Value = "ell")]
        Ell,

        /// <summary>
        /// Zho.
        /// </summary>
        [EnumMember(Value = "zho")]
        Zho,

        /// <summary>
        /// Hun.
        /// </summary>
        [EnumMember(Value = "hun")]
        Hun,

        /// <summary>
        /// Ita.
        /// </summary>
        [EnumMember(Value = "ita")]
        Ita,

        /// <summary>
        /// Ltz.
        /// </summary>
        [EnumMember(Value = "ltz")]
        Ltz,

        /// <summary>
        /// Msa.
        /// </summary>
        [EnumMember(Value = "msa")]
        Msa,

        /// <summary>
        /// Nld.
        /// </summary>
        [EnumMember(Value = "nld")]
        Nld,

        /// <summary>
        /// Nob.
        /// </summary>
        [EnumMember(Value = "nob")]
        Nob,

        /// <summary>
        /// Urd.
        /// </summary>
        [EnumMember(Value = "urd")]
        Urd,

        /// <summary>
        /// Pol.
        /// </summary>
        [EnumMember(Value = "pol")]
        Pol,

        /// <summary>
        /// Por.
        /// </summary>
        [EnumMember(Value = "por")]
        Por,

        /// <summary>
        /// Ron.
        /// </summary>
        [EnumMember(Value = "ron")]
        Ron,

        /// <summary>
        /// Rus.
        /// </summary>
        [EnumMember(Value = "rus")]
        Rus,

        /// <summary>
        /// Slk.
        /// </summary>
        [EnumMember(Value = "slk")]
        Slk,

        /// <summary>
        /// Slv.
        /// </summary>
        [EnumMember(Value = "slv")]
        Slv,

        /// <summary>
        /// Spa.
        /// </summary>
        [EnumMember(Value = "spa")]
        Spa,

        /// <summary>
        /// Swe.
        /// </summary>
        [EnumMember(Value = "swe")]
        Swe,

        /// <summary>
        /// Tur.
        /// </summary>
        [EnumMember(Value = "tur")]
        Tur,

        /// <summary>
        /// Tha.
        /// </summary>
        [EnumMember(Value = "tha")]
        Tha,

        /// <summary>
        /// Fil.
        /// </summary>
        [EnumMember(Value = "fil")]
        Fil,

        /// <summary>
        /// Est.
        /// </summary>
        [EnumMember(Value = "est")]
        Est,

        /// <summary>
        /// Lav.
        /// </summary>
        [EnumMember(Value = "lav")]
        Lav,

        /// <summary>
        /// Lit.
        /// </summary>
        [EnumMember(Value = "lit")]
        Lit
    }
}
// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Net;
using ShellCardManagementAPIs.Standard.Authentication;
using ShellCardManagementAPIs.Standard.Models;

namespace ShellCardManagementAPIs.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        IBasicAuthCredentials BasicAuthCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        BasicAuthModel BasicAuthModel { get; }

        /// <summary>
        /// Gets the credentials to use with BearerToken.
        /// </summary>
        IBearerTokenCredentials BearerTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with BearerToken.
        /// </summary>
        BearerTokenModel BearerTokenModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:SHELL.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Shell);
    }
}
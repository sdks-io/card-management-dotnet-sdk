// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard
{
    using System;
    using System.Net;
    using ShellCardManagementAPIs.Standard.Authentication;
    using ShellCardManagementAPIs.Standard.Models;

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
        /// Gets This variable specifies the type of environment. Environments:   * `api.shell.com` - Production   * `api-test.shell.com` - SIT
        /// </summary>
        Models.UrlEnum Url { get; }

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
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}
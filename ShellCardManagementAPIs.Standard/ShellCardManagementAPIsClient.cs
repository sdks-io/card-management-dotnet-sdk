// <copyright file="ShellCardManagementAPIsClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using ShellCardManagementAPIs.Standard.Authentication;
    using ShellCardManagementAPIs.Standard.Controllers;
    using ShellCardManagementAPIs.Standard.Http.Client;
    using ShellCardManagementAPIs.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class ShellCardManagementAPIsClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://{url}" },
                    { Server.AccessTokenServer, "https://api-test.shell.com/v1/oauth" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly Lazy<CustomerController> customer;
        private readonly Lazy<RestrictionController> restriction;
        private readonly Lazy<CardController> card;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private ShellCardManagementAPIsClient(
            Environment environment,
            Models.UrlEnum url,
            BasicAuthModel basicAuthModel,
            BearerTokenModel bearerTokenModel,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.Url = url;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            BearerTokenModel = bearerTokenModel;
            var bearerTokenManager = new BearerTokenManager(bearerTokenModel);
            bearerTokenManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BasicAuth", basicAuthManager},
                    {"BearerToken", bearerTokenManager},
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("url", ApiHelper.JsonSerialize(this.Url).Trim('\"'))))
                .UserAgent(userAgent)
                .Build();

            BasicAuthCredentials = basicAuthManager;
            BearerTokenCredentials = bearerTokenManager;

            this.customer = new Lazy<CustomerController>(
                () => new CustomerController(globalConfiguration));
            this.restriction = new Lazy<RestrictionController>(
                () => new RestrictionController(globalConfiguration));
            this.card = new Lazy<CardController>(
                () => new CardController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets CustomerController controller.
        /// </summary>
        public CustomerController CustomerController => this.customer.Value;

        /// <summary>
        /// Gets RestrictionController controller.
        /// </summary>
        public RestrictionController RestrictionController => this.restriction.Value;

        /// <summary>
        /// Gets CardController controller.
        /// </summary>
        public CardController CardController => this.card.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets Url.
        /// This variable specifies the type of environment. Environments:   * `api.shell.com` - Production   * `api-test.shell.com` - SIT.
        /// </summary>
        public Models.UrlEnum Url { get; }


        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with BearerToken.
        /// </summary>
        public IBearerTokenCredentials BearerTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerToken.
        /// </summary>
        public BearerTokenModel BearerTokenModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the ShellCardManagementAPIsClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .Url(this.Url)
                .HttpClientConfig(config => config.Build());

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            if (BearerTokenModel != null)
            {
                builder.BearerTokenCredentials(BearerTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"Url = {this.Url}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> ShellCardManagementAPIsClient.</returns>
        internal static ShellCardManagementAPIsClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_ENVIRONMENT");
            string url = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_URL");
            string username = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_USERNAME");
            string password = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_PASSWORD");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("SHELL_CARD_MANAGEMENT_AP_IS_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (url != null)
            {
                builder.Url(ApiHelper.JsonDeserialize<Models.UrlEnum>($"\"{url}\""));
            }

            if (username != null && password != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(username, password)
                .Build());
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.BearerTokenCredentials(new BearerTokenModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = ShellCardManagementAPIs.Standard.Environment.Production;
            private Models.UrlEnum url = Models.UrlEnum.EnumApitestshellcomtest;
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private BearerTokenModel bearerTokenModel = new BearerTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for BearerToken.
            /// </summary>
            /// <param name="bearerTokenModel">BearerTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerTokenCredentials(BearerTokenModel bearerTokenModel)
            {
                if (bearerTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(bearerTokenModel));
                }

                this.bearerTokenModel = bearerTokenModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets Url.
            /// </summary>
            /// <param name="url"> Url. </param>
            /// <returns> Builder. </returns>
            public Builder Url(Models.UrlEnum url)
            {
                this.url = url;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }


           

            /// <summary>
            /// Creates an object of the ShellCardManagementAPIsClient using the values provided for the builder.
            /// </summary>
            /// <returns>ShellCardManagementAPIsClient.</returns>
            public ShellCardManagementAPIsClient Build()
            {
                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                if (bearerTokenModel.OAuthClientId == null || bearerTokenModel.OAuthClientSecret == null)
                {
                    bearerTokenModel = null;
                }
                return new ShellCardManagementAPIsClient(
                    environment,
                    url,
                    basicAuthModel,
                    bearerTokenModel,
                    httpClientConfig.Build());
            }
        }
    }
}

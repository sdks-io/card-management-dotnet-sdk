
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Url` | `Models.UrlEnum` | This variable specifies the type of environment. Environments:<br><br>* `api.shell.com` - Production<br>* `api-test.shell.com` - SIT<br>*Default*: `UrlEnum.Enum_apitestshellcomtest` |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthCredentials` | [`BasicAuthCredentials`]($a/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| `BearerTokenCredentials` | [`BearerTokenCredentials`]($a/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
ShellCardManagementAPIs.Standard.ShellCardManagementAPIsClient client = new ShellCardManagementAPIs.Standard.ShellCardManagementAPIsClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .BearerTokenCredentials(
        new BearerTokenModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(ShellCardManagementAPIs.Standard.Environment.Production)
    .Url(UrlEnum.EnumApitestshellcomtest)
    .Build();
```

## Shell Card Management APIsClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| CustomerController | Gets CustomerController controller. |
| RestrictionController | Gets RestrictionController controller. |
| CardController | Gets CardController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| Url | This variable specifies the type of environment. Environments:   * `api.shell.com` - Production   * `api-test.shell.com` - SIT | `Models.UrlEnum` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`]($a/basic-authentication.md) |
| BearerTokenCredentials | Gets the credentials to use with BearerToken. | [`IBearerTokenCredentials`]($a/oauth-2-client-credentials-grant.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Shell Card Management APIsClient using the values provided for the builder. | `Builder` |

## Shell Card Management APIsClient Builder Class

Class to build instances of Shell Card Management APIsClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Url(Models.UrlEnum url)` | This variable specifies the type of environment. Environments:   * `api.shell.com` - Production   * `api-test.shell.com` - SIT | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |
| `BearerTokenCredentials(Action<BearerTokenModel.Builder> action)` | Sets credentials for BearerToken. | `Builder` |


using Atc.Azure.Options.Authorization;

namespace Atc.Azure.Options.Providers;

public interface IAzureCredentialOptionsProvider
{
    DefaultAzureCredentialOptions GetAzureCredentialOptions(
        EnvironmentOptions environmentOptions,
        ClientAuthorizationOptions authorizationOptions);

    DefaultAzureCredentialOptions GetAzureCredentialOptions(
        EnvironmentOptions environmentOptions,
        string tenantId);
}

namespace Atc.Azure.Options.Providers;

public class AzureCredentialOptionsProvider : IAzureCredentialOptionsProvider
{
    public DefaultAzureCredentialOptions GetAzureCredentialOptions(
        EnvironmentOptions environmentOptions,
        ClientAuthorizationOptions authorizationOptions)
        => GetAzureCredentialOptions(environmentOptions, authorizationOptions.TenantId);

    public DefaultAzureCredentialOptions GetAzureCredentialOptions(
        EnvironmentOptions environmentOptions,
        string tenantId)
        => new ()
        {
            SharedTokenCacheTenantId = tenantId,
            VisualStudioTenantId = tenantId,
            VisualStudioCodeTenantId = tenantId,
            ExcludeManagedIdentityCredential = environmentOptions.EnvironmentType == EnvironmentType.Local,
            ExcludeAzurePowerShellCredential = true,
            ExcludeInteractiveBrowserCredential = true,
            ExcludeEnvironmentCredential = true,
        };
}
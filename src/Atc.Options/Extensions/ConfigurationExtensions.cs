using Atc.Options.Environment;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace Atc.Options.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureKeyVaultForApi(this IConfigurationBuilder config)
        {
            var buildConfig = config.Build();
            var serviceOptions = new ServiceOptions();
            buildConfig.Bind(serviceOptions.SectionName, serviceOptions);

            var tokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));
            config.AddAzureKeyVault(serviceOptions.GetKeyVault(), keyVaultClient, new DefaultKeyVaultSecretManager());
        }
    }
}
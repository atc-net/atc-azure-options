using System.Diagnostics.CodeAnalysis;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace Atc.Azure.Options.Extensions
{
    public static class ConfigurationExtensions
    {
        [SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The AKV provider will dispose of any objects that it creates on its own.")]
        public static void ConfigureKeyVaultForApi(this IConfigurationBuilder config, string configurationSectionName)
        {
            var buildConfig = config.Build();
            var serviceOptions = new ServiceOptions();
            buildConfig.Bind(configurationSectionName, serviceOptions);

            var tokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));
            config.AddAzureKeyVault(serviceOptions.GetKeyVault(), keyVaultClient, new DefaultKeyVaultSecretManager());
        }
    }
}
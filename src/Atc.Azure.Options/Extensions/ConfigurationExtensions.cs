using System.Diagnostics.CodeAnalysis;
using Atc.Azure.Options.Environment;
using Atc.Azure.Options.Providers;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace Atc.Azure.Options.Extensions
{
    public static class ConfigurationExtensions
    {
        [SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The AKV provider will dispose of any objects that it creates on its own.")]
        public static void ConfigureKeyVaultForApi(
            this IConfigurationBuilder config,
            INamingProvider namingProvider,
            string environmentOptionsSectionName = nameof(EnvironmentOptions),
            string namingOptionsSectionName = nameof(NamingOptions))
        {
            var buildConfig = config.Build();

            var environmentOptions = new EnvironmentOptions();
            buildConfig.Bind(environmentOptionsSectionName, environmentOptions);

            var namingOptions = new NamingOptions();
            buildConfig.Bind(namingOptionsSectionName, namingOptions);

            var tokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));
            config.AddAzureKeyVault(environmentOptions.GetKeyVault(namingOptions, namingProvider), keyVaultClient, new DefaultKeyVaultSecretManager());
        }
    }
}
using System;
using Atc.Azure.Options.Environment;
using Atc.Azure.Options.Providers;
using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace Atc.Azure.Options.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureKeyVault(this IConfigurationBuilder config, DefaultAzureCredentialOptions defaultAzureCredentialOptions)
            => ConfigureKeyVault(config, defaultAzureCredentialOptions, new NamingProvider());

        public static void ConfigureKeyVault(
            this IConfigurationBuilder config,
            DefaultAzureCredentialOptions defaultAzureCredentialOptions,
            INamingProvider namingProvider,
            string environmentOptionsSectionName = nameof(EnvironmentOptions),
            string namingOptionsSectionName = nameof(NamingOptions))
        {
            var buildConfig = config.Build();

            var environmentOptions = new EnvironmentOptions();
            buildConfig.Bind(environmentOptionsSectionName, environmentOptions);

            var namingOptions = new NamingOptions();
            buildConfig.Bind(namingOptionsSectionName, namingOptions);

            config.AddAzureKeyVault(
                new Uri(environmentOptions.GetKeyVault(namingOptions, namingProvider)),
                new DefaultAzureCredential(defaultAzureCredentialOptions));
        }
    }
}
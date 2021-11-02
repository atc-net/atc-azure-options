using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Extensions
{
    public static class EnvironmentOptionsExtensions
    {
        public static string GetKeyVault(this EnvironmentOptions options, NamingOptions namingOptions)
            => $"https://{options.GetResourceName(namingOptions)}.vault.azure.net";

        public static string GetResourceName(this EnvironmentOptions options, NamingOptions namingOptions)
            => string.Concat(namingOptions.CompanyAbbreviation, namingOptions.SystemAbbreviation, options.EnvironmentName, namingOptions.ServiceAbbreviation);
    }
}
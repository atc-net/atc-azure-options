using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Providers
{
    public class NamingProvider : INamingProvider
    {
        public string GetResourceName(EnvironmentOptions options, NamingOptions namingOptions)
            => GetResourceName(options, namingOptions, string.Empty);

        public string GetResourceName(EnvironmentOptions options, NamingOptions namingOptions, string suffix)
            => string.Concat(
                namingOptions.CompanyAbbreviation,
                namingOptions.SystemAbbreviation,
                options.EnvironmentName,
                namingOptions.ServiceAbbreviation,
                suffix);
    }
}
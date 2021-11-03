using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Providers
{
    public class NamingProvider : INamingProvider
    {
        public string GetResourceName(EnvironmentOptions options, NamingOptions namingOptions)
            => string.Concat(
                namingOptions.CompanyAbbreviation,
                namingOptions.SystemAbbreviation,
                options.EnvironmentName,
                namingOptions.ServiceAbbreviation);
    }
}
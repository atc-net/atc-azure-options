using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Providers
{
    public interface INamingProvider
    {
        string GetResourceName(EnvironmentOptions options, NamingOptions namingOptions);
    }
}
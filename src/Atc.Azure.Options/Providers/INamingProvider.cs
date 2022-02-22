namespace Atc.Azure.Options.Providers;

public interface INamingProvider
{
    string GetResourceName(
        EnvironmentOptions options,
        NamingOptions namingOptions);

    string GetResourceName(
        EnvironmentOptions options,
        NamingOptions namingOptions,
        string suffix);
}
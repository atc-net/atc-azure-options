namespace Atc.Azure.Options.Extensions;

public static class EnvironmentOptionsExtensions
{
    public static string GetKeyVault(this EnvironmentOptions options, NamingOptions namingOptions)
        => GetKeyVault(options, namingOptions, new NamingProvider());

    public static string GetKeyVault(this EnvironmentOptions options, NamingOptions namingOptions, INamingProvider namingProvider)
        => $"https://{namingProvider.GetResourceName(options, namingOptions)}.vault.azure.net";
}
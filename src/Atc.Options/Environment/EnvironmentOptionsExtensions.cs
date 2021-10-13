namespace Atc.Options.Environment
{
    public static class EnvironmentOptionsExtensions
    {
        public static string GetKeyVault(this EnvironmentOptions options)
            => $"https://{options.GetResourceName()}.vault.azure.net";

        public static string GetResourceName(this EnvironmentOptions options)
            => string.Concat(options.CompanyAbbreviation, options.SystemAbbreviation, options.EnvironmentName, options.ServiceAbbreviation);
    }
}
using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options
{
    public partial class ServiceOptions
    {
        public string ApplicationInsightsInstrumentationKey { get; set; } = string.Empty;

        public EnvironmentOptions EnvironmentOptions { get; set; } = new EnvironmentOptions();

        public NamingOptions NamingOptions { get; set; } = new NamingOptions();
    }
}
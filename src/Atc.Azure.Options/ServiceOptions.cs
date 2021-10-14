using Atc.Azure.Options.Cosmos;

namespace Atc.Azure.Options
{
    public class ServiceOptions : CosmosOptions
    {
        public string ApplicationInsightsInstrumentationKey { get; set; } = string.Empty;
    }
}
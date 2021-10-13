using Atc.Options.Environment;

namespace Atc.Options.Cosmos
{
    public class CosmosOptions : EnvironmentOptions
    {
        public string CosmosDbKey { get; set; } = string.Empty;
    }
}
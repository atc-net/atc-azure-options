using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Cosmos
{
    public class CosmosOptions : EnvironmentOptions
    {
        public string CosmosDbKey { get; set; } = string.Empty;
    }
}
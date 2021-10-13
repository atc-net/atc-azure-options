using Atc.Azure.Options.Cosmos;
using Atc.Azure.Options.Environment;

namespace Atc.Azure.Options.Extensions
{
    public static class CosmosOptionsExtensions
    {
        private const string LocalAccountAuthKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        public static string GetCosmosAuthKey(this CosmosOptions options)
            => options.EnvironmentType == EnvironmentType.Local
                ? LocalAccountAuthKey
                : options.CosmosDbKey;

        public static string GetCosmosDbEndpoint(this CosmosOptions options)
            => options.EnvironmentType == EnvironmentType.Local
                ? "https://localhost:8081"
                : $"https://{options.GetResourceName()}.documents.azure.com:443/";
    }
}
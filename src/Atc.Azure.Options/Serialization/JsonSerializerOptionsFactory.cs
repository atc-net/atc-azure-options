using System.Text.Json;
using System.Text.Json.Serialization;

namespace Atc.Azure.Options.Serialization
{
    public static class JsonSerializerOptionsFactory
    {
        private static JsonSerializerOptions? jsonSerializerOptions;

        public static JsonSerializerOptions Create()
        {
            if (jsonSerializerOptions is not null)
            {
                return jsonSerializerOptions;
            }

            jsonSerializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultBufferSize = 50000,
                Converters =
                {
                    new JsonStringEnumConverter(),
                },
            };
            return jsonSerializerOptions;
        }
    }
}
using System;
using Atc.Azure.Options.Cosmos;

namespace Atc.Azure.Options
{
    public class ServiceOptions : CosmosOptions
    {
        public readonly string SectionName;

        public ServiceOptions(string sectionName = "ServiceOptions")
        {
            SectionName = sectionName ?? throw new ArgumentNullException(nameof(sectionName));
        }

        public string ApplicationInsightsInstrumentationKey { get; set; } = string.Empty;
    }
}
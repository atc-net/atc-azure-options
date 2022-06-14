namespace Atc.Azure.Options;

/// <summary>
/// This implementation of ServiceOptions is a minimal approach made partial that project implementations to extend.
/// </summary>
public partial class ServiceOptions
{
    public string ApplicationInsightsConnectionString { get; set; } = string.Empty;

    [Obsolete("ApplicationInsightsConnectionString should be used instead - see https://docs.microsoft.com/en-us/azure/azure-monitor/app/sdk-connection-string?tabs=net")]
    public string ApplicationInsightsInstrumentationKey { get; set; } = string.Empty;

    public string TenantId { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(ApplicationInsightsConnectionString)}: {ApplicationInsightsConnectionString}, {nameof(TenantId)}: {TenantId}";
}
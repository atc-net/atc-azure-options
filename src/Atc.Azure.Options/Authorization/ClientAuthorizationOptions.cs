namespace Atc.Azure.Options.Authorization;

public class ClientAuthorizationOptions
{
    public string TenantId { get; set; } = string.Empty;

    public string Instance { get; set; } = string.Empty;

    public string ClientId { get; set; } = string.Empty;

    public string Audience { get; set; } = string.Empty;

    public string ClientSecret { get; set; } = string.Empty;

    public string? ClientBaseAddress { get; set; }

    public override string ToString()
        => $"{nameof(TenantId)}: {TenantId}, {nameof(Instance)}: {Instance}, {nameof(ClientId)}: {ClientId}, {nameof(Audience)}: {Audience}, {nameof(ClientSecret)}: {ClientSecret}, {nameof(ClientBaseAddress)}: {ClientBaseAddress}";
}
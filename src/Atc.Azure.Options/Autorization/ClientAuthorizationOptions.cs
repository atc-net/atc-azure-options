namespace Atc.Azure.Options.Autorization
{
    public class ClientAuthorizationOptions
    {
        public string TenantId { get; set; } = string.Empty;

        public string Instance { get; set; } = string.Empty;

        public string ClientId { get; set; } = string.Empty;

        public string Audience { get; set; } = string.Empty;

        public string ClientSecret { get; set; } = string.Empty;

        public string? ClientBaseAddress { get; set; }
    }
}
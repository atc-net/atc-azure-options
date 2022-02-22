namespace Atc.Azure.Options.IotHub;

public class IotHubOptions
{
    public string ConnectionString { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(ConnectionString)}: {ConnectionString}";
}
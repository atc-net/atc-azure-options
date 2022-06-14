namespace Atc.Azure.Options.ServiceBus;

public class ServiceBusOptions
{
    public string ConnectionString { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(ConnectionString)}: {ConnectionString}";
}
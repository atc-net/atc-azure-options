namespace Atc.Azure.Options.ServiceBus;

public class ServiceBusOptions
{
    public string Name { get; set; } = string.Empty;

    public string ConnectionString { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(ConnectionString)}: {ConnectionString}";
}
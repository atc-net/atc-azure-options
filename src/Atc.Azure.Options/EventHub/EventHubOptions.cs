namespace Atc.Azure.Options.EventHub;

public class EventHubOptions
{
    public string Name { get; set; } = string.Empty;

    public string ConnectionString { get; set; } = string.Empty;

    public string FullyQualifiedNamespace { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(ConnectionString)}: {ConnectionString}, {nameof(FullyQualifiedNamespace)}: {FullyQualifiedNamespace}";
}
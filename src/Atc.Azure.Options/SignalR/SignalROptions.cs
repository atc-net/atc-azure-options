namespace Atc.Azure.Options.SignalR;

public class SignalROptions
{
    public string ConnectionString { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(ConnectionString)}: {ConnectionString}";
}
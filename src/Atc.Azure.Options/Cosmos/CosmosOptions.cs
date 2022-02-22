namespace Atc.Azure.Options.Cosmos;

public class CosmosOptions
{
    public string CosmosDbKey { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(CosmosDbKey)}: {CosmosDbKey}";
}
namespace Atc.Azure.Options.StorageAccount;

public class StorageAccountOptions
{
    public const string DefaultConnectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;";

    /// <summary>
    /// The ConnectionString for the StorageAccount.
    /// </summary>
    /// <remarks>
    /// This is used for the old approach where a ConnectionString needs to be supplied.
    /// </remarks>
    public string ConnectionString { get; set; } = string.Empty;

    public string ContainerName { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(ConnectionString)}: {ConnectionString}, {nameof(ContainerName)}: {ContainerName}";
}
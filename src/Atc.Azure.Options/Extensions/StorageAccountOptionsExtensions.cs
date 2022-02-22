namespace Atc.Azure.Options.Extensions;

public static class StorageAccountOptionsExtensions
{
    public const string StorageHostNameSuffix = "core.windows.net";

    /// <summary>
    /// Gets the ConnectionString for Storage Account.
    /// </summary>
    /// <param name="storageAccountOptions">The <see cref="StorageAccountOptions"/>.</param>
    /// <param name="environmentType">The <see cref="EnvironmentType"/>.</param>
    /// <returns>The default ConnectionString if environment is Local, otherwise the ConnectionString from the StorageAccountOptions.</returns>
    /// <remarks>
    /// This is used for the old approach where a ConnectionString needs to be supplied. <br />
    /// The new approach <see cref="GetBlobContainerUri"/> is to connect directly to the <see cref="Uri"/> using a managed identity.
    /// </remarks>
    public static string GetConnectionString(
        this StorageAccountOptions storageAccountOptions,
        EnvironmentType environmentType)
        => environmentType == EnvironmentType.Local
            ? StorageAccountOptions.DefaultConnectionString
            : $"{storageAccountOptions.ConnectionString}";

    /// <summary>
    /// Gets the Blob Service Uri.
    /// </summary>
    /// <param name="storageAccountOptions">The <see cref="StorageAccountOptions"/>.</param>
    /// <param name="resourceName">The name of the resource.</param>
    /// <returns>An <see cref="Uri"/> to the blob service.</returns>
    /// <exception cref="ArgumentException">If resourceName is not provided.</exception>
    public static Uri GetBlobServiceUri(
        this StorageAccountOptions storageAccountOptions,
        string resourceName)
    {
        if (string.IsNullOrWhiteSpace(resourceName))
        {
            throw new ArgumentException("Value is null or empty", nameof(resourceName));
        }

        return new Uri($"https://{resourceName}.blob.{StorageHostNameSuffix}");
    }

    /// <summary>
    /// Gets the Blob Container Uri.
    /// </summary>
    /// <param name="storageAccountOptions">The <see cref="StorageAccountOptions"/>.</param>
    /// <param name="resourceName">The name of the resource.</param>
    /// <returns>An <see cref="Uri"/> to the blob container.</returns>
    /// <exception cref="ArgumentException">If resourceName is not provided.</exception>
    /// <exception cref="InvalidOperationException">If ContainerName is not filled out.</exception>
    public static Uri GetBlobContainerUri(
        this StorageAccountOptions storageAccountOptions,
        string resourceName)
    {
        if (string.IsNullOrWhiteSpace(resourceName))
        {
            throw new ArgumentException("Value is null or empty", nameof(resourceName));
        }

        if (string.IsNullOrWhiteSpace(storageAccountOptions.ContainerName))
        {
            throw new InvalidOperationException($"The {nameof(storageAccountOptions.ContainerName)} is not set.");
        }

        return new Uri($"https://{resourceName}.blob.{StorageHostNameSuffix}/{storageAccountOptions.ContainerName}");
    }
}
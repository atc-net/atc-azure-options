namespace Atc.Azure.Options.StorageAccount
{
    public class StorageAccountOptions
    {
        public const string SectionName = "StorageAccountOptions";

        public string StorageConnectionString { get; set; } = string.Empty;

        public string StorageContainerName { get; set; } = string.Empty;
    }
}
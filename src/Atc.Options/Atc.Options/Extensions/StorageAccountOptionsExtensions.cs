using Atc.Options.Environment;
using Atc.Options.StorageAccount;

namespace Atc.Options.Extensions
{
    public static class StorageAccountOptionsExtensions
    {
        public static string GetConnectionString(this StorageAccountOptions storageAccountOptions, EnvironmentType environmentType)
            => environmentType == EnvironmentType.Local
                ? $"DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;"
                : $"{storageAccountOptions.StorageConnectionString}";
    }
}
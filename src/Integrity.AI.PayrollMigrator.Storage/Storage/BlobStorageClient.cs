using Azure.Storage.Blobs;

namespace Integrity.AI.PayrollMigrator.Storage.Storage;

public class BlobStorageClient
{
    private readonly BlobContainerClient _container;

    public BlobStorageClient(BlobContainerClient container)
    {
        _container = container;
    }

    public async Task UploadJsonAsync(string companyId, string filename, string jsonContent)
    {
        var blob = _container.GetBlobClient($"{companyId}/{filename}");
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonContent));
        await blob.UploadAsync(stream, overwrite: true);
    }

    public async Task<string> DownloadJsonAsync(string path)
    {
        var blob = _container.GetBlobClient(path);
        var download = await blob.DownloadContentAsync();
        return download.Value.Content.ToString();
    }
}

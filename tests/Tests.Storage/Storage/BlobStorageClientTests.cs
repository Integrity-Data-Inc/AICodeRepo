using Azure.Storage.Blobs;
using Integrity.AI.PayrollMigrator.Storage.Storage;
using Xunit;

public class BlobStorageClientTests
{
    [Fact]
    public async Task UploadDownload_RoundTrip()
    {
        var container = new BlobContainerClient("UseDevelopmentStorage=true", "test");
        var client = new BlobStorageClient(container);
        await client.UploadJsonAsync("1", "test.json", "{}");
        var content = await client.DownloadJsonAsync("1/test.json");
        Assert.Equal("{}", content);
    }
}
